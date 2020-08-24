using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KTMTicketing.Models
{
    public class CustomerResponse
    {
        public Destination Destination { get; set; }
        public Passenger Passenger { get; set; }
    }
    public class Destination
    {
        [Required(ErrorMessage = "Please specify your origin")]
        public String OriginLoc { get; set; }

        [Required(ErrorMessage = "Please specify your destination")]
        public String DestiLoc { get; set; }

        [Required(ErrorMessage = "Please select your way")]
        public String WayLoc { get; set; }

        [Required(ErrorMessage = "Please select your type of citizen")]
        public String Citizen { get; set; }

        [Required(ErrorMessage = "Please insert quantity of ticket")]
        [Range(1,100)]
        public int Quantity { get; set; }
    }
    public class Passenger
    {
        [Required(ErrorMessage = "Please specify your name")]
        public String PassName { get; set; }

        [Required(ErrorMessage = "Please specify your identity card / passport number")]
        public String PassID { get; set; }

        [Required(ErrorMessage = "Please specify your email")]
        public String PassEmail { get; set; }
        public String OriginLoc { get; set; }
        public String DestiLoc { get; set; }
        public String WayLoc { get; set; }
        public String Citizen { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public String OriginLocID { get; set; }
        public String DestiLocID { get; set; }
        public String WayLocID { get; set; }
        public String CitizenID { get; set; }
    }
}