using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evaluacion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_procesar_Click(object sender, EventArgs e)
        {
            Promedio Jas = new Promedio();
            Jas.Nombre = txt_nomestudiante.Text;
            Jas.Ncuenta = Convert.ToUInt64(txt_cuenta.Text);
            Jas.Nota1 = Convert.ToUInt16(txt_n1.Text);
            Jas.Nota2 = Convert.ToUInt16(txt_n2.Text);
            Jas.Nota3 = Convert.ToUInt16(txt_n3.Text);
            Jas.Nota4 = Convert.ToUInt16(txt_n4.Text);

            MessageBox.Show(Jas.Nombre.ToUpper() + " SU CALIFICACION FINAL ES DE : " + Jas.suma() +"-->"+ Jas.Condicion());

        }

        private void txt_cuenta_TextChanged(object sender, EventArgs e)
        {

        }
        //private void txt_nomestudiante_KeyPress(object sender, KeyPressEventArgs e) 
        //{ 
        //    if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) 
        //    {
        //    MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    e.Handled = true;
        //    return; 
        //    } 
        //}
    }
}
