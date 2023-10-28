using BusinessLayerInterfaces.BusinessModels.Exercise;
using DALInterfaces.Models.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerInterfaces.BusinessModels
{
    public class ProgressBlm
    {
        public DateTime DateTime { get; set; }
        public string Status { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public double Weight { get; set; }
        public string Notice { get; set; }
        public  ExerciseBlm Exercise { get; set; }
    }
}
