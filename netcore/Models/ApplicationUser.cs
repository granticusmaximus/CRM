﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace netcore.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public partial class ApplicationUser : IdentityUser
    {
        public string profilePictureUrl { get; set; } = "/images/empty_profile.png";
        public bool isSuperAdmin { get; set; } = false;

        //roles
        [Display(Name = "Index")]
        public bool isInRoleHomeIndex { get; set; } = false;
        [Display(Name = "About")]
        public bool isInRoleHomeAbout { get; set; } = false;
        [Display(Name = "Contact")]
        public bool isInRoleHomeContact { get; set; } = false;

        [Display(Name = "Roles")]
        public bool ApplicationUserRole { get; set; } = false;
    }
}
