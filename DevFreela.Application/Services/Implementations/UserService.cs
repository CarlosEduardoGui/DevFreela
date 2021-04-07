using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Infrastructure.Persistence;
using System.Collections.Generic;
using System.Linq;

namespace DevFreela.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly DevFreelaDbContext _dbContext;

        public UserService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public UserViewModel GetUserById(int id)
        {
            var user = _dbContext.Users.SingleOrDefault(x => x.Id == id);

            var owned = new List<ProjectViewModel>();
            foreach (var item in user.OwnedProjects)
            {
                var projectViewModel = new ProjectViewModel(item.Id, item.Title, item.CreatedAt);

                owned.Add(projectViewModel);
            }

            var freelance = new List<ProjectViewModel>();
            foreach (var item in user.FreelanceProjects)
            {
                var projectViewModel = new ProjectViewModel(item.Id, item.Title, item.CreatedAt);

                freelance.Add(projectViewModel);
            }

            var skills = new List<UserSkillViewModel>();
            foreach (var item in user.Skills)
            {
                var skillUserViewModel = new UserSkillViewModel(item.IdUser, item.IdSkill);

                skills.Add(skillUserViewModel);
            }

            var userViewModel = new UserViewModel(user.Id, user.FullName, user.Email, user.BirthDate,
                owned, freelance, skills);

            return userViewModel;
        }
    }
}
