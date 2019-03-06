namespace Domain.InsuranceTest.InsuranceTest
{
    public class Poliza
    {
        public System.Guid IdPol { get; set; } // ID_POL (Primary key)
        public int IdTipoCubrimiento { get; set; } // ID_TIPO_CUBRIMIENTO
        public int IdTipoRiesgo { get; set; } // ID_TIPO_RIESGO
        public long Precio { get; set; } // PRECIO
        public long PeriodoCobertura { get; set; } // PERIODO_COBERTURA
        public string Nombre { get; set; } // NOMBRE (length: 400)
        public string Descripcion { get; set; } // DESCRIPCION

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<LogPolizaCliente> LogPolizaClientes { get; set; } // LOG_POLIZA_CLIENTE.FK_LOG_POLIZA_CLIENTE_POLIZA_ID_POL

        // Foreign keys
        public virtual TipoCubrimiento TipoCubrimiento { get; set; } // FK_POLIZA_TIPO_CUBRIMIENTO_ID_TIPO_CUBRIMIENTO
        public virtual TipoRiesgo TipoRiesgo_IdTipoRiesgo { get; set; } // FK_POLIZA_TIPO_RIESGO_ID_TIPO_RIESGO

        public Poliza()
        {
            LogPolizaClientes = new System.Collections.Generic.List<LogPolizaCliente>();
        }
    }
}