using Microsoft.EntityFrameworkCore;

namespace cube_2._0.data_layer.Models
{
    public class Cube2Context : DbContext
    {
        public Cube2Context(DbContextOptions<Cube2Context> options):base(options)
        {
                
        }
        public DbSet<Shape> shapes { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Plant> plants { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<GradeDetails> grades { get; set; }
        public DbSet<MachineDetails> machines { get; set; }
        public DbSet<MaxRebarPerCycle> maxReBarMaster { get; set; }
        public DbSet<Costing> costings { get; set; }
        public DbSet<PlantCapacity> plantCapacities { get; set; }
        public DbSet<TPMRate> tpmrates { get; set; }
        public DbSet<StockDeatils> stocks { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Element> elements { get; set; }
        public DbSet<ElementDetails> elementdetails { get; set; }

        public DbSet<SDBR> sdbrs { get; set; }
        public DbSet<ProductionRecording> productRecordings { get; set; }
        public DbSet<Plan> plans { get; set; }
        public DbSet<LoadingListDetails> loadinglistdetails { get; set; }
        public DbSet<LoadingList> loadinglists { get; set; }
        public DbSet<DifficultyFactor> difficultyfactors { get; set; }
        public DbSet<Dia_Wise_Route> diawiseroutes { get; set; }

        public DbSet<PlantOrders> plantorders { get; set; }
    }
}
