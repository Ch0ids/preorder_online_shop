namespace DAL.Entities
{
    public class Word : BaseEntity
    {
        public required string Term { get; set; }
        public string? Definition { get; set; }
        public string? Explaination { get; set; }
        public string? Pronounciation { get; set; }
        public string? UseCase { get; set; }
        public int? Frequency { get; set; }
        public int? RepeatedLeftover { get; set; }
        public bool? IsMarked { get; set; }
    }
}
