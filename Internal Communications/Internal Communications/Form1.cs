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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            this.Hide();
            Email email_form = new Internal_Communications.Email();
            email_form.ShowDialog();
            this.Close();
        }

        private void btnNotificationSystem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Notificaton_System notification_form = new Notificaton_System();
            notification_form.ShowDialog();
            this.Close();
        }

        private void btnInstandMessaging_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instant Chat = new InstantMessagingClient();
            Chat.ShowDialog();
            this.Close();
        }
    }
}
