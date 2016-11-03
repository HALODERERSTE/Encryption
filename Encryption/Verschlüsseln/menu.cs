using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verschlüsseln
{
    public partial class menu : Form
    {
        rot5 rot5 = new rot5();
        rot13 rot13 = new rot13();

        public menu()
        {
            InitializeComponent();
        }

        private void bntChoose_Click(object sender, EventArgs e)
        {
            if (clEncrypt.GetItemChecked(0)) //ROT 5
            {
                rot5.Show();
                this.Hide();

            }
            else if (clEncrypt.GetItemChecked(1)) //ROT 13
            {
                rot13.Show();
                this.Hide();
            }
            else if (clEncrypt.GetItemChecked(2)) //XOR
            {

            }
            else if (clEncrypt.GetItemChecked(3)) //MD5 Hash
            {

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
