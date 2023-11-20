using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformWithExternalLibrary._DataProvider;
using WinformWithExternalLibrary.DataAccessObjects;

namespace WinformWithExternalLibrary
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			//		Form
			FormLogin.Instance = new FormLogin();

			Application.Run(FormLogin.Instance);
		}
	}
}
