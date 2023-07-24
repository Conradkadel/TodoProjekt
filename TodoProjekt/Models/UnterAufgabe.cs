using System.ComponentModel.DataAnnotations;

namespace TodoProjekt.Models
{
    public class UnterAufgabe : Basis
    {
        [Required]
        public string Name { get; set; }
        public bool Checked { get; set; }
        public int EinzelAufgabenId { get; set; }
    }
}
