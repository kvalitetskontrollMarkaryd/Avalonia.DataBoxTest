using System.Collections.Generic;
using System.Linq;
using Avalonia.DataBox.Model;

namespace Avalonia.DataBox.ViewModel
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            Projects = new List<Project>();
            Managers = new List<string>();
        }
        
        public void Load()
        {
            CreateManagers();
            CreateProjects();
        }

        public List<Project> Projects { get; }
        public List<string> Managers { get; }

        private void CreateProjects()
        {
            for (var i = 0; i < 50; i++)
            {
                Projects.Add(new Project()
                {
                    Id = i,
                    Name = $"Project {i}",
                    Number = i.ToString("00"),
                    Remark = $"Remark {i}",
                    Manager = Managers.LastOrDefault() ?? string.Empty,
                    IsChecked = false
                });
            }
        }

        private void CreateManagers()
        {
            Managers.Add("Tobias Johansson");
            Managers.Add("Wiesław Šoltés");
        }
    }
}