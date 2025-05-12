namespace FinalProject.DAL.Models;
public class Product : BaseEntity
{
    [Required]
    [MinLength(2), MaxLength(20)]
    public string Title { get; set; }

    [Required]
    [MinLength(0), MaxLength(50)]
    public string ShortDescription { get; set; }

    [Required]
    public double Price { get; set; }

    [Required]
    public string ImgUrl { get; set; }

    public Status? Status { get; set; }

}
