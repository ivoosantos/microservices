using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class PostgreSQLContext : DbContext
    {
        public PostgreSQLContext() { }
        public PostgreSQLContext(DbContextOptions<PostgreSQLContext> options) : base(options) 
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Boné Americano Red",
                Price = 89.9M,
                Description = "O Boné Americano Black da Diivoo é a escolha perfeita para quem busca atitude e versatilidade no streetwear.",
                ImageURL = "https://images.tcdn.com.br/img/img_prod/1377455/bone_americano_red_9_1_0e4486f66b5f79247faa89a78bdc7067.jpg",
                CategoryName = "Boné"

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Boné Americano Black Light",
                Price = 89.9M,
                Description = "O Boné Americano Black da Diivoo é a escolha perfeita para quem busca atitude e versatilidade no streetwear.",
                ImageURL = "https://images.tcdn.com.br/img/img_prod/1377455/bone_americano_red_9_1_0e4486f66b5f79247faa89a78bdc7067.jpg",
                CategoryName = "Boné"

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Boné Americano Cinza",
                Price = 89.9M,
                Description = "O Boné Americano Black da Diivoo é a escolha perfeita para quem busca atitude e versatilidade no streetwear.",
                ImageURL = "https://images.tcdn.com.br/img/img_prod/1377455/bone_americano_red_9_1_0e4486f66b5f79247faa89a78bdc7067.jpg",
                CategoryName = "Boné"

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Boné Americano Bege",
                Price = 89.9M,
                Description = "O Boné Americano Black da Diivoo é a escolha perfeita para quem busca atitude e versatilidade no streetwear.",
                ImageURL = "https://images.tcdn.com.br/img/img_prod/1377455/bone_americano_red_9_1_0e4486f66b5f79247faa89a78bdc7067.jpg",
                CategoryName = "Boné"

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Boné Americano Laranja",
                Price = 89.9M,
                Description = "O Boné Americano Black da Diivoo é a escolha perfeita para quem busca atitude e versatilidade no streetwear.",
                ImageURL = "https://images.tcdn.com.br/img/img_prod/1377455/bone_americano_red_9_1_0e4486f66b5f79247faa89a78bdc7067.jpg",
                CategoryName = "Boné"

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Boné Americano Rosa",
                Price = 89.9M,
                Description = "O Boné Americano Black da Diivoo é a escolha perfeita para quem busca atitude e versatilidade no streetwear.",
                ImageURL = "https://images.tcdn.com.br/img/img_prod/1377455/bone_americano_red_9_1_0e4486f66b5f79247faa89a78bdc7067.jpg",
                CategoryName = "Boné"

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Boné Americano Branco",
                Price = 89.9M,
                Description = "O Boné Americano Black da Diivoo é a escolha perfeita para quem busca atitude e versatilidade no streetwear.",
                ImageURL = "https://images.tcdn.com.br/img/img_prod/1377455/bone_americano_red_9_1_0e4486f66b5f79247faa89a78bdc7067.jpg",
                CategoryName = "Boné"

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Boné Americano Azul",
                Price = 89.9M,
                Description = "O Boné Americano Black da Diivoo é a escolha perfeita para quem busca atitude e versatilidade no streetwear.",
                ImageURL = "https://images.tcdn.com.br/img/img_prod/1377455/bone_americano_red_9_1_0e4486f66b5f79247faa89a78bdc7067.jpg",
                CategoryName = "Boné"

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Boné Americano Amarelo",
                Price = 89.9M,
                Description = "O Boné Americano Black da Diivoo é a escolha perfeita para quem busca atitude e versatilidade no streetwear.",
                ImageURL = "https://images.tcdn.com.br/img/img_prod/1377455/bone_americano_red_9_1_0e4486f66b5f79247faa89a78bdc7067.jpg",
                CategoryName = "Boné"

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Boné Americano Roxo",
                Price = 89.9M,
                Description = "O Boné Americano Black da Diivoo é a escolha perfeita para quem busca atitude e versatilidade no streetwear.",
                ImageURL = "https://images.tcdn.com.br/img/img_prod/1377455/bone_americano_red_9_1_0e4486f66b5f79247faa89a78bdc7067.jpg",
                CategoryName = "Boné"

            });
        }
    }
}
