using Dapper;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Infrastructure.Persistence;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace DevFreela.Application.Services.Implementations
{
    public class SkillService : ISkillService
    {
        private readonly DevFreelaDbContext _dbContext;
        private readonly string _connectionString;
        public SkillService(DevFreelaDbContext context, IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DevFreelaCs");

            _dbContext = context;
        }

        public List<SkillViewModel> GetAll()
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                var script = "SELECT Id, Description FROM Skills";

                return sqlConnection.Query<SkillViewModel>(script).ToList();
            }

            //var skills = _dbContext.Skills;

            //var skillsViewModel = skills
            //    .Select(x => new SkillViewModel(x.Id, x.Description))
            //    .ToList();

            //return skillsViewModel;
        }
    }
}
