using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bogus;
using Bogus.Extensions;
using WinformWithExternalLibrary.DataAccessObjects;
using WinformWithExternalLibrary.DataTransferObjects;

namespace WinformWithExternalLibrary.CustomComponent
{
	public class BogusAmogus
	{

		private string[] stringGioiTinh = new string[] { "Nam", "Nữ" };

		public class ThuBongName
		{
			public string thuBong { get; set; }
			public string thuBongCombineVerb { get; set; }
			public string thuBongAdj { get; set; }
			public string thuBongVerb { get; set; }
			public string thuBongExtra { get; set; }
			public string thuBongName { get; set; }
		}

		public BogusAmogus()
		{
			Randomizer.Seed = new Random(601040903);
		}

		public void GenerateFakeData()
		{
			int soLuong_DMSanPhamDTO = 250;
			int soLuong_NhanVienDTO = 25;
			int soLuong_NhaCungCapDTO = 40;
			int soLuong_HoaDonNhapDTO = 200;
			int soLuong_KhachHangDTO = 120;
			int soLuong_HoaDonBanDTO = 600;

			this.Generate_CongViecDTO();
			this.Generate_DMSanPhamDTO(soLuong_DMSanPhamDTO);
			this.Generate_NhanVienDTO(soLuong_NhanVienDTO);
			this.Generate_NhaCungCapDTO(soLuong_NhaCungCapDTO);
			this.Generate_HoaDonNhapDTO(soLuong_HoaDonNhapDTO);
			this.Generate_KhachHangDTO(soLuong_KhachHangDTO);
			this.Generate_HoaDonBanDTO(soLuong_HoaDonBanDTO);
			this.Generate_ChiTietHDNhapDTO();
			this.Generate_ChiTietHDBanDTO();
		}

