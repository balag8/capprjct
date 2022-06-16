using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Online_Vehicle_Rental_management.DAL.API.Migrations
{
    public partial class Initalcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admin",
                columns: table => new
                {
                    A_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    A_Name = table.Column<string>(maxLength: 50, nullable: false),
                    L_Name = table.Column<string>(maxLength: 30, nullable: false),
                    Emailid = table.Column<string>(maxLength: 50, nullable: false),
                    p_No = table.Column<string>(maxLength: 10, nullable: false),
                    password = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin", x => x.A_id);
                });

            migrationBuilder.CreateTable(
                name: "Cust",
                columns: table => new
                {
                    Cust_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cust_FName = table.Column<string>(maxLength: 30, nullable: false),
                    Cust_LName = table.Column<string>(maxLength: 30, nullable: false),
                    Cust_email = table.Column<string>(maxLength: 30, nullable: false),
                    cust_phno = table.Column<string>(maxLength: 20, nullable: false),
                    password = table.Column<string>(maxLength: 20, nullable: false),
                    Driving_licence = table.Column<string>(maxLength: 50, nullable: false),
                    AdminAdmin_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cust", x => x.Cust_id);
                    table.ForeignKey(
                        name: "FK_Cust_admin_AdminAdmin_id",
                        column: x => x.AdminAdmin_id,
                        principalTable: "admin",
                        principalColumn: "A_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle_Details",
                columns: table => new
                {
                    Vehicle_Number = table.Column<int>(maxLength: 20, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vehicle_Type = table.Column<string>(maxLength: 40, nullable: false),
                    Vehicle_price = table.Column<int>(maxLength: 40, nullable: false),
                    CustomerCustomer_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle_Details", x => x.Vehicle_Number);
                    table.ForeignKey(
                        name: "FK_Vehicle_Details_Cust_CustomerCustomer_id",
                        column: x => x.CustomerCustomer_id,
                        principalTable: "Cust",
                        principalColumn: "Cust_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Booking_Details",
                columns: table => new
                {
                    Booking_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    payment_details = table.Column<string>(maxLength: 50, nullable: false),
                    Booking_Date = table.Column<DateTime>(nullable: false),
                    VechicleVechicle_number = table.Column<int>(nullable: false),
                    vehicle_number = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking_Details", x => x.Booking_id);
                    table.ForeignKey(
                        name: "FK_Booking_Details_Vehicle_Details_vehicle_number",
                        column: x => x.vehicle_number,
                        principalTable: "Vehicle_Details",
                        principalColumn: "Vehicle_Number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "payment_details",
                columns: table => new
                {
                    Payment_no = table.Column<int>(maxLength: 20, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    payment_mode = table.Column<string>(maxLength: 30, nullable: false),
                    payment_details = table.Column<string>(nullable: false),
                    Booking_DetailsBooking_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payment_details", x => x.Payment_no);
                    table.ForeignKey(
                        name: "FK_payment_details_Booking_Details_Booking_DetailsBooking_id",
                        column: x => x.Booking_DetailsBooking_id,
                        principalTable: "Booking_Details",
                        principalColumn: "Booking_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Active_Booking_Details",
                columns: table => new
                {
                    Booking_id = table.Column<int>(maxLength: 20, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vehicle_status = table.Column<string>(maxLength: 30, nullable: false),
                    cancel_booking = table.Column<string>(maxLength: 30, nullable: false),
                    PaymentPayment_no = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Active_Booking_Details", x => x.Booking_id);
                    table.ForeignKey(
                        name: "FK_Active_Booking_Details_payment_details_PaymentPayment_no",
                        column: x => x.PaymentPayment_no,
                        principalTable: "payment_details",
                        principalColumn: "Payment_no",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Active_Booking_Details_PaymentPayment_no",
                table: "Active_Booking_Details",
                column: "PaymentPayment_no");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Details_vehicle_number",
                table: "Booking_Details",
                column: "vehicle_number");

            migrationBuilder.CreateIndex(
                name: "IX_Cust_AdminAdmin_id",
                table: "Cust",
                column: "AdminAdmin_id");

            migrationBuilder.CreateIndex(
                name: "IX_payment_details_Booking_DetailsBooking_id",
                table: "payment_details",
                column: "Booking_DetailsBooking_id");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_Details_CustomerCustomer_id",
                table: "Vehicle_Details",
                column: "CustomerCustomer_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Active_Booking_Details");

            migrationBuilder.DropTable(
                name: "payment_details");

            migrationBuilder.DropTable(
                name: "Booking_Details");

            migrationBuilder.DropTable(
                name: "Vehicle_Details");

            migrationBuilder.DropTable(
                name: "Cust");

            migrationBuilder.DropTable(
                name: "admin");
        }
    }
}
