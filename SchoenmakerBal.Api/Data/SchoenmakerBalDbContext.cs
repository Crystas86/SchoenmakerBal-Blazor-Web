using Microsoft.EntityFrameworkCore;
using SchoenmakerBal.Api.Entities;

namespace SchoenmakerBal.Api.Data
{
    public class SchoenmakerBalDbContext : DbContext
    {
        public SchoenmakerBalDbContext(DbContextOptions<SchoenmakerBalDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			//Products
			//Category - Onderhoudsmiddelen
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 1,
				Name = "Anti rain protector 400 ML",
				Description = "Een grote 400 ml spuitbus voor het waterdicht maken. Geschikt voor alle soorten leder en suède.Voor schoenen,tassen en kleding.Uitsluitend op goed geventileerde plaatsen te gebruiken",
				ImageURL = "/Images/Onderhoudsmiddel/AntiRain.jpg",
				Price = 7.18M,
				Qty = 100,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 2,
				Name = "Bama S20 renovating oil 250 ML",
				Description = "Bama herstellende olie voor gevet leer. Voedt, beschermt en verzorgt. De herstellende olie trekt diep in de schoen om het materiaal zacht en soepel te houden. GEBRUIKSAANWIJZING -Stof en vuil verwijderen van oppervlakte -Schud de spray voor gebruik -Spuit gelijkmatig vanaf een afstand van 20 cm rond het materiaal doornat te maken -10 minuten laten drogen  Geschikt voor alle kleuren gewaxed-, geolied leer/nubuck.",
				ImageURL = "/Images/Onderhoudsmiddel/BamaOil.png",
				Price = 8.23M,
				Qty = 45,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 3,
				Name = "Collonil waxleather 200 ML",
				Description = "Collonil Waxleather beschermt, verzorgt en voedt gewaxte- en matte leersoorten. Met bijenwas. Geschikt voor o.a. analine, nappa en pull up leer. Ook te gebruiken bij Hightech materialen.",
				ImageURL = "/Images/Onderhoudsmiddel/CollonilWax.png",
				Price = 9.93M,
				Qty = 30,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 4,
				Name = "Rapide gel tube 200 ML",
				Description = "Ledercrème is een product om leder regelmatig te onderhouden. Trekt goed in de poriën van het leder en houd het soepel. Conserveert het leder en is te gebruiken op meubelen,schoenen, tassen, jassen, zadels, hoofdstellen, etc. Gebruiksaanwijzing: Met een doekje of sponsje goed inwrijven, enige tijd laten intrekken en zonodig uitwrijven. Bij regelmatig gebruik blijft het leder soepel en waterafstotend. Verlengt de levensduur van het leder.",
				ImageURL = "/Images/Onderhoudsmiddel/RapideLeathergel.png",
				Price = 13.62M,
				Qty = 60,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 5,
				Name = "Rapide vaseline 150 ML",
				Description = "Rapide witte vaseline is een op zeer hoogwaardig geraffineerd product van farmaceutische kwaliteit. Het bezit een hoge mate aan zuiverheid en is ideaal om te gebruiken voor vele onderhoudsdoeleinden. GEBRUIKSAANWIJZING: Wrijf een beetje vaseline op het te behandelen product voor een perfect onderhoud.",
				ImageURL = "/Images/Onderhoudsmiddel/RapideVaseline.png",
				Price = 8.34M,
				Qty = 85,
				CategoryId = 1

			});
			//Category - Schoenveters
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 6,
				Name = "Ulaces mix & match",
				Description = "U-Lace veters zijn er niet alleen om je sneakers te persionaliseren, maar bieden ook een uitkomst voor iedereen die moeite heeft met het strikken van veters. Doordat U-Laces elastisch zijn kunt u van een normale veterschoen een instapper maken. Blister met 6 losse stukjes in één kleur.",
				ImageURL = "/Images/Schoenveters/Ulace.png",
				Price = 4.95M,
				Qty = 120,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 7,
				Name = "Leren veter",
				Description = "Echte leren veters 120 cm in de kleuren: Beige, middelbruin, donkerbruin, wit, zwart, cognac en geel/bruin. Bestellen per 12 of 25 paar per kleur.",
				ImageURL = "/Images/Schoenveters/LerenVeters.png",
				Price = 4.99M,
				Qty = 200,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 8,
				Name = "Leren veter sbt 25 meter",
				Description = "Echte leren veters op rol.",
				ImageURL = "/Images/Schoenveters/LerenVeterRol.png",
				Price = 38.99M,
				Qty = 300,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 9,
				Name = "Marla elastisch 75 CM",
				Description = "Marla veters in rode blister.",
				ImageURL = "/Images/Schoenveters/VetersElastisch.png",
				Price = 3.99M,
				Qty = 20,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 10,
				Name = "Marla brandwerend 120 CM zwart",
				Description = "Marla veters in rode blister.",
				ImageURL = "/Images/Schoenveters/VetersZwart.png",
				Price = 3.99M,
				Qty = 150,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 11,
				Name = "Marla plat 60/65 CM",
				Description = "Marla veters in rode blister. De lengte van de veters wordt veranderd van 65 cm. in 60 cm. 60 cm veters worden automatisch geleverd als de 65 cm lengte op is.",
				ImageURL = "/Images/Schoenveters/VetersPlat.png",
				Price = 4.99M,
				Qty = 60,
				CategoryId = 3
			});
			//Category - Inlegzolen
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 12,
				Name = "Bama running",
				Description = "Sportzool voor hardlopen. 360°-landing cup stabiliseert de hiel na de landing. Heel strike zone zorgt voor extra schokabsorbtie bij de landing. Rebound pad levert duurzame demping. Midfoot support voor extra stabiliteit op rechte wegen. Flex groovers bespaart energie, stap voor stap. Equalize pad verdeelt de druk over de voorvoet. Aerarion holes maken het transport van lucht en vocht mogelijk. Low frictation fabric helpt hitte door wrijving te verminderen.",
				ImageURL = "/Images/Inlegzolen/BamaInlegzolen.png",
				Price = 18.47M,
				Qty = 212,
				CategoryId = 2
			});

			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 13,
				Name = "Famaco comfort & dry",
				Description = "Functionele textielvezel met actieve koolstof op basis van latexschuim. De actieve koolstof absorbeert het voetvocht en voorkomt inaangename geurtjes.  De geperforeerde onderlaag zorgt voor een optimale luchtcirculatie in uw schoenen.  Wordt aanbevolen voor schoenen met Tex membramen.",
				ImageURL = "/Images/Inlegzolen/Famaco.png",
				Price = 6.99M,
				Qty = 112,
				CategoryId = 2
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 14,
				Name = "Famaco ultra warm",
				Description = "Vergroot Extra warme inlegzool in echt lamsvacht. Zogt er voor dat uw voeten warm blijven en voor een uitstekend draagcomfort. Antislip onderlaag biedt een stevige grip en stabiliteit. Plantaardig gelooid. Natuurlijk product.",
				ImageURL = "/Images/Inlegzolen/FamacoUltraWarm.png",
				Price = 12.99M,
				Qty = 90,
				CategoryId = 2
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 15,
				Name = "Marla geursmuller",
				Description = "Anti transpiratiezool. Neutraliseert nare luchtjes door actieve koolstof.",
				ImageURL = "/Images/Inlegzolen/MarlaAntiGeur.png",
				Price = 5.99M,
				Qty = 95,
				CategoryId = 2
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 16,
				Name = "Famaco universal royal kids",
				Description = "Hoge kwaliteit lederen inlegzool, plantaardig gelooid. Latex onderlaag op basis van actieve kool, absorbeert geuren. Comfortabel en hygienisch",
				ImageURL = "/Images/Inlegzolen/FamacoKids.png",
				Price = 9.78M,
				Qty = 100,
				CategoryId = 2
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 17,
				Name = "Marla gel pads",
				Description = "Voorkomt een branderig gevoel onder de bal van de voet en het naar voren glijden",
				ImageURL = "/Images/Inlegzolen/MarlaGelPads.png",
				Price = 5.99M,
				Qty = 73,
				CategoryId = 2
			});
			//Category - Borstels, Schoenlepels, Spanners
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 18,
				Name = "Haklepel met haak nikkel",
				Description = "Metalen schoenlepel met haak. Per 10 stuks verpakt",
				ImageURL = "/Images/Borstels_Schoenlepels_Spanners/Haklepel.png",
				Price = 5.28M,
				Qty = 50,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 19,
				Name = "Weggeefschoenlepel kunststof",
				Description = "Kunststof schoenlepel zonder haak met en zonder opdruk. Per 50 stuks verpakt.",
				ImageURL = "/Images/Borstels_Schoenlepels_Spanners/Schoenlepel.png",
				Price = 3.40M,
				Qty = 60,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 20,
				Name = "Bama schoenspanner plastic",
				Description = "Kunststof schoenspanner van Bama.",
				ImageURL = "/Images/Borstels_Schoenlepels_Spanners/KunstoffSpanner.png",
				Price = 9.26M,
				Qty = 70,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 21,
				Name = "Ceder schoenspanner elegance",
				Description = "Ceder houten schoenspanner.",
				ImageURL = "/Images/Borstels_Schoenlepels_Spanners/CederSpanner.png",
				Price = 27.80M,
				Qty = 120,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 22,
				Name = "Bama H07 uitpoetser",
				Description = "Een uitpoetser van de Bama.",
				ImageURL = "/Images/Borstels_Schoenlepels_Spanners/BamaUitpoetser.png",
				Price = 6.07M,
				Qty = 100,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 23,
				Name = "Marla suede & Nubuck spons",
				Description = "Reinigt en herstelt suède en nubuck.",
				ImageURL = "/Images/Borstels_Schoenlepels_Spanners/NubuckSponge.png",
				Price = 5.13M,
				Qty = 150,
				CategoryId = 4
			});

			//Add users
			modelBuilder.Entity<User>().HasData(new User
			{
				Id = 1,
				UserName = "Bob"

			});
			modelBuilder.Entity<User>().HasData(new User
			{
				Id = 2,
				UserName = "Sarah"

			});

			//Create Shopping Cart for Users
			modelBuilder.Entity<Cart>().HasData(new Cart
			{
				Id = 1,
				UserId = 1

			});
			modelBuilder.Entity<Cart>().HasData(new Cart
			{
				Id = 2,
				UserId = 2

			});
			//Add Product Categories
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 1,
				Name = "Onderhoudsmiddelen",
				IconCSS = "fas fa-spray-can"
			});
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 2,
				Name = "Schoenveters",
				IconCSS = "fas fa-shekel-sign"
			});
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 3,
				Name = "Inlegzolen",
				IconCSS = "fas fa-shoe-prints"
			});
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 4,
				Name = "Borstels, Schoenenlepels, Spanners",
				IconCSS = "fas fa-brush"
			});

		}

		public DbSet<Cart> Carts { get; set; }
		public DbSet<CartItem> CartItems { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ProductCategory> ProductCategories { get; set; }
		public DbSet<User> Users { get; set; }
	}
}
