namespace cube_2._0.data_layer.Models
{
    public class Shape
    {
        public int ShapeId { get; set; }
        //  public int AlternateId  { get; set; } Excluded because id will be auto generated
        public string Category { get; set; }

        public bool Fav { get; set; }
        //Collection of json data
        public string ImgProperties { get; set; }

        public string ImageUrl { get; set; }
    }

}
