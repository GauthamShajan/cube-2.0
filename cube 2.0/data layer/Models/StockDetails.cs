using System.ComponentModel.DataAnnotations.Schema;

namespace cube_2._0.data_layer.Models
{

    public class StockDeatils
    {
        public int Id { get; set; }

        //Material description is there so we need to include it here or in the material details master table

        public int BatchNo { get; set; }//need more info on that
        public float Weight { get; set; }
        public int TotalPieces { get; set; }
        [ForeignKey("gid")]
        public int gradeID { get; set; }
        public GradeDetails gid { get; set; }
    }

}
