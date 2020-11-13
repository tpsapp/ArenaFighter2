using System;
using System.Windows.Forms;

namespace ArenaFighter2
{
    public partial class frmAFNew : Form
    {
        frmAFMain frmMain = null;
        int iGRerolls = 0;
        int iHRerolls = 0;
        int iSRerolls = 0;
        int iARerolls = 0;

        public frmAFNew(frmAFMain frm)
        {
            InitializeComponent();
            frmMain = frm;
        }

        private void frmAFNew_TextChanged(object sender, EventArgs e)
        {
            if (!btnKeep.Enabled)
            {
                btnKeep.Enabled = true;
            }
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            if (!btnKeep.Enabled)
            {
                btnKeep.Enabled = true;
            }
        }

        private void cbSex_TextChanged(object sender, EventArgs e)
        {
            if (!btnKeep.Enabled)
            {
                btnKeep.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbGold.Text = frmMain.RollD6(2).ToString();
            if (!btnKeep.Enabled)
            {
                btnKeep.Enabled = true;
            }
            iGRerolls++;
            if (iGRerolls > 3)
            {
                btnRollGold.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbHealth.Text = frmMain.RollD6(2).ToString();
            if (!btnKeep.Enabled)
            {
                btnKeep.Enabled = true;
            }
            iHRerolls++;
            if (iHRerolls > 3)
            {
                btnRollHealth.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbStrength.Text = frmMain.RollD6(2).ToString();
            if (!btnKeep.Enabled)
            {
                btnKeep.Enabled = true;
            }
            iSRerolls++;
            if (iSRerolls > 3)
            {
                btnRollStr.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbAgility.Text = frmMain.RollD6(2).ToString();
            if (!btnKeep.Enabled)
            {
                btnKeep.Enabled = true;
            }
            iARerolls++;
            if (iARerolls > 3)
            {
                btnRollAgi.Enabled = false;
            }
        }

        private void btnKeep_Click(object sender, EventArgs e)
        {
            frmMain.cPlayer = new Character(tbFirstName.Text + " " + tbLastName.Text, cbSex.Text, 1, 0, Convert.ToInt32(tbGold.Text), Convert.ToInt32(tbHealth.Text), Convert.ToInt32(tbStrength.Text), Convert.ToInt32(tbAgility.Text), 0, 0);
            this.Close();
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            cbSex.SelectedIndex = 0;
            tbGold.Text = "";
            tbHealth.Text = "";
            tbStrength.Text = "";
            tbAgility.Text = "";
            btnKeep.Enabled = false;
            btnRollGold.Enabled = true;
            btnRollHealth.Enabled = true;
            btnRollStr.Enabled = true;
            btnRollAgi.Enabled = true;
            iGRerolls = 0;
            iHRerolls = 0;
            iSRerolls = 0;
            iARerolls = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