		private void Generate_DMSanPhamDTO(int soLuong)
		{
			string[] thuBong = new string[]
			{
				"Hoa hướng dương",
				"Heo bông",
				"Mèo bông",
				"Chó bông",
				"Gấu bông",
				"Rồng bông",
				"Amogus bông",
				"Vịt bông",
				"Gà bông",
				"Bò bông",
				"Trâu bông",
				"Chó Shiba bông",
				"Gấu trúc Panda bông",
				"Thỏ bông Melody",
				"Thỏ bông Cinnamoroll",
				"Thỏ bông Kuromi",
				"Mèo bông Hoàng thượng",
				"Khủng long bông",
				"Doremon bông",
				"Cá mập bông",
				"Mực bông",
				"Bạch tuộc bông",
				"Cáo bông",
				"Gối ôm thỏ",
				"Gối ôm chó",
				"Gối ôm mèo",
				"Gối ôm gấu",
				"Thỏ bông Pacha",
				"Trái bơ",
				"Trái đào",
				"Chuột bông Hamster",
				"Bò sửa bông",
				"Hổ bông",
				"Ong bông",
				"Voi bông",
				"Cá voi",
				"Gấu đỏ",
				"Huơu cao cổ",
				"Unicorn",
				"Hà mã bông",
				"Cừu bông",
				"Lạc đà bông",
				"Gấu bông bắc cực"
			};
			string[] thuBongCombineVerb = new string[]
			{
				"Ôm đùi",
				"Ôm mặt",
				"Cosplay"
			};
			string[] thuBongAdj = new string[]
			{
				"Mặt ngáo",
				"Hơi đần",
				"Xám",
				"Hồng",
				"Xanh dịu",
				"Trắng toát",
				"Cam",
				"Đỏ choét",
				"Tím",
				"Đầu to (rất to)",
				"Chằm Zn",
				"Xì teen",
				"Đáng iu",
				"Tiktok",
				"Trầm kẻm",
				"Siêu mềm",
				"OwO",
				"UwU",
				"ƠwƯ",
				"Ơ~Ơ",
				"Màu hường",
				"Màu galaxy",
				"Lười bướng",
				"Dễ ghéc",
				"Má hường",
				"Má phúng phính",
				"Hoàng thượng",
				"Tren Tiktok",
				"TókTók",
				"Lông mịn",
				"Lông mềm",
				"Lông smooth",
				"Đa cảm xúc",
				"Dui dẻ",
				"Nằm lười bướng",
				"Có cánh",
				"Có sừng dài 2m",
				"Có nón lá",
				"Béo ú",
				"Nhỏ bé xinh xinh",
				"X~X",
				"Kute",
				"Xinh xẻo",
				"Đầm hoa Caro",
				"Đầm hoa xinh UwU",
				"Nice Day",
				":D",
				"Mặc đồ bơi",
				"Đang đói (rất đói)",
				"Cầu vồng",
				"Biết bay",
				"Biết nói (thật đó)",
				"Biết gào (?????)",
				"Biết buồn (nó muốn được ôm)",
				"Lông cừu"
			};
			string[] thuBongVerb = new string[]
			{
				"Bất cần đời",
				"Có mền",
				"Nằm ngủ",
				"Đeo băng đô",
				"Cầm dao",
				"Mặc Hamburger",
				"Có súng (và đạn 9mm)",
				"Ngồi ngủ",
				"Ngồi ăn",
				"Đeo túi 7 màu",
				"Mặt tròn xoeeeee",
				"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt",
				"Ôm bình sữa",
				"Ôm trái đất",
				"Ôm tà tữa",
				"Ôm mặt trăng",
				"Đội Hoa hướng dương",
				"Baby UwU",
				"Tu bình sữa",
				"Ôm hoa",
				"Muốn ôm (ôm nó ik)",
				"Đứng giơ tay",
				"Nằm giơ tay",
				"Nằm khoanh tay (nó dỗi r)",
				"Ôm trái đào",
				"Ôm bánh kẹp",
				"Ăn dưa hấu",
				"Ăn người vô tội",
				"Dâu Lotso",
				"Ngồi đội mũ rời",
				"Mặc hoodie",
				"Mặc overall",
				"Giơ tay",
				"Cầm bánh",
				"Ôm dâu",
				"Lè lưỡi lêu lêu",
				"Mặc hoodie mèo",
				"Đeo tai nghe xịn",
			};
			string[] thuBongExtra = new string[]
			{
				"2in1",
				"3in1",
				"4in1",
				"5in1",
				"6in1",
				"7in1",
				"8in1",
				"9in1",
				"10in1",
				"sus"
			};

			DateTime dateTimeMin = new DateTime(year: 2023, month: 12, day: 31);
			DateTime dateTimeMax = new DateTime(year: 2024, month: 12, day: 31);

			Faker<ThuBongName> fakerName = new Faker<ThuBongName>(locale: "vi")
				.StrictMode(true)
				.RuleFor(name => name.thuBong, f => (f.PickRandom(thuBong) + " "))
				.RuleFor(name => name.thuBongCombineVerb, f => (f.PickRandom(thuBongCombineVerb) + " " + f.PickRandom(thuBong) + " ").OrDefault(f: f, defaultWeight: 0.9f, defaultValue: ""))
				.RuleFor(name => name.thuBongAdj, f => (f.PickRandom(thuBongVerb) + " "))
				.RuleFor(name => name.thuBongVerb, f => (f.PickRandom(thuBongVerb) + " "))
				.RuleFor(name => name.thuBongExtra, f => (f.PickRandom(thuBongExtra) + " ").OrDefault(f: f, defaultWeight: 0.9f, defaultValue: ""))
				.RuleFor(name => name.thuBongName, (f, u) => (u.thuBong + u.thuBongCombineVerb + u.thuBongAdj + u.thuBongVerb + u.thuBongExtra));

			Faker<DMSanPhamDTO> DTOfaker = new Faker<DMSanPhamDTO>(locale: "vi")
				.RuleFor(DTO => DTO.DMSanPhamDTO_MaSanPham, f => f.Phone.PhoneNumber(format: "############"))
				.RuleFor(DTO => DTO.DMSanPhamDTO_DonGiaNhap, f => f.Random.Number(min: 1000, max: 7990))
				.RuleFor(DTO => DTO.DMSanPhamDTO_DonGiaBan, (f, DTO) => (DTO.DMSanPhamDTO_DonGiaNhap + f.Random.Number(min: 200, max: 500)))
				.RuleFor(DTO => DTO.DMSanPhamDTO_SoLuongTonKho, f => f.Random.Number(min: 4, max: 29))
				.RuleFor(DTO => DTO.DMSanPhamDTO_TenSanPham, f => fakerName.Generate().thuBongName)
				.RuleFor(DTO => DTO.DMSanPhamDTO_ThoiGianBaoHanh, f => f.Date.Between(start: dateTimeMin, end: dateTimeMax))
				.FinishWith((f, DTO) =>
				{
					string queryString = $"INSERT INTO {DataProvider.DMSANPHAM_TABLE}" +
					$" (MaSanPham, DonGiaNhap, DonGiaBan, SoLuongTonKho, TenHangHoa, ThoiGianBaoHanh)" +
					$" VALUES" +
					$" ({this.GetString(DTO.DMSanPhamDTO_MaSanPham)}," +
					$" {DTO.DMSanPhamDTO_DonGiaNhap * 100}," +
					$" {DTO.DMSanPhamDTO_DonGiaBan * 100}," +
					$" {DTO.DMSanPhamDTO_SoLuongTonKho}," +
					$" {this.GetString(DTO.DMSanPhamDTO_TenSanPham)}," +
					$" {this.GetString(DTO.DMSanPhamDTO_ThoiGianBaoHanh)})";

					DataProvider.Instance.ExecuteNonQuery(queryString);
				});

			DTOfaker.Generate(count: soLuong);
		}

