using BilAPIDemo.model;

namespace BilAPIDemo.managers
{
    public interface IBilerManager
    {
        List<Bil> GetAll();
        Bil Get(String stelnummer);

        void Create(Bil bil);
        void Update(Bil bil);   
        void Delete(String stelnummer);



    }
}
