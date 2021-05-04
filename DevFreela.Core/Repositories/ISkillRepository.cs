using DevFreela.Core.Entities;
using System.Threading.Tasks;

namespace DevFreela.Core.Repositories
{
    public interface ISkillRepository
    {
        Task<Skill> GetById(int id);
    }
}
