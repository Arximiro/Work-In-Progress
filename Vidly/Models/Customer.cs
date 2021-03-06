﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Name { get; set; }

        [Min18YearsIfAMember, Display(Name = "Date of Birth")]
        public DateTime? DateOfBirth { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }


        [Display(Name = "Membership")]
        public byte MembershipTypeId { get; set; }
        public MembershipType MembershipType { get; set; }
    }
}