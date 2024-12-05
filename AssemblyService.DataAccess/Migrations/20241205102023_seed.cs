using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AssemblyService.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Campuses",
                columns: new[] { "Id", "Coordinates", "Number" },
                values: new object[,]
                {
                    { new Guid("0d31ee0e-fcc2-4d1b-82ea-45dd764eb470"), "-15.6727, -176.0164", 96 },
                    { new Guid("330f22ee-7930-4ca6-93bf-1ce1b2eb4646"), "10.8514, -122.8435", 34 },
                    { new Guid("4aca5b3a-3d40-4be5-a250-dc1555b84b24"), "-79.6092, -139.1848", 46 },
                    { new Guid("d16f1428-6096-444a-be1f-ea126f3771aa"), "36.4278, -86.641", 17 },
                    { new Guid("e5a69e26-28b8-448f-94e5-d9f05ce55321"), "-5.2541, -67.4824", 56 }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "LastName", "Position" },
                values: new object[,]
                {
                    { new Guid("46753fc7-28e9-46ad-ae01-cfc71139f5a1"), "Colten", "Howe", "Human Configuration Planner" },
                    { new Guid("6d3b3bba-a0ba-42f9-a956-cb8ff239a8ab"), "Alayna", "Wisozk", "Forward Usability Facilitator" },
                    { new Guid("e02f1e86-d1ac-4fa3-96b1-d32c73cf6d35"), "Martina", "Kovacek", "Regional Quality Planner" },
                    { new Guid("e3188a17-ffc1-43ea-a8da-b8d948139511"), "Johnnie", "Considine", "Chief Data Architect" },
                    { new Guid("f0ab2c9a-a678-4d66-8bf1-e6451ee0c1d4"), "Milan", "Gulgowski", "Principal Accountability Liaison" }
                });

            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "Id", "CampusId", "Capacity", "Number" },
                values: new object[,]
                {
                    { new Guid("021733d7-8227-4810-b570-4e1fe4a6d2fc"), new Guid("4aca5b3a-3d40-4be5-a250-dc1555b84b24"), 85, 630 },
                    { new Guid("0402738e-0d80-4ef3-a760-95abf0e96406"), new Guid("e5a69e26-28b8-448f-94e5-d9f05ce55321"), 56, 222 },
                    { new Guid("164771ec-160a-44f4-9dc6-2312bc703a1d"), new Guid("4aca5b3a-3d40-4be5-a250-dc1555b84b24"), 41, 782 },
                    { new Guid("19703ab3-c58f-4523-891a-1d57c3ef6c00"), new Guid("330f22ee-7930-4ca6-93bf-1ce1b2eb4646"), 47, 288 },
                    { new Guid("3480a588-de33-4896-b0c8-f21f4b48b592"), new Guid("d16f1428-6096-444a-be1f-ea126f3771aa"), 57, 615 },
                    { new Guid("373dd35f-00bb-4f11-896a-8c4896b0f594"), new Guid("0d31ee0e-fcc2-4d1b-82ea-45dd764eb470"), 45, 423 },
                    { new Guid("489ab4c5-4f1b-49f0-bdbd-37d1526085ec"), new Guid("4aca5b3a-3d40-4be5-a250-dc1555b84b24"), 34, 944 },
                    { new Guid("511f6515-544b-44fe-b155-fba2446844a7"), new Guid("330f22ee-7930-4ca6-93bf-1ce1b2eb4646"), 22, 122 },
                    { new Guid("546f870a-fc98-4f96-a168-6736b8dbf7dc"), new Guid("d16f1428-6096-444a-be1f-ea126f3771aa"), 52, 302 },
                    { new Guid("566a96a1-f884-4390-854c-cc8811bd6f76"), new Guid("d16f1428-6096-444a-be1f-ea126f3771aa"), 57, 196 },
                    { new Guid("7284d403-7668-4ce4-983d-b1a3a179acad"), new Guid("e5a69e26-28b8-448f-94e5-d9f05ce55321"), 33, 195 },
                    { new Guid("75faf98b-cd5d-436f-9a8c-9adafa6c6a57"), new Guid("d16f1428-6096-444a-be1f-ea126f3771aa"), 99, 422 },
                    { new Guid("79738ac2-6b57-4c8f-af2e-e492e892a92d"), new Guid("4aca5b3a-3d40-4be5-a250-dc1555b84b24"), 94, 618 },
                    { new Guid("7e8fa5cd-27d4-493d-94bd-365687b3b1ec"), new Guid("0d31ee0e-fcc2-4d1b-82ea-45dd764eb470"), 69, 848 },
                    { new Guid("7f807932-c58e-46b1-9a63-d4d2d32db292"), new Guid("e5a69e26-28b8-448f-94e5-d9f05ce55321"), 43, 490 },
                    { new Guid("7fbd4e1b-58a1-43e3-bda8-2a4c05d40293"), new Guid("330f22ee-7930-4ca6-93bf-1ce1b2eb4646"), 79, 800 },
                    { new Guid("86c6a09a-8b50-4745-aae4-200efffff6a0"), new Guid("e5a69e26-28b8-448f-94e5-d9f05ce55321"), 38, 568 },
                    { new Guid("9a58bd59-e409-45cd-8651-dacff7cd4e51"), new Guid("0d31ee0e-fcc2-4d1b-82ea-45dd764eb470"), 78, 871 },
                    { new Guid("aa3f0ccd-ccaa-4b1e-b53e-6e9bd12cc4fc"), new Guid("330f22ee-7930-4ca6-93bf-1ce1b2eb4646"), 74, 607 },
                    { new Guid("c0fdd0b7-d67a-4c08-a123-77dcd6335e40"), new Guid("330f22ee-7930-4ca6-93bf-1ce1b2eb4646"), 89, 966 },
                    { new Guid("c33e10b7-7f02-455d-9e56-b1a5254aad47"), new Guid("0d31ee0e-fcc2-4d1b-82ea-45dd764eb470"), 21, 627 },
                    { new Guid("c691da4c-dad9-4631-b012-38a30f0bc529"), new Guid("0d31ee0e-fcc2-4d1b-82ea-45dd764eb470"), 72, 649 },
                    { new Guid("cf5baef1-580a-42fb-a816-3152a858faec"), new Guid("d16f1428-6096-444a-be1f-ea126f3771aa"), 30, 424 },
                    { new Guid("f6a82af9-3553-4816-860a-06f324c19445"), new Guid("e5a69e26-28b8-448f-94e5-d9f05ce55321"), 24, 669 },
                    { new Guid("fa05bffd-d1b0-47d8-b675-1eb0ec461211"), new Guid("4aca5b3a-3d40-4be5-a250-dc1555b84b24"), 76, 730 }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CampusId", "Name" },
                values: new object[,]
                {
                    { new Guid("04531b99-92e1-48df-830b-52f78649ec48"), new Guid("d16f1428-6096-444a-be1f-ea126f3771aa"), "Health, Home & Automotive" },
                    { new Guid("0682e8ea-3aaa-4a86-affa-73a9264f29da"), new Guid("4aca5b3a-3d40-4be5-a250-dc1555b84b24"), "Movies & Toys" },
                    { new Guid("0e3bbdda-3bfd-4bee-914c-67780ab293dc"), new Guid("330f22ee-7930-4ca6-93bf-1ce1b2eb4646"), "Shoes" },
                    { new Guid("165a4718-b25b-4164-9f32-4be49546ece7"), new Guid("4aca5b3a-3d40-4be5-a250-dc1555b84b24"), "Music, Health & Beauty" },
                    { new Guid("2994f8b2-e6a8-4b74-b693-bd7bf67b98ca"), new Guid("330f22ee-7930-4ca6-93bf-1ce1b2eb4646"), "Tools, Jewelery & Tools" },
                    { new Guid("4533a232-db9e-4478-867a-aa140feca071"), new Guid("e5a69e26-28b8-448f-94e5-d9f05ce55321"), "Home & Jewelery" },
                    { new Guid("5879cb1f-73ab-4eff-9755-fa771c8139be"), new Guid("e5a69e26-28b8-448f-94e5-d9f05ce55321"), "Computers, Outdoors & Tools" },
                    { new Guid("5adffbc4-7965-43a6-8d8a-6be98815c069"), new Guid("0d31ee0e-fcc2-4d1b-82ea-45dd764eb470"), "Tools" },
                    { new Guid("6e807d0e-a0e1-43ab-bacc-dafb40872e73"), new Guid("d16f1428-6096-444a-be1f-ea126f3771aa"), "Computers, Sports & Garden" },
                    { new Guid("718247bd-e7fa-4306-8e8d-f39b10ed28b5"), new Guid("e5a69e26-28b8-448f-94e5-d9f05ce55321"), "Baby & Games" },
                    { new Guid("7f8c0ca4-8e3a-4349-b6c6-0768ea551d5c"), new Guid("0d31ee0e-fcc2-4d1b-82ea-45dd764eb470"), "Home & Jewelery" },
                    { new Guid("87c95550-fa33-48eb-a266-69e0483a7e86"), new Guid("330f22ee-7930-4ca6-93bf-1ce1b2eb4646"), "Books & Toys" },
                    { new Guid("900e7bd0-66ef-469d-b0c7-f921c914abdd"), new Guid("d16f1428-6096-444a-be1f-ea126f3771aa"), "Jewelery" },
                    { new Guid("904cb720-26cc-4756-bb0d-1b8ff84c2ec5"), new Guid("4aca5b3a-3d40-4be5-a250-dc1555b84b24"), "Music, Clothing & Games" },
                    { new Guid("966bea45-ba2f-4d7c-a234-f190247e2af8"), new Guid("0d31ee0e-fcc2-4d1b-82ea-45dd764eb470"), "Baby, Industrial & Movies" },
                    { new Guid("991c9202-8a16-48af-98df-5ec3d4b196ec"), new Guid("4aca5b3a-3d40-4be5-a250-dc1555b84b24"), "Outdoors & Jewelery" },
                    { new Guid("9a221f92-2cfa-4135-a035-e57882104f9b"), new Guid("0d31ee0e-fcc2-4d1b-82ea-45dd764eb470"), "Garden, Clothing & Music" },
                    { new Guid("a29f05b8-f938-4a4d-9bdf-c15e2b002ab8"), new Guid("d16f1428-6096-444a-be1f-ea126f3771aa"), "Health & Health" },
                    { new Guid("a3157b15-5b38-4986-b713-84ba884aecc1"), new Guid("330f22ee-7930-4ca6-93bf-1ce1b2eb4646"), "Garden & Automotive" },
                    { new Guid("af045304-bea0-4bc0-b70c-a1996d323df0"), new Guid("d16f1428-6096-444a-be1f-ea126f3771aa"), "Health, Shoes & Jewelery" },
                    { new Guid("b2fe1634-ce60-4505-9931-bc80131f0529"), new Guid("330f22ee-7930-4ca6-93bf-1ce1b2eb4646"), "Books & Garden" },
                    { new Guid("b30b5267-2373-47ca-a164-23a7286ed81d"), new Guid("e5a69e26-28b8-448f-94e5-d9f05ce55321"), "Games & Music" },
                    { new Guid("ed3dea5b-a2e1-4cb4-9b94-df6492b71dc8"), new Guid("e5a69e26-28b8-448f-94e5-d9f05ce55321"), "Music & Kids" },
                    { new Guid("f18b7fb7-bdb7-4796-809a-c202482f6482"), new Guid("4aca5b3a-3d40-4be5-a250-dc1555b84b24"), "Beauty" },
                    { new Guid("fda3238c-f994-40a3-84d9-600f8e4bb95f"), new Guid("0d31ee0e-fcc2-4d1b-82ea-45dd764eb470"), "Automotive, Books & Grocery" }
                });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "DepartmentId", "Name", "ShortName" },
                values: new object[,]
                {
                    { new Guid("02a33b58-f6c2-4416-b64c-2dd3774d07d5"), new Guid("2994f8b2-e6a8-4b74-b693-bd7bf67b98ca"), "Sleek Granite Sausages", "esse" },
                    { new Guid("09f2b2b6-5303-451a-9ed0-9035c6d7a1ec"), new Guid("718247bd-e7fa-4306-8e8d-f39b10ed28b5"), "Refined Wooden Mouse", "officia" },
                    { new Guid("0a6a020b-bcee-46df-b8c9-d5717bfe20e5"), new Guid("991c9202-8a16-48af-98df-5ec3d4b196ec"), "Sleek Plastic Shoes", "nulla" },
                    { new Guid("0b64af6a-ed44-469e-9f6f-e56e44dd11aa"), new Guid("718247bd-e7fa-4306-8e8d-f39b10ed28b5"), "Fantastic Frozen Salad", "id" },
                    { new Guid("0ef2b79a-d7b0-47dd-8619-014ae8dd2c7e"), new Guid("966bea45-ba2f-4d7c-a234-f190247e2af8"), "Generic Rubber Salad", "amet" },
                    { new Guid("1520206d-8e88-4421-bde9-75675d09c410"), new Guid("af045304-bea0-4bc0-b70c-a1996d323df0"), "Tasty Plastic Bacon", "est" },
                    { new Guid("192f731f-3a87-49d7-9155-cbe73dc0a2c7"), new Guid("165a4718-b25b-4164-9f32-4be49546ece7"), "Handmade Cotton Pants", "delectus" },
                    { new Guid("25216629-afc2-447b-9071-6c7f1f3cf872"), new Guid("6e807d0e-a0e1-43ab-bacc-dafb40872e73"), "Licensed Cotton Hat", "qui" },
                    { new Guid("25cfaefd-6c97-4da4-a9da-268b5d89bfd0"), new Guid("0682e8ea-3aaa-4a86-affa-73a9264f29da"), "Refined Metal Shirt", "minima" },
                    { new Guid("2bf417e3-1a22-469d-a0a2-f616c2756d21"), new Guid("b2fe1634-ce60-4505-9931-bc80131f0529"), "Awesome Concrete Salad", "doloribus" },
                    { new Guid("33271bd7-1614-4ca6-915f-a54bec96fc8b"), new Guid("f18b7fb7-bdb7-4796-809a-c202482f6482"), "Handmade Cotton Mouse", "aliquam" },
                    { new Guid("37d22009-145b-4199-b149-3407103f364b"), new Guid("718247bd-e7fa-4306-8e8d-f39b10ed28b5"), "Gorgeous Metal Bike", "ipsum" },
                    { new Guid("3899d61d-a2fb-4918-b895-164880243df4"), new Guid("0e3bbdda-3bfd-4bee-914c-67780ab293dc"), "Licensed Soft Cheese", "distinctio" },
                    { new Guid("3bb49cf3-bada-4f63-aa8e-77ac747c7eff"), new Guid("87c95550-fa33-48eb-a266-69e0483a7e86"), "Fantastic Wooden Mouse", "suscipit" },
                    { new Guid("4ce943a5-e2d1-4556-a5dd-60ab68ded148"), new Guid("fda3238c-f994-40a3-84d9-600f8e4bb95f"), "Practical Granite Shoes", "placeat" },
                    { new Guid("4ddca443-3268-4f81-a50f-11c5020d269c"), new Guid("87c95550-fa33-48eb-a266-69e0483a7e86"), "Sleek Soft Bike", "deserunt" },
                    { new Guid("4e32a6ad-20f5-4420-9153-8784c5de415e"), new Guid("904cb720-26cc-4756-bb0d-1b8ff84c2ec5"), "Generic Rubber Chips", "consectetur" },
                    { new Guid("4fc6e05e-decf-4afc-bf39-82d42c80a5f5"), new Guid("a3157b15-5b38-4986-b713-84ba884aecc1"), "Generic Metal Tuna", "dolore" },
                    { new Guid("50e01743-fdd2-49e7-8eed-70d667111bab"), new Guid("991c9202-8a16-48af-98df-5ec3d4b196ec"), "Practical Granite Car", "nisi" },
                    { new Guid("514ceae5-4856-4bec-9106-249dafd0d981"), new Guid("a29f05b8-f938-4a4d-9bdf-c15e2b002ab8"), "Rustic Frozen Cheese", "mollitia" },
                    { new Guid("59ecf9b8-9bee-427a-82dd-bff822f01578"), new Guid("900e7bd0-66ef-469d-b0c7-f921c914abdd"), "Practical Cotton Chips", "expedita" },
                    { new Guid("600b1648-9f98-4abf-a15a-47e450532a2b"), new Guid("9a221f92-2cfa-4135-a035-e57882104f9b"), "Incredible Rubber Chair", "dolores" },
                    { new Guid("615df340-eb2f-431e-8817-2d6514c32fae"), new Guid("a29f05b8-f938-4a4d-9bdf-c15e2b002ab8"), "Intelligent Steel Bacon", "dignissimos" },
                    { new Guid("643f9d93-dddb-4c6d-8940-deb1f0f48079"), new Guid("9a221f92-2cfa-4135-a035-e57882104f9b"), "Handcrafted Fresh Table", "eum" },
                    { new Guid("64c24d6f-4bec-4a4d-89b1-02efa009b224"), new Guid("ed3dea5b-a2e1-4cb4-9b94-df6492b71dc8"), "Licensed Plastic Cheese", "dolorem" },
                    { new Guid("66875cb8-a969-45c1-b619-59210d5c7cb0"), new Guid("5adffbc4-7965-43a6-8d8a-6be98815c069"), "Small Rubber Table", "ut" },
                    { new Guid("674bdc8e-56cd-4a13-be4c-8ea5835b984a"), new Guid("5879cb1f-73ab-4eff-9755-fa771c8139be"), "Intelligent Steel Table", "deleniti" },
                    { new Guid("69473240-a210-4b9c-a148-f7bb41828e97"), new Guid("900e7bd0-66ef-469d-b0c7-f921c914abdd"), "Generic Fresh Bacon", "harum" },
                    { new Guid("6aa62ecc-9a16-4c00-ab37-eb1d38175597"), new Guid("04531b99-92e1-48df-830b-52f78649ec48"), "Small Plastic Gloves", "dolore" },
                    { new Guid("6dd840a3-db01-4ff9-859d-3b2ab1123639"), new Guid("ed3dea5b-a2e1-4cb4-9b94-df6492b71dc8"), "Licensed Metal Keyboard", "deleniti" },
                    { new Guid("6fd0603e-ca3b-482b-810d-cfa04929a325"), new Guid("5879cb1f-73ab-4eff-9755-fa771c8139be"), "Ergonomic Wooden Soap", "dolor" },
                    { new Guid("70dc3cfa-305f-47b8-9f20-825cda9860d1"), new Guid("2994f8b2-e6a8-4b74-b693-bd7bf67b98ca"), "Handmade Soft Fish", "minus" },
                    { new Guid("70df49e5-5e0e-4254-90ea-ee00f95fa192"), new Guid("5adffbc4-7965-43a6-8d8a-6be98815c069"), "Incredible Steel Tuna", "nisi" },
                    { new Guid("73f0512c-bcab-4b31-b88b-9dc475e6eaa4"), new Guid("a3157b15-5b38-4986-b713-84ba884aecc1"), "Generic Plastic Fish", "vel" },
                    { new Guid("7838fefd-817b-40b2-a9d8-803e4cdbf935"), new Guid("4533a232-db9e-4478-867a-aa140feca071"), "Small Granite Bacon", "enim" },
                    { new Guid("7cd8a014-63e5-4d50-a715-60cd77b060bb"), new Guid("b2fe1634-ce60-4505-9931-bc80131f0529"), "Fantastic Metal Chips", "quas" },
                    { new Guid("80068452-53c0-4f5d-bd98-99b1030c307e"), new Guid("f18b7fb7-bdb7-4796-809a-c202482f6482"), "Unbranded Steel Bacon", "consequatur" },
                    { new Guid("8285111b-eb30-43cc-b591-76a86860d3a1"), new Guid("af045304-bea0-4bc0-b70c-a1996d323df0"), "Fantastic Wooden Bike", "sint" },
                    { new Guid("875dcd83-8a0d-4d4c-a940-77eed12fdb7d"), new Guid("904cb720-26cc-4756-bb0d-1b8ff84c2ec5"), "Rustic Metal Towels", "velit" },
                    { new Guid("8e4edd2e-6bde-41e5-8a9f-bace207728bb"), new Guid("a29f05b8-f938-4a4d-9bdf-c15e2b002ab8"), "Licensed Soft Shirt", "odio" },
                    { new Guid("8f80d2dc-a0b9-4d12-a307-3b84d7254273"), new Guid("7f8c0ca4-8e3a-4349-b6c6-0768ea551d5c"), "Ergonomic Rubber Table", "rerum" },
                    { new Guid("91a54e63-d8df-4894-a09e-f0c46042077d"), new Guid("2994f8b2-e6a8-4b74-b693-bd7bf67b98ca"), "Refined Concrete Chair", "et" },
                    { new Guid("94c0150f-e4bd-4721-96df-cdc827e72a44"), new Guid("fda3238c-f994-40a3-84d9-600f8e4bb95f"), "Practical Fresh Pants", "fuga" },
                    { new Guid("97a44888-8ff2-4dec-a01a-d989ccecb2a4"), new Guid("0e3bbdda-3bfd-4bee-914c-67780ab293dc"), "Rustic Granite Fish", "et" },
                    { new Guid("9b8af1c1-b90c-41ed-97d5-d4a73b03f22d"), new Guid("6e807d0e-a0e1-43ab-bacc-dafb40872e73"), "Handcrafted Steel Keyboard", "et" },
                    { new Guid("9f11250d-55f9-49e9-94be-856734b521b4"), new Guid("87c95550-fa33-48eb-a266-69e0483a7e86"), "Tasty Metal Computer", "numquam" },
                    { new Guid("a00839cf-84bf-4f80-8274-dc664e85641a"), new Guid("04531b99-92e1-48df-830b-52f78649ec48"), "Awesome Plastic Towels", "voluptatem" },
                    { new Guid("a109a756-a975-4ee3-9c64-bc95f702d61d"), new Guid("ed3dea5b-a2e1-4cb4-9b94-df6492b71dc8"), "Unbranded Soft Computer", "fugiat" },
                    { new Guid("a53bb84b-d9a7-43e8-af1b-b9ed59468980"), new Guid("4533a232-db9e-4478-867a-aa140feca071"), "Unbranded Cotton Mouse", "veritatis" },
                    { new Guid("abd718f8-3047-45df-b950-1663b160cba0"), new Guid("0e3bbdda-3bfd-4bee-914c-67780ab293dc"), "Rustic Plastic Salad", "omnis" },
                    { new Guid("af57c576-38e4-42fb-bea5-28c2a054a2e4"), new Guid("a3157b15-5b38-4986-b713-84ba884aecc1"), "Practical Cotton Gloves", "ut" },
                    { new Guid("b2d59468-a941-4b88-9311-323c0f9a3f23"), new Guid("966bea45-ba2f-4d7c-a234-f190247e2af8"), "Awesome Soft Keyboard", "unde" },
                    { new Guid("b814e13f-e787-49d0-9079-07907635dcf4"), new Guid("991c9202-8a16-48af-98df-5ec3d4b196ec"), "Sleek Plastic Salad", "dolor" },
                    { new Guid("b98539c3-e534-47f6-b5e3-c070e4929bf3"), new Guid("7f8c0ca4-8e3a-4349-b6c6-0768ea551d5c"), "Awesome Metal Car", "similique" },
                    { new Guid("bf15e4e2-9bf2-4d4f-a29a-30cd74ce4dfc"), new Guid("5879cb1f-73ab-4eff-9755-fa771c8139be"), "Small Concrete Sausages", "commodi" },
                    { new Guid("bf8fe80f-bbf3-45e1-9e52-680edf72748d"), new Guid("900e7bd0-66ef-469d-b0c7-f921c914abdd"), "Awesome Cotton Ball", "officia" },
                    { new Guid("c0d970fe-7b48-4cc0-9f5b-6ba2f32c78df"), new Guid("966bea45-ba2f-4d7c-a234-f190247e2af8"), "Sleek Concrete Towels", "et" },
                    { new Guid("c10ca116-8a68-4893-9ae8-04d427154e51"), new Guid("af045304-bea0-4bc0-b70c-a1996d323df0"), "Rustic Steel Sausages", "quod" },
                    { new Guid("c3183c8b-05b3-4c92-a097-bf5ad29ca3ed"), new Guid("165a4718-b25b-4164-9f32-4be49546ece7"), "Practical Metal Fish", "cumque" },
                    { new Guid("c3bbba76-37f6-4519-b53f-a225dd27cca8"), new Guid("04531b99-92e1-48df-830b-52f78649ec48"), "Fantastic Granite Towels", "reprehenderit" },
                    { new Guid("d02113cc-66ab-4f6c-8ebf-ab2b886d8779"), new Guid("b2fe1634-ce60-4505-9931-bc80131f0529"), "Rustic Cotton Bike", "neque" },
                    { new Guid("d956bf7e-e525-4a68-a309-d4b8384914da"), new Guid("165a4718-b25b-4164-9f32-4be49546ece7"), "Unbranded Frozen Chair", "qui" },
                    { new Guid("daa2b54e-853c-4dfa-b667-666b84e0781a"), new Guid("7f8c0ca4-8e3a-4349-b6c6-0768ea551d5c"), "Small Soft Pizza", "voluptas" },
                    { new Guid("dfee090a-f6f8-4374-a4c4-00e26d0135c8"), new Guid("0682e8ea-3aaa-4a86-affa-73a9264f29da"), "Unbranded Granite Chair", "illo" },
                    { new Guid("e521c79e-cf9e-4cc3-80f4-f5831b583e86"), new Guid("0682e8ea-3aaa-4a86-affa-73a9264f29da"), "Sleek Granite Salad", "et" },
                    { new Guid("e5782a7a-b1d2-4f7a-b6cd-1f432e15a41e"), new Guid("9a221f92-2cfa-4135-a035-e57882104f9b"), "Intelligent Wooden Ball", "excepturi" },
                    { new Guid("e70a7aa1-5df3-40a3-a7b4-670dcd9f5ce6"), new Guid("b30b5267-2373-47ca-a164-23a7286ed81d"), "Gorgeous Rubber Towels", "ut" },
                    { new Guid("ed9eabc1-2bbc-45e7-846a-14524674652b"), new Guid("b30b5267-2373-47ca-a164-23a7286ed81d"), "Intelligent Fresh Mouse", "non" },
                    { new Guid("eea97953-e846-4542-b7e5-a39588da2a9e"), new Guid("b30b5267-2373-47ca-a164-23a7286ed81d"), "Intelligent Plastic Car", "ipsum" },
                    { new Guid("efd281fd-d040-4686-bef0-dc5e63a24c43"), new Guid("fda3238c-f994-40a3-84d9-600f8e4bb95f"), "Unbranded Wooden Shoes", "neque" },
                    { new Guid("f5301d55-f324-4036-83f9-f1ad48c0301e"), new Guid("5adffbc4-7965-43a6-8d8a-6be98815c069"), "Sleek Wooden Chair", "quo" },
                    { new Guid("f73b8152-301d-4cac-bccc-0084094d51f8"), new Guid("6e807d0e-a0e1-43ab-bacc-dafb40872e73"), "Practical Rubber Towels", "minima" },
                    { new Guid("faa71991-70e0-4bf0-b38f-60bc5c8eb19d"), new Guid("904cb720-26cc-4756-bb0d-1b8ff84c2ec5"), "Ergonomic Concrete Tuna", "sit" },
                    { new Guid("fc4cc694-6ee5-4c8b-8cca-f09d330e30a3"), new Guid("4533a232-db9e-4478-867a-aa140feca071"), "Handmade Metal Bacon", "dolores" },
                    { new Guid("ff282e2d-3cd9-45b5-a36c-30ad78f1ca8d"), new Guid("f18b7fb7-bdb7-4796-809a-c202482f6482"), "Gorgeous Granite Bacon", "totam" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Course", "DepartmentId", "EndYear", "IdentityNumber", "Name", "StartYear", "StudentCount" },
                values: new object[,]
                {
                    { new Guid("0103e9d3-cdfb-40f4-9f93-25c35c4510fc"), 4, new Guid("9a221f92-2cfa-4135-a035-e57882104f9b"), new DateOnly(2027, 8, 1), 8840, "Sports, Home & Books", new DateOnly(2022, 8, 7), 48 },
                    { new Guid("02f692c6-f0e5-4045-abcb-5bd6d6fd22bf"), 4, new Guid("991c9202-8a16-48af-98df-5ec3d4b196ec"), new DateOnly(2027, 3, 3), 5049, "Automotive, Computers & Tools", new DateOnly(2024, 4, 9), 24 },
                    { new Guid("0fc1b87c-9da1-471f-a2f9-14a097846b04"), 3, new Guid("0682e8ea-3aaa-4a86-affa-73a9264f29da"), new DateOnly(2028, 5, 22), 1362, "Books, Clothing & Electronics", new DateOnly(2022, 1, 23), 18 },
                    { new Guid("21bbfe56-0a3d-42ce-9a7a-865ee39d87ce"), 3, new Guid("9a221f92-2cfa-4135-a035-e57882104f9b"), new DateOnly(2028, 4, 6), 5522, "Kids, Industrial & Automotive", new DateOnly(2022, 2, 10), 38 },
                    { new Guid("248e84ab-12c3-4b3c-8a57-46b5d5bd12d9"), 3, new Guid("b2fe1634-ce60-4505-9931-bc80131f0529"), new DateOnly(2028, 7, 17), 1502, "Books, Garden & Games", new DateOnly(2023, 7, 23), 38 },
                    { new Guid("2601b471-f6f0-4197-8c64-582ce1eaa6e3"), 2, new Guid("9a221f92-2cfa-4135-a035-e57882104f9b"), new DateOnly(2025, 3, 11), 1201, "Outdoors", new DateOnly(2022, 2, 23), 32 },
                    { new Guid("30c913d6-eaa5-45ae-aafd-98b773c49a19"), 3, new Guid("87c95550-fa33-48eb-a266-69e0483a7e86"), new DateOnly(2026, 4, 17), 8950, "Industrial", new DateOnly(2022, 4, 16), 39 },
                    { new Guid("39b06c0a-a651-4574-85f6-66053efc2500"), 1, new Guid("904cb720-26cc-4756-bb0d-1b8ff84c2ec5"), new DateOnly(2025, 7, 25), 6881, "Jewelery & Home", new DateOnly(2023, 11, 13), 21 },
                    { new Guid("39e48343-7838-42b6-b34c-8a5f1d46c8b6"), 1, new Guid("a29f05b8-f938-4a4d-9bdf-c15e2b002ab8"), new DateOnly(2027, 8, 4), 1395, "Computers", new DateOnly(2024, 7, 16), 16 },
                    { new Guid("3ee14ebf-3216-446f-8708-4a074d87ef41"), 3, new Guid("991c9202-8a16-48af-98df-5ec3d4b196ec"), new DateOnly(2028, 11, 12), 3497, "Tools & Beauty", new DateOnly(2023, 7, 29), 21 },
                    { new Guid("3f1133a4-8861-4ef6-ac9a-105f5c2789c1"), 1, new Guid("900e7bd0-66ef-469d-b0c7-f921c914abdd"), new DateOnly(2028, 1, 9), 3452, "Tools", new DateOnly(2023, 1, 15), 32 },
                    { new Guid("5041f502-9bb6-40b3-90f8-d24c80c44232"), 3, new Guid("5879cb1f-73ab-4eff-9755-fa771c8139be"), new DateOnly(2028, 1, 8), 3173, "Outdoors", new DateOnly(2024, 6, 25), 10 },
                    { new Guid("520ee4fb-c741-4638-a360-4284831b172d"), 1, new Guid("2994f8b2-e6a8-4b74-b693-bd7bf67b98ca"), new DateOnly(2026, 8, 14), 8299, "Baby, Movies & Grocery", new DateOnly(2021, 4, 7), 32 },
                    { new Guid("558161ef-e7b5-49b6-9116-c3549f9cdb20"), 3, new Guid("900e7bd0-66ef-469d-b0c7-f921c914abdd"), new DateOnly(2026, 9, 8), 4407, "Sports, Kids & Baby", new DateOnly(2024, 7, 21), 22 },
                    { new Guid("57ccef60-dea4-4a2f-b48c-864e68e033cd"), 4, new Guid("6e807d0e-a0e1-43ab-bacc-dafb40872e73"), new DateOnly(2025, 7, 1), 7695, "Music, Automotive & Garden", new DateOnly(2022, 7, 11), 28 },
                    { new Guid("589b1cf1-4e4d-44d2-9564-69be35df93ad"), 2, new Guid("04531b99-92e1-48df-830b-52f78649ec48"), new DateOnly(2025, 7, 19), 7276, "Shoes & Grocery", new DateOnly(2022, 7, 8), 44 },
                    { new Guid("5b925362-03b2-4e0a-a54a-88507ed38e6f"), 4, new Guid("7f8c0ca4-8e3a-4349-b6c6-0768ea551d5c"), new DateOnly(2027, 5, 24), 3708, "Jewelery", new DateOnly(2021, 2, 12), 46 },
                    { new Guid("5bb38a5f-b9e2-4ff1-9854-1ff0a0b4b513"), 2, new Guid("7f8c0ca4-8e3a-4349-b6c6-0768ea551d5c"), new DateOnly(2024, 12, 29), 6658, "Electronics & Grocery", new DateOnly(2024, 3, 11), 46 },
                    { new Guid("5d602112-2903-4790-9fe5-acdb2d7a13d0"), 3, new Guid("04531b99-92e1-48df-830b-52f78649ec48"), new DateOnly(2028, 9, 15), 4901, "Outdoors", new DateOnly(2021, 2, 27), 45 },
                    { new Guid("5dc77eb2-9b21-4f3c-93af-0bfc1248f5e2"), 3, new Guid("a3157b15-5b38-4986-b713-84ba884aecc1"), new DateOnly(2027, 10, 22), 9119, "Garden & Automotive", new DateOnly(2021, 7, 17), 16 },
                    { new Guid("5dfff1ac-f2f0-44f1-aef4-ae8c745cece7"), 1, new Guid("a29f05b8-f938-4a4d-9bdf-c15e2b002ab8"), new DateOnly(2027, 1, 21), 9082, "Games, Kids & Tools", new DateOnly(2022, 9, 26), 12 },
                    { new Guid("66bceb57-aab0-4769-9bed-c4ba4c56a7f6"), 4, new Guid("904cb720-26cc-4756-bb0d-1b8ff84c2ec5"), new DateOnly(2027, 6, 2), 8745, "Jewelery & Music", new DateOnly(2021, 2, 11), 33 },
                    { new Guid("6a6cb079-fb63-4829-99a1-71042abe5aae"), 1, new Guid("4533a232-db9e-4478-867a-aa140feca071"), new DateOnly(2028, 4, 30), 3788, "Industrial, Tools & Jewelery", new DateOnly(2024, 8, 15), 48 },
                    { new Guid("6eb6af85-9b48-44e9-afbf-66004e8898b3"), 4, new Guid("f18b7fb7-bdb7-4796-809a-c202482f6482"), new DateOnly(2026, 3, 28), 8016, "Automotive & Music", new DateOnly(2022, 3, 16), 36 },
                    { new Guid("734a6ce0-0f8e-4232-905d-c1c871419147"), 4, new Guid("ed3dea5b-a2e1-4cb4-9b94-df6492b71dc8"), new DateOnly(2026, 1, 25), 3843, "Beauty, Games & Electronics", new DateOnly(2021, 4, 2), 35 },
                    { new Guid("73dd53ed-c5d4-44ba-b536-3033142fd688"), 1, new Guid("a29f05b8-f938-4a4d-9bdf-c15e2b002ab8"), new DateOnly(2025, 5, 5), 2471, "Music, Beauty & Clothing", new DateOnly(2023, 12, 12), 21 },
                    { new Guid("7423c79e-8634-4ad4-b29a-cd84b5c25f63"), 2, new Guid("af045304-bea0-4bc0-b70c-a1996d323df0"), new DateOnly(2027, 6, 3), 6008, "Movies & Baby", new DateOnly(2021, 2, 7), 47 },
                    { new Guid("75df346c-dcb4-4d58-9d87-80c6c336f6cb"), 2, new Guid("87c95550-fa33-48eb-a266-69e0483a7e86"), new DateOnly(2025, 11, 13), 7033, "Home & Sports", new DateOnly(2022, 11, 30), 49 },
                    { new Guid("788f0860-ed60-41bb-8b25-914403277985"), 2, new Guid("04531b99-92e1-48df-830b-52f78649ec48"), new DateOnly(2028, 4, 25), 1258, "Grocery", new DateOnly(2023, 8, 1), 27 },
                    { new Guid("8351460f-38da-4778-9d71-1657062958b0"), 3, new Guid("f18b7fb7-bdb7-4796-809a-c202482f6482"), new DateOnly(2028, 7, 12), 1192, "Beauty & Automotive", new DateOnly(2023, 2, 18), 17 },
                    { new Guid("83efc6ac-f8c5-4480-9c3a-3dc8b3729748"), 4, new Guid("f18b7fb7-bdb7-4796-809a-c202482f6482"), new DateOnly(2025, 2, 3), 9713, "Electronics", new DateOnly(2022, 11, 11), 35 },
                    { new Guid("83f82c77-f8fd-45a3-80a6-a788db014322"), 2, new Guid("0682e8ea-3aaa-4a86-affa-73a9264f29da"), new DateOnly(2026, 5, 8), 3349, "Jewelery & Clothing", new DateOnly(2021, 2, 7), 50 },
                    { new Guid("8bc6918b-6758-4ac0-9e33-115f666e1bd8"), 4, new Guid("a3157b15-5b38-4986-b713-84ba884aecc1"), new DateOnly(2025, 6, 18), 8374, "Automotive", new DateOnly(2021, 5, 12), 17 },
                    { new Guid("912d37cd-a363-4e27-89e6-588c478dff85"), 3, new Guid("0e3bbdda-3bfd-4bee-914c-67780ab293dc"), new DateOnly(2025, 7, 13), 8803, "Industrial", new DateOnly(2022, 2, 27), 23 },
                    { new Guid("91cfb108-7e62-4ebb-8609-0f30b7953558"), 1, new Guid("0e3bbdda-3bfd-4bee-914c-67780ab293dc"), new DateOnly(2025, 10, 9), 6345, "Toys & Toys", new DateOnly(2021, 8, 13), 44 },
                    { new Guid("957cc75b-6fd2-4178-bf6f-1ed67d6e5d40"), 1, new Guid("2994f8b2-e6a8-4b74-b693-bd7bf67b98ca"), new DateOnly(2026, 8, 23), 3489, "Tools & Jewelery", new DateOnly(2022, 12, 10), 25 },
                    { new Guid("997599a8-3fdd-4106-aac3-182a4b560058"), 3, new Guid("0682e8ea-3aaa-4a86-affa-73a9264f29da"), new DateOnly(2028, 8, 3), 6845, "Beauty", new DateOnly(2024, 1, 2), 47 },
                    { new Guid("9d3cadd6-3d2d-497c-8b39-a3772ed26305"), 3, new Guid("966bea45-ba2f-4d7c-a234-f190247e2af8"), new DateOnly(2027, 6, 25), 3715, "Clothing", new DateOnly(2022, 1, 18), 23 },
                    { new Guid("9e57d3aa-b7f1-46d3-824d-6f76df390ee1"), 2, new Guid("991c9202-8a16-48af-98df-5ec3d4b196ec"), new DateOnly(2025, 2, 13), 3021, "Electronics & Sports", new DateOnly(2022, 12, 19), 27 },
                    { new Guid("a03d9b28-4654-42e3-9be7-d363ca4a25fd"), 2, new Guid("b30b5267-2373-47ca-a164-23a7286ed81d"), new DateOnly(2028, 10, 18), 9835, "Sports", new DateOnly(2022, 5, 10), 26 },
                    { new Guid("a243bfb3-1800-4147-814e-946892dbf773"), 3, new Guid("718247bd-e7fa-4306-8e8d-f39b10ed28b5"), new DateOnly(2025, 5, 27), 4149, "Industrial, Jewelery & Electronics", new DateOnly(2024, 11, 24), 20 },
                    { new Guid("a3868154-1d26-4184-a8a1-955709e26333"), 4, new Guid("165a4718-b25b-4164-9f32-4be49546ece7"), new DateOnly(2027, 12, 9), 7239, "Beauty", new DateOnly(2022, 8, 23), 22 },
                    { new Guid("a99cd9eb-e296-47c3-b7a9-32db8525297b"), 1, new Guid("5879cb1f-73ab-4eff-9755-fa771c8139be"), new DateOnly(2028, 12, 5), 8744, "Kids, Beauty & Baby", new DateOnly(2023, 7, 18), 23 },
                    { new Guid("ad53d74d-b252-4640-a153-bfea18d3673e"), 3, new Guid("af045304-bea0-4bc0-b70c-a1996d323df0"), new DateOnly(2026, 1, 2), 4800, "Beauty & Music", new DateOnly(2023, 9, 5), 47 },
                    { new Guid("ad896796-a764-4ba7-b866-6d5852dafcc4"), 1, new Guid("5adffbc4-7965-43a6-8d8a-6be98815c069"), new DateOnly(2028, 10, 22), 2494, "Grocery", new DateOnly(2024, 1, 28), 37 },
                    { new Guid("b1153768-3d65-4482-a7b8-f1afa80c36ed"), 1, new Guid("ed3dea5b-a2e1-4cb4-9b94-df6492b71dc8"), new DateOnly(2026, 3, 8), 3676, "Garden & Kids", new DateOnly(2024, 4, 1), 25 },
                    { new Guid("b18436c0-50a1-44f0-bbda-aeaea64cc1d0"), 2, new Guid("b30b5267-2373-47ca-a164-23a7286ed81d"), new DateOnly(2025, 11, 30), 3022, "Industrial", new DateOnly(2022, 8, 14), 10 },
                    { new Guid("b1aad3f6-1d48-4377-9b84-2ffbaff476dd"), 2, new Guid("6e807d0e-a0e1-43ab-bacc-dafb40872e73"), new DateOnly(2025, 12, 1), 3454, "Home & Shoes", new DateOnly(2024, 3, 12), 36 },
                    { new Guid("b283a23b-2b81-4291-970d-b394203ea544"), 2, new Guid("fda3238c-f994-40a3-84d9-600f8e4bb95f"), new DateOnly(2028, 11, 5), 5258, "Beauty", new DateOnly(2021, 1, 14), 15 },
                    { new Guid("b8aa9c63-e755-44ab-9276-62ce19bf8ba0"), 4, new Guid("87c95550-fa33-48eb-a266-69e0483a7e86"), new DateOnly(2026, 12, 8), 4211, "Toys", new DateOnly(2023, 12, 20), 27 },
                    { new Guid("b94d255d-1e13-4a72-8396-6bd11d4cdcf0"), 1, new Guid("966bea45-ba2f-4d7c-a234-f190247e2af8"), new DateOnly(2025, 8, 25), 5820, "Kids", new DateOnly(2022, 6, 16), 32 },
                    { new Guid("ba79dede-6946-4d14-81c1-3c154d20a988"), 1, new Guid("af045304-bea0-4bc0-b70c-a1996d323df0"), new DateOnly(2025, 6, 24), 9473, "Music", new DateOnly(2023, 3, 26), 29 },
                    { new Guid("bb4e2630-392e-49f3-b584-f87b15caf198"), 3, new Guid("a3157b15-5b38-4986-b713-84ba884aecc1"), new DateOnly(2025, 8, 5), 5073, "Electronics, Home & Electronics", new DateOnly(2021, 1, 31), 42 },
                    { new Guid("bc653f00-5984-4f6e-9c1d-80a5fe114590"), 1, new Guid("ed3dea5b-a2e1-4cb4-9b94-df6492b71dc8"), new DateOnly(2025, 1, 8), 3794, "Baby", new DateOnly(2022, 5, 13), 37 },
                    { new Guid("be35415d-da05-4f94-9a9a-501135038b8c"), 3, new Guid("718247bd-e7fa-4306-8e8d-f39b10ed28b5"), new DateOnly(2026, 3, 18), 7365, "Beauty & Beauty", new DateOnly(2021, 5, 4), 39 },
                    { new Guid("c4d89ab9-ff22-45e8-9020-1ffc8759585d"), 4, new Guid("5adffbc4-7965-43a6-8d8a-6be98815c069"), new DateOnly(2026, 3, 25), 7649, "Outdoors & Beauty", new DateOnly(2022, 7, 15), 27 },
                    { new Guid("d0779898-ad51-4a77-bd51-aaad51467239"), 1, new Guid("b2fe1634-ce60-4505-9931-bc80131f0529"), new DateOnly(2028, 9, 23), 3047, "Grocery & Kids", new DateOnly(2021, 4, 26), 31 },
                    { new Guid("d31bd92d-0d05-46d8-b5d4-8b8c27ebcbfa"), 3, new Guid("b2fe1634-ce60-4505-9931-bc80131f0529"), new DateOnly(2025, 8, 17), 4848, "Industrial, Toys & Grocery", new DateOnly(2021, 12, 16), 23 },
                    { new Guid("d74ea1d4-be9d-48b1-9e05-f141ef8dfb59"), 3, new Guid("2994f8b2-e6a8-4b74-b693-bd7bf67b98ca"), new DateOnly(2027, 3, 3), 5786, "Clothing & Beauty", new DateOnly(2021, 5, 10), 45 },
                    { new Guid("da4f7f6e-6912-4db7-9436-ae8b8e6e6bb9"), 3, new Guid("0e3bbdda-3bfd-4bee-914c-67780ab293dc"), new DateOnly(2027, 9, 15), 1722, "Home", new DateOnly(2023, 4, 1), 41 },
                    { new Guid("dc4be890-1278-4e5e-8861-cc62e8ef4220"), 3, new Guid("6e807d0e-a0e1-43ab-bacc-dafb40872e73"), new DateOnly(2027, 5, 11), 9322, "Games, Clothing & Baby", new DateOnly(2021, 10, 13), 46 },
                    { new Guid("dd08e2c3-7da5-4ea9-88b6-d7b631bc875c"), 4, new Guid("5879cb1f-73ab-4eff-9755-fa771c8139be"), new DateOnly(2025, 1, 2), 5424, "Jewelery", new DateOnly(2024, 11, 6), 39 },
                    { new Guid("de1a725a-b599-47cd-88a6-7867a7761475"), 2, new Guid("904cb720-26cc-4756-bb0d-1b8ff84c2ec5"), new DateOnly(2025, 10, 26), 8267, "Garden, Health & Grocery", new DateOnly(2022, 12, 20), 32 },
                    { new Guid("de707ae1-21fe-490e-8edc-ac5f5b23279c"), 4, new Guid("4533a232-db9e-4478-867a-aa140feca071"), new DateOnly(2027, 5, 5), 4883, "Tools & Kids", new DateOnly(2024, 3, 11), 35 },
                    { new Guid("de8eb3ad-6e02-41b4-b26b-b69925a7abc5"), 3, new Guid("b30b5267-2373-47ca-a164-23a7286ed81d"), new DateOnly(2026, 1, 9), 6501, "Garden", new DateOnly(2021, 9, 18), 17 },
                    { new Guid("e1a4a18c-b1e6-4cf1-afbb-8cf65f5d3f3d"), 2, new Guid("fda3238c-f994-40a3-84d9-600f8e4bb95f"), new DateOnly(2028, 11, 13), 4305, "Games, Toys & Industrial", new DateOnly(2024, 2, 10), 36 },
                    { new Guid("e3672f86-b048-4bab-aa43-d9fce28673d9"), 2, new Guid("5adffbc4-7965-43a6-8d8a-6be98815c069"), new DateOnly(2026, 8, 23), 2347, "Games", new DateOnly(2022, 10, 7), 13 },
                    { new Guid("e36c316c-4361-4d4a-94ed-6134a684781f"), 4, new Guid("165a4718-b25b-4164-9f32-4be49546ece7"), new DateOnly(2024, 12, 27), 5642, "Sports, Outdoors & Industrial", new DateOnly(2022, 3, 9), 16 },
                    { new Guid("e9390e1b-1859-4adf-acce-e7b9d7d55ec5"), 2, new Guid("900e7bd0-66ef-469d-b0c7-f921c914abdd"), new DateOnly(2025, 4, 23), 8646, "Shoes, Books & Outdoors", new DateOnly(2022, 2, 19), 11 },
                    { new Guid("f268d336-e674-4782-b6a2-9d8dbc2da6b0"), 2, new Guid("fda3238c-f994-40a3-84d9-600f8e4bb95f"), new DateOnly(2028, 7, 13), 8154, "Beauty & Jewelery", new DateOnly(2024, 7, 15), 39 },
                    { new Guid("f29bcd8d-6e9a-412f-a9ce-de7004b071e8"), 2, new Guid("165a4718-b25b-4164-9f32-4be49546ece7"), new DateOnly(2026, 5, 19), 8859, "Shoes", new DateOnly(2024, 2, 15), 45 },
                    { new Guid("f5aa36c6-242e-4b76-b339-78f5919f1722"), 3, new Guid("7f8c0ca4-8e3a-4349-b6c6-0768ea551d5c"), new DateOnly(2026, 8, 12), 8735, "Music & Books", new DateOnly(2022, 3, 2), 15 },
                    { new Guid("fa32c2d6-9e87-43ea-bf24-8eba9a2427ae"), 2, new Guid("718247bd-e7fa-4306-8e8d-f39b10ed28b5"), new DateOnly(2026, 8, 30), 9455, "Clothing, Beauty & Baby", new DateOnly(2023, 1, 29), 32 },
                    { new Guid("fb35665f-588f-40d9-bb83-abb22ebf3e6a"), 1, new Guid("966bea45-ba2f-4d7c-a234-f190247e2af8"), new DateOnly(2026, 8, 24), 8433, "Tools", new DateOnly(2021, 6, 9), 25 },
                    { new Guid("fe50a2a0-acf2-4778-a560-3d46bb602cdc"), 3, new Guid("4533a232-db9e-4478-867a-aa140feca071"), new DateOnly(2027, 8, 17), 7472, "Movies & Beauty", new DateOnly(2024, 9, 30), 42 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("021733d7-8227-4810-b570-4e1fe4a6d2fc"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("0402738e-0d80-4ef3-a760-95abf0e96406"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("164771ec-160a-44f4-9dc6-2312bc703a1d"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("19703ab3-c58f-4523-891a-1d57c3ef6c00"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("3480a588-de33-4896-b0c8-f21f4b48b592"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("373dd35f-00bb-4f11-896a-8c4896b0f594"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("489ab4c5-4f1b-49f0-bdbd-37d1526085ec"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("511f6515-544b-44fe-b155-fba2446844a7"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("546f870a-fc98-4f96-a168-6736b8dbf7dc"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("566a96a1-f884-4390-854c-cc8811bd6f76"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("7284d403-7668-4ce4-983d-b1a3a179acad"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("75faf98b-cd5d-436f-9a8c-9adafa6c6a57"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("79738ac2-6b57-4c8f-af2e-e492e892a92d"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("7e8fa5cd-27d4-493d-94bd-365687b3b1ec"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("7f807932-c58e-46b1-9a63-d4d2d32db292"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("7fbd4e1b-58a1-43e3-bda8-2a4c05d40293"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("86c6a09a-8b50-4745-aae4-200efffff6a0"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("9a58bd59-e409-45cd-8651-dacff7cd4e51"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("aa3f0ccd-ccaa-4b1e-b53e-6e9bd12cc4fc"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c0fdd0b7-d67a-4c08-a123-77dcd6335e40"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c33e10b7-7f02-455d-9e56-b1a5254aad47"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c691da4c-dad9-4631-b012-38a30f0bc529"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("cf5baef1-580a-42fb-a816-3152a858faec"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("f6a82af9-3553-4816-860a-06f324c19445"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("fa05bffd-d1b0-47d8-b675-1eb0ec461211"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("02a33b58-f6c2-4416-b64c-2dd3774d07d5"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("09f2b2b6-5303-451a-9ed0-9035c6d7a1ec"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("0a6a020b-bcee-46df-b8c9-d5717bfe20e5"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("0b64af6a-ed44-469e-9f6f-e56e44dd11aa"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("0ef2b79a-d7b0-47dd-8619-014ae8dd2c7e"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("1520206d-8e88-4421-bde9-75675d09c410"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("192f731f-3a87-49d7-9155-cbe73dc0a2c7"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("25216629-afc2-447b-9071-6c7f1f3cf872"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("25cfaefd-6c97-4da4-a9da-268b5d89bfd0"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("2bf417e3-1a22-469d-a0a2-f616c2756d21"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("33271bd7-1614-4ca6-915f-a54bec96fc8b"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("37d22009-145b-4199-b149-3407103f364b"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("3899d61d-a2fb-4918-b895-164880243df4"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("3bb49cf3-bada-4f63-aa8e-77ac747c7eff"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("4ce943a5-e2d1-4556-a5dd-60ab68ded148"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("4ddca443-3268-4f81-a50f-11c5020d269c"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("4e32a6ad-20f5-4420-9153-8784c5de415e"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("4fc6e05e-decf-4afc-bf39-82d42c80a5f5"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("50e01743-fdd2-49e7-8eed-70d667111bab"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("514ceae5-4856-4bec-9106-249dafd0d981"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("59ecf9b8-9bee-427a-82dd-bff822f01578"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("600b1648-9f98-4abf-a15a-47e450532a2b"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("615df340-eb2f-431e-8817-2d6514c32fae"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("643f9d93-dddb-4c6d-8940-deb1f0f48079"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("64c24d6f-4bec-4a4d-89b1-02efa009b224"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("66875cb8-a969-45c1-b619-59210d5c7cb0"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("674bdc8e-56cd-4a13-be4c-8ea5835b984a"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("69473240-a210-4b9c-a148-f7bb41828e97"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("6aa62ecc-9a16-4c00-ab37-eb1d38175597"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("6dd840a3-db01-4ff9-859d-3b2ab1123639"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("6fd0603e-ca3b-482b-810d-cfa04929a325"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("70dc3cfa-305f-47b8-9f20-825cda9860d1"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("70df49e5-5e0e-4254-90ea-ee00f95fa192"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("73f0512c-bcab-4b31-b88b-9dc475e6eaa4"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("7838fefd-817b-40b2-a9d8-803e4cdbf935"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("7cd8a014-63e5-4d50-a715-60cd77b060bb"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("80068452-53c0-4f5d-bd98-99b1030c307e"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("8285111b-eb30-43cc-b591-76a86860d3a1"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("875dcd83-8a0d-4d4c-a940-77eed12fdb7d"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("8e4edd2e-6bde-41e5-8a9f-bace207728bb"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("8f80d2dc-a0b9-4d12-a307-3b84d7254273"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("91a54e63-d8df-4894-a09e-f0c46042077d"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("94c0150f-e4bd-4721-96df-cdc827e72a44"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("97a44888-8ff2-4dec-a01a-d989ccecb2a4"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("9b8af1c1-b90c-41ed-97d5-d4a73b03f22d"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("9f11250d-55f9-49e9-94be-856734b521b4"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("a00839cf-84bf-4f80-8274-dc664e85641a"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("a109a756-a975-4ee3-9c64-bc95f702d61d"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("a53bb84b-d9a7-43e8-af1b-b9ed59468980"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("abd718f8-3047-45df-b950-1663b160cba0"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("af57c576-38e4-42fb-bea5-28c2a054a2e4"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("b2d59468-a941-4b88-9311-323c0f9a3f23"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("b814e13f-e787-49d0-9079-07907635dcf4"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("b98539c3-e534-47f6-b5e3-c070e4929bf3"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("bf15e4e2-9bf2-4d4f-a29a-30cd74ce4dfc"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("bf8fe80f-bbf3-45e1-9e52-680edf72748d"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("c0d970fe-7b48-4cc0-9f5b-6ba2f32c78df"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("c10ca116-8a68-4893-9ae8-04d427154e51"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("c3183c8b-05b3-4c92-a097-bf5ad29ca3ed"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("c3bbba76-37f6-4519-b53f-a225dd27cca8"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("d02113cc-66ab-4f6c-8ebf-ab2b886d8779"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("d956bf7e-e525-4a68-a309-d4b8384914da"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("daa2b54e-853c-4dfa-b667-666b84e0781a"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("dfee090a-f6f8-4374-a4c4-00e26d0135c8"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("e521c79e-cf9e-4cc3-80f4-f5831b583e86"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("e5782a7a-b1d2-4f7a-b6cd-1f432e15a41e"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("e70a7aa1-5df3-40a3-a7b4-670dcd9f5ce6"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("ed9eabc1-2bbc-45e7-846a-14524674652b"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("eea97953-e846-4542-b7e5-a39588da2a9e"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("efd281fd-d040-4686-bef0-dc5e63a24c43"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("f5301d55-f324-4036-83f9-f1ad48c0301e"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("f73b8152-301d-4cac-bccc-0084094d51f8"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("faa71991-70e0-4bf0-b38f-60bc5c8eb19d"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("fc4cc694-6ee5-4c8b-8cca-f09d330e30a3"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("ff282e2d-3cd9-45b5-a36c-30ad78f1ca8d"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("0103e9d3-cdfb-40f4-9f93-25c35c4510fc"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("02f692c6-f0e5-4045-abcb-5bd6d6fd22bf"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("0fc1b87c-9da1-471f-a2f9-14a097846b04"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("21bbfe56-0a3d-42ce-9a7a-865ee39d87ce"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("248e84ab-12c3-4b3c-8a57-46b5d5bd12d9"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("2601b471-f6f0-4197-8c64-582ce1eaa6e3"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("30c913d6-eaa5-45ae-aafd-98b773c49a19"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("39b06c0a-a651-4574-85f6-66053efc2500"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("39e48343-7838-42b6-b34c-8a5f1d46c8b6"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("3ee14ebf-3216-446f-8708-4a074d87ef41"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("3f1133a4-8861-4ef6-ac9a-105f5c2789c1"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("5041f502-9bb6-40b3-90f8-d24c80c44232"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("520ee4fb-c741-4638-a360-4284831b172d"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("558161ef-e7b5-49b6-9116-c3549f9cdb20"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("57ccef60-dea4-4a2f-b48c-864e68e033cd"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("589b1cf1-4e4d-44d2-9564-69be35df93ad"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("5b925362-03b2-4e0a-a54a-88507ed38e6f"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("5bb38a5f-b9e2-4ff1-9854-1ff0a0b4b513"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("5d602112-2903-4790-9fe5-acdb2d7a13d0"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("5dc77eb2-9b21-4f3c-93af-0bfc1248f5e2"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("5dfff1ac-f2f0-44f1-aef4-ae8c745cece7"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("66bceb57-aab0-4769-9bed-c4ba4c56a7f6"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("6a6cb079-fb63-4829-99a1-71042abe5aae"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("6eb6af85-9b48-44e9-afbf-66004e8898b3"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("734a6ce0-0f8e-4232-905d-c1c871419147"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("73dd53ed-c5d4-44ba-b536-3033142fd688"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("7423c79e-8634-4ad4-b29a-cd84b5c25f63"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("75df346c-dcb4-4d58-9d87-80c6c336f6cb"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("788f0860-ed60-41bb-8b25-914403277985"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("8351460f-38da-4778-9d71-1657062958b0"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("83efc6ac-f8c5-4480-9c3a-3dc8b3729748"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("83f82c77-f8fd-45a3-80a6-a788db014322"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("8bc6918b-6758-4ac0-9e33-115f666e1bd8"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("912d37cd-a363-4e27-89e6-588c478dff85"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("91cfb108-7e62-4ebb-8609-0f30b7953558"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("957cc75b-6fd2-4178-bf6f-1ed67d6e5d40"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("997599a8-3fdd-4106-aac3-182a4b560058"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("9d3cadd6-3d2d-497c-8b39-a3772ed26305"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("9e57d3aa-b7f1-46d3-824d-6f76df390ee1"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("a03d9b28-4654-42e3-9be7-d363ca4a25fd"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("a243bfb3-1800-4147-814e-946892dbf773"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("a3868154-1d26-4184-a8a1-955709e26333"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("a99cd9eb-e296-47c3-b7a9-32db8525297b"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("ad53d74d-b252-4640-a153-bfea18d3673e"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("ad896796-a764-4ba7-b866-6d5852dafcc4"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("b1153768-3d65-4482-a7b8-f1afa80c36ed"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("b18436c0-50a1-44f0-bbda-aeaea64cc1d0"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("b1aad3f6-1d48-4377-9b84-2ffbaff476dd"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("b283a23b-2b81-4291-970d-b394203ea544"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("b8aa9c63-e755-44ab-9276-62ce19bf8ba0"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("b94d255d-1e13-4a72-8396-6bd11d4cdcf0"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("ba79dede-6946-4d14-81c1-3c154d20a988"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("bb4e2630-392e-49f3-b584-f87b15caf198"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("bc653f00-5984-4f6e-9c1d-80a5fe114590"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("be35415d-da05-4f94-9a9a-501135038b8c"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("c4d89ab9-ff22-45e8-9020-1ffc8759585d"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("d0779898-ad51-4a77-bd51-aaad51467239"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("d31bd92d-0d05-46d8-b5d4-8b8c27ebcbfa"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("d74ea1d4-be9d-48b1-9e05-f141ef8dfb59"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("da4f7f6e-6912-4db7-9436-ae8b8e6e6bb9"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("dc4be890-1278-4e5e-8861-cc62e8ef4220"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("dd08e2c3-7da5-4ea9-88b6-d7b631bc875c"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("de1a725a-b599-47cd-88a6-7867a7761475"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("de707ae1-21fe-490e-8edc-ac5f5b23279c"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("de8eb3ad-6e02-41b4-b26b-b69925a7abc5"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("e1a4a18c-b1e6-4cf1-afbb-8cf65f5d3f3d"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("e3672f86-b048-4bab-aa43-d9fce28673d9"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("e36c316c-4361-4d4a-94ed-6134a684781f"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("e9390e1b-1859-4adf-acce-e7b9d7d55ec5"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("f268d336-e674-4782-b6a2-9d8dbc2da6b0"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("f29bcd8d-6e9a-412f-a9ce-de7004b071e8"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("f5aa36c6-242e-4b76-b339-78f5919f1722"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("fa32c2d6-9e87-43ea-bf24-8eba9a2427ae"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("fb35665f-588f-40d9-bb83-abb22ebf3e6a"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("fe50a2a0-acf2-4778-a560-3d46bb602cdc"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("46753fc7-28e9-46ad-ae01-cfc71139f5a1"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("6d3b3bba-a0ba-42f9-a956-cb8ff239a8ab"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("e02f1e86-d1ac-4fa3-96b1-d32c73cf6d35"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("e3188a17-ffc1-43ea-a8da-b8d948139511"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("f0ab2c9a-a678-4d66-8bf1-e6451ee0c1d4"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("04531b99-92e1-48df-830b-52f78649ec48"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("0682e8ea-3aaa-4a86-affa-73a9264f29da"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("0e3bbdda-3bfd-4bee-914c-67780ab293dc"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("165a4718-b25b-4164-9f32-4be49546ece7"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("2994f8b2-e6a8-4b74-b693-bd7bf67b98ca"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("4533a232-db9e-4478-867a-aa140feca071"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5879cb1f-73ab-4eff-9755-fa771c8139be"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5adffbc4-7965-43a6-8d8a-6be98815c069"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("6e807d0e-a0e1-43ab-bacc-dafb40872e73"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("718247bd-e7fa-4306-8e8d-f39b10ed28b5"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("7f8c0ca4-8e3a-4349-b6c6-0768ea551d5c"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("87c95550-fa33-48eb-a266-69e0483a7e86"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("900e7bd0-66ef-469d-b0c7-f921c914abdd"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("904cb720-26cc-4756-bb0d-1b8ff84c2ec5"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("966bea45-ba2f-4d7c-a234-f190247e2af8"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("991c9202-8a16-48af-98df-5ec3d4b196ec"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("9a221f92-2cfa-4135-a035-e57882104f9b"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a29f05b8-f938-4a4d-9bdf-c15e2b002ab8"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a3157b15-5b38-4986-b713-84ba884aecc1"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("af045304-bea0-4bc0-b70c-a1996d323df0"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b2fe1634-ce60-4505-9931-bc80131f0529"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b30b5267-2373-47ca-a164-23a7286ed81d"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("ed3dea5b-a2e1-4cb4-9b94-df6492b71dc8"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("f18b7fb7-bdb7-4796-809a-c202482f6482"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("fda3238c-f994-40a3-84d9-600f8e4bb95f"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("0d31ee0e-fcc2-4d1b-82ea-45dd764eb470"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("330f22ee-7930-4ca6-93bf-1ce1b2eb4646"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("4aca5b3a-3d40-4be5-a250-dc1555b84b24"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("d16f1428-6096-444a-be1f-ea126f3771aa"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("e5a69e26-28b8-448f-94e5-d9f05ce55321"));
        }
    }
}
