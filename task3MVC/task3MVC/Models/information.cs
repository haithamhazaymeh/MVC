//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace task3MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
 
    public partial class information
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "*")]
        [StringLength(12)]
        [Display(Name = "First Name")]

        public string First_Name { get; set; }
        [Required(ErrorMessage = "*")]
        [StringLength(12)]
        [Display(Name = "Last Name")]


        public string Last_Name { get; set; }
        [Required(ErrorMessage = "*")]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [RegularExpression("((079)|(078)|(077)){1}[0-9]{7}", ErrorMessage = "Enter A Valid Jordanian Phone Number")]
        public string Phone { get; set; }
        [Range(18, 50)]
        [Required(ErrorMessage = "*")]
        public Nullable<int> Age { get; set; }
        [MaxLength(10)]
        [Required(ErrorMessage = "*")]
        [Display(Name = "Jop Titel")]
        public string JopTitel { get; set; }

        public Nullable<bool> Gender { get; set; }

        public string GenderDisplay
        {
            get
            {
                if (Gender == null)
                {
                    return "Not specified";
                }
                else
                {
                    return Gender == true ? "Male" : "Female";
                }
            }

        
        }
        [Required(ErrorMessage = "*")]

        public string Imges { get; set; }

        [Required(ErrorMessage = "*")]

        public string CV { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}
