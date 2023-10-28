using DALInterfaces.Models.Exercise;
using DALInterfaces.Models;
using BusinessLayerInterfaces.BusinessModels.Exercise;

namespace BusinessLayerInterfaces.BusinessModels
{
    public class TraningPlanBlm
    {
        public string Name { get; set; }
        public ICollection<ExerciseBlm> Exercises { get; set; }
        public UserBlm UserOwner { get; set; }
    }
}
