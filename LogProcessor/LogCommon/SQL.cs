namespace LogCommon
{
    public class SQL : DbContext
    {
        public static string ConnectionString { get; set; }
        public SQL() :base(new DbContextOptionsBuilder().UseSqlServer(ConnectionString).Options) { }
        public SQL(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<LogEntry> LogEntries { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Logprocessor;User Id=sa;Passoword=titok;TrustServerCertificate=true;");
        }

    }
}