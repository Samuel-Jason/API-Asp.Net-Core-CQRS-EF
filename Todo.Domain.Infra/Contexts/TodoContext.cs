using MicrosoftEntityFrameworkCore;

namespace Todo.Domain.Infra.Contexts
{
   public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<TodoItem> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilderEntity<TodoItem>().ToTable("Todo");
            modelBuilderEntity<TodoItem>().Property(x => x.Id);
            modelBuilderEntity<TodoItem>().Property(x => x.User).HasMaxLength(120).HasColumnType("varchar(120)");
            modelBuilderEntity<TodoItem>().Property(x => x.Title).HasMaxLength(160).HasColumnType("varchar(160)");
            modelBuilderEntity<TodoItem>().Property(x => x.Done).HasColumnType("bit");
            modelBuilderEntity<TodoItem>().Property(x => x.Date);
            modelBuilderEntity<TodoItem>().HasIndex(b => b.User);
        }
    }
}