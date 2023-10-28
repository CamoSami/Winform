﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using WinformWithExternalLibrary.DataTransferObjects;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace WinformWithExternalLibrary.DataAccessObjects
{
    public class NhanVienDAO
    {
        public static NhanVienDAO Instance { get; set; }
        public NhanVienDAO() { }

        //Có nút tạo mới Nhân viên
        public bool InsertNhanVien(dynamic baseDTO)
        {
            NhanVienDTO NhanVienDTO = baseDTO as NhanVienDTO;
            
			string insertNhanVien = "Insert into " +
                                DataProvider.NHANVIEN_TABLE +
                                " (MaCongViec,TenNhanVien,NgaySinh,DiaChi,DienThoai,GioiTinh) VALUES (" +
                                    "N'" + NhanVienDTO.NhanVienDTO_MaCongViec + "'" +
                                    "N'" + NhanVienDTO.NhanVienDTO_TenNhanVien + "'" +
                                    "N'" + NhanVienDTO.NhanVienDTO_NgaySinh + "'" +
                                    "N'" + NhanVienDTO.NhanVienDTO_DiaChi + "'" +
                                    "N'" + NhanVienDTO.NhanVienDTO_DienThoai + "'" +
                                    "N'" + NhanVienDTO.NhanVienDTO_GioiTinh + "'" +
                                    ")";
            
			int rowChanged = DataProvider.Instance.ExecuteNonQuery(insertNhanVien);
            
			return rowChanged > 0;
        }

        //Hiện danh sách nhân viên đã được nhập
        public List<NhanVienDTO> HienThiDanhSachNhanVien()
        {
            List<NhanVienDTO> danhSachNhanVien = new List<NhanVienDTO>();

            string query = "SELECT MaNhanVien, MaCongViec, TenNhanVien, NgaySinh, DiaChi, DienThoai, GioiTinh " +
							"FROM " + DataProvider.NHANVIEN_TABLE;

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow row in dataTable.Rows)
			{
				NhanVienDTO nhanVienDTO = new NhanVienDTO();

				nhanVienDTO.NhanVienDTO_MaNhanVien = (Guid)row[0];
				nhanVienDTO.NhanVienDTO_MaCongViec = (Guid)row[1];
				nhanVienDTO.NhanVienDTO_TenNhanVien = (string)row[2];
				nhanVienDTO.NhanVienDTO_NgaySinh = (DateTime)row[3];
				nhanVienDTO.NhanVienDTO_DiaChi = (string)row[4];
				nhanVienDTO.NhanVienDTO_DienThoai = (string)row[5];
				nhanVienDTO.NhanVienDTO_GioiTinh = (string)row[6];

				//Debug.WriteLine(nhanVienDTO.GetFullString());

				danhSachNhanVien.Add(nhanVienDTO);
			}

			return danhSachNhanVien;
        }        

    }

}