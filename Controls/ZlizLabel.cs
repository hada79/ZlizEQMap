using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ZlizEQMap
{
	[System.ComponentModel.DesignerCategory("Code")]
	public class ZlizLabel : Label
	{
		protected override void OnPaint(PaintEventArgs e)
		{
			string[] words = this.Text.Split(' ');
			Rectangle rect = new Rectangle(ClientRectangle.Location, ClientRectangle.Size);
			int accumulatedWidth = 0;
			int i = 0;

			foreach (char c in this.Text)
			{
				if (c == ' ' && !Char.IsUpper(this.Text[i + 1]))
				{
					accumulatedWidth += 5;
				}
				else if (Char.IsUpper(c))
				{
					Font large = new Font("Times New Roman", 36f, FontStyle.Bold);
					rect.Location = new Point(accumulatedWidth, 0);
					TextRenderer.DrawText(e.Graphics, c.ToString(), large, rect, ForeColor, TextFormatFlags.Left | TextFormatFlags.Bottom);
					accumulatedWidth += (int)e.Graphics.MeasureString(c.ToString(), large).Width - 11;
				}
				else
				{
					Font small = new Font("Times New Roman", 14f, FontStyle.Bold);
					rect.Location = new Point(accumulatedWidth, -6);
					TextRenderer.DrawText(e.Graphics, c.ToString().ToUpper(), small, rect, ForeColor, TextFormatFlags.Left | TextFormatFlags.Bottom);
					accumulatedWidth += (int)e.Graphics.MeasureString(c.ToString().ToUpper(), small).Width - 6;
				}

				i++;
			}
		}
	}
}
