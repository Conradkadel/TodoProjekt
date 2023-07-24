using TodoProjekt.Models;

namespace TodoProjekt.Services
{
    public class AufgabenServices : IAufgabenServices
    {
        private readonly DatabaseContext _ctx;

        public AufgabenServices(DatabaseContext ctx)
        {
            _ctx = ctx;
        }
        public bool AddAufgabe(EinzelAufgabe aufgabe)
        {
            try
            {
                
                if (aufgabe.Id == 0) 
                {
                    _ctx.EinzelAufgabe.Add(aufgabe);
                }
                else
                {
                    _ctx.EinzelAufgabe.Update(aufgabe);
                }
                aufgabe.ErstellDatum = DateTime.Now.ToShortDateString();
                aufgabe.status = Status.Offen;
                aufgabe.Prozentsatz = 0.00;
                _ctx.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var aufgabe = FindbyId(id);
                if (aufgabe == null)
                {
                    return false;
                }
                _ctx.EinzelAufgabe.Remove(aufgabe);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public EinzelAufgabe FindbyId(int id)
        {
            return _ctx.EinzelAufgabe.Find(id);
        }

        public List<EinzelAufgabe> GetAll()
        {
            return _ctx.EinzelAufgabe.ToList();
        }
    }
}
