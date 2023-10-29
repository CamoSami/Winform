using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformWithExternalLibrary.DataTransferObjects
{
    public class CongViecDTO
    {
		public Guid CongViecDTO_MaCongViec { get; set; }

        public int CongViecDTO_MucLuong { get; set; }

        public string CongViecDTO_TenCongViec { get; set; }

        public CongViecDTO(int congViecDTO_MucLuong, string congViecDTO_TenCongViec)
        {
            this.CongViecDTO_MucLuong = congViecDTO_MucLuong;
            this.CongViecDTO_TenCongViec = congViecDTO_TenCongViec;
        }

        public CongViecDTO() { }
    }
}
