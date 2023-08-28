using System.ComponentModel.DataAnnotations.Schema;

namespace cube_2._0.data_layer.Models
{
    //Max Rebar per cycle
    public class MaxRebarPerCycle
    {
        public int Id { get; set; }

        public int MaxRebar { get; set; }

        [ForeignKey("mid")]
        public string MachineId { get; set; }//Foreign Key to Machine Deatils

        public MachineDetails mid { get; set; }

        [ForeignKey("gid")]
        public int GradeId { get; set; }//Foreign Key to Grade Details

        public GradeDetails gid { get; set; }

    }

}
