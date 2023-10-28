using DALInterfaces.Models.Exercise;
using DALInterfaces.Repositories.Exercise;

namespace DALEF.Repositories.Exercise
{
    public class ExerciseTypeRepository : BaseRepository<ExerciseTypeModel>, IExerciseTypeRepository
    {
        public ExerciseTypeRepository(WebContext context) : base(context) { }
    }
}
