using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformWithExternalLibrary.DataAccessObjects;
using WinformWithExternalLibrary.DataTransferObjects;
using WinformWithExternalLibrary.DataValidateObjects;

namespace WinformWithExternalLibrary.ExtraForm
{
	public partial class FormCreateCongViec : MaterialForm
	{
		public FormCreateCongViec()
		{
			this.InitializeComponent();

			this.CreateNewJob();
		}

		public void CreateNewJob()
		{
			TabPageNV_btnOK.Click += (object sender, EventArgs e) =>
			{
				// Tạo một đối tượng CongViecDTO mới
				CongViecDTO congViecDTO = new CongViecDTO();

				// Lấy dữ liệu từ các điều khiển trên giao diện và đặt giá trị vào đối tượng CongViecDTO
				congViecDTO.CongViecDTO_MaCongViec = Guid.NewGuid();
				congViecDTO.CongViecDTO_TenCongViec = CongViecDVO_TenCongViec.Text;
				congViecDTO.CongViecDTO_MucLuong = long.Parse(CongViecDVO_MucLuong.Text);

				// Tạo một đối tượng CongViecDVO để kiểm tra tính hợp lệ của dữ liệu
				CongViecDVO validator = new CongViecDVO(
					congViecDTO.CongViecDTO_MaCongViec,
					congViecDTO.CongViecDTO_TenCongViec,
					congViecDTO.CongViecDTO_MucLuong
				);

				// Sử dụng ValidateObject để kiểm tra tính hợp lệ của dữ liệu
				var validationResults = new List<ValidationResult>();

				if (Validator.TryValidateObject(validator, new ValidationContext(validator), validationResults, validateAllProperties: true))
				{
					// Dữ liệu hợp lệ, thực hiện các hành động tiếp theo, ví dụ: thêm vào danh sách công việc
					bool res = CongViecDAO.Instance.InsertCongViec(congViecDTO);
					if (res)
					{
						// Sau đó, có thể thực hiện các hành động khác như làm mới giao diện, hiển thị thông báo, ...
						this.ClearForm();
						this.ShowSuccessMessage("Công việc đã được thêm mới thành công!");
					}

					else
					{
						this.ShowSuccessMessage("Công việc đã được thêm mới không thành công.Hãy thử lại!");
					}
				}
				else
				{
					// Dữ liệu không hợp lệ, xử lý các lỗi (ví dụ: hiển thị thông báo lỗi)
					string errorMessage = string.Join(Environment.NewLine, validationResults.Select(result => result.ErrorMessage));

					this.ShowErrorMessage(errorMessage);
				}
			};
		}

		// Đoạn mã giả định cho việc làm mới giao diện và hiển thị thông báo
		private void ClearForm()
		{
			// Thực hiện làm mới các điều khiển trên giao diện
			CongViecDVO_MucLuong.Clear();
			CongViecDVO_TenCongViec.Clear();
		}

		private void ShowSuccessMessage(string message)
		{
			// Hiển thị thông báo thành công
			MaterialMessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, UseRichTextBox: false, buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center);
		}

		private void ShowErrorMessage(string message)
		{
			// Hiển thị thông báo lỗi
			MaterialMessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, UseRichTextBox: false, buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center);
		}

	}
}
