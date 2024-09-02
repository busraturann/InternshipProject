using Apideneme.Models;

namespace Apideneme.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
