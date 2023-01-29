using System;
using System.ComponentModel.DataAnnotations;

namespace WarehouseAPI.Models
{
    public class NewProduct
    {
        [Required]
        [Range(1,int.MaxValue, ErrorMessage = "Nie moze byc puste")]
        public int IdProduct { get; set; }
        
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Nie moze byc puste")]
        public int IdWarehouse { get; set; }
        
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Musi byc wieksze od 0")]
        public int Amount { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
    }
}
