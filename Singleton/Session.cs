using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Session
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}
