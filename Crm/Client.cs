namespace Crm;

public sealed class Client
{
    string? firstName;
    string? lastName;
    string? middleName;
    short age;
    string? passportNumber;
    string? gender;

    public  string FirstName
    {
        get => firstName ?? string.Empty;
        init => firstName = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public string LastName 
    { 
        get => lastName ?? string.Empty;
        init => lastName = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public string MiddleName 
    {
        get => middleName ?? string.Empty;
        init => middleName = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public  short Age 
    { 
        get => age;
        init => age = value >= 18 ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public string PassportNumber 
    { 
        init => passportNumber = value is { Length: >= 8 } ? value : throw new ArgumentOutOfRangeException(nameof(value)); 
    }
    public string Gender 
    { 
        get => gender ?? string.Empty;
        init => gender = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
}
