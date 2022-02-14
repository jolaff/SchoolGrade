namespace SchoolGrade.Library.Models;

public abstract class EntityBase
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
}