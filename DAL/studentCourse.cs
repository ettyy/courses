//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class studentCourse
    {
        public int studentCourseId { get; set; }
        public int courseId { get; set; }
        public int studentId { get; set; }
        public Nullable<int> studentCourseMark { get; set; }
    
        public virtual cours cours { get; set; }
        public virtual student student { get; set; }
    }
}
