using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public class MyResource : IDisposable
    {
        private FileStream file;

        public MyResource(string path)
        {
            file = new FileStream(path, FileMode.Open);
            Console.WriteLine("File opened");
        }
        public void Dispose()
        {
            file?.Dispose();
            Console.WriteLine("File closed and resources released.");
        }
    }
}
