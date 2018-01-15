using System.Collections.Generic;

namespace agent_project.Models
{
    public interface IProjectRepository {
        IEnumerable<ProjectItem> GetAll();
        ProjectItem Find(string name);
        void Add(ProjectItem item);
        void Remove(string identifier);
        void Update(ProjectItem item);
    }
}