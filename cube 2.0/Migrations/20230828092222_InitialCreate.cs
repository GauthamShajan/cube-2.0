using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cube_2._0.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PinCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelatedTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lat = table.Column<float>(type: "real", nullable: false),
                    Lang = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "diawiseroutes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dia = table.Column<int>(type: "int", nullable: false),
                    Route = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diawiseroutes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "difficultyfactors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    difficultyFactor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_difficultyfactors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "grades",
                columns: table => new
                {
                    GradeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section = table.Column<int>(type: "int", nullable: false),
                    BarType = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Density = table.Column<int>(type: "int", nullable: false),
                    MinLength = table.Column<int>(type: "int", nullable: false),
                    MaxLength = table.Column<int>(type: "int", nullable: false),
                    RM_FG_Remmant = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grades", x => x.GradeId);
                });

            migrationBuilder.CreateTable(
                name: "machines",
                columns: table => new
                {
                    MachineId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MachineName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProcessType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MachineType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MachineCategory = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_machines", x => x.MachineId);
                });

            migrationBuilder.CreateTable(
                name: "plants",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contactNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    emailID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lat = table.Column<float>(type: "real", nullable: false),
                    lng = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plants", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "shapes",
                columns: table => new
                {
                    ShapeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fav = table.Column<bool>(type: "bit", nullable: false),
                    ImgProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shapes", x => x.ShapeId);
                });

            migrationBuilder.CreateTable(
                name: "tpmrates",
                columns: table => new
                {
                    Diff_fact = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Route = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prod_Rate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tpmrates", x => x.Diff_fact);
                });

            migrationBuilder.CreateTable(
                name: "costings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    price = table.Column<float>(type: "real", nullable: false),
                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    gradeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_costings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_costings_grades_gradeID",
                        column: x => x.gradeID,
                        principalTable: "grades",
                        principalColumn: "GradeId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "stocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BatchNo = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    TotalPieces = table.Column<int>(type: "int", nullable: false),
                    gradeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_stocks_grades_gradeID",
                        column: x => x.gradeID,
                        principalTable: "grades",
                        principalColumn: "GradeId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "maxReBarMaster",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaxRebar = table.Column<int>(type: "int", nullable: false),
                    MachineId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GradeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_maxReBarMaster", x => x.Id);
                    table.ForeignKey(
                        name: "FK_maxReBarMaster_grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "grades",
                        principalColumn: "GradeId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_maxReBarMaster_machines_MachineId",
                        column: x => x.MachineId,
                        principalTable: "machines",
                        principalColumn: "MachineId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "plantCapacities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Normal_Hour = table.Column<float>(type: "real", nullable: false),
                    Rush_Hour = table.Column<float>(type: "real", nullable: false),
                    Booked_Hour = table.Column<float>(type: "real", nullable: false),
                    Booked_Rush = table.Column<float>(type: "real", nullable: false),
                    PlantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plantCapacities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_plantCapacities_plants_PlantId",
                        column: x => x.PlantId,
                        principalTable: "plants",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantID = table.Column<int>(type: "int", nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_users_plants_PlantID",
                        column: x => x.PlantID,
                        principalTable: "plants",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "elementdetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BarMarkId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    No_of_Pieces = table.Column<int>(type: "int", nullable: false),
                    Total_No_of_Pieces = table.Column<int>(type: "int", nullable: false),
                    bundleID = table.Column<int>(type: "int", nullable: false),
                    bmRow = table.Column<int>(type: "int", nullable: false),
                    plID = table.Column<int>(type: "int", nullable: false),
                    Bund_Qty = table.Column<int>(type: "int", nullable: false),
                    lengthDeduction = table.Column<bool>(type: "bit", nullable: false),
                    scale = table.Column<bool>(type: "bit", nullable: false),
                    InventoryLength = table.Column<float>(type: "real", nullable: false),
                    ProductionLength = table.Column<float>(type: "real", nullable: false),
                    InventoryWeight = table.Column<float>(type: "real", nullable: false),
                    ProductionWeight = table.Column<float>(type: "real", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false),
                    ShapeId = table.Column<int>(type: "int", nullable: false),
                    PinDia = table.Column<float>(type: "real", nullable: false),
                    ElementId = table.Column<int>(type: "int", nullable: false),
                    GradeId = table.Column<int>(type: "int", nullable: false),
                    RouteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_elementdetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_elementdetails_diawiseroutes_RouteId",
                        column: x => x.RouteId,
                        principalTable: "diawiseroutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_elementdetails_grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "grades",
                        principalColumn: "GradeId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_elementdetails_shapes_ShapeId",
                        column: x => x.ShapeId,
                        principalTable: "shapes",
                        principalColumn: "ShapeId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "elements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElementName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    No_of_Sets = table.Column<int>(type: "int", nullable: false),
                    TagPrintStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ElementStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_elements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SAP_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Offer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoldToPartyId = table.Column<int>(type: "int", nullable: false),
                    ShipToPartyId = table.Column<int>(type: "int", nullable: false),
                    BillToPartyId = table.Column<int>(type: "int", nullable: false),
                    ElementId = table.Column<int>(type: "int", nullable: false),
                    dfactor = table.Column<int>(type: "int", nullable: false),
                    tocTAT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    flag = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_orders_difficultyfactors_dfactor",
                        column: x => x.dfactor,
                        principalTable: "difficultyfactors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_orders_elements_ElementId",
                        column: x => x.ElementId,
                        principalTable: "elements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "loadinglistdetails",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    orderID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    trailerNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    elementDetailsID = table.Column<int>(type: "int", nullable: false),
                    totalBundles = table.Column<int>(type: "int", nullable: false),
                    totalRods = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loadinglistdetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_loadinglistdetails_elementdetails_elementDetailsID",
                        column: x => x.elementDetailsID,
                        principalTable: "elementdetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_loadinglistdetails_orders_orderID",
                        column: x => x.orderID,
                        principalTable: "orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "plantorders",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    plantID = table.Column<int>(type: "int", nullable: false),
                    orderID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plantorders", x => x.id);
                    table.ForeignKey(
                        name: "FK_plantorders_orders_orderID",
                        column: x => x.orderID,
                        principalTable: "orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_plantorders_plants_plantID",
                        column: x => x.plantID,
                        principalTable: "plants",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "sdbrs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orderID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    customer = table.Column<int>(type: "int", nullable: false),
                    ProdWt = table.Column<float>(type: "real", nullable: false),
                    coilRouteDuration_BBS = table.Column<float>(type: "real", nullable: false),
                    rebarRouteDuration_BBS = table.Column<float>(type: "real", nullable: false),
                    coilRouteDuration_SDBR = table.Column<float>(type: "real", nullable: false),
                    rebarRouteDuration_SDBR = table.Column<float>(type: "real", nullable: false),
                    coilRouteDiff = table.Column<float>(type: "real", nullable: false),
                    rebarRouteDiff = table.Column<float>(type: "real", nullable: false),
                    delvDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SDBRstatus = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prodStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    groupNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    seqNo = table.Column<int>(type: "int", nullable: false),
                    poDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sdbrs", x => x.id);
                    table.ForeignKey(
                        name: "FK_sdbrs_customers_customer",
                        column: x => x.customer,
                        principalTable: "customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_sdbrs_orders_orderID",
                        column: x => x.orderID,
                        principalTable: "orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "loadinglists",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    loadingDetails = table.Column<int>(type: "int", nullable: false),
                    gatePassPrintDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    totalWeight = table.Column<float>(type: "real", nullable: false),
                    weighBridgeWeight = table.Column<float>(type: "real", nullable: false),
                    gatePassNo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loadinglists", x => x.id);
                    table.ForeignKey(
                        name: "FK_loadinglists_loadinglistdetails_loadingDetails",
                        column: x => x.loadingDetails,
                        principalTable: "loadinglistdetails",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "plans",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    planDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    orderID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    planParameter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tolerance = table.Column<int>(type: "int", nullable: false),
                    planRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sdbrID = table.Column<int>(type: "int", nullable: false),
                    scrapPercent = table.Column<float>(type: "real", nullable: false),
                    offCutPercent = table.Column<float>(type: "real", nullable: false),
                    totalCycle = table.Column<int>(type: "int", nullable: false),
                    totalCut = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    weight = table.Column<float>(type: "real", nullable: false),
                    noTags = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plans", x => x.id);
                    table.ForeignKey(
                        name: "FK_plans_orders_orderID",
                        column: x => x.orderID,
                        principalTable: "orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_plans_sdbrs_sdbrID",
                        column: x => x.sdbrID,
                        principalTable: "sdbrs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "productRecordings",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orderID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    plantID = table.Column<int>(type: "int", nullable: false),
                    elementID = table.Column<int>(type: "int", nullable: false),
                    totalWeightProcessed = table.Column<float>(type: "real", nullable: false),
                    remainingWeight = table.Column<float>(type: "real", nullable: false),
                    totalPiecesProcessed = table.Column<float>(type: "real", nullable: false),
                    remainingPieces = table.Column<float>(type: "real", nullable: false),
                    materialType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    length = table.Column<int>(type: "int", nullable: false),
                    remnantMaterial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    planID = table.Column<int>(type: "int", nullable: false),
                    storageLocationFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    storageLocationTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    batchNo = table.Column<int>(type: "int", nullable: false),
                    actualQty = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productRecordings", x => x.id);
                    table.ForeignKey(
                        name: "FK_productRecordings_elementdetails_elementID",
                        column: x => x.elementID,
                        principalTable: "elementdetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_productRecordings_orders_orderID",
                        column: x => x.orderID,
                        principalTable: "orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_productRecordings_plans_planID",
                        column: x => x.planID,
                        principalTable: "plans",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_productRecordings_plants_plantID",
                        column: x => x.plantID,
                        principalTable: "plants",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_costings_gradeID",
                table: "costings",
                column: "gradeID");

            migrationBuilder.CreateIndex(
                name: "IX_elementdetails_ElementId",
                table: "elementdetails",
                column: "ElementId");

            migrationBuilder.CreateIndex(
                name: "IX_elementdetails_GradeId",
                table: "elementdetails",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_elementdetails_RouteId",
                table: "elementdetails",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_elementdetails_ShapeId",
                table: "elementdetails",
                column: "ShapeId");

            migrationBuilder.CreateIndex(
                name: "IX_elements_OrderId",
                table: "elements",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_loadinglistdetails_elementDetailsID",
                table: "loadinglistdetails",
                column: "elementDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_loadinglistdetails_orderID",
                table: "loadinglistdetails",
                column: "orderID");

            migrationBuilder.CreateIndex(
                name: "IX_loadinglists_loadingDetails",
                table: "loadinglists",
                column: "loadingDetails");

            migrationBuilder.CreateIndex(
                name: "IX_maxReBarMaster_GradeId",
                table: "maxReBarMaster",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_maxReBarMaster_MachineId",
                table: "maxReBarMaster",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_dfactor",
                table: "orders",
                column: "dfactor");

            migrationBuilder.CreateIndex(
                name: "IX_orders_ElementId",
                table: "orders",
                column: "ElementId");

            migrationBuilder.CreateIndex(
                name: "IX_plans_orderID",
                table: "plans",
                column: "orderID");

            migrationBuilder.CreateIndex(
                name: "IX_plans_sdbrID",
                table: "plans",
                column: "sdbrID");

            migrationBuilder.CreateIndex(
                name: "IX_plantCapacities_PlantId",
                table: "plantCapacities",
                column: "PlantId");

            migrationBuilder.CreateIndex(
                name: "IX_plantorders_orderID",
                table: "plantorders",
                column: "orderID");

            migrationBuilder.CreateIndex(
                name: "IX_plantorders_plantID",
                table: "plantorders",
                column: "plantID");

            migrationBuilder.CreateIndex(
                name: "IX_productRecordings_elementID",
                table: "productRecordings",
                column: "elementID");

            migrationBuilder.CreateIndex(
                name: "IX_productRecordings_orderID",
                table: "productRecordings",
                column: "orderID");

            migrationBuilder.CreateIndex(
                name: "IX_productRecordings_planID",
                table: "productRecordings",
                column: "planID");

            migrationBuilder.CreateIndex(
                name: "IX_productRecordings_plantID",
                table: "productRecordings",
                column: "plantID");

            migrationBuilder.CreateIndex(
                name: "IX_sdbrs_customer",
                table: "sdbrs",
                column: "customer");

            migrationBuilder.CreateIndex(
                name: "IX_sdbrs_orderID",
                table: "sdbrs",
                column: "orderID");

            migrationBuilder.CreateIndex(
                name: "IX_stocks_gradeID",
                table: "stocks",
                column: "gradeID");

            migrationBuilder.CreateIndex(
                name: "IX_users_PlantID",
                table: "users",
                column: "PlantID");

            migrationBuilder.AddForeignKey(
                name: "FK_elementdetails_elements_ElementId",
                table: "elementdetails",
                column: "ElementId",
                principalTable: "elements",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_elements_orders_OrderId",
                table: "elements",
                column: "OrderId",
                principalTable: "orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_elements_ElementId",
                table: "orders");

            migrationBuilder.DropTable(
                name: "costings");

            migrationBuilder.DropTable(
                name: "loadinglists");

            migrationBuilder.DropTable(
                name: "maxReBarMaster");

            migrationBuilder.DropTable(
                name: "plantCapacities");

            migrationBuilder.DropTable(
                name: "plantorders");

            migrationBuilder.DropTable(
                name: "productRecordings");

            migrationBuilder.DropTable(
                name: "stocks");

            migrationBuilder.DropTable(
                name: "tpmrates");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "loadinglistdetails");

            migrationBuilder.DropTable(
                name: "machines");

            migrationBuilder.DropTable(
                name: "plans");

            migrationBuilder.DropTable(
                name: "plants");

            migrationBuilder.DropTable(
                name: "elementdetails");

            migrationBuilder.DropTable(
                name: "sdbrs");

            migrationBuilder.DropTable(
                name: "diawiseroutes");

            migrationBuilder.DropTable(
                name: "grades");

            migrationBuilder.DropTable(
                name: "shapes");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "elements");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "difficultyfactors");
        }
    }
}
