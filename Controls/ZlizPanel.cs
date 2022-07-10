using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ZlizEQMap
{
	[System.ComponentModel.DesignerCategory("Code")]
	public class ZlizPanel : Panel
	{
		public Color BorderColor { get; set; }

		public ZlizPanel(Color borderColor)
		{
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
			this.BorderColor = borderColor;
		}

		protected override void OnPaintBackground(PaintEventArgs e)
		{
			base.OnPaintBackground(e);

			Pen pen = new Pen(BorderColor, 1f);

			e.Graphics.DrawRectangle(pen, 0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
		}
	}
}
