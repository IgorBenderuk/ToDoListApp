namespace ToDoApp.Api.options;

public class IdentityTokenOptions
{
    [ConfigurationKeyName("ExpiresDays")] public double ExpiresDays { get; set; }
    [ConfigurationKeyName("Issuer")] public string? Issuer { get; set; }
}