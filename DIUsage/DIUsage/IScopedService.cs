using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIUsage
{
    public interface IScopedService : IReportServiceLifetime
    {
        ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Scoped;
    }
}
