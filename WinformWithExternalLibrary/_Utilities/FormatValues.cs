using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformWithExternalLibrary._Utilities
{
    public class FormatValues
    {
        public string FormatPriceToView(string input, int numberOfDigits)
        {
            int length = input.Length;

            // Tính toán vị trí để chèn dấu chấm
            int firstDotPosition = length % numberOfDigits;
            if (firstDotPosition == 0)
                firstDotPosition = numberOfDigits;

            int remainingDigits = length - firstDotPosition;

            // Chèn dấu chấm vào đúng vị trí
            for (int i = 0; i < remainingDigits / numberOfDigits; i++)
            {
                input = input.Insert(firstDotPosition + i * (numberOfDigits + 1), ".");
            }

            return input;
        }

        public string UnFormatPriceToView(string formattedString)
        {
            // Loại bỏ dấu chấm khỏi chuỗi
            string unformattedString = formattedString.Replace(".", "");

            return unformattedString;
        }
    }
}
