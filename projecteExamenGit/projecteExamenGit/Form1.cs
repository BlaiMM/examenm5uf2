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
        public frmMain()
        {
            InitializeComponent();
        }

        private void btAnimal_Click(object sender, EventArgs e)
        {
            if (!(ja_està_obert("FrmAnimal")))
            {
                fAnim = new FrmAnimal();
                fAnim.MdiParent = this;           // --- hem fet que FRM_MAIN sigui MdiContainer i posem aquest Form com a fill seu ---
            }
            fAnim.WindowState = FormWindowState.Normal;
            fAnim.Show();
        }
        public Boolean ja_està_obert(String xnom_frm)
        {
            int x1 = 0;
            Boolean xb = false;

            while ((x1 < this.MdiChildren.Length) && (!(xb)))
            {
                xb = (this.MdiChildren[x1].Name == xnom_frm);
                x1++;
            }
            return (xb);
        }

        private void btViatge_Click(object sender, EventArgs e)
        {
            if (!(ja_està_obert("FrmViatge")))
            {
                fViat = new FrmViatge();
                fViat.MdiParent = this;           // --- hem fet que FRM_MAIN sigui MdiContainer i posem aquest Form com a fill seu ---
            }
            fViat.WindowState = FormWindowState.Normal;
            fViat.Show();
        }
    }
}
