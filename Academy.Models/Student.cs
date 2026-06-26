using Dapper.Contrib.Extensions;
using System;
namespace Academy.Models
{
    [Table("Students")]
    public class Student
    {
        [Key()]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateBirthday { get; set; } = null;
    }
}
