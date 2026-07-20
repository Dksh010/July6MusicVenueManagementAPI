using July6.DTOs;
using July6.Models;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Runtime.CompilerServices;

namespace July6.Services
{
    public class EquipmentService : IEquipmentService
    {
        private readonly static List<InternalModel> _equipmentList = new List<InternalModel>()
        {
            new InternalModel {Id = 1, ModelName = "Fender", Condition = EquipmentCondition.BrandNew, PurchasePrice = 1000},
            new InternalModel {Id = 2, ModelName = "Gibson", Condition = EquipmentCondition.Used, PurchasePrice = 1200},
            new InternalModel {Id = 3, ModelName = "PRS", Condition = EquipmentCondition.Broken, PurchasePrice = 750},
            new InternalModel {Id = 4, ModelName = "Stagg", Condition = EquipmentCondition.BrandNew, PurchasePrice = 500}
        };

        public List<EquipmentResponseDTO> GetEquipments ()
        {
            List<EquipmentResponseDTO> allEquipments = new List<EquipmentResponseDTO>();

            foreach(InternalModel e in _equipmentList )
            {
                allEquipments.Add( new EquipmentResponseDTO
                {
                    Id = e.Id,
                    ModelName = e.ModelName,
                    Condition = e.Condition
                } );
            }
            return allEquipments;
        }
        //
        public bool AddNewEquipment (EquipmentCreateDTO newEquipment)
        {
            int id = _equipmentList.Max( e => e.Id ) + 1;
            if(newEquipment == null )
            {
                return false;
            }

            InternalModel newModel = new InternalModel
            {
                Id = id ,
                Condition = newEquipment.Condition ,
                ModelName = newEquipment.ModelName ,
                PurchasePrice = newEquipment.PurchasePrice
            };
                _equipmentList.Add( newModel );
                return true;
        }
    }
}
