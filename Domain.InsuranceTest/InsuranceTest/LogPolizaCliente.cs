using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InsuranceTest.InsuranceTest
{
    public class LogPolizaCliente
    {
        public System.Guid IdLpc { get; set; } // ID_LPC (Primary key)
        public System.Guid IdPol { get; set; } // ID_POL
        public System.Guid IdCli { get; set; } // ID_CLI
        public System.DateTime FechaProceso { get; set; } // FECHA_PROCESO
        public bool Activa { get; set; } // ACTIVA

        // Foreign keys
        public virtual Cliente Cliente { get; set; } // FK_LOG_POLIZA_CLIENTE_Cliente_ID_CLI
        public virtual Poliza Poliza { get; set; } // FK_LOG_POLIZA_CLIENTE_POLIZA_ID_POL
    }
}
