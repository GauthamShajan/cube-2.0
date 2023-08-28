using System.ComponentModel.DataAnnotations;

namespace cube_2._0.data_layer.Models
{
    public class MachineDetails
    {
        [Key]
        public string MachineId { get; set; }
        public string MachineName { get; set; }
        public string ProcessType { get; set; }// There are 9 types of processes which we can select from dropdown while adding a new machine
        public string MachineType { get; set; }//Automated or Manual
        public string MachineCategory { get; set; }//There are 12 types of categories which we can select from dropdown while adding a new machine
    }

}
