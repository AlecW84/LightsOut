namespace LightsOut
{
	partial class AboutForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.TitleLabel = new System.Windows.Forms.Label();
			this.AuthorLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.DialogOkayButton = new System.Windows.Forms.Button();
			this.AboutImagePictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.AboutImagePictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.Font = new System.Drawing.Font("Pericles", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TitleLabel.Location = new System.Drawing.Point(140, 50);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(292, 56);
			this.TitleLabel.TabIndex = 0;
			this.TitleLabel.Text = "Lights Out!";
			// 
			// AuthorLabel
			// 
			this.AuthorLabel.AutoSize = true;
			this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AuthorLabel.Location = new System.Drawing.Point(147, 120);
			this.AuthorLabel.Name = "AuthorLabel";
			this.AuthorLabel.Size = new System.Drawing.Size(205, 31);
			this.AuthorLabel.TabIndex = 1;
			this.AuthorLabel.Text = "By Alec Watson";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(83, 174);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(303, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "Turn all the lights out (black) to win the game!";
			// 
			// DialogOkayButton
			// 
			this.DialogOkayButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.DialogOkayButton.Location = new System.Drawing.Point(184, 210);
			this.DialogOkayButton.Name = "DialogOkayButton";
			this.DialogOkayButton.Size = new System.Drawing.Size(75, 23);
			this.DialogOkayButton.TabIndex = 3;
			this.DialogOkayButton.Text = "Ok!";
			this.DialogOkayButton.UseVisualStyleBackColor = true;
			// 
			// AboutImagePictureBox
			// 
			this.AboutImagePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AboutImagePictureBox.Image")));
			this.AboutImagePictureBox.Location = new System.Drawing.Point(56, 50);
			this.AboutImagePictureBox.Name = "AboutImagePictureBox";
			this.AboutImagePictureBox.Size = new System.Drawing.Size(95, 101);
			this.AboutImagePictureBox.TabIndex = 4;
			this.AboutImagePictureBox.TabStop = false;
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(469, 261);
			this.Controls.Add(this.AboutImagePictureBox);
			this.Controls.Add(this.DialogOkayButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AuthorLabel);
			this.Controls.Add(this.TitleLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About";
			((System.ComponentModel.ISupportInitialize)(this.AboutImagePictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Label AuthorLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button DialogOkayButton;
		private System.Windows.Forms.PictureBox AboutImagePictureBox;
	}
}