using Fitnes.Models;
using System.Data.Entity;

namespace Fitnes
{
    public  class FitnesDataBase : DbContext
   {
        private readonly string _schema;

        public FitnesDataBase(string schema = "public") : base("DatabaseConnectionString")
        {
            _schema = schema;
        }

        public DbSet<Day> Days { get; set; }
        public DbSet<Capasity> Capasities { get; set; }
        public DbSet<DayTrainingCapasity> DayTrainingCapasities { get; set; }
        public DbSet<ExerciseCapasity> ExerciseCapasities { get; set; }
        public DbSet<GymExercise> GymExercises { get; set; }
        public DbSet<TrainingType> TrainingTypes { get; set; }
        public DbSet<UnitType> UnitTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.HasDefaultSchema(_schema);
            base.OnModelCreating(builder);
        }
   }
}
