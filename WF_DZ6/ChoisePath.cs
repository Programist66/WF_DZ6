using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_DZ6
{
    public partial class ChoisePath : Form
    {
        public ChoisePath(Point location)
        {
            InitializeComponent();
            Location = location;
            textBox1.Text = ResultForm.InstaletFolder;
        }

        private void ChoisePath_FormClosing(object? sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите завершить установку?", "Завершение", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else if (result == DialogResult.Yes)
            {
                FormClosing -= ChoisePath_FormClosing;
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using CommonOpenFileDialog dialog = new();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                textBox1.Text = dialog.FileName;
                ResultForm.InstaletFolder = dialog.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChoiseOptions choiseOptions = new(Location);
            choiseOptions.Show();
            FormClosing -= ChoisePath_FormClosing;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChoiseModules form = new ChoiseModules(Location);
            form.Show();
            FormClosing -= ChoisePath_FormClosing;
            Close();
        }
    }
}
