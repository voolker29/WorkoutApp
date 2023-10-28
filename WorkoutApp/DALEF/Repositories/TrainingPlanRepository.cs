using DALInterfaces.Models;
using DALInterfaces.Repositories;

namespace DALEF.Repositories
{
    public class TrainingPlanRepository : BaseRepository<TraningPlanModel>, ITrainingPlanRepository
    {
        public TrainingPlanRepository(WebContext context) : base(context)
        {
        }
    }
}
