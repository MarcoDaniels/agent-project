using Microsoft.EntityFrameworkCore;

namespace agent_project.Models
{
    /**
     * The database context is the main class that coordinates Entity Framework functionality for a given data model.
     * You create this class by deriving from the Microsoft.EntityFrameworkCore.DbContext class.
     */
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) 
            : base(options)
        { }

        public DbSet<ProjectItem> ProjectItems { get; set; }
    }
}