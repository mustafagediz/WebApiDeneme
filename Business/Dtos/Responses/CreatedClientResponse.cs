namespace Business.Dtos.Responses;

public class CreatedClientResponse
{
    public long IdentityNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public short DateBirth { get; set; }

    public DateTime MembershipDate { get; set; }

}