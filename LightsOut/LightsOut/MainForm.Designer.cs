namespace LightsOut
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.threeByThreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fourByFourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fiveByFiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newGameButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.menuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// menuStrip2
			// 
			this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.sizeToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip2.Location = new System.Drawing.Point(0, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new System.Drawing.Size(584, 24);
			this.menuStrip2.TabIndex = 2;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// gameToolStripMenuItem
			// 
			this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
			this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.gameToolStripMenuItem.Text = "&Game";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.newToolStripMenuItem.Text = "&New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			// 
			// sizeToolStripMenuItem
			// 
			this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.threeByThreeToolStripMenuItem,
            this.fourByFourToolStripMenuItem,
            this.fiveByFiveToolStripMenuItem});
			this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
			this.sizeToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.sizeToolStripMenuItem.Text = "&Size";
			// 
			// threeByThreeToolStripMenuItem
			// 
			this.threeByThreeToolStripMenuItem.Checked = true;
			this.threeByThreeToolStripMenuItem.CheckOnClick = true;
			this.threeByThreeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.threeByThreeToolStripMenuItem.Name = "threeByThreeToolStripMenuItem";
			this.threeByThreeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.threeByThreeToolStripMenuItem.Text = "3x3";
			this.threeByThreeToolStripMenuItem.Click += new System.EventHandler(this.gridSizeToolStripMenuItem_Click);
			// 
			// fourByFourToolStripMenuItem
			// 
			this.fourByFourToolStripMenuItem.CheckOnClick = true;
			this.fourByFourToolStripMenuItem.Name = "fourByFourToolStripMenuItem";
			this.fourByFourToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.fourByFourToolStripMenuItem.Text = "4x4";
			this.fourByFourToolStripMenuItem.Click += new System.EventHandler(this.gridSizeToolStripMenuItem_Click);
			// 
			// fiveByFiveToolStripMenuItem
			// 
			this.fiveByFiveToolStripMenuItem.CheckOnClick = true;
			this.fiveByFiveToolStripMenuItem.Name = "fiveByFiveToolStripMenuItem";
			this.fiveByFiveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.fiveByFiveToolStripMenuItem.Text = "5x5";
			this.fiveByFiveToolStripMenuItem.Click += new System.EventHandler(this.gridSizeToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// newGameButton
			// 
			this.newGameButton.Location = new System.Drawing.Point(200, 531);
			this.newGameButton.Name = "newGameButton";
			this.newGameButton.Size = new System.Drawing.Size(75, 23);
			this.newGameButton.TabIndex = 3;
			this.newGameButton.Text = "New Game";
			this.newGameButton.UseVisualStyleBackColor = true;
			this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(300, 531);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 23);
			this.exitButton.TabIndex = 4;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 561);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.newGameButton);
			this.Controls.Add(this.menuStrip2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(250, 250);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lights Out!";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.MenuStrip menuStrip2;
		private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.Button newGameButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem threeByThreeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fourByFourToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fiveByFiveToolStripMenuItem;
	}
}

