namespace ToDoList.Domain.DTOs;
public record UserRegisterRequest(string Email, string FullName, string Password);