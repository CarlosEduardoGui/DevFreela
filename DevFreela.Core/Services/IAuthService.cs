namespace DevFreela.Core.Services
{
    public interface IAuthService
    {
        string GenerateJwtTojen(string email, string role);

        string ComputeSha256Hash(string password);
    }
}
