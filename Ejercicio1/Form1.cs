using System;
using System.IO;
using System.Windows.Forms;

namespace ProcesadorCSV_Dataset
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCargarCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*";
            dialog.Title = "Selecciona tu Dataset";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                CargarDatosEnTabla(dialog.FileName);
            }
        }

        private void CargarDatosEnTabla(string rutaArchivo)
        {
            try
            {
                dgvDatos.Columns.Clear();
                dgvDatos.Rows.Clear();

                double sumaPrecios = 0;
                int totalRegistros = 0;

                using (StreamReader lector = new StreamReader(rutaArchivo))
                {
                    
                    string lineaEncabezados = lector.ReadLine();
                    if (lineaEncabezados != null)
                    {
                        string[] nombresColumnas = lineaEncabezados.Split(',');
                        foreach (string columna in nombresColumnas)
                        {
                            dgvDatos.Columns.Add(columna, columna);
                        }
                    }

                    
                    string lineaDatos;
                    while ((lineaDatos = lector.ReadLine()) != null)
                    {
                       
                        if (string.IsNullOrWhiteSpace(lineaDatos)) continue;

                        string[] celdas = lineaDatos.Split(',');

                        dgvDatos.Rows.Add(celdas);

                        if (celdas.Length > 0)
                        {
                            string ultimoValor = celdas[celdas.Length - 1];
                            if (double.TryParse(ultimoValor, out double valorNumerico))
                            {
                                sumaPrecios += valorNumerico;
                                totalRegistros++;
                            }
                        }
                    }
                }

                if (totalRegistros > 0)
                {
                    double promedio = sumaPrecios / totalRegistros;
                    lblEstadisticas.Text = $"Se cargaron {totalRegistros} registros. Valor promedio estimado: ${Math.Round(promedio, 2)}";
                }
                else
                {
                    lblEstadisticas.Text = "Datos cargados, pero no se detectaron valores numéricos para promediar.";
                }

                MessageBox.Show("¡Dataset procesado con éxito!", "Completado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al procesar el archivo CSV:\n" + ex.Message, "Error");
            }
        }
    }
}
