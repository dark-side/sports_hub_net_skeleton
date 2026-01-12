using SportsHub.Api.Models.Users;

namespace SportsHub.Api.Services;

public interface IUsersService
{
    Task<UserResponse[]> GetAllUsers();
    Task<UserResponse> GetUser(int userId);
}
