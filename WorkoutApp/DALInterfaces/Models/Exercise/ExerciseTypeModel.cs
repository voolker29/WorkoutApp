namespace DALInterfaces.Models.Exercise
{
    public class ExerciseTypeModel : BaseModel
    {
        public string Name { get; set; }
        public virtual ICollection<ExerciseModel> Exercises { get; set; }
        public virtual UserModel UserCreator { get; set; }
    }
}
