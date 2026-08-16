using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReefBlog.Domain;

public class BlogPost
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string Title { get; set; } = null!;

    [Required]
    public string Content { get; set; } = null!;

    [Required]
    public DateTime PublishedDate { get; set; }

    [Required]
    public int AuthorId { get; set; }

    [ForeignKey("AuthorId")]
    public BlogAuthor Author { get; set; } = null!;

    public ICollection<BlogTags> Tags { get; set; } = new List<BlogTags>();

    public ICollection<BlogCategories> Categories { get; set; } = new List<BlogCategories>();
}
