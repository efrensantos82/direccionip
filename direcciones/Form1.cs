using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using direcciones.direccion;

namespace direcciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        direccionIPSoapClient ip = new direccionIPSoapClient();
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtdireccion.Text != string.Empty && txtdireccion1.Text != string.Empty && txtdireccion2.Text != string.Empty && txtdireccion3.Text != string.Empty)
            {
                try
                {
                    MessageBox.Show(ip.direccion(int.Parse(txtdireccion.Text)));
                }
                catch (FormatException ex)
                {

                    MessageBox.Show("Introduce correctamenta la direccion o la direccion no pertenece a ninguna de las clas A B o C",ex.Message);
                }
            }
            else 
            {
                MessageBox.Show( "Llena todos los campos necesarios de la Direccion IP");
            }
        }
    }
}
