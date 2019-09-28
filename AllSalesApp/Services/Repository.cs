using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllSalesApp.Services
{
    interface Repository : IDisposable
    {
        void CreateObj(Object obj);
        void DeleteObj(Object obj);
        void UpdateObj(Object obj);

    }
}
