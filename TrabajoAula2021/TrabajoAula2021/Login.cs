using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoAula2021
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonprueba_Click(object sender, EventArgs e)
        {
            labelprueba.Text=("Funciona");
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            labelprueba.Text = ("confirmar");
        }
    }
}
