//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace online_test.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Exam_Schedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exam_Schedule()
        {
            this.assigned_user_exam = new HashSet<assigned_user_exam>();
            this.User_Exam_Answer = new HashSet<User_Exam_Answer>();
        }
    
        public int Id { get; set; }
        public System.DateTime Exam_date { get; set; }
        public string Exam_title { get; set; }
        public int Exam_duration { get; set; }
        public int Exam_total_question { get; set; }
        public string Exam_status { get; set; }
        public int Course_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<assigned_user_exam> assigned_user_exam { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Exam_Answer> User_Exam_Answer { get; set; }
    }
}
