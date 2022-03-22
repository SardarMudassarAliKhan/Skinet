using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Skinet.Dtos
{
    public class CustomerbasketDto
    {
        [Required]
        public string Id { get; set; }
        public List<BasketItemDto> Items { get; set; }
    }
}
