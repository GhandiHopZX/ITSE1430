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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharForm));
            this._RaceBox = new System.Windows.Forms.ComboBox();
            this.characterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this._ProfessionBox = new System.Windows.Forms.ComboBox();
            this.professionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Strength = new System.Windows.Forms.NumericUpDown();
            this.Intelligence = new System.Windows.Forms.NumericUpDown();
            this.Agility = new System.Windows.Forms.NumericUpDown();
            this.Constitution = new System.Windows.Forms.NumericUpDown();
            this.Charisma = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NewCharName = new System.Windows.Forms.Label();
            this._NameBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.professionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.raceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.professionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Strength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Intelligence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Agility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Constitution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Charisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // _RaceBox
            // 
            this._RaceBox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this._RaceBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterBindingSource, "Name", true));
            this._RaceBox.DataSource = this.raceBindingSource;
            this._RaceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._RaceBox.FormattingEnabled = true;
            resources.ApplyResources(this._RaceBox, "_RaceBox");
            this._RaceBox.Name = "_RaceBox";
            this._RaceBox.UseWaitCursor = true;
            this._RaceBox.SelectedIndexChanged += new System.EventHandler(this.OnCancel);
            this._RaceBox.Validating += new System.ComponentModel.CancelEventHandler(this.RaceBox);
            // 
            // characterBindingSource
            // 
            this.characterBindingSource.DataSource = typeof(CharacterCreator.Character);
            // 
            // raceBindingSource
            // 
            this.raceBindingSource.DataMember = "Race";
            this.raceBindingSource.DataSource = this.characterBindingSource;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.UseWaitCursor = true;
            // 
            // _ProfessionBox
            // 
            this._ProfessionBox.DataSource = this.professionBindingSource;
            this._ProfessionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._ProfessionBox.FormattingEnabled = true;
            resources.ApplyResources(this._ProfessionBox, "_ProfessionBox");
            this._ProfessionBox.Name = "_ProfessionBox";
            this._ProfessionBox.UseWaitCursor = true;
            this._ProfessionBox.Validating += new System.ComponentModel.CancelEventHandler(this.ProfessionBox);
            // 
            // professionBindingSource
            // 
            this.professionBindingSource.DataMember = "Profession";
            this.professionBindingSource.DataSource = this.characterBindingSource;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.UseWaitCursor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.UseWaitCursor = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.UseWaitCursor = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.label6.UseWaitCursor = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.label7.UseWaitCursor = true;
            // 
            // Strength
            // 
            resources.ApplyResources(this.Strength, "Strength");
            this.Strength.Name = "Strength";
            this.Strength.UseWaitCursor = true;
            this.Strength.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Intelligence
            // 
            resources.ApplyResources(this.Intelligence, "Intelligence");
            this.Intelligence.Name = "Intelligence";
            this.Intelligence.UseWaitCursor = true;
            this.Intelligence.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Agility
            // 
            resources.ApplyResources(this.Agility, "Agility");
            this.Agility.Name = "Agility";
            this.Agility.UseWaitCursor = true;
            this.Agility.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Constitution
            // 
            resources.ApplyResources(this.Constitution, "Constitution");
            this.Constitution.Name = "Constitution";
            this.Constitution.UseWaitCursor = true;
            this.Constitution.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Charisma
            // 
            resources.ApplyResources(this.Charisma, "Charisma");
            this.Charisma.Name = "Charisma";
            this.Charisma.UseWaitCursor = true;
            this.Charisma.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.OnCancel);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.OnAddButton);
            // 
            // NewCharName
            // 
            resources.ApplyResources(this.NewCharName, "NewCharName");
            this.NewCharName.Name = "NewCharName";
            this.NewCharName.UseWaitCursor = true;
            // 
            // _NameBox
            // 
            resources.ApplyResources(this._NameBox, "_NameBox");
            this._NameBox.Name = "_NameBox";
            this._NameBox.UseWaitCursor = true;
            this._NameBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameBox);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider3.ContainerControl = this;
            // 
            // professionBindingSource1
            // 
            this.professionBindingSource1.DataMember = "Profession";
            this.professionBindingSource1.DataSource = this.characterBindingSource;
            // 
            // raceBindingSource1
            // 
            this.raceBindingSource1.DataMember = "Race";
            this.raceBindingSource1.DataSource = this.characterBindingSource;
            // 
            // professionBindingSource2
            // 
            this.professionBindingSource2.DataMember = "Profession";
            this.professionBindingSource2.DataSource = this.characterBindingSource;
            // 
            // CharForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._NameBox);
            this.Controls.Add(this.NewCharName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Charisma);
            this.Controls.Add(this.Constitution);
            this.Controls.Add(this.Agility);
            this.Controls.Add(this.Intelligence);
            this.Controls.Add(this.Strength);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._ProfessionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._RaceBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharForm";
            this.ShowIcon = false;
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Strength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Intelligence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Agility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Constitution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Charisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _RaceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _ProfessionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Strength;
        private System.Windows.Forms.NumericUpDown Intelligence;
        private System.Windows.Forms.NumericUpDown Agility;
        private System.Windows.Forms.NumericUpDown Constitution;
        private System.Windows.Forms.NumericUpDown Charisma;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label NewCharName;
        private System.Windows.Forms.TextBox _NameBox;
        private System.Windows.Forms.BindingSource characterBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.BindingSource professionBindingSource;
        private System.Windows.Forms.BindingSource raceBindingSource;
        private System.Windows.Forms.BindingSource professionBindingSource1;
        private System.Windows.Forms.BindingSource raceBindingSource1;
        private System.Windows.Forms.BindingSource professionBindingSource2;
    }
}