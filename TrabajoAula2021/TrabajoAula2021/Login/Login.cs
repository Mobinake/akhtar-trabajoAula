using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoAula2021.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonPrueba_Click(object sender, EventArgs e)
        {
            labelprueba.Text = ("Prueba");
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            labelprueba.Text = ("Confirmar");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
