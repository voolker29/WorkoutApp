using DALInterfaces.Models;
using DALInterfaces.Repositories;

namespace DALEF.Repositories
{
    public class ProgressRepository : BaseRepository<ProgressModel>,IProgressRepository
    {
        public ProgressRepository(WebContext context) : base(context)
        {
        }
    }
}
