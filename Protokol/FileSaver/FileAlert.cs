using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorLogic.Interfaces;

namespace FileSaver
{
    public class FileAlert : IProtokolAlert
    {
        private string _path;
        private string _fileName;

        public FileAlert(string path) : this(path, "SensorAlert.txt") { }

        public FileAlert(string path, string fileName)
        {
            _path = path;
            _fileName = fileName;
        }

        public void ProtokollAlert(DateTime date, string message)
        {
            using (StreamWriter fileWriter = PrepareFile(_path,_fileName))
            {
                fileWriter.WriteLine($"{date} | {message}");
            }
        }

        private StreamWriter PrepareFile(string path, string name)
        {
            var fullName = Path.Combine(path, name);

            if (!File.Exists(fullName))
            {
                File.Create(fullName).Dispose();
            }

            return new StreamWriter(fullName);
        }
    }
}
