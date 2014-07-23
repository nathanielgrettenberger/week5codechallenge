using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace W3CodeChallenge.Models
{

    // create a new partial new class
    // for w3codechallenge form
    // so we ca connect the validation propertires with 
    // metadaata
    [MetadataType(typeof(W3CodeChallengeValidation))]
    public partial class W3Codechallengevalidation
    { };
    public class W3CodeChallengeValidation
    { [Required, Display(Name="First Name"), MaxLength(50)]
        public string FirstName { get; set; }
     
        
        [Required, Display(Name="Last Name"), MaxLength(50)]
        public string LastName { get; set; }
     
    }

}