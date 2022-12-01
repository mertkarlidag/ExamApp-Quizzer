using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamAPI.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }  
        
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }

        public int Password { get; set; }
        public int? Score{ get; set; }
        public int? TimeTaken { get; set; }
        public bool IsAdmin { get; set; }
    }
}
