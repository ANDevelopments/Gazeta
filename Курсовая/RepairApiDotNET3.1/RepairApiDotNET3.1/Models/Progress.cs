using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace RepairApiDotNET3.Models
{
    public class Progress
    {
        [Key]
        public string ProgressName { get; set; }
    }
}
