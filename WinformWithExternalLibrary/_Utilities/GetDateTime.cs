using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformWithExternalLibrary._Utilities
{
	public class GetDateTime
	{
		public string GetDateTimeNow_Date()
		{
			return "_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year;
		}
	}
}
