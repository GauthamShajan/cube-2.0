using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace cube_2._0.data_layer.Models
{
    public class User
    {
        public int UserId { get; set; }
        [ForeignKey("plant")]
        public int? PlantID { get; set; } =null;
        public Plant plant { get; set; }
        public String UserType { get; set; } = null!;
        public String UserName { get; set; } = null!;
        public String Password { get; set; } = null!;
        public String MailId { get; set; } = null!;
        public String ConfirmPassword { get; set; } = null!;
    }

    public class Plant
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string contactNo { get; set; }
        public string emailID { get; set; }
        public float lat { get; set; }
        public float lng  { get; set; }
    }
}
