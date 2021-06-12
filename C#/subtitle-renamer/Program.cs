using System;
using System.Windows.Forms;

namespace subtitle_renamer
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
	public static class Global
	{
		public static string path
		{
			get;
			set;
		}
		public static string name
		{
			get;
			set;
		}
		public static string season
		{
			get;
			set;
		}
		public static string quality
		{
			get;
			set;
		}
		public static string videoFormat
		{
			get;
			set;
		}
		public static int videoIndex
		{
			get;
			set;
		}
		public static string subtitleFormat
		{
			get;
			set;
		}
		public static int subtitleIndex
		{
			get;
			set;
		}
	}
}
