using Bin2Dec.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bin2Dec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConversor_Click(object sender, EventArgs e)
        {
            conversiones obj_conversor = new conversiones();
            Validaciones valid = new Validaciones();
            string binario = txtbin.Text;

            if (valid.maxDigitos(binario)&&valid.validacionCaracteresBin2(binario))
            {
                long bin = Convert.ToInt64(binario);
                lblResult.Text = (obj_conversor.Binario_Decimal(bin)).ToString();
            }
            else
            {
                if (!valid.validacionCaracteresBin2(binario))
                {
                    MessageBox.Show("ERROR!!!!! No se permite ingresar ningun otro caracter que no corresponda al lenguaje binario");
                }
                else
                {
                    MessageBox.Show("ERROR!!!!! El digito binario ingresado no puede ser mayor a 8 caracteres");
                }
            }
        }
    }
}
