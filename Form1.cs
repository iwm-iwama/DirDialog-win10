using System;
using System.Windows.Forms;

namespace iwm_DirDialog
{
	public partial class Form1 : Form
	{
		private const string VERSION = "DirDialog iwm20210601";

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Text = VERSION;
			Pub.Rtn = RtnDirSelect();
			Application.Exit();
		}

		private string RtnDirSelect()
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog
			{
				Description = "フォルダを指定してください。",
				RootFolder = Environment.SpecialFolder.MyComputer,
				SelectedPath = Environment.CurrentDirectory,
				ShowNewFolderButton = true
			};

			if (fbd.ShowDialog(this) == DialogResult.OK)
			{
				return $"\"{fbd.SelectedPath}\"";
			}

			return "";
		}
	}

	public class Pub
	{
		public static string Rtn = "";
	}

	public class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());

			Console.Write(Pub.Rtn);
		}
	}
}
