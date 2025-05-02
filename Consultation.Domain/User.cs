using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.Domain
{
    public class User
    {
        public string UserID { get; set; }

        public string UserPassword { get; set; }

        public string UserEmail { get; set; }

        [ForeignKey(nameof(FacultyID))]
        public string? FacultyID { get; set; }

        [ForeignKey(nameof(StudentID))]
        public string? StudentID { get; set; }

    }
}
