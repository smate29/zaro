namespace LogCommon
{
    [Table("LogEntries")]
    public class LogEntry
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public Guid CorrelationId { get; set; }
        public DateTime DataUtc { get; set; }
        public int Thread { get; set; }
        public string Level { get; set; }
        public string Logger { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
    }
}
