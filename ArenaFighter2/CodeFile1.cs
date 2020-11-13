using System;
using System.Windows.Forms;
using System.Xml;

public class Character
{
    private string sName;
    private string sSex;
    private int iLevel;
    private int iExp;
    private int iGold;
    private int iHealth;
    private int iMaxHealth;
    private int iStr;
    private int iAgi;
    private int iWeapon;
    private int iArmor;
    private int iPotions;
    private bool bAlive;
    private Random rRandomizer = new Random();

    public bool ReadPlayerInfo(string filename)
    {
        try
        {
            XmlDocument xdFile = new XmlDocument();
            xdFile.Load(filename);
            XmlNodeList xnlInfo = xdFile.GetElementsByTagName("character");
            sName = xnlInfo[0].ChildNodes[0].InnerText;
            sSex = xnlInfo[0].ChildNodes[1].InnerText;
            iLevel = Convert.ToInt32(xnlInfo[0].ChildNodes[2].InnerText);
            iExp = Convert.ToInt32(xnlInfo[0].ChildNodes[3].InnerText);
            iGold = Convert.ToInt32(xnlInfo[0].ChildNodes[4].InnerText);
            iHealth = Convert.ToInt32(xnlInfo[0].ChildNodes[5].InnerText);
            iMaxHealth = Convert.ToInt32(xnlInfo[0].ChildNodes[6].InnerText);
            iStr = Convert.ToInt32(xnlInfo[0].ChildNodes[7].InnerText);
            iAgi = Convert.ToInt32(xnlInfo[0].ChildNodes[8].InnerText);
            iWeapon = Convert.ToInt32(xnlInfo[0].ChildNodes[9].InnerText);
            iArmor = Convert.ToInt32(xnlInfo[0].ChildNodes[10].InnerText);
            iPotions = Convert.ToInt32(xnlInfo[0].ChildNodes[11].InnerText);
            bAlive = Convert.ToBoolean(xnlInfo[0].ChildNodes[12].InnerText);
            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error loading character information.\nError: " + ex.Message);
            return false;
        }
    }

    public void SavePlayerInfo(string filename)
    {
        try
        {
            XmlWriterSettings xwsSettings = new XmlWriterSettings();
            xwsSettings.Indent = true;
            xwsSettings.IndentChars = "    ";
            xwsSettings.NewLineOnAttributes = true;
            XmlWriter xwFile = XmlWriter.Create(filename, xwsSettings);
            xwFile.WriteStartDocument();
            xwFile.WriteStartElement("character");
            xwFile.WriteStartElement("name");
            xwFile.WriteString(sName);
            xwFile.WriteEndElement();
            xwFile.WriteStartElement("sex");
            xwFile.WriteString(sSex);
            xwFile.WriteEndElement();
            xwFile.WriteStartElement("level");
            xwFile.WriteString(iLevel.ToString());
            xwFile.WriteEndElement();
            xwFile.WriteStartElement("exp");
            xwFile.WriteString(iExp.ToString());
            xwFile.WriteEndElement();
            xwFile.WriteStartElement("gold");
            xwFile.WriteString(iGold.ToString());
            xwFile.WriteEndElement();
            xwFile.WriteStartElement("health");
            xwFile.WriteString(iHealth.ToString());
            xwFile.WriteEndElement();
            xwFile.WriteStartElement("maxhealth");
            xwFile.WriteString(iMaxHealth.ToString());
            xwFile.WriteEndElement();
            xwFile.WriteStartElement("str");
            xwFile.WriteString(iStr.ToString());
            xwFile.WriteEndElement();
            xwFile.WriteStartElement("agi");
            xwFile.WriteString(iAgi.ToString());
            xwFile.WriteEndElement();
            xwFile.WriteStartElement("weapon");
            xwFile.WriteString(iWeapon.ToString());
            xwFile.WriteEndElement();
            xwFile.WriteStartElement("armor");
            xwFile.WriteString(iArmor.ToString());
            xwFile.WriteEndElement();
            xwFile.WriteStartElement("potions");
            xwFile.WriteString(iPotions.ToString());
            xwFile.WriteEndElement();
            xwFile.WriteStartElement("alive");
            xwFile.WriteString(bAlive.ToString());
            xwFile.WriteEndElement();
            xwFile.WriteEndElement();
            xwFile.WriteEndDocument();
            xwFile.Flush();
            xwFile.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error saving character information.\nError: " + ex.Message);
        }
    }

