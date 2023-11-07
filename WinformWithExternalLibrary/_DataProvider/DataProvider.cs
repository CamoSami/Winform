using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WinformWithExternalLibrary._DataProvider
{

	public class DataProvider
	{
		#region Constants For Query String Building
		//		Table
		public const string KHACHHANG_TABLE = "tKhachHang";
		public const string NHACUNGCAP_TABLE = "tNhaCungCap";
		public const string HOADONBAN_TABLE = "tHoaDonBan";
		public const string HOADONNHAP_TABLE = "tHoaDonNhap";
		public const string CHITIETHDBAN_TABLE = "tChiTietHDBan";
		public const string CHITIETHDNHAP_TABLE = "tChiTietHDNhap";
		public const string CONGVIEC_TABLE = "tCongViec";
		public const string NHANVIEN_TABLE = "tNhanVien";
		public const string DMSANPHAM_TABLE = "tDMSanPham";
		public const string GIAMGIA_TABLE = "tGiamGia";
		#endregion

		public static DataProvider Instance { get; set; }

		private readonly string connectionString = "Data Source=(local)\\SQLEXPRESS; " +
										"Database= Database_QuanLyThuNhoiBong; " +
										"Trusted_Connection=True;  " +
										"MultipleActiveResultSets=True; " +
										"TrustServerCertificate=True";

		public DataProvider() { }

		public bool TestConnection(string connectionString = "")
		{
			if (connectionString.Equals(""))
			{
				connectionString = this.connectionString;
			}

			using (SqlConnection sqlConnection = new SqlConnection(connectionString))
			{
				try
				{
					sqlConnection.Open();

					return true;
				}
				catch (SqlException ex)
				{
					MaterialMessageBox.Show(
					text: "Có vấn đề j đó vừa xảy ra ._.\n\n" + ex.Message,
					caption: "ExecuteQuery",
					UseRichTextBox: false,
					buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
					);

					return false;
				}
			}
		}


		public DataTable ExecuteQuery(string query)
		{
			DataTable dataTable = new DataTable();
			
			try
			{
				using (SqlConnection sqlConnection = new SqlConnection(connectionString))
				{
					sqlConnection.Open();

					SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

					SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

					sqlDataAdapter.Fill(dataTable);

					sqlConnection.Close();
				}
			}
			catch (SqlException ex)
			{
				// Handle SQL exceptions
				Debug.WriteLine("SQL Exception occurred: " + ex.Message);

				MaterialMessageBox.Show(
					text: "Có vấn đề j đó vừa xảy ra ._.\n\n" + ex.Message,
					caption: "ExecuteQuery",
					UseRichTextBox: false,
					buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
					);
			}
			catch (Exception ex)
			{
				// Handle other exceptions
				Debug.WriteLine("Exception occurred: " + ex.Message);

				MaterialMessageBox.Show(
					text: "Có vấn đề j đó vừa xảy ra ._.\n\n" + ex.Message,
					caption: "ExecuteQuery",
					UseRichTextBox: false,
					buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
					);
			}

			return dataTable;
		}

		public int ExecuteNonQuery(string query)
		{
			int numberOfRowAffected = 0;

			try
			{

				using (SqlConnection sqlConnection = new SqlConnection(connectionString))
				{
					sqlConnection.Open();
					SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

					numberOfRowAffected = sqlCommand.ExecuteNonQuery();

					sqlConnection.Close();
				}
			}
			catch (SqlException ex)
			{
				// Handle SQL exceptions
				Debug.WriteLine("SQL Exception occurred: " + ex.Message);

				MaterialMessageBox.Show(
					text: "Có vấn đề j đó vừa xảy ra ._.\n\n" + ex.Message,
					caption: "ExecuteNonQuery",
					UseRichTextBox: false,
					buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
					);
			}
			catch (Exception ex)
			{
				// Handle other exceptions
				Debug.WriteLine("Exception occurred: " + ex.Message);

				MaterialMessageBox.Show(
					text: "Có vấn đề j đó vừa xảy ra ._.\n\n" + ex.Message,
					caption: "ExecuteNonQuery",
					UseRichTextBox: false,
					buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
					);
			}

			return numberOfRowAffected;
		}

		public object ExecuteScalar(string query)
		{
			object firstDataSlot = 0;
			try
			{
				using (SqlConnection sqlConnection = new SqlConnection(connectionString))
				{
					sqlConnection.Open();
					SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

					firstDataSlot = sqlCommand.ExecuteScalar();

					sqlConnection.Close();
				}
			}
			catch (SqlException ex)
			{
				// Handle SQL exceptions
				Debug.WriteLine("SQL Exception occurred: " + ex.Message);

				MaterialMessageBox.Show(
					text: "Có vấn đề j đó vừa xảy ra ._.\n\n" + ex.Message,
					caption: "ExecuteScalar",
					UseRichTextBox: false,
					buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
					);
			}
			catch (Exception ex)
			{
				// Handle other exceptions
				Debug.WriteLine("Exception occurred: " + ex.Message);

				MaterialMessageBox.Show(
					text: "Có vấn đề j đó vừa xảy ra ._.\n\n" + ex.Message,
					caption: "ExecuteScalar",
					UseRichTextBox: false,
					buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
					);
			}

			return firstDataSlot;
		}
	}
}
