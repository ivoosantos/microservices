using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GeekShopping.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductDataTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 2L, "Boné", "O Boné Americano Black da Diivoo é a escolha perfeita para quem busca atitude e versatilidade no streetwear.", "https://images.tcdn.com.br/img/img_prod/1377455/bone_americano_red_9_1_0e4486f66b5f79247faa89a78bdc7067.jpg", "Boné Americano Red", 89.9m },
                    { 3L, "Boné", "O Boné Americano Black da Diivoo é a escolha perfeita para quem busca atitude e versatilidade no streetwear.", "https://images.tcdn.com.br/img/img_prod/1377455/bone_americano_red_9_1_0e4486f66b5f79247faa89a78bdc7067.jpg", "Boné Americano Black Light", 89.9m },
                    { 4L, "Boné", "O Boné Americano Black da Diivoo é a escolha perfeita para quem busca atitude e versatilidade no streetwear.", "https://images.tcdn.com.br/img/img_prod/1377455/bone_americano_red_9_1_0e4486f66b5f79247faa89a78bdc7067.jpg", "Boné Americano Cinza", 89.9m },
                    { 5L, "Boné", "O Boné Americano Black da Diivoo é a escolha perfeita para quem busca atitude e versatilidade no streetwear.", "https://images.tcdn.com.br/img/img_prod/1377455/bone_americano_red_9_1_0e4486f66b5f79247faa89a78bdc7067.jpg", "Boné Americano Bege", 89.9m },
                    { 6L, "Boné", "O Boné Americano Black da Diivoo é a escolha perfeita para quem busca atitude e versatilidade no streetwear.", "https://images.tcdn.com.br/img/img_prod/1377455/bone_americano_red_9_1_0e4486f66b5f79247faa89a78bdc7067.jpg", "Boné Americano Laranja", 89.9m },
                    { 7L, "Boné", "O Boné Americano Black da Diivoo é a escolha perfeita para quem busca atitude e versatilidade no streetwear.", "https://images.tcdn.com.br/img/img_prod/1377455/bone_americano_red_9_1_0e4486f66b5f79247faa89a78bdc7067.jpg", "Boné Americano Rosa", 89.9m },
                    { 8L, "Boné", "O Boné Americano Black da Diivoo é a escolha perfeita para quem busca atitude e versatilidade no streetwear.", "https://images.tcdn.com.br/img/img_prod/1377455/bone_americano_red_9_1_0e4486f66b5f79247faa89a78bdc7067.jpg", "Boné Americano Branco", 89.9m },
                    { 9L, "Boné", "O Boné Americano Black da Diivoo é a escolha perfeita para quem busca atitude e versatilidade no streetwear.", "https://images.tcdn.com.br/img/img_prod/1377455/bone_americano_red_9_1_0e4486f66b5f79247faa89a78bdc7067.jpg", "Boné Americano Azul", 89.9m },
                    { 10L, "Boné", "O Boné Americano Black da Diivoo é a escolha perfeita para quem busca atitude e versatilidade no streetwear.", "https://images.tcdn.com.br/img/img_prod/1377455/bone_americano_red_9_1_0e4486f66b5f79247faa89a78bdc7067.jpg", "Boné Americano Amarelo", 89.9m },
                    { 11L, "Boné", "O Boné Americano Black da Diivoo é a escolha perfeita para quem busca atitude e versatilidade no streetwear.", "https://images.tcdn.com.br/img/img_prod/1377455/bone_americano_red_9_1_0e4486f66b5f79247faa89a78bdc7067.jpg", "Boné Americano Roxo", 89.9m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 11L);
        }
    }
}
