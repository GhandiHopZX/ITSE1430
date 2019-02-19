namespace GameManager.Host.Winforms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.OnGameSelected = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // OnGameSelected
            // 
            resources.ApplyResources(this.OnGameSelected, "OnGameSelected");
            this.OnGameSelected.FormattingEnabled = true;
            this.OnGameSelected.Name = "OnGameSelected";
            this.OnGameSelected.SelectedIndexChanged += new System.EventHandler(this.OnGameSelected_SelectedIndexChanged);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.OnGameSelected);
            this.Name = "MainForm";
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _miFileExit;
        private System.Windows.Forms.ToolStripMenuItem gamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _miGamesAdd;
        private System.Windows.Forms.ToolStripMenuItem _miGamesEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem _miGamesDelete;
        private System.Windows.Forms.ToolStripMenuItem _miHelpAbout;
        private System.Windows.Forms.Label _enName;
        private System.Windows.Forms.Label _enPublisher;
        private System.Windows.Forms.Label _enPrice;
        private System.Windows.Forms.TextBox en_Name;
        private System.Windows.Forms.TextBox en_Publisher;
        private System.Windows.Forms.CheckBox _cbOwned;
        private System.Windows.Forms.CheckBox _cbCompleted;
        private System.Windows.Forms.TextBox en_Price;
        private System.Windows.Forms.Button SaveBox;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ListBox OnGameSelected;
    }
}

