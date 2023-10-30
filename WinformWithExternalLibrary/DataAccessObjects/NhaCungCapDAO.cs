﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataTransferObjects;
using WinformWithExternalLibrary.DataValidateObjects;

namespace WinformWithExternalLibrary.DataAccessObjects
{
    public class NhaCungCapDAO
    {
        public static NhaCungCapDAO Instance { get; set; }

        public NhaCungCapDAO() { }

        public string GetNameWithPhoneNumber(string phoneNumber)
        {
            string selectSupplier = $"SELECT TenNhaCungCap FROM " +
                $"{DataProvider.NHACUNGCAP_TABLE}" +
                $"WHERE DienThoai = '{phoneNumber}'";
            
            object supplier = DataProvider.Instance.ExecuteScalar(selectSupplier);

            return supplier != null ? supplier.ToString().Trim() : "";
        }

        public List<string> GetPhoneNumbers()
        {
            string selectPhoneNumber = $"SELECT DienThoai FROM " +
                $"{DataProvider.NHACUNGCAP_TABLE}";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(selectPhoneNumber);
            
            List<string> phoneNumbers = new List<string>();

            foreach (DataRow row in dataTable.Rows)
            {
                phoneNumbers.Add(row[0].ToString().Trim());
            }

            return phoneNumbers;
        }

        public bool IfPhoneNumberTaken(string NhaCungCapDVO_DienThoai)
        {
            string selectPhoneNumber = $"SELECT * FROM " +
                $"{DataProvider.NHACUNGCAP_TABLE}" +
                $" WHERE DienThoai = " +
                $"'{NhaCungCapDVO_DienThoai}'";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(selectPhoneNumber);

            return dataTable.Rows.Count > 0;
        }

        public bool InsertNhaCungCap(dynamic baseDTO)
        {
            NhaCungCapDAO nhaCungCapDVO = baseDTO as NhaCungCapDAO;
            string insertSupplier = $"INSERT INTO " +
                $"{DataProvider.NHACUNGCAP_TABLE} " +
                $"(TenNhaCungCap, DienThoai, DiaChi) VALUES(N'{nhaCungCapDVO.NhaCungCapDTO_TenNhaCungCap}')"
        }
    }
}