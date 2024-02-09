using System.ComponentModel.DataAnnotations;

namespace mvc.Models
{
    //Class model
    public class MessageModel
    {
        //Require + Error message
        [Required(ErrorMessage = "Namn måste innehålla minst fyra tecken")]
        //Min lenght
        [MinLength(4)]
        //Label
        [Display(Name = "Namn:")]
        public string? Name { get; set; }

        //Require + Error message
        [Required(ErrorMessage = "Ange en korrekt mejladress")]
        //Label
        [Display(Name = "Mejladress:")]
        //Email
        [EmailAddress]
        public string? Email { get; set; }

        //Require + Error message
        [Required(ErrorMessage = "Ange ett korrekt telefonnummer")]
        //Label
        [Display(Name = "Telefonnummer:")]
        //Phone
        [Phone]
        public string? Phone { get; set; }

        //Require + errormessage
        [Required(ErrorMessage = "Meddelande måste innehålla minst tio tecken")]
        //Label
        [Display(Name = "Meddelande:")]
        //Min length
        [MinLength(10)]
        public string? Message { get; set; }
    }
}
