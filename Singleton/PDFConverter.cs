using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class PDFConverter : IConverter
    {
        private Session session;
        private PDFConvertService pDFConvertService;

        public PDFConverter()
        {
                this.pDFConvertService = new PDFConvertService();
                this.session = this.pDFConvertService.GetSession();
        }
        public void Convert(string filePath)
        {
            Console.WriteLine($"...... Started.......");
        }

        public string GetSessionInfo()
        {
            return session.Id;
        }
    }
}
