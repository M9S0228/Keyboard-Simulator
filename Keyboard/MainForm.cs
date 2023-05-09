using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Keyboard
{
    public partial class MainForm : Form
    {
        public InputForm input_form;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            input_form = new InputForm();
            LevelComboBox.SelectedIndex = 0;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            input_form.Level = LevelComboBox.SelectedIndex;
            input_form.ShowDialog();
        }
        private void вІдкритиРезультатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            FileStream fs = File.OpenRead(filename);
            byte[] array = new byte[fs.Length];
            fs.Read(array, 0, array.Length);
            string te = System.Text.Encoding.UTF8.GetString(array);
            MessageBox.Show(te, "Результати");
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
