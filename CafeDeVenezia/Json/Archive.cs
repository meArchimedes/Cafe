using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDeVenezia.Json
{
     interface Archive
    {
        void Save(ArchivedInfo data);
        List<ArchivedInfo> ImportData();
    }
}
