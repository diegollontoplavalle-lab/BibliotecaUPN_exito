using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaUPN
{
    public partial class Frmregistro : Form
    {
        private List<string[]> registro = new List<string[]>();

        // Variables globales para guardar temporalmente los datos recibidos por el constructor
        private string _codigoPre, _codigoLib, _codigoEst, _fechaPre, _fechaDev, _estado, _nombre;

        private void dgvRegistro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvRegistro.Rows[e.RowIndex];
                if (fila.Cells["CodigoPre"].Value != null)
                {
                    string codigoPrestamoSeleccionado = fila.Cells["CodigoPre"].Value.ToString();

                    // Opcional: Si quieres copiarlo automáticamente al portapapeles o pasarlo de vuelta:
                    Clipboard.SetText(codigoPrestamoSeleccionado);
                    MessageBox.Show($"Código de préstamo '{codigoPrestamoSeleccionado}' copiado. Péguelo en 'Código del Préstamo' en la ventana principal para consultarlo o actualizarlo.", "Selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Constructor con parámetros que recibe el préstamo actual
        public Frmregistro(string codigoPre, string codigoEst, string nombre, string codigoLib, string fechaPre, string fechaDev, string estado)
        {
            InitializeComponent();

            // Guardamos los valores en las variables globales
            _codigoPre = codigoPre;
            _codigoEst = codigoEst;
            _nombre = nombre;
            _codigoLib = codigoLib;
            _fechaPre = fechaPre;
            _fechaDev = fechaDev;
            _estado = estado;
        }

        // Constructor por defecto (por si se llama sin parámetros)
        public Frmregistro()
        {
            InitializeComponent();
        }
        
        private void Frmregistro_Load(object sender, EventArgs e)
        {
            ConfigurarColumnasGrilla();
            CargarArchivoCSV();
        }

        private void ConfigurarColumnasGrilla()
        {
            dgvRegistro.Columns.Clear();
            dgvRegistro.Rows.Clear();

            dgvRegistro.Columns.Add("CodigoPre", "Código de Préstamo");
            dgvRegistro.Columns.Add("CodigoEst", "Código del Estudiante");
            dgvRegistro.Columns.Add("NombreEst", "Nombre del Estudiante");
            dgvRegistro.Columns.Add("CodigoLib", "Código del Libro");
            dgvRegistro.Columns.Add("FechaPre", "Fecha de Préstamo");
            dgvRegistro.Columns.Add("FechaDev", "Fecha de Devolución");
            dgvRegistro.Columns.Add("Estado", "Estado");

            dgvRegistro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarArchivoCSV()
        {
            // RUTA EXACTA sincronizada con la que usas en Form1
            string ruta = @"C:\Users\piero\OneDrive\Escritorio\bibliotecaUPN\regsitro.csv.txt";
            registro.Clear();

            try
            {
                if (File.Exists(ruta))
                {
                    using (StreamReader lector = new StreamReader(ruta))
                    {
                        string linea;
                        while ((linea = lector.ReadLine()) != null)
                        {
                            if (string.IsNullOrWhiteSpace(linea) || !linea.Contains("|"))
                            {
                                continue;
                            }

                            string[] datos = linea.Split('|');

                            for (int i = 0; i < datos.Length; i++)
                            {
                                datos[i] = datos[i].Trim();
                            }

                            registro.Add(datos);
                        }
                    }
                }


                
                if (!string.IsNullOrEmpty(_codigoPre))
                {
                    bool yaExiste = false;
                    foreach (var r in registro)
                    {
                        if (r.Length > 0 && r[0] == _codigoPre)
                        {
                            yaExiste = true;
                            break;
                        }
                    }

                    if (!yaExiste)
                    {
                        string[] nuevoActual = { _codigoPre, _codigoEst, _nombre, _codigoLib, _fechaPre, _fechaDev, _estado };
                        registro.Add(nuevoActual);
                    }
                }

                // Imprimir todos los datos de la lista en el DataGridView
                foreach (var fila in registro)
                {
                    dgvRegistro.Rows.Add(fila);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       
    }
}