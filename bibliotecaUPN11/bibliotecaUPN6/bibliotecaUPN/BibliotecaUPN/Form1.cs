using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BibliotecaUPN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            if (dtpPrestamo != null)
            {
                dtpPrestamo.Value = DateTime.Today;
                // Conectamos el evento para que calcule los 7 días automáticamente
                dtpPrestamo.ValueChanged -= dtpPrestamo_ValueChanged;
                dtpPrestamo.ValueChanged += dtpPrestamo_ValueChanged;
            }

            if (dtpDevolucion != null && dtpPrestamo != null)
            {
                dtpDevolucion.Value = dtpPrestamo.Value.AddDays(7);
            }

            txtCodigoEstudiante.Text = "N00";
            txtCodigoprestamo.Text = GestorArchivo.ObtenerSiguienteCodigo();
            ConfigurarComboBox();
        }

        private void ConfigurarComboBox()
        {
            if (cboEstado.Items.Count == 0)
            {
                cboEstado.Items.Add("Activo");
                cboEstado.Items.Add("Pendiente");
                cboEstado.Items.Add("Devuelto");
                cboEstado.SelectedIndex = 1;
            }
        }

        private void txtCodigoEstudiante_TextChanged(object sender, EventArgs e)
        {
            if (!txtCodigoEstudiante.Text.StartsWith("N00"))
            {
                txtCodigoEstudiante.Text = "N00";
                txtCodigoEstudiante.SelectionStart = txtCodigoEstudiante.Text.Length;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLibros miforma = new frmLibros();
            if (miforma.ShowDialog() == DialogResult.OK)
            {
                txtCodigolibro.Text = miforma.CodigoSeleccionado;
            }
        }

        // REGISTRAR CON TUS VALIDACIONES EXACTAS
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string codPre = txtCodigoprestamo.Text;
            string codigoEstudiante = txtCodigoEstudiante.Text;
            string nombre = txtnombrestudi.Text;
            string codLib = txtCodigolibro.Text;
            string estado = cboEstado.Text;

            string fPre = dtpPrestamo != null ? dtpPrestamo.Value.ToString("dd/MM/yyyy") : DateTime.Today.ToString("dd/MM/yyyy");
            string fDev = dtpDevolucion != null ? dtpDevolucion.Value.ToString("dd/MM/yyyy") : DateTime.Today.AddDays(7).ToString("dd/MM/yyyy");

            // Tus validaciones exactas de la imagen de referencia:
            string patronForamtoUPN = @"^[Nn]00\d{6}$";
            if (!Regex.IsMatch(codigoEstudiante, patronForamtoUPN))
            {
                MessageBox.Show("El código de ESTUDIANTE inválida. Ejemplo válido: N00123456", "Formato UPN Incorrecto ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigoEstudiante.Focus();
                return;
            }

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingrese el nombre del estudiante.", "Campo vacio ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnombrestudi.Focus();
                return;
            }

            if (nombre.Length <= 3)
            {
                MessageBox.Show("Ingrese un nombre mayor a tres digitos y menor a diez", "Campo de Validación ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtnombrestudi.Focus();
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(nombre, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                MessageBox.Show("No se permite símbolos", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnombrestudi.Focus();
                return;
            }

            if (string.IsNullOrEmpty(codLib))
            {
                MessageBox.Show("Seleccione un libro.", "Atención ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(GestorArchivo.ruta));
                string nuevaLinea = codPre + "|" + codigoEstudiante.ToUpper() + "|" + nombre + "|" + codLib + "|" + fPre + "|" + fDev + "|" + estado;
                File.AppendAllText(GestorArchivo.ruta, nuevaLinea + Environment.NewLine);

                MessageBox.Show($"Préstamo {codPre} del libro {codLib} registrado exitosamente para el estudiante {nombre}.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abre el formulario con la tabla
                new Frmregistro(codPre, codigoEstudiante, nombre, codLib, fPre, fDev, estado).ShowDialog();

                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message,"Error ",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // VER PRÉSTAMO
        private void btnverestado_Click(object sender, EventArgs e)
        {
            string buscar = txtCodigoprestamo.Text;
            if (string.IsNullOrEmpty(buscar)) { MessageBox.Show("Ingrese un código para buscar."); return; }

            string[] datos = GestorArchivo.BuscarPrestamo(buscar);

            if (datos != null)
            {
                txtCodigoprestamo.Text = datos[0].Trim();
                txtCodigoEstudiante.Text = datos[1].Trim();
                txtnombrestudi.Text = datos[2].Trim();
                txtCodigolibro.Text = datos[3].Trim();

                if (dtpPrestamo != null && DateTime.TryParse(datos[4], out DateTime parsedPre))
                    dtpPrestamo.Value = parsedPre;

                if (dtpDevolucion != null && DateTime.TryParse(datos[5], out DateTime parsedDev))
                    dtpDevolucion.Value = parsedDev;

                cboEstado.Text = datos[6].Trim();

                MessageBox.Show("Préstamo encontrado y cargado.","Préstamo seleccionado ",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró el préstamo.","Error de Préstamo ",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ACTUALIZAR ESTADO
        private void btnActualizarestado_Click(object sender, EventArgs e)
        {
            string buscar = txtCodigoprestamo.Text;
            if (string.IsNullOrEmpty(buscar)) { MessageBox.Show("Ingrese el código a actualizar."); return; }

            if (!File.Exists(GestorArchivo.ruta)) return;

            string[] lineas = File.ReadAllLines(GestorArchivo.ruta);
            bool actualizado = false;
            string codPre = "", codEst = "", nombre = "", codLib = "", fPre = "", fDev = "", estado = "";

            for (int i = 0; i < lineas.Length; i++)
            {
                if (lineas[i].Contains("|"))
                {
                    string[] datos = lineas[i].Split('|');
                    if (datos[0].Trim().TrimStart('0') == buscar.TrimStart('0'))
                    {
                        datos[1] = txtCodigoEstudiante.Text.Trim().ToUpper();
                        datos[2] = txtnombrestudi.Text.Trim();
                        datos[3] = txtCodigolibro.Text.Trim();

                        if (dtpPrestamo != null) datos[4] = dtpPrestamo.Value.ToString("dd/MM/yyyy");
                        if (dtpDevolucion != null) datos[5] = dtpDevolucion.Value.ToString("dd/MM/yyyy");

                        datos[6] = cboEstado.Text.Trim(); // Nuevo estado

                        codPre = datos[0].Trim();
                        codEst = datos[1].Trim();
                        nombre = datos[2].Trim();
                        codLib = datos[3].Trim();
                        fPre = datos[4].Trim();
                        fDev = datos[5].Trim();
                        estado = datos[6].Trim();

                        lineas[i] = string.Join("|", datos);
                        actualizado = true;
                        break;
                    }
                }
            }

            if (actualizado)
            {
                File.WriteAllLines(GestorArchivo.ruta, lineas);
                MessageBox.Show("El estado se actualizó con éxito.","Actulización exitosa " , MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abre el formulario con la lista (DataGridView)
                new Frmregistro(codPre, codEst, nombre, codLib, fPre, fDev, estado).ShowDialog();
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se encontró el registro para actualizar.", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            txtCodigoEstudiante.Text = "N00";
            txtnombrestudi.Clear();
            txtCodigolibro.Clear();
            if (dtpPrestamo != null) dtpPrestamo.Value = DateTime.Today;
            if (dtpDevolucion != null && dtpPrestamo != null) dtpDevolucion.Value = dtpPrestamo.Value.AddDays(7);
            cboEstado.SelectedIndex = 1;
            txtCodigoprestamo.Text = GestorArchivo.ObtenerSiguienteCodigo();
            txtCodigoEstudiante.Focus();
        }

        // EVENTO AUTOMÁTICO DE LOS 7 DÍAS EN LA DEVOLUCIÓN
        private void dtpPrestamo_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDevolucion != null && dtpPrestamo != null)
            {
                dtpDevolucion.Value = dtpPrestamo.Value.AddDays(7);
            }
        }
    }
}