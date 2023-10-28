using DALInterfaces.Models.Exercise;

namespace DALInterfaces.Models
{
    public class ProgressModel : BaseModel
    {
        public DateTime DateTime { get; set; }
        public string Status { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public double Weight { get; set; }
        public string Notice { get; set; }
        public virtual ExerciseModel Exercise { get; set; }
    }
}
