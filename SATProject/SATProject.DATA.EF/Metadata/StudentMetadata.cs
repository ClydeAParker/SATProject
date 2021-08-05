using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATProject.DATA.EF.Metadata
{
    #region Student Metadata
    public class StudentMetadata
    {
        [Required(ErrorMessage = "Student First Name is required")]
        [StringLength(20, ErrorMessage = "*Name length must be 20 characters or less")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Student Last Name is required")]
        [StringLength(20, ErrorMessage = "*Name length must be 20 characters or less")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Major Name is required")]
        [StringLength(15, ErrorMessage = "*Name length must be 15 characters or less")]
        [Display(Name = "Major Name")]
        public string Major { get; set; }

        [StringLength(50, ErrorMessage = "*Value must be 50 characters or less")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string Address { get; set; }

        [StringLength(25, ErrorMessage = "*Value must be 25 characters or less")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string City { get; set; }

        [StringLength(2, MinimumLength = 2, ErrorMessage = "*Value must be 2 characters")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string State { get; set; }

        [StringLength(10, MinimumLength = 10, ErrorMessage = "*Value must be 10 characters")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string ZipCode { get; set; }

        [StringLength(13, MinimumLength = 13, ErrorMessage = "*Value must be 10 characters")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string Phone { get; set; }

        [StringLength(60, MinimumLength = 60, ErrorMessage = "*Value must be 10 characters")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string Email { get; set; }
    }
    #endregion
}
