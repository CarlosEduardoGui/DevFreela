using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Novo Projeto AspNetCore 1", "Descricao 1", 1, 1, 1000),
                new Project("Novo Projeto AspNetCore 2", "Descricao 2", 1, 1, 2000),
                new Project("Novo Projeto AspNetCore 3", "Descricao 3", 1, 1, 3000),
            };

            Users = new List<User>
            {
                new User("Carlos Eduardo", "eduardocarlos@gmail.com", new DateTime(1999, 03, 03))
            };

            Skills = new List<Skill>
            {
                new Skill(".NET Core"),
                new Skill("C#"),
                new Skill("SQL")
            };
        }
        public List<Project> Projects { get; set; }

        public List<User> Users { get; set; }

        public List<Skill> Skills { get; set; }
    }
}
