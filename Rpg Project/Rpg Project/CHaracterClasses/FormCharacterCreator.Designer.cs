namespace Rpg_Project
{
    partial class FormCharacterCreator
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelAllocate = new System.Windows.Forms.Label();
            this.textBoxStrength = new System.Windows.Forms.TextBox();
            this.textBoxDexterity = new System.Windows.Forms.TextBox();
            this.textBoxWisdom = new System.Windows.Forms.TextBox();
            this.textBoxIntelligence = new System.Windows.Forms.TextBox();
            this.labelStrength = new System.Windows.Forms.Label();
            this.labelDexterity = new System.Windows.Forms.Label();
            this.labelWisdom = new System.Windows.Forms.Label();
            this.labelIntelligence = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.labelChooseClass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(111, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Choose a name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(129, 8);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(139, 48);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMale.TabIndex = 2;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(193, 48);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFemale.TabIndex = 3;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelGender.Location = new System.Drawing.Point(12, 48);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(121, 17);
            this.labelGender.TabIndex = 4;
            this.labelGender.Text = "Choose a gender:";
            // 
            // labelAllocate
            // 
            this.labelAllocate.AutoSize = true;
            this.labelAllocate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelAllocate.Location = new System.Drawing.Point(12, 84);
            this.labelAllocate.Name = "labelAllocate";
            this.labelAllocate.Size = new System.Drawing.Size(208, 17);
            this.labelAllocate.TabIndex = 5;
            this.labelAllocate.Text = "Allocate your 15 attribute points";
            // 
            // textBoxStrength
            // 
            this.textBoxStrength.Location = new System.Drawing.Point(101, 119);
            this.textBoxStrength.Name = "textBoxStrength";
            this.textBoxStrength.Size = new System.Drawing.Size(35, 20);
            this.textBoxStrength.TabIndex = 6;
            // 
            // textBoxDexterity
            // 
            this.textBoxDexterity.Location = new System.Drawing.Point(101, 163);
            this.textBoxDexterity.Name = "textBoxDexterity";
            this.textBoxDexterity.Size = new System.Drawing.Size(35, 20);
            this.textBoxDexterity.TabIndex = 7;
            // 
            // textBoxWisdom
            // 
            this.textBoxWisdom.Location = new System.Drawing.Point(101, 214);
            this.textBoxWisdom.Name = "textBoxWisdom";
            this.textBoxWisdom.Size = new System.Drawing.Size(35, 20);
            this.textBoxWisdom.TabIndex = 8;
            // 
            // textBoxIntelligence
            // 
            this.textBoxIntelligence.Location = new System.Drawing.Point(101, 259);
            this.textBoxIntelligence.Name = "textBoxIntelligence";
            this.textBoxIntelligence.Size = new System.Drawing.Size(35, 20);
            this.textBoxIntelligence.TabIndex = 9;
            // 
            // labelStrength
            // 
            this.labelStrength.AutoSize = true;
            this.labelStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelStrength.Location = new System.Drawing.Point(29, 120);
            this.labelStrength.Name = "labelStrength";
            this.labelStrength.Size = new System.Drawing.Size(66, 17);
            this.labelStrength.TabIndex = 10;
            this.labelStrength.Text = "Strength:";
            // 
            // labelDexterity
            // 
            this.labelDexterity.AutoSize = true;
            this.labelDexterity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDexterity.Location = new System.Drawing.Point(28, 164);
            this.labelDexterity.Name = "labelDexterity";
            this.labelDexterity.Size = new System.Drawing.Size(67, 17);
            this.labelDexterity.TabIndex = 11;
            this.labelDexterity.Text = "Dexterity:";
            // 
            // labelWisdom
            // 
            this.labelWisdom.AutoSize = true;
            this.labelWisdom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelWisdom.Location = new System.Drawing.Point(33, 215);
            this.labelWisdom.Name = "labelWisdom";
            this.labelWisdom.Size = new System.Drawing.Size(62, 17);
            this.labelWisdom.TabIndex = 12;
            this.labelWisdom.Text = "Wisdom:";
            // 
            // labelIntelligence
            // 
            this.labelIntelligence.AutoSize = true;
            this.labelIntelligence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelIntelligence.Location = new System.Drawing.Point(12, 260);
            this.labelIntelligence.Name = "labelIntelligence";
            this.labelIntelligence.Size = new System.Drawing.Size(83, 17);
            this.labelIntelligence.TabIndex = 13;
            this.labelIntelligence.Text = "Intelligence:";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(171, 208);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 71);
            this.buttonCreate.TabIndex = 14;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Items.AddRange(new object[] {
            "Warrior",
            "Rogue",
            "Cleric",
            "Mage"});
            this.comboBoxClass.Location = new System.Drawing.Point(171, 160);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(75, 21);
            this.comboBoxClass.TabIndex = 15;
            // 
            // labelChooseClass
            // 
            this.labelChooseClass.AutoSize = true;
            this.labelChooseClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelChooseClass.Location = new System.Drawing.Point(178, 120);
            this.labelChooseClass.Name = "labelChooseClass";
            this.labelChooseClass.Size = new System.Drawing.Size(68, 34);
            this.labelChooseClass.TabIndex = 16;
            this.labelChooseClass.Text = "Choose a\r\n   Class:";
            // 
            // FormCharacterCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 293);
            this.Controls.Add(this.labelChooseClass);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelIntelligence);
            this.Controls.Add(this.labelWisdom);
            this.Controls.Add(this.labelDexterity);
            this.Controls.Add(this.labelStrength);
            this.Controls.Add(this.textBoxIntelligence);
            this.Controls.Add(this.textBoxWisdom);
            this.Controls.Add(this.textBoxDexterity);
            this.Controls.Add(this.textBoxStrength);
            this.Controls.Add(this.labelAllocate);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "FormCharacterCreator";
            this.Text = "Character Creator";
            this.Load += new System.EventHandler(this.FormCharacterCreator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelAllocate;
        private System.Windows.Forms.TextBox textBoxStrength;
        private System.Windows.Forms.TextBox textBoxDexterity;
        private System.Windows.Forms.TextBox textBoxWisdom;
        private System.Windows.Forms.TextBox textBoxIntelligence;
        private System.Windows.Forms.Label labelStrength;
        private System.Windows.Forms.Label labelDexterity;
        private System.Windows.Forms.Label labelWisdom;
        private System.Windows.Forms.Label labelIntelligence;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label labelChooseClass;
    }
}