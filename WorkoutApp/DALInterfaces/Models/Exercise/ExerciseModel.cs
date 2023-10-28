namespace DALInterfaces.Models.Exercise
{
    public class ExerciseModel : BaseModel
    {
        public int DayOfWeek { get; set; }
        public int Reps { get; set; }
        public int Sets { get; set; }
        public DateTime Rest { get; set; }
        public virtual ExerciseTypeModel ExerciseType { get; set; }
        public virtual ICollection<ProgressModel> Progress { get; set; }
        public virtual TraningPlanModel TrainingPlan { get; set; }
    }
}
