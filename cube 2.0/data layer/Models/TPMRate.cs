using System.ComponentModel.DataAnnotations;

namespace cube_2._0.data_layer.Models
{

    public class TPMRate
    {
        public string Route { get; set; }
        [Key]
        public int Diff_fact { get; set; }
        public int Prod_Rate { get; set; }
    }

}
