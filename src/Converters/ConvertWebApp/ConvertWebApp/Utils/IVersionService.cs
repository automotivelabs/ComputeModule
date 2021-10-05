using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConvertWebApp.Utils
{
    public interface IVersionService
    {
        string Version { get; }
        string FileVersion { get; }
    }
}
