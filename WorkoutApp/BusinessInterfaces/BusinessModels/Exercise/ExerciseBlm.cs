namespace BusinessLayerInterfaces.BusinessModels.Exercise
{
    public class ExerciseBlm
    {
        public int DayOfWeek { get; set; }
        public int Reps { get; set; }
        public int Sets { get; set; }
        public DateTime Rest { get; set; }
        public ExerciseTypeBlm ExerciseType { get; set; }
        public ICollection<ProgressBlm> Progresses  { get; set; }
        public TraningPlanBlm TraningPlan { get; set; }

    }
}
