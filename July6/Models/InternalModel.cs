namespace July6.Models
{
    public class InternalModel
    {
        public int Id { get; set; }
        public string ModelName { get; set; } = string.Empty;
        public EquipmentCondition Condition { get; set; } = EquipmentCondition.Used;
        public decimal PurchasePrice { get; set; }
    }
}
