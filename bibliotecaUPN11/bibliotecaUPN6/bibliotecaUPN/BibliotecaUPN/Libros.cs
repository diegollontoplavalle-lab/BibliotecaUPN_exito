using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaUPN
{
    public partial class frmLibros : Form
    {
        // Declaramos una lista global para almacenar los libros leídos
        private List<string[]> listalibros = new List<string[]>();
        private string codigoSeleccionado = "";
        private string rutaLibros = @"C:\Users\piero\OneDrive\Escritorio\bibliotecaUPN\LIbros.csv.txt";

        public string CodigoSeleccionado
        {
            get { return codigoSeleccionado; }
        }

        public frmLibros()
        {
            InitializeComponent();

            txtBuscar.Text = "Buscar libro";
            txtBuscar.ForeColor = Color.Gray;

            txtBuscar.Enter += (s, ev) =>
            {
                if (txtBuscar.Text == "Buscar libro")
                {
                    txtBuscar.Text = "";
                    txtBuscar.ForeColor = Color.Black;
                }
            };

            txtBuscar.Leave += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    txtBuscar.Text = "Buscar libro";
                    txtBuscar.ForeColor = Color.Gray;
                }
            };
            btnseleccionar.Enabled = false;
            dgvlibrosalmacen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvlibrosalmacen.MultiSelect = false;

        }

        private void Libros_Load(object sender, EventArgs e)
        {
            ConfigurarColumnasGrilla();
            CargarArchivoCSV();
            ConfigurarCombobox();
        }

        private void ConfigurarColumnasGrilla()
        {
            // Configurar columnas una sola vez para evitar duplicados
            dgvlibrosalmacen.Columns.Clear();
            dgvlibrosalmacen.Columns.Add("Carrera", "Carrera");
            dgvlibrosalmacen.Columns.Add("Codigo", "Código");
            dgvlibrosalmacen.Columns.Add("Titulo", "Título del Libro"); // Corregido el espacio extra
            dgvlibrosalmacen.Columns.Add("Autor", "Autor");
            dgvlibrosalmacen.Columns.Add("Anio", "Año de publicación");
            dgvlibrosalmacen.Columns.Add("Auditoria", "Auditoría");

            dgvlibrosalmacen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void CargarArchivoCSV()
        {
            string ruta = @"C:\Users\piero\OneDrive\Escritorio\bibliotecaUPN\LIbros.csv.txt";
            listalibros.Clear();
            dgvlibrosalmacen.Rows.Clear();

            try
            {
                if (!File.Exists(ruta))
                {
                    MessageBox.Show("No se encontró el archivo de libros.", "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (StreamReader lector = new StreamReader(rutaLibros))
                {
                    string linea;

                    while ((linea = lector.ReadLine()) != null)
                    {
                        // Omitimos líneas vacías o que no contengan el separador '|'
                        if (string.IsNullOrWhiteSpace(linea) || !linea.Contains("|"))
                        {
                            continue;
                        }

                        // Separamos los datos por el delimitador '|'
                        string[] datos = linea.Split('|');

                        // Quitamos espacios en blanco extra en cada campo
                        for (int i = 0; i < datos.Length; i++)
                        {
                            datos[i] = datos[i].Trim();
                        }

                        listalibros.Add(datos);
                    }

                    var librosOrdenados = listalibros
                        .OrderBy(libro => libro[0])
                        .ThenBy(libro => libro[1]);

                    foreach (var libro in librosOrdenados)
                    {
                        dgvlibrosalmacen.Rows.Add(libro);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo de libros: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarLibros(IEnumerable<string[]> libros)
        {
            dgvlibrosalmacen.Rows.Clear();

            foreach (string[] libro in libros.OrderBy(l => l[0]).ThenBy(l => l[1]))
            {
                dgvlibrosalmacen.Rows.Add(libro);
            }

            btnseleccionar.Enabled = false;
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (dgvlibrosalmacen.SelectedRows.Count > 0)
            {
                // Extraemos el código de la columna "Codigo" de la fila seleccionada
                codigoSeleccionado = dgvlibrosalmacen.SelectedRows[0].Cells["Codigo"].Value.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dgvlibrosalmacen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvlibrosalmacen.ClearSelection();
                dgvlibrosalmacen.Rows[e.RowIndex].Selected = true;
                btnseleccionar.Enabled = true; // Habilita el botón solo cuando se selecciona una fila válida
            }
        }

        private void ConfigurarCombobox()
        {
            if (cboCarrera.Items.Count == 0)
            {
                cboCarrera.Items.Add("Ingeniería Industrial");
                cboCarrera.Items.Add("Ingeniería de Sistemas Computacionales");
                cboCarrera.Items.Add("Ingeniería Civil");
                cboCarrera.Items.Add("Ingenieria ambiental");
                cboCarrera.Items.Add("Ingeniería de Software");
                cboCarrera.Items.Add("Ingeniería de Minas ");
                cboCarrera.Items.Add("Administración");
                cboCarrera.Items.Add("Adminitracion y Negocios Internacionales");
                cboCarrera.Items.Add("Contabilidad y Finanzas");
                cboCarrera.Items.Add("Administración y Marketing");

                cboCarrera.SelectedIndex = 1;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string carrera = cboCarrera.Text;
            string codigo = txtCodigo.Text;
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;
            string año = txtAño.Text;
            string auditoria = txtAuditoria.Text;

            string patronCodigo = @"^[A-Z]{2,6}-[0-9]{3}\z";
            if (!Regex.IsMatch(codigo, patronCodigo))
            {
                MessageBox.Show("El CÓDIGO inválida. Ejemplo válido: AGT-001", "Formato CÓDIGO incorrecto ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Focus();
                return;
            }
            string patronFecha = @"^(19[0-9]{2}|20[01][0-9]|202[0-6])\z";
            if (!Regex.IsMatch(año, patronFecha))
            {
                MessageBox.Show("El CÓDIGO inválida. Ejemplo válido: 2026", "Formato fecha incorrecto ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Focus();
                return;
            }


            if (!System.Text.RegularExpressions.Regex.IsMatch(codigo, @"^[A-Z]{2,6}-[0-9]{3}\z"))
            {
                MessageBox.Show("No se permite símbolos", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Focus();
                return;
            }

            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Ingrese la Carrera.", "Campo vacio ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(titulo))
            {
                MessageBox.Show("Ingrese la Carrera.", "Campo vacio ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTitulo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(autor))
            {
                MessageBox.Show("Ingrese la Carrera.", "Campo vacio ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAutor.Focus();
                return;
            }
            if (string.IsNullOrEmpty(año))
            {
                MessageBox.Show("Ingrese la Carrera.", "Campo vacio ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAño.Focus();
                return;
            }
            if (string.IsNullOrEmpty(auditoria))
            {
                MessageBox.Show("Ingrese la Carrera.", "Campo vacio ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAuditoria.Focus();
                return;
            }
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(rutaLibros));
                string nuevaLinea = carrera + "|" + codigo.ToUpper() + "|" + titulo + "|" + autor + "|" + año + "|" + auditoria ;
                File.AppendAllText(rutaLibros, nuevaLinea + Environment.NewLine);

                MessageBox.Show($"El libro {titulo} con el codigo {codigo} ha sido registrado con exito", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarArchivoCSV();

                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Limpiar()
        {
            
            txtCodigo.Clear();
            txtTitulo.Clear();
            txtAutor.Clear();
            txtAño.Clear();
            txtAuditoria.Clear();
           
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar libro")
            {
                MostrarLibros(listalibros);
                return;
            }

            string texto = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(texto))
            {
                MostrarLibros(listalibros);
                return;
            }

            var filtrados = listalibros.Where(libro =>
                libro.Any(campo => campo != null && campo.ToLower().Contains(texto)));

            MostrarLibros(filtrados);
        }
    }
}