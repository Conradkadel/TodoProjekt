using TodoProjekt.Models;

namespace TodoProjekt.Services
{
    public interface IUnteraufgabenServices
    {
        
        bool AddAufgabe(UnterAufgabe unterAufgabe, int userId);
        bool Delete(int id);
        UnterAufgabe FindbyId(int id);
        List<UnterAufgabe> GetAll();
    }
}
