using System.ComponentModel.DataAnnotations.Schema;

namespace cube_2._0.data_layer.Models
{

    public class Element
    {
        public int Id { get; set; }
        public string ElementName { get; set; }
        public int No_of_Sets { get; set; }
        public string TagPrintStatus { get; set; }

        public string ElementStatus { get; set; }
        [ForeignKey("oid")]
        public string OrderId { get; set; }

        public Order oid { get; set; }
    }

}
