namespace Domain.InsuranceTest.InsuranceTest
{
    public class Cliente
    {
        public System.Guid IdCli { get; set; } // ID_CLI (Primary key)
        public string Nombres { get; set; } // NOMBRES
        public string NoDocumento { get; set; } // NO_DOCUMENTO (length: 50)
        public string Telefono { get; set; } // TELEFONO (length: 50)

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<LogPolizaCliente> LogPolizaClientes { get; set; } // LOG_POLIZA_CLIENTE.FK_LOG_POLIZA_CLIENTE_Cliente_ID_CLI

        public Cliente()
        {
            LogPolizaClientes = new System.Collections.Generic.List<LogPolizaCliente>();
        }
    }
}
