using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_2_714240061
{
    public partial class Form1 : Form
    {
        private string FilePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Tampilkan OpenFileDialog dan cek DialogResult
                DialogResult userResponse = openFileDialog1.ShowDialog();
                if (userResponse == DialogResult.OK)
                {
                    FilePath = openFileDialog1.FileName.ToString();
                    MessageBox.Show("You successfully opened: " + FilePath, "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("You canceled the open file operation.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
