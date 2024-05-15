using System.ComponentModel.DataAnnotations.Schema;

namespace EF_CodeFirst.Models
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }

        [ForeignKey("StudentId")]
        public int StudentId { get; set; }

    }
}
