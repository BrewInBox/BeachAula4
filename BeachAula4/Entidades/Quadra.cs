namespace BeachAula4.Entidades
{
    public class Quadra
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal ValorHora { get; set; }
        public bool Ativa { get; set; }
        public string? Descricao { get; set; }

    }
}
