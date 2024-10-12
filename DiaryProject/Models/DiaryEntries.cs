using System.ComponentModel.DataAnnotations;

namespace DiaryProject.Models
{
    public class DiaryEntries
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Entry { get; set; } = string.Empty;

        [Required]
        public DateTime Date { get; set; }
    }
}