    public int RollD6(int n)
    {
        int result = 0;
        for (int i = 0; i < n; i++)
        {
            result += rRandomizer.Next(1, 7);
        }
        return result;
    }

    public string Attack(Character cOpponent)
    {
        string result = string.Empty;
        int iAttack = (iWeapon + iAgi + RollD6(2)) - cOpponent.Agility();
        result = iAttack.ToString() + "|";
        if (iAttack > 0)
        {
            int iDamage = (RollD6(1) + iStr + iWeapon) - cOpponent.Armor();
            if (iDamage <= 0)
            {
                iDamage = 1;
            }
            result += iDamage.ToString();
            cOpponent.TakeDamage(iDamage);
        }
        return result;
    }

    public void LevelUp()
    {
        if (iLevel < 10)
        {
            int iNextLevel = iExp / 100;
            while (iNextLevel >= iLevel)
            {
                iLevel++;
                iMaxHealth += RollD6(1);
                iHealth = iMaxHealth;
                iStr += RollD6(1);
                iAgi += RollD6(1);
                MessageBox.Show("You are now level " + iLevel.ToString() + ".\nYour Health is now " + iMaxHealth.ToString() + ".\nYour Strength is now " + iStr.ToString() + ".\nYour Agility is now " + iAgi.ToString() + ".");
            }
        }
    }

    public void TakeDamage(int d)
    {
        iHealth -= d;
        if (iHealth <= 0)
        {
            bAlive = false;
        }
    }

    public void Heal(bool usepotion)
    {
        if (usepotion)
        {
            if (iPotions > 0)
            {
                iPotions--;
                iHealth += 6 * iLevel;
                if (iHealth > iMaxHealth)
                {
                    iHealth = iMaxHealth;
                }
            }
            else
            {
                MessageBox.Show("You have no potions available.");
            }
        }
        else
        {
            iHealth = iMaxHealth;
        }
    }

    public Character(string filename)
    {
        if (!ReadPlayerInfo(filename))
            ClearInfo();
    }

    public Character(string name, string sex, int level, int Exp, int gold, int health, int str, int agi, int weapon, int armor)
    {
        sName = name;
        sSex = sex;
        iLevel = level;
        iExp = 0;
        iGold = gold;
        iHealth = health;
        iMaxHealth = health;
        iStr = str;
        iAgi = agi;
        iWeapon = weapon;
        iArmor = armor;
        iPotions = 0;
        bAlive = true;
    }

    public void ClearInfo()
    {
        sName = string.Empty;
        sSex = string.Empty;
        iLevel = 0;
        iExp = 0;
        iGold = 0;
        iHealth = 0;
        iMaxHealth = 0;
        iStr = 0;
        iAgi = 0;
        iWeapon = 0;
        iArmor = 0;
        iPotions = 0;
        bAlive = true;
    }

    public int Weapon()
    {
        return iWeapon;
    }

    public void Weapon(int w)
    {
        iWeapon = w;
    }

    public int Armor()
    {
        return iArmor;
    }

    public void Armor(int a)
    {
        iArmor = a;
    }

    public int Gold()
    {
        return iGold;
    }

    public void Gold(int g)
    {
        iGold = g;
    }

    public int Health()
    {
        return iHealth;
    }

    public int Strength()
    {
        return iStr;
    }

    public int Agility()
    {
        return iAgi;
    }

    public int Potions()
    {
        return iPotions;
    }

    public void Potions(int p)
    {
        iPotions = p;
    }

    public int Exp()
    {
        return iExp;
    }

    public void Exp(int e)
    {
        iExp = e;
    }

    public bool Alive()
    {
        return bAlive;
    }

    public void Alive(bool a)
    {
        bAlive = a;
    }

    public string Name()
    {
        return sName;
    }

    public string Sex()
    {
        return sSex;
    }

    public int MaxHealth()
    {
        return iMaxHealth;
    }

    public int Level()
    {
        return iLevel;
    }
}