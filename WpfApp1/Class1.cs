using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp1
{
    public class Class1
    {
        private string GetExistPath(string txt)
        {
            string text = txt.Trim().Trim('"');
            if (string.IsNullOrEmpty(text) || !Directory.Exists(text))
            {
                return null;
            }
            return text;
        }
        static public bool SplitNamesToSeparatedFiles(string filePath, string directoryPath, ref int sum, out string s)
        {
            sum = 0;
            string text = directoryPath.Trim().Trim('"');
            if (string.IsNullOrEmpty(text) )
            {
                s = "לא הוזן נתיב לתיקייה";
                return false;
            }
            if( !Directory.Exists(text))
                Directory.CreateDirectory(text);
            string text1 = filePath.Trim().Trim('"');
            if (string.IsNullOrEmpty(text1))
            {
                s = "לא הוזן נתיב לקובץ";
                return false;
            }
            string[] arr = File.ReadAllText(text1, Encoding.UTF8).Split(',');
                for (int i = 0; i < arr.Length; i++)
                {
                    string path = Path.Combine(text, arr[i] + ".txt");
                    File.Create(path).Close();
                    sum++;
                }
            s = "הקבצים נוצרו בהצלחה";
            return true;
        }
    }
}
