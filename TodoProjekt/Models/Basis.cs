namespace TodoProjekt.Models
{
    public class Basis
    {
        public int Id { get; set; }

        public string? ErstellDatum { get; set; }

        public DateTime BearbeitungsDatum { get; set; } = DateTime.Now;
    }
}
