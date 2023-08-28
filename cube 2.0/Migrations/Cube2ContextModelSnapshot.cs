﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cube_2._0.data_layer.Models;

#nullable disable

namespace cube_2._0.Migrations
{
    [DbContext(typeof(Cube2Context))]
    partial class Cube2ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("cube_2._0.data_layer.Models.Costing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnType("datetime2");

                    b.Property<int>("gradeID")
                        .HasColumnType("int");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("gradeID");

                    b.ToTable("costings");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Lang")
                        .HasColumnType("real");

                    b.Property<float>("Lat")
                        .HasColumnType("real");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PinCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelatedTo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.Dia_Wise_Route", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Dia")
                        .HasColumnType("int");

                    b.Property<string>("Route")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("diawiseroutes");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.DifficultyFactor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("difficultyFactor")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("difficultyfactors");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.Element", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ElementName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ElementStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("No_of_Sets")
                        .HasColumnType("int");

                    b.Property<string>("OrderId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TagPrintStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("elements");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.ElementDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BarMarkId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Bund_Qty")
                        .HasColumnType("int");

                    b.Property<int>("ElementId")
                        .HasColumnType("int");

                    b.Property<int>("GradeId")
                        .HasColumnType("int");

                    b.Property<float>("InventoryLength")
                        .HasColumnType("real");

                    b.Property<float>("InventoryWeight")
                        .HasColumnType("real");

                    b.Property<int>("No_of_Pieces")
                        .HasColumnType("int");

                    b.Property<float>("PinDia")
                        .HasColumnType("real");

                    b.Property<float>("ProductionLength")
                        .HasColumnType("real");

                    b.Property<float>("ProductionWeight")
                        .HasColumnType("real");

                    b.Property<int>("RouteId")
                        .HasColumnType("int");

