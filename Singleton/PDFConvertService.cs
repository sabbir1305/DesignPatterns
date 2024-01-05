using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class PDFConvertService 
    {
        public void Convert(string filePath, Session session)
        {
            Console.WriteLine($"Completed path :{filePath}, Session id: {session.Id}");
        }

        public Session GetSession()
        {
            return new Session();
        }
    }
}
