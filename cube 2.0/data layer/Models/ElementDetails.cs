using System.ComponentModel.DataAnnotations.Schema;

namespace cube_2._0.data_layer.Models
{

    public class ElementDetails
    {
        public int Id { get; set; }

        public string BarMarkId { get; set; }

        public int No_of_Pieces { get; set; }
        public int Total_No_of_Pieces { get; set; }
        public int bundleID { get; set; }
        public int bmRow { get; set; }//need clarity
        public int plID { get; set; }//need clarity
        public int Bund_Qty { get; set; }//need clarity
        public bool lengthDeduction { get; set; }
        public bool scale { get; set; }
        public float InventoryLength { get; set; }
        public float ProductionLength { get; set; }
        public float InventoryWeight { get; set; }
        public float ProductionWeight { get; set; }
        public int TagId { get; set; }//auto incremented based on number of shapes
        [ForeignKey("sid")]
        public int ShapeId { get; set; }
        public Shape sid { get;set; }
        public float PinDia { get; set; }
        [ForeignKey("eid")]
        public int ElementId { get; set; }

        public Element eid { get; set; }

        [ForeignKey("gid")]

        public int GradeId { get; set; }
        public GradeDetails gid { get; set; }
        [ForeignKey("rid")]
        public int RouteId { get; set; }
        public Dia_Wise_Route rid { get; set; }



    }
}
