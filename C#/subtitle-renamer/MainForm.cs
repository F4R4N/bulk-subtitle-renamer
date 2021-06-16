using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace subtitle_renamer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public string ChooseFolder()
		{
			return folderBrowserDialog1.ShowDialog() == DialogResult.OK ? folderBrowserDialog1.SelectedPath : "";
		}
		public void setValues()
		{
			Global.name = textBox1.Text;
			Global.quality = textBox2.Text;
			Global.season = textBox3.Text;
			Global.videoFormat = comboBox1.SelectedItem.ToString();
			Global.videoIndex = (int)numericUpDown1.Value;
			Global.subtitleFormat = comboBox2.SelectedItem.ToString();
			Global.subtitleIndex = (int)numericUpDown2.Value;
		}
		public Dictionary<string, bool> checkValuesEmptiness()
		{
			var resault = new Dictionary<string, bool>();
			
			if (Global.path == null && textBox4.Text != "")
			{
				Global.path = textBox4.Text;
				resault["path"] = Global.path != "" || Global.path != null;
			}
			resault["name"] = Global.name != "";
			resault["season"] = Global.season != "";
			resault["quality"] = Global.quality != "";
			return resault;
		}
		public void rename()
		{
			try
			{
				Directory.SetCurrentDirectory(Global.path);
				var srcDir = new DirectoryInfo(Global.path);
				
				FileInfo[] videos = srcDir.GetFiles("*."+Global.videoFormat);
				FileInfo[] subtitles = srcDir.GetFiles("*."+Global.subtitleFormat);
				
				if (videos.Length == 0 || subtitles.Length == 0)
				{
					MessageBox.Show("there is no file with given movie or subtitle format in this directory.", "Bad path", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					var regex = new Regex(@"\d+");
					foreach(FileInfo video in videos)
					{
						string episodeNumber = regex.Matches(video.Name)[Global.videoIndex-1].ToString();
						string videoName = string.Format("{0}-S{1}-E{2}-{3}.{4}", Global.name, Global.season, episodeNumber, Global.quality, Global.videoFormat);
						File.Move(video.Name, videoName);
					}
					foreach(FileInfo subtitle in subtitles)
					{
						string episodeNumber = regex.Matches(subtitle.Name)[Global.subtitleIndex-1].ToString();
						string subtitleName = string.Format("{0}-S{1}-E{2}-{3}.{4}", Global.name, Global.season, episodeNumber, Global.quality, Global.subtitleFormat);
						File.Move(subtitle.Name, subtitleName);
					}
					MessageBox.Show("Job Done!", "Renaming complete.", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch(DirectoryNotFoundException)
			{
				MessageBox.Show(string.Format("Unable to locate the given directory path at '{0}'.", Global.path), "Directory not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
				
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			Global.path = ChooseFolder();
			textBox4.Enabled = false;
			textBox4.Text = Global.path;
		}
		void Button2Click(object sender, EventArgs e)
		{
			
			setValues();
			var valuesState = checkValuesEmptiness();
			foreach(var data in valuesState){
				Controls["error"+data.Key].Text = "";
				if (!data.Value){
					Controls["error"+data.Key].Text = "field should not be empty";
				}
			}
			if(valuesState.All(val => val.Value)){  // if all of the values in dictionary is true
				var sure = MessageBox.Show("Are you sure you want to rename the files? this action is undo-able please check the given data again.", "Are you sure?",  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (sure == DialogResult.Yes)
				{
					rename();
				}
			}
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			comboBox1.SelectedIndex = 0;
			comboBox2.SelectedIndex = 0;
		}
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://github.com/F4R4N");
		}
		void LinkLabel2LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://www.gnu.org/licenses/lgpl-3.0.en.html");
		}
		void Button3Click(object sender, EventArgs e)
		{
			var helpForm = new HelpForm();
			helpForm.Show();
		}
		void Label8Click(object sender, EventArgs e)
		{
	
		}
		void TextBox4OnClick(object sender, EventArgs e)
		{
			button1.Enabled = false;
		}
	}
}