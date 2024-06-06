namespace Domain.Entities
{
    public class WorkoutPersonalized
    {
        public int Id{ get; set; }
        public required string Name{ get; set; }
        public required string Finally { get; set; }
        public required string Description { get; set; }
        public required string TrainningPlace { get; set; }
        public DateTime ImplementationDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public required int Repetitions{get;set;}
        public required int Time{get; set;}
        public required int WorkoutId { get; set; }
        public bool Active {get;set;} = true;
    }
}