using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace YouthOutreach_HI_MVC.Models
{
    public class Donations
    {
        [Key]
        public int DonationId { get; set; }

        public string Category { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Comments { get; set; }
        public bool Hot { get; set; }

    }
}