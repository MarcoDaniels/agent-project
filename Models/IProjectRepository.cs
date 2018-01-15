using System.Collections.Generic;

namespace agent_project.Models
{
    public interface IProjectRepository {
        void Add(ProjectItem item);
        IEnumerable<ProjectItem> GetAll();
        ProjectItem Find(string identifier);
        ProjectItem GetByURL(string url);
        ProjectItem GetByName(string name);
        void Remove(string identifier);
        void Update(ProjectItem item);
    }
}