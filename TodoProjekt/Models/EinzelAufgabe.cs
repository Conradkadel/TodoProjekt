using System.ComponentModel.DataAnnotations;

namespace TodoProjekt.Models
{
    public class EinzelAufgabe : Basis
    {
        [Required]
        public string Name { get; set; }

        public Status status { get; set; }
        public double? Prozentsatz { get; set; }
        public string Beschreibung { get; set; }


    }
}
