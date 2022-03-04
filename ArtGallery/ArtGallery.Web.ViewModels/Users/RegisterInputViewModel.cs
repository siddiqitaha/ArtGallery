﻿namespace ArtGallery.Web.ViewModels.Users
{
    using System.ComponentModel.DataAnnotations;
    using static ArtGallery.Common.GlobalConstants.ArtGalleryUser;
    using static ArtGallery.Common.GlobalConstants.DisplayNames;
    using static ArtGallery.Common.GlobalConstants.ErrorMessages;

    public class RegisterInputViewModel
    {
        [Required]
        [MaxLength(FullNameMinLenth)]
        [MinLength(FullNameMinLenth)]
        [Display(Name = FullNameDisplayName)]
        public string FullName { get; set; }

        [Required]
        [Display(Name = UsernameDisplay)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = EmailDisplay)]
        public string Email { get; set; }

        [Required]
        [MaxLength(PasswordMaxLength)]
        [MinLength(PasswordMinLength)]
        [DataType(DataType.Password)]
        [Display(Name = PasswordDisplay)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = PasswordValidation)]
        [DataType(DataType.Password)]
        [Display(Name = ConfirmPasswordDisplay)]

        public string ConfirmPassword { get; set; }
    }
}
