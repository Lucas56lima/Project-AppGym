using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Commands;

namespace Infrastructure.Context
{
    public class AppGymContextDb : DbContext
    {
    
        public AppGymContextDb(DbContextOptions<AppGymContextDb> options) : base(options)   
        {        
       
        }
        public DbSet<User> Users { get;set;}
        public DbSet<Plan> Plans { get;set;}
        public DbSet<Payment> Payments { get;set;}
        public DbSet<Workout> Workouts { get;set;}
        public DbSet<CustomWorkout> CustomWorkouts {  get;set;}
        public DbSet<CustomWorkoutDetail> CustomWorkoutDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Chama o m�todo base para garantir que a configura��o padr�o seja aplicada.
            base.OnModelCreating(modelBuilder);

            // Configura a chave prim�ria composta para a entidade CustomWorkoutDetail.
            modelBuilder.Entity<CustomWorkoutDetail>()
                .HasKey(cwd => new { cwd.CustomWorkoutId, cwd.WorkoutId });

            // Configura a rela��o muitos-para-um entre CustomWorkout e CustomWorkoutDetail.
            modelBuilder.Entity<CustomWorkoutDetail>()
                .HasOne(cwd => cwd.CustomWorkout)
                .WithMany(cw => cw.CustomWorkoutDetails)
                .HasForeignKey(cwd => cwd.CustomWorkoutId);

            // Configura a rela��o muitos-para-um entre Workout e CustomWorkoutDetail.
            modelBuilder.Entity<CustomWorkoutDetail>()
                .HasOne(cwd => cwd.Workout)
                .WithMany(w => w.CustomWorkoutDetails)
                .HasForeignKey(cwd => cwd.WorkoutId);
        }

    }

}