namespace ApiCalendar.Services
{
    public class Tasks
    {

        public int ID { get; set; }

        public string TaskName { get; set; }

        public string CategoryId { get; set; }
        public DateOnly CreatedAt { get; set; }
        public DateTime DoneAt { get; set; }
       public bool IsDone {get;set;}

      //  public List<Tasks> Task1 = new List<Tasks>();
    }
}
