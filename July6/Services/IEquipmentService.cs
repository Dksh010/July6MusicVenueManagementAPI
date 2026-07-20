using July6.DTOs;

namespace July6.Services
{
    public interface IEquipmentService
    {
        List<EquipmentResponseDTO> GetEquipments ();
        bool AddNewEquipment ( EquipmentCreateDTO newEquipment );
    }
}
