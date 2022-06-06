using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoenmakerBal.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Onderhoudsmiddelen" },
                    { 2, "SchoenVeters" },
                    { 3, "Inlegzolen" },
                    { 4, "Borstels, Schoenenlepels, Spanners" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[,]
                {
                    { 1, 1, "Een grote 400 ml spuitbus voor het waterdicht maken. Geschikt voor alle soorten leder en suède.Voor schoenen,tassen en kleding.Uitsluitend op goed geventileerde plaatsen te gebruiken", "/Images/Beauty/Beauty1.png", "ANTI RAIN PROTECTOR 400 ML", 7.18m, 100 },
                    { 2, 1, "Bama herstellende olie voor gevet leer. Voedt, beschermt en verzorgt. De herstellende olie trekt diep in de schoen om het materiaal zacht en soepel te houden. GEBRUIKSAANWIJZING -Stof en vuil verwijderen van oppervlakte -Schud de spray voor gebruik -Spuit gelijkmatig vanaf een afstand van 20 cm rond het materiaal doornat te maken -10 minuten laten drogen  Geschikt voor alle kleuren gewaxed-, geolied leer/nubuck.", "/Images/Beauty/Beauty2.png", "BAMA S20 RENOVATING OIL 250 ML", 8.23m, 45 },
                    { 3, 1, "Collonil Waxleather beschermt, verzorgt en voedt gewaxte- en matte leersoorten. Met bijenwas. Geschikt voor o.a. analine, nappa en pull up leer. Ook te gebruiken bij Hightech materialen.", "/Images/Beauty/Beauty3.png", "COLLONIL WAXLEATHER 200 ML", 9.93m, 30 },
                    { 4, 1, "Ledercrème is een product om leder regelmatig te onderhouden. Trekt goed in de poriën van het leder en houd het soepel. Conserveert het leder en is te gebruiken op meubelen,schoenen, tassen, jassen, zadels, hoofdstellen, etc. Gebruiksaanwijzing: Met een doekje of sponsje goed inwrijven, enige tijd laten intrekken en zonodig uitwrijven. Bij regelmatig gebruik blijft het leder soepel en waterafstotend. Verlengt de levensduur van het leder.", "/Images/Beauty/Beauty4.png", "RAPIDE GEL TUBE 200 ML", 13.62m, 60 },
                    { 5, 1, "Rapide witte vaseline is een op zeer hoogwaardig geraffineerd product van farmaceutische kwaliteit. Het bezit een hoge mate aan zuiverheid en is ideaal om te gebruiken voor vele onderhoudsdoeleinden. GEBRUIKSAANWIJZING: Wrijf een beetje vaseline op het te behandelen product voor een perfect onderhoud.", "/Images/Beauty/Beauty5.png", "RAPIDE VASELINE 150 ML", 8.34m, 85 },
                    { 6, 3, "U-Lace veters zijn er niet alleen om je sneakers te persionaliseren, maar bieden ook een uitkomst voor iedereen die moeite heeft met het strikken van veters. Doordat U-Laces elastisch zijn kunt u van een normale veterschoen een instapper maken. Blister met 6 losse stukjes in één kleur.", "/Images/Electronic/Electronics1.png", "ULACES MIX & MATCH", 4.95m, 120 },
                    { 7, 3, "Echte leren veters 120 cm in de kleuren: Beige, middelbruin, donkerbruin, wit, zwart, cognac en geel/bruin. Bestellen per 12 of 25 paar per kleur.", "/Images/Electronic/Electronics2.png", "LEREN VETER", 4.99m, 200 },
                    { 8, 3, "Echte leren veters op rol.", "/Images/Electronic/Electronics3.png", "LEREN VETER SBT 25 METER", 38.99m, 300 },
                    { 9, 3, "Marla veters in rode blister.", "/Images/Electronic/Electronic4.png", "MARLA ELASTISCH 75 CM", 3.99m, 20 },
                    { 10, 3, "Marla veters in rode blister.", "/Images/Electronic/Electronic5.png", "MARLA BRANDWEREND 120 CM ZWART", 3.99m, 150 },
                    { 11, 3, "Marla veters in rode blister. De lengte van de veters wordt veranderd van 65 cm. in 60 cm. 60 cm veters worden automatisch geleverd als de 65 cm lengte op is.", "/Images/Electronic/technology6.png", "MARLA PLAT 60/65 CM", 4.99m, 60 },
                    { 12, 2, "Sportzool voor hardlopen. 360°-landing cup stabiliseert de hiel na de landing. Heel strike zone zorgt voor extra schokabsorbtie bij de landing. Rebound pad levert duurzame demping. Midfoot support voor extra stabiliteit op rechte wegen. Flex groovers bespaart energie, stap voor stap. Equalize pad verdeelt de druk over de voorvoet. Aerarion holes maken het transport van lucht en vocht mogelijk. Low frictation fabric helpt hitte door wrijving te verminderen.", "/Images/Furniture/Furniture1.png", "BAMA RUNNING", 18.47m, 212 },
                    { 13, 2, "Functionele textielvezel met actieve koolstof op basis van latexschuim. De actieve koolstof absorbeert het voetvocht en voorkomt inaangename geurtjes.  De geperforeerde onderlaag zorgt voor een optimale luchtcirculatie in uw schoenen.  Wordt aanbevolen voor schoenen met Tex membramen.", "/Images/Furniture/Furniture2.png", "FAMACO COMFORT & DRY", 6.99m, 112 },
                    { 14, 2, "Vergroot Extra warme inlegzool in echt lamsvacht. Zogt er voor dat uw voeten warm blijven en voor een uitstekend draagcomfort. Antislip onderlaag biedt een stevige grip en stabiliteit. Plantaardig gelooid. Natuurlijk product.", "/Images/Furniture/Furniture3.png", "FAMACO ULTRA WARM", 12.99m, 90 },
                    { 15, 2, "Anti transpiratiezool. Neutraliseert nare luchtjes door actieve koolstof.", "/Images/Furniture/Furniture4.png", "MARLA GEURSMULLER", 5.99m, 95 },
                    { 16, 2, "Hoge kwaliteit lederen inlegzool, plantaardig gelooid. Latex onderlaag op basis van actieve kool, absorbeert geuren. Comfortabel en hygienisch", "/Images/Furniture/Furniture6.png", "FAMACO UNIVERSAL ROYAL KIDS", 9.78m, 100 },
                    { 17, 2, "Voorkomt een branderig gevoel onder de bal van de voet en het naar voren glijden", "/Images/Furniture/Furniture7.png", "MARLA GEL PADS", 5.99m, 73 },
                    { 18, 4, "Metalen schoenlepel met haak. Per 10 stuks verpakt", "/Images/Shoes/Shoes1.png", "HAKLEPEL MET HAAK NIKKEL", 5.28m, 50 },
                    { 19, 4, "Kunststof schoenlepel zonder haak met en zonder opdruk. Per 50 stuks verpakt.", "/Images/Shoes/Shoes2.png", "WEGGEEFSCHOENLEPEL KUNSTSTOF", 3.40m, 60 },
                    { 20, 4, "Kunststof schoenspanner van Bama.", "/Images/Shoes/Shoes3.png", "BAMA SCHOENSPANNER PLASTIC", 9.26m, 70 },
                    { 21, 4, "Ceder houten schoenspanner.", "/Images/Shoes/Shoes4.png", "CEDER SCHOENSPANNER ELEGANCE", 27.80m, 120 },
                    { 22, 4, "Een uitpoetser van de Bama.", "/Images/Shoes/Shoes5.png", "BAMA H07 UITPOETSER", 6.07m, 100 },
                    { 23, 4, "Reinigt en herstelt suède en nubuck.", "/Images/Shoes/Shoes6.png", "MARLA SUEDE & NUBUCK SPONS", 5.13m, 150 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[,]
                {
                    { 1, "Bob" },
                    { 2, "Sarah" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
