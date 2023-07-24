using TodoProjekt.Models;

namespace TodoProjekt.Services
{
    public class UnterAufugabenServices : IUnteraufgabenServices
    {
        private int userId { get; set; }
        private readonly DatabaseContext _ctx;
        public UnterAufugabenServices(DatabaseContext ctx)
        {
            _ctx = ctx;
        }
        public bool AddAufgabe(UnterAufgabe unterAufgabe , int userId)
        {
            try
            {
                if (unterAufgabe.Id == 0)
                {
                    unterAufgabe.ErstellDatum = DateTime.Now.ToShortTimeString();
                    unterAufgabe.Checked = false;
                    _ctx.UnterAufgabe.Add(unterAufgabe);
                }
                else
                {
                    _ctx.UnterAufgabe.Update(unterAufgabe);
                }
                
                unterAufgabe.EinzelAufgabenId = userId;

                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var unterAufgabe = FindbyId(id);
                if (unterAufgabe == null)
                {
                    return false;
                }
                _ctx.UnterAufgabe.Remove(unterAufgabe);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public UnterAufgabe FindbyId(int id)
        {
            return _ctx.UnterAufgabe.Find(id);
        }

        public List<UnterAufgabe> GetAll()
        {
            return _ctx.UnterAufgabe.ToList();
        }
    }
}
