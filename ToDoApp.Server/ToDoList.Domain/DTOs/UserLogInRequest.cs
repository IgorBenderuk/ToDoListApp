namespace ToDoList.Domain.DTOs;
public record UserLogInRequest
{
    public UserLogInRequest() { }

    public UserLogInRequest(string email, string password)
    {
        Email = email;
        Password = password;
    }

    public string Email { get; set; }
    public string Password { get; set; }
}