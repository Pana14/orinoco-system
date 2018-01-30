using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internal_Communications
{
    public partial class Email : Form
    {
   

       
        public Email()
        {
            InitializeComponent();

          
        }

        public void Email_Load(object sender, EventArgs e)
        {
           
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            new Email_Options().Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Menu = new Form1();
            Menu.ShowDialog();
            this.Close();
        }
    }
}
