using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Message
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void timeButton_Click(object sender, EventArgs e)
		{
			
			DateTime now = DateTime.Now;
			string dt = DateTime.Now.ToString();
			

			//分辨早安午安晚安

			string date = TransTime(now);


			//輸出現在時間
			timeLabel.Text = dt + "\r\n" + date;

			MessageBox.Show(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
		}

		private string TransTime(DateTime date)
		{ 
			int hour = date.Hour;
			string talk = string.Empty;
			if (hour >= 6 && hour < 12)
			{
				talk = "早安";
			}
			else if (hour >= 12 && hour < 18)
			{
				talk = "午安";
			}
			else
			{
				talk = "晚安";
			}
			return talk;
		}

		private void timeLabel_Click(object sender, EventArgs e)
		{
			
		}

		
	}

}
  