		private void Generate_CongViecDTO()
		{
			CongViecDTO[] congViecDTOs = new CongViecDTO[]
			{
				new CongViecDTO(
					congViecDTO_MucLuong: 65000,
					congViecDTO_TenCongViec: "Nghiên cíu"
				),
				new CongViecDTO(
					congViecDTO_MucLuong: 75000,
					congViecDTO_TenCongViec: "Dịch vụ khách hàng"
				),
				new CongViecDTO(
					congViecDTO_MucLuong: 70000,
					congViecDTO_TenCongViec: "Quản lý kho"
				),
				new CongViecDTO(
					congViecDTO_MucLuong: 65000,
					congViecDTO_TenCongViec: "Quản lý quầy sản phẩm"
				),
				new CongViecDTO(
					congViecDTO_MucLuong: 67500,
					congViecDTO_TenCongViec: "Lau dọn và bảo quản"
				),
				new CongViecDTO(
					congViecDTO_MucLuong: 75000,
					congViecDTO_TenCongViec: "Thu ngân"
				),
				new CongViecDTO(
					congViecDTO_MucLuong: 70000,
					congViecDTO_TenCongViec: "Quản lý trang MXH"
				),
				new CongViecDTO(
					congViecDTO_MucLuong: 70000,
					congViecDTO_TenCongViec: "Phối hợp với nhà cung cấp"
				),
				new CongViecDTO(
					congViecDTO_MucLuong: 100000,
					congViecDTO_TenCongViec: "Quản lý"
				),
			};

			foreach (CongViecDTO congViecDTO in congViecDTOs)
			{
				string queryString = $"INSERT INTO {DataProvider.CONGVIEC_TABLE}" +
					$" (MucLuong, TenCongViec)" +
					$" VALUES" +
					$" ({congViecDTO.CongViecDTO_MucLuong}," +
					$" N'{congViecDTO.CongViecDTO_TenCongViec}')";

				DataProvider.Instance.ExecuteNonQuery(queryString);
			}
		}

