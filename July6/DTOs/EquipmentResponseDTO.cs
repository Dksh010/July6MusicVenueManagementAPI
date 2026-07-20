using July6.Models;

namespace July6.DTOs
{
    public class EquipmentResponseDTO
    {
        public int Id { get; set; }
        public string ModelName { get; set; } = string.Empty;
        public EquipmentCondition Condition { get; set; }
    }
}
