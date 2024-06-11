using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp10
{
    public partial class FormMine : Form
    {
        public FormMine()
        {
            InitializeComponent();
        }

        private void FormMine_Load(object sender, EventArgs e)
        {

        }
        public void Show(int Ore, int Worker)
        {
            Label_Ore.Text = "Ore: " + Ore.ToString();
            Label_Worker.Text = "Worker: " + Worker.ToString();
        }
    }
}
