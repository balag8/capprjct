﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Online_Vehicle_Rental_management.DAL.API;

namespace Online_Vehicle_Rental_management.DAL.API.Migrations
{
    [DbContext(typeof(OVRMDbContext))]
    partial class OVRMDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Online_Vehicle_Rental_management.Entities.API.Active_Booking", b =>
                {
                    b.Property<int>("Booking_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Booking_id")
                        .HasColumnType("int")
                        .HasMaxLength(20)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PaymentPayment_no")
                        .HasColumnType("int");

                    b.Property<string>("cancel_booking")
                        .IsRequired()
                        .HasColumnName("cancel_booking")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("vehicle_status")
                        .IsRequired()
                        .HasColumnName("vehicle_status")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Booking_id");

                    b.HasIndex("PaymentPayment_no");

                    b.ToTable("Active_Booking_Details");
                });

            modelBuilder.Entity("Online_Vehicle_Rental_management.Entities.API.Admin", b =>
                {
                    b.Property<int>("Admin_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("A_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Admin_Email")
                        .IsRequired()
                        .HasColumnName("Emailid")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Admin_Password")
                        .IsRequired()
                        .HasColumnName("password")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("First_name")
                        .IsRequired()
                        .HasColumnName("A_Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Last_name")
                        .IsRequired()
                        .HasColumnName("L_Name")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Mobile_No")
                        .IsRequired()
                        .HasColumnName("p_No")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Admin_id");

                    b.ToTable("admin");
                });

            modelBuilder.Entity("Online_Vehicle_Rental_management.Entities.API.Booking_Details", b =>
                {
                    b.Property<int>("Booking_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Booking_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Booking_Date")
                        .HasColumnName("Booking_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("VechicleVechicle_number")
                        .HasColumnType("int");

                    b.Property<string>("payment_details")
                        .IsRequired()
                        .HasColumnName("payment_details")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("vehicle_number")
                        .HasColumnType("int");

                    b.HasKey("Booking_id");

                    b.HasIndex("vehicle_number");

                    b.ToTable("Booking_Details");
                });

            modelBuilder.Entity("Online_Vehicle_Rental_management.Entities.API.Customer", b =>
                {
                    b.Property<int>("Customer_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Cust_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdminAdmin_id")
                        .HasColumnType("int");

                    b.Property<string>("Cust_Emailid")
                        .IsRequired()
                        .HasColumnName("Cust_email")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Cust_FstName")
                        .IsRequired()
                        .HasColumnName("Cust_FName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Cust_LstName")
                        .IsRequired()
                        .HasColumnName("Cust_LName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Cust_Password")
                        .IsRequired()
                        .HasColumnName("password")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Cust_drivingLicence")
                        .IsRequired()
                        .HasColumnName("Driving_licence")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Mobile_no")
                        .IsRequired()
                        .HasColumnName("cust_phno")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Customer_id");

                    b.HasIndex("AdminAdmin_id");

                    b.ToTable("Cust");
                });

            modelBuilder.Entity("Online_Vehicle_Rental_management.Entities.API.Payment", b =>
                {
                    b.Property<int>("Payment_no")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Payment_no")
                        .HasColumnType("int")
                        .HasMaxLength(20)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Booking_DetailsBooking_id")
                        .HasColumnType("int");

                    b.Property<string>("payment_details")
                        .IsRequired()
                        .HasColumnName("payment_details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("payment_mode")
                        .IsRequired()
                        .HasColumnName("payment_mode")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Payment_no");

                    b.HasIndex("Booking_DetailsBooking_id");

                    b.ToTable("payment_details");
                });

            modelBuilder.Entity("Online_Vehicle_Rental_management.Entities.API.Vehicle", b =>
                {
                    b.Property<int>("vehicle_number")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Vehicle_Number")
                        .HasColumnType("int")
                        .HasMaxLength(20)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerCustomer_id")
                        .HasColumnType("int");

                    b.Property<int>("price")
                        .HasColumnName("Vehicle_price")
                        .HasColumnType("int")
                        .HasMaxLength(40);

                    b.Property<string>("vehicle_type")
                        .IsRequired()
                        .HasColumnName("Vehicle_Type")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("vehicle_number");

                    b.HasIndex("CustomerCustomer_id");

                    b.ToTable("Vehicle_Details");
                });

            modelBuilder.Entity("Online_Vehicle_Rental_management.Entities.API.Active_Booking", b =>
                {
                    b.HasOne("Online_Vehicle_Rental_management.Entities.API.Payment", null)
                        .WithMany("Active_Bookings")
                        .HasForeignKey("PaymentPayment_no")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Online_Vehicle_Rental_management.Entities.API.Booking_Details", b =>
                {
                    b.HasOne("Online_Vehicle_Rental_management.Entities.API.Vehicle", null)
                        .WithMany("Booking_Details")
                        .HasForeignKey("vehicle_number");
                });

            modelBuilder.Entity("Online_Vehicle_Rental_management.Entities.API.Customer", b =>
                {
                    b.HasOne("Online_Vehicle_Rental_management.Entities.API.Admin", "admin")
                        .WithMany("Customers")
                        .HasForeignKey("AdminAdmin_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Online_Vehicle_Rental_management.Entities.API.Payment", b =>
                {
                    b.HasOne("Online_Vehicle_Rental_management.Entities.API.Booking_Details", null)
                        .WithMany("payments")
                        .HasForeignKey("Booking_DetailsBooking_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Online_Vehicle_Rental_management.Entities.API.Vehicle", b =>
                {
                    b.HasOne("Online_Vehicle_Rental_management.Entities.API.Customer", null)
                        .WithMany("vehicle")
                        .HasForeignKey("CustomerCustomer_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}