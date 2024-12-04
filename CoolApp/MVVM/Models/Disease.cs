using SQLite;

namespace CoolApp.MVVM.Models
{
    [Table("Disease")]
    public class Disease
    {
        [PrimaryKey, AutoIncrement, Column("Id")]
        public int Id { get; set; }

        [Column("Name"), Indexed, NotNull]
        public string? Name { get; set; }

        [Column("Image")]
        public string? Image { get; set; }

        [Column("Description")]
        public string? Description { get; set; }
    }
}