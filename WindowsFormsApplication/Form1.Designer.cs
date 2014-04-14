namespace WindowsFormsApplication
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.analyzeButton = new System.Windows.Forms.Button();
			this.cipherLabel = new System.Windows.Forms.Label();
			this.methodLabel = new System.Windows.Forms.Label();
			this.keyLabel = new System.Windows.Forms.Label();
			this.keyTextBox = new System.Windows.Forms.TextBox();
			this.keyLengthLabel = new System.Windows.Forms.Label();
			this.minUpDown = new System.Windows.Forms.NumericUpDown();
			this.maxUpDown = new System.Windows.Forms.NumericUpDown();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.enToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.esToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.frToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kasiskiBox = new System.Windows.Forms.CheckBox();
			this.cipherTextBox = new System.Windows.Forms.TextBox();
			this.resultTextBox = new System.Windows.Forms.TextBox();
			this.directionLabel = new System.Windows.Forms.Label();
			this.decryptionRadioButton = new System.Windows.Forms.RadioButton();
			this.encryptionRadioButton = new System.Windows.Forms.RadioButton();
			this.resultLabel = new System.Windows.Forms.Label();
			this.cleanButton = new System.Windows.Forms.Button();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.minUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.maxUpDown)).BeginInit();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// analyzeButton
			// 
			resources.ApplyResources(this.analyzeButton, "analyzeButton");
			this.analyzeButton.Name = "analyzeButton";
			this.analyzeButton.UseVisualStyleBackColor = true;
			this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
			// 
			// cipherLabel
			// 
			resources.ApplyResources(this.cipherLabel, "cipherLabel");
			this.cipherLabel.Name = "cipherLabel";
			// 
			// methodLabel
			// 
			resources.ApplyResources(this.methodLabel, "methodLabel");
			this.methodLabel.Name = "methodLabel";
			// 
			// keyLabel
			// 
			resources.ApplyResources(this.keyLabel, "keyLabel");
			this.keyLabel.Name = "keyLabel";
			// 
			// keyTextBox
			// 
			resources.ApplyResources(this.keyTextBox, "keyTextBox");
			this.keyTextBox.Name = "keyTextBox";
			// 
			// keyLengthLabel
			// 
			resources.ApplyResources(this.keyLengthLabel, "keyLengthLabel");
			this.keyLengthLabel.Name = "keyLengthLabel";
			// 
			// minUpDown
			// 
			resources.ApplyResources(this.minUpDown, "minUpDown");
			this.minUpDown.Name = "minUpDown";
			this.minUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.minUpDown.ValueChanged += new System.EventHandler(this.minUpDown_ValueChanged);
			// 
			// maxUpDown
			// 
			resources.ApplyResources(this.maxUpDown, "maxUpDown");
			this.maxUpDown.Name = "maxUpDown";
			this.maxUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
			this.maxUpDown.ValueChanged += new System.EventHandler(this.maxUpDown_ValueChanged);
			// 
			// menuStrip
			// 
			this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.helpToolStripMenuItem});
			resources.ApplyResources(this.menuStrip, "menuStrip");
			this.menuStrip.Name = "menuStrip";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
			// 
			// newToolStripMenuItem
			// 
			resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// openToolStripMenuItem
			// 
			resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			resources.ApplyResources(this.toolStripSeparator, "toolStripSeparator");
			// 
			// saveToolStripMenuItem
			// 
			resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// languageToolStripMenuItem
			// 
			this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enToolStripMenuItem,
            this.esToolStripMenuItem,
            this.deToolStripMenuItem,
            this.frToolStripMenuItem,
            this.ptToolStripMenuItem});
			this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
			resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
			// 
			// enToolStripMenuItem
			// 
			this.enToolStripMenuItem.Checked = true;
			this.enToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.enToolStripMenuItem.Name = "enToolStripMenuItem";
			resources.ApplyResources(this.enToolStripMenuItem, "enToolStripMenuItem");
			this.enToolStripMenuItem.Click += new System.EventHandler(this.enToolStripMenuItem_Click);
			// 
			// esToolStripMenuItem
			// 
			this.esToolStripMenuItem.Name = "esToolStripMenuItem";
			resources.ApplyResources(this.esToolStripMenuItem, "esToolStripMenuItem");
			this.esToolStripMenuItem.Click += new System.EventHandler(this.esToolStripMenuItem_Click);
			// 
			// deToolStripMenuItem
			// 
			this.deToolStripMenuItem.Name = "deToolStripMenuItem";
			resources.ApplyResources(this.deToolStripMenuItem, "deToolStripMenuItem");
			this.deToolStripMenuItem.Click += new System.EventHandler(this.deToolStripMenuItem_Click);
			// 
			// frToolStripMenuItem
			// 
			this.frToolStripMenuItem.Name = "frToolStripMenuItem";
			resources.ApplyResources(this.frToolStripMenuItem, "frToolStripMenuItem");
			this.frToolStripMenuItem.Click += new System.EventHandler(this.frToolStripMenuItem_Click);
			// 
			// ptToolStripMenuItem
			// 
			this.ptToolStripMenuItem.Name = "ptToolStripMenuItem";
			resources.ApplyResources(this.ptToolStripMenuItem, "ptToolStripMenuItem");
			this.ptToolStripMenuItem.Click += new System.EventHandler(this.ptToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// kasiskiBox
			// 
			resources.ApplyResources(this.kasiskiBox, "kasiskiBox");
			this.kasiskiBox.Name = "kasiskiBox";
			this.kasiskiBox.UseVisualStyleBackColor = true;
			this.kasiskiBox.CheckedChanged += new System.EventHandler(this.kasiskiBox_CheckedChanged);
			// 
			// cipherTextBox
			// 
			resources.ApplyResources(this.cipherTextBox, "cipherTextBox");
			this.cipherTextBox.Name = "cipherTextBox";
			// 
			// resultTextBox
			// 
			resources.ApplyResources(this.resultTextBox, "resultTextBox");
			this.resultTextBox.Name = "resultTextBox";
			// 
			// directionLabel
			// 
			resources.ApplyResources(this.directionLabel, "directionLabel");
			this.directionLabel.Name = "directionLabel";
			// 
			// decryptionRadioButton
			// 
			resources.ApplyResources(this.decryptionRadioButton, "decryptionRadioButton");
			this.decryptionRadioButton.Checked = true;
			this.decryptionRadioButton.Name = "decryptionRadioButton";
			this.decryptionRadioButton.TabStop = true;
			this.decryptionRadioButton.UseVisualStyleBackColor = true;
			this.decryptionRadioButton.CheckedChanged += new System.EventHandler(this.decryptionRadioButton_CheckedChanged);
			// 
			// encryptionRadioButton
			// 
			resources.ApplyResources(this.encryptionRadioButton, "encryptionRadioButton");
			this.encryptionRadioButton.Name = "encryptionRadioButton";
			this.encryptionRadioButton.UseVisualStyleBackColor = true;
			this.encryptionRadioButton.CheckedChanged += new System.EventHandler(this.encryptionRadioButton_CheckedChanged);
			// 
			// resultLabel
			// 
			resources.ApplyResources(this.resultLabel, "resultLabel");
			this.resultLabel.Name = "resultLabel";
			// 
			// cleanButton
			// 
			resources.ApplyResources(this.cleanButton, "cleanButton");
			this.cleanButton.Name = "cleanButton";
			this.cleanButton.UseVisualStyleBackColor = true;
			this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.cleanButton);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.encryptionRadioButton);
			this.Controls.Add(this.decryptionRadioButton);
			this.Controls.Add(this.directionLabel);
			this.Controls.Add(this.resultTextBox);
			this.Controls.Add(this.cipherTextBox);
			this.Controls.Add(this.kasiskiBox);
			this.Controls.Add(this.maxUpDown);
			this.Controls.Add(this.minUpDown);
			this.Controls.Add(this.keyLengthLabel);
			this.Controls.Add(this.keyTextBox);
			this.Controls.Add(this.keyLabel);
			this.Controls.Add(this.methodLabel);
			this.Controls.Add(this.cipherLabel);
			this.Controls.Add(this.analyzeButton);
			this.Controls.Add(this.menuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip;
			this.MaximizeBox = false;
			this.Name = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.minUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.maxUpDown)).EndInit();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button analyzeButton;
		private System.Windows.Forms.Label cipherLabel;
		private System.Windows.Forms.Label methodLabel;
		private System.Windows.Forms.Label keyLabel;
		private System.Windows.Forms.TextBox keyTextBox;
		private System.Windows.Forms.Label keyLengthLabel;
		private System.Windows.Forms.NumericUpDown minUpDown;
		private System.Windows.Forms.NumericUpDown maxUpDown;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.CheckBox kasiskiBox;
		private System.Windows.Forms.TextBox cipherTextBox;
		private System.Windows.Forms.TextBox resultTextBox;
		private System.Windows.Forms.Label directionLabel;
		private System.Windows.Forms.RadioButton decryptionRadioButton;
		private System.Windows.Forms.RadioButton encryptionRadioButton;
		private System.Windows.Forms.Label resultLabel;
		private System.Windows.Forms.Button cleanButton;
		private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem enToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem esToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem frToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ptToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
	}
}