		private void Generate_NhanVienDTO(int soLuong)
		{
			string queryStringMaCongViec = $"SELECT MaCongViec FROM {DataProvider.CONGVIEC_TABLE}";

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(queryStringMaCongViec);
			List<Guid> tempMaCongViecs = new List<Guid>();

			foreach (DataRow dataRow in dataTable.Rows)
			{
				Guid.TryParse(dataRow[0].ToString(), out Guid tempGuid);

				tempMaCongViecs.Add(tempGuid);

				//Debug.WriteLine(tempGuid);
			}

			DateTime dateTimeMin = new DateTime(year: 1950, month: 1, day: 1);
			DateTime dateTimeMax = new DateTime(year: 2005, month: 12, day: 31);

			Faker<NhanVienDTO> faker = new Faker<NhanVienDTO>(locale: "vi")
				.RuleFor(DTO => DTO.NhanVienDTO_MaCongViec, f => f.PickRandom(tempMaCongViecs))
				.RuleFor(DTO => DTO.NhanVienDTO_TenNhanVien, f => f.Name.LastName() + " " + f.Name.FirstName())
				.RuleFor(DTO => DTO.NhanVienDTO_NgaySinh, f => f.Date.Between(start: dateTimeMin, end: dateTimeMax))
				.RuleFor(DTO => DTO.NhanVienDTO_DiaChi, f => f.Address.StreetAddress())
				.RuleFor(DTO => DTO.NhanVienDTO_DienThoai, f => f.Phone.PhoneNumber(format: "##########"))
				.RuleFor(DTO => DTO.NhanVienDTO_GioiTinh, f => f.PickRandom(stringGioiTinh).OrDefault(f: f, defaultWeight: 0.1f, defaultValue: "GT thứ 3"))
				.FinishWith((f, DTO) =>
				{
					string queryString = $"INSERT INTO {DataProvider.NHANVIEN_TABLE}" +
					$"(MaCongViec, TenNhanVien, NgaySinh, DiaChi, DienThoai, GioiTinh) VALUES (" +
					$"{this.GetString(DTO.NhanVienDTO_MaCongViec)}," +
					$"{this.GetString(DTO.NhanVienDTO_TenNhanVien)}," +
					$"{this.GetString(DTO.NhanVienDTO_NgaySinh)}," +
					$"{this.GetString(DTO.NhanVienDTO_DiaChi)}," +
					$"{this.GetString(DTO.NhanVienDTO_DienThoai)}," +
					$"{this.GetString(DTO.NhanVienDTO_GioiTinh)}" +
					$")";

					DataProvider.Instance.ExecuteNonQuery(queryString);
				});

			faker.Generate(soLuong);
		}

		private void Generate_NhaCungCapDTO(int soLuong)
		{
			Faker<NhaCungCapDTO> faker = new Faker<NhaCungCapDTO>(locale: "vi")
				.RuleFor(DTO => DTO.NhaCungCapDTO_TenNhaCungCap, f => f.Company.CompanyName())
				.RuleFor(DTO => DTO.NhaCungCapDTO_DienThoai, f => f.Phone.PhoneNumber(format: "##########"))
				.RuleFor(DTO => DTO.NhaCungCapDTO_DiaChi, f => f.Address.StreetAddress())
				.FinishWith((f, DTO) =>
				{
					//Debug.WriteLine($"\nTenNhaCungCap: {DTO.NhaCungCapDTO_TenNhaCungCap}" +
					//	$"\nDienThoai: {DTO.NhaCungCapDTO_DienThoai}" +
					//	$"\nDiaChi: {DTO.NhaCungCapDTO_DiaChi}" +
					//	$"\n");

					string queryString = $"INSERT INTO {DataProvider.NHACUNGCAP_TABLE}" +
					$"(TenNhaCungCap, DienThoai, DiaChi) VALUES (" +
					$"{this.GetString(DTO.NhaCungCapDTO_TenNhaCungCap)}," +
					$"{this.GetString(DTO.NhaCungCapDTO_DienThoai)}," +
					$"{this.GetString(DTO.NhaCungCapDTO_DiaChi)}" +
					$")";

					DataProvider.Instance.ExecuteNonQuery(queryString);
				});

			faker.Generate(soLuong);
		}

