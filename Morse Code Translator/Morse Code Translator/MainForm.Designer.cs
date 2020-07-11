
namespace Morse_Code_Translator
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
			this.TB = new System.Windows.Forms.TextBox();
			this.button = new System.Windows.Forms.Button();
			this.Translation = new System.Windows.Forms.Label();
			this.gradient1 = new Morse_Code_Translator.Gradient();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.gradient1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Text Box
			// 
			this.TB.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TB.Location = new System.Drawing.Point(823, 448);
			this.TB.Name = "TB";
			this.TB.Size = new System.Drawing.Size(1487, 106);
			this.TB.TabIndex = 0;
			// 
			// button
			// 
			this.button.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.button.BackColor = System.Drawing.Color.Transparent;
			this.button.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button.Location = new System.Drawing.Point(300, 445);
			this.button.Name = "button";
			this.button.Size = new System.Drawing.Size(525, 118);
			this.button.TabIndex = 0;
			this.button.Text = "TRANSLATE";
			this.button.UseVisualStyleBackColor = false;
			this.button.Click += new System.EventHandler(this.ButtonClick);
			// 
			// Translation
			// 
			this.Translation.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Translation.BackColor = System.Drawing.Color.White;
			this.Translation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Translation.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Translation.Location = new System.Drawing.Point(300, 587);
			this.Translation.Name = "Translation";
			this.Translation.Size = new System.Drawing.Size(2018, 728);
			this.Translation.TabIndex = 0;
			this.Translation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// gradient1
			// 
			this.gradient1.AutoSize = true;
			this.gradient1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.gradient1.ColorTop = System.Drawing.Color.Khaki;
			this.gradient1.Controls.Add(this.label2);
			this.gradient1.Controls.Add(this.label1);
			this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gradient1.Location = new System.Drawing.Point(0, 0);
			this.gradient1.Name = "gradient1";
			this.gradient1.Size = new System.Drawing.Size(2668, 1520);
			this.gradient1.TabIndex = 4;
			// 
			// Sub Title
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Tahoma", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(292, 270);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(2017, 123);
			this.label2.TabIndex = 1;
			this.label2.Text = "Enter a phrase or sentence and get it translated into morse code";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Main title
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(301, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(2009, 139);
			this.label1.TabIndex = 0;
			this.label1.Text = "MORSE CODE TRANSLATOR";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2668, 1520);
			this.Controls.Add(this.Translation);
			this.Controls.Add(this.button);
			this.Controls.Add(this.TB);
			this.Controls.Add(this.gradient1);
			this.Name = "MainForm";
			this.Text = "Morse Code Translator";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.gradient1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Morse_Code_Translator.Gradient gradient1;
		private System.Windows.Forms.Label Translation;
		private System.Windows.Forms.Button button;
		private System.Windows.Forms.TextBox TB;
	}
}
