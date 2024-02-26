namespace Core.Entities;

public class BaseEntity<TId>
{
    public TId Id { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedTime { get; set; }


    public DateTime DeletedTime { get; set; }
}