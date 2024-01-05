using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public interface IConverter
    {
        void Convert(string filePath);

        string GetSessionInfo();
    }
}
