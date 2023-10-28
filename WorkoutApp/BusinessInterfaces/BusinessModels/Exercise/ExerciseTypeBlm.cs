using DALInterfaces.Models.Exercise;
using DALInterfaces.Models;

namespace BusinessLayerInterfaces.BusinessModels.Exercise
{
    public class ExerciseTypeBlm
    {
        public string Name { get; set; }
        public UserBlm UserCreator { get; set; }
    }
}
