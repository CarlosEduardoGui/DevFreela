using Dapper;
using DevFreela.Infrastructure.Persistence;
using MediatR;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DevFreela.Application.Commands.StartProject
{
    class StartProjectCommandHandler : IRequestHandler<StartProjectCommand, Unit>
    {
        private readonly string _connectionString;
        private readonly DevFreelaDbContext _dbContext;

        public StartProjectCommandHandler(DevFreelaDbContext dbContext, IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DevFreelaCs");
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(StartProjectCommand request, CancellationToken cancellationToken)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == request.Id);

            project.Start();
            //_dbContext.SaveChangesAsync();

            using var sqlConnection = new SqlConnection(_connectionString);
            var script = "UPDATE Projects SET Status = @status, StartedAt = @startedAt WHERE Id = @id";

            var id = await sqlConnection.ExecuteAsync(script, new { status = project.Status, startedAt = project.StartedAt, request.Id });

            return Unit.Value;
        }
    }
}
