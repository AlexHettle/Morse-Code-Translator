﻿
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace Morse_Code_Translator
{
	/// <summary>
	/// Class used in order to create the app's gradient background 
	/// </summary>
	public class Gradient : Panel
	{
		public Color ColorTop { get; set; }
		public Color ColorBottom { get; set; }
		protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new 
            LinearGradientBrush(this.ClientRectangle, this.ColorTop, 
            this.ColorBottom, 90F);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);
            base.OnPaint(e);
        }
	}
}
