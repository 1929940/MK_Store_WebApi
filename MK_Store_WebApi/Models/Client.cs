using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MK_Store_WebApi.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        public string Login { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(20)]
        public string Phone { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}