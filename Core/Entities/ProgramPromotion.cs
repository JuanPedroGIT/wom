namespace Core.Entities
{
    public class ProgramPromotion: BaseEntity
    {
        public int IdProgram { get; set; }
        public Program Program { get; set; }

        public string Name { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}