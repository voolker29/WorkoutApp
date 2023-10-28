using DALInterfaces.Models;
using DALInterfaces.Models.Exercise;
using Microsoft.EntityFrameworkCore;

namespace DALEF
{
    public class WebContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public DbSet<ExerciseModel> Exercises { get; set; }
        public DbSet<ExerciseTypeModel> ExercisesTypes { get; set; }
        public DbSet<ProgressModel> Progresses { get; set; }
        public DbSet<TraningPlanModel> TraningPlans { get; set; }



        public WebContext() { }

        public WebContext(DbContextOptions<WebContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(StartUp.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>()
                   .HasMany(traningPlan => traningPlan.TraningPlans)
                   .WithOne(userOwner => userOwner.UserOwner);

            modelBuilder.Entity<UserModel>()
                  .HasMany(exerciseType => exerciseType.CreatedExercisesTypes)
                  .WithOne(userCreator => userCreator.UserCreator);

            modelBuilder.Entity<TraningPlanModel>()
                   .HasMany(exercise => exercise.Exercises)
                   .WithOne(traningPlan => traningPlan.TrainingPlan)
                   .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ExerciseModel>()
                   .HasOne(exerciseType => exerciseType.ExerciseType)
                   .WithMany(exercise => exercise.Exercises);

            modelBuilder.Entity<ExerciseModel>()
                   .HasMany(progress => progress.Progress)
                   .WithOne(exercise => exercise.Exercise);



        }
    }
}
