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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Strength = new System.Windows.Forms.Label();
            this.Intelligence = new System.Windows.Forms.Label();
            this.Charisma = new System.Windows.Forms.Label();
            this.Constitution = new System.Windows.Forms.Label();
            this.Agility = new System.Windows.Forms.Label();
            this.StrNumeric = new System.Windows.Forms.NumericUpDown();
            this.IntNumeric = new System.Windows.Forms.NumericUpDown();
            this.ChaNumeric = new System.Windows.Forms.NumericUpDown();
            this.ConNumeric = new System.Windows.Forms.NumericUpDown();
            this.AgiNumeric = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.NameBox2 = new System.Windows.Forms.TextBox();
            this.ProfessionBox1 = new System.Windows.Forms.ComboBox();
            this.characterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.characterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RaceBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.StrNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChaNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgiNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).BeginInit();
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
            // Charisma
            // 
            this.Charisma.AutoSize = true;
            this.Charisma.Location = new System.Drawing.Point(27, 306);
            this.Charisma.Name = "Charisma";
            this.Charisma.Size = new System.Drawing.Size(67, 17);
            this.Charisma.TabIndex = 5;
            this.Charisma.Text = "Charisma";
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
            // ChaNumeric
            // 
            this.ChaNumeric.Location = new System.Drawing.Point(240, 306);
            this.ChaNumeric.Name = "ChaNumeric";
            this.ChaNumeric.Size = new System.Drawing.Size(120, 22);
            this.ChaNumeric.TabIndex = 13;
            this.ChaNumeric.Value = new decimal(new int[] {
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnSave);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(284, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Cancel);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // NameBox2
            // 
            this.errorProvider1.SetError(this.NameBox2, "Name required");
            this.NameBox2.Location = new System.Drawing.Point(239, 24);
            this.NameBox2.Name = "NameBox2";
            this.NameBox2.Size = new System.Drawing.Size(121, 22);
            this.NameBox2.TabIndex = 19;
            this.NameBox2.Validating += new System.ComponentModel.CancelEventHandler(this.NameBox2_Validating);
            // 
            // ProfessionBox1
            // 
            this.ProfessionBox1.DataSource = this.characterBindingSource1;
            this.ProfessionBox1.DisplayMember = "Swordsman";
            this.ProfessionBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProfessionBox1.FormattingEnabled = true;
            this.ProfessionBox1.Location = new System.Drawing.Point(239, 84);
            this.ProfessionBox1.Name = "ProfessionBox1";
            this.ProfessionBox1.Size = new System.Drawing.Size(121, 24);
            this.ProfessionBox1.TabIndex = 20;
            this.ProfessionBox1.Tag = "";
            this.ProfessionBox1.Validating += new System.ComponentModel.CancelEventHandler(this.ProfessionBox1_Validating);
            this.ProfessionBox1.Validated += new System.EventHandler(this.ProfessionBox1_Validated);
            // 
            // characterBindingSource1
            // 
            this.characterBindingSource1.DataSource = typeof(CharacterCreator.Character);
            // 
            // bindingSource2
            // 
            this.bindingSource2.CurrentChanged += new System.EventHandler(this.bindingSource2_CurrentChanged);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // characterBindingSource
            // 
            this.characterBindingSource.DataSource = typeof(CharacterCreator.Character);
            // 
            // RaceBox2
            // 
            this.RaceBox2.DataSource = this.characterBindingSource1;
            this.RaceBox2.DisplayMember = "Siren";
            this.RaceBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RaceBox2.FormattingEnabled = true;
            this.RaceBox2.Location = new System.Drawing.Point(239, 144);
            this.RaceBox2.Name = "RaceBox2";
            this.RaceBox2.Size = new System.Drawing.Size(121, 24);
            this.RaceBox2.TabIndex = 21;
            this.RaceBox2.Validating += new System.ComponentModel.CancelEventHandler(this.RaceBox2_Validating);
            this.RaceBox2.Validated += new System.EventHandler(this.RaceBox2_Validated);
            // 
            // CharForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 499);
            this.Controls.Add(this.RaceBox2);
            this.Controls.Add(this.ProfessionBox1);
            this.Controls.Add(this.NameBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AgiNumeric);
            this.Controls.Add(this.ConNumeric);
            this.Controls.Add(this.ChaNumeric);
            this.Controls.Add(this.IntNumeric);
            this.Controls.Add(this.StrNumeric);
            this.Controls.Add(this.Agility);
            this.Controls.Add(this.Constitution);
            this.Controls.Add(this.Charisma);
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
            ((System.ComponentModel.ISupportInitialize)(this.ChaNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgiNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Strength;
        private System.Windows.Forms.Label Intelligence;
        private System.Windows.Forms.Label Charisma;
        private System.Windows.Forms.Label Constitution;
        private System.Windows.Forms.Label Agility;
        private System.Windows.Forms.NumericUpDown StrNumeric;
        private System.Windows.Forms.NumericUpDown IntNumeric;
        private System.Windows.Forms.NumericUpDown ChaNumeric;
        private System.Windows.Forms.NumericUpDown ConNumeric;
        private System.Windows.Forms.NumericUpDown AgiNumeric;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox RaceBox2;
        private System.Windows.Forms.ComboBox ProfessionBox1;
        private System.Windows.Forms.BindingSource characterBindingSource;
        private System.Windows.Forms.TextBox NameBox2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource characterBindingSource1;
    }
}