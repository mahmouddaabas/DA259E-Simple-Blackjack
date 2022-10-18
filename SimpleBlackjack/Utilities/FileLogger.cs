using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class FileLogger
    {
        public void LogToFile(string msg)
        {
            string path = "C:\\Programing\\C#\\DA259E-Simple-Blackjack\\SimpleBlackjack\\SimpleBlackjack\\Resources\\";
            File.AppendAllText(Path.Combine(path, "Logger.txt"), msg);
        }
    }
}
