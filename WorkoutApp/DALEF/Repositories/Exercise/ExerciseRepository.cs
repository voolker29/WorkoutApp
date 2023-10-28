using DALInterfaces.Models.Exercise;
using DALInterfaces.Repositories.Exercise;

namespace DALEF.Repositories.Exercise
{
    public class ExerciseRepository : BaseRepository<ExerciseModel>, IExerciseRepository
    {
        public ExerciseRepository(WebContext context) : base(context) { }
    }
}
