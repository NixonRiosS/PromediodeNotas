using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller1_PromedioNotasEstudiante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_nota1.Text = string.Empty;
            txt_nota2.Text = string.Empty;
            txt_nota3.Text = string.Empty;
            label5.Visible = false;
            lbl_promedio.Visible = false;
            txt_nota1.Focus();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (txt_nota1.Text == "" || txt_nota2.Text == "" || txt_nota3.Text == "")
            {
                MessageBox.Show("Todos los campos de las notas deben estar diligenciados", "Mensaje de validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_nota1.Focus();
            }
            else
            {
                double n1, n2, n3, prom, suma;

                n1 = double.Parse(txt_nota1.Text);
                n2 = double.Parse(txt_nota2.Text);
                n3 = double.Parse(txt_nota3.Text);

                suma = n1 + n2 + n3;

                prom = suma / 3;

                lbl_promedio.Text = Convert.ToString(String.Format("{0:n2}", prom));

                label5.Visible = true;
                lbl_promedio.Visible = true;

            }
        }

        
    }
}