		private void Generate_HoaDonNhapDTO(int soLuong)
		{
			string queryStringMaNhaCungCap = $"SELECT MaNhaCungCap FROM {DataProvider.NHACUNGCAP_TABLE}";

			DataTable dataTableMaNhaCungCap = DataProvider.Instance.ExecuteQuery(queryStringMaNhaCungCap);
			List<Guid> tempMaNhaCungCap = new List<Guid>();

			foreach (DataRow dataRow in dataTableMaNhaCungCap.Rows)
			{
				Guid.TryParse(dataRow[0].ToString(), out Guid tempGuid);

				tempMaNhaCungCap.Add(tempGuid);

				//Debug.WriteLine(tempGuid);
			}

			//Debug.WriteLine("\n\n");

			string queryStringMaNhanVien = $"SELECT MaNhanVien FROM {DataProvider.NHANVIEN_TABLE} " +
				$"JOIN {DataProvider.CONGVIEC_TABLE} " +
				$"ON {DataProvider.NHANVIEN_TABLE}.MaCongViec = {DataProvider.CONGVIEC_TABLE}.MaCongViec " +
				$"WHERE TenCongViec = N'Phối hợp với nhà cung cấp'";

			DataTable dataTableMaNhanVien = DataProvider.Instance.ExecuteQuery(queryStringMaNhanVien);
			List<Guid> tempMaNhanVien = new List<Guid>();

			foreach (DataRow dataRow in dataTableMaNhanVien.Rows)
			{
				Guid.TryParse(dataRow[0].ToString(), out Guid tempGuid);

				tempMaNhanVien.Add(tempGuid);

				//Debug.WriteLine(tempGuid);
			}

			DateTime dateTimeMin = new DateTime(year: 2010, month: 1, day: 1);

			Faker<HoaDonNhapDTO> faker = new Faker<HoaDonNhapDTO>(locale: "vi")
				.RuleFor(DTO => DTO.HoaDonNhapDTO_MaNhaCungCap, f => f.PickRandom(tempMaNhaCungCap))
				.RuleFor(DTO => DTO.HoaDonNhapDTO_MaNhanVien, f => f.PickRandom(tempMaNhanVien))
				.RuleFor(DTO => DTO.HoaDonNhapDTO_NgayNhap, f => f.Date.Between(start: dateTimeMin, end: DateTime.Now))
				.RuleFor(DTO => DTO.HoaDonNhapDTO_SoSanPham, f => f.Random.Number(min: 1, max: 4))
				.RuleFor(DTO => DTO.HoaDonNhapDTO_GiamGia, f => f.Random.Number(min: 200, max: 5000).OrDefault(f: f, defaultValue: 0, defaultWeight: 0.9f))
				.RuleFor(DTO => DTO.HoaDonNhapDTO_TongTien, f => f.Random.Number(min: 5000, max: 50000))
				.FinishWith((f, DTO) =>
				{
					//Debug.WriteLine($"\n{this.GetString(DTO.HoaDonNhapDTO_MaNhaCungCap)}" +
					//	$"\n{this.GetString(DTO.HoaDonNhapDTO_MaNhanVien)}" +
					//	$"\n{this.GetString(DTO.HoaDonNhapDTO_NgayNhap)}" +
					//	$"\n{DTO.HoaDonNhapDTO_GiamGia * 1000}" +
					//	$"\n{DTO.HoaDonNhapDTO_TongTien * 1000}");

					string queryString = $"INSERT INTO {DataProvider.HOADONNHAP_TABLE} " +
					$"(MaNhaCungCap, MaNhanVien, NgayNhap, SoSanPham, GiamGia, TongTien) VALUES (" +
					$"{this.GetString(DTO.HoaDonNhapDTO_MaNhaCungCap)}," +
					$"{this.GetString(DTO.HoaDonNhapDTO_MaNhanVien)}," +
					$"{this.GetString(DTO.HoaDonNhapDTO_NgayNhap)}," +
					$"{DTO.HoaDonNhapDTO_SoSanPham}," +
					$"{DTO.HoaDonNhapDTO_GiamGia * 100}," +
					$"{DTO.HoaDonNhapDTO_TongTien * 100}" +
					$")";

					DataProvider.Instance.ExecuteNonQuery(queryString);
				});

			faker.Generate(soLuong);
		}

		private void Generate_KhachHangDTO(int soLuong)
		{
			Faker<KhachHangDTO> faker = new Faker<KhachHangDTO>(locale: "vi")
					.RuleFor(u => u.KhachHangDTO_TenKhachHang, f => f.Name.LastName() + " " + f.Name.FirstName())
					.RuleFor(u => u.KhachHangDTO_DienThoai, f => f.Phone.PhoneNumber(format: "##########"))
					.RuleFor(u => u.KhachHangDTO_DiaChi, f => f.Address.StreetAddress())
					.FinishWith((f, DTO) =>
					{
						string queryString = $"INSERT INTO {DataProvider.KHACHHANG_TABLE} " +
						$"(TenKhachHang, DienThoai, DiaChi) VALUES (" +
						$"{this.GetString(DTO.KhachHangDTO_TenKhachHang)}," +
						$"{this.GetString(DTO.KhachHangDTO_DienThoai)}," +
						$"{this.GetString(DTO.KhachHangDTO_DiaChi)}" +
						$")";

						DataProvider.Instance.ExecuteNonQuery(queryString);
					});

			faker.Generate(soLuong);

			string queryStringLaTao = $"INSERT INTO {DataProvider.KHACHHANG_TABLE} " +
						$"(TenKhachHang, DienThoai, DiaChi) VALUES (" +
						$"{this.GetString("Ngô Sách Minh Hiếu")}," +
						$"{this.GetString("0977255636")}," +
						$"{this.GetString("Làng Vòng")}" +
						$")";

			DataProvider.Instance.ExecuteNonQuery(queryStringLaTao);
		}

