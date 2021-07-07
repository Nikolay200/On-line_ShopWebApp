using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Db.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserDeliveryInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatronymicName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    House = table.Column<int>(type: "int", nullable: false),
                    Flat = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Index = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDeliveryInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComparingProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComparingProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComparingProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_UserDeliveryInfo_UserId",
                        column: x => x.UserId,
                        principalTable: "UserDeliveryInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Cost", "Description", "ImagePath", "Name" },
                values: new object[,]
                {
                    { new Guid("1e0b866f-7698-43c9-a35c-d718ca19444f"), 3000m, "Все модели оснащены легкими пропускными кольцами, опоры которых имеют форму, препятствующую захлестам. Оригинальные катушкодержатели удобно лежат в руке и обеспечивают максимальную тактильную чувствительность.", "https://fmagazin.ru/_files/editor/images/pic/herakles/spinning_herakles_red_creek_ml_1_98m_5_20g_m.jpg", "Спиннинг" },
                    { new Guid("91cad72c-c9b5-4ead-bfbe-3983aad7d9dc"), 4000m, "Легкий корпус из высокопрочного пластика, плавный равномерный ход и замечательные тяговые характеристики. Моментальный антиреверс. Алюминиевая шпуля с насечкой и коническим буртиком.", "https://fmagazin.ru/_files/editor/images/pic/volzhanka/katushka_volzhanka_tajfun_5500_m.jpg", "Катушка" },
                    { new Guid("85dd3eb6-c430-4d65-b1b9-88b05c444699"), 500m, "Плетеный шнур изготовленный по технологии четырехжильного плетения – две жилы из высокомолекулярного полиэтилена, две – из полиэстера", "https://fmagazin.ru/_files/editor/images/pic/sunline/monofilnaya_leska/leska_sunline_bass_special_100m_0_190mm_jungle_green_m.jpg", "Леска" },
                    { new Guid("095b246b-0c6f-4c7c-bd85-433b320af18b"), 10000m, "Дальность работы:50 метров Глубина сканирования:50 метров Луч сканирования:40 градусов GPS модуль:Нет Вес:65 грамм", "https://rusonar.ru/upload/medialibrary/331/33179e13dd1369b9f82a1c162fd8c6b0.png", "Эхолот" },
                    { new Guid("077f2292-a056-41d1-b7f0-32e33c269ecd"), 15000m, "Регулируемые по высоте опоры позволяют удобно расположиться практически на любом берегу, а сиденье, вращающееся на 360 градусов, обеспечит комфортную рыбалку без усталости спины.", "https://cdn1.ozone.ru/s3/multimedia-4/c500/6018863824.jpg", "Рыболовное кресло" },
                    { new Guid("a535f549-d5b3-4ed1-a8f5-eee3f527d70e"), 150m, "Подойдёт для ловли как в озёрах, так и в небольших каналах и медленно текущих реках. Отлично держится в кормушке.", "https://images.spinningline.ru/00127414_LARGE-001.jpg", "Прикормка" },
                    { new Guid("357d13c5-c6d4-4ebf-9c02-92b41588ff87"), 2000m, "Сигнализатор имеет влагозащиту, что позволяет использовать его в самых суровых условиях.", "https://fmagazin.ru/_files/editor/images/pic/anaconda/komplekt_signalizatorov_s_pejdzherom_anaconda_tsr_2_way_set_2_1_red_green_m.jpg", "Комплект сигнализаторов поклёвки" },
                    { new Guid("52a4300f-03c7-44fd-9154-e4dbb779dfa0"), 100m, "Поплавки Iron Trout Trolling Float идеально подходят для ловли форели в проводку с яркими шариками на дальней дистанции", "https://fmagazin.ru/_files/editor/images/pic/colmic/poplavok_colmic_cooper_1g_m.jpg", "Поплавок" },
                    { new Guid("e161a181-cf56-4faf-9c20-bc70ec31bc70"), 800m, "Рюкзак имеет основное отделение, куда помещаются коробки с инструментами и приманками, дополнительное отделение, два боковых кармана для размещения бутылок с водой или другого груза.", "https://fmagazin.ru/_files/editor/images/pic/rap/ryukzak_rapala_jungle_rjubp_m.jpg", "Рюкзак" },
                    { new Guid("36c71706-0ad1-4042-ad47-7e05b3220bee"), 2500m, "Включает в себя нож, пассатижи, отвертки, штопор и.т.д. Все, кроме декоративных пластмассовых накладок, выполнено из нержавеющей стали.", "https://fmagazin.ru/_files/editor/images/pic/aqua/nozh_skladnoj_aqua_ak_p802_m.jpg", "Нож складной" },
                    { new Guid("1118276f-27ab-43b3-b8ec-dc373bb0b639"), 600m, "В поворотном отражателе этого налобного фонаря собраны 6 LED SMD-светодиодов. Они создают равномерный яркий свет для освещения объектов на переднем и среднем планах в темноте.", "https://fmagazin.ru/_files/editor/images/pic/sledopyt/fonar_nalobnyj_sibirskij_sledopyt_lyuminofor_m.jpg", "Фонарь налобный" },
                    { new Guid("ee40557c-c632-407d-b69d-21d846dc33d2"), 300m, "Матовая чёрная поверхность не бликует на солнце, а контрастная шкала облегчает замер при слабом освещении. Корпус и линза весов выполнены их прочных композитных материалов, а подвес и крюк для взвешивания – из нержавеющей стали.", "https://fmagazin.ru/_files/editor/images/pic/prologic/vesy_mekhanicheskie_prologic_specimen_dial_scale_60lbs_27kg_m.jpg", "Весы" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_OrderId",
                table: "CartItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ComparingProducts_ProductId",
                table: "ComparingProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteProducts_ProductId",
                table: "FavoriteProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "ComparingProducts");

            migrationBuilder.DropTable(
                name: "FavoriteProducts");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "UserDeliveryInfo");
        }
    }
}
