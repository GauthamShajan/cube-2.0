using System.ComponentModel.DataAnnotations;

namespace cube_2._0.data_layer.Models
{
    //need to create self refrencing table for diffrernt customer types
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string CustomerType { get; set; }
        public string Town { get; set; }
        public string PinCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string RelatedTo { get; set; }

        //For getting the exact location
        public float Lat { get; set; }
        public float Lang { get; set; }


    }
}