		private void Generate_HoaDonBanDTO(int soLuong)
		{
			string queryStringKhachHang = $"SELECT MaKhachHang FROM {DataProvider.KHACHHANG_TABLE}";

			DataTable dataTableMaKhachHang = DataProvider.Instance.ExecuteQuery(queryStringKhachHang);
			List<Guid> tempMaKhachHang = new List<Guid>();

			foreach (DataRow dataRow in dataTableMaKhachHang.Rows)
			{
				Guid.TryParse(dataRow[0].ToString(), out Guid tempGuid);

				tempMaKhachHang.Add(tempGuid);

				//Debug.WriteLine(tempGuid);
			}

			//Debug.WriteLine("\n\n");

			string queryStringMaNhanVien = $"SELECT MaNhanVien FROM {DataProvider.NHANVIEN_TABLE} " +
				$"JOIN {DataProvider.CONGVIEC_TABLE} " +
				$"ON {DataProvider.NHANVIEN_TABLE}.MaCongViec = {DataProvider.CONGVIEC_TABLE}.MaCongViec " +
				$"WHERE TenCongViec = N'Thu ngân'";

			DataTable dataTableMaNhanVien = DataProvider.Instance.ExecuteQuery(queryStringMaNhanVien);
			List<Guid> tempMaNhanVien = new List<Guid>();

			foreach (DataRow dataRow in dataTableMaNhanVien.Rows)
			{
				Guid.TryParse(dataRow[0].ToString(), out Guid tempGuid);

				tempMaNhanVien.Add(tempGuid);

				//Debug.WriteLine(tempGuid);
			}

			DateTime dateTimeMin = new DateTime(year: 2010, month: 1, day: 1);

			Faker<HoaDonBanDTO> faker = new Faker<HoaDonBanDTO>(locale: "vi")
				.RuleFor(DTO => DTO.HoaDonBanDTO_MaKhachHang, f => f.PickRandom(tempMaKhachHang).OrNull(f: f, nullWeight: 0.9f))
				.RuleFor(DTO => DTO.HoaDonBanDTO_MaNhanVien, f => f.PickRandom(tempMaNhanVien))
				.RuleFor(DTO => DTO.HoaDonBanDTO_NgayBan, f => f.Date.Between(start: dateTimeMin, end: DateTime.Now))
				.RuleFor(DTO => DTO.HoaDonBanDTO_SoSanPham, f => f.Random.Number(min: 1, max: 4))
				.RuleFor(DTO => DTO.HoaDonBanDTO_GiamGia, f => f.Random.Number(min: 200, max: 5000).OrDefault(f: f, defaultValue: 0, defaultWeight: 0.9f))
				.RuleFor(DTO => DTO.HoaDonBanDTO_TongTien, f => f.Random.Number(min: 2000, max: 50000))
				.FinishWith((f, DTO) =>
				{
					//Debug.WriteLine($"\n{this.GetString(DTO.HoaDonNhapDTO_MaNhaCungCap)}" +
					//	$"\n{this.GetString(DTO.HoaDonNhapDTO_MaNhanVien)}" +
					//	$"\n{this.GetString(DTO.HoaDonNhapDTO_NgayNhap)}" +
					//	$"\n{DTO.HoaDonNhapDTO_GiamGia * 1000}" +
					//	$"\n{DTO.HoaDonNhapDTO_TongTien * 1000}");

					string queryString;

					if (DTO.HoaDonBanDTO_MaKhachHang != null)
					{
						queryString = $"INSERT INTO {DataProvider.HOADONBAN_TABLE} " +
							$"(MaKhachHang, MaNhanVien, NgayBan, SoSanPham, GiamGia, TongTien) VALUES (" +
							$"{this.GetString(DTO.HoaDonBanDTO_MaKhachHang)}," +
							$"{this.GetString(DTO.HoaDonBanDTO_MaNhanVien)}," +
							$"{this.GetString(DTO.HoaDonBanDTO_NgayBan)}," +
							$"{DTO.HoaDonBanDTO_SoSanPham}," +
							$"{DTO.HoaDonBanDTO_GiamGia * 100}," +
							$"{DTO.HoaDonBanDTO_TongTien * 100}" +
							$")";
					}
					else
					{
						queryString = $"INSERT INTO {DataProvider.HOADONBAN_TABLE} " +
							$"(MaNhanVien, NgayBan, SoSanPham, GiamGia, TongTien) VALUES (" +
							$"{this.GetString(DTO.HoaDonBanDTO_MaNhanVien)}," +
							$"{this.GetString(DTO.HoaDonBanDTO_NgayBan)}," +
							$"{DTO.HoaDonBanDTO_SoSanPham}," +
							$"{DTO.HoaDonBanDTO_GiamGia * 100}," +
							$"{DTO.HoaDonBanDTO_TongTien * 100}" +
							$")";
					}

					DataProvider.Instance.ExecuteNonQuery(queryString);
				});

			faker.Generate(soLuong);
		}

