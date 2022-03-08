using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    public partial class InicialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consumers",
                columns: table => new
                {
                    IdConsumer = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdExternal = table.Column<string>(type: "TEXT", nullable: true),
                    NewVSLogin = table.Column<bool>(type: "INTEGER", nullable: false),
                    UtmSource = table.Column<string>(type: "TEXT", nullable: true),
                    UtmCampaign = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Surname = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Birthdate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    PostalCode = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Province = table.Column<string>(type: "TEXT", nullable: true),
                    StreetType = table.Column<string>(type: "TEXT", nullable: true),
                    StreetName = table.Column<string>(type: "TEXT", nullable: true),
                    StreetNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Block = table.Column<string>(type: "TEXT", nullable: true),
                    Floor = table.Column<string>(type: "TEXT", nullable: true),
                    Door = table.Column<string>(type: "TEXT", nullable: true),
                    AddressComplement = table.Column<string>(type: "TEXT", nullable: true),
                    RecordDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumers", x => x.IdConsumer);
                });

            migrationBuilder.CreateTable(
                name: "Generations",
                columns: table => new
                {
                    IdGeneration = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GenerationName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generations", x => x.IdGeneration);
                });

            migrationBuilder.CreateTable(
                name: "Programs",
                columns: table => new
                {
                    IdProgram = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProgramName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programs", x => x.IdProgram);
                });

            migrationBuilder.CreateTable(
                name: "Sources",
                columns: table => new
                {
                    IdSource = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SourceName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    SourceCripto = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sources", x => x.IdSource);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    IdStatus = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StatusName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.IdStatus);
                });

            migrationBuilder.CreateTable(
                name: "ProgramGenerationPeriods",
                columns: table => new
                {
                    IdProgramGenerationPeriod = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdProgram = table.Column<int>(type: "INTEGER", nullable: false),
                    IdGeneration = table.Column<int>(type: "INTEGER", nullable: false),
                    DateStart = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateEnd = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TrafficSource = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    MaximumReferencedConsumers = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramGenerationPeriods", x => x.IdProgramGenerationPeriod);
                    table.ForeignKey(
                        name: "FK_ProgramGenerationPeriods_Generations_IdGeneration",
                        column: x => x.IdGeneration,
                        principalTable: "Generations",
                        principalColumn: "IdGeneration",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgramGenerationPeriods_Programs_IdProgram",
                        column: x => x.IdProgram,
                        principalTable: "Programs",
                        principalColumn: "IdProgram",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProgramPromotions",
                columns: table => new
                {
                    IdProgramPromotion = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdProgram = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    DateStart = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DateEnd = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramPromotions", x => x.IdProgramPromotion);
                    table.ForeignKey(
                        name: "FK_ProgramPromotions_Programs_IdProgram",
                        column: x => x.IdProgram,
                        principalTable: "Programs",
                        principalColumn: "IdProgram",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProgramQuestions",
                columns: table => new
                {
                    IdProgramQuestion = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdProgram = table.Column<int>(type: "INTEGER", nullable: false),
                    Question = table.Column<string>(type: "TEXT", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramQuestions", x => x.IdProgramQuestion);
                    table.ForeignKey(
                        name: "FK_ProgramQuestions_Programs_IdProgram",
                        column: x => x.IdProgram,
                        principalTable: "Programs",
                        principalColumn: "IdProgram",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConsumerPrograms",
                columns: table => new
                {
                    IdConsumerProgram = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdConsumer = table.Column<int>(type: "INTEGER", nullable: false),
                    IdProgram = table.Column<int>(type: "INTEGER", nullable: false),
                    IdGeneration = table.Column<int>(type: "INTEGER", nullable: false),
                    IdStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    ActivationCode = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    IdConsumerProgramReference = table.Column<int>(type: "INTEGER", nullable: true),
                    IdSource = table.Column<int>(type: "INTEGER", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumerPrograms", x => x.IdConsumerProgram);
                    table.ForeignKey(
                        name: "FK_ConsumerPrograms_Consumers_IdConsumer",
                        column: x => x.IdConsumer,
                        principalTable: "Consumers",
                        principalColumn: "IdConsumer",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsumerPrograms_Generations_IdGeneration",
                        column: x => x.IdGeneration,
                        principalTable: "Generations",
                        principalColumn: "IdGeneration",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsumerPrograms_Programs_IdProgram",
                        column: x => x.IdProgram,
                        principalTable: "Programs",
                        principalColumn: "IdProgram",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsumerPrograms_Sources_IdSource",
                        column: x => x.IdSource,
                        principalTable: "Sources",
                        principalColumn: "IdSource",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsumerPrograms_Statuses_IdStatus",
                        column: x => x.IdStatus,
                        principalTable: "Statuses",
                        principalColumn: "IdStatus",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConsumerProgramAnswer",
                columns: table => new
                {
                    IdConsumerProgramAnswer = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdConsumerProgram = table.Column<int>(type: "INTEGER", nullable: false),
                    IdProgramQuestion = table.Column<int>(type: "INTEGER", nullable: false),
                    Answer = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    RecordDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumerProgramAnswer", x => x.IdConsumerProgramAnswer);
                    table.ForeignKey(
                        name: "FK_ConsumerProgramAnswer_ConsumerPrograms_IdConsumerProgram",
                        column: x => x.IdConsumerProgram,
                        principalTable: "ConsumerPrograms",
                        principalColumn: "IdConsumerProgram",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsumerProgramAnswer_ProgramQuestions_IdProgramQuestion",
                        column: x => x.IdProgramQuestion,
                        principalTable: "ProgramQuestions",
                        principalColumn: "IdProgramQuestion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConsumerProgramPromotions",
                columns: table => new
                {
                    IdConsumerProgramPromotion = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdConsumerProgram = table.Column<int>(type: "INTEGER", nullable: false),
                    IdProgramPromotion = table.Column<int>(type: "INTEGER", nullable: false),
                    Answer = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    IdStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumerProgramPromotions", x => x.IdConsumerProgramPromotion);
                    table.ForeignKey(
                        name: "FK_ConsumerProgramPromotions_ConsumerPrograms_IdConsumerProgram",
                        column: x => x.IdConsumerProgram,
                        principalTable: "ConsumerPrograms",
                        principalColumn: "IdConsumerProgram",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsumerProgramPromotions_ProgramPromotions_IdProgramPromotion",
                        column: x => x.IdProgramPromotion,
                        principalTable: "ProgramPromotions",
                        principalColumn: "IdProgramPromotion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsumerProgramPromotions_Statuses_IdStatus",
                        column: x => x.IdStatus,
                        principalTable: "Statuses",
                        principalColumn: "IdStatus",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConsumerProgramAnswer_IdConsumerProgram",
                table: "ConsumerProgramAnswer",
                column: "IdConsumerProgram");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumerProgramAnswer_IdProgramQuestion",
                table: "ConsumerProgramAnswer",
                column: "IdProgramQuestion");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumerProgramPromotions_IdConsumerProgram",
                table: "ConsumerProgramPromotions",
                column: "IdConsumerProgram");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumerProgramPromotions_IdProgramPromotion",
                table: "ConsumerProgramPromotions",
                column: "IdProgramPromotion");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumerProgramPromotions_IdStatus",
                table: "ConsumerProgramPromotions",
                column: "IdStatus");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumerPrograms_IdConsumer",
                table: "ConsumerPrograms",
                column: "IdConsumer");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumerPrograms_IdGeneration",
                table: "ConsumerPrograms",
                column: "IdGeneration");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumerPrograms_IdProgram",
                table: "ConsumerPrograms",
                column: "IdProgram");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumerPrograms_IdSource",
                table: "ConsumerPrograms",
                column: "IdSource");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumerPrograms_IdStatus",
                table: "ConsumerPrograms",
                column: "IdStatus");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramGenerationPeriods_IdGeneration",
                table: "ProgramGenerationPeriods",
                column: "IdGeneration");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramGenerationPeriods_IdProgram",
                table: "ProgramGenerationPeriods",
                column: "IdProgram");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramPromotions_IdProgram",
                table: "ProgramPromotions",
                column: "IdProgram");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramQuestions_IdProgram",
                table: "ProgramQuestions",
                column: "IdProgram");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsumerProgramAnswer");

            migrationBuilder.DropTable(
                name: "ConsumerProgramPromotions");

            migrationBuilder.DropTable(
                name: "ProgramGenerationPeriods");

            migrationBuilder.DropTable(
                name: "ProgramQuestions");

            migrationBuilder.DropTable(
                name: "ConsumerPrograms");

            migrationBuilder.DropTable(
                name: "ProgramPromotions");

            migrationBuilder.DropTable(
                name: "Consumers");

            migrationBuilder.DropTable(
                name: "Generations");

            migrationBuilder.DropTable(
                name: "Sources");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Programs");
        }
    }
}
