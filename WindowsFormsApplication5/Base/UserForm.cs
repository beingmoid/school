using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5.Base
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        private bool IsValidEmailAddress(string email)
        {
            try
            {
                MailAddress ma = new MailAddress(email);

                return true;
            }
            catch
            {
                return false;
            }
        }
        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            var txt = (TextBox)sender;
            if (!IsValidEmailAddress(txt.Text))
            {
                errorProvider1.SetError(label5,"Invalid Format");
            }
        }
    }
}
