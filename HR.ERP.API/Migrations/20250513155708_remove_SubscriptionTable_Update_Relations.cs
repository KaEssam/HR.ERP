using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.ERP.API.Migrations
{
    /// <inheritdoc />
    public partial class remove_SubscriptionTable_Update_Relations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "JobPostings");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "AuditLogs");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId1",
                table: "PerformanceReviews",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId1",
                table: "Payrolls",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId1",
                table: "LeaveRequests",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId1",
                table: "JobApplications",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId1",
                table: "Benefits",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId1",
                table: "Attendances",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId1",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceReviews_EmployeeId1",
                table: "PerformanceReviews",
                column: "EmployeeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Payrolls_EmployeeId1",
                table: "Payrolls",
                column: "EmployeeId1");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_EmployeeId1",
                table: "LeaveRequests",
                column: "EmployeeId1");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplications_EmployeeId1",
                table: "JobApplications",
                column: "EmployeeId1");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplications_JobPostingId",
                table: "JobApplications",
                column: "JobPostingId");

            migrationBuilder.CreateIndex(
                name: "IX_Benefits_EmployeeId1",
                table: "Benefits",
                column: "EmployeeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_EmployeeId1",
                table: "Attendances",
                column: "EmployeeId1");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DepartmentId",
                table: "AspNetUsers",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DepartmentId1",
                table: "AspNetUsers",
                column: "DepartmentId1",
                unique: true,
                filter: "[DepartmentId1] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Departments_DepartmentId",
                table: "AspNetUsers",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Departments_DepartmentId1",
                table: "AspNetUsers",
                column: "DepartmentId1",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_AspNetUsers_EmployeeId1",
                table: "Attendances",
                column: "EmployeeId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Benefits_AspNetUsers_EmployeeId1",
                table: "Benefits",
                column: "EmployeeId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplications_AspNetUsers_EmployeeId1",
                table: "JobApplications",
                column: "EmployeeId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplications_JobPostings_JobPostingId",
                table: "JobApplications",
                column: "JobPostingId",
                principalTable: "JobPostings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveRequests_AspNetUsers_EmployeeId1",
                table: "LeaveRequests",
                column: "EmployeeId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payrolls_AspNetUsers_EmployeeId1",
                table: "Payrolls",
                column: "EmployeeId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PerformanceReviews_AspNetUsers_EmployeeId1",
                table: "PerformanceReviews",
                column: "EmployeeId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Departments_DepartmentId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Departments_DepartmentId1",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_AspNetUsers_EmployeeId1",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_Benefits_AspNetUsers_EmployeeId1",
                table: "Benefits");

            migrationBuilder.DropForeignKey(
                name: "FK_JobApplications_AspNetUsers_EmployeeId1",
                table: "JobApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_JobApplications_JobPostings_JobPostingId",
                table: "JobApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveRequests_AspNetUsers_EmployeeId1",
                table: "LeaveRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_Payrolls_AspNetUsers_EmployeeId1",
                table: "Payrolls");

            migrationBuilder.DropForeignKey(
                name: "FK_PerformanceReviews_AspNetUsers_EmployeeId1",
                table: "PerformanceReviews");

            migrationBuilder.DropIndex(
                name: "IX_PerformanceReviews_EmployeeId1",
                table: "PerformanceReviews");

            migrationBuilder.DropIndex(
                name: "IX_Payrolls_EmployeeId1",
                table: "Payrolls");

            migrationBuilder.DropIndex(
                name: "IX_LeaveRequests_EmployeeId1",
                table: "LeaveRequests");

            migrationBuilder.DropIndex(
                name: "IX_JobApplications_EmployeeId1",
                table: "JobApplications");

            migrationBuilder.DropIndex(
                name: "IX_JobApplications_JobPostingId",
                table: "JobApplications");

            migrationBuilder.DropIndex(
                name: "IX_Benefits_EmployeeId1",
                table: "Benefits");

            migrationBuilder.DropIndex(
                name: "IX_Attendances_EmployeeId1",
                table: "Attendances");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_DepartmentId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_DepartmentId1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmployeeId1",
                table: "PerformanceReviews");

            migrationBuilder.DropColumn(
                name: "EmployeeId1",
                table: "Payrolls");

            migrationBuilder.DropColumn(
                name: "EmployeeId1",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "EmployeeId1",
                table: "JobApplications");

            migrationBuilder.DropColumn(
                name: "EmployeeId1",
                table: "Benefits");

            migrationBuilder.DropColumn(
                name: "EmployeeId1",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DepartmentId1",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "JobPostings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "AuditLogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaxEmployees = table.Column<int>(type: "int", nullable: false),
                    PlanType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TenantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                });
        }
    }
}
