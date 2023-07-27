using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabModels.Interfaces
{
    public interface iDocumento
    {
        string NumeroDocumento { get; set; }
        string MostrarDocumento();
    }
}
