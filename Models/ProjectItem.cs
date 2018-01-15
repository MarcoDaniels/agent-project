using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace agent_project.Models
{
    public class ProjectItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string ReleaseDate { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
    }
}