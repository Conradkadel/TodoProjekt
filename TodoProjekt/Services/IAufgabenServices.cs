using TodoProjekt.Models;

namespace TodoProjekt.Services
{
    public interface IAufgabenServices
    {
        bool AddAufgabe(EinzelAufgabe aufgabe);
        bool Delete(int id);    
        EinzelAufgabe FindbyId(int id);
        List<EinzelAufgabe> GetAll();   
    }
}
