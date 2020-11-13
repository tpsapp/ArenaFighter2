namespace ArenaFighter2
{
    partial class frmAFNew
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAFNew));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbGold = new System.Windows.Forms.TextBox();
            this.tbHealth = new System.Windows.Forms.TextBox();
            this.tbStrength = new System.Windows.Forms.TextBox();
            this.tbAgility = new System.Windows.Forms.TextBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.btnRollGold = new System.Windows.Forms.Button();
            this.btnRollHealth = new System.Windows.Forms.Button();
            this.btnRollStr = new System.Windows.Forms.Button();
            this.btnRollAgi = new System.Windows.Forms.Button();
            this.btnKeep = new System.Windows.Forms.Button();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Player Creation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(46, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sex?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(45, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gold:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(36, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Health:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(27, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Strength:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(40, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Agility:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.White;
            this.tbFirstName.Location = new System.Drawing.Point(83, 40);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 0;
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.Color.White;
            this.tbLastName.Location = new System.Drawing.Point(83, 66);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 1;
            this.tbLastName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // tbGold
            // 
            this.tbGold.BackColor = System.Drawing.Color.White;
            this.tbGold.Enabled = false;
            this.tbGold.ForeColor = System.Drawing.Color.Black;
            this.tbGold.Location = new System.Drawing.Point(83, 119);
            this.tbGold.Name = "tbGold";
            this.tbGold.ReadOnly = true;
            this.tbGold.Size = new System.Drawing.Size(100, 20);
            this.tbGold.TabIndex = 10;
            // 
            // tbHealth
            // 
            this.tbHealth.BackColor = System.Drawing.Color.White;
            this.tbHealth.Enabled = false;
            this.tbHealth.ForeColor = System.Drawing.Color.Black;
            this.tbHealth.Location = new System.Drawing.Point(83, 145);
            this.tbHealth.Name = "tbHealth";
            this.tbHealth.ReadOnly = true;
            this.tbHealth.Size = new System.Drawing.Size(100, 20);
            this.tbHealth.TabIndex = 11;
            // 
            // tbStrength
            // 
            this.tbStrength.BackColor = System.Drawing.Color.White;
            this.tbStrength.Enabled = false;
            this.tbStrength.ForeColor = System.Drawing.Color.Black;
            this.tbStrength.Location = new System.Drawing.Point(83, 171);
            this.tbStrength.Name = "tbStrength";
            this.tbStrength.ReadOnly = true;
            this.tbStrength.Size = new System.Drawing.Size(100, 20);
            this.tbStrength.TabIndex = 12;
            // 
            // tbAgility
            // 
            this.tbAgility.BackColor = System.Drawing.Color.White;
            this.tbAgility.Enabled = false;
            this.tbAgility.ForeColor = System.Drawing.Color.Black;
            this.tbAgility.Location = new System.Drawing.Point(83, 197);
            this.tbAgility.Name = "tbAgility";
            this.tbAgility.ReadOnly = true;
            this.tbAgility.Size = new System.Drawing.Size(100, 20);
            this.tbAgility.TabIndex = 13;
            // 
            // cbSex
            // 
            this.cbSex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbSex.Location = new System.Drawing.Point(83, 92);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(100, 21);
            this.cbSex.TabIndex = 2;
            this.cbSex.Text = "Male";
            this.cbSex.TextChanged += new System.EventHandler(this.cbSex_TextChanged);
            // 
            // btnRollGold
            // 
            this.btnRollGold.Location = new System.Drawing.Point(189, 116);
            this.btnRollGold.Name = "btnRollGold";
            this.btnRollGold.Size = new System.Drawing.Size(75, 23);
            this.btnRollGold.TabIndex = 3;
            this.btnRollGold.Text = "Roll";
            this.btnRollGold.UseVisualStyleBackColor = true;
            this.btnRollGold.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRollHealth
            // 
            this.btnRollHealth.Location = new System.Drawing.Point(189, 142);
            this.btnRollHealth.Name = "btnRollHealth";
            this.btnRollHealth.Size = new System.Drawing.Size(75, 23);
            this.btnRollHealth.TabIndex = 4;
            this.btnRollHealth.Text = "Roll";
            this.btnRollHealth.UseVisualStyleBackColor = true;
            this.btnRollHealth.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRollStr
            // 
            this.btnRollStr.Location = new System.Drawing.Point(189, 168);
            this.btnRollStr.Name = "btnRollStr";
            this.btnRollStr.Size = new System.Drawing.Size(75, 23);
            this.btnRollStr.TabIndex = 5;
            this.btnRollStr.Text = "Roll";
            this.btnRollStr.UseVisualStyleBackColor = true;
            this.btnRollStr.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRollAgi
            // 
            this.btnRollAgi.Location = new System.Drawing.Point(189, 194);
            this.btnRollAgi.Name = "btnRollAgi";
            this.btnRollAgi.Size = new System.Drawing.Size(75, 23);
            this.btnRollAgi.TabIndex = 6;
            this.btnRollAgi.Text = "Roll";
            this.btnRollAgi.UseVisualStyleBackColor = true;
            this.btnRollAgi.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnKeep
            // 
            this.btnKeep.Enabled = false;
            this.btnKeep.Location = new System.Drawing.Point(50, 237);
            this.btnKeep.Name = "btnKeep";
            this.btnKeep.Size = new System.Drawing.Size(75, 23);
            this.btnKeep.TabIndex = 7;
            this.btnKeep.Text = "&Keep";
            this.btnKeep.UseVisualStyleBackColor = true;
            this.btnKeep.Click += new System.EventHandler(this.btnKeep_Click);
            // 
            // btnDiscard
            // 
            this.btnDiscard.Location = new System.Drawing.Point(131, 237);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(75, 23);
            this.btnDiscard.TabIndex = 8;
            this.btnDiscard.Text = "&Discard";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(212, 237);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAFNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArenaFighter2.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(294, 272);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.btnKeep);
            this.Controls.Add(this.btnRollAgi);
            this.Controls.Add(this.btnRollStr);
            this.Controls.Add(this.btnRollHealth);
            this.Controls.Add(this.btnRollGold);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.tbAgility);
            this.Controls.Add(this.tbStrength);
            this.Controls.Add(this.tbHealth);
            this.Controls.Add(this.tbGold);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAFNew";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Arena Fighter - New Player";
            this.TextChanged += new System.EventHandler(this.frmAFNew_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbGold;
        private System.Windows.Forms.TextBox tbHealth;
        private System.Windows.Forms.TextBox tbStrength;
        private System.Windows.Forms.TextBox tbAgility;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Button btnRollGold;
        private System.Windows.Forms.Button btnRollHealth;
        private System.Windows.Forms.Button btnRollStr;
        private System.Windows.Forms.Button btnRollAgi;
        private System.Windows.Forms.Button btnKeep;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Button btnCancel;
    }
}