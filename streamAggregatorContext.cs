using Microsoft.EntityFrameworkCore;
namespace stream_aggregator
{
  public partial class streamAggregatorContext : DbContext
  {
    public DbSet<CourseEnrolled> CoursesEnrolled { get; set; }
    public DbSet<Course> Courses { get; set; }

    public streamAggregatorContext()
    {
    }

    public streamAggregatorContext(DbContextOptions<streamAggregatorContext> options)
        : base(options)
    {
    }
  }

}