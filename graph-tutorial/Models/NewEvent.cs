using System;
using System.ComponentModel.DataAnnotations;

namespace GraphTutorial.Models
{
    public class NewEvent
    {
        [Required]
        public string Subject { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
        [RegularExpression(@"((\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)*([;])*)*",
          ErrorMessage="Please enter one or more email addresses separated by a semi-colon (;)")]
        public string Attendees { get; set; }
    }
}