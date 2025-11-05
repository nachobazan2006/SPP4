using System.Windows.Forms;

namespace frmLaMilanga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvBar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmLaMilanga_Load(object sender, EventArgs e)
        {
            

            // añaadir filas con nombres y valores iniciales
            dgvBar.Rows.Add("Julio", 0, 0, 0, 0);
            dgvBar.Rows.Add("Esteban", 0, 0, 0, 0);
            dgvBar.Rows.Add("Javier", 0, 0, 0, 0);
            dgvBar.Rows.Add("Gonzalo", 0, 0, 0, 0);
            dgvBar.Rows.Add("Alberto", 0, 0, 0, 0);

            // hacer la columna de nombres (columna 0) de solo lectura
            if (dgvBar.Columns.Count > 0)
            {
                dgvBar.Columns[0].Width = 100;
                dgvBar.Columns[0].ReadOnly = true;
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            //variable booleana para controlar si los datos son correctos
            bool correcto = true;

            // recorro  las filas
            for (int i = 0; i < dgvBar.Rows.Count; i++)
            {
                // recorro  las columnas excepto la 0 (nombres)
                for (int j = 1; j < dgvBar.Columns.Count; j++)
                {
                    // tomo el valor de la celda
                    string valor = Convert.ToString(dgvBar.Rows[i].Cells[j].Value)?.Trim();

                    // si está vacío o no es un número, hay error
                    if (string.IsNullOrWhiteSpace(valor) || !float.TryParse(valor, out _)) //out porque no nos interesa guasrdar el valor, sino si la conversión es posible
                    {
                        correcto = false;
                        break; //marca que hay un error, pero el ciclo continua hasta salir del bucle
                    }
                }
                //sale del bucle si hay error   
                if (!correcto)
                    break;
            }

            // mostramos el resultado
            if (correcto)
            {
                MessageBox.Show("Datos validados correctamente.");
                btnMozoDelDia.Enabled = true;
                btnTotales.Enabled = true;
            }
            else
            {
                MessageBox.Show("Hay datos incorrectos o vacíos.");
                btnMozoDelDia.Enabled = false;
                btnTotales.Enabled = false;
            }
        }

        private void btnMozoDelDia_Click(object sender, EventArgs e)
        {
            // creo el vector de mozos  
            string[] mozos = { "Julio", "Esteban", "Javier", "Gonzalo", "Alberto" };

            float mayorVenta = 0;
            string mozoGanador = "";
            List<string> ganadores = new List<string>();
            //arancamos estructura para recorrer las filas del datagridview
            for (int i = 0; i < dgvBar.Rows.Count; i++)
            {
                // variables para guardar los valores de cada categoría
                float comidas = 0, bebidasSin = 0, bebidasCon = 0, postres = 0;

                // leo los valores del dgv, que pueden ser cualquier tipo de dato, por eso convierto a string y luego parseo a float para así guardar el resultado en las variables
                float.TryParse(Convert.ToString(dgvBar.Rows[i].Cells[4].Value), out comidas);
                float.TryParse(Convert.ToString(dgvBar.Rows[i].Cells[1].Value), out bebidasSin);
                float.TryParse(Convert.ToString(dgvBar.Rows[i].Cells[2].Value), out bebidasCon);
                float.TryParse(Convert.ToString(dgvBar.Rows[i].Cells[3].Value), out postres);

                // calculo el total vendido por el mozo actual
                float total = comidas + bebidasSin + bebidasCon + postres;


                // si este total es mayor que el mayor registrado, actualizo
                if (total > mayorVenta)
                {
                    mayorVenta = total;
                    ganadores.Clear();
                    ganadores.Add(mozos[i]);

                }
                else if (total == mayorVenta)      
                {
                    ganadores.Add(mozos[i]);
                }
            }

            string Mensaje;
            if (ganadores.Count == 1) 
                Mensaje = $"El mozo del dìa es  { ganadores[0] } con un total de $  { mayorVenta }.";
            else Mensaje = $"Empate entre {string.Join(",", ganadores)} con un total de ${mayorVenta}";

            MessageBox.Show(Mensaje);
        }

        private void btnTotales_Click(object sender, EventArgs e)
        {
            // variables para acumular totales
            float totalGeneral = 0;
            float totalComidas = 0, totalBebidasSin = 0, totalBebidasCon = 0, totalPostres = 0;

            // recorro las filas del datagridview
            for (int i = 0; i < dgvBar.Rows.Count; i++)
            {
                float comidas = 0, bebidasSin = 0, bebidasCon = 0, postres = 0;

                // al igual que antes, leo los valores del dgv, que pueden ser cualquier tipo de dato, por eso convierto a string y luego parseo a float para así guardar el resultado en las variables
                float.TryParse(Convert.ToString(dgvBar.Rows[i].Cells[4].Value), out comidas);
                float.TryParse(Convert.ToString(dgvBar.Rows[i].Cells[1].Value), out bebidasSin);
                float.TryParse(Convert.ToString(dgvBar.Rows[i].Cells[2].Value), out bebidasCon);
                float.TryParse(Convert.ToString(dgvBar.Rows[i].Cells[3].Value), out postres);

                totalComidas += comidas;
                totalBebidasSin += bebidasSin;
                totalBebidasCon += bebidasCon;
                totalPostres += postres;

                totalGeneral += comidas + bebidasSin + bebidasCon + postres;
            }

            MessageBox.Show(
                "Totales por categoría:\n\n" +
                "Comidas: " + totalComidas.ToString("0.00") + "\n" +
                "Bebidas sin alcohol: " + totalBebidasSin.ToString("0.00") + "\n" +
                "Bebidas con alcohol: " + totalBebidasCon.ToString("0.00") + "\n" +
                "Postres: " + totalPostres.ToString("0.00") + "\n\n" +
                "Total general vendido: " + totalGeneral.ToString("0.00"),
                "Totales",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }
    }
}
