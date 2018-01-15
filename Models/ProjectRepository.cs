using System.Collections.Generic;
using System.Linq;

namespace agent_project.Models
{
    public class ProjectRepository : IProjectRepository {
        
        private readonly ProjectContext _context;

        public ProjectRepository(ProjectContext context) {
            _context = context;

            if (!_context.ProjectItems.Any()) {
                // TODO: add all projects and information
                Add(new ProjectItem {
                    Id = "1",
                    Name = "joyful talks",
                    Url = "http://joyfultalks.com",
                    ReleaseDate = "June 2016",
                    Description = "Joyful Talks is a personal blog",
                    Details = "Joyful talks run in CodeIgniter PHP, MySQL, jQuery and CSS Bootstrap."
                });

                Add(new ProjectItem {
                    Id = "2",
                    Name = "Cerejas Mari'José",
                    Url = "http://marijose.pt",
                    ReleaseDate = "May 2014",
                    Description = "Website for a fruit company",
                    Details = "Cerejas Mari'José runs in Laravel PHP framework, Bootstrap CSS, MySQL and jQuery."
                });
            }
        }

        public IEnumerable<ProjectItem> GetAll() {
            return _context.ProjectItems.ToList();
        }

        public void Add(ProjectItem item) {
            _context.ProjectItems.Add(item);
            _context.SaveChanges();
        }

        public ProjectItem Find(string name) {
            return _context.ProjectItems.FirstOrDefault(t => t.Name == name);
        }

        public void Remove(string name) {
            var entity = _context.ProjectItems.First(t => t.Name== name);
            _context.ProjectItems.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(ProjectItem item) {
            _context.ProjectItems.Update(item);
            _context.SaveChanges();
        }
    }
}