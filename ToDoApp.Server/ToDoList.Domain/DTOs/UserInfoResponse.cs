namespace ToDoList.Domain.DTOs;
public record UserInfoResponse
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
}