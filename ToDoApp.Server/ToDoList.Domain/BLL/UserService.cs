using ToDoList.Domain.DTOs;

namespace ToDoList.Domain.BLL;

public interface IAccountService
{
    Task Register(UserRegisterRequest request);
    Task Login(UserLogInRequest request);
    Task Logout();
    Task<UserInfoResponse> GetAccountInfoAsync(int id);
}