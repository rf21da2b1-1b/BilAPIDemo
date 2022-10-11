using BilAPIDemo.model;

namespace BilAPIDemo.managers
{
    public class BilerManager : IBilerManager
    {
        private readonly BilerContext _db = new BilerContext();


        public void Create(Bil bil)
        {
            _db.Biler.Add(bil);
            _db.SaveChanges();    // commit til database

        }

        public void Delete(string stelnummer)
        {
            throw new NotImplementedException();
        }

        public Bil Get(string stelnummer)
        {

            return _db.Biler.ToList().Find(b => b.Stelnummer == stelnummer);
        }

        public List<Bil> GetAll()
        {
            return _db.Biler.ToList();
        }

        public void Update(Bil bil)
        {
            throw new NotImplementedException();
        }
    }
}
