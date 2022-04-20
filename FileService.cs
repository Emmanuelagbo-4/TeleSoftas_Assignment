using System;
using System.Text;

namespace telesoftas_assignment
{
    public class FileService
    {
        public static readonly string TextFile = @"./input.txt";
        public static readonly string WrappedTextFile = @"./output.txt";

        public static string WrapText(string InputText, int LineLength)
        {

            StringBuilder sb = new StringBuilder();
            if (InputText.Length <= LineLength && InputText.Length != 0)
            {
                return sb.Append($"{InputText.PadRight(LineLength)}").ToString();
            }

            sb.Append($"{InputText.Substring(0, LineLength).ToString()}".PadLeft(LineLength) + "\n");
            string result = sb.ToString();
            InputText = InputText.Substring(LineLength, (InputText.Length) - (LineLength));
            return result += WrapText(InputText, LineLength);
        }
    }
}
