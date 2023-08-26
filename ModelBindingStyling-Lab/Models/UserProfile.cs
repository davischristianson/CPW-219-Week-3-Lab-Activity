using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ModelBindingStyling_Lab.Models
{
    /// <summary>
    /// Individual user profile information
    /// </summary>
    public class UserProfile
    {
        public int UserProfileId { get; set; }

        /// <summary>
        /// First and last legal name of the user
        /// </summary>
        [Display(Name = "Full Name")]
        public string FullName { get; set; } = null!;

        /// <summary>
        /// User date of birth
        /// </summary>
        [Display(Name = "Date of birth")]
        public DateOnly DateOfBirth { get; set; }

        /// <summary>
        /// Contact email
        /// </summary>
        [Display(Name = "Email Address")]
        public string Email { get; set; } = null!;

        /// <summary>
        /// Contact phone number
        /// </summary>
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } = null!;

        /// <summary>
        /// Profile image of the user
        /// </summary>
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = null!;

        /// <summary>
        /// The users GitHub profile URL
        /// </summary>
        [Display(Name = "GitHub URL")]
        public string GitHubUrl { get; set; } = null!;

        /// <summary>
        /// List of languages the user is skilled in. Will be an empty
        /// list if there are 0
        /// </summary>
        [Display(Name = "Skilled Languages")]
        public List<string> SkilledLanguages { get; set; } = new();
    }
}
