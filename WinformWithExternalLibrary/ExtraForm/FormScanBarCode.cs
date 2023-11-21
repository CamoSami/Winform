using AForge.Video.DirectShow;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace WinformWithExternalLibrary.ExtraForm
{
	public partial class FormScanBarCode : MaterialForm
	{
		public class OnScanBarcodeCompleteEventArgs : EventArgs
		{
			public string maSanPham;
		}
		public event EventHandler<OnScanBarcodeCompleteEventArgs> OnScanBarcodeComplete;

		private FilterInfoCollection filterInfoCollection;
		private VideoCaptureDevice videoCaptureDevice;

		public FormScanBarCode()
		{
			this.InitializeComponent();

			this.barCodeScannerTb.Enabled = false;

			this.ScanBarcode();
		}

		private void ScanBarcode()
		{
			// Import service
			this.filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

			// Select type camera on Combobox
			foreach (FilterInfo device in this.filterInfoCollection)
			{
				this.cameraCb.Items.Add(device.Name);
			}

			this.cameraCb.SelectedIndex = 0;

			this.btnScan.Click += (object sender, EventArgs e) => {
				this.videoCaptureDevice = new VideoCaptureDevice(this.filterInfoCollection[this.cameraCb.SelectedIndex].MonikerString);

				this.videoCaptureDevice.NewFrame += (obj, eventArgs) => 
				{
					Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
					BarcodeReader reader = new BarcodeReader();

					var result = reader.Decode(bitmap);

					if (result != null)
					{
						this.barCodeScannerTb.Invoke(new MethodInvoker(delegate ()
						{
							this.barCodeScannerTb.Text = result.ToString();
						}));
					}
					
					this.scannerPictureBox.Image = bitmap;
				};

				this.videoCaptureDevice.Start();
			};

			this.btnReset.Click += (obj, e) =>
			{
				this.barCodeScannerTb.Text = "";

				this.videoCaptureDevice.Stop();
				this.videoCaptureDevice = null;
			};

			this.btnDone.Click += (obj, e) =>
			{
				if (this.barCodeScannerTb.Text == "")
				{
					return;
				}

				this.OnScanBarcodeComplete?.Invoke(this, new OnScanBarcodeCompleteEventArgs { 
					maSanPham = this.barCodeScannerTb.Text 
				});

				this.Close();
			};

			this.FormClosing += (object sender, FormClosingEventArgs e) =>
			{
				if (this.videoCaptureDevice != null)
				{
					if (this.videoCaptureDevice.IsRunning)
					{
						this.videoCaptureDevice.Stop();
					}
				}
			};
		}
	}
}
