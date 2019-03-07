using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggers.FIleClasses
{
    class LogFile : ILogFile
    {
        private int size;

        public int Size { get => size;}

        public LogFile()
        {
            this.size = 0;
        }

        public void Write(string directory, string message)
        {
            File.AppendAllText(directory, message);
            increaseSize(message);
        }

        private void increaseSize(string message)
        {
            size += message.Where(p => Char.IsLetter(p)).Sum(p => p);
        }
    }
}
