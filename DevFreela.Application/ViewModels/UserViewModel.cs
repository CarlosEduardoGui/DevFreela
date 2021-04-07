using System;
using System.Collections.Generic;

namespace DevFreela.Application.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(int id, string fullName, string email, DateTime birthDate, List<ProjectViewModel> ownedProjects, List<ProjectViewModel> freelanceProjects, List<UserSkillViewModel> userSkills)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;

            OwnedProjects = new List<ProjectViewModel>();
            FreelanceProjects = new List<ProjectViewModel>();
            Skills = new List<UserSkillViewModel>();
        }

        public int Id { get; private set; }

        public string FullName { get; private set; }

        public string Email { get; private set; }

        public DateTime BirthDate { get; private set; }

        public List<UserSkillViewModel> Skills { get; private set; }

        public List<ProjectViewModel> OwnedProjects { get; private set; }

        public List<ProjectViewModel> FreelanceProjects { get; private set; }
    }
}
