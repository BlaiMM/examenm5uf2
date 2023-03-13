using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projecteExamenGit
{
    public partial class frmMain : Form
    {
        public FrmAnimal fAnim;
        public FrmViatge fViat;
        public FrmMenjar fMenjar;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btAnimal_Click(object sender, EventArgs e)
        {
            
                fAnim = new FrmAnimal();
                fAnim.MdiParent = this;          
            
            fAnim.WindowState = FormWindowState.Normal;
            fAnim.Show();
        }
        

        private void btViatge_Click(object sender, EventArgs e)
        {
            
                fViat = new FrmViatge();
                fViat.MdiParent = this;          
            
            fViat.WindowState = FormWindowState.Normal;
            fViat.Show();
        }

        private void btMenjar_Click(object sender, EventArgs e)
        {

            fMenjar = new FrmMenjar();
            fMenjar.MdiParent = this;

            fMenjar.WindowState = FormWindowState.Normal;
            fMenjar.Show();
        }
    }
}
