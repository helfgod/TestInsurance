namespace Domain.InsuranceTest.InsuranceTest
{
    public class TipoCubrimiento
    {
        public int IdTipoCubrimiento { get; set; } // ID_TIPO_CUBRIMIENTO (Primary key)
        public string TcNombre { get; set; } // TC_NOMBRE
        public string TcCobertura { get; set; } // TC_COBERTURA (length: 50)

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<Poliza> Polizas { get; set; } // POLIZA.FK_POLIZA_TIPO_CUBRIMIENTO_ID_TIPO_CUBRIMIENTO

        public TipoCubrimiento()
        {
            Polizas = new System.Collections.Generic.List<Poliza>();
        }
    }
}