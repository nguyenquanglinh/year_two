using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            var cauNoi = txtCauNoi.Text;
            if (string.IsNullOrWhiteSpace(cauNoi))
                MessageBox.Show("chưa nhập gì");
            else
                MessageBox.Show(cauNoi);
            txtCauNoi.Clear();
        }
    }
}
