using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace cube_2._0.data_layer.Models
{
    //Plant Capacity
    public class PlantCapacity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public float Normal_Hour { get; set; }
        public float Rush_Hour { get; set; }
        public float Booked_Hour { get; set; }
        public float Booked_Rush { get; set; }
        [ForeignKey("pid")]
        public int PlantId { get; set; }
        public Plant pid { get; set; }

    }

}
