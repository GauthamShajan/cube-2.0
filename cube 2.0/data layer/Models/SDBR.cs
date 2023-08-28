using System.ComponentModel.DataAnnotations.Schema;

namespace cube_2._0.data_layer.Models
{
    public class SDBR
    {
        public int id { get; set; }
        [ForeignKey("ord")]
        public string orderID { get; set; }
        public Order ord { get; set; }
        [ForeignKey("cust")]
        public int customer { get; set; }
        public Customer cust { get; set; }
        public float ProdWt { get; set; }
        public float coilRouteDuration_BBS { get; set; }
        public float rebarRouteDuration_BBS { get; set; }
        public float coilRouteDuration_SDBR { get; set; }
        public float rebarRouteDuration_SDBR { get; set; }
        public float coilRouteDiff { get; set; }
        public float rebarRouteDiff { get; set; }
        public DateTime delvDate { get; set; }
        public bool SDBRstatus { get; set; } //red or green
        public string Status { get; set; }
        public DateTime prodStartDate { get; set; }
        public string groupNo { get; set; }
        public int seqNo { get; set; }
        public DateTime poDate { get; set; }


    }

    public class Plan
    {
        public int id { get; set; }
        public DateTime planDate { get; set; }
        [ForeignKey("ord")]
        public string orderID { get; set; }
        public Order ord { get; set; }
        public string planParameter { get; set; }//Maximize offcuts/Maximize Scrap usage
        public int tolerance { get; set; }
        public string planRemarks { get; set; }
        [ForeignKey("sdbr")]
        public int sdbrID { get; set; }
        public SDBR sdbr { get; set; }

        public float scrapPercent { get; set; }
        public float offCutPercent { get; set; }
        public int totalCycle { get; set; }
        public int totalCut { get; set; }
        public string status { get; set; }
        public float  weight { get; set; }
        public int noTags { get; set; }
    }

    public class ProductionRecording
    {
        public int id { get; set; }
        [ForeignKey("ord")]
        public string orderID { get; set; }
        public Order ord { get; set; }
        [ForeignKey("plant")]
        public int plantID { get; set; }
        public Plant plant { get; set; }
        [ForeignKey("ed")]
        public int elementID { get; set; }
        public ElementDetails ed { get; set; }
        public float totalWeightProcessed { get; set; }
        public float remainingWeight { get; set; }
        public float totalPiecesProcessed { get; set; }
        public float remainingPieces { get; set; }
        public string materialType { get; set; }

        public int length { get; set; }
        public string remnantMaterial { get; set; }
        [ForeignKey("plan")]
        public int planID { get; set; }
        public Plan plan { get; set; }
        public string storageLocationFrom { get; set; }
        public string storageLocationTo { get; set; }
        public int batchNo { get; set; }
        public float actualQty { get; set; }

    }

    public class PlantOrders
    {
        public int id { get; set; }
        [ForeignKey("plant")]
        public int plantID { get; set; }
        public Plant plant { get; set; }
        [ForeignKey("ord")]
        public string orderID { get; set; }
        public Order ord { get; set; }

    }

    public class LoadingListDetails
    {
        public int id { get; set; }
        public string name { get; set; }
        [ForeignKey("order")]
        public string orderID { get; set; }
        public Order order { get; set; }
        public string trailerNo { get; set; }
        [ForeignKey("ed")]
        public int elementDetailsID { get; set; }
        public ElementDetails ed { get; set; }
        public int totalBundles { get; set; }
        public int totalRods { get; set; }

    }

    public class LoadingList
    {
        public int id { get; set; }
        [ForeignKey("ld")]
        public int loadingDetails { get; set; }
        public LoadingListDetails ld { get; set; }

        public DateTime gatePassPrintDate { get; set; }
        public float totalWeight { get; set; }
        public float weighBridgeWeight { get; set; }
        public string gatePassNo { get; set; }

    }

    public class DifficultyFactor
    {
        public int id { get; set; }
        public string category { get; set; }
        public int difficultyFactor { get; set; }
    }

    //public class StatusType
    //{
    //    public int id { get; set; }
    //    public string name { get; set; }
    //    public float color { get; set; }
    //}
}
