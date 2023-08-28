using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace cube_2._0.data_layer.Models
{
    // Pricing master
    public class Costing
    {
        [Key]
        public int Id { get; set; }

        public float price { get; set; }
        public DateTime ValidFrom { get; set; }
        [ForeignKey("gd")]
        public int gradeID { get; set; }
        public GradeDetails gd { get; set; }

    }

}