		private void Generate_ChiTietHDNhapDTO()
		{
			string queryStringHDNhap = $"SELECT MaHDNhap, SoSanPham FROM {DataProvider.HOADONNHAP_TABLE}";

			DataTable dataTableHDNhap = DataProvider.Instance.ExecuteQuery(queryStringHDNhap);
			List<Guid> tempMaHDNhap = new List<Guid>();
			List<int> tempSoSanPham = new List<int>();

			foreach (DataRow dataRow in dataTableHDNhap.Rows)
			{
				Guid.TryParse(dataRow[0].ToString(), out Guid tempGuid);

				tempMaHDNhap.Add(tempGuid);
				tempSoSanPham.Add(int.Parse(dataRow[1].ToString()));

				//Debug.WriteLine(tempGuid);
			}

			string queryStringDMSanPham = $"SELECT MaDMSanPham, DonGiaNhap FROM {DataProvider.DMSANPHAM_TABLE}";

			DataTable dataTableDMSanPham = DataProvider.Instance.ExecuteQuery(queryStringDMSanPham);
			List<Guid> tempMaDMSanPham = new List<Guid>();
			List<int> tempDonGiaNhap = new List<int>();

			foreach (DataRow dataRow in dataTableDMSanPham.Rows)
			{
				Guid.TryParse(dataRow[0].ToString(), out Guid tempGuid);

				tempMaDMSanPham.Add(tempGuid);
				tempDonGiaNhap.Add(int.Parse(dataRow[1].ToString()));

				//Debug.WriteLine(tempGuid);
			}

			Faker<ChiTietHDNhapDTO> faker = new Faker<ChiTietHDNhapDTO>(locale: "vi")
				.RuleFor(DTO => DTO.ChiTietHDNhapDTO_SoLuong, f => f.Random.Number(min: 4, max: 20));

			Random random = new Random();

			for (int i = 0; i < tempMaHDNhap.Count; i++)
			{
				List<Guid> usedMaSanPham = new List<Guid>();
				int triGiaHDNhap = 0;

				for (int j = 0; j < tempSoSanPham[i]; j++)
				{
					ChiTietHDNhapDTO temp = faker.Generate();
					Guid maSanPham = tempMaDMSanPham[random.Next(minValue: 0, maxValue: tempMaDMSanPham.Count)];

					while (usedMaSanPham.Contains(maSanPham))
					{
						maSanPham = tempMaDMSanPham[random.Next(minValue: 0, maxValue: tempMaDMSanPham.Count)];
					}

					triGiaHDNhap += tempDonGiaNhap[tempMaDMSanPham.IndexOf(maSanPham)] * temp.ChiTietHDNhapDTO_SoLuong;

					string queryString = $"INSERT INTO {DataProvider.CHITIETHDNHAP_TABLE} " +
						$"(MaHDNhap, MaDMSanPham, SoLuong, ThanhTien) VALUES (" +
						$"{this.GetString(tempMaHDNhap[i])}," +
						$"{this.GetString(maSanPham)}," +
						$"{temp.ChiTietHDNhapDTO_SoLuong}," +
						$"{tempDonGiaNhap[tempMaDMSanPham.IndexOf(maSanPham)] * temp.ChiTietHDNhapDTO_SoLuong}" +
						$")";

					DataProvider.Instance.ExecuteQuery(queryString);

					usedMaSanPham.Add(maSanPham);
				}

				string queryStringUpdate = $"UPDATE {DataProvider.HOADONNHAP_TABLE} " +
					$"SET TongTien = {triGiaHDNhap} " +
					$"WHERE MaHDNhap = {this.GetString(tempMaHDNhap[i])}";

				DataProvider.Instance.ExecuteQuery(queryStringUpdate);
			}
		}

