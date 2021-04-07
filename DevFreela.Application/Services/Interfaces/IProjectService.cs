using DevFreela.Application.InputModels;
using DevFreela.Application.ViewModels;
using System.Collections.Generic;

namespace DevFreela.Application.Services.Interfaces
{
    public interface IProjectService
    {
        List<ProjectViewModel> GetAll(string query);

        ProjectDetailsViewModel GetById(int id);

        int Create(NewProjectInputModel model);

        void Update(UpdateProjectInputModel model);

        void Delete(int id);

        void CreateComment(CreateCommentInputModel model);

        void Start(int id);

        void Finish(int id);

    }
}
