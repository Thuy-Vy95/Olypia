using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace from_tong_quat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;
                MessageBox.Show(fileName);
            }
            dlg.Title = "Nhập Dữ Liệu Từ File";
            dlg.InitialDirectory =
            @"C:pathtofile";
            dlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            dlg.FilterIndex = 1;
            dlg.RestoreDirectory = true;
            textnhanfile.Text = dlg.FileName;
            textnhanfile.Text = Text;
        }
    }
}
        
    