		private void Generate_ChiTietHDBanDTO()
		{
			string queryStringHDBan = $"SELECT MaHDBan, SoSanPham FROM {DataProvider.HOADONBAN_TABLE}";

			DataTable dataTableHDBan = DataProvider.Instance.ExecuteQuery(queryStringHDBan);
			List<Guid> tempMaHDBan = new List<Guid>();
			List<int> tempSoSanPham = new List<int>();

			foreach (DataRow dataRow in dataTableHDBan.Rows)
			{
				Guid.TryParse(dataRow[0].ToString(), out Guid tempGuid);

				tempMaHDBan.Add(tempGuid);
				tempSoSanPham.Add(int.Parse(dataRow[1].ToString()));

				//Debug.WriteLine(tempGuid);
			}

			string queryStringDMSanPham = $"SELECT MaDMSanPham, DonGiaBan FROM {DataProvider.DMSANPHAM_TABLE}";

			DataTable dataTableDMSanPham = DataProvider.Instance.ExecuteQuery(queryStringDMSanPham);
			List<Guid> tempMaDMSanPham = new List<Guid>();
			List<int> tempDonGiaBan = new List<int>();

			foreach (DataRow dataRow in dataTableDMSanPham.Rows)
			{
				Guid.TryParse(dataRow[0].ToString(), out Guid tempGuid);

				tempMaDMSanPham.Add(tempGuid);
				tempDonGiaBan.Add(int.Parse(dataRow[1].ToString()));

				//Debug.WriteLine(tempGuid);
			}

			Faker<ChiTietHDBanDTO> faker = new Faker<ChiTietHDBanDTO>(locale: "vi")
				.RuleFor(DTO => DTO.ChiTietHDBanDTO_SoLuong, f => f.Random.Number(min: 1, max: 5));

			Random random = new Random();

			for (int i = 0; i < tempMaHDBan.Count; i++)
			{
				List<Guid> usedMaSanPham = new List<Guid>();
				int triGiaHDBan = 0;

				for (int j = 0; j < tempSoSanPham[i]; j++)
				{
					ChiTietHDBanDTO temp = faker.Generate();
					Guid maSanPham = tempMaDMSanPham[random.Next(minValue: 0, maxValue: tempMaDMSanPham.Count)];

					while (usedMaSanPham.Contains(maSanPham))
					{
						maSanPham = tempMaDMSanPham[random.Next(minValue: 0, maxValue: tempMaDMSanPham.Count)];
					}

					triGiaHDBan += tempDonGiaBan[tempMaDMSanPham.IndexOf(maSanPham)] * temp.ChiTietHDBanDTO_SoLuong;

					string queryString = $"INSERT INTO {DataProvider.CHITIETHDBAN_TABLE} " +
						$"(MaHDBan, MaDMSanPham, SoLuong, ThanhTien) VALUES (" +
						$"{this.GetString(tempMaHDBan[i])}," +
						$"{this.GetString(maSanPham)}," +
						$"{temp.ChiTietHDBanDTO_SoLuong}," +
						$"{tempDonGiaBan[tempMaDMSanPham.IndexOf(maSanPham)] * temp.ChiTietHDBanDTO_SoLuong}" +
						$")";

					DataProvider.Instance.ExecuteQuery(queryString);

					usedMaSanPham.Add(maSanPham);
				}

				string queryStringUpdate = $"UPDATE {DataProvider.HOADONBAN_TABLE} " +
					$"SET TongTien = {triGiaHDBan} " +
					$"WHERE MaHDBan = {this.GetString(tempMaHDBan[i])}";

				DataProvider.Instance.ExecuteQuery(queryStringUpdate);
			}
		}



		private string GetString(dynamic obj)
		{
			return "N'" + obj.ToString() + "'";
		}
	}
}
