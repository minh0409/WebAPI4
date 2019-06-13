using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Company
    {
        public int ID { get; set; }
        [Display(Name = "Company Name")]
        public string Name { get; set; }

        [Display(Name = "Company Contacts")]
        public Contacts Contacts { get; set; }

        [Display(Name = "Company Status")]
        public string Status { get; set; }

        [Display(Name = "Financial Statement")]
        public Financial Financial { get; set; }

        public Address Address { get; set; }
    }

    public class Contacts
    {
        [Required]
        [StringLength(100)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }

    public class Financial
    {
        [Display(Name = "Today's Profit")]
        public double Profit { get; set; }

        [Display(Name = "New Orders")]
        public double Orders { get; set; }

    }
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

    }

}