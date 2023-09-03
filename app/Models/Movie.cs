using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Movie
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [Required(ErrorMessage = "Поле должно быть установлено")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Поле должно быть установлено")]
    public string Producer { get; set; }

    [Required(ErrorMessage = "Поле должно быть установлено")]
    public string Genre { get; set; }

    [Required(ErrorMessage = "Поле должно быть установлено")]
    [Range(1929, 2023, ErrorMessage = "Недопустимый год")]
    public int Year { get; set; }

    [Range(1, 5, ErrorMessage = "Недопустимые звезды")]
    public string Stars { get; set; }

    [Required(ErrorMessage = "Поле должно быть установлено")]
    [StringLength(300, ErrorMessage = "Описание не должно превышать 100 символов")]
    public string Description { get; set; }

    public string? ImageName { get; set; }
}