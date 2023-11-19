using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformWithExternalLibrary._Utilities
{
	public class GetRandom
	{
		public string GenerateRandomString(int length)
		{
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			System.Random random = new System.Random(); // Sử dụng System.Random để tránh xung đột
			char[] randomArray = new char[length];

			for (int i = 0; i < length; i++)
			{
				randomArray[i] = chars[random.Next(chars.Length)];
			}

			return new string(randomArray);
		}


	}
}
