using System.ComponentModel.DataAnnotations;
namespace Capstone.Sample.ComplainApp
{
    public class UserModel
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        [Display(Name = "Full Name")]
        [StringLength(20, ErrorMessage = "Name should be less than or equal to 20 characters.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Please Email ID")]
        [Display(Name = "Email Id")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email is not valid.")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter Password")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public string Gender { get; set; }

        [Display(Name = "Mobile Number")]
        [Required(ErrorMessage = "Mobile Number is required.")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Minimum and Maximum 10 Digit Required.")]
        [RegularExpression(@"^[6-9]\d{9}$", ErrorMessage = "Mobile No. is not valid.")]
        public string MobileNo { get; set; }
        
        public string Role { get; set; }

        public string AadharNo { get; set; }
    }
}
