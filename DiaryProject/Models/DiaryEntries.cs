using System.ComponentModel.DataAnnotations;

namespace DiaryProject.Models
{
    public class DiaryEntries
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage =("The title is missing."))]
        [StringLength(100, MinimumLength =2, ErrorMessage = "Title must be between 3 and 100 characters!")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage ="What did you do? Nothing? Really?")]
        [StringLength(maximumLength:1000, MinimumLength =1, ErrorMessage ="It takes more than 0 words to tell us about your day.")]
        public string Entry { get; set; } = string.Empty;

        [Required(ErrorMessage ="You must be a forgetful time traveler.")]
        public DateTime Date { get; set; }
    }
}
