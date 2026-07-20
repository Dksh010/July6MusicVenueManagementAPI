using July6.Models;
using System.ComponentModel.DataAnnotations;

namespace July6.DTOs
{
    public class EquipmentCreateDTO
    {
        [Required(ErrorMessage = "The model name is mandatory")]
        [Length(5, maximumLength: 120) ]
        public string ModelName { get; set; } = string.Empty;

        [Required(ErrorMessage = "The price is mandatory")]
        [Range(200, 10000)]
        public decimal PurchasePrice { get; set; }

        public EquipmentCondition Condition { get; set; } = EquipmentCondition.Used;
    }
}
