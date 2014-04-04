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
			this.cipherTextBox = new System.Windows.Forms.RichTextBox();
			this.analyzeButton = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.resultTextBox = new System.Windows.Forms.RichTextBox();
			this.cipherLabel = new System.Windows.Forms.Label();
			this.methodLabel = new System.Windows.Forms.Label();
			this.resultLabel = new System.Windows.Forms.Label();
			this.keyTextBox = new System.Windows.Forms.TextBox();
			this.keyLengthLabel = new System.Windows.Forms.Label();
			this.minUpDown = new System.Windows.Forms.NumericUpDown();
			this.maxUpDown = new System.Windows.Forms.NumericUpDown();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.minUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.maxUpDown)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cipherTextBox
			// 
			resources.ApplyResources(this.cipherTextBox, "cipherTextBox");
			this.cipherTextBox.Name = "cipherTextBox";
			// 
			// analyzeButton
			// 
			resources.ApplyResources(this.analyzeButton, "analyzeButton");
			this.analyzeButton.Name = "analyzeButton";
			this.analyzeButton.UseVisualStyleBackColor = true;
			this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
			// 
			// radioButton1
			// 
			resources.ApplyResources(this.radioButton1, "radioButton1");
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.TabStop = true;
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			resources.ApplyResources(this.radioButton2, "radioButton2");
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.TabStop = true;
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// resultTextBox
			// 
			resources.ApplyResources(this.resultTextBox, "resultTextBox");
			this.resultTextBox.Name = "resultTextBox";
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
			// resultLabel
			// 
			resources.ApplyResources(this.resultLabel, "resultLabel");
			this.resultLabel.Name = "resultLabel";
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
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
			resources.ApplyResources(this.menuStrip1, "menuStrip1");
			this.menuStrip1.Name = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
			// 
			// newToolStripMenuItem
			// 
			resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			// 
			// openToolStripMenuItem
			// 
			resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
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
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			resources.ApplyResources(this.saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
			// 
			// printToolStripMenuItem
			// 
			resources.ApplyResources(this.printToolStripMenuItem, "printToolStripMenuItem");
			this.printToolStripMenuItem.Name = "printToolStripMenuItem";
			// 
			// printPreviewToolStripMenuItem
			// 
			resources.ApplyResources(this.printPreviewToolStripMenuItem, "printPreviewToolStripMenuItem");
			this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
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
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
			// 
			// undoToolStripMenuItem
			// 
			this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
			resources.ApplyResources(this.undoToolStripMenuItem, "undoToolStripMenuItem");
			// 
			// redoToolStripMenuItem
			// 
			this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
			resources.ApplyResources(this.redoToolStripMenuItem, "redoToolStripMenuItem");
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
			// 
			// cutToolStripMenuItem
			// 
			resources.ApplyResources(this.cutToolStripMenuItem, "cutToolStripMenuItem");
			this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			// 
			// copyToolStripMenuItem
			// 
			resources.ApplyResources(this.copyToolStripMenuItem, "copyToolStripMenuItem");
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			// 
			// pasteToolStripMenuItem
			// 
			resources.ApplyResources(this.pasteToolStripMenuItem, "pasteToolStripMenuItem");
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
			// 
			// selectAllToolStripMenuItem
			// 
			this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			resources.ApplyResources(this.selectAllToolStripMenuItem, "selectAllToolStripMenuItem");
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
			// 
			// customizeToolStripMenuItem
			// 
			this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
			resources.ApplyResources(this.customizeToolStripMenuItem, "customizeToolStripMenuItem");
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
			// 
			// contentsToolStripMenuItem
			// 
			this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
			resources.ApplyResources(this.contentsToolStripMenuItem, "contentsToolStripMenuItem");
			// 
			// indexToolStripMenuItem
			// 
			this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
			resources.ApplyResources(this.indexToolStripMenuItem, "indexToolStripMenuItem");
			// 
			// searchToolStripMenuItem
			// 
			this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
			resources.ApplyResources(this.searchToolStripMenuItem, "searchToolStripMenuItem");
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.maxUpDown);
			this.Controls.Add(this.minUpDown);
			this.Controls.Add(this.keyLengthLabel);
			this.Controls.Add(this.keyTextBox);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.methodLabel);
			this.Controls.Add(this.cipherLabel);
			this.Controls.Add(this.resultTextBox);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.analyzeButton);
			this.Controls.Add(this.cipherTextBox);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.minUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.maxUpDown)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox cipherTextBox;
		private System.Windows.Forms.Button analyzeButton;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RichTextBox resultTextBox;
		private System.Windows.Forms.Label cipherLabel;
		private System.Windows.Forms.Label methodLabel;
		private System.Windows.Forms.Label resultLabel;
		private System.Windows.Forms.TextBox keyTextBox;
		private System.Windows.Forms.Label keyLengthLabel;
		private System.Windows.Forms.NumericUpDown minUpDown;
		private System.Windows.Forms.NumericUpDown maxUpDown;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
	}
}

