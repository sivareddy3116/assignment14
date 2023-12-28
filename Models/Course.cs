using System;
using System.Collections.Generic;

namespace WebAppassignment14.Models
{
    public partial class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Fee { get; set; }
        public string CourseCategory { get; set; } = null!;
        public DateTime? StartDate { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category? Category { get; set; }
    }
}
