using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCodeFirst.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Column("StudentName", TypeName ="varchar(100)")]
        public string Name { get; set; }
        [Column("StudentGender", TypeName ="varchar(30)")]
        public string Gender { get; set; }
        [Column("StudentAge", TypeName ="int")]
        public int Age { get; set; }
        [Column("StudentStanderd", TypeName ="int")]
        public int  Standard { get; set; }

    }
}
