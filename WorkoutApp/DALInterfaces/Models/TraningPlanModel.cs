
using DALInterfaces.Models.Exercise;

namespace DALInterfaces.Models
{
    public class TraningPlanModel:BaseModel
    {
        public string Name { get; set; }
        public virtual ICollection<ExerciseModel> Exercises { get; set; }
        public virtual UserModel UserOwner { get; set; }
    }
}
