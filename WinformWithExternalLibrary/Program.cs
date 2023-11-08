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


			//		GenerateData
			//this.InitializeFakeData();

			//		Data Access Objects
			DataProvider.Instance = new DataProvider();

			ChiTietHDBanDAO.Instance = new ChiTietHDBanDAO();
			CongViecDAO.Instance = new CongViecDAO();
			DMSanPhamDAO.Instance = new DMSanPhamDAO();
			GiamGiaDAO.Instance = new GiamGiaDAO();
			HoaDonBanDAO.Instance = new HoaDonBanDAO();
			KhachHangDAO.Instance = new KhachHangDAO();
			NhaCungCapDAO.Instance = new NhaCungCapDAO();
			NhanVienDAO.Instance = new NhanVienDAO();
			PhanTichDAO.Instance = new PhanTichDAO();

			//		Form
			FormLogin.Instance = new FormLogin();

			Application.Run(FormLogin.Instance);
		}
	}
}
