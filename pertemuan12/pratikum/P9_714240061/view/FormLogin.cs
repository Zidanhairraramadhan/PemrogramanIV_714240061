using P9_714240061.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_714240061.view
{
    public partial class FormLogin : Form
    {
        CekLogin login = new CekLogin();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                                 return; 
    }

            
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            bool status = login.cek_login(username, password);

            
            if (status)
            {
               
                MessageBox.Show("Login Berhasil", "Informasi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
        ParentForm pform = new ParentForm(); 
                this.Hide(); 
                pform.Show(); 
            }
            else
            {
                MessageBox.Show("Username atau Password salah", "Gagal Login",
                               MessageBoxButtons.OK, MessageBoxIcon.Error); 
    }
        }
    }
}
