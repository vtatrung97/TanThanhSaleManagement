using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.SaleProject.Vehicles.Dtos
{

    public class CreateVehicleInput
    {
        [Required]
        public string PlateNumber { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int ProductionYear { get; set; }
    }
}
