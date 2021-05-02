using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace TaskList.Models
{
    public class TaskItem
    {
        public int ID { get; set; }
        public string Description { get; set; }
        [Display(Name = "Completed By")]
        public DateTime CompleteBy { get; set; }
        [Display(Name = "Completed")]
        public bool IsCompleted { get; set; }
        public IdentityUser User { get; set; }
    }
}
