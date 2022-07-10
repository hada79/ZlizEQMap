using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ZlizEQMap
{
	partial class ZlizEQMapForm
	{
		private void SetControlProperties()
		{
			labelZoneName.BackColor = Color.Transparent;
			labelLegend.BackColor = Color.Transparent;
			checkLegend.BackColor = Color.Transparent;
			checkEnableDirection.BackColor = Color.Transparent;
			checkGroupByContinent.BackColor = Color.Transparent;
			checkAutoSizeOnMapSwitch.BackColor = Color.Transparent;
			panelMain.BackColor = Color.Transparent;
			flowSubMaps.BackColor = Color.Transparent;
			linkLabelWiki.BackColor = Color.Transparent;
			notifyIcon1.Text = "ZlizEQMap";
			notifyIcon1.Icon = ZlizEQMap.Properties.Resources.wufist_14;
			checkAlwaysOnTop.BackColor = Color.Transparent;
			sliderOpacity.BackColor = Color.FromArgb(251, 246, 224);
		}
	}
}
