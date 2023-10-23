using DALInterfaces.Models;

namespace DALInterfaces.Repositories
{
    public interface IBaseRepository<DbModel> where DbModel : BaseModel
    {
        void Save(DbModel model);
        void Remove(int id);
        void Update(DbModel model);
        DbModel Get(int id);
    }
}
