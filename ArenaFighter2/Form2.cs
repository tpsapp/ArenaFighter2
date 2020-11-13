using System;
using System.Windows.Forms;

namespace ArenaFighter2
{
    public partial class frmAFShop : Form
    {
        private int[] iPrices = new int[12] { 0, 2, 6, 50, 150, 300, 600, 900, 1500, 2400, 3900, 6300 };
        private int iOrderAmount;
        private int iPGold;
        private int iCredit;
        private int iPotion;
        private bool bWeapon = false;
        private bool bArmor = false;
        private frmAFMain frmMain = null;

        public frmAFShop(frmAFMain frm)
        {
            InitializeComponent();
            frmMain = frm;
        }

        private void frmAFShop_Load(object sender, EventArgs e)
        {
            lWeapon.Text = "Current Weapon: " + frmMain.Weapons[frmMain.cPlayer.Weapon()];
            lArmor.Text = "Current Armor: " + frmMain.Armors[frmMain.cPlayer.Armor()];
            tbPGold.Text = frmMain.cPlayer.Gold().ToString();
            tbOrderAmount.Text = "0";
            iOrderAmount = 0;
            iPGold = frmMain.cPlayer.Gold();
            iCredit = 0;
            iPotion = frmMain.cPlayer.Level() * 5;
            btnPotion.Text = "Buy Potion for " + iPotion.ToString() + "g";
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbCart.Items.Count; i++)
            {
                for (int x = 0; x < 12; x++)
                {
                    if (lbCart.Items[i] == frmMain.Weapons[x])
                    {
                        frmMain.cPlayer.Weapon(x);
                    }
                    if (lbCart.Items[i] == frmMain.Armors[x])
                    {
                        frmMain.cPlayer.Armor(x);
                    }
                }
                if (lbCart.Items[i] == "Potion")
                {
                    frmMain.cPlayer.Potions(frmMain.cPlayer.Potions() + 1);
                }
            }
            iPGold += iCredit - iOrderAmount;
            frmMain.cPlayer.Gold(iPGold);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbWeapons_DoubleClick(object sender, EventArgs e)
        {
            if (!bWeapon)
            {
                if (lbWeapons.SelectedIndex > 0)
                {
                    iCredit += iPrices[frmMain.cPlayer.Weapon()];
                    int iTotal = (iPGold + iCredit) - iOrderAmount;
                    if (iTotal >= iPrices[lbWeapons.SelectedIndex])
                    {
                        lbCart.Items.Add(frmMain.Weapons[lbWeapons.SelectedIndex]);
                        iOrderAmount += iPrices[lbWeapons.SelectedIndex];
                        tbOrderAmount.Text = iOrderAmount.ToString();
                        bWeapon = true;
                    }
                }
            }
        }

        private void lbArmors_DoubleClick(object sender, EventArgs e)
        {
            if (!bArmor)
            {
                if (lbArmors.SelectedIndex > 0)
                {
                    iCredit += iPrices[frmMain.cPlayer.Armor()];
                    int iTotal = (iPGold + iCredit) - iOrderAmount;
                    if (iTotal >= iPrices[lbArmors.SelectedIndex])
                    {
                        lbCart.Items.Add(frmMain.Armors[lbArmors.SelectedIndex]);
                        iOrderAmount += iPrices[lbArmors.SelectedIndex];
                        tbOrderAmount.Text = iOrderAmount.ToString();
                        bArmor = true;
                    }
                }
            }
        }

        private void lbCart_DoubleClick(object sender, EventArgs e)
        {
            while (lbCart.SelectedIndex > 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    if (lbCart.Items[lbCart.SelectedIndex] == frmMain.Weapons[i])
                    {
                        iOrderAmount -= iPrices[i];
                        iCredit -= iPrices[frmMain.cPlayer.Weapon()];
                        bWeapon = false;
                        lbCart.Items.RemoveAt(lbCart.SelectedIndex);
                        tbOrderAmount.Text = iOrderAmount.ToString();
                    }
                    if (lbCart.Items[lbCart.SelectedIndex] == frmMain.Armors[i])
                    {
                        iOrderAmount -= iPrices[i];
                        iCredit -= iPrices[frmMain.cPlayer.Armor()];
                        bWeapon = false;
                        lbCart.Items.RemoveAt(lbCart.SelectedIndex);
                        tbOrderAmount.Text = iOrderAmount.ToString();
                    }
                }
                if (lbCart.Items[lbCart.SelectedIndex] == "Potion")
                {
                    iOrderAmount -= iPotion;
                    lbCart.Items.RemoveAt(lbCart.SelectedIndex);
                }
            }
        }

        private void btnPotion_Click(object sender, EventArgs e)
        {
            int iTotal = (iPGold + iCredit) - iOrderAmount;
            if (iTotal >= iPotion)
            {
                lbCart.Items.Add("Potion");
                iOrderAmount += iPotion;
                tbOrderAmount.Text = iOrderAmount.ToString();
            }
        }
    }
}
