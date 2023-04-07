using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.VisualStudio.Debugger.Contracts.EditAndContinue;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstTask.Models
{
    //[Table("add")]
    public class Hello
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Phone { get; set; }
        public string Email { get; set; } = null!;

        public int Time { get; set; }
        public string Place { get; set; } = null!;  
        
    }
}