                    b.Property<int>("ShapeId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.Property<int>("Total_No_of_Pieces")
                        .HasColumnType("int");

                    b.Property<int>("bmRow")
                        .HasColumnType("int");

                    b.Property<int>("bundleID")
                        .HasColumnType("int");

                    b.Property<bool>("lengthDeduction")
                        .HasColumnType("bit");

                    b.Property<int>("plID")
                        .HasColumnType("int");

                    b.Property<bool>("scale")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ElementId");

                    b.HasIndex("GradeId");

                    b.HasIndex("RouteId");

                    b.HasIndex("ShapeId");

                    b.ToTable("elementdetails");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.GradeDetails", b =>
                {
                    b.Property<int>("GradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GradeId"));

                    b.Property<string>("BarType")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("Density")
                        .HasColumnType("int");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaterialType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxLength")
                        .HasColumnType("int");

                    b.Property<int>("MinLength")
                        .HasColumnType("int");

                    b.Property<string>("RM_FG_Remmant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Section")
                        .HasColumnType("int");

                    b.HasKey("GradeId");

                    b.ToTable("grades");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.LoadingList", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("gatePassNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("gatePassPrintDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("loadingDetails")
                        .HasColumnType("int");

                    b.Property<float>("totalWeight")
                        .HasColumnType("real");

                    b.Property<float>("weighBridgeWeight")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.HasIndex("loadingDetails");

                    b.ToTable("loadinglists");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.LoadingListDetails", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("elementDetailsID")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("orderID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("totalBundles")
                        .HasColumnType("int");

                    b.Property<int>("totalRods")
                        .HasColumnType("int");

                    b.Property<string>("trailerNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("elementDetailsID");

                    b.HasIndex("orderID");

                    b.ToTable("loadinglistdetails");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.MachineDetails", b =>
                {
                    b.Property<string>("MachineId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MachineCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MachineName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MachineType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProcessType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MachineId");

                    b.ToTable("machines");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.MaxRebarPerCycle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GradeId")
                        .HasColumnType("int");

                    b.Property<string>("MachineId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("MaxRebar")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GradeId");

                    b.HasIndex("MachineId");

                    b.ToTable("maxReBarMaster");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.Order", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("BillToPartyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ElementId")
                        .HasColumnType("int");

                    b.Property<string>("Offer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderRemarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SAP_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShipToPartyId")
                        .HasColumnType("int");

                    b.Property<int>("SoldToPartyId")
                        .HasColumnType("int");

                    b.Property<int>("dfactor")
                        .HasColumnType("int");

                    b.Property<int>("flag")
                        .HasColumnType("int");

                    b.Property<string>("tocTAT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ElementId");

                    b.HasIndex("dfactor");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.Plan", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("noTags")
                        .HasColumnType("int");

                    b.Property<float>("offCutPercent")
                        .HasColumnType("real");

                    b.Property<string>("orderID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("planDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("planParameter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("planRemarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("scrapPercent")
                        .HasColumnType("real");

                    b.Property<int>("sdbrID")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tolerance")
                        .HasColumnType("int");

                    b.Property<int>("totalCut")
                        .HasColumnType("int");

                    b.Property<int>("totalCycle")
                        .HasColumnType("int");

                    b.Property<float>("weight")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.HasIndex("orderID");

                    b.HasIndex("sdbrID");

                    b.ToTable("plans");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.Plant", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emailID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("lat")
                        .HasColumnType("real");

                    b.Property<float>("lng")
                        .HasColumnType("real");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("plants");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.PlantCapacity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Booked_Hour")
                        .HasColumnType("real");

                    b.Property<float>("Booked_Rush")
                        .HasColumnType("real");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<float>("Normal_Hour")
                        .HasColumnType("real");

                    b.Property<int>("PlantId")
                        .HasColumnType("int");

                    b.Property<float>("Rush_Hour")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("PlantId");

                    b.ToTable("plantCapacities");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.PlantOrders", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("orderID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("plantID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("orderID");

                    b.HasIndex("plantID");

                    b.ToTable("plantorders");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.ProductionRecording", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<float>("actualQty")
                        .HasColumnType("real");

                    b.Property<int>("batchNo")
                        .HasColumnType("int");

                    b.Property<int>("elementID")
                        .HasColumnType("int");

                    b.Property<int>("length")
                        .HasColumnType("int");

                    b.Property<string>("materialType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("orderID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("planID")
                        .HasColumnType("int");

                    b.Property<int>("plantID")
                        .HasColumnType("int");

                    b.Property<float>("remainingPieces")
                        .HasColumnType("real");

                    b.Property<float>("remainingWeight")
                        .HasColumnType("real");

                    b.Property<string>("remnantMaterial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("storageLocationFrom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("storageLocationTo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("totalPiecesProcessed")
                        .HasColumnType("real");

                    b.Property<float>("totalWeightProcessed")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.HasIndex("elementID");

                    b.HasIndex("orderID");

                    b.HasIndex("planID");

                    b.HasIndex("plantID");

                    b.ToTable("productRecordings");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.SDBR", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<float>("ProdWt")
                        .HasColumnType("real");

                    b.Property<bool>("SDBRstatus")
                        .HasColumnType("bit");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("coilRouteDiff")
                        .HasColumnType("real");

                    b.Property<float>("coilRouteDuration_BBS")
                        .HasColumnType("real");

                    b.Property<float>("coilRouteDuration_SDBR")
                        .HasColumnType("real");

                    b.Property<int>("customer")
                        .HasColumnType("int");

                    b.Property<DateTime>("delvDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("groupNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("orderID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("poDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("prodStartDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("rebarRouteDiff")
                        .HasColumnType("real");

                    b.Property<float>("rebarRouteDuration_BBS")
                        .HasColumnType("real");

                    b.Property<float>("rebarRouteDuration_SDBR")
                        .HasColumnType("real");

                    b.Property<int>("seqNo")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("customer");

                    b.HasIndex("orderID");

                    b.ToTable("sdbrs");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.Shape", b =>
                {
                    b.Property<int>("ShapeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShapeId"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Fav")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgProperties")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShapeId");

                    b.ToTable("shapes");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.StockDeatils", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BatchNo")
                        .HasColumnType("int");

                    b.Property<int>("TotalPieces")
                        .HasColumnType("int");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.Property<int>("gradeID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("gradeID");

                    b.ToTable("stocks");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.TPMRate", b =>
                {
                    b.Property<int>("Diff_fact")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Diff_fact"));

                    b.Property<int>("Prod_Rate")
                        .HasColumnType("int");

                    b.Property<string>("Route")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Diff_fact");

                    b.ToTable("tpmrates");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlantID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("PlantID");

                    b.ToTable("users");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.Costing", b =>
                {
                    b.HasOne("cube_2._0.data_layer.Models.GradeDetails", "gd")
                        .WithMany()
                        .HasForeignKey("gradeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("gd");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.Element", b =>
                {
                    b.HasOne("cube_2._0.data_layer.Models.Order", "oid")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("oid");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.ElementDetails", b =>
                {
                    b.HasOne("cube_2._0.data_layer.Models.Element", "eid")
                        .WithMany()
                        .HasForeignKey("ElementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cube_2._0.data_layer.Models.GradeDetails", "gid")
                        .WithMany()
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cube_2._0.data_layer.Models.Dia_Wise_Route", "rid")
                        .WithMany()
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cube_2._0.data_layer.Models.Shape", "sid")
                        .WithMany()
                        .HasForeignKey("ShapeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("eid");

                    b.Navigation("gid");

                    b.Navigation("rid");

                    b.Navigation("sid");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.LoadingList", b =>
                {
                    b.HasOne("cube_2._0.data_layer.Models.LoadingListDetails", "ld")
                        .WithMany()
                        .HasForeignKey("loadingDetails")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ld");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.LoadingListDetails", b =>
                {
                    b.HasOne("cube_2._0.data_layer.Models.ElementDetails", "ed")
                        .WithMany()
                        .HasForeignKey("elementDetailsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cube_2._0.data_layer.Models.Order", "order")
                        .WithMany()
                        .HasForeignKey("orderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ed");

                    b.Navigation("order");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.MaxRebarPerCycle", b =>
                {
                    b.HasOne("cube_2._0.data_layer.Models.GradeDetails", "gid")
                        .WithMany()
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cube_2._0.data_layer.Models.MachineDetails", "mid")
                        .WithMany()
                        .HasForeignKey("MachineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("gid");

                    b.Navigation("mid");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.Order", b =>
                {
                    b.HasOne("cube_2._0.data_layer.Models.Element", "eid")
                        .WithMany()
                        .HasForeignKey("ElementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cube_2._0.data_layer.Models.DifficultyFactor", "dfac")
                        .WithMany()
                        .HasForeignKey("dfactor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("dfac");

                    b.Navigation("eid");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.Plan", b =>
                {
                    b.HasOne("cube_2._0.data_layer.Models.Order", "ord")
                        .WithMany()
                        .HasForeignKey("orderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cube_2._0.data_layer.Models.SDBR", "sdbr")
                        .WithMany()
                        .HasForeignKey("sdbrID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ord");

                    b.Navigation("sdbr");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.PlantCapacity", b =>
                {
                    b.HasOne("cube_2._0.data_layer.Models.Plant", "pid")
                        .WithMany()
                        .HasForeignKey("PlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pid");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.PlantOrders", b =>
                {
                    b.HasOne("cube_2._0.data_layer.Models.Order", "ord")
                        .WithMany()
                        .HasForeignKey("orderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cube_2._0.data_layer.Models.Plant", "plant")
                        .WithMany()
                        .HasForeignKey("plantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ord");

                    b.Navigation("plant");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.ProductionRecording", b =>
                {
                    b.HasOne("cube_2._0.data_layer.Models.ElementDetails", "ed")
                        .WithMany()
                        .HasForeignKey("elementID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cube_2._0.data_layer.Models.Order", "ord")
                        .WithMany()
                        .HasForeignKey("orderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cube_2._0.data_layer.Models.Plan", "plan")
                        .WithMany()
                        .HasForeignKey("planID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cube_2._0.data_layer.Models.Plant", "plant")
                        .WithMany()
                        .HasForeignKey("plantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ed");

                    b.Navigation("ord");

                    b.Navigation("plan");

                    b.Navigation("plant");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.SDBR", b =>
                {
                    b.HasOne("cube_2._0.data_layer.Models.Customer", "cust")
                        .WithMany()
                        .HasForeignKey("customer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cube_2._0.data_layer.Models.Order", "ord")
                        .WithMany()
                        .HasForeignKey("orderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cust");

                    b.Navigation("ord");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.StockDeatils", b =>
                {
                    b.HasOne("cube_2._0.data_layer.Models.GradeDetails", "gid")
                        .WithMany()
                        .HasForeignKey("gradeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("gid");
                });

            modelBuilder.Entity("cube_2._0.data_layer.Models.User", b =>
                {
                    b.HasOne("cube_2._0.data_layer.Models.Plant", "plant")
                        .WithMany()
                        .HasForeignKey("PlantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("plant");
                });
#pragma warning restore 612, 618
        }
    }
}
