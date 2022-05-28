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
    public partial class Form2 : Form
    {
        Form1 back;
        Form4 data;
        Form3 binding;

        void binding_FormClosed(Object sender, FormClosedEventArgs e)
        {
            binding = null;
        }

        void back_FormClosed(Object sender, FormClosedEventArgs e)
        {
            back = null;
        }

        public Form2()
        {
            InitializeComponent();
        }


        private void picturehome_Click(object sender, EventArgs e)
        {
            if (back == null)
            {
                back = new Form1();
                back.FormClosed += new FormClosedEventHandler(back_FormClosed);
                back.Show();
            }
            else
            {
                back.Activate();
            }
            this.Hide();
        }

        private void picturedata_Click(object sender, EventArgs e)
        {
            data = new Form4();
            data.Show();
            this.Hide();
        }

        private void buttondata_Click(object sender, EventArgs e)
        {
            data = new Form4();
            data.Show();
            this.Hide();
        }

        private void picturebinding_Click(object sender, EventArgs e)
        {
            if (binding == null)
            {
                binding = new Form3();
                binding.FormClosed += new FormClosedEventHandler(binding_Formclosed);
                binding.Show();
            }
            else
            {
                binding.Activate();
                binding.Close();
            }
            this.Hide();
        }

        private void binding_Formclosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonbinding_Click(object sender, EventArgs e)
        {
            binding = new Form3();
            binding.Show();
            this.Hide();
        }
    }
}
