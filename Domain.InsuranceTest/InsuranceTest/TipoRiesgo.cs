namespace Domain.InsuranceTest.InsuranceTest
{
    public class TipoRiesgo
    {
        public int IdTipoRiesgo { get; set; } // ID_TIPO_RIESGO (Primary key)
        public string Nombre { get; set; } // NOMBRE

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<Poliza> Polizas { get; set; } // POLIZA.FK_POLIZA_TIPO_RIESGO_ID_TIPO_RIESGO

        public TipoRiesgo()
        {
            Polizas = new System.Collections.Generic.List<Poliza>();
        }
    }
}