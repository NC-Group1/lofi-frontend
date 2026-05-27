using lofi_frontend.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace lofi_frontend.Models
{
    public class Music
{
    [Required]
    public int Id { get; set; }
    [Required]
    public string Title { get; set; } = "";
    [Required]
    public string Artist { get; set; } = "";
    [Required]
    public string Channel { get; set; } = "";
    public Mood Mood { get; set; } = Mood.Chill;
    public Genre Genre { get; set; } = Genre.LoFi;
    public string URL { get; set; } = "";
}
}
