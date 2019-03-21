namespace CharacterCreator.Winforms
{
    partial class CharForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Strength = new System.Windows.Forms.Label();
            this.Intelligence = new System.Windows.Forms.Label();
            this.Dexterity = new System.Windows.Forms.Label();
            this.Constitution = new System.Windows.Forms.Label();
            this.Agility = new System.Windows.Forms.Label();
            this.ProfessionBox = new System.Windows.Forms.ComboBox();
            this.RaceBox = new System.Windows.Forms.ComboBox();
            this.StrNumeric = new System.Windows.Forms.NumericUpDown();
            this.IntNumeric = new System.Windows.Forms.NumericUpDown();
            this.DexNumeric = new System.Windows.Forms.NumericUpDown();
            this.ConNumeric = new System.Windows.Forms.NumericUpDown();
            this.AgiNumeric = new System.Windows.Forms.NumericUpDown();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StrNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DexNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgiNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Race";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Profession";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // Strength
            // 
            this.Strength.AutoSize = true;
            this.Strength.Location = new System.Drawing.Point(27, 224);
            this.Strength.Name = "Strength";
            this.Strength.Size = new System.Drawing.Size(62, 17);
            this.Strength.TabIndex = 3;
            this.Strength.Text = "Strength";
            // 
            // Intelligence
            // 
            this.Intelligence.AutoSize = true;
            this.Intelligence.Location = new System.Drawing.Point(27, 264);
            this.Intelligence.Name = "Intelligence";
            this.Intelligence.Size = new System.Drawing.Size(79, 17);
            this.Intelligence.TabIndex = 4;
            this.Intelligence.Text = "Intelligence";
            // 
            // Dexterity
            // 
            this.Dexterity.AutoSize = true;
            this.Dexterity.Location = new System.Drawing.Point(27, 306);
            this.Dexterity.Name = "Dexterity";
            this.Dexterity.Size = new System.Drawing.Size(63, 17);
            this.Dexterity.TabIndex = 5;
            this.Dexterity.Text = "Dexterity";
            // 
            // Constitution
            // 
            this.Constitution.AutoSize = true;
            this.Constitution.Location = new System.Drawing.Point(27, 349);
            this.Constitution.Name = "Constitution";
            this.Constitution.Size = new System.Drawing.Size(85, 17);
            this.Constitution.TabIndex = 6;
            this.Constitution.Text = "Constitiution";
            // 
            // Agility
            // 
            this.Agility.AutoSize = true;
            this.Agility.Location = new System.Drawing.Point(27, 390);
            this.Agility.Name = "Agility";
            this.Agility.Size = new System.Drawing.Size(45, 17);
            this.Agility.TabIndex = 7;
            this.Agility.Text = "Agility";
            // 
            // ProfessionBox
            // 
            this.ProfessionBox.FormattingEnabled = true;
            this.ProfessionBox.Location = new System.Drawing.Point(238, 84);
            this.ProfessionBox.Name = "ProfessionBox";
            this.ProfessionBox.Size = new System.Drawing.Size(121, 24);
            this.ProfessionBox.TabIndex = 8;
            // 
            // RaceBox
            // 
            this.RaceBox.FormattingEnabled = true;
            this.RaceBox.Location = new System.Drawing.Point(238, 144);
            this.RaceBox.Name = "RaceBox";
            this.RaceBox.Size = new System.Drawing.Size(121, 24);
            this.RaceBox.TabIndex = 9;
            // 
            // StrNumeric
            // 
            this.StrNumeric.Location = new System.Drawing.Point(239, 224);
            this.StrNumeric.Name = "StrNumeric";
            this.StrNumeric.Size = new System.Drawing.Size(120, 22);
            this.StrNumeric.TabIndex = 11;
            this.StrNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // IntNumeric
            // 
            this.IntNumeric.Location = new System.Drawing.Point(239, 264);
            this.IntNumeric.Name = "IntNumeric";
            this.IntNumeric.Size = new System.Drawing.Size(120, 22);
            this.IntNumeric.TabIndex = 12;
            this.IntNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // DexNumeric
            // 
            this.DexNumeric.Location = new System.Drawing.Point(240, 306);
            this.DexNumeric.Name = "DexNumeric";
            this.DexNumeric.Size = new System.Drawing.Size(120, 22);
            this.DexNumeric.TabIndex = 13;
            this.DexNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // ConNumeric
            // 
            this.ConNumeric.Location = new System.Drawing.Point(239, 349);
            this.ConNumeric.Name = "ConNumeric";
            this.ConNumeric.Size = new System.Drawing.Size(120, 22);
            this.ConNumeric.TabIndex = 14;
            this.ConNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // AgiNumeric
            // 
            this.AgiNumeric.Location = new System.Drawing.Point(239, 390);
            this.AgiNumeric.Name = "AgiNumeric";
            this.AgiNumeric.Size = new System.Drawing.Size(120, 22);
            this.AgiNumeric.TabIndex = 15;
            this.AgiNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(238, 24);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(121, 22);
            this.NameBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(284, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CharForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 473);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.AgiNumeric);
            this.Controls.Add(this.ConNumeric);
            this.Controls.Add(this.DexNumeric);
            this.Controls.Add(this.IntNumeric);
            this.Controls.Add(this.StrNumeric);
            this.Controls.Add(this.RaceBox);
            this.Controls.Add(this.ProfessionBox);
            this.Controls.Add(this.Agility);
            this.Controls.Add(this.Constitution);
            this.Controls.Add(this.Dexterity);
            this.Controls.Add(this.Intelligence);
            this.Controls.Add(this.Strength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CharForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Character";
            ((System.ComponentModel.ISupportInitialize)(this.StrNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DexNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgiNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Strength;
        private System.Windows.Forms.Label Intelligence;
        private System.Windows.Forms.Label Dexterity;
        private System.Windows.Forms.Label Constitution;
        private System.Windows.Forms.Label Agility;
        private System.Windows.Forms.ComboBox ProfessionBox;
        private System.Windows.Forms.ComboBox RaceBox;
        private System.Windows.Forms.NumericUpDown StrNumeric;
        private System.Windows.Forms.NumericUpDown IntNumeric;
        private System.Windows.Forms.NumericUpDown DexNumeric;
        private System.Windows.Forms.NumericUpDown ConNumeric;
        private System.Windows.Forms.NumericUpDown AgiNumeric;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}