namespace RestauranteWeb.API.Model
{
    public class Prato
    {
        public int PratoId { get; set; }
       
        public int RestauranteId { get; set; }

        public string NomePrato { get; set; }

        public float ValorPrato { get; set; }

        public int DisponibilidadePrato { get; set; }        
        
    }
}