namespace Business.Dtos.Requests;

public class CreateClientRequest
{
    public long IdentityNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public short DateBirth { get; set; }
    public string Password { get; set; }
}