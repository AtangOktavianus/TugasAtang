using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a = int.Parse(A.Text); //proses casting
            var b = Convert.ToInt32(B.Text); //casting
            Double lstHasil;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    lstHasil = a + b;
                    Hasil.Text = Convert.ToString(lstHasil);
                    break;
                case 1:
                    lstHasil = a - b;
                    Hasil.Text = Convert.ToString(lstHasil);
                    break;
                case 2:
                    lstHasil = a * b;
                    Hasil.Text = Convert.ToString(lstHasil);
                    break;
                case 3:
                    lstHasil = a / b;
                    Hasil.Text = Convert.ToString(lstHasil);
                    break;
            }
        }
    }
}
