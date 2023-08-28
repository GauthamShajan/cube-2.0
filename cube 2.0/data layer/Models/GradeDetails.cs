using System.ComponentModel.DataAnnotations;

namespace cube_2._0.data_layer.Models
{
    public class GradeDetails
    {
        [Key]
        public int GradeId { get; set; }
        public string Material { get; set; }//Specific way to name the material by using the combination of other attributes
        public string MaterialType { get; set; }
        public string Grade { get; set; }
        public int Section { get; set; }
        public char BarType { get; set; }
        public int Density { get; set; }
        public int MinLength { get; set; }
        public int MaxLength { get; set; }

        public string RM_FG_Remmant{get;set;}
}

}
