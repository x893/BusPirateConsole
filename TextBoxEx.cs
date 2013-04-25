using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BusPirate
{
	public class TextBoxEx : TextBox
	{
		public TextBoxEx()
		{
			// Enable internal TextBox double-buffering
			SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
		}
	}
}
