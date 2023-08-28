using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace cube_2._0.data_layer.Models
{

    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }//order id will be calculated in a specific way

        public string SAP_Id    { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Offer { get; set; }
        public string OrderType { get; set; }
        public string OrderRemarks { get; set; }

        public int SoldToPartyId { get; set; }

        public int ShipToPartyId { get; set; }

        public int BillToPartyId { get; set; }

        [ForeignKey("eid")]
        public int ElementId { get; set; }

        //public Customer cid { get; set; }
        public Element eid { get; set; }
        [ForeignKey("dfac")]
        public int dfactor { get; set; }
        public DifficultyFactor dfac { get; set; }
        public string tocTAT { get; set; }
        public int flag { get; set; }
    }

}
