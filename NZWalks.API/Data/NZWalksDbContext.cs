using Microsoft.EntityFrameworkCore;
using NZWalks.API.Model.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walks> Walks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // seed data for difficulties
            // easy, medium, hard

            var difficulties = new List<Difficulty>()
            {
                new Difficulty() 
                {
                    Id = Guid.Parse("c9d528e1-d525-4a93-8134-6c05a34efe98"),
                    Name = "Easy"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("6e61a464-67e8-4036-97f6-3c28a1bee3cc"),
                    Name = "Medium"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("2d104452-06b7-4426-bb02-15449f119f57"),
                    Name = "Hard"
                }
            };

            // Seed difficulties to the database
            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            // seed data for regions
            var regions = new List<Region>()
            {
                new Region
                {
                    Id = Guid.Parse("c7997530-d2fc-4efb-9780-0f3d40795eac"),
                    Name = "Auckland",
                    Code = "AKL",
                    RegionImageUrl = "https://www.google.com/imgres?q=auckland&imgurl=https%3A%2F%2Fi.natgeofe.com%2Fn%2F3c248eb9-9607-430b-8008-0bde5e01a3a8%2Fsleep_GettyImages-520149304_ukHR_4x3.jpg&imgrefurl=https%3A%2F%2Fwww.nationalgeographic.com%2Ftravel%2Farticle%2Ftop-activities-things-to-do-47&docid=jjpBPT_pZJSVeM&tbnid=0CRKmlYKlUdY8M&vet=12ahUKEwih_K6doK-KAxVkXEEAHXHdHwMQM3oECCMQAA..i&w=3072&h=2304&hcb=2&ved=2ahUKEwih_K6doK-KAxVkXEEAHXHdHwMQM3oECCMQAA"
                },
                new Region
                {
                    Id = Guid.Parse("71ec3d3c-0a0e-4049-9592-7cf52733a748"),
                    Name = "Northland",
                    Code = "NTL",
                    RegionImageUrl = "https://www.google.com/imgres?q=northland&imgurl=https%3A%2F%2Fwww.newzealand.com%2Fassets%2FTourism-NZ%2FNorthland-Bay-of-Islands%2Fimg-1536219888-397-1389-9BDBE019-C76A-7080-9BF53BE475ABD5BD__aWxvdmVrZWxseQo_CropResizeWzE5MDAsMTAwMCw3NSwianBnIl0.jpg&imgrefurl=https%3A%2F%2Fwww.newzealand.com%2Fus%2Ffeature%2Fdiscover-experiences-in-northland%2F&docid=TJM4b5cNwUIjsM&tbnid=cgxpwkzyhHjSRM&vet=12ahUKEwiKjeuVpK-KAxXUVEEAHcguNCAQM3oECBkQAA..i&w=1900&h=1000&hcb=2&ved=2ahUKEwiKjeuVpK-KAxXUVEEAHcguNCAQM3oECBkQAA"
                },
                new Region
                {
                    Id = Guid.Parse("07ee6315-d19b-4b0d-b3ac-322442a06ac2"),
                    Name = "Bay of Plenty",
                    Code = "BOP",
                    RegionImageUrl = "https://www.google.com/imgres?q=bay%20of%20plenty&imgurl=https%3A%2F%2Fwww.newzealand.com%2Fassets%2FTourism-NZ%2FBay-of-Plenty%2Fimg-1536927287-1206-10060-p-7CD33CA5-0906-4B8F-DC8DDBFCCE92BB46-2544003__aWxvdmVrZWxseQo_FocalPointCropWzQzMCw2MzAsNTAsNTAsNzUsInBuZyIsNjUsMi41XQ.png&imgrefurl=https%3A%2F%2Fwww.newzealand.com%2Fus%2Fbay-of-plenty%2F&docid=Q8QPyO9oKGuKDM&tbnid=QwhRFcwJSXaWYM&vet=12ahUKEwieo5agpK-KAxWoRkEAHQUXMcEQM3oECDAQAA..i&w=630&h=430&hcb=2&ved=2ahUKEwieo5agpK-KAxWoRkEAHQUXMcEQM3oECDAQAA"
                },
                new Region
                {
                    Id = Guid.Parse("0ba9d30b-1bbc-4476-8d26-0512472d8f57"),
                    Name = "Wellington",
                    Code = "WLG",
                    RegionImageUrl = "https://www.google.com/imgres?q=wellington&imgurl=https%3A%2F%2Fwellingtonnz.bynder.com%2Ftransform%2Fsocial%2Ff2224523-265d-4578-a72a-b9b068d987ce%2F&imgrefurl=https%3A%2F%2Fwww.wellingtonnz.com%2Fmap&docid=XlylarIFXFIUYM&tbnid=2IvptErEhqb8XM&vet=12ahUKEwj19fqmpK-KAxUqaUEAHSG1FsUQM3oECBUQAA..i&w=1200&h=600&hcb=2&ved=2ahUKEwj19fqmpK-KAxUqaUEAHSG1FsUQM3oECBUQAA"
                },
                new Region
                {
                    Id = Guid.Parse("908bcc02-c29f-401a-a1c5-b3d6b1ae9745"),
                    Name = "Nelson",
                    Code = "NSN",
                    RegionImageUrl = "https://www.google.com/imgres?q=nelson&imgurl=https%3A%2F%2Fstatic.wikia.nocookie.net%2Fsimpsons%2Fimages%2Fe%2Fe0%2FNelson_Muntz-795440.png%2Frevision%2Flatest%2Fscale-to-width%2F360%3Fcb%3D20201222215339&imgrefurl=https%3A%2F%2Fsimpsons.fandom.com%2Fwiki%2FNelson_Muntz&docid=zg-0iOoTK1m6zM&tbnid=9TnjmeThh5l02M&vet=12ahUKEwjDhZytpK-KAxV_Z0EAHV_EE0sQM3oECGMQAA..i&w=360&h=590&hcb=2&ved=2ahUKEwjDhZytpK-KAxV_Z0EAHV_EE0sQM3oECGMQAA"
                },
                new Region
                {
                    Id = Guid.Parse("6de9a473-8177-4293-a8e8-50f36352a031"),
                    Name = "Southland",
                    Code = "STL",
                    RegionImageUrl = "https://www.google.com/imgres?q=southland%20nz&imgurl=https%3A%2F%2Fcdn.outsideonline.com%2Fwp-content%2Fuploads%2F2020%2F02%2F04%2Fmountain-lake-new-zealand-si_h.jpg&imgrefurl=https%3A%2F%2Fwww.outsideonline.com%2Fadventure-travel%2Fdestinations%2Faustralia-pacific%2Fnew-zealand-south-island-travel-guide%2F&docid=ApLxgSMXsmdjYM&tbnid=8snm5dnKzG4AiM&vet=12ahUKEwiny_6-pK-KAxVDXUEAHfwvKEQQM3oECBYQAA..i&w=2400&h=1350&hcb=2&ved=2ahUKEwiny_6-pK-KAxVDXUEAHfwvKEQQM3oECBYQAA"
                }
            };

            modelBuilder.Entity<Region>().HasData(regions);
        }

    }
}
