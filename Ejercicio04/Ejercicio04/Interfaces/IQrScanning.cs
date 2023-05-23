using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04.Interfaces
{
    public interface IQrScanning
    {
        Task<string> ScanAsync();
    }
}
