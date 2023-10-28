using DALInterfaces.Models.Exercise;

namespace DALInterfaces.Models
{
    public class UserModel : BaseModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public virtual ICollection<TraningPlanModel> TraningPlans { get; set; }
        public virtual ICollection<ExerciseTypeModel> CreatedExercisesTypes { get; set; }
    }
}
