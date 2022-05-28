using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExersiceDataBinding
{
    public partial class Form1 : Form
    {
        Form2 login;
        void login_FormClosed(Object sender, FormClosedEventArgs e)
        {
            login = null;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           if (login == null)
           {
                login = new Form2();
                login.FormClosed += new FormClosedEventHandler(login_FormClosed);
                login.Show();
            }
           else
           {
                login.Activate();
           }
            this.Hide();
                
        }
    }
}
