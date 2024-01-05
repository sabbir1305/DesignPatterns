using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIUsage
{
    internal sealed class ScopedService : IScopedService
    {
        Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
    }
}
