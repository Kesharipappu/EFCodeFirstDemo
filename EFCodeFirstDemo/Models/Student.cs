using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirstDemo.Models
{
    //[Table(name:"Student_Master")]
    public class Student
    {
        public int StudentID { get; set; } //scaler property
        //[Required()]
        //[Display(Name ="Student Name")]
        public string StudentName { get; set; }    //scaler property

        //[Required]
        public string DateOfBirth { get; set; }//scaler property
         public string Email { get; set; }
        public Address Address { get; set; } //Navigation property
    }
    public class Address
    {
        public int Id { get; set; }
        //[Required]
        public string AddressLine { get; set; }
       // [Required(ErrorMessage ="City Name is Mandatory")]
        public string City { get; set; }
        public ICollection<Student> Students { get; set; }

    }

}