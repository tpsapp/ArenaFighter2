using System;
using System.Windows.Forms;

namespace ArenaFighter2
{
    public partial class frmAFMain : Form
    {
        public string[] Weapons = new string[12] { "None", "Dagger", "Club", "Staff", "Sword", "Mace", "Steel Sword", "Steel Mace", "Silver Sword", "Silver Mace", "Gold Sword", "Gold Mace" };
        public string[] Armors = new string[12] { "None", "Cloth", "Leather", "Chain", "Plate", "Scale", "Steel Chain", "Steel Plate", "Steel Scale", "Titanium Chain", "Titanium Plate", "Titanium Scale" };

        public Character cPlayer = null;
        public Character cOpponent = null;

        private Random rRandomizer = new Random();

        public int RollD6(int times)
        {
            int result = 0;
            for (int i = 0; i < times; i++)
            {
                result += rRandomizer.Next(1, 7);
            }
            return result;
        }

        private void UpdatePlayer()
        {
            tbPName.Text = cPlayer.Name();
            tbPSex.Text = cPlayer.Sex();
            tbPLevel.Text = cPlayer.Level().ToString();
            tbPExp.Text = cPlayer.Exp().ToString();
            tbPGold.Text = cPlayer.Gold().ToString();
            tbPHealth.Text = cPlayer.Health().ToString();
            tbPMaxHealth.Text = cPlayer.MaxHealth().ToString();
            tbPStr.Text = cPlayer.Strength().ToString();
            tbPAgi.Text = cPlayer.Agility().ToString();
            tbPWeapon.Text = Weapons[cPlayer.Weapon()];
            tbPArmor.Text = Armors[cPlayer.Armor()];
            tbPPotions.Text = cPlayer.Potions().ToString();
        }

        private void UpdateOpponent()
        {
            tbOName.Text = cOpponent.Name();
            tbOSex.Text = cOpponent.Sex();
            tbOLevel.Text = cOpponent.Level().ToString();
            tbOExp.Text = cOpponent.Exp().ToString();
            tbOGold.Text = cOpponent.Gold().ToString();
            tbOHealth.Text = cOpponent.Health().ToString();
            tbOMaxHealth.Text = cOpponent.MaxHealth().ToString();
            tbOStr.Text = cOpponent.Strength().ToString();
            tbOAgi.Text = cOpponent.Agility().ToString();
            tbOWeapon.Text = Weapons[cOpponent.Weapon()];
            tbOArmor.Text = Armors[cOpponent.Armor()];
            tbOPotions.Text = cOpponent.Potions().ToString();
        }

        private void UpdateResults(string sResults, bool bPlayer)
        {
            string[] sRolls = new string[2];
            sRolls = sResults.Split('|');
            if (bPlayer)
            {
                rtbPResults.AppendText("Your attack roll: " + sRolls[0] + "\nYour damage roll: " + sRolls[1] + "\n");
            }
            else
            {
                rtbOResults.AppendText("Their attack roll: " + sRolls[0] + "\nTheir damage roll: " + sRolls[1] + "\n");
            }
        }

        public frmAFMain()
        {
            InitializeComponent();
        }

        private void frmAFMain_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmAFHelp frmHelp = new frmAFHelp();
            frmHelp.ShowDialog();
        }

        private void btnNewFight_Click(object sender, EventArgs e)
        {
            if (cOpponent != null)
                cOpponent.ClearInfo();
            cOpponent = new Character("Opponent", "Male", cPlayer.Level(), 0, RollD6(cPlayer.Level() + 1), RollD6(cPlayer.Level() + 1), RollD6(cPlayer.Level() + 1), RollD6(cPlayer.Level() + 1), rRandomizer.Next(1, cPlayer.Level() + 1), rRandomizer.Next(1, cPlayer.Level() + 1));
            btnAttack.Enabled = true;
            btnNewFight.Enabled = false;
            if (cPlayer.Potions() > 0)
            {
                btnDrinkPotion.Enabled = true;
            }
            rtbPResults.Clear();
            rtbOResults.Clear();
            UpdatePlayer();
            UpdateOpponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sfdSave.FileName = tbPName.Text + ".xml";
            sfdSave.ShowDialog();
            if (sfdSave.FileName != "")
            {
                cPlayer.SavePlayerInfo(sfdSave.FileName);
            }
            sfdSave.FileName = "";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ofdLoad.ShowDialog();
            if (ofdLoad.FileName != "")
            {
                if (cPlayer == null)
                {
                    cPlayer = new Character(ofdLoad.FileName);
                }
                else
                {
                    cPlayer.ReadPlayerInfo(ofdLoad.FileName);
                }
                btnSave.Enabled = true;
                btnNewFight.Enabled = true;
                btnShop.Enabled = true;
                UpdatePlayer();
            }
            ofdLoad.FileName = "";
        }

        private void btnNewPlayer_Click(object sender, EventArgs e)
        {
            frmAFNew frmNew = new frmAFNew(this);
            frmNew.ShowDialog();
            if (cPlayer != null)
            {
                UpdatePlayer();
                btnNewFight.Enabled = true;
                btnSave.Enabled = true;
                if (cPlayer.Gold() > 0)
                {
                    btnShop.Enabled = true;
                }
            }
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            frmAFShop frmShop = new frmAFShop(this);
            frmShop.ShowDialog();
            UpdatePlayer();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            string pAttack = string.Empty;
            string oAttack = string.Empty;

            pAttack = cPlayer.Attack(cOpponent);
            UpdateResults(pAttack, true);
            if (cOpponent.Alive())
            {
                oAttack = cOpponent.Attack(cPlayer);
                UpdateResults(oAttack, false);
                if (!cPlayer.Alive())
                {
                    MessageBox.Show("You have been defeated by your opponent!");
                    btnSave.Enabled = false;
                    btnAttack.Enabled = false;
                    btnDrinkPotion.Enabled = false;
                    btnShop.Enabled = false;
                    btnNewFight.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("You have defeated your opponent!");
                cPlayer.Exp(cPlayer.Exp() + (cOpponent.Level() * 2));
                cPlayer.Gold(cPlayer.Gold() + cOpponent.Gold());
                cPlayer.LevelUp();
                btnAttack.Enabled = false;
                btnDrinkPotion.Enabled = false;
                btnNewFight.Enabled = true;
            }
            UpdatePlayer();
            UpdateOpponent();
        }

        private void btnDrinkPotion_Click(object sender, EventArgs e)
        {
            cPlayer.Heal(true);
        }
    }
}
