using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AssemblyService.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class dataseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Campuses",
                columns: new[] { "Id", "Coordinates", "Number" },
                values: new object[,]
                {
                    { new Guid("1f2d8ba2-f238-4997-a776-32d088586268"), "57.9676, 172.0674", 44 },
                    { new Guid("24fdcb96-0e61-434b-b8d4-b3799e61ab81"), "37.5919, -144.0334", 59 },
                    { new Guid("50ea5bc9-6b16-4e67-99f1-507a10a9cf5e"), "80.0082, 27.3649", 34 },
                    { new Guid("65f4bdd4-54de-4386-af36-4dec081e1795"), "72.2626, 64.5401", 33 },
                    { new Guid("d87e7e65-e11f-4b0c-b0af-a3a83634fa7d"), "-66.278, 4.5368", 43 }
                });

            migrationBuilder.InsertData(
                table: "CompletedSlots",
                columns: new[] { "Id", "ClassroomId", "DayOfWeek", "SubjectId", "TimeSlot", "WeekType" },
                values: new object[,]
                {
                    { new Guid("0219cd30-200b-4eb0-9ac4-8cf34e625786"), new Guid("95ba5d66-3da8-4175-b694-9c1c767e8625"), 3, new Guid("0534cee9-764b-40c1-9911-5da52ec3b766"), 2, 2 },
                    { new Guid("08c31e74-fa33-4c32-a10d-590c7eedecb1"), new Guid("470557a3-6f24-46c6-a44e-392683b039fd"), 0, new Guid("0ae24e72-9419-403b-b4ca-8660d8968c99"), 1, 0 },
                    { new Guid("095f2758-e8cb-4cd7-95a8-91e3f44033ff"), new Guid("afd87040-3773-4956-8a2b-8e404dfccf73"), 6, new Guid("c05122a9-c298-4e39-81be-9b9e18938439"), 5, 1 },
                    { new Guid("0b4e4aa9-d99c-4f1f-9332-b38ab0076766"), new Guid("328be0e5-e268-453e-bc5a-1c28c153285d"), 6, new Guid("b7ef39df-0fa0-4e67-83eb-3bfe364172d4"), 5, 1 },
                    { new Guid("0b560c08-6f9e-4cc2-9ccb-6f110867523c"), new Guid("a1d6744c-0e79-43d6-96fc-b5715e60f31e"), 0, new Guid("973452c7-e669-4e95-9f80-51fb8aa13883"), 4, 0 },
                    { new Guid("14b2a9a9-276f-4918-86c2-b818f6bf8b82"), new Guid("7f78737f-5686-4783-bfb5-5e902e997b07"), 1, new Guid("6259f6d3-691a-4274-bb82-3b9a6f3d8780"), 3, 0 },
                    { new Guid("177f37f9-e107-4716-b4ef-c6d2b6681269"), new Guid("bf675689-8d1e-4d47-a5f6-56f52944848a"), 0, new Guid("a5ad7b59-7233-4f94-ba5f-6dbd49703ca8"), 1, 2 },
                    { new Guid("1909749b-788a-4187-aca5-d44efe923d29"), new Guid("08ccf74a-88b8-421e-bb5a-cd156fc79c01"), 4, new Guid("b9efee35-f1a1-4af1-b82b-41455b891ca0"), 5, 2 },
                    { new Guid("1a12ebca-33db-4592-a504-496c571db668"), new Guid("a9810515-81c6-42a3-ac5d-efb4a70c99ab"), 0, new Guid("887c7aa0-3038-4c29-9c7f-ee3515feb6e5"), 2, 2 },
                    { new Guid("1f572b42-cb8b-42ce-b0de-146104e3e893"), new Guid("1fbb0022-9fed-4c6b-9c77-5e121300caf4"), 1, new Guid("fb4e9a02-fb43-4904-9be7-c36b6e288d4c"), 3, 0 },
                    { new Guid("2178a6d7-f63e-4605-8d5b-4967e305cb2d"), new Guid("1c4bd9bc-f788-40b6-b0d6-eb81d100d92d"), 6, new Guid("3c202cf3-6f36-469b-b12f-4c3ae500fa9b"), 1, 2 },
                    { new Guid("2240a563-2024-4255-9341-9d234372a1b7"), new Guid("5b31fe92-778b-4840-b925-18fc6341c7e5"), 4, new Guid("dc928b8b-49b2-48fc-8963-4a150eacf0f6"), 3, 0 },
                    { new Guid("2b855222-eb16-4c20-8f92-8b0140897d38"), new Guid("86f8c4cc-dc87-4a91-9e04-f55190fc6d5d"), 2, new Guid("7f888637-6655-42c0-b0c2-fb241a3ccb32"), 5, 2 },
                    { new Guid("2ceb8e91-8c7a-4047-8062-a28a5556adb2"), new Guid("d73d477a-a1d1-4504-bdb7-26b5c93f2634"), 2, new Guid("ce83a798-e4ee-4623-9651-f87b9b87615e"), 1, 2 },
                    { new Guid("301888e9-90d0-4533-9b20-2f18bc7035a9"), new Guid("c950bf26-c81d-441d-b68a-f6768b676084"), 6, new Guid("c8cebe21-d9e8-4848-91ea-9b325cb26601"), 5, 2 },
                    { new Guid("31818d66-266e-41ec-8308-04ef7af314b0"), new Guid("70278821-0dd9-4778-93af-3c6c1b106ebf"), 6, new Guid("c0774e73-62da-4d77-9a43-ab75c9ae79cc"), 3, 1 },
                    { new Guid("3182dcde-a5bb-4312-82f9-9b76a584e5f5"), new Guid("bb4b3088-190c-4ebb-873b-0040ed984ede"), 5, new Guid("8865eacf-6e7f-407b-b717-3361172c8dcb"), 5, 1 },
                    { new Guid("3417e5ca-e801-405a-8988-11a1cf752042"), new Guid("4cb3216b-b1a3-4c31-acf7-9dd441920721"), 2, new Guid("85aef681-1d13-4455-b0d5-3aff9a565907"), 2, 1 },
                    { new Guid("3a0d72bd-4152-4cb6-a7ce-c14b2d11cc0d"), new Guid("2e39c02b-b8e3-4f65-82e5-40bc91fb08d2"), 6, new Guid("8412b6fd-28f2-4ba9-99e1-5b0f4cd28428"), 2, 0 },
                    { new Guid("3a4a07cf-1499-412e-a7a8-9a37927b891c"), new Guid("f07c922f-c2ba-4805-bdbd-634d3eb46e96"), 1, new Guid("86110728-190d-4ab6-be02-697b0da62283"), 1, 0 },
                    { new Guid("3a6f70ad-e959-432b-9287-4f6cfa4ad70a"), new Guid("42cc35b9-87a9-4671-96a7-7ad964f66768"), 5, new Guid("8f921353-83c3-4c3d-9674-715694e0943a"), 2, 0 },
                    { new Guid("424e1982-fb1e-41c5-9b7b-3d7e7c877a91"), new Guid("a2861d08-bd67-49c4-87f2-69abadffd1eb"), 3, new Guid("72524c8c-1f22-4994-9dd7-ed453427f7f3"), 2, 2 },
                    { new Guid("43e026d0-31f7-4069-a460-2bf39c4acf7f"), new Guid("48b1451e-9fbb-4564-b528-7d53da732a20"), 2, new Guid("ff70296e-baea-4dc4-9e4c-fb9a4479dd36"), 2, 2 },
                    { new Guid("479d9f46-bb34-4506-ba88-f2e3be3ec1f0"), new Guid("24b32dd6-a613-4b3f-a3f9-2e3b9b62ef18"), 4, new Guid("27cea000-0daa-468e-b6a1-d362f2150ad9"), 2, 0 },
                    { new Guid("50f00ca4-81db-461c-95f0-6a1698672e39"), new Guid("a6b25d59-470d-4385-a9b3-e627829c579f"), 2, new Guid("e017e343-825d-4444-bfab-248080c48f65"), 5, 1 },
                    { new Guid("510981ca-1949-4173-85e9-01c56786f289"), new Guid("196e58b1-63b9-44b7-9b8a-3107c63bfa34"), 1, new Guid("e48cee52-bb85-408f-99fe-7de09027605b"), 1, 1 },
                    { new Guid("580c77ad-e6b1-41f9-8c7b-d0d94e036c1a"), new Guid("12b60259-4f4d-488c-90a0-d60802925aa2"), 2, new Guid("044a8ab9-99e7-45d1-9141-18359cc1333c"), 4, 1 },
                    { new Guid("59792c1e-7206-4627-b601-cdaedaae621f"), new Guid("44230825-cd97-4263-8116-d0a4407fa56e"), 3, new Guid("0b6d391c-b243-48c4-8221-2551ef381e71"), 2, 2 },
                    { new Guid("5b158990-0056-4f65-ae7d-87624f8aafc3"), new Guid("ef43a5cf-16ce-4999-ab70-3f962661ef55"), 2, new Guid("1e4750d3-38d4-4fc0-940e-68f83ebec81b"), 2, 0 },
                    { new Guid("6133db49-f2f8-4cd2-8257-618527dce993"), new Guid("fae693b1-acc3-466c-8733-d32a0c658d25"), 1, new Guid("a0f0598d-d23f-4ddf-a40a-a23494f10402"), 1, 2 },
                    { new Guid("68b9c47f-1fd7-45e9-ac92-89d2bbc4bcc1"), new Guid("25e9dadc-ed15-4e81-bcd4-ac482979fc82"), 1, new Guid("19c608c1-bbb6-4d58-86ae-0d2bdc069141"), 5, 1 },
                    { new Guid("6eab599e-3719-401a-b2a0-d4d0ae53834c"), new Guid("523a74da-4435-4ea5-a9d7-3f3f11c084ec"), 2, new Guid("593fd68c-5efb-4f59-99f7-95b59b1e91e9"), 2, 1 },
                    { new Guid("70f11e55-6a9d-45bf-bb0f-cae36c8baeca"), new Guid("38128452-19f4-4a1b-bf10-2ee5c4343459"), 2, new Guid("641c08f2-afe5-4208-ab0c-b7fe1961ec93"), 4, 2 },
                    { new Guid("73ed7f5f-607a-4a2d-9166-5be46729a752"), new Guid("84dd5316-369c-4f6a-8014-ac8634ca4063"), 3, new Guid("b1fe2af6-fc3e-4a81-b65c-4a95b9dbf02b"), 2, 2 },
                    { new Guid("79c10c74-836d-4b54-a123-846b777a8ec9"), new Guid("2cca05ec-25d2-4a35-a365-ef282ae6d4ee"), 1, new Guid("6e072cc4-4ce5-424e-abd8-f3fee304f881"), 4, 1 },
                    { new Guid("7b1c439d-70a7-407e-9369-229999fcd957"), new Guid("0f10fd9d-aad9-4135-b9b1-8f1fe571d171"), 1, new Guid("07e7a6ed-66c7-48d3-bdd6-8bb280e7bbc9"), 4, 2 },
                    { new Guid("7cbc2e2d-ff3e-488e-950e-8cb33f6cd7b7"), new Guid("008614b9-548d-474f-b497-3304500404dd"), 4, new Guid("21f0b65d-2e6c-47aa-96af-5ae26b6ba674"), 5, 2 },
                    { new Guid("8208cdf0-fed5-487c-b60e-3c5ff79c036e"), new Guid("32824319-2d03-4d94-8179-fb3e550a6a95"), 4, new Guid("389d7b28-3a57-4239-aa16-08c7e6fabbda"), 3, 0 },
                    { new Guid("82729ae3-0bdb-4515-be05-b449adffa373"), new Guid("cef7a396-04ed-492b-b502-7d97a563da1c"), 1, new Guid("0da939c6-8061-4a72-900b-8d3cf02879c9"), 3, 0 },
                    { new Guid("88df80c2-52bf-4fda-b857-e3a15616bc91"), new Guid("4d5ee280-9167-41b6-be41-07131dcb6bf1"), 2, new Guid("a3d94a1a-35fe-4a51-a72e-0e0d407e642d"), 4, 2 },
                    { new Guid("8cd2f13a-e1d9-447d-90b9-7aaf08e74f08"), new Guid("adf3e553-12fb-4528-aaed-54b433dad4cd"), 0, new Guid("aa53f8a7-e563-4e0b-ba99-978b49801afe"), 5, 2 },
                    { new Guid("93927f35-8e87-4e9f-b10b-f58d6ea491ff"), new Guid("6c611a13-cfee-473f-91e1-49b5ce0f086a"), 3, new Guid("7b27c01b-cad8-4b2e-9741-ecd68ea931ef"), 5, 0 },
                    { new Guid("94880070-e8be-44b3-bae8-55c3d654e347"), new Guid("d88d7abf-4708-4c9f-a01c-104bb2035fb4"), 4, new Guid("5c10c9ec-5ea3-4d7f-8ea6-3c930aa2ee95"), 1, 2 },
                    { new Guid("9b521672-4ce3-4c43-971d-8fec87888fb2"), new Guid("1f1a78dc-b53e-4bca-83ee-822356a91023"), 3, new Guid("da4659ad-cf3e-41b3-b468-0f43f4c6f53e"), 4, 1 },
                    { new Guid("9e7d5d44-98cc-4dcc-86af-4f7c36e11aee"), new Guid("be5252b6-bf56-4c97-9ebc-06164220850e"), 0, new Guid("913102dc-f430-4817-b93c-ff69e3a48aaf"), 4, 1 },
                    { new Guid("a76a5f79-5c50-4621-90da-a0b17a707b30"), new Guid("f0ec0ea8-47fd-413b-8f5b-c5102eb0f8ec"), 1, new Guid("2ed16eea-aaca-4356-bb72-d8a5f281c014"), 3, 2 },
                    { new Guid("a89c03c6-ed27-4aa1-9716-91f72d55ef99"), new Guid("e4c3c8f1-419f-48ff-a3e8-0d843e7174d7"), 2, new Guid("930e1ec6-61d1-4cb5-88b5-f7f4faa3da98"), 4, 2 },
                    { new Guid("aee043af-e4b5-44ee-8180-2f653c7a6edd"), new Guid("3cab4f44-fcdb-473d-823b-356ff6dd1cda"), 2, new Guid("e4947555-c87f-45fa-84cc-6e783e35db74"), 5, 1 },
                    { new Guid("b4626305-cc30-4fdd-afd8-d916e8b4801f"), new Guid("01655dc2-efe4-40aa-8423-eaef90cdbcd4"), 3, new Guid("47fa5709-5a6a-40ab-9701-e4239cea5484"), 2, 1 },
                    { new Guid("b676c8b4-023e-4f04-9947-145a2eaf5de7"), new Guid("9197af5d-d86a-4326-b415-31397dbd30d1"), 6, new Guid("592f6adc-c637-4981-9ea3-c803d1a0b063"), 4, 0 },
                    { new Guid("bc5f534a-adf8-4a0b-b0cb-da8bf4858a16"), new Guid("e18a221c-d908-4755-9d51-bd7976bc38a2"), 5, new Guid("34b38f40-e5e1-42e2-97e1-055507ae9c6e"), 2, 0 },
                    { new Guid("c094e880-7adb-4600-89d9-c8f0588dafa4"), new Guid("76e77061-e882-47b0-8361-0ce90080f9e0"), 2, new Guid("5e036d7c-59ba-4b88-8967-3acc3737ccad"), 2, 2 },
                    { new Guid("c0eb396f-1ecf-4339-b4fe-10e424ebd774"), new Guid("938bc91e-2d7e-4e76-95bd-108f3c7b5bf8"), 0, new Guid("3cf56324-50be-4526-b426-ef3670eef8c6"), 2, 2 },
                    { new Guid("c617c1a5-b83d-4b53-a1a9-79022fd82ae7"), new Guid("a5ac7dba-739a-4cbd-b2c8-6f1240633ce3"), 4, new Guid("36af5df0-d03b-4d78-b43a-f076958f0f3c"), 4, 2 },
                    { new Guid("c97833aa-967c-480e-886b-d8b1908df818"), new Guid("50167f1e-6a9f-4d7c-8f2b-141b041545d8"), 2, new Guid("6d126168-96db-4609-9617-8540a3c6f716"), 1, 1 },
                    { new Guid("c9e6734e-97d2-4d87-8b2a-03904590eafb"), new Guid("7386d081-9c79-48ae-99b9-e620e7648e4b"), 2, new Guid("5c2fa306-a7e1-4f67-a63e-5948c91e717b"), 5, 1 },
                    { new Guid("d221c3be-e401-4b22-85a3-ed2a18297a7f"), new Guid("d06e9aff-4dbf-4234-b701-aa2aad6cec69"), 1, new Guid("e5eebd5e-b8b9-4844-b322-a87d13bcdb3e"), 5, 1 },
                    { new Guid("daa82173-7790-4ee7-baac-f10c220d8601"), new Guid("e0976536-5c4d-4d1d-9263-e9f2f20ffadf"), 1, new Guid("1355912a-f032-456c-af55-cdadfa2d461f"), 5, 2 },
                    { new Guid("dd1ff795-e6e6-436e-b273-730dba1f9cec"), new Guid("0525e13f-3865-4622-ba22-3eb6b951c82b"), 0, new Guid("368d89ae-4302-4b53-859d-a334a86c15d3"), 2, 0 },
                    { new Guid("e06cbf72-1e92-4eb0-bd05-5b16d5a1d2b2"), new Guid("d58dccda-21d1-4fd1-b1a2-3440bbc27a3e"), 3, new Guid("0306eb69-db3c-4928-911a-6e254fd89230"), 5, 2 },
                    { new Guid("e111fc73-b7aa-4564-8471-9d84cf49e35c"), new Guid("ca73aa90-7fed-4cf6-ae93-410e8429e1ba"), 5, new Guid("b6f34704-9ed0-481f-8795-3438aa4d95eb"), 5, 1 },
                    { new Guid("e3189537-61df-4fff-9fe3-769a1721c3ef"), new Guid("d832cd33-55e3-46f2-ae03-a0dfebd4a7d3"), 6, new Guid("7c73c4f9-19d6-4e4e-8990-0ea43375d1aa"), 3, 2 },
                    { new Guid("e3bed1d1-f1fa-4338-9559-b329a16d8aa8"), new Guid("ed233d21-f6da-4d33-bb5f-e4461b5baf3e"), 2, new Guid("f1e56301-7af7-4253-a2f5-210bd516a642"), 3, 0 },
                    { new Guid("e44ea821-43c1-4d49-b13f-3e8b3530c867"), new Guid("3efe5a03-1f9f-49da-976e-65c194412b80"), 1, new Guid("cf412f69-6825-405a-920f-9953f0b08b9e"), 3, 0 },
                    { new Guid("e52b6e6a-7f99-4027-ac31-61a7ae1139af"), new Guid("f4025102-de6c-4ff7-bef3-c506ad49640a"), 1, new Guid("f7382fad-ef41-4178-9b5a-e14318c88c1e"), 3, 2 },
                    { new Guid("e667bad8-399a-43fa-a09a-51b57d06575d"), new Guid("4e024606-9dba-4378-8b22-0cd597bc4f93"), 5, new Guid("f3bcf7a5-7df5-43a0-a79e-01ea112a8acc"), 5, 1 },
                    { new Guid("e786ede0-6156-4940-ad10-735637e5af11"), new Guid("1b7ed4ed-efaf-4a1b-a863-0ed96cb88c20"), 5, new Guid("ca7dde4f-1aab-45d9-b2f8-21ea914298d0"), 3, 0 },
                    { new Guid("e8789bb3-6c8f-4dab-b3ee-589eae8d78e0"), new Guid("e8c89287-201f-44de-a7b8-8d58653be92c"), 6, new Guid("f1582994-4ad0-4b4d-95ae-7a847e1a08ec"), 5, 0 },
                    { new Guid("ec9fad06-b616-4f6e-b8b0-18d661de7b29"), new Guid("abb9dd23-2e8d-40d3-9ecf-e8c701a53441"), 3, new Guid("a6f67b6c-4fa1-4a61-9f40-7fc3dbf2fc34"), 1, 2 },
                    { new Guid("efb282bc-e121-4858-a340-0cecb776ecc8"), new Guid("87a53b26-c532-4a7a-92c8-62c5db738ea7"), 1, new Guid("a49ea297-a6a2-4620-be88-ff7a560d1d0e"), 2, 0 },
                    { new Guid("f104a7f7-e3eb-46ac-b7cf-b2d5e9cb3790"), new Guid("883a7bc0-e6ec-4d3e-9a25-4d411b9de4e7"), 1, new Guid("c074167e-7923-4965-8d96-159c19320c33"), 2, 1 },
                    { new Guid("f838841c-e2d6-42e1-98e8-892306d6d0f2"), new Guid("3095e432-8133-4d49-a0ad-25ec82cb86c6"), 6, new Guid("41e09ebe-dff7-4105-8e6d-1ba6afbefa5d"), 2, 2 },
                    { new Guid("f8a0d671-4e64-4d46-aab4-37db77d87156"), new Guid("11cb6a93-ca07-4564-8732-d6c9429376de"), 3, new Guid("7fa5a8cd-4cd3-41ff-ace8-3387c291a800"), 5, 2 },
                    { new Guid("fbf02106-b2f7-48e8-a8b1-11f6095482ad"), new Guid("eebe2bf8-6189-4f23-8c39-34ca205684d1"), 6, new Guid("e65d9a90-41e9-4fd3-a074-241e7c357c27"), 1, 2 },
                    { new Guid("fe3fd0a3-eed8-4181-b83f-6e7113d6a9a0"), new Guid("421fea23-c058-4c74-9fcf-34852fbf41b2"), 4, new Guid("b2507a76-9c01-4280-ac80-6eee7cdad54f"), 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "SubjectTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00a019a4-027c-4fe9-82f8-92669be4d1ba"), null },
                    { new Guid("00a269e0-695b-4bbd-962b-523e97381838"), null },
                    { new Guid("0167a1ad-8c8e-4487-8cc8-dc9a7ce2913a"), null },
                    { new Guid("01a87e32-ca1c-4432-a3fb-a6705fbb1cb1"), null },
                    { new Guid("01dd8510-a265-47c8-b9f0-892e0fa2b8cc"), null },
                    { new Guid("02964334-1c98-435e-b99c-566f33efb03f"), null },
                    { new Guid("030c1cf5-48ca-4893-b767-1b3e2a625e05"), null },
                    { new Guid("046396b9-5df1-4fd7-9f6d-b84ef81975c4"), null },
                    { new Guid("0590458d-4e5b-4909-9d45-30c705a4e38b"), null },
                    { new Guid("078fcbe7-943b-4481-b356-d674e39b22b0"), null },
                    { new Guid("07a90d69-f937-4cf1-b123-01b7983ae787"), null },
                    { new Guid("0a2c84c9-4a54-4768-88a1-653bf9046ed7"), null },
                    { new Guid("0ba0f4c2-77c2-4891-9fed-903e12967a0a"), null },
                    { new Guid("0ca1a578-367b-4fca-954c-1f6d9837173c"), null },
                    { new Guid("0cb9638f-e51a-4ffd-813c-6bf9d1f3662c"), null },
                    { new Guid("0d05d766-c5a5-46d2-9fee-1d1bd7267678"), null },
                    { new Guid("0f00eec6-8362-4920-a0d5-bf5d9b08bc8d"), null },
                    { new Guid("0ff302de-9074-45ea-8650-6ef046057756"), null },
                    { new Guid("1089c444-89c2-49e1-8e31-237773b4bbdb"), null },
                    { new Guid("14099075-f935-48c1-a94c-c1348dfd4243"), null },
                    { new Guid("1460cdf0-0472-41fe-8d74-5035e4c9d775"), null },
                    { new Guid("1544f60d-cbfc-429b-8f6e-1f28029134dc"), null },
                    { new Guid("15cd6a94-b0fc-4ed9-8e3c-6632004b05ee"), null },
                    { new Guid("1676f974-7e6c-456a-be87-c0606e6a117d"), null },
                    { new Guid("18d48ee3-468d-42dc-a29b-40ee0afc9406"), null },
                    { new Guid("19171c23-1e58-40e2-ac0f-e6d66941f057"), null },
                    { new Guid("195048ec-e7a7-42c2-a6a6-19af598bc581"), null },
                    { new Guid("195ac85a-fa25-40db-a58a-6f39a1d65b73"), null },
                    { new Guid("19adeea2-9f6d-4192-afe4-8af3a6da06af"), null },
                    { new Guid("1c6d8319-9dbf-47df-993d-be839c332ee4"), null },
                    { new Guid("1ccfd9df-5e24-4554-8cb5-a3036f85d854"), null },
                    { new Guid("1d4dc608-8e58-44a9-a1ba-75d9a117874a"), null },
                    { new Guid("1f512176-db86-4bfe-b80f-a3540619179b"), null },
                    { new Guid("1fbb0c15-5c65-4723-8668-1f29b76f6db6"), null },
                    { new Guid("1fe1633c-a4aa-425e-9d32-12bdd6640561"), null },
                    { new Guid("1ff41738-1a8a-4b9a-aab7-75ab6ff026b0"), null },
                    { new Guid("21a8e091-fa75-4dbe-abdb-104a9b398538"), null },
                    { new Guid("223b3527-20ce-42f7-b231-c5f3e68b790e"), null },
                    { new Guid("238ccde9-3991-48b3-876b-a0b6020fb426"), null },
                    { new Guid("2599fe6c-4228-4621-a8ac-41894cee75ed"), null },
                    { new Guid("2661a04b-369c-4208-b57b-d33f5376d68c"), null },
                    { new Guid("271e3a2c-81ba-4720-b3fb-adb22e4de15f"), null },
                    { new Guid("28b20f69-2038-408b-b21e-1447e6f43772"), null },
                    { new Guid("2984e81a-30cc-46e4-a7a6-560e21e71f8b"), null },
                    { new Guid("29def353-605a-4b32-a0a5-2296ec5d6ccb"), null },
                    { new Guid("2aebe351-d536-477a-a9d3-4548147acb2c"), null },
                    { new Guid("2c2f5243-f65b-46f4-998a-69fc754e8a2c"), null },
                    { new Guid("2ca871b6-7612-4ea5-b45f-7f7ecb2be7d7"), null },
                    { new Guid("2d166a85-901f-4e76-9b83-3b678d322810"), null },
                    { new Guid("2fa8d356-29c6-4f89-865c-244dc6f78889"), null },
                    { new Guid("3075a0a1-ef04-40db-b006-a0463b1e1348"), null },
                    { new Guid("31216b6b-399f-4f74-be14-71de6483bb6b"), null },
                    { new Guid("316d18c5-0714-4f5f-8e83-f13295016f79"), null },
                    { new Guid("31b34397-b626-4e31-ab43-61529f13a549"), null },
                    { new Guid("34b89a0c-6ab7-4c23-a295-8a93ffb7e01f"), null },
                    { new Guid("34d7f666-a6e5-4d30-8ce3-00e1fd0b264b"), null },
                    { new Guid("35695035-b37a-44c3-8d47-8f2561bdebd5"), null },
                    { new Guid("362a1dce-11f6-458c-8fa2-3a47e5b04b24"), null },
                    { new Guid("36c0ed72-24cc-4b9f-bef2-2459959f6512"), null },
                    { new Guid("36fddfc6-609d-47d5-8239-3a3f60e9ae8c"), null },
                    { new Guid("37298e3e-3d92-494e-b74e-61074a02102b"), null },
                    { new Guid("37543324-69ec-4549-9c8f-1ead424fb1d1"), null },
                    { new Guid("3781cdeb-55c2-4277-8ee5-aefb9e646572"), null },
                    { new Guid("396dde86-8633-4613-8d6c-7c36a76ca074"), null },
                    { new Guid("39eaf3fb-f54f-460f-b12d-2f5b24d7e268"), null },
                    { new Guid("3a50ea6c-c189-45a5-8807-851b25bbb392"), null },
                    { new Guid("3a523640-76a2-4e21-8f65-3f88e9b3862a"), null },
                    { new Guid("3a53f64e-2aa3-4c5c-bd44-d7b21832f07f"), null },
                    { new Guid("3a5f0bb7-5fb4-4193-aaa8-153eb79f7a2a"), null },
                    { new Guid("3a7a1791-9ea6-4d7b-95d1-f2ff68c03819"), null },
                    { new Guid("3accec83-2399-4d6a-94c4-d71b9fc41656"), null },
                    { new Guid("3b3928bd-120e-431c-be8d-810dc254f283"), null },
                    { new Guid("3b9b009a-df7f-47c8-990a-f69340215c7f"), null },
                    { new Guid("3d0cf7d4-3beb-4f8a-a08f-4264839800e3"), null },
                    { new Guid("3dfc4458-7d85-4a7c-abbe-f83f563d859f"), null },
                    { new Guid("3f25c6dc-457e-4633-8ce8-be4f7f3a6c8e"), null },
                    { new Guid("405de9c7-e4a3-498e-99ab-410d284a945f"), null },
                    { new Guid("41a1794c-dc09-450d-a0c0-71cc1dfe1b29"), null },
                    { new Guid("41b8bccf-b0d0-4708-b538-ee56cde49fe3"), null },
                    { new Guid("41fe30c7-c6e0-4925-8aae-446b2c736ed0"), null },
                    { new Guid("443e5850-fceb-42d0-964f-15e34f5b45c4"), null },
                    { new Guid("44c91d5a-7933-4330-a632-e08f50c70136"), null },
                    { new Guid("44d5f412-ef46-4734-8a59-b7dc63343876"), null },
                    { new Guid("453c56bf-ec06-4f3a-99e5-73455f0834dd"), null },
                    { new Guid("46e08432-9754-4d01-ba41-54068e271e2f"), null },
                    { new Guid("4775b212-cbc1-4602-8545-4ad5ad1b2ec0"), null },
                    { new Guid("48a0299b-6621-40d4-b84d-e9ba9b5abc9b"), null },
                    { new Guid("490c6dbc-3fd8-4d7f-95f0-99221aea0214"), null },
                    { new Guid("4b8a6e93-0a76-400b-b4dc-102b131e994f"), null },
                    { new Guid("4ba9bb5e-3eab-4d1b-8051-8320f79761ac"), null },
                    { new Guid("4bc155db-69fd-4245-a738-0db024116c5f"), null },
                    { new Guid("4d23acab-169d-411e-b15d-9f9bbefd3607"), null },
                    { new Guid("4d4e2e9a-fc4c-400a-b725-de5547e4ea9e"), null },
                    { new Guid("4ed74c5e-90e6-4231-84ca-1bd6d3a20c6e"), null },
                    { new Guid("503fe743-c681-47ee-a1b8-7da0c6ab8616"), null },
                    { new Guid("51c05c3a-1ee6-4600-8ccf-a4e852d03d19"), null },
                    { new Guid("5396582a-7256-4319-a5ff-6b59110526ff"), null },
                    { new Guid("54081509-ba88-4a54-b6d7-154f4e8c1c41"), null },
                    { new Guid("55476c0c-6539-4359-a0a8-a5ae124f63e0"), null },
                    { new Guid("55def556-0940-433d-96f2-1a5e95d983c0"), null },
                    { new Guid("56819dc3-ea9a-42d6-b919-ffd2a904cd5c"), null },
                    { new Guid("56d2d550-7c8b-42b0-a889-46a651bda589"), null },
                    { new Guid("57135ba2-6275-45e7-86a7-44b2ffb4b734"), null },
                    { new Guid("57d23f92-f675-4766-8601-2cd96eac2975"), null },
                    { new Guid("59ec43c5-6fb8-4064-b4f8-89d3320bc1a9"), null },
                    { new Guid("5a26a5d0-3325-401a-8cbb-5b634baaee98"), null },
                    { new Guid("5a72f36d-e440-4c71-ad6c-c42c50432557"), null },
                    { new Guid("5ac949f5-a633-429f-a503-1a23a1c1898e"), null },
                    { new Guid("5ad7fa49-9797-499d-b9b4-a73ff589b959"), null },
                    { new Guid("5b77835f-d97f-42da-af79-991a04e88829"), null },
                    { new Guid("5be68f0f-c05e-4e79-bff2-f1892d5f968b"), null },
                    { new Guid("5cd1608e-3f02-44f6-a909-f440364323a9"), null },
                    { new Guid("5dc08b3e-0af0-411e-9ec2-f43db7c803c6"), null },
                    { new Guid("5e5a462b-7ae2-4990-a41e-02154a481083"), null },
                    { new Guid("5e904aa2-2d6e-4829-88fd-4331b31cef76"), null },
                    { new Guid("5fb3bf91-9665-446d-9c82-fc91370bbf43"), null },
                    { new Guid("5fdc3430-5fba-4d46-b43d-8c1f34700497"), null },
                    { new Guid("6065a6ce-32cb-4b49-a5aa-b304a9d8b39c"), null },
                    { new Guid("61247ec3-f964-435a-9241-9f29991a4b84"), null },
                    { new Guid("616c9c2c-8c37-484f-b21e-5bac754dd06d"), null },
                    { new Guid("61cc5a7c-e76a-4a1c-b8fe-2a105e0fa348"), null },
                    { new Guid("64854252-1b37-434f-8342-94af068b8cb6"), null },
                    { new Guid("65713ea3-7a5b-4d27-9dc9-afc15a5b1594"), null },
                    { new Guid("65b96311-528e-463f-a7c0-e7ea3a8f6040"), null },
                    { new Guid("65d03a02-183c-44f4-b669-bd03701fb271"), null },
                    { new Guid("66186be4-79a7-4e21-a757-a1aaa7b78622"), null },
                    { new Guid("66e3ea3f-3608-4417-a991-32e268d6a9f7"), null },
                    { new Guid("6774f9d0-153f-40a8-93e5-fbb9ede1cdfd"), null },
                    { new Guid("6835df51-4407-4052-84ec-b6019ce88a35"), null },
                    { new Guid("6855aad3-ffe6-4d7e-8093-2ddf30e1be6f"), null },
                    { new Guid("686e5b84-c91c-4152-9118-a60cab6d760d"), null },
                    { new Guid("6a0dd354-f52b-4224-b8c6-65392acd4f0a"), null },
                    { new Guid("6a90a588-4435-49bf-b72c-93182a03d886"), null },
                    { new Guid("6bc32e0d-d1c5-4590-ad03-3b85469fce1a"), null },
                    { new Guid("6c48182c-ba9e-434b-8350-26152afaa256"), null },
                    { new Guid("6c71337e-e6b0-4dc5-9119-359c95b49805"), null },
                    { new Guid("6d90edcc-2b11-4eb6-823d-193c69cc300f"), null },
                    { new Guid("6db161d4-24cd-428e-9119-30d41d052171"), null },
                    { new Guid("6f5077b0-1a35-4922-806d-d5ad22cf58aa"), null },
                    { new Guid("6f8a3580-b8d0-4b19-abb5-cce51de765de"), null },
                    { new Guid("72328438-15fb-448f-aa3c-299a2d1268c1"), null },
                    { new Guid("72fbee82-5918-4f12-a2a4-d377ed83ef71"), null },
                    { new Guid("747e5d60-5387-4725-afac-ae1a2cf0b6b5"), null },
                    { new Guid("7486efd4-2180-44af-8f82-c47fa0cb1119"), null },
                    { new Guid("75014f39-c8cc-48fa-9662-fed1f3fe2b89"), null },
                    { new Guid("75a3152a-be9f-4269-a813-2dc4e4c28cd3"), null },
                    { new Guid("76258178-e95c-4ba2-8a16-a1f92df29394"), null },
                    { new Guid("76296426-56cd-499c-a39f-9ebfbc5b6844"), null },
                    { new Guid("7708e2c1-69ac-4d0f-868a-9745401180dd"), null },
                    { new Guid("79168535-6f59-4df2-838e-13add6eebe6c"), null },
                    { new Guid("7ab47f95-1f6e-4719-ab69-58a5a3deba91"), null },
                    { new Guid("7b3bd50c-e182-47b3-b7a5-f77d8f9484c1"), null },
                    { new Guid("7b8e577f-7e5d-4ff0-970a-4c36d8ee36b6"), null },
                    { new Guid("7ba12057-db30-4244-b454-c27989cc4f2c"), null },
                    { new Guid("7d030045-11f0-4d0d-a1fa-f5f86018f29f"), null },
                    { new Guid("7d2959df-0727-46be-ab77-2df9beba17e3"), null },
                    { new Guid("7e8af4d3-b2a0-4ad2-95c2-b4ee78d935d1"), null },
                    { new Guid("80571f8a-df22-4371-9e04-31255c229386"), null },
                    { new Guid("81e38cc0-230d-4122-92a6-dac68965c0b2"), null },
                    { new Guid("82a39b92-1116-4b4e-a249-f4bcac43234e"), null },
                    { new Guid("82c12e0e-c76d-4d78-aa4c-5021cbcbb65a"), null },
                    { new Guid("8340ba22-33f6-4dc3-baae-3e1c8f1b069b"), null },
                    { new Guid("847beab2-ccab-47be-ba89-ea19024ab468"), null },
                    { new Guid("85f08b24-be6e-41cc-b09c-5f30ee488b8e"), null },
                    { new Guid("867e883d-83a0-41c2-8971-82af2ee799cb"), null },
                    { new Guid("875372ee-f762-42bb-8672-cc908aecfd14"), null },
                    { new Guid("87f9efbc-b97f-4089-83fb-4840e4d630a8"), null },
                    { new Guid("880f880d-4c14-492e-939a-1acc344158ee"), null },
                    { new Guid("88ee8d91-c548-426c-a410-c8248e534bc9"), null },
                    { new Guid("89f1941f-6910-4b53-bfb1-457786b12c72"), null },
                    { new Guid("8c736d7f-3071-4c2b-8739-4e7f60e27232"), null },
                    { new Guid("8c804458-c2da-4319-8dae-fa841830f512"), null },
                    { new Guid("8cfea05c-8699-4314-ac24-53037885fa2d"), null },
                    { new Guid("8da37d4b-ff01-47de-be12-eb00fb07ebf2"), null },
                    { new Guid("8ea1a07d-d0cc-4fcb-a0f6-5bc94e1916cb"), null },
                    { new Guid("8fb14fc5-e0db-426e-99a2-9ce9e68d6c1b"), null },
                    { new Guid("8fc83843-bedc-4e23-a394-4eaac40d8f9b"), null },
                    { new Guid("8fecd7d7-4020-4d0d-abb6-1372630b7695"), null },
                    { new Guid("90746d1f-11f8-4d0c-8e56-2899e55be5bc"), null },
                    { new Guid("94b6ac05-9453-44ee-840e-80a4686fb194"), null },
                    { new Guid("9576950b-b63b-4510-9265-12e119489e8d"), null },
                    { new Guid("95e94b5f-6d65-4bd2-8a5f-1fec5bc99cdb"), null },
                    { new Guid("963e9487-507d-436c-b163-923e3e8c9a39"), null },
                    { new Guid("97d42393-57dc-48f0-8cf3-1beb5e542309"), null },
                    { new Guid("98d1f8eb-2b54-49f5-a0e9-b64e7265d96f"), null },
                    { new Guid("99a68dc1-a487-4144-9065-4ccbc19d180f"), null },
                    { new Guid("9aa72f35-fff5-4f19-9a58-77968fe1b329"), null },
                    { new Guid("9b153db0-7a1e-4651-9ebf-f01c9e4bba9b"), null },
                    { new Guid("9c2f3a70-77fe-48e0-8f40-04452373f6e1"), null },
                    { new Guid("9cbd5a04-6a15-4e53-ae70-968d20cc1956"), null },
                    { new Guid("9cd6db03-5f85-4aab-8d12-b7e51c35c2a8"), null },
                    { new Guid("9da58814-fc32-47db-89ee-e1ec4ffdc077"), null },
                    { new Guid("a04174c8-42f7-4fe7-aa8d-9b5bf36e8e17"), null },
                    { new Guid("a240cd24-5555-4350-8bc6-d9f78a3a8749"), null },
                    { new Guid("a372481d-9f01-4d6d-bf6b-d9e496ae2ebf"), null },
                    { new Guid("a5ce978b-96e1-47b0-9c3f-6c28148affa8"), null },
                    { new Guid("a76ae727-1ae4-489d-9a3e-2459ed3e567f"), null },
                    { new Guid("a845a994-b31d-42da-acea-74425a7a84f2"), null },
                    { new Guid("a9501f51-536a-45f5-9bb0-31bc724d8adb"), null },
                    { new Guid("aa1145e9-39f0-4669-b9f8-b66926be8b24"), null },
                    { new Guid("aa243e65-18b6-4767-ba69-bed8fc00e918"), null },
                    { new Guid("abfef4a0-e3ce-4ec7-827b-4deb994159f7"), null },
                    { new Guid("ad65f893-17f8-4bee-addc-76345c15697b"), null },
                    { new Guid("ad68f905-b109-4822-8dc7-934756a5032b"), null },
                    { new Guid("afba043a-38ac-4083-882a-a47da7524bd5"), null },
                    { new Guid("b02c37ac-ffd5-44b7-ac8b-7d2cf82d503f"), null },
                    { new Guid("b044fcb4-1740-4bce-b1f6-c3d7050376df"), null },
                    { new Guid("b0b08230-6535-4f78-9a2b-1a58f89d2350"), null },
                    { new Guid("b32b7493-f79e-4c9b-98eb-977306439c5b"), null },
                    { new Guid("b384ffc0-beb6-47bc-9533-82684b0f1ac7"), null },
                    { new Guid("b511c7da-2998-4b04-943d-876734422e4e"), null },
                    { new Guid("b6722f8b-cb2e-43c9-b1cc-2066ff0e7d62"), null },
                    { new Guid("b712ab55-4823-4297-9e27-2b86e7a3619a"), null },
                    { new Guid("b7ba8499-a6d6-4645-a854-641ab4683407"), null },
                    { new Guid("b9a0c1fe-5540-4cae-92d8-a9982ae3c171"), null },
                    { new Guid("b9c02476-19fe-4209-bfb4-9cc49f403232"), null },
                    { new Guid("bac6ddac-71bf-4eb1-a471-1e7dfb6abb75"), null },
                    { new Guid("baf408ec-22c0-4fa8-a0ab-151980e057eb"), null },
                    { new Guid("bb9ffc89-c5b6-4d5d-a7b2-4a60c0d86861"), null },
                    { new Guid("be619ea0-16c6-4173-be51-985da8858a35"), null },
                    { new Guid("c02f938b-7fc8-4d5f-bd60-ad8d6bd99f43"), null },
                    { new Guid("c288a69d-41f0-42e2-9f1f-1cfe76cb6616"), null },
                    { new Guid("c2a6831d-f464-4e46-8813-76bf64d67aa0"), null },
                    { new Guid("c2ea5893-9f0f-4ba3-b096-a145541f02ee"), null },
                    { new Guid("c38a9655-a3dd-4c64-8ae5-89f3d2276f87"), null },
                    { new Guid("c40dc40b-2273-451c-884f-112dea596db7"), null },
                    { new Guid("c452c1c6-ae6b-4020-84ed-7a9324140d6e"), null },
                    { new Guid("c48c99a9-bc2d-4d4b-a902-b7e86e0a4951"), null },
                    { new Guid("c76ee0b5-26ff-460e-a622-9001a7c4e1c8"), null },
                    { new Guid("c797cf38-3186-469c-8155-e36c22d044d0"), null },
                    { new Guid("c8243a7a-6f0a-46e7-b592-577555473186"), null },
                    { new Guid("c8cd92aa-1c29-4ba0-995d-cbca468ff9ea"), null },
                    { new Guid("c93b3f51-87ee-4810-9dfb-5ba6bb01cfc4"), null },
                    { new Guid("c9aeb37a-d557-4c86-8c02-35e21934c722"), null },
                    { new Guid("ca176e21-30bf-4ce9-8dba-7cc425b12dd1"), null },
                    { new Guid("caa40b1d-fa7d-4190-b910-12f4eaa6a891"), null },
                    { new Guid("cadb7fe4-cdd8-4f61-9231-cd438727db55"), null },
                    { new Guid("cae52c8a-755f-44d1-9a34-52eaecefef36"), null },
                    { new Guid("cb1b40be-6b95-40ff-ad38-1b6d59a6088f"), null },
                    { new Guid("cb97d3c1-b1a6-4054-96ef-8fb78a35d271"), null },
                    { new Guid("cce4ae5c-0cf8-48a4-baf2-c1815e57b8d0"), null },
                    { new Guid("cd823fb8-24a7-40c9-a085-d206bafc44ed"), null },
                    { new Guid("cd957506-9b00-4730-8c6e-71482ff9194a"), null },
                    { new Guid("ce559b3d-0925-452a-85a6-b4a4683c633c"), null },
                    { new Guid("cefc593c-e347-4bce-b077-3dd9059d174d"), null },
                    { new Guid("cff1f908-7fbe-4887-9c1b-f7023223b37b"), null },
                    { new Guid("d0c94635-49ea-4639-9742-1ca85276315d"), null },
                    { new Guid("d125a6d2-87ad-480c-ad2d-72d292b7845b"), null },
                    { new Guid("d257cc22-47e7-4941-b9c9-166d258e14bd"), null },
                    { new Guid("d2771db6-d566-45be-8c17-80642a4b9e92"), null },
                    { new Guid("d39d3fa8-0b15-40ee-bea7-cd63f20220fa"), null },
                    { new Guid("d41a9137-bd89-4f57-907f-24fe5df0138d"), null },
                    { new Guid("d49d695c-0082-47ea-b6bf-c0c73a8743f4"), null },
                    { new Guid("d4e99ca3-3d52-4ef2-a514-b1334be459c4"), null },
                    { new Guid("d5883121-8fe3-4a91-9592-f56acfb1fae5"), null },
                    { new Guid("d6b74edf-19e6-420e-b6ec-036b9afc9e8d"), null },
                    { new Guid("d8c7f3b2-c7d1-4a8b-a8e3-7281f75dac60"), null },
                    { new Guid("d8d197f9-0d92-4d3a-80cc-ffd9d7205bac"), null },
                    { new Guid("d994c52d-c011-41d9-ad8e-3186f565a1d7"), null },
                    { new Guid("d9cdef95-59b5-40c4-be9d-f7e239f2dfb3"), null },
                    { new Guid("da06f286-3ca4-4fcb-ad4c-462c4c52ed86"), null },
                    { new Guid("da80ebff-d372-45a0-b9da-d79c0617b247"), null },
                    { new Guid("dcd43795-96c9-4141-a6f7-ecd9e4ab6da8"), null },
                    { new Guid("dd85773d-8d0f-4dd4-a9ff-a8718bcf042a"), null },
                    { new Guid("deb9ef20-5039-4d6d-a548-33a2d771b7e1"), null },
                    { new Guid("decb30c7-e01b-4a0c-b5c2-6fc283f556e8"), null },
                    { new Guid("df7e2672-1888-4134-b644-a1594e71d060"), null },
                    { new Guid("e0b90f61-673c-4326-bf6d-b0ec109d6cab"), null },
                    { new Guid("e10da1a3-becc-4877-b4e9-2b8bbe809684"), null },
                    { new Guid("e1af883f-365f-4a9b-a0db-b8f6b501b351"), null },
                    { new Guid("e2a77b25-378e-4b41-9641-f59f5dd63c2e"), null },
                    { new Guid("e2aed87a-c62d-4312-bcfc-a7da679a3ed7"), null },
                    { new Guid("e3749504-5967-4311-a370-19b8fff80be0"), null },
                    { new Guid("e52ea395-7a20-42c1-bce8-109afda31aa8"), null },
                    { new Guid("e8f766a0-5fc2-41fb-8bc4-a1651eeab987"), null },
                    { new Guid("e996dcf2-b2de-4471-b4a6-41f94fc76eb9"), null },
                    { new Guid("ea89f648-5491-44a8-bdf2-3e327f0161ce"), null },
                    { new Guid("ebd0f6ed-7264-4345-86a4-0f417c6212d8"), null },
                    { new Guid("ec688798-3e7e-4f51-9dcf-bd41df82c684"), null },
                    { new Guid("ee6db7bb-cd6b-45c5-9db0-2d85a28545d4"), null },
                    { new Guid("f0082c12-d57c-4f24-812f-28da844f6d4f"), null },
                    { new Guid("f0b995b1-1bd3-47ef-8a0d-d46356e55626"), null },
                    { new Guid("f0df1a4c-1b03-4200-9069-99f6b3dec160"), null },
                    { new Guid("f17be757-3264-4bd8-a5ac-000fd6d4b0e3"), null },
                    { new Guid("f1ea90af-6c34-47e4-bcd9-7944bdfb49c4"), null },
                    { new Guid("f2bdf65f-cea2-4752-85c1-bfc3724aae23"), null },
                    { new Guid("f3b5a7cf-e807-41fe-af9e-50c41d3edc0d"), null },
                    { new Guid("f4550f45-257f-455b-86b6-cf07403c7670"), null },
                    { new Guid("f5598ef3-b122-4c9a-bb25-74141eccdcb9"), null },
                    { new Guid("f5617a49-4534-447d-b782-cbe8fac06892"), null },
                    { new Guid("f73af884-3192-4dc6-b9f4-8f3c7e0d9cf8"), null },
                    { new Guid("f994a944-8b76-4d71-8c36-9b30e7096732"), null },
                    { new Guid("f9fbc680-8745-41b7-b3df-822bf9aaf9b0"), null },
                    { new Guid("fa6e99b4-0f43-4bad-ade2-b2b9b63c2242"), null },
                    { new Guid("fa7b2fe9-df0f-495f-a908-30fbf8e7cafb"), null },
                    { new Guid("fa8e6307-aaf8-4be6-8964-61bcc71bdd9a"), null },
                    { new Guid("fbb588fb-6cbb-4530-b2fd-cead8ab69f62"), null },
                    { new Guid("fc58cb90-3469-4cc3-99a4-cd1b0aa64c51"), null },
                    { new Guid("fd3dabcc-66ad-4f30-99a1-d24dac80e306"), null },
                    { new Guid("fe8c3ff5-ef99-408c-bbb0-2148dfea59bb"), null }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "DisciplineId", "RequestedHoursPerWeek", "SubjectTypeId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("00a019a4-027c-4fe9-82f8-92669be4d1ba"), new Guid("9cd642fd-155a-4218-8c6e-d72baf0449d1"), 2, new Guid("1647392f-227b-4dc6-bb89-3f57860078b8"), new Guid("256fd2d3-319e-48ca-b3f0-a95a76544b91") },
                    { new Guid("00a269e0-695b-4bbd-962b-523e97381838"), new Guid("3565139c-aa75-4dbf-b08b-1adaf6b59273"), 5, new Guid("1021ac9e-f700-49e3-8306-33b032ae255e"), new Guid("7678aef6-bf7a-45f7-b4e5-b2b07c0051ee") },
                    { new Guid("0167a1ad-8c8e-4487-8cc8-dc9a7ce2913a"), new Guid("ce23f60f-dd90-408d-9e89-6352987974ff"), 1, new Guid("4c3aa285-8c83-4fe8-96e9-196e1198a37f"), new Guid("211e6374-2c4f-4db2-aa35-c51ac9077f05") },
                    { new Guid("01a87e32-ca1c-4432-a3fb-a6705fbb1cb1"), new Guid("82a4dc93-d5bf-45c6-a9dc-6e9ac80787ca"), 1, new Guid("8d3067c4-984c-4722-8292-5e011bf9e3db"), new Guid("f2bff140-099d-4fce-b5b8-dcf61f034d60") },
                    { new Guid("01dd8510-a265-47c8-b9f0-892e0fa2b8cc"), new Guid("30e51618-5e50-498e-b5b9-9d8939cafab5"), 3, new Guid("36315933-43fd-4f9e-9b51-0d9ba2bf58d3"), new Guid("d2721c9f-6077-4dc4-872a-08e8b07f39a7") },
                    { new Guid("02964334-1c98-435e-b99c-566f33efb03f"), new Guid("7130502a-2401-4351-a086-8166afd81dd6"), 2, new Guid("69f5c7d3-b77c-4c55-bb2e-093b338abb67"), new Guid("8881d867-de22-48c0-8089-630b1c0ae0df") },
                    { new Guid("030c1cf5-48ca-4893-b767-1b3e2a625e05"), new Guid("53f7f602-23fe-420c-9d93-50cd84eb88c5"), 2, new Guid("ce400d5b-2268-4666-9d39-13373a74274d"), new Guid("94dd28af-3234-4a9b-98fc-c252266b50b5") },
                    { new Guid("046396b9-5df1-4fd7-9f6d-b84ef81975c4"), new Guid("dc392a81-c8bf-49b6-a4b4-26248978aae3"), 1, new Guid("9b94f421-1807-43d8-bb5a-02830af9caef"), new Guid("31b354ad-d368-4921-a11b-d0c2572f07c8") },
                    { new Guid("0590458d-4e5b-4909-9d45-30c705a4e38b"), new Guid("f5815dfd-fce7-4959-8f7b-847e9b0ba9f8"), 4, new Guid("1e156658-b1cd-474d-93f9-cd8412a7b55e"), new Guid("936ae074-5f9f-4313-96cc-aae9a92b777a") },
                    { new Guid("078fcbe7-943b-4481-b356-d674e39b22b0"), new Guid("ce5e35c8-d398-4422-ace8-91cdd17a3cad"), 2, new Guid("1d247835-baa2-4e3c-ae1c-868b62171f6c"), new Guid("40cfb917-ca3d-48f7-8866-c25f488b6eb3") },
                    { new Guid("07a90d69-f937-4cf1-b123-01b7983ae787"), new Guid("d32348ad-a489-4ace-a283-191cbcca4327"), 5, new Guid("14501512-a167-4d0e-b90c-53f5949fc62f"), new Guid("69f648ec-2dae-4b81-b7e2-be17d0f0419a") },
                    { new Guid("0a2c84c9-4a54-4768-88a1-653bf9046ed7"), new Guid("11b9c42d-6085-4fac-a4fa-71a1091b1e73"), 5, new Guid("0753ce97-343f-467a-89f4-1affaccaddb0"), new Guid("1febe3d3-2c1c-4b55-a200-de8d9504f065") },
                    { new Guid("0ba0f4c2-77c2-4891-9fed-903e12967a0a"), new Guid("23b11bc5-ea8d-45c9-9fba-b937f0dc36a3"), 3, new Guid("9245f182-af00-4940-9256-cb72e1085034"), new Guid("d7c564c3-6597-459c-a44f-ac0d23360f2f") },
                    { new Guid("0ca1a578-367b-4fca-954c-1f6d9837173c"), new Guid("698d909f-d0b5-47bd-b78c-5df7fdb3a321"), 4, new Guid("2b9d5cfb-a0bd-455e-a678-cc8033a91a27"), new Guid("f7e1d8ce-ef48-4156-b587-04c179c27746") },
                    { new Guid("0cb9638f-e51a-4ffd-813c-6bf9d1f3662c"), new Guid("2d92a47f-6e3e-4682-b87f-ee60d579c45d"), 1, new Guid("9f4d1500-94ae-4087-bfd3-b28a9685d96d"), new Guid("c350351b-7186-48d3-983c-234a48980463") },
                    { new Guid("0d05d766-c5a5-46d2-9fee-1d1bd7267678"), new Guid("25983a87-46de-49b0-b032-77e5706cdf03"), 1, new Guid("f3e57a50-be2d-4c4f-8b55-a6f09a444184"), new Guid("20d76bb1-6106-4830-ab6e-8ff20561bc70") },
                    { new Guid("0f00eec6-8362-4920-a0d5-bf5d9b08bc8d"), new Guid("a2ba5c7f-fdf9-45b5-85ae-53ce353b238b"), 4, new Guid("0494e1cc-0759-4d19-8ea0-374915b6db41"), new Guid("ab19b4e4-74c3-4fa5-ac4c-4c3b28e4c9bb") },
                    { new Guid("0ff302de-9074-45ea-8650-6ef046057756"), new Guid("cda5fd4b-38ec-48fd-a94e-7d475c09e9a4"), 3, new Guid("74aaeae6-e416-4a84-a4ce-4dadb5b1d621"), new Guid("fb44ed86-2632-439d-8fec-580c7288d0b5") },
                    { new Guid("1089c444-89c2-49e1-8e31-237773b4bbdb"), new Guid("cb7e94ec-c4d7-4c6a-8f52-0452ab28d08e"), 1, new Guid("00bda393-e39d-4b8d-b153-7cff4a868f42"), new Guid("3cac2bad-f340-48f3-a3c2-ca71779c0fff") },
                    { new Guid("14099075-f935-48c1-a94c-c1348dfd4243"), new Guid("d090fc18-967c-4fc9-8954-da29dd1fa325"), 1, new Guid("34d28886-c86b-4665-ac00-4401ff93b8b0"), new Guid("5fbe59c4-24b5-4353-b792-f5682c0f0697") },
                    { new Guid("1460cdf0-0472-41fe-8d74-5035e4c9d775"), new Guid("fd62ec6a-e0f5-4c4f-9d13-021265be75d0"), 5, new Guid("82254d93-21de-4715-a122-7eff19ce2049"), new Guid("509a254e-3a08-40fc-870b-8acbd1e408c6") },
                    { new Guid("1544f60d-cbfc-429b-8f6e-1f28029134dc"), new Guid("92c18385-be92-436c-a2a5-301f641945e9"), 5, new Guid("b8461b3b-2728-4e65-9314-be620fa24c04"), new Guid("a4efc653-f691-4bb5-8545-f53df5d84565") },
                    { new Guid("15cd6a94-b0fc-4ed9-8e3c-6632004b05ee"), new Guid("0762580b-5831-4d1d-bd99-ac4eb69f3da5"), 1, new Guid("ae61160d-948b-447c-829b-2e3367e07cdf"), new Guid("059badcd-e8d8-4eb8-b200-a72cf6e721aa") },
                    { new Guid("1676f974-7e6c-456a-be87-c0606e6a117d"), new Guid("2d53bee1-5aa2-441b-85a0-ebed93dbc52d"), 3, new Guid("87c1aac4-802b-499b-99ce-9268236a1a17"), new Guid("37d20078-734a-4bad-9266-ff303f4d5357") },
                    { new Guid("18d48ee3-468d-42dc-a29b-40ee0afc9406"), new Guid("23d55fe8-9b7b-4e61-a094-85fe63c0be87"), 5, new Guid("c8644cb1-04f1-4423-bba8-72e2e18460bd"), new Guid("081d3e81-975a-4eff-a562-0f54d2933264") },
                    { new Guid("19171c23-1e58-40e2-ac0f-e6d66941f057"), new Guid("b4c30ffa-38ad-41d7-8106-44cb70ef2278"), 3, new Guid("a85a3328-74f9-47ff-9c3a-e94c8054b93b"), new Guid("1b4a3431-3add-48fd-b81d-309898e3ca78") },
                    { new Guid("195048ec-e7a7-42c2-a6a6-19af598bc581"), new Guid("bc8e75cc-b487-4838-b09e-22864cb417eb"), 5, new Guid("ee0a9f1e-3337-4db9-9e2b-3e28ea3d13d3"), new Guid("a150327e-b1e6-4250-b4b2-e29aaa5d573e") },
                    { new Guid("195ac85a-fa25-40db-a58a-6f39a1d65b73"), new Guid("215156a3-4158-4804-a900-ced820595ce0"), 2, new Guid("c645c8d2-724a-4d4a-9dba-d78e387f67f9"), new Guid("1c1be71c-07f9-49f9-b030-3c22af005473") },
                    { new Guid("19adeea2-9f6d-4192-afe4-8af3a6da06af"), new Guid("dbfd8939-1df2-4762-b37b-1932e9cf0759"), 2, new Guid("09b94881-8120-478b-be3b-6d7f5318cb72"), new Guid("b4b81b97-5fee-40f3-bbac-b6a36522ac09") },
                    { new Guid("1c6d8319-9dbf-47df-993d-be839c332ee4"), new Guid("b3b7cc4d-92b3-4e7a-a275-9aecb8397a9d"), 1, new Guid("ea84e0b9-b842-45b0-9489-22f4c19d50cd"), new Guid("29f99902-bc42-4eac-92c0-46a441d7228a") },
                    { new Guid("1ccfd9df-5e24-4554-8cb5-a3036f85d854"), new Guid("5de1d4e6-d203-44d6-824c-91e8dfa1a03d"), 5, new Guid("565cc377-d694-4cb8-b646-7de2e0cfd8bc"), new Guid("21ef7ecd-33f0-43a6-8571-4004e36a3a75") },
                    { new Guid("1d4dc608-8e58-44a9-a1ba-75d9a117874a"), new Guid("cb333312-c9e0-4176-a330-fbb0e98decb3"), 2, new Guid("712ff007-3fc0-4f30-a001-a856a44eedcb"), new Guid("db2fa57c-e3ae-424b-b216-8d702c6fbb72") },
                    { new Guid("1f512176-db86-4bfe-b80f-a3540619179b"), new Guid("99c4f4d6-460d-4eab-92ba-e1c8cd926a56"), 3, new Guid("2913efce-d333-458a-8fab-47fe013ebb4f"), new Guid("76f4f7a3-a0b3-43f9-9b7a-dc604d310a92") },
                    { new Guid("1fbb0c15-5c65-4723-8668-1f29b76f6db6"), new Guid("c001f8a1-c2f5-48c9-8d2a-bc7cb2005bae"), 3, new Guid("bc28285c-3227-41ca-bbc2-c64809d044a3"), new Guid("c4aea402-3875-4c7e-b909-fa7d78b03b64") },
                    { new Guid("1fe1633c-a4aa-425e-9d32-12bdd6640561"), new Guid("d38889b5-5725-4e80-9f7f-57879ac4d7df"), 4, new Guid("d83a828f-f61b-4f0c-a68a-221043ac97ec"), new Guid("2b12fc41-884f-49a8-894a-04047801b2c3") },
                    { new Guid("1ff41738-1a8a-4b9a-aab7-75ab6ff026b0"), new Guid("f194a15e-13bf-4783-81e0-d5ee5ffc0238"), 3, new Guid("f25c4a16-617b-49fd-93e5-ce1768b4dcc5"), new Guid("688d015f-fbf7-4aac-9c1f-657f3e168ad0") },
                    { new Guid("21a8e091-fa75-4dbe-abdb-104a9b398538"), new Guid("4d59d8ff-64b0-48db-a0b9-b4611b24e751"), 3, new Guid("54ef01c7-228a-4e30-a596-e40e85199bd8"), new Guid("46d0fdba-027d-4216-a9e1-40aa51467f18") },
                    { new Guid("223b3527-20ce-42f7-b231-c5f3e68b790e"), new Guid("8041bac2-11a4-4cc4-af30-5a22c74e2897"), 2, new Guid("29e65aa8-d146-419d-944b-1b37b75a9932"), new Guid("b4efaa1d-f0d8-420b-9803-83e810515c1d") },
                    { new Guid("238ccde9-3991-48b3-876b-a0b6020fb426"), new Guid("28d3652d-6631-4a7e-9d21-0fb4011ec83b"), 1, new Guid("5fa7c825-6e71-4ac6-af2f-ab783534da9f"), new Guid("02ed3184-73ef-4cee-ae24-d5d331e76844") },
                    { new Guid("2599fe6c-4228-4621-a8ac-41894cee75ed"), new Guid("2cbd1a32-481b-45b5-a31b-42a6848ff1d1"), 2, new Guid("e66a89b2-cb0c-4d13-b0e2-7c2484da3979"), new Guid("2dcc38b9-8e16-414f-9820-491dc45f182c") },
                    { new Guid("2661a04b-369c-4208-b57b-d33f5376d68c"), new Guid("47ccea91-1436-44f7-9497-704e3fa4b598"), 4, new Guid("e2cba895-3e56-4339-bd31-31df7dc33a5a"), new Guid("07cf35e2-0b9e-4924-85c0-228b5e626fe5") },
                    { new Guid("271e3a2c-81ba-4720-b3fb-adb22e4de15f"), new Guid("1bf1464c-1df0-4f07-bde8-67d5235968e8"), 1, new Guid("30c0d026-2e43-45e6-95ef-8d9c61c3633e"), new Guid("cafe538c-6de1-41ab-b1c2-89404bf63efd") },
                    { new Guid("28b20f69-2038-408b-b21e-1447e6f43772"), new Guid("672f1749-3e4d-47b8-8fef-7b83ac62885a"), 3, new Guid("3366f0a3-dcc4-4c67-8c78-f28ec8e27602"), new Guid("e37f74f4-0cbc-4bcd-951b-62c81af18ea7") },
                    { new Guid("2984e81a-30cc-46e4-a7a6-560e21e71f8b"), new Guid("88455f06-f654-495d-a039-2d8e9e56415b"), 5, new Guid("201245a0-f590-4ab3-adf4-0e8e8edb9cba"), new Guid("ede499d7-b413-413b-a8ee-80831f653ff9") },
                    { new Guid("29def353-605a-4b32-a0a5-2296ec5d6ccb"), new Guid("d824ea6e-a342-45d1-9638-3ecb8b3e08f6"), 5, new Guid("61d2450d-29de-4a1c-a4ac-9a3859c6c783"), new Guid("d1659e30-87d2-4d68-a955-f6b4ecc5e458") },
                    { new Guid("2aebe351-d536-477a-a9d3-4548147acb2c"), new Guid("bab52557-d21b-4175-a3e5-75a526749e9d"), 1, new Guid("48bf2adc-a0d1-44db-b238-64c6b6e045df"), new Guid("d9c2e982-66b0-4c36-91ee-e60ee2278cd5") },
                    { new Guid("2c2f5243-f65b-46f4-998a-69fc754e8a2c"), new Guid("5ccbda30-c30b-481f-bb0d-37373b417f1a"), 1, new Guid("4a981049-43a4-4cfc-889a-326f003952e7"), new Guid("6ff6a803-5477-4d94-90c6-85f4823d1de4") },
                    { new Guid("2ca871b6-7612-4ea5-b45f-7f7ecb2be7d7"), new Guid("34ef45e2-af34-479f-bc08-09425afc2597"), 1, new Guid("731bc86e-2308-4c42-92d1-98c9ec9e3689"), new Guid("b522332c-2cce-4804-85be-b17324c06648") },
                    { new Guid("2d166a85-901f-4e76-9b83-3b678d322810"), new Guid("fbdc8004-5b77-4269-ae09-3bf5844ddd85"), 2, new Guid("260d90eb-545e-493e-a837-a39acd62e21f"), new Guid("fb22cdb8-dd8e-432e-b233-f61ab493f1ca") },
                    { new Guid("2fa8d356-29c6-4f89-865c-244dc6f78889"), new Guid("f1d20e63-93d4-4d2c-8209-3bb8739195c3"), 4, new Guid("bf5da6b0-43c7-4afe-aad2-8cbcdd48d3b9"), new Guid("ff621a8f-e39f-4913-ba23-d9bad14d30ab") },
                    { new Guid("3075a0a1-ef04-40db-b006-a0463b1e1348"), new Guid("51710b70-a568-4d7d-a56a-c3d00a3e0deb"), 3, new Guid("3364a368-ccf0-4e0b-9bd5-1b6abe304ab5"), new Guid("7df90c49-9b52-4e4d-b605-1b8d41dccd93") },
                    { new Guid("31216b6b-399f-4f74-be14-71de6483bb6b"), new Guid("fa84dfb6-6e97-464e-992d-9531cc7052b1"), 1, new Guid("df976f78-fb04-40a5-9c89-5f10443c5a81"), new Guid("b235fa38-d696-42f1-a5d1-2f84d23f8724") },
                    { new Guid("316d18c5-0714-4f5f-8e83-f13295016f79"), new Guid("75a99844-cab0-4a34-8917-b3a7a378df5b"), 1, new Guid("f8a72b9e-ec5e-41a0-922f-394004677b5c"), new Guid("3c2ac3d6-16b4-4c6d-9706-2fb0ba1967c6") },
                    { new Guid("31b34397-b626-4e31-ab43-61529f13a549"), new Guid("7801631a-f9f0-40ae-a417-081dd8dad1ca"), 2, new Guid("37b6eac0-2adc-4bf4-bb33-65092e6ed3af"), new Guid("5df058d3-b261-4ead-8ef5-3b6a59fcd83d") },
                    { new Guid("34b89a0c-6ab7-4c23-a295-8a93ffb7e01f"), new Guid("cfcee04c-40ef-44f6-9c9a-12321bfcab72"), 2, new Guid("eb1dcf3c-5358-47a9-a0a9-a962fa6ed463"), new Guid("e5285b59-2abc-43ed-907e-bbf1bededf1b") },
                    { new Guid("34d7f666-a6e5-4d30-8ce3-00e1fd0b264b"), new Guid("0af653fd-7f1e-426e-8a70-a21f65f3e175"), 1, new Guid("55e73b79-3878-4be1-a210-51ff8cf113e6"), new Guid("8d0393bf-4eaa-4818-8b02-ac589f680d2e") },
                    { new Guid("35695035-b37a-44c3-8d47-8f2561bdebd5"), new Guid("5399eb62-553c-4805-9d84-d92f1e5a41ce"), 4, new Guid("5bd1216c-3e14-4f96-87e2-6f978d9afb84"), new Guid("349c19f3-9a12-46dc-a57c-54bffed5979a") },
                    { new Guid("362a1dce-11f6-458c-8fa2-3a47e5b04b24"), new Guid("4b648f72-0639-48de-a96b-67f0c9fe6a05"), 3, new Guid("e682e063-ab16-44ca-8929-ea428c8524ce"), new Guid("1308dd33-405b-40c8-85db-ed52fb08aa8a") },
                    { new Guid("36c0ed72-24cc-4b9f-bef2-2459959f6512"), new Guid("a320689a-45b4-426f-ad0c-1dc1b2cb0f53"), 4, new Guid("cca5e9fc-7b68-4337-8187-71382f2bb6c8"), new Guid("2e5a702a-af56-45b7-bc5b-fc4f03a83e9a") },
                    { new Guid("36fddfc6-609d-47d5-8239-3a3f60e9ae8c"), new Guid("b6fe28ad-dfa0-4dd8-a2e5-fa91bb9f05f7"), 4, new Guid("a12c1892-2fb2-4af2-b743-e0c0da0e4b09"), new Guid("5df79964-2b08-4946-b2f2-a70084b5a19b") },
                    { new Guid("37298e3e-3d92-494e-b74e-61074a02102b"), new Guid("2544320a-108b-4ef1-a342-9e11168e19f4"), 3, new Guid("dd31c22f-3a26-49b3-a9c8-5f20cbf3e062"), new Guid("84c44fc5-c4a3-4672-9424-014056306a62") },
                    { new Guid("37543324-69ec-4549-9c8f-1ead424fb1d1"), new Guid("a525b7ca-cc6e-4a5b-a9df-794051e9790b"), 4, new Guid("61085721-b266-414a-91d5-722e8b113395"), new Guid("d653c016-f753-4181-bf85-ca296c826c09") },
                    { new Guid("3781cdeb-55c2-4277-8ee5-aefb9e646572"), new Guid("8d36e6ab-da1b-46f8-9d3d-dbebf28730ae"), 5, new Guid("c9ce7a39-43a6-4620-a07a-3b24d3696b17"), new Guid("fb030af3-bc4e-4ec0-8e5e-4b8169c44ad9") },
                    { new Guid("396dde86-8633-4613-8d6c-7c36a76ca074"), new Guid("cefa7b8e-887e-4c2a-b3d6-5b72e978472a"), 1, new Guid("dd40c111-b3e8-4eba-96d2-52bd785d256d"), new Guid("22997ff3-ae5d-40dd-9ec4-348458cd16be") },
                    { new Guid("39eaf3fb-f54f-460f-b12d-2f5b24d7e268"), new Guid("887e0ec1-fc76-407c-b144-c6c5e4c8d125"), 3, new Guid("ba87d511-5ee6-4219-b0ff-0abb695fed8d"), new Guid("3e2c0e16-fd12-4625-8389-9c5550941900") },
                    { new Guid("3a50ea6c-c189-45a5-8807-851b25bbb392"), new Guid("77d2f47e-a35e-499a-bf10-e9468d2c1994"), 5, new Guid("92ebc970-aba5-4b5e-87b1-6e11f205285c"), new Guid("b2366dc2-ba5d-43a4-b070-b687cd118375") },
                    { new Guid("3a523640-76a2-4e21-8f65-3f88e9b3862a"), new Guid("df6c358c-8cc0-4731-868d-67a974f86c06"), 1, new Guid("8185341a-3f07-49a6-aacd-bcd49ef26ee5"), new Guid("fc5edda9-5b46-4d4a-ab6f-13cabf94c4f7") },
                    { new Guid("3a53f64e-2aa3-4c5c-bd44-d7b21832f07f"), new Guid("1ba65da7-d252-46f0-b868-0938d6a0aca9"), 2, new Guid("6cb18d4d-a45c-48cf-968c-bc7cc5add54a"), new Guid("77ab4bbf-c009-4e9e-b82b-b7d019619ce1") },
                    { new Guid("3a5f0bb7-5fb4-4193-aaa8-153eb79f7a2a"), new Guid("7f22306a-8e58-4c17-ad9d-2b3baa46a042"), 4, new Guid("1a2abcd6-8a4a-42e2-9081-7755b6496fa6"), new Guid("f38f2044-e158-482c-af09-2c0ad34099a3") },
                    { new Guid("3a7a1791-9ea6-4d7b-95d1-f2ff68c03819"), new Guid("04aa8385-ac53-40ab-8b95-c41c234e2517"), 4, new Guid("8055dfd7-82a7-4427-8673-307cd29e7652"), new Guid("d0024a98-9495-456e-916b-2756c681337c") },
                    { new Guid("3accec83-2399-4d6a-94c4-d71b9fc41656"), new Guid("61a0b01a-f36c-425d-b16f-9111db5a18cd"), 4, new Guid("b8b68297-511d-4edc-962e-4579e0a3afe4"), new Guid("16b21bb7-a0d1-4b53-99cb-93768158a057") },
                    { new Guid("3b3928bd-120e-431c-be8d-810dc254f283"), new Guid("79903c49-7abd-42cb-8c6f-18c2c63cfec9"), 5, new Guid("f6b0e6a9-7fdb-4e88-b424-583807c996f8"), new Guid("ee85bbd2-9428-40b0-bc3b-b07e000b1987") },
                    { new Guid("3b9b009a-df7f-47c8-990a-f69340215c7f"), new Guid("74c1ecd8-bd8f-4086-982e-b7df98bac199"), 2, new Guid("09b885bb-a8d0-4ff5-bcc0-966cc6991c93"), new Guid("38e98815-52d6-448a-ac96-a8acf0f46380") },
                    { new Guid("3d0cf7d4-3beb-4f8a-a08f-4264839800e3"), new Guid("f792e23e-7493-4ced-8593-a431fc6ff11f"), 2, new Guid("ed5d91ee-22ca-42c8-a6d0-429003b72fbe"), new Guid("5b451dd2-649c-4f4f-b042-5efa0306529f") },
                    { new Guid("3dfc4458-7d85-4a7c-abbe-f83f563d859f"), new Guid("7a661f65-e6bd-47da-8e85-af26e64e98db"), 1, new Guid("567902b9-8d79-4ffa-b229-cd99330520f8"), new Guid("8e74f7da-b2bf-419a-9a9f-71df997d53ba") },
                    { new Guid("3f25c6dc-457e-4633-8ce8-be4f7f3a6c8e"), new Guid("ce0050dd-748b-40f5-be62-c9b4a7aa80d3"), 2, new Guid("aa50e31a-aa0e-4a7e-b44a-034efe1339d9"), new Guid("cdbbdae9-68b6-4ecd-b114-a301f290e8d0") },
                    { new Guid("405de9c7-e4a3-498e-99ab-410d284a945f"), new Guid("37ca921d-dbcb-47f7-b9b3-eeeb07b7f242"), 4, new Guid("7896a357-edd2-4bfb-8be3-d5c4245190c5"), new Guid("195d28ac-384d-4149-9de5-54ca50b19f23") },
                    { new Guid("41a1794c-dc09-450d-a0c0-71cc1dfe1b29"), new Guid("2660f818-36aa-42a4-930f-8c831afe856c"), 2, new Guid("cc655901-2fc6-40b5-bc43-dfe8f2e39c16"), new Guid("9911a809-cba6-492e-8053-a442ebef3de3") },
                    { new Guid("41b8bccf-b0d0-4708-b538-ee56cde49fe3"), new Guid("5b1b39d1-8f9b-42f4-8e4f-bb79107533b7"), 3, new Guid("d9b555d6-c2c5-422d-a173-50bb999572d1"), new Guid("b32bd66c-14fb-4d29-b1f6-6683b364c31c") },
                    { new Guid("41fe30c7-c6e0-4925-8aae-446b2c736ed0"), new Guid("7fd1897c-8c2b-47e0-9129-175c3acbc462"), 2, new Guid("58721b5d-642c-4d84-946c-4ca3435d0111"), new Guid("b91e950c-15be-4c21-8230-3d0be2e05aa6") },
                    { new Guid("443e5850-fceb-42d0-964f-15e34f5b45c4"), new Guid("d5fe806b-36d3-4a7f-a3fa-cccad73c400f"), 3, new Guid("9aee91b9-ce63-4921-82cd-89ee4bfc9407"), new Guid("9c20a96c-d202-409a-990f-dbc149258ace") },
                    { new Guid("44c91d5a-7933-4330-a632-e08f50c70136"), new Guid("d59244ca-ca75-44cb-9f29-826bac54fe27"), 3, new Guid("27951b78-6bc8-4d7a-aed4-ca90c3dd3314"), new Guid("52b17ec8-19e4-4c75-bc1c-b4b3c38c110d") },
                    { new Guid("44d5f412-ef46-4734-8a59-b7dc63343876"), new Guid("f769620d-2b0d-4cbb-9514-4cef782d0b82"), 5, new Guid("76885b62-4a93-46eb-bf83-02ed09b43494"), new Guid("22c7299a-40fc-4db4-b5b8-9d42caa6e3ee") },
                    { new Guid("453c56bf-ec06-4f3a-99e5-73455f0834dd"), new Guid("cc7611fd-82f3-443d-a641-a35ac2630940"), 5, new Guid("c6ae84d1-bbf2-4f94-845b-daaf8a8c1195"), new Guid("478d1947-d9f8-4d3b-915d-f8c5ba2c8a34") },
                    { new Guid("46e08432-9754-4d01-ba41-54068e271e2f"), new Guid("03ee494c-35ec-47b0-bd63-5e8debad15d3"), 3, new Guid("6d38b2af-d55a-47da-843f-71217fbbb2ca"), new Guid("b7c8377e-dcb8-4b67-9548-66dd19951f50") },
                    { new Guid("4775b212-cbc1-4602-8545-4ad5ad1b2ec0"), new Guid("37aa3e16-6a67-42b5-9ea6-5a6dbf6b0c3e"), 1, new Guid("9a77de37-9271-48a3-a511-7fc3a526541b"), new Guid("96733a16-995d-407f-b972-ff60c1f4c02d") },
                    { new Guid("48a0299b-6621-40d4-b84d-e9ba9b5abc9b"), new Guid("655f610e-a27a-4804-b680-2a2e86941e9b"), 5, new Guid("32bbc214-21e8-484c-bb71-e15e64b33c41"), new Guid("3e0ba59b-4ca8-4315-b904-747e8beda2fd") },
                    { new Guid("490c6dbc-3fd8-4d7f-95f0-99221aea0214"), new Guid("01dd7fbe-c38e-4c06-9112-3ba64c41a001"), 3, new Guid("d6c68369-6e87-45f1-a200-620362c8bbf2"), new Guid("2ce9ffde-13b4-4492-8934-94988cab637c") },
                    { new Guid("4b8a6e93-0a76-400b-b4dc-102b131e994f"), new Guid("6fb24a1f-2b38-437f-8635-f7bd1c290ffc"), 2, new Guid("a98f4235-e4a9-4b87-a21b-ff0403e99eb7"), new Guid("76f0a15a-2cf7-4bf0-891b-5bdcb1f3c1d3") },
                    { new Guid("4ba9bb5e-3eab-4d1b-8051-8320f79761ac"), new Guid("96cec920-472d-4c82-a10e-9e634e77a3fd"), 3, new Guid("5c475a3f-a680-42ce-b207-9eb3f95caee0"), new Guid("ee5e1d59-dcf3-4d45-a4a7-9a62075a8ecd") },
                    { new Guid("4bc155db-69fd-4245-a738-0db024116c5f"), new Guid("4d79fd31-ae05-4fcc-adaa-c97c9d7c5386"), 2, new Guid("83286ce6-c664-47fe-b193-a74b6f0e5c44"), new Guid("cfe39a71-4c0a-4360-a133-54e032de48ac") },
                    { new Guid("4d23acab-169d-411e-b15d-9f9bbefd3607"), new Guid("2ff653fe-de0f-453e-97b6-e9aeac7a8a68"), 5, new Guid("6069e19b-f6a2-4438-b29b-1fdec323d237"), new Guid("b06e5f9a-58e6-4154-ae87-8df28968b7d0") },
                    { new Guid("4d4e2e9a-fc4c-400a-b725-de5547e4ea9e"), new Guid("faad5ea9-16a4-46b1-b4f3-438da0f0a606"), 4, new Guid("4bbc7e03-b1d2-46c1-9d60-edba231754ac"), new Guid("e8a5e9ca-7249-413d-b8a8-a8f7006bf2ed") },
                    { new Guid("4ed74c5e-90e6-4231-84ca-1bd6d3a20c6e"), new Guid("2aaefca5-ed87-4cf0-acfa-13776957c4be"), 4, new Guid("139d351f-0734-437d-95be-cc1e07d5a10d"), new Guid("1d8bc189-7501-4265-aff5-db5d82648f3e") },
                    { new Guid("503fe743-c681-47ee-a1b8-7da0c6ab8616"), new Guid("7a010de3-bcbc-4f32-b456-07008df6a86b"), 4, new Guid("b6edf997-e302-4b6f-b27d-57dbc24b90d8"), new Guid("e8899a13-4c93-4686-9d8d-b72c28e644f2") },
                    { new Guid("51c05c3a-1ee6-4600-8ccf-a4e852d03d19"), new Guid("bf116ab0-b00d-4670-86f9-f4824f414afe"), 1, new Guid("060f2aae-86ce-43b9-af83-1d97ffe55823"), new Guid("9a30bc76-825b-406b-8701-3ed95b0eefc3") },
                    { new Guid("5396582a-7256-4319-a5ff-6b59110526ff"), new Guid("162f69e6-ee6b-4002-b7fc-22f198d111a4"), 5, new Guid("54e60ccc-3065-4f44-8e53-d4aeabc08a31"), new Guid("75655724-fa64-46e5-8ccb-5556fa2be739") },
                    { new Guid("54081509-ba88-4a54-b6d7-154f4e8c1c41"), new Guid("2eb91613-920b-4f50-b355-8bd38ef6ec40"), 3, new Guid("8c11b269-97ac-4a46-9333-beda4cb0f9da"), new Guid("01d0d2e2-36bc-4370-bdc8-04d9d89472b3") },
                    { new Guid("55476c0c-6539-4359-a0a8-a5ae124f63e0"), new Guid("81e9dcf6-e26b-4613-9efe-3a3e56d61163"), 1, new Guid("c73a4571-cf9e-4b9a-90a6-ce7fbb6e1ba1"), new Guid("cdf869be-d985-4f87-b0de-09f36de8a6be") },
                    { new Guid("55def556-0940-433d-96f2-1a5e95d983c0"), new Guid("20e7f426-6c0b-4482-b19e-6c7b61264406"), 4, new Guid("7fd000dc-2eea-4518-accd-23e7e9be41ac"), new Guid("ce758232-2b72-4d93-82c2-e1a1dcf573c5") },
                    { new Guid("56819dc3-ea9a-42d6-b919-ffd2a904cd5c"), new Guid("8e40d5ac-6d7d-4c5c-b7e6-1bfc121e2e6a"), 2, new Guid("a8064238-dfbb-48e6-b34c-6a9ad2ec0ee8"), new Guid("28781d8c-864d-4669-9eed-5657023800f6") },
                    { new Guid("56d2d550-7c8b-42b0-a889-46a651bda589"), new Guid("54958f66-1506-443c-bbc0-88a94b596d06"), 2, new Guid("d16c1427-24b7-49cd-b141-14da7e756f21"), new Guid("80727693-bcca-4aee-adbb-3471a3fbc87a") },
                    { new Guid("57135ba2-6275-45e7-86a7-44b2ffb4b734"), new Guid("fc7a7ba7-df0c-4cb5-99b5-b4a4064eb045"), 3, new Guid("94fba6d1-dddd-4ae3-9385-e45cc3d3c4cf"), new Guid("dfdce582-e5cf-4e45-a83b-fd91ece6d976") },
                    { new Guid("57d23f92-f675-4766-8601-2cd96eac2975"), new Guid("997250ae-fe94-430a-9dad-0b8f98f6069b"), 3, new Guid("260145d9-f24d-4aac-acdc-1d82fc0764b9"), new Guid("456a1c40-7972-4ebc-b300-111a7127b0fe") },
                    { new Guid("59ec43c5-6fb8-4064-b4f8-89d3320bc1a9"), new Guid("d0db6d93-ed59-4067-848c-fde11adc7676"), 3, new Guid("abcc308f-f776-4795-b3ea-d921736cf214"), new Guid("08046a94-80a5-446f-ba50-e80473400198") },
                    { new Guid("5a26a5d0-3325-401a-8cbb-5b634baaee98"), new Guid("ccf0c99e-ad07-444e-b795-33d5b220c0df"), 3, new Guid("c3ca1bfe-e3b9-4a43-b67c-865c1df25bb6"), new Guid("48596d61-21a5-4431-b465-651abac9ad25") },
                    { new Guid("5a72f36d-e440-4c71-ad6c-c42c50432557"), new Guid("fa54e69c-1a51-4d8d-8e3d-44171414f526"), 4, new Guid("0a72e9bd-e413-4144-a7c6-0b211d7df8f6"), new Guid("3b45bb61-6d77-4474-b8ff-00bbd58c3202") },
                    { new Guid("5ac949f5-a633-429f-a503-1a23a1c1898e"), new Guid("2e8f5f20-931d-4f9b-a640-3b3fa09ecf7f"), 2, new Guid("e5edcf15-3b41-42b9-8379-95b89528f238"), new Guid("ca764e3e-3bfd-4edf-b5fe-4fa41e9dad4c") },
                    { new Guid("5ad7fa49-9797-499d-b9b4-a73ff589b959"), new Guid("3a424cf3-88a7-4376-8156-9da2d698e2ab"), 2, new Guid("7b8c4de1-e836-41ef-a92d-460c931b32a8"), new Guid("3ab00747-ab7c-4a0c-b61f-4277836568e6") },
                    { new Guid("5b77835f-d97f-42da-af79-991a04e88829"), new Guid("10d29b53-beff-4d3d-bcb3-2b3db50018e8"), 1, new Guid("195935ba-8a40-4cbf-b5bc-70e829191b4a"), new Guid("c82bd4b7-0474-40d5-9dbd-8d2f0449e088") },
                    { new Guid("5be68f0f-c05e-4e79-bff2-f1892d5f968b"), new Guid("70a9fc88-a992-4374-b240-e2946bd0787e"), 3, new Guid("8806fea9-ce81-4449-85bd-1ea9be9487b7"), new Guid("bee315e7-0ba1-440a-a154-744a0b89fea0") },
                    { new Guid("5cd1608e-3f02-44f6-a909-f440364323a9"), new Guid("0ce9af44-b104-4b5e-990c-b6436e438dc5"), 1, new Guid("42b3cc13-3b89-44ae-92f1-e84a32162fa8"), new Guid("8a6c6f92-69a0-468f-b779-233eb403be0f") },
                    { new Guid("5dc08b3e-0af0-411e-9ec2-f43db7c803c6"), new Guid("bc7896ca-7084-4dba-8fa0-b8ea112f465c"), 3, new Guid("9f793ac9-1db7-4969-b6f2-ace5671ea021"), new Guid("ea4ac7e4-f711-4010-bd9e-79158ccb5f20") },
                    { new Guid("5e5a462b-7ae2-4990-a41e-02154a481083"), new Guid("7a85e1fa-4407-4fa6-8494-83bd0d6dcf33"), 1, new Guid("855499a7-18f1-48db-b95e-6c3ad90b8ae5"), new Guid("73fda0de-d7d3-4dc9-857a-1156ff84d554") },
                    { new Guid("5e904aa2-2d6e-4829-88fd-4331b31cef76"), new Guid("e61af291-8000-4821-8128-9611592be3dd"), 5, new Guid("0f319332-61f5-44b2-945c-5ce7dbc19fad"), new Guid("7413f75c-f290-4fdf-b594-87b3419ea8a3") },
                    { new Guid("5fb3bf91-9665-446d-9c82-fc91370bbf43"), new Guid("aca506b9-28e8-40cd-9e0e-8a077b6c98bb"), 1, new Guid("939f627d-3edd-4119-a973-1503c99c616e"), new Guid("8f7b46f5-cd74-4397-98e0-00f002fac326") },
                    { new Guid("5fdc3430-5fba-4d46-b43d-8c1f34700497"), new Guid("611b0f57-d112-4479-9d69-42f14405ab9b"), 4, new Guid("a6a8252e-6a7b-4c05-b3d7-93118ceaf0ef"), new Guid("9bf5c77f-c584-4272-9d9d-d77653710799") },
                    { new Guid("6065a6ce-32cb-4b49-a5aa-b304a9d8b39c"), new Guid("3f8994c8-0b24-4794-a4e0-0ff95e6c5c40"), 4, new Guid("3c9141af-1954-4148-a153-f2a716a8052c"), new Guid("d58b78df-21de-4d9c-ad4f-77ee82378932") },
                    { new Guid("61247ec3-f964-435a-9241-9f29991a4b84"), new Guid("a687614c-44af-4c92-91b6-5f9e1910006e"), 5, new Guid("8fda8c99-2347-4f5f-b62d-3fcfe369cbe7"), new Guid("17eb6c58-e5b1-48c1-9091-f01ef2c95be0") },
                    { new Guid("616c9c2c-8c37-484f-b21e-5bac754dd06d"), new Guid("34ec9290-8598-4ee9-9240-41e5795525be"), 2, new Guid("0410f3cf-4956-40b0-9c60-6f922051c524"), new Guid("d26d129b-c061-4532-adf4-c6276805f85b") },
                    { new Guid("61cc5a7c-e76a-4a1c-b8fe-2a105e0fa348"), new Guid("dfa76613-02d8-44b8-b3d7-5394b3cd587e"), 3, new Guid("a079e88a-0d42-46dc-9742-7e9943b6a6a6"), new Guid("e8982117-0d68-45d4-b6f7-a80ed879ff06") },
                    { new Guid("64854252-1b37-434f-8342-94af068b8cb6"), new Guid("9a3c6297-b89e-4827-8158-26410e7241a4"), 3, new Guid("48834f9e-71e6-4afc-9d9b-956ebb5afcea"), new Guid("0dbef621-f566-4a2a-b877-cf7b719a999a") },
                    { new Guid("65713ea3-7a5b-4d27-9dc9-afc15a5b1594"), new Guid("8ae1bf37-9f9d-41c1-9420-d06abccf86f0"), 4, new Guid("ca06f9ac-01b8-4cc4-83d6-dde0d35cb408"), new Guid("3d7f39a7-9bc8-4712-aef1-f58d008d69f2") },
                    { new Guid("65b96311-528e-463f-a7c0-e7ea3a8f6040"), new Guid("fbdc543b-fc62-4a38-b3ca-cc853bfc4075"), 3, new Guid("2e4337b5-e839-4472-980d-e9e92151f2de"), new Guid("3202c4dd-643e-48e3-9605-d684c7bdf333") },
                    { new Guid("65d03a02-183c-44f4-b669-bd03701fb271"), new Guid("e48e596c-5e1c-41a5-93d1-6c0372ee60de"), 4, new Guid("3c75af6b-b3bb-4808-9457-5aaf8e9a545b"), new Guid("902a2884-abc4-49e2-8c36-8fda84954178") },
                    { new Guid("66186be4-79a7-4e21-a757-a1aaa7b78622"), new Guid("82541e73-9199-4264-a6d2-8241c63cc62b"), 2, new Guid("9483a28d-3368-4778-a38c-a3359502ea7d"), new Guid("13a69fc3-ed49-487a-b424-36102525fe3a") },
                    { new Guid("66e3ea3f-3608-4417-a991-32e268d6a9f7"), new Guid("c4c872ca-5185-470d-98dd-e6101f899074"), 2, new Guid("cf576ca9-a483-4ede-9a0a-ad1161850fc2"), new Guid("1dd1cfb2-cd43-40fb-bdae-4e2d4a0317a7") },
                    { new Guid("6774f9d0-153f-40a8-93e5-fbb9ede1cdfd"), new Guid("8d4d9791-afbb-4307-b719-6f83df75864f"), 2, new Guid("7a1755e6-878d-4b7f-ae0e-267da66e4f9c"), new Guid("d83f22d3-ffeb-453a-aa0a-0d3d2a91b675") },
                    { new Guid("6835df51-4407-4052-84ec-b6019ce88a35"), new Guid("2de2c3fc-c356-402e-ae64-58d6a46063ab"), 3, new Guid("3d0d1b9e-c026-4785-8314-99afdab97e29"), new Guid("d8b92d32-89cd-4b92-a33d-5f543a48e08f") },
                    { new Guid("6855aad3-ffe6-4d7e-8093-2ddf30e1be6f"), new Guid("c4fe0735-5877-41d1-9b48-b355aca45254"), 3, new Guid("ec6e79e6-58c9-4956-a6e3-09b03fdd4bfd"), new Guid("46f34ddd-5769-4a8d-ae88-eb45cdb1c5f8") },
                    { new Guid("686e5b84-c91c-4152-9118-a60cab6d760d"), new Guid("c1047978-7cde-4a45-85de-4f143e19fc50"), 4, new Guid("0ca6c6f4-0a0d-49de-9db6-0ac28ed15d86"), new Guid("5532f1ed-3314-4bbd-be8b-db3e7e0d5109") },
                    { new Guid("6a0dd354-f52b-4224-b8c6-65392acd4f0a"), new Guid("8a4fa444-cad4-4595-a4b4-d826ba43ba52"), 1, new Guid("1369d724-7a21-417f-a292-dccd5e4c6546"), new Guid("4163faf4-bb47-4484-a028-e0ec22aa9528") },
                    { new Guid("6a90a588-4435-49bf-b72c-93182a03d886"), new Guid("81751577-0136-4bb0-824b-bc30cd64dfdc"), 2, new Guid("69063353-0542-40b3-8f9c-9bb2294ec67d"), new Guid("82d5ca3d-75d7-4c32-ac7f-ec8b0a40714c") },
                    { new Guid("6bc32e0d-d1c5-4590-ad03-3b85469fce1a"), new Guid("cdb2465c-42a8-4236-b802-187f8e740682"), 3, new Guid("002eb2f7-a9a8-4f76-950b-413e0647d286"), new Guid("2b4d72c6-9ce2-4b04-b0c2-73d7273b7488") },
                    { new Guid("6c48182c-ba9e-434b-8350-26152afaa256"), new Guid("fdaa168a-c02a-4c40-b224-2516b891b841"), 3, new Guid("887ba148-426a-4fe3-9422-896a15b6cf3a"), new Guid("58d2b792-1ad1-4584-b38e-cae0f2cef1b1") },
                    { new Guid("6c71337e-e6b0-4dc5-9119-359c95b49805"), new Guid("ec369bc3-1f95-4987-83aa-dbb5b17bd064"), 5, new Guid("1f1f4c12-21fa-4db2-bc22-b3ac3e3727ab"), new Guid("b341d371-51f8-422f-9696-7ba925d6db17") },
                    { new Guid("6d90edcc-2b11-4eb6-823d-193c69cc300f"), new Guid("6ed340d0-771d-48e1-821b-298e3ff1571d"), 4, new Guid("ffa68f77-5cc1-4c52-bb7c-f9c8e9d86224"), new Guid("abf8052a-0e94-4713-b8e4-637b9098afe5") },
                    { new Guid("6db161d4-24cd-428e-9119-30d41d052171"), new Guid("f230ebb9-ccd9-4442-890c-8b7be45988fc"), 2, new Guid("1423f866-d243-45ca-b2d7-bc1ed5a8b346"), new Guid("fcd7d155-357d-4ee1-b158-f4f5cb2fe157") },
                    { new Guid("6f5077b0-1a35-4922-806d-d5ad22cf58aa"), new Guid("4ed7bfc7-60b7-404f-a5f5-58cc1c720021"), 5, new Guid("535d4047-431b-4360-9a24-74151d4c704e"), new Guid("e0207f5f-c4a9-4702-9da6-50490836f39d") },
                    { new Guid("6f8a3580-b8d0-4b19-abb5-cce51de765de"), new Guid("c76dddc5-ec45-40cf-8073-b49b78c96e69"), 4, new Guid("6ad72818-70bc-47d7-86cd-c3c904d525f4"), new Guid("9fda8a25-007e-401e-a5c0-6ecc5a9c9859") },
                    { new Guid("72328438-15fb-448f-aa3c-299a2d1268c1"), new Guid("875cb8fd-78d7-481e-b924-06cd2dfc842d"), 5, new Guid("cd2ff49a-9f9c-4af2-af36-18b0e0b43a5f"), new Guid("550f74d1-8848-42de-a92b-1fccbe42710e") },
                    { new Guid("72fbee82-5918-4f12-a2a4-d377ed83ef71"), new Guid("9b725876-2f0c-4fc1-99f4-3cfa7a4e61da"), 3, new Guid("5df9f898-b854-492f-8827-3da186b9f2e0"), new Guid("5d6a1c4e-6101-4767-bff8-0a02cc8c2513") },
                    { new Guid("747e5d60-5387-4725-afac-ae1a2cf0b6b5"), new Guid("20a15dca-c36d-4f7c-9b65-8209d70df119"), 3, new Guid("a9981aff-dedc-4822-b7ee-2c44bc334d91"), new Guid("c6e91b3d-0ccd-4790-9d72-aecd52dfc049") },
                    { new Guid("7486efd4-2180-44af-8f82-c47fa0cb1119"), new Guid("960d15ee-76f7-40a6-8dc7-f8bd472266b4"), 1, new Guid("3623ab2b-ba23-456c-b9b1-02e4be0a6b77"), new Guid("22544f3a-8ca7-4894-b879-35eb9683994f") },
                    { new Guid("75014f39-c8cc-48fa-9662-fed1f3fe2b89"), new Guid("c5c3b339-a76f-4738-af99-872054e6e882"), 2, new Guid("eebf0654-7abb-4a5a-9d35-d2db875456f9"), new Guid("dfd05ae6-3535-4200-89d1-8caa47e64b44") },
                    { new Guid("75a3152a-be9f-4269-a813-2dc4e4c28cd3"), new Guid("f1de0846-24c1-4677-803e-748700c44340"), 5, new Guid("4bcf18c2-f345-455c-ac5e-84bf46f86d3a"), new Guid("64020ec0-09f4-4dc5-a169-05dabc827e02") },
                    { new Guid("76258178-e95c-4ba2-8a16-a1f92df29394"), new Guid("1d9959bc-1203-4c8a-bb5d-5962cf268835"), 1, new Guid("9f6bea59-31da-4639-a692-d51f553967ee"), new Guid("e7a5d48b-c64b-4e8f-ab22-cdee181f1bb8") },
                    { new Guid("76296426-56cd-499c-a39f-9ebfbc5b6844"), new Guid("99ac90c8-9b90-4021-8cdc-19aec12a7e01"), 1, new Guid("2f97b6b1-6d96-4e87-964d-05f1b8da9b4b"), new Guid("b773852c-b6a5-4c1d-adcc-ea77324bec2b") },
                    { new Guid("7708e2c1-69ac-4d0f-868a-9745401180dd"), new Guid("75dc7c9f-84fc-402a-87ad-f3315d0e2af3"), 4, new Guid("63f60a0a-b743-4aca-ab57-68672abc2651"), new Guid("192eb89d-a2fc-4b5f-aac3-daada3711ff3") },
                    { new Guid("79168535-6f59-4df2-838e-13add6eebe6c"), new Guid("6ddfcec0-2702-4c2c-a4b0-755845e68121"), 2, new Guid("d6fd2229-ce4c-43ad-a12a-9fd4c9b12101"), new Guid("56924d60-3d76-42c2-b522-9d315a26b0ef") },
                    { new Guid("7ab47f95-1f6e-4719-ab69-58a5a3deba91"), new Guid("b18ef5fd-c22f-4482-aca4-b58e0904a46d"), 4, new Guid("999cda6c-99d1-4d6b-9f93-084772bed84a"), new Guid("0e6ba8cf-ca7c-41db-a640-3d0099cd4416") },
                    { new Guid("7b3bd50c-e182-47b3-b7a5-f77d8f9484c1"), new Guid("84f02389-56c2-43b3-bc1f-25dffbc95e6c"), 1, new Guid("3eaf18d9-5bad-4aac-92e6-f90d8f901bef"), new Guid("b066b0eb-ea4c-417c-8ce2-f6b1498c778b") },
                    { new Guid("7b8e577f-7e5d-4ff0-970a-4c36d8ee36b6"), new Guid("3726d7cc-23df-4490-81b6-825668524542"), 2, new Guid("fd4ca0fc-1cd1-442e-bcd7-4d4f18e46131"), new Guid("f04cd805-c2ba-44ec-9d50-3d54878b967d") },
                    { new Guid("7ba12057-db30-4244-b454-c27989cc4f2c"), new Guid("259c318b-226e-4e52-a33a-0f34f5d412d0"), 2, new Guid("d614b55f-4519-4634-bc6f-f248f5389431"), new Guid("be74220a-f37b-48ba-a307-3d00387288e7") },
                    { new Guid("7d030045-11f0-4d0d-a1fa-f5f86018f29f"), new Guid("33bdab1a-2279-4031-b81a-f7c4455dd5a3"), 4, new Guid("9cff564e-647e-4d2a-b1b6-a2f3f4ed8313"), new Guid("deb84407-8cb4-4b62-9f1b-535956d19aee") },
                    { new Guid("7d2959df-0727-46be-ab77-2df9beba17e3"), new Guid("af0ef2b5-dd9c-4e22-adef-874fb0b87882"), 5, new Guid("1f168215-6ad0-4bc8-bb93-355921166e19"), new Guid("4dd81985-caba-46a6-b2bd-176962183b49") },
                    { new Guid("7e8af4d3-b2a0-4ad2-95c2-b4ee78d935d1"), new Guid("849e3ece-d5de-4ae7-a3b2-e7a65eb912d7"), 3, new Guid("04c50f14-3ec7-4c5f-8989-3089979a4508"), new Guid("fb9ac137-40ef-4c30-9ada-bd383a7e2c2e") },
                    { new Guid("80571f8a-df22-4371-9e04-31255c229386"), new Guid("746eacb8-60a8-40b1-a242-66aaa69fd4b5"), 3, new Guid("abdce477-fbcd-405c-b2cd-48faaabacb21"), new Guid("1e737415-fcaf-47bd-b5d9-c5a95c224334") },
                    { new Guid("81e38cc0-230d-4122-92a6-dac68965c0b2"), new Guid("3eeac9f7-498d-45c9-84d6-9eb986aba6d5"), 2, new Guid("1c97991d-31ef-4f99-8678-104c90c1b95e"), new Guid("8b535fd3-cc7b-4b49-98ed-84a85e04dbdc") },
                    { new Guid("82a39b92-1116-4b4e-a249-f4bcac43234e"), new Guid("775556e2-8db1-4400-84d4-a94f19cedf71"), 5, new Guid("76195a4f-2bf6-459d-939a-fe937bba5584"), new Guid("30406005-bab8-43ff-b717-86396eed1bc5") },
                    { new Guid("82c12e0e-c76d-4d78-aa4c-5021cbcbb65a"), new Guid("8c8aa7a0-6289-4489-bf34-024d60df811b"), 4, new Guid("fc31c1fa-75d5-4def-858d-c0d64fcce944"), new Guid("70579170-2e50-4242-9414-0b9b78b09b50") },
                    { new Guid("8340ba22-33f6-4dc3-baae-3e1c8f1b069b"), new Guid("60c11794-ba0c-4009-affa-b99999e686b2"), 1, new Guid("7d32ea6c-9848-4743-9cb3-2cf52bac41bb"), new Guid("f2f41235-718f-41fb-84ba-900d1adb0e7b") },
                    { new Guid("847beab2-ccab-47be-ba89-ea19024ab468"), new Guid("b7f14dbc-c686-4b9a-a73a-24af2242ef75"), 5, new Guid("f5e42c66-35c5-40ba-a3c0-a63792560caf"), new Guid("a0c774e0-6352-43dc-9f7b-ca00b87f8311") },
                    { new Guid("85f08b24-be6e-41cc-b09c-5f30ee488b8e"), new Guid("3090a949-9987-4f21-8faf-c389f4f14217"), 3, new Guid("57656d86-845d-4bac-90c8-55e7eaa1ee48"), new Guid("91fd6b20-264d-4625-98c0-d8cce721ad26") },
                    { new Guid("867e883d-83a0-41c2-8971-82af2ee799cb"), new Guid("663b175c-c9ba-40e4-95bd-7aa08abe1f25"), 3, new Guid("bdc0424c-3d06-44e9-991c-3688cce96750"), new Guid("1b9952da-6a74-4cea-b013-6a326704efa3") },
                    { new Guid("875372ee-f762-42bb-8672-cc908aecfd14"), new Guid("3409367a-ea04-4781-918c-d3abc30bddb7"), 3, new Guid("810a0378-c80d-45eb-b3af-1b6812df325d"), new Guid("8514784a-a9f8-44b8-938f-89cbbc172d27") },
                    { new Guid("87f9efbc-b97f-4089-83fb-4840e4d630a8"), new Guid("7766cc52-e8cf-4c39-9f4f-ef34df8b9609"), 2, new Guid("27318dde-42b5-4a34-a472-102429202ae0"), new Guid("6d3f07d1-ffb2-4ca2-b75a-c19e35104de4") },
                    { new Guid("880f880d-4c14-492e-939a-1acc344158ee"), new Guid("ec95d2c1-4658-405d-bd1b-83e521d03c65"), 4, new Guid("69e0b4dd-484d-4ec0-8061-625738812eaa"), new Guid("e0c9a2c0-d166-453d-aa36-4b11e4840bef") },
                    { new Guid("88ee8d91-c548-426c-a410-c8248e534bc9"), new Guid("1b1bd8f8-4f37-47bf-a8b3-ce9e6b1f0d06"), 5, new Guid("b1ad7883-5928-4b1d-aaf5-c6858b85c2fb"), new Guid("785cc240-cb1f-4885-896f-4eca531609b4") },
                    { new Guid("89f1941f-6910-4b53-bfb1-457786b12c72"), new Guid("f212ffdd-42a2-455f-8e6b-1bdc7916a113"), 4, new Guid("f1bc9388-7f98-4672-829e-8daba9d825fe"), new Guid("224065f7-b125-4ecb-9d9d-0cec4a29b15c") },
                    { new Guid("8c736d7f-3071-4c2b-8739-4e7f60e27232"), new Guid("ba9058b6-a804-4602-8ffa-2f36c989014a"), 5, new Guid("9de96604-89a1-43cf-9064-3bade9f7d099"), new Guid("c0a7488d-cd46-4190-9bb8-0aa705a876be") },
                    { new Guid("8c804458-c2da-4319-8dae-fa841830f512"), new Guid("f47c1fb5-2273-471d-a48c-7535e24ded34"), 1, new Guid("a82e1ed6-d05c-4c09-83f9-d03ca1fbf3b9"), new Guid("a2433831-4b76-4e9a-80dd-d0992a9b47e3") },
                    { new Guid("8cfea05c-8699-4314-ac24-53037885fa2d"), new Guid("c1a6ca9b-21d9-4421-b453-4ad9cc01b4a8"), 2, new Guid("ecabaa69-1853-4635-8b28-28f3385be2f9"), new Guid("53343e37-43ac-42a6-9636-fd4ff4b5aa5d") },
                    { new Guid("8da37d4b-ff01-47de-be12-eb00fb07ebf2"), new Guid("99290ab4-9f57-42f8-803e-f28d2408e3ee"), 4, new Guid("144a25d3-5fbc-4552-b528-13efcfe122c0"), new Guid("707810e7-8364-4909-8a5d-d161c6dd7d53") },
                    { new Guid("8ea1a07d-d0cc-4fcb-a0f6-5bc94e1916cb"), new Guid("6f01a4e1-9673-4f0f-83e3-e1100a9348a7"), 1, new Guid("aa112259-2b4c-4243-8337-b0c0b7eee3e0"), new Guid("77bff046-3696-47bd-957a-b559681d2941") },
                    { new Guid("8fb14fc5-e0db-426e-99a2-9ce9e68d6c1b"), new Guid("f21163d3-5567-484e-b233-8a5f9e8274ca"), 2, new Guid("16b66d6c-b784-4f52-9c2e-8ad9288c84af"), new Guid("d8dc4f39-fc0b-438c-9486-5fd3dfbe5ae9") },
                    { new Guid("8fc83843-bedc-4e23-a394-4eaac40d8f9b"), new Guid("37701f0e-2773-4e1c-984e-832e6e14a1fc"), 5, new Guid("d8a1623d-f1e6-435a-a2d3-f4a3901f7cb6"), new Guid("0079f332-6db9-46d1-9a00-151ef306728f") },
                    { new Guid("8fecd7d7-4020-4d0d-abb6-1372630b7695"), new Guid("6b1be530-cb2e-4178-a978-c0f43c204de5"), 1, new Guid("f5a308b5-29b8-48f0-803e-1dc01423c0fa"), new Guid("04448a22-8121-475f-a446-4c594b7bbd71") },
                    { new Guid("90746d1f-11f8-4d0c-8e56-2899e55be5bc"), new Guid("b88a8c3d-73e6-4e51-8322-025a96e1e795"), 4, new Guid("4c44b87b-bf4a-4f36-840d-d3a7aab8dcf5"), new Guid("f83ebbbc-3e28-4726-bec7-e1d1847eb93f") },
                    { new Guid("94b6ac05-9453-44ee-840e-80a4686fb194"), new Guid("8c90a109-181c-44ec-874f-1a27350a43e5"), 1, new Guid("ff0b3702-965f-4dcc-9856-68ca87fc982c"), new Guid("31b24a19-6a8f-4169-b518-6a7ecca18091") },
                    { new Guid("9576950b-b63b-4510-9265-12e119489e8d"), new Guid("466f1699-346c-45d3-b0d1-f04c63b7e623"), 5, new Guid("8626d390-2a08-44d8-97ab-15139b6b6ef4"), new Guid("e7b0a300-de71-4be1-8bdb-58cf1f9ad91e") },
                    { new Guid("95e94b5f-6d65-4bd2-8a5f-1fec5bc99cdb"), new Guid("9aceaa5b-5de9-48b5-90ce-08c39a9e30aa"), 4, new Guid("bb047197-7624-4434-8fac-895e6f2bb73b"), new Guid("497a3cd1-e92c-4aad-aa38-b056f4248ec1") },
                    { new Guid("963e9487-507d-436c-b163-923e3e8c9a39"), new Guid("ba55c40e-4e3c-4f85-8bb7-852c2fe22966"), 1, new Guid("a90ae800-05ea-4b8a-9048-f8b9ac4061f5"), new Guid("37528dc6-0dc4-44a5-a660-df0a72a35ba5") },
                    { new Guid("97d42393-57dc-48f0-8cf3-1beb5e542309"), new Guid("813a773b-51f5-4e3c-81c8-38325cccb35d"), 1, new Guid("6b6ed6a0-a5af-41d4-a501-e759f04edf1a"), new Guid("77ea95c5-cc0b-4631-8da8-a7d3cf2e3265") },
                    { new Guid("98d1f8eb-2b54-49f5-a0e9-b64e7265d96f"), new Guid("d2088d73-f13a-4def-91b4-89952db5bf51"), 5, new Guid("0ce1aebb-faac-464c-a396-1f6be2a4d172"), new Guid("0b4a92a9-271c-4525-8fc4-d460520457c2") },
                    { new Guid("99a68dc1-a487-4144-9065-4ccbc19d180f"), new Guid("030987da-c365-4338-b5b4-ca82b79e5943"), 1, new Guid("f13a53e6-bc5a-4d7d-b6e4-700a1443913b"), new Guid("0bff59c9-86c6-4144-8f2b-c38960cadd63") },
                    { new Guid("9aa72f35-fff5-4f19-9a58-77968fe1b329"), new Guid("6007c6a5-fd3f-4fc5-81fd-c77356251772"), 2, new Guid("24a5bdbe-604a-41e1-b6f6-af1717f4b9d9"), new Guid("b97f28c6-cafb-4c4e-b93a-cc8ff93c5124") },
                    { new Guid("9b153db0-7a1e-4651-9ebf-f01c9e4bba9b"), new Guid("079dc28d-f1b8-4e52-862e-11574e001974"), 1, new Guid("2cc8465c-1851-444e-92a4-a5c7d6eba4ea"), new Guid("1d27fb3d-bc1d-475f-acc8-13d1ebf47890") },
                    { new Guid("9c2f3a70-77fe-48e0-8f40-04452373f6e1"), new Guid("cde329a2-4091-4655-b7bd-32208c1ef86c"), 2, new Guid("c11aac7a-701e-4101-91bc-ec2ba641db79"), new Guid("fee93a76-294f-4a9c-ab2f-28c52c6a6bc1") },
                    { new Guid("9cbd5a04-6a15-4e53-ae70-968d20cc1956"), new Guid("0fd66b35-ce0b-418e-9502-4cd74f19b4d4"), 4, new Guid("8eaf1f03-88c1-4ca2-b98b-6fdae25557e3"), new Guid("1c9e6de4-db10-44fa-a2e1-5d2b5a30e62d") },
                    { new Guid("9cd6db03-5f85-4aab-8d12-b7e51c35c2a8"), new Guid("c75a642d-ec9e-4eec-9724-02773216d91e"), 4, new Guid("01b3af25-2714-4d0d-9cd3-df725452f84f"), new Guid("da6f29ff-eeac-4bba-b9ae-023583d67f8e") },
                    { new Guid("9da58814-fc32-47db-89ee-e1ec4ffdc077"), new Guid("89dd55e4-4015-449c-b5bf-aeddf7d5cfb7"), 3, new Guid("ab88354d-5217-4e5a-be2b-bc2ceff83420"), new Guid("5b7d6f38-d309-4214-8a44-af1f417d06b2") },
                    { new Guid("a04174c8-42f7-4fe7-aa8d-9b5bf36e8e17"), new Guid("77711183-8fbe-4bdc-aa03-b0afbde6e54d"), 5, new Guid("302403df-126c-4d62-90d3-806d0385b47d"), new Guid("2e24998a-cb6a-493a-afe5-b82ea5b8bc81") },
                    { new Guid("a240cd24-5555-4350-8bc6-d9f78a3a8749"), new Guid("369c0897-d98a-464d-8b86-7a9624aad748"), 5, new Guid("64945f1e-9800-415e-9600-c1575dc6dd8a"), new Guid("254529d8-fe58-48b1-83fc-9f8438f4f723") },
                    { new Guid("a372481d-9f01-4d6d-bf6b-d9e496ae2ebf"), new Guid("e978cc45-efc0-418d-bfe5-3dd6ba4d6951"), 4, new Guid("31a2e698-5550-4951-83ec-b8c0358bc7c7"), new Guid("37cf8ccf-b234-4aab-b44d-82b0cd9063a3") },
                    { new Guid("a5ce978b-96e1-47b0-9c3f-6c28148affa8"), new Guid("1696c6c5-77e5-46b3-b164-7f1e6e13ee6d"), 1, new Guid("4cad12b2-8d0e-4608-a791-4d99a3267b19"), new Guid("6acc82e5-6b6c-44f5-924e-b55a754b87ee") },
                    { new Guid("a76ae727-1ae4-489d-9a3e-2459ed3e567f"), new Guid("9ea6f418-5668-47cd-958e-60a5e1abd7f8"), 5, new Guid("2725bf52-1a61-4b0b-ac60-25c6599f8f74"), new Guid("6f9ead57-98b0-4225-8dab-04257db1ebdb") },
                    { new Guid("a845a994-b31d-42da-acea-74425a7a84f2"), new Guid("fcb3fc59-799c-4095-8cf8-706574acdb6f"), 1, new Guid("778e891e-28ad-422b-8577-c4f34cfb670a"), new Guid("e499782c-311b-4300-886f-1d20eabac0d4") },
                    { new Guid("a9501f51-536a-45f5-9bb0-31bc724d8adb"), new Guid("5af7b9e2-5d8f-4d12-abde-6c4f6acb2dd3"), 3, new Guid("4952bae0-fdb1-4a88-8e00-6fd47a39509f"), new Guid("a0173453-4fda-422e-9bf0-0d7db1eb9437") },
                    { new Guid("aa1145e9-39f0-4669-b9f8-b66926be8b24"), new Guid("190202d8-ab12-4663-94bb-b1871b4e2cf8"), 5, new Guid("e72d2038-a5da-4e10-8810-5d8db13e2d0d"), new Guid("b020e8bc-bb0b-45b8-9f9f-6cb6ea604ae7") },
                    { new Guid("aa243e65-18b6-4767-ba69-bed8fc00e918"), new Guid("33f9eb49-6261-4c65-a269-1127d9e6f37c"), 4, new Guid("f64c0f8b-0389-4aff-b3ee-6b4c99e42670"), new Guid("c0aa815a-90eb-4ef8-8237-fb07520c7662") },
                    { new Guid("abfef4a0-e3ce-4ec7-827b-4deb994159f7"), new Guid("8a85fa56-3b9d-4f4b-90f8-0bfb6c2fbfbe"), 3, new Guid("a92bfd68-f1e5-4669-a3b4-dc70bb809049"), new Guid("370978ac-6c4e-4439-a314-d578cfddd79d") },
                    { new Guid("ad65f893-17f8-4bee-addc-76345c15697b"), new Guid("c540824a-4b52-4fb8-b1f6-bc2aedb1fcd4"), 5, new Guid("0aac0510-9914-4055-bcc5-44bbb800576c"), new Guid("265b8c54-a055-4795-b7df-2b7e4ebf1a69") },
                    { new Guid("ad68f905-b109-4822-8dc7-934756a5032b"), new Guid("8f84d15d-c57b-4ae2-b3e9-f6a368fe212e"), 3, new Guid("944e8638-2aad-4351-b324-d5ce6e1b4e09"), new Guid("8d154064-b0d2-4a0c-b27c-0f1f06cab1b3") },
                    { new Guid("afba043a-38ac-4083-882a-a47da7524bd5"), new Guid("6883acbb-9952-4ad2-b581-2c82ddd0a403"), 3, new Guid("62eda8ff-3ace-4e56-82a5-7bc5e84bacc7"), new Guid("2e1511da-d472-4ac5-b625-38cff44cc0c3") },
                    { new Guid("b02c37ac-ffd5-44b7-ac8b-7d2cf82d503f"), new Guid("75b0184d-3f8c-40a7-b6b0-f1ad36a45c5d"), 2, new Guid("e77c58be-9187-46fc-b98a-ffad2d843ca1"), new Guid("3d7b32ea-ee54-4f5d-90c1-a999623bb75d") },
                    { new Guid("b044fcb4-1740-4bce-b1f6-c3d7050376df"), new Guid("e1944e13-9b41-48fe-852b-c1a56b5bbacd"), 2, new Guid("25c63b52-a533-40b0-af80-d9213e066d91"), new Guid("d3c8b103-a2bb-45ff-8596-a86954e7b20a") },
                    { new Guid("b0b08230-6535-4f78-9a2b-1a58f89d2350"), new Guid("7538a7c3-7641-4951-b956-98d93b6aad40"), 5, new Guid("a616bb79-0de8-4f81-8633-84642ec66f0e"), new Guid("3b93014a-2d56-4bd6-a1ee-fabf0bbaaf71") },
                    { new Guid("b32b7493-f79e-4c9b-98eb-977306439c5b"), new Guid("75bafdfc-d8d7-4d41-a3a1-f6fbebec3c9b"), 1, new Guid("c1cb824d-9613-4e25-aee6-bdc9f99c3669"), new Guid("4d92481f-61d2-4760-9b27-5f9b7296da3c") },
                    { new Guid("b384ffc0-beb6-47bc-9533-82684b0f1ac7"), new Guid("6f5dcc4e-4104-411a-bd91-38b4b2127c37"), 1, new Guid("b751ff69-68dc-4850-8065-006217d86879"), new Guid("4f183d51-bed8-40f3-9a71-3d39c2d20e60") },
                    { new Guid("b511c7da-2998-4b04-943d-876734422e4e"), new Guid("890eb33a-78f5-43a1-b1b6-3ad804e8401a"), 2, new Guid("f6b5e3fe-28b2-423e-bca7-faa5375106a0"), new Guid("ab01b130-1ba5-4a64-a5b0-d06174aa2b01") },
                    { new Guid("b6722f8b-cb2e-43c9-b1cc-2066ff0e7d62"), new Guid("beaf0436-c7e4-4a32-9794-bd6f8b94b6db"), 3, new Guid("82bd438d-afc4-4a7c-ae98-3417fdee6dcb"), new Guid("5fb93132-99f6-4310-bb52-9292eee7e9b2") },
                    { new Guid("b712ab55-4823-4297-9e27-2b86e7a3619a"), new Guid("be935f2f-7669-49f9-8490-cdb73eb4334e"), 2, new Guid("68ce3dc2-9b70-49fa-8f65-73696345f580"), new Guid("de5224c7-8047-475c-b8ba-784eae096e9d") },
                    { new Guid("b7ba8499-a6d6-4645-a854-641ab4683407"), new Guid("2a3a0034-a66c-4750-a5a2-c91dc207479b"), 5, new Guid("0d5b860c-b616-48fc-a58e-55caab9fb079"), new Guid("ffad32e3-add9-448c-afe8-1e0bdef1bef8") },
                    { new Guid("b9a0c1fe-5540-4cae-92d8-a9982ae3c171"), new Guid("c4a1ecfe-cbd3-456c-993e-18e5c5ec9006"), 4, new Guid("76bb57c1-8c5f-4170-bf92-526fb948132c"), new Guid("300b043d-610b-4115-ad46-98f52ffb925f") },
                    { new Guid("b9c02476-19fe-4209-bfb4-9cc49f403232"), new Guid("7e894260-3b8a-47c0-a744-367c776de37c"), 5, new Guid("c33f7c5c-8778-41d3-906c-c2d8e5797503"), new Guid("341b604e-c2f9-4328-8ab9-ae1b37f77991") },
                    { new Guid("bac6ddac-71bf-4eb1-a471-1e7dfb6abb75"), new Guid("6d9ff91b-9aa6-4535-a065-46be7979035b"), 5, new Guid("37e87cce-88db-4cfa-89ea-b9e0c528dd53"), new Guid("4351fe30-38d3-4087-bbb0-e5d6a82d517c") },
                    { new Guid("baf408ec-22c0-4fa8-a0ab-151980e057eb"), new Guid("b987056c-93e2-46a6-8bbe-ebf2acce9ad3"), 5, new Guid("65838b7e-375d-44d6-9819-047ecf111993"), new Guid("c9002076-0acc-4998-9dee-7c3fb6c0a3e9") },
                    { new Guid("bb9ffc89-c5b6-4d5d-a7b2-4a60c0d86861"), new Guid("a264261a-d544-400f-b27e-80d3ddd4eaf6"), 2, new Guid("f7f0c82b-231a-43ed-b398-8484c9aee581"), new Guid("8ef7428f-9509-42f8-957c-340e7b20592b") },
                    { new Guid("be619ea0-16c6-4173-be51-985da8858a35"), new Guid("5a916901-b80e-4e76-b96c-2ab43b9e397c"), 1, new Guid("28794111-feda-44dc-8154-e22b3faa0e14"), new Guid("30ce55c9-9369-4c08-a7ba-5708265cb2f8") },
                    { new Guid("c02f938b-7fc8-4d5f-bd60-ad8d6bd99f43"), new Guid("926c706b-21f1-4474-abc0-29f7c3d0db33"), 5, new Guid("10423990-a6cd-4ff7-82ac-aca7e7a212f3"), new Guid("348662be-307a-4123-8871-5d8369684cce") },
                    { new Guid("c288a69d-41f0-42e2-9f1f-1cfe76cb6616"), new Guid("ca476678-6c59-40db-b7df-ddab1d75b1fc"), 1, new Guid("4623eb5d-924a-4bfe-a5ed-06e6d4c93d8a"), new Guid("7e3d81f1-5d26-4007-9001-aed754d6b51c") },
                    { new Guid("c2a6831d-f464-4e46-8813-76bf64d67aa0"), new Guid("60e9a09a-1cd6-4e6a-a458-b4c6d351d75b"), 5, new Guid("a6ab927e-077b-444a-bd8a-992b3283dd53"), new Guid("5255221a-b045-42ef-90c7-b0a64bf2bb61") },
                    { new Guid("c2ea5893-9f0f-4ba3-b096-a145541f02ee"), new Guid("dfcb3de9-0353-4b6b-a9b4-671ec75fd0aa"), 4, new Guid("66ff3b23-6b4b-4712-9027-b7faff2ffb4f"), new Guid("98c8db72-7d39-497e-a29f-6a66737c5b83") },
                    { new Guid("c38a9655-a3dd-4c64-8ae5-89f3d2276f87"), new Guid("9c7aa41b-5a0b-4a03-bf9e-7fecad1c5f4f"), 2, new Guid("196cf299-e4c9-4453-aa7c-82b3ae926641"), new Guid("a98296b8-a67b-47a5-9dc8-a3f192e70baf") },
                    { new Guid("c40dc40b-2273-451c-884f-112dea596db7"), new Guid("1ad63821-eb93-445c-a8d9-95ab64839e0f"), 3, new Guid("cbe581ea-4323-449a-83fd-5e24c85eb511"), new Guid("6026e013-37c7-4117-baaf-5395737955f0") },
                    { new Guid("c452c1c6-ae6b-4020-84ed-7a9324140d6e"), new Guid("152d0127-9b65-4d10-b20e-30a74d39324c"), 5, new Guid("e88a648b-6636-411f-bca9-21936f0c9311"), new Guid("03f0b379-1c80-4de6-a6c7-56bb471fe988") },
                    { new Guid("c48c99a9-bc2d-4d4b-a902-b7e86e0a4951"), new Guid("6a7ad37b-516f-4bf3-ab90-53c9985ff676"), 1, new Guid("8c0225b0-f9e0-4018-b5b4-e987adaa1183"), new Guid("30f30151-d09b-41d6-ba6d-ae3e039ede05") },
                    { new Guid("c76ee0b5-26ff-460e-a622-9001a7c4e1c8"), new Guid("8f69dd10-63c2-47a3-ba69-e05ccd49c19c"), 1, new Guid("7ea4230f-191f-42b0-9414-b6de871456fa"), new Guid("edebf351-b2fb-4b09-a5fb-3b24b70ab4ea") },
                    { new Guid("c797cf38-3186-469c-8155-e36c22d044d0"), new Guid("53e7e035-c8fe-4040-ae15-b509440b1c9e"), 4, new Guid("b697402b-c654-4aa8-9b4a-4943f631a497"), new Guid("8b31996f-f634-4937-adae-ab78deedab52") },
                    { new Guid("c8243a7a-6f0a-46e7-b592-577555473186"), new Guid("8120affe-aeb5-4755-8df9-13149680bb5b"), 1, new Guid("89e63442-7d8f-4b91-8405-3ee931804071"), new Guid("217f6c95-7484-4f40-bd67-11c26c7e1019") },
                    { new Guid("c8cd92aa-1c29-4ba0-995d-cbca468ff9ea"), new Guid("6d3e79d6-8136-4719-bfc9-ceb2597edbd5"), 1, new Guid("0b8da5e6-44b3-4f02-ab79-454c9ad5e282"), new Guid("0c72fe59-2926-4093-8a9e-389cfa29b03f") },
                    { new Guid("c93b3f51-87ee-4810-9dfb-5ba6bb01cfc4"), new Guid("10c763dd-c33c-4f0e-8a19-353e2f3e1de0"), 5, new Guid("af7e0c60-6b65-4cb2-a218-cb3e34182ea6"), new Guid("b93d3413-6567-45cf-8191-9df398b28963") },
                    { new Guid("c9aeb37a-d557-4c86-8c02-35e21934c722"), new Guid("ff9e6018-745a-44ef-8b97-2f58edfc6749"), 2, new Guid("89abfa41-9572-4b23-b343-106b0cc741d7"), new Guid("5d8d5199-4fc0-443b-9d7f-450c4c681760") },
                    { new Guid("ca176e21-30bf-4ce9-8dba-7cc425b12dd1"), new Guid("da87bd8b-fdb4-4e79-ab6a-a53f367f7c22"), 3, new Guid("2e28d492-857d-450d-801d-9831bffc71cd"), new Guid("57dae056-55b6-4367-863d-734cfb66ef18") },
                    { new Guid("caa40b1d-fa7d-4190-b910-12f4eaa6a891"), new Guid("ab37829b-027a-4228-9c26-3ef806856159"), 1, new Guid("b1a91456-86c6-4f48-8a8f-d2072736eb4e"), new Guid("e500102d-acd8-42de-8330-066ca8949877") },
                    { new Guid("cadb7fe4-cdd8-4f61-9231-cd438727db55"), new Guid("2a891ea7-316f-4e79-80e2-87789473b1f2"), 4, new Guid("21af6a9f-48cc-4fcb-918b-edb475b32eb9"), new Guid("c9688680-8e48-4842-b3e8-62431bbcc487") },
                    { new Guid("cae52c8a-755f-44d1-9a34-52eaecefef36"), new Guid("08172f03-16df-450f-872e-2aa13e7d81c7"), 1, new Guid("5ad453ed-8c05-48f1-8f5f-1e2e5589a062"), new Guid("e32da7e6-e56c-4b18-a1bd-64879be842cd") },
                    { new Guid("cb1b40be-6b95-40ff-ad38-1b6d59a6088f"), new Guid("22b633a1-6330-41e2-986a-5cc79bd98cf7"), 3, new Guid("d1c7a236-4ff3-4160-ad18-bd58f5414366"), new Guid("a4fda86b-b67e-4323-9546-a6777e2618cb") },
                    { new Guid("cb97d3c1-b1a6-4054-96ef-8fb78a35d271"), new Guid("adfa82ca-c5f4-4e22-8107-d555f1c51dc3"), 3, new Guid("4dafc807-ba9d-435f-9efc-b94019b6099a"), new Guid("1e208efd-6060-4f03-a403-1a9c54a9efda") },
                    { new Guid("cce4ae5c-0cf8-48a4-baf2-c1815e57b8d0"), new Guid("21436ac2-7553-4547-a9b3-dab9a889a131"), 4, new Guid("73a653cb-d2aa-49df-bebf-5b76121b566f"), new Guid("ba955bec-fbc7-4c39-af35-707e51b9b5d6") },
                    { new Guid("cd823fb8-24a7-40c9-a085-d206bafc44ed"), new Guid("a34d98da-4394-4ffb-a6f4-f870420209d8"), 2, new Guid("4a0f7cae-1673-4b84-854e-f7e3ae6e1c9c"), new Guid("69099de9-4355-43b1-9552-9713d37cdff2") },
                    { new Guid("cd957506-9b00-4730-8c6e-71482ff9194a"), new Guid("fbaa77dd-ce6a-44b1-a8a2-a42c872d8041"), 3, new Guid("b561ae5e-d2ed-43e0-a96a-bdb3116b61f9"), new Guid("ea8ce327-1762-4784-ab68-0a12483e219e") },
                    { new Guid("ce559b3d-0925-452a-85a6-b4a4683c633c"), new Guid("0021ec16-bc4e-4b18-a612-e739a690b187"), 5, new Guid("26ac55c7-da46-4128-a2f7-69f3253ff89d"), new Guid("42c089e0-cc24-4868-9a1b-5d50e5a0a0e2") },
                    { new Guid("cefc593c-e347-4bce-b077-3dd9059d174d"), new Guid("2206fdc2-9468-4865-884e-0307920e6a26"), 5, new Guid("96e1f6cf-215b-4a06-b1fe-984ad6ce8fa7"), new Guid("f235cbbf-d2bd-4cd2-9865-3d48066d17cb") },
                    { new Guid("cff1f908-7fbe-4887-9c1b-f7023223b37b"), new Guid("f20edb87-99a5-4749-999c-e7dc933c8d49"), 1, new Guid("67ef1dac-45e3-44c9-a49d-4ffd0b91d15a"), new Guid("83b93b86-076f-4544-b502-151995fe6a58") },
                    { new Guid("d0c94635-49ea-4639-9742-1ca85276315d"), new Guid("8754e993-825e-46a8-bc94-33b12b878cab"), 2, new Guid("ba08c8b2-674e-4488-a3c1-0190356ebe74"), new Guid("c78151b9-bb26-43c4-81dd-306e05b4fe6c") },
                    { new Guid("d125a6d2-87ad-480c-ad2d-72d292b7845b"), new Guid("85f2f180-4744-490b-8811-da0977861cf0"), 2, new Guid("3f78ea15-43f0-436b-92e4-b62669d24231"), new Guid("717632d1-6818-4f36-a481-bb58133ff854") },
                    { new Guid("d257cc22-47e7-4941-b9c9-166d258e14bd"), new Guid("59df2794-87a5-4f13-aaa9-e684089c96de"), 5, new Guid("0072808f-a202-4085-9cdb-56fc4056334a"), new Guid("62324c3e-5be8-451c-b27d-46ca2f6c99b5") },
                    { new Guid("d2771db6-d566-45be-8c17-80642a4b9e92"), new Guid("0b0fd648-d146-48d0-8c79-f7668d152ca7"), 1, new Guid("97180b5e-2ec0-4615-b083-8d70a17ddcee"), new Guid("0e446b63-df65-4178-b9f0-6a243e4c53f5") },
                    { new Guid("d39d3fa8-0b15-40ee-bea7-cd63f20220fa"), new Guid("f41c1aa0-b285-4e8f-8f62-ce1c5c61ea1f"), 2, new Guid("8a906fde-98b0-48ce-9326-a066a3230067"), new Guid("e7c822a8-a749-4170-a973-edd2d88310c8") },
                    { new Guid("d41a9137-bd89-4f57-907f-24fe5df0138d"), new Guid("f01435b8-938a-4509-bc8b-72b265b94363"), 1, new Guid("33bdef78-b50d-4482-8896-353b5b8fd4ea"), new Guid("85e40869-4799-4715-bced-fbc57969aa21") },
                    { new Guid("d49d695c-0082-47ea-b6bf-c0c73a8743f4"), new Guid("f4c7f8c0-5e04-424f-9bf4-26d373636122"), 4, new Guid("238b14fb-648b-4212-a3dc-ef4e39cd6aea"), new Guid("0ef51d61-7517-4169-ae71-4f8da9e2d5ee") },
                    { new Guid("d4e99ca3-3d52-4ef2-a514-b1334be459c4"), new Guid("a14f19c6-bfba-4a67-92be-f24baae1d90c"), 2, new Guid("895e64b5-a782-494e-8782-b2128faff3cf"), new Guid("510a239c-222f-4924-8b8d-cd29204d6747") },
                    { new Guid("d5883121-8fe3-4a91-9592-f56acfb1fae5"), new Guid("7e0bf4cf-745d-4c41-8e96-9fbe3feefb27"), 3, new Guid("5403dd7e-2f5a-4774-ac51-54016934ff5c"), new Guid("2cf91650-1d48-45b0-8bd1-559fb094a171") },
                    { new Guid("d6b74edf-19e6-420e-b6ec-036b9afc9e8d"), new Guid("21c181ba-4143-4a72-82b2-5365061b9e91"), 3, new Guid("c54e6995-a546-4584-b273-40921024d809"), new Guid("4d60c830-484e-4530-aba6-7cf2f97112a7") },
                    { new Guid("d8c7f3b2-c7d1-4a8b-a8e3-7281f75dac60"), new Guid("0318b956-aeac-40ca-a529-e19c4f4759cf"), 3, new Guid("d88902de-4181-405f-b69a-1bcb3a2e19f0"), new Guid("15314bcd-b497-43bb-9357-95a96aa45996") },
                    { new Guid("d8d197f9-0d92-4d3a-80cc-ffd9d7205bac"), new Guid("686edcb6-88c6-4961-9e1e-3f7972f72bfc"), 5, new Guid("170eef10-7255-4ab5-8049-14ee593dbcfc"), new Guid("c71e75da-54e3-4d73-af98-8e4a5a2c9267") },
                    { new Guid("d994c52d-c011-41d9-ad8e-3186f565a1d7"), new Guid("57b027a0-875e-4553-a484-4e7a676dc7a4"), 4, new Guid("3136cf54-28ff-4bf9-853d-4677bbdefae3"), new Guid("703a4330-fd1f-482b-b274-e62621734995") },
                    { new Guid("d9cdef95-59b5-40c4-be9d-f7e239f2dfb3"), new Guid("83942c1d-3fd0-4726-80e5-1641245e9318"), 3, new Guid("58946c8b-0bce-441f-b10c-45513edd4548"), new Guid("fa9c8c4d-768a-4f34-b7c2-b01f9ee89d28") },
                    { new Guid("da06f286-3ca4-4fcb-ad4c-462c4c52ed86"), new Guid("9484f65f-889c-4229-a817-cc7d77bba383"), 3, new Guid("c5d016ef-b706-4552-baf6-ab75c08fa27b"), new Guid("d265bad6-9dec-490e-815a-2d89cfc628b2") },
                    { new Guid("da80ebff-d372-45a0-b9da-d79c0617b247"), new Guid("de2c4bbf-6085-4596-bb6e-597052983703"), 3, new Guid("ad86c757-36c4-46ba-a9f6-83e039eabb7d"), new Guid("c499a87f-f7a5-4e7b-aba3-9c76d0ad1c3e") },
                    { new Guid("dcd43795-96c9-4141-a6f7-ecd9e4ab6da8"), new Guid("4d80a874-de05-4ca8-9b09-624a9642edf8"), 4, new Guid("99c77b72-345c-463f-a949-dffddff410bd"), new Guid("1bd18ddb-b279-41dc-97a7-cfe7f1150a4b") },
                    { new Guid("dd85773d-8d0f-4dd4-a9ff-a8718bcf042a"), new Guid("ca50452b-0a5d-4026-9abb-a1d5c0e98349"), 1, new Guid("cdbe1302-235e-4c95-874d-f554bd533fb8"), new Guid("d544acf7-d851-4647-b572-bbacf360b2a7") },
                    { new Guid("deb9ef20-5039-4d6d-a548-33a2d771b7e1"), new Guid("2ea0aa54-09f7-420c-8fc4-860fd950fe16"), 4, new Guid("461a310f-a095-4c04-821e-48a67eee6dd9"), new Guid("f1ef1940-3808-4c1b-99a5-2df5a161f2bd") },
                    { new Guid("decb30c7-e01b-4a0c-b5c2-6fc283f556e8"), new Guid("b35a171b-bcff-4de0-a0fc-dda690920d21"), 2, new Guid("5832a64f-dc0d-4883-80b7-c2ecf910c516"), new Guid("edc243a9-197d-41bc-967e-3e831abc5977") },
                    { new Guid("df7e2672-1888-4134-b644-a1594e71d060"), new Guid("d6dd8d4f-9f01-4ca4-9a3f-0a7ed1afc564"), 3, new Guid("8d86ae00-18fd-4c04-8fae-5c56484e90b6"), new Guid("03d7a58b-9100-4065-8595-3b6e6682212e") },
                    { new Guid("e0b90f61-673c-4326-bf6d-b0ec109d6cab"), new Guid("3d6acc83-e795-4bdb-841f-a38fe72b7550"), 5, new Guid("343c0e4a-9711-4343-936c-cae3f2d94a69"), new Guid("639821cb-140b-4127-99a8-15f554fd18b9") },
                    { new Guid("e10da1a3-becc-4877-b4e9-2b8bbe809684"), new Guid("952f7eeb-cc89-4f1e-88f3-9a9395b72a85"), 3, new Guid("cb176185-f34b-492a-af24-a02803c2f855"), new Guid("5c8b3acc-53a0-49eb-a753-afa84a7dd137") },
                    { new Guid("e1af883f-365f-4a9b-a0db-b8f6b501b351"), new Guid("39668f03-c899-4062-8479-281a1469f2ed"), 2, new Guid("4f90e845-7dd3-4eb7-ba75-fa93ec1ed476"), new Guid("8e09a2de-ddd8-4b1b-b3e6-3fcc0914ed34") },
                    { new Guid("e2a77b25-378e-4b41-9641-f59f5dd63c2e"), new Guid("206df5d0-687d-4776-a5a9-cc1464043792"), 5, new Guid("18760e98-071c-47df-b195-cb459a59c2cc"), new Guid("43470741-8fbc-49a6-a95d-c4053c1ef6e2") },
                    { new Guid("e2aed87a-c62d-4312-bcfc-a7da679a3ed7"), new Guid("871e2638-f440-469a-92a3-e04aef2eecff"), 1, new Guid("516209d9-3939-42cb-bb62-684fd4cacfec"), new Guid("98d29a58-046f-41d9-a512-bd687ef47183") },
                    { new Guid("e3749504-5967-4311-a370-19b8fff80be0"), new Guid("57481ce6-7fc8-483b-915d-424d80e0651e"), 3, new Guid("ecfedbc0-80d7-4bbc-886b-50d54ef7e52c"), new Guid("0eb57b9a-80fa-4279-a277-3d0544890acf") },
                    { new Guid("e52ea395-7a20-42c1-bce8-109afda31aa8"), new Guid("da112e0c-32b8-4410-978d-c9c812161b74"), 2, new Guid("84172fdb-d62d-4315-bfcf-63c9d5df2e98"), new Guid("da6d04b6-8b5e-4ab3-85ea-b3a77c0f710d") },
                    { new Guid("e8f766a0-5fc2-41fb-8bc4-a1651eeab987"), new Guid("531d5306-7fd8-47e1-aeb1-ce63e2d7f8c5"), 4, new Guid("8c1936d2-b491-4921-ae6d-5fc7c4be4cf2"), new Guid("0d87a0fa-0a88-4000-8750-7614519edeee") },
                    { new Guid("e996dcf2-b2de-4471-b4a6-41f94fc76eb9"), new Guid("4cc53a87-d49b-4fb9-8fe1-b51abbc9aba0"), 4, new Guid("ce1725b1-0719-42f3-adff-803763fee581"), new Guid("2b2fcf08-c44b-43a0-b479-45d8a0f6da41") },
                    { new Guid("ea89f648-5491-44a8-bdf2-3e327f0161ce"), new Guid("14eabe8e-6250-4cb6-9b41-0e1caf5fdd64"), 3, new Guid("343e382d-a639-4531-bf68-ce6e8934fec7"), new Guid("bf762da7-370b-4091-878f-8bdb683d91f9") },
                    { new Guid("ebd0f6ed-7264-4345-86a4-0f417c6212d8"), new Guid("08abfac8-800d-488e-a5f4-dfb5a37f7fd2"), 3, new Guid("83886e80-86ee-4123-b4d3-7bd1ffa6f8f8"), new Guid("b9c2d368-ac65-49d1-a859-7f446a9b4c34") },
                    { new Guid("ec688798-3e7e-4f51-9dcf-bd41df82c684"), new Guid("1c6a4647-1a33-4f10-a192-99d7c4fd4cae"), 3, new Guid("14436803-9796-4056-927b-1105f6517355"), new Guid("d0f1e1da-f5d4-4c47-8fa6-ecf5da071237") },
                    { new Guid("ee6db7bb-cd6b-45c5-9db0-2d85a28545d4"), new Guid("34050380-ecfb-4130-933f-1d2bde3ad0aa"), 4, new Guid("4d1d0289-0ab1-44d1-8973-73a2bb582b0f"), new Guid("6f5b1d0c-dad9-4b7d-b3ab-d940ef17cadb") },
                    { new Guid("f0082c12-d57c-4f24-812f-28da844f6d4f"), new Guid("5f8fd7c3-2cba-4291-9f9c-e724642fed3a"), 3, new Guid("b45588a9-7b16-4bf1-afa1-69ce5c0b7611"), new Guid("ac1aaa09-56e1-42f4-9686-0dcf64c4b834") },
                    { new Guid("f0b995b1-1bd3-47ef-8a0d-d46356e55626"), new Guid("4e643915-ad53-4057-81ba-f92eb7f836db"), 5, new Guid("e9e097f4-6902-4164-ab4a-f355866e1c19"), new Guid("493b03bc-09c6-4434-9a70-1baaedf69aa7") },
                    { new Guid("f0df1a4c-1b03-4200-9069-99f6b3dec160"), new Guid("ad0a11b2-2630-4885-bcf5-d469b96ea10a"), 4, new Guid("51e0b042-271d-47e4-9516-fb45b36da88a"), new Guid("1000c804-5fcc-4320-b084-7f08f506cc3c") },
                    { new Guid("f17be757-3264-4bd8-a5ac-000fd6d4b0e3"), new Guid("a8428237-49eb-446c-8040-9f73bfa0fb19"), 5, new Guid("3866f53e-dde5-45cb-a923-21414f79edf3"), new Guid("a7c909b3-f465-4907-a02f-c69028ed13aa") },
                    { new Guid("f1ea90af-6c34-47e4-bcd9-7944bdfb49c4"), new Guid("b9f8ed78-7307-444b-bace-d7b63ca325ff"), 3, new Guid("4e089fdb-83e7-4e8a-9434-e52ed798f1ab"), new Guid("ba365174-6281-4887-a238-12f67a14ad94") },
                    { new Guid("f2bdf65f-cea2-4752-85c1-bfc3724aae23"), new Guid("6817032d-3ec2-4d2c-aa2e-45c677a95713"), 5, new Guid("b544fdde-0f46-42ec-90a9-1b8e57cc714a"), new Guid("5ca864e4-311d-4b15-b5e5-097aa4737df8") },
                    { new Guid("f3b5a7cf-e807-41fe-af9e-50c41d3edc0d"), new Guid("77444651-4405-4d76-9878-336411ff989d"), 5, new Guid("daf39776-c84a-4753-aac8-1a67c0d19e63"), new Guid("7ad43aa2-432f-46d4-a3d8-e73c3d563151") },
                    { new Guid("f4550f45-257f-455b-86b6-cf07403c7670"), new Guid("568156a7-f424-4a4b-8533-b9d74c470525"), 5, new Guid("c4fd7291-2372-4077-bcaf-b3081f0fac2a"), new Guid("b774dd63-ea0f-4407-a39c-820210664244") },
                    { new Guid("f5598ef3-b122-4c9a-bb25-74141eccdcb9"), new Guid("27b74a76-72c3-499f-b6ab-33cb0b8f42af"), 3, new Guid("c1621a6a-fdc9-4ea1-a2d4-9660a0c398d4"), new Guid("85152918-e9a1-409a-b6de-e41b4eb820ae") },
                    { new Guid("f5617a49-4534-447d-b782-cbe8fac06892"), new Guid("aac1e17d-7fcc-48cd-ad9c-a53a6f07bf37"), 5, new Guid("2c4d2bf8-eb34-429d-a6cb-58fa9305d7fc"), new Guid("db9f172f-f46b-401a-80bf-e4bed52c1e48") },
                    { new Guid("f73af884-3192-4dc6-b9f4-8f3c7e0d9cf8"), new Guid("485fc668-cb56-41c9-b507-28c078a9403c"), 5, new Guid("5956ac6d-7acc-4170-a58e-4abb1bbe8c03"), new Guid("06b5c8a1-3341-469f-be41-2f21368d1818") },
                    { new Guid("f994a944-8b76-4d71-8c36-9b30e7096732"), new Guid("eaba48ad-9e69-4d23-97f3-1c26c3bb1b47"), 4, new Guid("1488267f-307c-4c6e-a13e-10cbf5081f4a"), new Guid("ce04f938-fb8c-4929-95a8-f4bc01317d8e") },
                    { new Guid("f9fbc680-8745-41b7-b3df-822bf9aaf9b0"), new Guid("a7e3ccae-9915-43fd-9de9-f59f83c245af"), 3, new Guid("3038e5d1-8cad-4e72-a71d-9b2ade1552fc"), new Guid("c6d06ad7-af98-4038-b905-54b48b523528") },
                    { new Guid("fa6e99b4-0f43-4bad-ade2-b2b9b63c2242"), new Guid("63c18153-6cf3-4a19-834b-212256b98206"), 1, new Guid("509289c5-1ffd-44dd-869d-77a94639f4f8"), new Guid("9eb0eb95-f058-4f6c-9586-e012584f7bb5") },
                    { new Guid("fa7b2fe9-df0f-495f-a908-30fbf8e7cafb"), new Guid("e6cf78de-d491-478c-9c7f-eab44ef034de"), 1, new Guid("34a6644b-1791-462c-914f-ab0733d96706"), new Guid("d08b8a6c-a3e2-4c3d-a8a6-16faf121be3c") },
                    { new Guid("fa8e6307-aaf8-4be6-8964-61bcc71bdd9a"), new Guid("b3e4a2b9-5259-4082-96a9-617bf67ee553"), 1, new Guid("b87d64b2-b4e9-462d-9aae-855a4640f538"), new Guid("e07a6b34-8f1e-4981-8321-08a0270cd661") },
                    { new Guid("fbb588fb-6cbb-4530-b2fd-cead8ab69f62"), new Guid("01e57640-f435-46b2-92df-c3113d6eff85"), 5, new Guid("9129d570-11b9-4813-8289-2f9524314fa1"), new Guid("5fc8ceae-648c-4982-b35e-03cf3d828bf0") },
                    { new Guid("fc58cb90-3469-4cc3-99a4-cd1b0aa64c51"), new Guid("f94f0e86-107d-444e-afbe-27598496aeec"), 5, new Guid("2eb08f89-4402-4d5b-8b47-d70dd986ab8b"), new Guid("5975379b-423f-4484-9a61-a1dd1c8fde64") },
                    { new Guid("fd3dabcc-66ad-4f30-99a1-d24dac80e306"), new Guid("5e151440-1ff8-43f7-a301-fbeca37c45d4"), 2, new Guid("37c6c31a-39d0-4459-a72c-be36532fe2c7"), new Guid("c125219c-f4ca-45fb-9098-b5a2e4e8ff6e") },
                    { new Guid("fe8c3ff5-ef99-408c-bbb0-2148dfea59bb"), new Guid("826c2e03-c5f1-4d87-8331-64a0e77733ff"), 4, new Guid("b1785b22-0d9c-41af-ad80-cb6f82534a9f"), new Guid("3ba96b55-28f5-48da-9ea6-89197989e103") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "LastName", "Position" },
                values: new object[,]
                {
                    { new Guid("0623c709-b6f1-406a-a333-2da97cdef813"), "Scotty", "McClure", "Senior Quality Planner" },
                    { new Guid("071ed842-f78b-4e57-82a2-c976f1bdd73a"), "Hermina", "Howe", "National Metrics Representative" },
                    { new Guid("07549a7b-6fa3-4f60-8760-4016b33b59ec"), "Alexandrea", "Romaguera", "Principal Branding Executive" },
                    { new Guid("0ae0d136-3af3-4e93-a02a-48583641749d"), "Roman", "Tillman", "Principal Infrastructure Director" },
                    { new Guid("1bd05f1b-c95d-466e-bb8c-2e46337c016f"), "Rolando", "Homenick", "Senior Implementation Specialist" },
                    { new Guid("1d3dbbde-e547-455e-83fc-a13f8d128fa8"), "Madisen", "Legros", "Principal Infrastructure Architect" },
                    { new Guid("21d601c1-f670-4480-aa3e-621557c39d6c"), "Lavina", "Kozey", "Senior Mobility Strategist" },
                    { new Guid("24f8603c-ba71-43a0-9e20-ece0671963e6"), "Isaac", "Huels", "Product Marketing Coordinator" },
                    { new Guid("26e9fbb9-4ca4-490d-af8e-f6c8de252318"), "Tyree", "Schultz", "Chief Assurance Consultant" },
                    { new Guid("2d6ab54c-e86c-4888-a00a-f46bbe19d3f5"), "Maureen", "Schulist", "Dynamic Program Technician" },
                    { new Guid("33b35b28-36b3-437c-a04f-3df255d090cf"), "Litzy", "Nitzsche", "Senior Applications Coordinator" },
                    { new Guid("33e1703f-c1f8-49ad-b39d-b4c5fa5ceffb"), "Serenity", "Barrows", "National Program Administrator" },
                    { new Guid("358c4a65-6495-45db-a27d-4fb03cbe8c27"), "Schuyler", "Hartmann", "Lead Markets Supervisor" },
                    { new Guid("3a7c08af-096d-4a5c-be05-13d7ca700f25"), "Gideon", "Marquardt", "Forward Identity Analyst" },
                    { new Guid("3c328426-c014-493a-aad8-799397391960"), "Enrique", "McClure", "Dynamic Branding Coordinator" },
                    { new Guid("3dadc217-c96c-4967-98c0-5da966491054"), "Evalyn", "Ratke", "Regional Functionality Consultant" },
                    { new Guid("3df42c51-0c6c-49b8-96de-65076cb1a434"), "Marie", "VonRueden", "Regional Factors Analyst" },
                    { new Guid("404effa3-fbc9-454a-8001-1ad3d3ac9413"), "Jailyn", "Cummerata", "Regional Configuration Technician" },
                    { new Guid("41817995-b3d4-4146-8ff4-fde7641aa254"), "Maureen", "Purdy", "Chief Division Specialist" },
                    { new Guid("4f4ec2b7-5638-4820-ab8a-eaacf205e926"), "Dennis", "Fisher", "Legacy Mobility Planner" },
                    { new Guid("5348b7d1-b864-48ff-811b-bd4fe4e6b92c"), "Camila", "Dickens", "Internal Communications Representative" },
                    { new Guid("565ed3dc-5efa-44b4-865c-df121c979faa"), "Mckenzie", "Mohr", "Product Metrics Consultant" },
                    { new Guid("579cb0d0-e312-4570-b8c2-749da843e5e6"), "Tyson", "Auer", "National Paradigm Engineer" },
                    { new Guid("58e2cba6-8da1-4e61-af78-4b0ab83dded4"), "Mireille", "Anderson", "Future Mobility Administrator" },
                    { new Guid("5975c4b5-3d31-49a9-8b38-11afbe50ba49"), "Desiree", "Hodkiewicz", "Direct Quality Liaison" },
                    { new Guid("5d16cb00-fa27-4018-a65c-1095bd4de771"), "Rachelle", "Macejkovic", "Future Identity Administrator" },
                    { new Guid("5f1404e4-e589-4967-804c-e0dce08b9bd8"), "Yessenia", "VonRueden", "Product Paradigm Executive" },
                    { new Guid("5f7c945d-dbcf-4b50-9041-acc040048748"), "Katelyn", "Stokes", "Central Marketing Agent" },
                    { new Guid("64b519eb-e8a9-42d4-94f1-5b6983fce245"), "Norberto", "Franecki", "Central Division Liaison" },
                    { new Guid("65b6b80c-909f-4ae5-b2c1-eb881c71f4b3"), "King", "Ledner", "Customer Identity Manager" },
                    { new Guid("678d3c3d-fa4f-4aa2-bff3-f784bb4e9c8b"), "Elroy", "Herzog", "Internal Branding Analyst" },
                    { new Guid("6bb18b63-d075-4be4-817a-f0ea7e01d709"), "Pascale", "Hermiston", "Future Marketing Engineer" },
                    { new Guid("7406095b-fcc1-459e-9256-a2d121fb3915"), "Ceasar", "Casper", "Direct Web Representative" },
                    { new Guid("7677ced5-2cc6-4e01-af96-8d9e37dcd41b"), "Alfonso", "Kris", "Customer Markets Orchestrator" },
                    { new Guid("77f58067-695a-4a99-8c6f-be70bf80ec78"), "Raymond", "Ortiz", "International Accountability Specialist" },
                    { new Guid("794bc366-2a63-4abd-b72c-73651e049446"), "Stone", "Schumm", "National Security Consultant" },
                    { new Guid("79945dc6-ca50-4c2d-a279-3d0aaf3dbf28"), "Sam", "Weissnat", "Dynamic Directives Liaison" },
                    { new Guid("79e312b9-c9a6-4126-bb7b-7324ac3ad63c"), "Webster", "Hand", "Central Division Analyst" },
                    { new Guid("7c8923fb-0cf0-49ff-8c40-f890173c4054"), "Cleora", "Leannon", "Dynamic Applications Facilitator" },
                    { new Guid("7de98cff-22c8-417d-8f70-ce6a9bd41704"), "Gayle", "Stroman", "Lead Data Director" },
                    { new Guid("80b5550d-b872-41d0-8aa2-ac81d6af6144"), "Adele", "Walker", "Global Implementation Officer" },
                    { new Guid("815dea25-ac67-414d-9d9a-b62c66b63f2b"), "Eloy", "Kilback", "Lead Functionality Liaison" },
                    { new Guid("8306848f-7e77-4328-a5e8-d6de9f52cd2a"), "Amanda", "Homenick", "Regional Creative Executive" },
                    { new Guid("851aa153-687b-479d-8ac5-b771fcdebb59"), "Cedrick", "Schmitt", "Internal Marketing Analyst" },
                    { new Guid("89e94a97-3cc3-42ed-8d4b-50a3f93dc089"), "Osvaldo", "Cormier", "Human Optimization Facilitator" },
                    { new Guid("9108a295-5066-4b2b-bb42-b9348d7ce005"), "Albertha", "Walter", "Senior Tactics Planner" },
                    { new Guid("91412b2d-e0d2-4d06-a6f3-efb89df3d507"), "Maryjane", "Sauer", "District Implementation Designer" },
                    { new Guid("9185be87-3c3b-4205-8b8e-c882cfebb96a"), "Reginald", "Anderson", "Forward Paradigm Executive" },
                    { new Guid("9574d6d4-b55f-4aca-9e3b-fcde643ab710"), "Kennedy", "Lakin", "International Response Executive" },
                    { new Guid("95a6b347-fbd2-4403-b674-d2775b93ecd5"), "Harmon", "Mayer", "Senior Integration Consultant" },
                    { new Guid("96971f91-63ab-415c-afa2-63fc9639c0db"), "Alexie", "Murazik", "Human Intranet Assistant" },
                    { new Guid("9820cd84-7fe7-49cd-bdb9-543db13d781e"), "Wendell", "Schuppe", "Product Mobility Facilitator" },
                    { new Guid("993c6f9d-dd37-46ce-9c16-654c2a71d048"), "Delphine", "Russel", "Human Division Facilitator" },
                    { new Guid("9d67e102-d434-4eba-b015-47a6278ea7fb"), "Earline", "Corkery", "Human Configuration Assistant" },
                    { new Guid("a1373d1a-ba24-4a36-8857-c61480809e4b"), "Laurence", "Glover", "Forward Directives Associate" },
                    { new Guid("a2cfcd56-608c-4139-a39a-24a4408ce83b"), "Erik", "Grady", "National Metrics Strategist" },
                    { new Guid("a44ae65e-d8ce-498e-b572-b43fabfbc0d6"), "Serena", "Herzog", "International Marketing Strategist" },
                    { new Guid("a594bc71-7449-4bd7-96d5-a35c44dbc76a"), "Robert", "Baumbach", "Dynamic Brand Specialist" },
                    { new Guid("ae2d28a6-b3c0-4db0-b00f-892001219a20"), "Bradley", "Stanton", "Investor Intranet Administrator" },
                    { new Guid("afdccca4-196e-4699-97a9-c1f304091cb3"), "Tania", "Murphy", "Product Configuration Facilitator" },
                    { new Guid("b76dba8a-b35b-4a60-9894-b5bd00d5831f"), "Lulu", "McKenzie", "Legacy Operations Producer" },
                    { new Guid("bdd86f5c-d6b8-4015-8c90-aaf011d5a810"), "Derrick", "Reinger", "Lead Identity Producer" },
                    { new Guid("cbcb8532-1add-4a65-a7c8-2dcf1107e0b0"), "Elmore", "Olson", "Forward Program Liaison" },
                    { new Guid("cda5d979-fb9c-4ab3-b183-415fcdf326d4"), "Jarrett", "Lubowitz", "Principal Tactics Architect" },
                    { new Guid("d00bb7ca-215f-445d-98cc-fa54dfebade5"), "Elissa", "Sawayn", "Future Assurance Manager" },
                    { new Guid("d10afde9-dda3-46e3-bcf3-1106f39206ac"), "Keshawn", "Brown", "Legacy Branding Strategist" },
                    { new Guid("d1d343f0-3a10-4267-8020-3abfce7a5d9a"), "Mara", "Flatley", "Forward Creative Specialist" },
                    { new Guid("da75499e-a7be-4b84-9b3d-0ca955b0c1da"), "Erich", "Yost", "Corporate Accountability Facilitator" },
                    { new Guid("dc5490f2-702c-4414-921f-9c550d39f517"), "Jazmyn", "Harris", "Human Accountability Technician" },
                    { new Guid("de5b29d8-e4cc-4e05-973d-55eb8154a789"), "Jerry", "Collins", "International Paradigm Assistant" },
                    { new Guid("e46853a9-703b-4a95-8a74-1b375a3925a6"), "Hassan", "Schmitt", "International Metrics Producer" },
                    { new Guid("e9a13f12-04c0-4639-a641-cc7886e38aba"), "Roscoe", "Hoppe", "Dynamic Brand Executive" },
                    { new Guid("ef98a29a-1ec5-4002-87b5-0570064befec"), "Turner", "Zieme", "Internal Mobility Producer" },
                    { new Guid("f52f7a9f-95a0-4a6a-9025-d90367740709"), "Mellie", "Mohr", "Customer Response Consultant" },
                    { new Guid("fd0f2b23-c1fe-46e5-9c44-4241d2dc64f6"), "Soledad", "Robel", "Central Division Strategist" }
                });

            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "Id", "CampusId", "Capacity", "Number" },
                values: new object[,]
                {
                    { new Guid("10e90b80-7b6a-408e-aadf-3da9a7e49167"), new Guid("d87e7e65-e11f-4b0c-b0af-a3a83634fa7d"), 61, 145 },
                    { new Guid("16a9b4f4-cd60-42d4-b614-ce24b3e4e383"), new Guid("65f4bdd4-54de-4386-af36-4dec081e1795"), 90, 378 },
                    { new Guid("1b868a5d-8185-4b45-98f6-0898a2900ee6"), new Guid("24fdcb96-0e61-434b-b8d4-b3799e61ab81"), 86, 929 },
                    { new Guid("21b4587c-aa4e-40d8-a29e-585af839115a"), new Guid("24fdcb96-0e61-434b-b8d4-b3799e61ab81"), 76, 773 },
                    { new Guid("21c9043f-325b-49fd-a636-d7a874cd5e16"), new Guid("50ea5bc9-6b16-4e67-99f1-507a10a9cf5e"), 87, 280 },
                    { new Guid("290d6f14-1196-4c7a-9e91-6b7c01f61e77"), new Guid("1f2d8ba2-f238-4997-a776-32d088586268"), 32, 516 },
                    { new Guid("45c90dfb-8884-4f5a-9fec-0a8c9650c507"), new Guid("24fdcb96-0e61-434b-b8d4-b3799e61ab81"), 34, 919 },
                    { new Guid("478ccce7-78a9-4f88-a5a1-b242e3e47840"), new Guid("1f2d8ba2-f238-4997-a776-32d088586268"), 34, 667 },
                    { new Guid("50e36ae8-0290-402c-b3ca-a0cd8703a9a1"), new Guid("24fdcb96-0e61-434b-b8d4-b3799e61ab81"), 66, 489 },
                    { new Guid("697d6699-930b-4a75-857c-435600afbe49"), new Guid("d87e7e65-e11f-4b0c-b0af-a3a83634fa7d"), 66, 855 },
                    { new Guid("78267685-256e-4dac-9906-e560433b8cce"), new Guid("d87e7e65-e11f-4b0c-b0af-a3a83634fa7d"), 25, 250 },
                    { new Guid("78f16233-1904-47c8-8b6d-b557cd4997b7"), new Guid("d87e7e65-e11f-4b0c-b0af-a3a83634fa7d"), 97, 509 },
                    { new Guid("79652742-270f-4367-97f7-92919fb52d04"), new Guid("50ea5bc9-6b16-4e67-99f1-507a10a9cf5e"), 23, 461 },
                    { new Guid("8e47ca51-a8fa-476c-be47-f51e2595c559"), new Guid("65f4bdd4-54de-4386-af36-4dec081e1795"), 88, 377 },
                    { new Guid("98577e8c-d9a5-4c1f-b214-deab3e2f9021"), new Guid("50ea5bc9-6b16-4e67-99f1-507a10a9cf5e"), 91, 654 },
                    { new Guid("b5cceafa-c99d-407b-a929-c84b3427b7cc"), new Guid("65f4bdd4-54de-4386-af36-4dec081e1795"), 34, 609 },
                    { new Guid("bbbd27df-ea1f-4192-aaf8-1e69aaa13702"), new Guid("50ea5bc9-6b16-4e67-99f1-507a10a9cf5e"), 81, 465 },
                    { new Guid("c3b59913-4ca8-4e2d-a5f7-984f458f1b19"), new Guid("1f2d8ba2-f238-4997-a776-32d088586268"), 47, 332 },
                    { new Guid("cc2c1cde-d03e-4420-b1d7-24471cba76a8"), new Guid("d87e7e65-e11f-4b0c-b0af-a3a83634fa7d"), 55, 320 },
                    { new Guid("cd02db85-744f-4995-83e5-ce36f8f8328c"), new Guid("1f2d8ba2-f238-4997-a776-32d088586268"), 38, 816 },
                    { new Guid("d2346294-e7fa-4c42-9e02-348a2e9b3a82"), new Guid("1f2d8ba2-f238-4997-a776-32d088586268"), 33, 768 },
                    { new Guid("d508895f-0a51-4cb3-b7e4-681c2057685b"), new Guid("65f4bdd4-54de-4386-af36-4dec081e1795"), 33, 156 },
                    { new Guid("e22c2456-b828-4d1b-8217-6dd5ed93c49d"), new Guid("50ea5bc9-6b16-4e67-99f1-507a10a9cf5e"), 28, 127 },
                    { new Guid("ea9fa6a5-0772-4a35-9e5a-ca5cff512801"), new Guid("65f4bdd4-54de-4386-af36-4dec081e1795"), 34, 410 },
                    { new Guid("f8e3b049-62c7-4225-86c1-de90fb63749a"), new Guid("24fdcb96-0e61-434b-b8d4-b3799e61ab81"), 23, 840 }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CampusId", "Name" },
                values: new object[,]
                {
                    { new Guid("0b665598-69f5-4b13-bde4-1394ff5c31dc"), new Guid("24fdcb96-0e61-434b-b8d4-b3799e61ab81"), "Games, Kids & Garden" },
                    { new Guid("0d93d483-255a-4943-b456-c170b7309702"), new Guid("50ea5bc9-6b16-4e67-99f1-507a10a9cf5e"), "Home, Industrial & Automotive" },
                    { new Guid("0f05fada-c852-4f14-beff-141c6ea5c26e"), new Guid("d87e7e65-e11f-4b0c-b0af-a3a83634fa7d"), "Jewelery, Books & Movies" },
                    { new Guid("1a314662-8534-495b-b374-7ef2bb9b4bae"), new Guid("1f2d8ba2-f238-4997-a776-32d088586268"), "Kids & Grocery" },
                    { new Guid("2c8fcd5b-a661-46a3-ac62-fda4e2ef789c"), new Guid("65f4bdd4-54de-4386-af36-4dec081e1795"), "Home" },
                    { new Guid("35247627-3f8b-4c56-8f6d-7c8ab4c64047"), new Guid("d87e7e65-e11f-4b0c-b0af-a3a83634fa7d"), "Sports & Home" },
                    { new Guid("3667884a-88e0-48ba-81ad-dd08e4f6513f"), new Guid("50ea5bc9-6b16-4e67-99f1-507a10a9cf5e"), "Electronics" },
                    { new Guid("3fafcc9f-d1f3-410e-a884-d616abadbfd2"), new Guid("1f2d8ba2-f238-4997-a776-32d088586268"), "Sports, Sports & Tools" },
                    { new Guid("48e8e41d-9d51-45db-98c6-5247fcf4a102"), new Guid("65f4bdd4-54de-4386-af36-4dec081e1795"), "Tools & Music" },
                    { new Guid("6611d417-e14a-4edf-8ba4-58689b831ee9"), new Guid("65f4bdd4-54de-4386-af36-4dec081e1795"), "Garden" },
                    { new Guid("69706726-60c9-4c05-8855-e54e469466cc"), new Guid("50ea5bc9-6b16-4e67-99f1-507a10a9cf5e"), "Books & Outdoors" },
                    { new Guid("718ba29e-2d49-4a4c-a9a6-9680a379181e"), new Guid("65f4bdd4-54de-4386-af36-4dec081e1795"), "Games & Toys" },
                    { new Guid("87b74d9d-d153-4f65-83c4-718345f266aa"), new Guid("24fdcb96-0e61-434b-b8d4-b3799e61ab81"), "Kids, Clothing & Music" },
                    { new Guid("8e5af34b-4511-4796-9027-7ed8ffdef45a"), new Guid("1f2d8ba2-f238-4997-a776-32d088586268"), "Shoes, Garden & Automotive" },
                    { new Guid("a00da874-bb29-4e88-aef6-4ba73aa7c6a8"), new Guid("d87e7e65-e11f-4b0c-b0af-a3a83634fa7d"), "Music, Movies & Movies" },
                    { new Guid("b034a33a-0588-4988-8d91-e56505812847"), new Guid("d87e7e65-e11f-4b0c-b0af-a3a83634fa7d"), "Electronics, Jewelery & Grocery" },
                    { new Guid("b1925b99-6048-443d-bb39-9a62fd414bf5"), new Guid("d87e7e65-e11f-4b0c-b0af-a3a83634fa7d"), "Movies & Kids" },
                    { new Guid("b9202822-0576-4839-a1d3-9f0a56b39bcd"), new Guid("1f2d8ba2-f238-4997-a776-32d088586268"), "Health & Baby" },
                    { new Guid("c091d70d-a3ad-405a-b021-5ed4e2079ea1"), new Guid("50ea5bc9-6b16-4e67-99f1-507a10a9cf5e"), "Movies & Grocery" },
                    { new Guid("c235096d-5277-4bc6-9ebf-3bd0441bcfc9"), new Guid("50ea5bc9-6b16-4e67-99f1-507a10a9cf5e"), "Electronics" },
                    { new Guid("cc0d0a24-97e6-4fb9-b52b-a4bf3e0c60ed"), new Guid("24fdcb96-0e61-434b-b8d4-b3799e61ab81"), "Outdoors" },
                    { new Guid("d8f60351-f6ec-4823-a7fc-e7660c635bb7"), new Guid("24fdcb96-0e61-434b-b8d4-b3799e61ab81"), "Games & Baby" },
                    { new Guid("ded29ebf-f062-4958-9f78-8df4fe9599cb"), new Guid("65f4bdd4-54de-4386-af36-4dec081e1795"), "Kids & Jewelery" },
                    { new Guid("e540714c-712f-4c9c-bbe0-3c6e536a18cf"), new Guid("1f2d8ba2-f238-4997-a776-32d088586268"), "Movies & Home" },
                    { new Guid("eb69393b-7dfa-4b8b-b3fe-0e83b6f3a956"), new Guid("24fdcb96-0e61-434b-b8d4-b3799e61ab81"), "Music, Tools & Kids" }
                });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "DepartmentId", "Name", "ShortName" },
                values: new object[,]
                {
                    { new Guid("079c1f5f-9a13-42da-9752-c509d0236dd6"), new Guid("2c8fcd5b-a661-46a3-ac62-fda4e2ef789c"), "Practical Concrete Computer", "laborum" },
                    { new Guid("0b1f6ebb-8341-4a3d-960e-031a36568e95"), new Guid("ded29ebf-f062-4958-9f78-8df4fe9599cb"), "Gorgeous Metal Ball", "vel" },
                    { new Guid("0d90cb0e-0383-4751-96e5-d8aae5c70976"), new Guid("35247627-3f8b-4c56-8f6d-7c8ab4c64047"), "Ergonomic Granite Cheese", "sunt" },
                    { new Guid("134393a6-1447-4b91-a450-72a5313fe48c"), new Guid("c091d70d-a3ad-405a-b021-5ed4e2079ea1"), "Sleek Cotton Chips", "deleniti" },
                    { new Guid("1372f0f6-98af-47c2-b0e9-ebb9ee9baa78"), new Guid("48e8e41d-9d51-45db-98c6-5247fcf4a102"), "Gorgeous Frozen Ball", "eligendi" },
                    { new Guid("13e26ac0-731e-416b-93ef-9b52232ba5bb"), new Guid("b1925b99-6048-443d-bb39-9a62fd414bf5"), "Unbranded Granite Salad", "non" },
                    { new Guid("141743c3-7ef7-4599-8eea-8dc0d5914a57"), new Guid("0d93d483-255a-4943-b456-c170b7309702"), "Refined Soft Chicken", "cum" },
                    { new Guid("14301c9f-060e-4727-936e-84f0fad20a04"), new Guid("718ba29e-2d49-4a4c-a9a6-9680a379181e"), "Gorgeous Concrete Pants", "tempore" },
                    { new Guid("1494ba89-7ca9-4494-b4ca-ac7dc5d1ca05"), new Guid("3667884a-88e0-48ba-81ad-dd08e4f6513f"), "Tasty Frozen Bacon", "voluptas" },
                    { new Guid("15dfe2bd-68c9-4d85-aadd-f6847119ed68"), new Guid("69706726-60c9-4c05-8855-e54e469466cc"), "Fantastic Plastic Chicken", "inventore" },
                    { new Guid("16fae056-d808-4ff7-a090-c2b59ba13f9a"), new Guid("0f05fada-c852-4f14-beff-141c6ea5c26e"), "Sleek Concrete Shirt", "facilis" },
                    { new Guid("22437554-dfc6-4983-bff8-18361937f9b8"), new Guid("2c8fcd5b-a661-46a3-ac62-fda4e2ef789c"), "Handmade Wooden Fish", "est" },
                    { new Guid("27381a99-afee-4ddf-8148-50fbf7e49b08"), new Guid("b034a33a-0588-4988-8d91-e56505812847"), "Licensed Metal Keyboard", "officiis" },
                    { new Guid("2c9fc2e6-5da3-4e28-95cc-8cd97cafce46"), new Guid("b1925b99-6048-443d-bb39-9a62fd414bf5"), "Practical Frozen Computer", "libero" },
                    { new Guid("33669538-50fe-4c00-9664-75d66edc1ed9"), new Guid("6611d417-e14a-4edf-8ba4-58689b831ee9"), "Sleek Plastic Shirt", "necessitatibus" },
                    { new Guid("336d58aa-a2b3-4c39-ae3c-9a71804db984"), new Guid("b1925b99-6048-443d-bb39-9a62fd414bf5"), "Fantastic Cotton Bike", "praesentium" },
                    { new Guid("3e3f8c66-adc9-4a81-929c-42fdf2ff8047"), new Guid("d8f60351-f6ec-4823-a7fc-e7660c635bb7"), "Handmade Frozen Shoes", "id" },
                    { new Guid("409baa2a-e4f7-4f41-9529-404d1750dafb"), new Guid("48e8e41d-9d51-45db-98c6-5247fcf4a102"), "Generic Frozen Ball", "laborum" },
                    { new Guid("4181cae3-4c20-472d-8ac4-bd7de6d4ddb4"), new Guid("0b665598-69f5-4b13-bde4-1394ff5c31dc"), "Tasty Rubber Bacon", "in" },
                    { new Guid("4413fb08-8682-4dba-9205-021b4631f9c3"), new Guid("3fafcc9f-d1f3-410e-a884-d616abadbfd2"), "Handmade Frozen Shoes", "deserunt" },
                    { new Guid("4603dd1c-28ad-4140-b6f8-d2cbf465f8af"), new Guid("b034a33a-0588-4988-8d91-e56505812847"), "Sleek Rubber Cheese", "velit" },
                    { new Guid("4809a7f9-15af-4f0e-a83c-de450fcf4071"), new Guid("d8f60351-f6ec-4823-a7fc-e7660c635bb7"), "Handmade Wooden Fish", "dolor" },
                    { new Guid("52c45776-b51e-4c95-ae9f-5cc43e0d563e"), new Guid("718ba29e-2d49-4a4c-a9a6-9680a379181e"), "Intelligent Steel Chips", "iste" },
                    { new Guid("5418b0eb-06fe-4d4d-8deb-8a20872852ae"), new Guid("0d93d483-255a-4943-b456-c170b7309702"), "Intelligent Wooden Bacon", "autem" },
                    { new Guid("599de2d0-a1c0-4347-ac69-e30e0ec08940"), new Guid("1a314662-8534-495b-b374-7ef2bb9b4bae"), "Generic Steel Pizza", "voluptatem" },
                    { new Guid("5aa8d7cf-38a7-4635-bf67-b8640048c5cb"), new Guid("c235096d-5277-4bc6-9ebf-3bd0441bcfc9"), "Licensed Metal Soap", "praesentium" },
                    { new Guid("62ca8d41-2f31-4e0a-9720-37e743d758db"), new Guid("e540714c-712f-4c9c-bbe0-3c6e536a18cf"), "Tasty Frozen Soap", "aut" },
                    { new Guid("6319fe3c-4257-431e-abbf-3d770192a419"), new Guid("48e8e41d-9d51-45db-98c6-5247fcf4a102"), "Handcrafted Steel Pants", "reiciendis" },
                    { new Guid("63782e5d-dd7d-4bff-b1d4-c55623704a8a"), new Guid("69706726-60c9-4c05-8855-e54e469466cc"), "Incredible Rubber Fish", "qui" },
                    { new Guid("6a92b389-1096-4fb8-9d6f-ccf649f45865"), new Guid("c235096d-5277-4bc6-9ebf-3bd0441bcfc9"), "Licensed Rubber Chair", "quos" },
                    { new Guid("6e4add3b-b1d0-48df-8498-a5b48de2f486"), new Guid("1a314662-8534-495b-b374-7ef2bb9b4bae"), "Generic Frozen Car", "aut" },
                    { new Guid("764286d0-d664-4e8b-bf2c-f58855a7a9d5"), new Guid("8e5af34b-4511-4796-9027-7ed8ffdef45a"), "Refined Frozen Shirt", "et" },
                    { new Guid("76f21dc3-2936-4f79-98f8-087df6f58ea1"), new Guid("cc0d0a24-97e6-4fb9-b52b-a4bf3e0c60ed"), "Ergonomic Fresh Hat", "et" },
                    { new Guid("7a245829-c0ee-4959-9e9c-599e373798ea"), new Guid("eb69393b-7dfa-4b8b-b3fe-0e83b6f3a956"), "Tasty Metal Cheese", "fugit" },
                    { new Guid("7bb08f79-f643-47fe-ab49-cfc044089131"), new Guid("a00da874-bb29-4e88-aef6-4ba73aa7c6a8"), "Fantastic Frozen Hat", "corrupti" },
                    { new Guid("7ee048ce-0791-40e6-ac98-76651bb834b9"), new Guid("2c8fcd5b-a661-46a3-ac62-fda4e2ef789c"), "Sleek Steel Chips", "ut" },
                    { new Guid("7f4b1180-c2e9-477d-8fc1-e543c9b34826"), new Guid("eb69393b-7dfa-4b8b-b3fe-0e83b6f3a956"), "Fantastic Rubber Salad", "voluptas" },
                    { new Guid("8674645b-44f7-45d1-be63-e4f4333201c3"), new Guid("87b74d9d-d153-4f65-83c4-718345f266aa"), "Sleek Wooden Computer", "nobis" },
                    { new Guid("8be9f3b9-74e1-41ab-b53a-0086eeb59387"), new Guid("ded29ebf-f062-4958-9f78-8df4fe9599cb"), "Handcrafted Wooden Chicken", "voluptatum" },
                    { new Guid("8d8475f7-06aa-4cfb-bb5e-7f0d6e85fb8b"), new Guid("ded29ebf-f062-4958-9f78-8df4fe9599cb"), "Handcrafted Cotton Shirt", "voluptatem" },
                    { new Guid("8ffc6a92-396e-405f-8a7f-c28dc9d0172e"), new Guid("0f05fada-c852-4f14-beff-141c6ea5c26e"), "Tasty Frozen Salad", "non" },
                    { new Guid("942ef1c3-4b9d-4e9a-ae01-2f7258d199d1"), new Guid("69706726-60c9-4c05-8855-e54e469466cc"), "Rustic Frozen Chicken", "vero" },
                    { new Guid("9d6bc2ed-16ad-465b-bf31-6b6815a46dad"), new Guid("a00da874-bb29-4e88-aef6-4ba73aa7c6a8"), "Tasty Granite Tuna", "quo" },
                    { new Guid("9da6ac92-6270-41d2-a0e1-af09b1188a89"), new Guid("e540714c-712f-4c9c-bbe0-3c6e536a18cf"), "Ergonomic Steel Shirt", "eum" },
                    { new Guid("a208b60e-1c11-4c3f-89ba-23a121f4a6a7"), new Guid("b034a33a-0588-4988-8d91-e56505812847"), "Practical Concrete Shirt", "recusandae" },
                    { new Guid("a37c9c83-b019-4163-8675-278bb5d775f7"), new Guid("3fafcc9f-d1f3-410e-a884-d616abadbfd2"), "Rustic Plastic Salad", "sunt" },
                    { new Guid("a3bbc08c-f9cf-4a3f-abd8-3d7fe71c709b"), new Guid("d8f60351-f6ec-4823-a7fc-e7660c635bb7"), "Handcrafted Wooden Towels", "ut" },
                    { new Guid("acdfcedd-aad5-4f1d-be2b-2db1869ef127"), new Guid("0f05fada-c852-4f14-beff-141c6ea5c26e"), "Unbranded Plastic Keyboard", "eos" },
                    { new Guid("aeea471a-664f-4c08-b21a-693cab754306"), new Guid("1a314662-8534-495b-b374-7ef2bb9b4bae"), "Small Frozen Tuna", "amet" },
                    { new Guid("b47ded01-fc7f-4514-ab88-165b635b232d"), new Guid("35247627-3f8b-4c56-8f6d-7c8ab4c64047"), "Fantastic Metal Pants", "aut" },
                    { new Guid("b52a1eff-f4e7-4b1a-ad2c-6d954315fcf3"), new Guid("8e5af34b-4511-4796-9027-7ed8ffdef45a"), "Generic Fresh Mouse", "perferendis" },
                    { new Guid("b9e6c2e4-95d6-48fb-afd5-011e7a74b887"), new Guid("6611d417-e14a-4edf-8ba4-58689b831ee9"), "Refined Granite Fish", "distinctio" },
                    { new Guid("bbaf0525-606b-489f-82c4-e14e235daeea"), new Guid("87b74d9d-d153-4f65-83c4-718345f266aa"), "Ergonomic Rubber Bacon", "voluptas" },
                    { new Guid("bbbc1f80-e7a8-46a7-82af-3ca360350d72"), new Guid("b9202822-0576-4839-a1d3-9f0a56b39bcd"), "Awesome Soft Cheese", "officiis" },
                    { new Guid("c73ad9a9-08ac-4932-84a3-dfad6dce2e1f"), new Guid("3667884a-88e0-48ba-81ad-dd08e4f6513f"), "Rustic Rubber Ball", "aperiam" },
                    { new Guid("cb282835-6e97-4547-b952-f3e14c7d4b73"), new Guid("0d93d483-255a-4943-b456-c170b7309702"), "Gorgeous Steel Cheese", "enim" },
                    { new Guid("cc0c34f1-0e09-4824-98d3-d38e6cfeaa1b"), new Guid("b9202822-0576-4839-a1d3-9f0a56b39bcd"), "Fantastic Rubber Hat", "quae" },
                    { new Guid("cd5f0727-34a2-423b-9867-435b9c7fb737"), new Guid("3667884a-88e0-48ba-81ad-dd08e4f6513f"), "Handcrafted Cotton Keyboard", "non" },
                    { new Guid("d4143b7f-28c1-4e2d-8d98-dc55dca3efed"), new Guid("c091d70d-a3ad-405a-b021-5ed4e2079ea1"), "Small Metal Sausages", "molestiae" },
                    { new Guid("d43af315-c5b6-493b-a4ca-0b439d479efd"), new Guid("c091d70d-a3ad-405a-b021-5ed4e2079ea1"), "Unbranded Metal Pants", "neque" },
                    { new Guid("d4400925-c3b7-4df4-978c-502fb60f7b27"), new Guid("3fafcc9f-d1f3-410e-a884-d616abadbfd2"), "Rustic Steel Cheese", "doloremque" },
                    { new Guid("dad8cca0-bead-4ead-98a6-1e2301050923"), new Guid("cc0d0a24-97e6-4fb9-b52b-a4bf3e0c60ed"), "Fantastic Cotton Chips", "velit" },
                    { new Guid("df1cd750-319b-4d6c-9a82-d38451293f0e"), new Guid("87b74d9d-d153-4f65-83c4-718345f266aa"), "Refined Fresh Ball", "culpa" },
                    { new Guid("df7a1aa8-f5c1-4d5b-9977-8e0c41eabae9"), new Guid("e540714c-712f-4c9c-bbe0-3c6e536a18cf"), "Licensed Soft Chips", "iste" },
                    { new Guid("e1bcde56-0d7d-4de9-ada2-d8455de9c464"), new Guid("cc0d0a24-97e6-4fb9-b52b-a4bf3e0c60ed"), "Handcrafted Steel Pants", "eligendi" },
                    { new Guid("e357c912-aaff-46d9-bb70-8f122e93195c"), new Guid("0b665598-69f5-4b13-bde4-1394ff5c31dc"), "Tasty Concrete Salad", "magnam" },
                    { new Guid("ea703f0a-2534-4907-acb5-460824f51a0e"), new Guid("6611d417-e14a-4edf-8ba4-58689b831ee9"), "Tasty Cotton Bike", "ut" },
                    { new Guid("f282d535-2f97-4ca7-bcbc-082db02197dc"), new Guid("35247627-3f8b-4c56-8f6d-7c8ab4c64047"), "Fantastic Metal Cheese", "eaque" },
                    { new Guid("f3e2c4d7-acd3-46c6-8e68-ab018d652175"), new Guid("718ba29e-2d49-4a4c-a9a6-9680a379181e"), "Refined Plastic Car", "quae" },
                    { new Guid("f47fdf6b-29d6-4cfb-b7cc-524efb550bbb"), new Guid("b9202822-0576-4839-a1d3-9f0a56b39bcd"), "Licensed Fresh Gloves", "voluptatibus" },
                    { new Guid("faa0fa37-e817-4570-9f94-613bdcfa43c1"), new Guid("a00da874-bb29-4e88-aef6-4ba73aa7c6a8"), "Handmade Soft Fish", "adipisci" },
                    { new Guid("fc11f3de-3979-491e-b264-8766b2d45075"), new Guid("eb69393b-7dfa-4b8b-b3fe-0e83b6f3a956"), "Handmade Cotton Cheese", "voluptatem" },
                    { new Guid("fc4161d0-d6db-43e6-bb75-2e27867a347c"), new Guid("c235096d-5277-4bc6-9ebf-3bd0441bcfc9"), "Gorgeous Concrete Chicken", "iusto" },
                    { new Guid("fd4b5fc4-c644-4a74-8e8c-d13d742d34fd"), new Guid("0b665598-69f5-4b13-bde4-1394ff5c31dc"), "Sleek Granite Hat", "sed" },
                    { new Guid("ff3b4be5-31be-4259-be30-91f764427a58"), new Guid("8e5af34b-4511-4796-9027-7ed8ffdef45a"), "Practical Soft Table", "ratione" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Course", "DepartmentId", "EndYear", "IdentityNumber", "Name", "StartYear", "StudentCount" },
                values: new object[,]
                {
                    { new Guid("0015c57c-c826-41c5-842b-bf2b1c2f460e"), 2, new Guid("48e8e41d-9d51-45db-98c6-5247fcf4a102"), new DateOnly(2028, 7, 2), 6790, "Clothing & Music", new DateOnly(2023, 8, 11), 32 },
                    { new Guid("0b6cb1a4-b994-44e5-a59e-28d14f0b24d9"), 1, new Guid("a00da874-bb29-4e88-aef6-4ba73aa7c6a8"), new DateOnly(2026, 6, 13), 9697, "Sports", new DateOnly(2024, 2, 7), 35 },
                    { new Guid("0d7dc49f-38c6-46e7-87cd-50b282218edd"), 2, new Guid("cc0d0a24-97e6-4fb9-b52b-a4bf3e0c60ed"), new DateOnly(2025, 9, 11), 9359, "Automotive", new DateOnly(2021, 8, 19), 23 },
                    { new Guid("13f3bd78-b50b-4125-8502-a5e60b2ebd68"), 4, new Guid("d8f60351-f6ec-4823-a7fc-e7660c635bb7"), new DateOnly(2025, 12, 31), 6214, "Tools", new DateOnly(2024, 2, 12), 35 },
                    { new Guid("14fead64-9c45-4d91-be9b-3b2790c13108"), 1, new Guid("cc0d0a24-97e6-4fb9-b52b-a4bf3e0c60ed"), new DateOnly(2028, 5, 30), 6222, "Jewelery & Health", new DateOnly(2024, 5, 20), 45 },
                    { new Guid("163510ae-6c01-4590-ad76-38dcf5c9e5dd"), 3, new Guid("6611d417-e14a-4edf-8ba4-58689b831ee9"), new DateOnly(2027, 6, 14), 4652, "Electronics", new DateOnly(2022, 1, 28), 22 },
                    { new Guid("163da3eb-db44-4132-9764-5a191bcdcc4a"), 2, new Guid("c235096d-5277-4bc6-9ebf-3bd0441bcfc9"), new DateOnly(2028, 9, 6), 9350, "Music", new DateOnly(2022, 9, 24), 34 },
                    { new Guid("16c5a01c-5c22-4ca3-bf1d-b8f6a45afd59"), 3, new Guid("3667884a-88e0-48ba-81ad-dd08e4f6513f"), new DateOnly(2025, 1, 5), 8580, "Baby & Toys", new DateOnly(2022, 6, 14), 16 },
                    { new Guid("1d06cdfc-41c5-4d68-995a-4d968f8b3a8a"), 4, new Guid("6611d417-e14a-4edf-8ba4-58689b831ee9"), new DateOnly(2027, 8, 24), 2302, "Beauty & Industrial", new DateOnly(2024, 11, 2), 23 },
                    { new Guid("205bea5a-d106-4efc-911b-f56c66e86e6e"), 4, new Guid("eb69393b-7dfa-4b8b-b3fe-0e83b6f3a956"), new DateOnly(2025, 3, 11), 9636, "Music, Outdoors & Clothing", new DateOnly(2024, 11, 19), 34 },
                    { new Guid("2144110f-6e16-47d6-acd2-9bf54bf033fc"), 3, new Guid("6611d417-e14a-4edf-8ba4-58689b831ee9"), new DateOnly(2028, 9, 19), 7087, "Home", new DateOnly(2023, 1, 29), 21 },
                    { new Guid("25ca6abc-b376-4b29-b8c2-b8c365c441a4"), 3, new Guid("69706726-60c9-4c05-8855-e54e469466cc"), new DateOnly(2027, 1, 20), 9598, "Industrial & Toys", new DateOnly(2021, 5, 25), 23 },
                    { new Guid("26bdebaf-de26-433d-b13b-29fd4689d6cc"), 3, new Guid("d8f60351-f6ec-4823-a7fc-e7660c635bb7"), new DateOnly(2025, 8, 19), 3515, "Industrial & Tools", new DateOnly(2023, 5, 20), 23 },
                    { new Guid("3378301d-663c-44a8-b72e-759d616d44cd"), 2, new Guid("eb69393b-7dfa-4b8b-b3fe-0e83b6f3a956"), new DateOnly(2026, 8, 26), 7142, "Outdoors & Grocery", new DateOnly(2021, 7, 20), 24 },
                    { new Guid("34924e04-1c79-4233-83e5-cf3aa39e046d"), 3, new Guid("0f05fada-c852-4f14-beff-141c6ea5c26e"), new DateOnly(2028, 7, 8), 1104, "Shoes & Garden", new DateOnly(2021, 2, 1), 25 },
                    { new Guid("399b750c-f68a-4ce3-b5ff-0cfac69d0d05"), 4, new Guid("35247627-3f8b-4c56-8f6d-7c8ab4c64047"), new DateOnly(2028, 1, 8), 5428, "Industrial", new DateOnly(2023, 6, 21), 42 },
                    { new Guid("3de200d7-ae64-4ccb-af31-8bb07b976a26"), 3, new Guid("0d93d483-255a-4943-b456-c170b7309702"), new DateOnly(2025, 6, 15), 6383, "Books & Computers", new DateOnly(2024, 6, 23), 24 },
                    { new Guid("3eaf3477-0f70-4472-b07c-d86348e399f1"), 3, new Guid("8e5af34b-4511-4796-9027-7ed8ffdef45a"), new DateOnly(2027, 6, 18), 2899, "Music & Tools", new DateOnly(2024, 10, 27), 18 },
                    { new Guid("418b576f-a1eb-42f4-9065-3353f3885835"), 3, new Guid("718ba29e-2d49-4a4c-a9a6-9680a379181e"), new DateOnly(2026, 7, 15), 1552, "Outdoors & Shoes", new DateOnly(2024, 3, 1), 27 },
                    { new Guid("4b2cbd44-880c-48d5-97fb-fc382db8c76a"), 3, new Guid("69706726-60c9-4c05-8855-e54e469466cc"), new DateOnly(2027, 9, 25), 7226, "Sports & Baby", new DateOnly(2022, 2, 13), 45 },
                    { new Guid("4e3c96fe-8053-4c82-ad5c-7026731da5d8"), 4, new Guid("c091d70d-a3ad-405a-b021-5ed4e2079ea1"), new DateOnly(2025, 10, 18), 6282, "Movies & Grocery", new DateOnly(2022, 12, 16), 44 },
                    { new Guid("5300d798-c552-437b-a30d-cff5a10fa3c8"), 1, new Guid("35247627-3f8b-4c56-8f6d-7c8ab4c64047"), new DateOnly(2027, 4, 26), 3381, "Music & Computers", new DateOnly(2022, 6, 8), 50 },
                    { new Guid("5a0ceab3-f0ef-4f92-bde5-aba6400ddeb3"), 4, new Guid("ded29ebf-f062-4958-9f78-8df4fe9599cb"), new DateOnly(2027, 6, 3), 7677, "Garden, Home & Beauty", new DateOnly(2020, 12, 20), 29 },
                    { new Guid("5bcb92c4-85d5-4123-bd6a-ed70e5d5a4db"), 3, new Guid("b034a33a-0588-4988-8d91-e56505812847"), new DateOnly(2026, 3, 5), 9206, "Clothing & Toys", new DateOnly(2021, 4, 13), 44 },
                    { new Guid("5e2c5009-1b59-47b7-9745-46aa04e86286"), 4, new Guid("a00da874-bb29-4e88-aef6-4ba73aa7c6a8"), new DateOnly(2025, 7, 28), 8504, "Music, Toys & Kids", new DateOnly(2021, 10, 17), 40 },
                    { new Guid("5e65be20-4c78-4fc5-ac29-da11ecbd4571"), 1, new Guid("0b665598-69f5-4b13-bde4-1394ff5c31dc"), new DateOnly(2027, 1, 30), 8897, "Health & Jewelery", new DateOnly(2021, 1, 6), 39 },
                    { new Guid("60b87c2f-3ed3-4405-a1a2-c67b403d665a"), 2, new Guid("1a314662-8534-495b-b374-7ef2bb9b4bae"), new DateOnly(2027, 1, 9), 4250, "Books, Kids & Games", new DateOnly(2021, 1, 24), 32 },
                    { new Guid("6217bdc2-70bb-424b-bcef-8cea17dc2bbb"), 1, new Guid("c091d70d-a3ad-405a-b021-5ed4e2079ea1"), new DateOnly(2025, 8, 21), 8116, "Baby", new DateOnly(2022, 3, 27), 10 },
                    { new Guid("62b1df70-c449-40a8-89a8-143b42f06eeb"), 3, new Guid("2c8fcd5b-a661-46a3-ac62-fda4e2ef789c"), new DateOnly(2026, 6, 30), 5917, "Kids, Outdoors & Electronics", new DateOnly(2022, 1, 17), 47 },
                    { new Guid("62b81d64-1b94-4ba2-a658-a085ad6b193b"), 3, new Guid("87b74d9d-d153-4f65-83c4-718345f266aa"), new DateOnly(2025, 6, 4), 5851, "Baby", new DateOnly(2022, 5, 23), 40 },
                    { new Guid("654c50c8-6393-4c8d-a318-8d65e664eac7"), 3, new Guid("0b665598-69f5-4b13-bde4-1394ff5c31dc"), new DateOnly(2027, 7, 15), 2161, "Sports & Clothing", new DateOnly(2023, 7, 19), 31 },
                    { new Guid("66879e4a-b57f-43ae-9feb-04ae781c3878"), 4, new Guid("e540714c-712f-4c9c-bbe0-3c6e536a18cf"), new DateOnly(2025, 7, 5), 5383, "Electronics & Automotive", new DateOnly(2023, 4, 29), 22 },
                    { new Guid("68be8a62-d0b6-49c5-bfb4-60ee603d1225"), 4, new Guid("48e8e41d-9d51-45db-98c6-5247fcf4a102"), new DateOnly(2028, 9, 18), 1844, "Grocery", new DateOnly(2021, 3, 4), 31 },
                    { new Guid("6b32f0f8-baa0-40a0-9eeb-f1442b2e75fa"), 2, new Guid("718ba29e-2d49-4a4c-a9a6-9680a379181e"), new DateOnly(2025, 9, 14), 2237, "Home", new DateOnly(2021, 7, 5), 32 },
                    { new Guid("7229335a-e8bd-4c03-8cb1-7842b90377f5"), 2, new Guid("0f05fada-c852-4f14-beff-141c6ea5c26e"), new DateOnly(2027, 10, 28), 8385, "Computers, Jewelery & Shoes", new DateOnly(2022, 10, 18), 16 },
                    { new Guid("737d4017-89b8-4eae-81f5-76f838aae88e"), 1, new Guid("718ba29e-2d49-4a4c-a9a6-9680a379181e"), new DateOnly(2025, 6, 5), 7292, "Baby, Jewelery & Outdoors", new DateOnly(2023, 6, 27), 21 },
                    { new Guid("76ff1cfc-0b7e-42e1-93df-d974de7298e4"), 3, new Guid("8e5af34b-4511-4796-9027-7ed8ffdef45a"), new DateOnly(2025, 8, 28), 8678, "Beauty", new DateOnly(2021, 4, 28), 21 },
                    { new Guid("7aa756f5-3160-4713-b53f-6aa669f0f7a7"), 1, new Guid("b9202822-0576-4839-a1d3-9f0a56b39bcd"), new DateOnly(2028, 1, 21), 8412, "Sports", new DateOnly(2023, 10, 1), 19 },
                    { new Guid("7aae947c-5e75-4aa1-a804-00e48c7f7d71"), 4, new Guid("8e5af34b-4511-4796-9027-7ed8ffdef45a"), new DateOnly(2025, 12, 19), 7312, "Sports", new DateOnly(2024, 5, 7), 13 },
                    { new Guid("7b8c5319-adf4-4bd8-93ae-c8624bc88132"), 3, new Guid("69706726-60c9-4c05-8855-e54e469466cc"), new DateOnly(2025, 4, 26), 5344, "Shoes, Shoes & Baby", new DateOnly(2023, 11, 12), 32 },
                    { new Guid("7bf52f18-2e0b-4a69-8d7a-52c08c05d2df"), 3, new Guid("2c8fcd5b-a661-46a3-ac62-fda4e2ef789c"), new DateOnly(2027, 5, 23), 5727, "Shoes", new DateOnly(2023, 8, 18), 32 },
                    { new Guid("7cc1c799-2271-405e-987c-832b903ba744"), 4, new Guid("48e8e41d-9d51-45db-98c6-5247fcf4a102"), new DateOnly(2026, 9, 23), 1480, "Electronics, Books & Outdoors", new DateOnly(2023, 5, 18), 19 },
                    { new Guid("7d6f7b1d-3805-402e-84f9-48f9db416a68"), 2, new Guid("3667884a-88e0-48ba-81ad-dd08e4f6513f"), new DateOnly(2027, 1, 5), 4601, "Tools, Movies & Outdoors", new DateOnly(2023, 6, 20), 18 },
                    { new Guid("8056b0f1-bb92-4957-947c-097d9412b01a"), 1, new Guid("eb69393b-7dfa-4b8b-b3fe-0e83b6f3a956"), new DateOnly(2026, 2, 1), 4878, "Movies & Health", new DateOnly(2024, 1, 14), 48 },
                    { new Guid("8116542a-9b25-4e07-953a-b96c3464acc7"), 4, new Guid("1a314662-8534-495b-b374-7ef2bb9b4bae"), new DateOnly(2024, 12, 11), 7892, "Tools & Automotive", new DateOnly(2024, 8, 14), 49 },
                    { new Guid("81529e4c-89e3-4bd1-8129-bbeb27218477"), 4, new Guid("cc0d0a24-97e6-4fb9-b52b-a4bf3e0c60ed"), new DateOnly(2026, 2, 6), 4559, "Books, Shoes & Garden", new DateOnly(2023, 10, 26), 22 },
                    { new Guid("846b69fe-cbec-4aca-9149-a04b39cfa57f"), 3, new Guid("3fafcc9f-d1f3-410e-a884-d616abadbfd2"), new DateOnly(2025, 1, 17), 3070, "Shoes, Health & Games", new DateOnly(2022, 8, 6), 39 },
                    { new Guid("98b1b724-1686-4b81-ade0-4280c034a7e0"), 1, new Guid("b1925b99-6048-443d-bb39-9a62fd414bf5"), new DateOnly(2027, 11, 6), 1821, "Grocery", new DateOnly(2023, 12, 21), 46 },
                    { new Guid("a119d8c0-cf6c-4894-845d-bdb9bf7c1be8"), 1, new Guid("a00da874-bb29-4e88-aef6-4ba73aa7c6a8"), new DateOnly(2028, 3, 26), 3098, "Outdoors & Movies", new DateOnly(2022, 12, 17), 20 },
                    { new Guid("a2f9f7c8-1253-4a4b-9d3d-aab3e6cd5af1"), 3, new Guid("0d93d483-255a-4943-b456-c170b7309702"), new DateOnly(2027, 6, 27), 7570, "Jewelery & Outdoors", new DateOnly(2021, 10, 20), 20 },
                    { new Guid("a5043434-34ae-4503-8815-c92ca9324177"), 4, new Guid("2c8fcd5b-a661-46a3-ac62-fda4e2ef789c"), new DateOnly(2027, 4, 17), 2788, "Books", new DateOnly(2022, 10, 17), 21 },
                    { new Guid("ab9c6d73-863b-4cb1-811a-f11c819b0da5"), 1, new Guid("e540714c-712f-4c9c-bbe0-3c6e536a18cf"), new DateOnly(2026, 4, 23), 7191, "Home, Grocery & Beauty", new DateOnly(2022, 4, 7), 32 },
                    { new Guid("ae30f401-fc64-4ee1-b9d6-f2510ca4f878"), 2, new Guid("b1925b99-6048-443d-bb39-9a62fd414bf5"), new DateOnly(2025, 7, 26), 6360, "Tools & Jewelery", new DateOnly(2023, 12, 19), 26 },
                    { new Guid("b2bd844e-ea3a-46a5-9181-081a324f4176"), 2, new Guid("c235096d-5277-4bc6-9ebf-3bd0441bcfc9"), new DateOnly(2027, 1, 3), 4943, "Automotive, Health & Outdoors", new DateOnly(2023, 12, 10), 35 },
                    { new Guid("bcdb4b34-9aa0-4ee4-aaaa-22d1c2c77f7f"), 3, new Guid("3fafcc9f-d1f3-410e-a884-d616abadbfd2"), new DateOnly(2025, 11, 20), 4800, "Health, Jewelery & Jewelery", new DateOnly(2022, 5, 20), 25 },
                    { new Guid("bffff0b4-5c70-48ce-8e26-b60635ea45a7"), 3, new Guid("3fafcc9f-d1f3-410e-a884-d616abadbfd2"), new DateOnly(2025, 2, 28), 3685, "Kids", new DateOnly(2022, 8, 7), 46 },
                    { new Guid("c0d57f41-0057-49e7-8f78-8d82be6598c6"), 2, new Guid("87b74d9d-d153-4f65-83c4-718345f266aa"), new DateOnly(2026, 5, 25), 4409, "Home & Toys", new DateOnly(2024, 8, 5), 48 },
                    { new Guid("c2818f3e-8585-434b-bb5e-f3d36ed99857"), 4, new Guid("87b74d9d-d153-4f65-83c4-718345f266aa"), new DateOnly(2026, 1, 25), 5888, "Industrial, Health & Outdoors", new DateOnly(2024, 7, 7), 12 },
                    { new Guid("c2b31069-a234-4e21-89b4-d4ad59e9f5cf"), 3, new Guid("b034a33a-0588-4988-8d91-e56505812847"), new DateOnly(2027, 8, 7), 7392, "Electronics & Outdoors", new DateOnly(2022, 2, 8), 32 },
                    { new Guid("c37c422c-dc44-4900-b6b3-9f53fb2772ed"), 2, new Guid("b034a33a-0588-4988-8d91-e56505812847"), new DateOnly(2026, 2, 27), 4404, "Industrial & Electronics", new DateOnly(2023, 4, 30), 48 },
                    { new Guid("c3b47ff6-fcf4-4ba4-9e15-7ab6278e114c"), 4, new Guid("3667884a-88e0-48ba-81ad-dd08e4f6513f"), new DateOnly(2026, 1, 16), 7373, "Movies", new DateOnly(2022, 3, 20), 39 },
                    { new Guid("c887cd50-6645-48fc-b2c9-d57f42f48685"), 1, new Guid("b1925b99-6048-443d-bb39-9a62fd414bf5"), new DateOnly(2025, 5, 23), 6733, "Outdoors, Music & Movies", new DateOnly(2024, 10, 13), 42 },
                    { new Guid("ce2e0cc9-1420-4654-88ee-9af75ef90589"), 3, new Guid("e540714c-712f-4c9c-bbe0-3c6e536a18cf"), new DateOnly(2024, 12, 22), 9533, "Outdoors & Automotive", new DateOnly(2024, 8, 6), 23 },
                    { new Guid("d17db7fd-b291-40b3-b31e-cd99dafb3c2e"), 4, new Guid("b9202822-0576-4839-a1d3-9f0a56b39bcd"), new DateOnly(2025, 10, 19), 2871, "Books & Outdoors", new DateOnly(2021, 7, 24), 35 },
                    { new Guid("d2094bf7-5d87-4f56-96a9-f4d2d3de1395"), 1, new Guid("ded29ebf-f062-4958-9f78-8df4fe9599cb"), new DateOnly(2026, 10, 4), 2980, "Automotive", new DateOnly(2022, 3, 20), 27 },
                    { new Guid("d6b0d825-f857-4fbd-9035-7df9d9ac07bd"), 4, new Guid("0b665598-69f5-4b13-bde4-1394ff5c31dc"), new DateOnly(2028, 2, 2), 8364, "Baby, Tools & Computers", new DateOnly(2023, 5, 9), 50 },
                    { new Guid("d8a2c636-8270-46b4-a171-fa93fd183526"), 2, new Guid("d8f60351-f6ec-4823-a7fc-e7660c635bb7"), new DateOnly(2025, 3, 13), 4198, "Home", new DateOnly(2024, 7, 1), 39 },
                    { new Guid("dcc159c5-9735-4502-8f36-5215bd7acc81"), 4, new Guid("35247627-3f8b-4c56-8f6d-7c8ab4c64047"), new DateOnly(2028, 5, 13), 7536, "Health", new DateOnly(2023, 3, 8), 47 },
                    { new Guid("de908e90-5244-4c53-9ef6-f7ad89bc88c8"), 3, new Guid("0d93d483-255a-4943-b456-c170b7309702"), new DateOnly(2027, 2, 12), 3424, "Toys & Movies", new DateOnly(2023, 1, 4), 43 },
                    { new Guid("e25b9c74-e9e5-4fbb-8e99-e09a7eae4b2d"), 1, new Guid("c235096d-5277-4bc6-9ebf-3bd0441bcfc9"), new DateOnly(2025, 8, 23), 2718, "Games", new DateOnly(2021, 9, 30), 24 },
                    { new Guid("e8906b6a-f2ba-44c9-be35-c9ef334f5efa"), 2, new Guid("c091d70d-a3ad-405a-b021-5ed4e2079ea1"), new DateOnly(2025, 8, 20), 6840, "Tools, Garden & Baby", new DateOnly(2023, 3, 20), 26 },
                    { new Guid("e8bfdca2-4278-455b-bda6-4e4479270d98"), 4, new Guid("ded29ebf-f062-4958-9f78-8df4fe9599cb"), new DateOnly(2026, 2, 15), 5511, "Garden", new DateOnly(2021, 1, 19), 15 },
                    { new Guid("e8f09785-eaae-4ad2-8e6c-89fe9a03e26a"), 3, new Guid("0f05fada-c852-4f14-beff-141c6ea5c26e"), new DateOnly(2028, 2, 29), 7145, "Jewelery, Garden & Tools", new DateOnly(2023, 12, 23), 13 },
                    { new Guid("ea035567-f803-4497-9c51-e7dbc41cba8c"), 4, new Guid("1a314662-8534-495b-b374-7ef2bb9b4bae"), new DateOnly(2028, 6, 25), 6513, "Movies & Computers", new DateOnly(2023, 6, 8), 25 },
                    { new Guid("ebc90ac6-d31b-44b1-9cb6-3e144423b9a5"), 4, new Guid("b9202822-0576-4839-a1d3-9f0a56b39bcd"), new DateOnly(2028, 4, 20), 5243, "Garden", new DateOnly(2021, 8, 3), 45 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("10e90b80-7b6a-408e-aadf-3da9a7e49167"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("16a9b4f4-cd60-42d4-b614-ce24b3e4e383"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("1b868a5d-8185-4b45-98f6-0898a2900ee6"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("21b4587c-aa4e-40d8-a29e-585af839115a"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("21c9043f-325b-49fd-a636-d7a874cd5e16"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("290d6f14-1196-4c7a-9e91-6b7c01f61e77"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("45c90dfb-8884-4f5a-9fec-0a8c9650c507"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("478ccce7-78a9-4f88-a5a1-b242e3e47840"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("50e36ae8-0290-402c-b3ca-a0cd8703a9a1"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("697d6699-930b-4a75-857c-435600afbe49"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("78267685-256e-4dac-9906-e560433b8cce"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("78f16233-1904-47c8-8b6d-b557cd4997b7"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("79652742-270f-4367-97f7-92919fb52d04"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("8e47ca51-a8fa-476c-be47-f51e2595c559"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("98577e8c-d9a5-4c1f-b214-deab3e2f9021"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("b5cceafa-c99d-407b-a929-c84b3427b7cc"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("bbbd27df-ea1f-4192-aaf8-1e69aaa13702"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("c3b59913-4ca8-4e2d-a5f7-984f458f1b19"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("cc2c1cde-d03e-4420-b1d7-24471cba76a8"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("cd02db85-744f-4995-83e5-ce36f8f8328c"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d2346294-e7fa-4c42-9e02-348a2e9b3a82"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("d508895f-0a51-4cb3-b7e4-681c2057685b"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("e22c2456-b828-4d1b-8217-6dd5ed93c49d"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("ea9fa6a5-0772-4a35-9e5a-ca5cff512801"));

            migrationBuilder.DeleteData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("f8e3b049-62c7-4225-86c1-de90fb63749a"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("0219cd30-200b-4eb0-9ac4-8cf34e625786"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("08c31e74-fa33-4c32-a10d-590c7eedecb1"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("095f2758-e8cb-4cd7-95a8-91e3f44033ff"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("0b4e4aa9-d99c-4f1f-9332-b38ab0076766"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("0b560c08-6f9e-4cc2-9ccb-6f110867523c"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("14b2a9a9-276f-4918-86c2-b818f6bf8b82"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("177f37f9-e107-4716-b4ef-c6d2b6681269"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("1909749b-788a-4187-aca5-d44efe923d29"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("1a12ebca-33db-4592-a504-496c571db668"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("1f572b42-cb8b-42ce-b0de-146104e3e893"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("2178a6d7-f63e-4605-8d5b-4967e305cb2d"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("2240a563-2024-4255-9341-9d234372a1b7"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("2b855222-eb16-4c20-8f92-8b0140897d38"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("2ceb8e91-8c7a-4047-8062-a28a5556adb2"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("301888e9-90d0-4533-9b20-2f18bc7035a9"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("31818d66-266e-41ec-8308-04ef7af314b0"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("3182dcde-a5bb-4312-82f9-9b76a584e5f5"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("3417e5ca-e801-405a-8988-11a1cf752042"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("3a0d72bd-4152-4cb6-a7ce-c14b2d11cc0d"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("3a4a07cf-1499-412e-a7a8-9a37927b891c"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("3a6f70ad-e959-432b-9287-4f6cfa4ad70a"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("424e1982-fb1e-41c5-9b7b-3d7e7c877a91"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("43e026d0-31f7-4069-a460-2bf39c4acf7f"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("479d9f46-bb34-4506-ba88-f2e3be3ec1f0"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("50f00ca4-81db-461c-95f0-6a1698672e39"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("510981ca-1949-4173-85e9-01c56786f289"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("580c77ad-e6b1-41f9-8c7b-d0d94e036c1a"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("59792c1e-7206-4627-b601-cdaedaae621f"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("5b158990-0056-4f65-ae7d-87624f8aafc3"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("6133db49-f2f8-4cd2-8257-618527dce993"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("68b9c47f-1fd7-45e9-ac92-89d2bbc4bcc1"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("6eab599e-3719-401a-b2a0-d4d0ae53834c"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("70f11e55-6a9d-45bf-bb0f-cae36c8baeca"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("73ed7f5f-607a-4a2d-9166-5be46729a752"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("79c10c74-836d-4b54-a123-846b777a8ec9"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("7b1c439d-70a7-407e-9369-229999fcd957"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("7cbc2e2d-ff3e-488e-950e-8cb33f6cd7b7"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("8208cdf0-fed5-487c-b60e-3c5ff79c036e"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("82729ae3-0bdb-4515-be05-b449adffa373"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("88df80c2-52bf-4fda-b857-e3a15616bc91"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("8cd2f13a-e1d9-447d-90b9-7aaf08e74f08"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("93927f35-8e87-4e9f-b10b-f58d6ea491ff"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("94880070-e8be-44b3-bae8-55c3d654e347"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("9b521672-4ce3-4c43-971d-8fec87888fb2"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("9e7d5d44-98cc-4dcc-86af-4f7c36e11aee"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("a76a5f79-5c50-4621-90da-a0b17a707b30"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("a89c03c6-ed27-4aa1-9716-91f72d55ef99"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("aee043af-e4b5-44ee-8180-2f653c7a6edd"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("b4626305-cc30-4fdd-afd8-d916e8b4801f"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("b676c8b4-023e-4f04-9947-145a2eaf5de7"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("bc5f534a-adf8-4a0b-b0cb-da8bf4858a16"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("c094e880-7adb-4600-89d9-c8f0588dafa4"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("c0eb396f-1ecf-4339-b4fe-10e424ebd774"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("c617c1a5-b83d-4b53-a1a9-79022fd82ae7"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("c97833aa-967c-480e-886b-d8b1908df818"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("c9e6734e-97d2-4d87-8b2a-03904590eafb"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("d221c3be-e401-4b22-85a3-ed2a18297a7f"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("daa82173-7790-4ee7-baac-f10c220d8601"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("dd1ff795-e6e6-436e-b273-730dba1f9cec"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("e06cbf72-1e92-4eb0-bd05-5b16d5a1d2b2"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("e111fc73-b7aa-4564-8471-9d84cf49e35c"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("e3189537-61df-4fff-9fe3-769a1721c3ef"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("e3bed1d1-f1fa-4338-9559-b329a16d8aa8"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("e44ea821-43c1-4d49-b13f-3e8b3530c867"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("e52b6e6a-7f99-4027-ac31-61a7ae1139af"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("e667bad8-399a-43fa-a09a-51b57d06575d"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("e786ede0-6156-4940-ad10-735637e5af11"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("e8789bb3-6c8f-4dab-b3ee-589eae8d78e0"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("ec9fad06-b616-4f6e-b8b0-18d661de7b29"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("efb282bc-e121-4858-a340-0cecb776ecc8"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("f104a7f7-e3eb-46ac-b7cf-b2d5e9cb3790"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("f838841c-e2d6-42e1-98e8-892306d6d0f2"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("f8a0d671-4e64-4d46-aab4-37db77d87156"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("fbf02106-b2f7-48e8-a8b1-11f6095482ad"));

            migrationBuilder.DeleteData(
                table: "CompletedSlots",
                keyColumn: "Id",
                keyValue: new Guid("fe3fd0a3-eed8-4181-b83f-6e7113d6a9a0"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("079c1f5f-9a13-42da-9752-c509d0236dd6"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("0b1f6ebb-8341-4a3d-960e-031a36568e95"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("0d90cb0e-0383-4751-96e5-d8aae5c70976"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("134393a6-1447-4b91-a450-72a5313fe48c"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("1372f0f6-98af-47c2-b0e9-ebb9ee9baa78"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("13e26ac0-731e-416b-93ef-9b52232ba5bb"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("141743c3-7ef7-4599-8eea-8dc0d5914a57"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("14301c9f-060e-4727-936e-84f0fad20a04"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("1494ba89-7ca9-4494-b4ca-ac7dc5d1ca05"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("15dfe2bd-68c9-4d85-aadd-f6847119ed68"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("16fae056-d808-4ff7-a090-c2b59ba13f9a"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("22437554-dfc6-4983-bff8-18361937f9b8"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("27381a99-afee-4ddf-8148-50fbf7e49b08"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("2c9fc2e6-5da3-4e28-95cc-8cd97cafce46"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("33669538-50fe-4c00-9664-75d66edc1ed9"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("336d58aa-a2b3-4c39-ae3c-9a71804db984"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("3e3f8c66-adc9-4a81-929c-42fdf2ff8047"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("409baa2a-e4f7-4f41-9529-404d1750dafb"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("4181cae3-4c20-472d-8ac4-bd7de6d4ddb4"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("4413fb08-8682-4dba-9205-021b4631f9c3"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("4603dd1c-28ad-4140-b6f8-d2cbf465f8af"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("4809a7f9-15af-4f0e-a83c-de450fcf4071"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("52c45776-b51e-4c95-ae9f-5cc43e0d563e"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("5418b0eb-06fe-4d4d-8deb-8a20872852ae"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("599de2d0-a1c0-4347-ac69-e30e0ec08940"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("5aa8d7cf-38a7-4635-bf67-b8640048c5cb"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("62ca8d41-2f31-4e0a-9720-37e743d758db"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("6319fe3c-4257-431e-abbf-3d770192a419"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("63782e5d-dd7d-4bff-b1d4-c55623704a8a"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("6a92b389-1096-4fb8-9d6f-ccf649f45865"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("6e4add3b-b1d0-48df-8498-a5b48de2f486"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("764286d0-d664-4e8b-bf2c-f58855a7a9d5"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("76f21dc3-2936-4f79-98f8-087df6f58ea1"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("7a245829-c0ee-4959-9e9c-599e373798ea"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("7bb08f79-f643-47fe-ab49-cfc044089131"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("7ee048ce-0791-40e6-ac98-76651bb834b9"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("7f4b1180-c2e9-477d-8fc1-e543c9b34826"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("8674645b-44f7-45d1-be63-e4f4333201c3"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("8be9f3b9-74e1-41ab-b53a-0086eeb59387"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("8d8475f7-06aa-4cfb-bb5e-7f0d6e85fb8b"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("8ffc6a92-396e-405f-8a7f-c28dc9d0172e"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("942ef1c3-4b9d-4e9a-ae01-2f7258d199d1"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("9d6bc2ed-16ad-465b-bf31-6b6815a46dad"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("9da6ac92-6270-41d2-a0e1-af09b1188a89"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("a208b60e-1c11-4c3f-89ba-23a121f4a6a7"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("a37c9c83-b019-4163-8675-278bb5d775f7"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("a3bbc08c-f9cf-4a3f-abd8-3d7fe71c709b"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("acdfcedd-aad5-4f1d-be2b-2db1869ef127"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("aeea471a-664f-4c08-b21a-693cab754306"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("b47ded01-fc7f-4514-ab88-165b635b232d"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("b52a1eff-f4e7-4b1a-ad2c-6d954315fcf3"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("b9e6c2e4-95d6-48fb-afd5-011e7a74b887"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("bbaf0525-606b-489f-82c4-e14e235daeea"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("bbbc1f80-e7a8-46a7-82af-3ca360350d72"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("c73ad9a9-08ac-4932-84a3-dfad6dce2e1f"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("cb282835-6e97-4547-b952-f3e14c7d4b73"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("cc0c34f1-0e09-4824-98d3-d38e6cfeaa1b"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("cd5f0727-34a2-423b-9867-435b9c7fb737"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("d4143b7f-28c1-4e2d-8d98-dc55dca3efed"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("d43af315-c5b6-493b-a4ca-0b439d479efd"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("d4400925-c3b7-4df4-978c-502fb60f7b27"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("dad8cca0-bead-4ead-98a6-1e2301050923"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("df1cd750-319b-4d6c-9a82-d38451293f0e"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("df7a1aa8-f5c1-4d5b-9977-8e0c41eabae9"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("e1bcde56-0d7d-4de9-ada2-d8455de9c464"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("e357c912-aaff-46d9-bb70-8f122e93195c"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("ea703f0a-2534-4907-acb5-460824f51a0e"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("f282d535-2f97-4ca7-bcbc-082db02197dc"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("f3e2c4d7-acd3-46c6-8e68-ab018d652175"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("f47fdf6b-29d6-4cfb-b7cc-524efb550bbb"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("faa0fa37-e817-4570-9f94-613bdcfa43c1"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("fc11f3de-3979-491e-b264-8766b2d45075"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("fc4161d0-d6db-43e6-bb75-2e27867a347c"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("fd4b5fc4-c644-4a74-8e8c-d13d742d34fd"));

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: new Guid("ff3b4be5-31be-4259-be30-91f764427a58"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("0015c57c-c826-41c5-842b-bf2b1c2f460e"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("0b6cb1a4-b994-44e5-a59e-28d14f0b24d9"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("0d7dc49f-38c6-46e7-87cd-50b282218edd"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("13f3bd78-b50b-4125-8502-a5e60b2ebd68"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("14fead64-9c45-4d91-be9b-3b2790c13108"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("163510ae-6c01-4590-ad76-38dcf5c9e5dd"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("163da3eb-db44-4132-9764-5a191bcdcc4a"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("16c5a01c-5c22-4ca3-bf1d-b8f6a45afd59"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("1d06cdfc-41c5-4d68-995a-4d968f8b3a8a"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("205bea5a-d106-4efc-911b-f56c66e86e6e"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("2144110f-6e16-47d6-acd2-9bf54bf033fc"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("25ca6abc-b376-4b29-b8c2-b8c365c441a4"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("26bdebaf-de26-433d-b13b-29fd4689d6cc"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("3378301d-663c-44a8-b72e-759d616d44cd"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("34924e04-1c79-4233-83e5-cf3aa39e046d"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("399b750c-f68a-4ce3-b5ff-0cfac69d0d05"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("3de200d7-ae64-4ccb-af31-8bb07b976a26"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("3eaf3477-0f70-4472-b07c-d86348e399f1"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("418b576f-a1eb-42f4-9065-3353f3885835"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("4b2cbd44-880c-48d5-97fb-fc382db8c76a"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("4e3c96fe-8053-4c82-ad5c-7026731da5d8"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("5300d798-c552-437b-a30d-cff5a10fa3c8"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("5a0ceab3-f0ef-4f92-bde5-aba6400ddeb3"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("5bcb92c4-85d5-4123-bd6a-ed70e5d5a4db"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("5e2c5009-1b59-47b7-9745-46aa04e86286"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("5e65be20-4c78-4fc5-ac29-da11ecbd4571"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("60b87c2f-3ed3-4405-a1a2-c67b403d665a"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("6217bdc2-70bb-424b-bcef-8cea17dc2bbb"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("62b1df70-c449-40a8-89a8-143b42f06eeb"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("62b81d64-1b94-4ba2-a658-a085ad6b193b"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("654c50c8-6393-4c8d-a318-8d65e664eac7"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("66879e4a-b57f-43ae-9feb-04ae781c3878"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("68be8a62-d0b6-49c5-bfb4-60ee603d1225"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("6b32f0f8-baa0-40a0-9eeb-f1442b2e75fa"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("7229335a-e8bd-4c03-8cb1-7842b90377f5"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("737d4017-89b8-4eae-81f5-76f838aae88e"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("76ff1cfc-0b7e-42e1-93df-d974de7298e4"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("7aa756f5-3160-4713-b53f-6aa669f0f7a7"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("7aae947c-5e75-4aa1-a804-00e48c7f7d71"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("7b8c5319-adf4-4bd8-93ae-c8624bc88132"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("7bf52f18-2e0b-4a69-8d7a-52c08c05d2df"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("7cc1c799-2271-405e-987c-832b903ba744"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("7d6f7b1d-3805-402e-84f9-48f9db416a68"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("8056b0f1-bb92-4957-947c-097d9412b01a"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("8116542a-9b25-4e07-953a-b96c3464acc7"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("81529e4c-89e3-4bd1-8129-bbeb27218477"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("846b69fe-cbec-4aca-9149-a04b39cfa57f"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("98b1b724-1686-4b81-ade0-4280c034a7e0"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("a119d8c0-cf6c-4894-845d-bdb9bf7c1be8"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("a2f9f7c8-1253-4a4b-9d3d-aab3e6cd5af1"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("a5043434-34ae-4503-8815-c92ca9324177"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("ab9c6d73-863b-4cb1-811a-f11c819b0da5"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("ae30f401-fc64-4ee1-b9d6-f2510ca4f878"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("b2bd844e-ea3a-46a5-9181-081a324f4176"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("bcdb4b34-9aa0-4ee4-aaaa-22d1c2c77f7f"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("bffff0b4-5c70-48ce-8e26-b60635ea45a7"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("c0d57f41-0057-49e7-8f78-8d82be6598c6"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("c2818f3e-8585-434b-bb5e-f3d36ed99857"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("c2b31069-a234-4e21-89b4-d4ad59e9f5cf"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("c37c422c-dc44-4900-b6b3-9f53fb2772ed"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("c3b47ff6-fcf4-4ba4-9e15-7ab6278e114c"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("c887cd50-6645-48fc-b2c9-d57f42f48685"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("ce2e0cc9-1420-4654-88ee-9af75ef90589"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("d17db7fd-b291-40b3-b31e-cd99dafb3c2e"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("d2094bf7-5d87-4f56-96a9-f4d2d3de1395"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("d6b0d825-f857-4fbd-9035-7df9d9ac07bd"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("d8a2c636-8270-46b4-a171-fa93fd183526"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("dcc159c5-9735-4502-8f36-5215bd7acc81"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("de908e90-5244-4c53-9ef6-f7ad89bc88c8"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("e25b9c74-e9e5-4fbb-8e99-e09a7eae4b2d"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("e8906b6a-f2ba-44c9-be35-c9ef334f5efa"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("e8bfdca2-4278-455b-bda6-4e4479270d98"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("e8f09785-eaae-4ad2-8e6c-89fe9a03e26a"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("ea035567-f803-4497-9c51-e7dbc41cba8c"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("ebc90ac6-d31b-44b1-9cb6-3e144423b9a5"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("00a019a4-027c-4fe9-82f8-92669be4d1ba"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("00a269e0-695b-4bbd-962b-523e97381838"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("0167a1ad-8c8e-4487-8cc8-dc9a7ce2913a"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("01a87e32-ca1c-4432-a3fb-a6705fbb1cb1"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("01dd8510-a265-47c8-b9f0-892e0fa2b8cc"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("02964334-1c98-435e-b99c-566f33efb03f"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("030c1cf5-48ca-4893-b767-1b3e2a625e05"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("046396b9-5df1-4fd7-9f6d-b84ef81975c4"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("0590458d-4e5b-4909-9d45-30c705a4e38b"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("078fcbe7-943b-4481-b356-d674e39b22b0"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("07a90d69-f937-4cf1-b123-01b7983ae787"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("0a2c84c9-4a54-4768-88a1-653bf9046ed7"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("0ba0f4c2-77c2-4891-9fed-903e12967a0a"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("0ca1a578-367b-4fca-954c-1f6d9837173c"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("0cb9638f-e51a-4ffd-813c-6bf9d1f3662c"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("0d05d766-c5a5-46d2-9fee-1d1bd7267678"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("0f00eec6-8362-4920-a0d5-bf5d9b08bc8d"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("0ff302de-9074-45ea-8650-6ef046057756"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("1089c444-89c2-49e1-8e31-237773b4bbdb"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("14099075-f935-48c1-a94c-c1348dfd4243"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("1460cdf0-0472-41fe-8d74-5035e4c9d775"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("1544f60d-cbfc-429b-8f6e-1f28029134dc"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("15cd6a94-b0fc-4ed9-8e3c-6632004b05ee"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("1676f974-7e6c-456a-be87-c0606e6a117d"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("18d48ee3-468d-42dc-a29b-40ee0afc9406"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("19171c23-1e58-40e2-ac0f-e6d66941f057"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("195048ec-e7a7-42c2-a6a6-19af598bc581"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("195ac85a-fa25-40db-a58a-6f39a1d65b73"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("19adeea2-9f6d-4192-afe4-8af3a6da06af"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("1c6d8319-9dbf-47df-993d-be839c332ee4"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("1ccfd9df-5e24-4554-8cb5-a3036f85d854"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("1d4dc608-8e58-44a9-a1ba-75d9a117874a"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("1f512176-db86-4bfe-b80f-a3540619179b"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("1fbb0c15-5c65-4723-8668-1f29b76f6db6"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("1fe1633c-a4aa-425e-9d32-12bdd6640561"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("1ff41738-1a8a-4b9a-aab7-75ab6ff026b0"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("21a8e091-fa75-4dbe-abdb-104a9b398538"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("223b3527-20ce-42f7-b231-c5f3e68b790e"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("238ccde9-3991-48b3-876b-a0b6020fb426"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("2599fe6c-4228-4621-a8ac-41894cee75ed"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("2661a04b-369c-4208-b57b-d33f5376d68c"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("271e3a2c-81ba-4720-b3fb-adb22e4de15f"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("28b20f69-2038-408b-b21e-1447e6f43772"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("2984e81a-30cc-46e4-a7a6-560e21e71f8b"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("29def353-605a-4b32-a0a5-2296ec5d6ccb"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("2aebe351-d536-477a-a9d3-4548147acb2c"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("2c2f5243-f65b-46f4-998a-69fc754e8a2c"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("2ca871b6-7612-4ea5-b45f-7f7ecb2be7d7"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("2d166a85-901f-4e76-9b83-3b678d322810"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("2fa8d356-29c6-4f89-865c-244dc6f78889"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("3075a0a1-ef04-40db-b006-a0463b1e1348"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("31216b6b-399f-4f74-be14-71de6483bb6b"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("316d18c5-0714-4f5f-8e83-f13295016f79"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("31b34397-b626-4e31-ab43-61529f13a549"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("34b89a0c-6ab7-4c23-a295-8a93ffb7e01f"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("34d7f666-a6e5-4d30-8ce3-00e1fd0b264b"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("35695035-b37a-44c3-8d47-8f2561bdebd5"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("362a1dce-11f6-458c-8fa2-3a47e5b04b24"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("36c0ed72-24cc-4b9f-bef2-2459959f6512"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("36fddfc6-609d-47d5-8239-3a3f60e9ae8c"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("37298e3e-3d92-494e-b74e-61074a02102b"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("37543324-69ec-4549-9c8f-1ead424fb1d1"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("3781cdeb-55c2-4277-8ee5-aefb9e646572"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("396dde86-8633-4613-8d6c-7c36a76ca074"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("39eaf3fb-f54f-460f-b12d-2f5b24d7e268"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("3a50ea6c-c189-45a5-8807-851b25bbb392"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("3a523640-76a2-4e21-8f65-3f88e9b3862a"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("3a53f64e-2aa3-4c5c-bd44-d7b21832f07f"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("3a5f0bb7-5fb4-4193-aaa8-153eb79f7a2a"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("3a7a1791-9ea6-4d7b-95d1-f2ff68c03819"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("3accec83-2399-4d6a-94c4-d71b9fc41656"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("3b3928bd-120e-431c-be8d-810dc254f283"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("3b9b009a-df7f-47c8-990a-f69340215c7f"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("3d0cf7d4-3beb-4f8a-a08f-4264839800e3"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("3dfc4458-7d85-4a7c-abbe-f83f563d859f"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("3f25c6dc-457e-4633-8ce8-be4f7f3a6c8e"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("405de9c7-e4a3-498e-99ab-410d284a945f"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("41a1794c-dc09-450d-a0c0-71cc1dfe1b29"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("41b8bccf-b0d0-4708-b538-ee56cde49fe3"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("41fe30c7-c6e0-4925-8aae-446b2c736ed0"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("443e5850-fceb-42d0-964f-15e34f5b45c4"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("44c91d5a-7933-4330-a632-e08f50c70136"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("44d5f412-ef46-4734-8a59-b7dc63343876"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("453c56bf-ec06-4f3a-99e5-73455f0834dd"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("46e08432-9754-4d01-ba41-54068e271e2f"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("4775b212-cbc1-4602-8545-4ad5ad1b2ec0"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("48a0299b-6621-40d4-b84d-e9ba9b5abc9b"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("490c6dbc-3fd8-4d7f-95f0-99221aea0214"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("4b8a6e93-0a76-400b-b4dc-102b131e994f"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("4ba9bb5e-3eab-4d1b-8051-8320f79761ac"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("4bc155db-69fd-4245-a738-0db024116c5f"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("4d23acab-169d-411e-b15d-9f9bbefd3607"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("4d4e2e9a-fc4c-400a-b725-de5547e4ea9e"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("4ed74c5e-90e6-4231-84ca-1bd6d3a20c6e"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("503fe743-c681-47ee-a1b8-7da0c6ab8616"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("51c05c3a-1ee6-4600-8ccf-a4e852d03d19"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("5396582a-7256-4319-a5ff-6b59110526ff"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("54081509-ba88-4a54-b6d7-154f4e8c1c41"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("55476c0c-6539-4359-a0a8-a5ae124f63e0"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("55def556-0940-433d-96f2-1a5e95d983c0"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("56819dc3-ea9a-42d6-b919-ffd2a904cd5c"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("56d2d550-7c8b-42b0-a889-46a651bda589"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("57135ba2-6275-45e7-86a7-44b2ffb4b734"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("57d23f92-f675-4766-8601-2cd96eac2975"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("59ec43c5-6fb8-4064-b4f8-89d3320bc1a9"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("5a26a5d0-3325-401a-8cbb-5b634baaee98"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("5a72f36d-e440-4c71-ad6c-c42c50432557"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("5ac949f5-a633-429f-a503-1a23a1c1898e"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("5ad7fa49-9797-499d-b9b4-a73ff589b959"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("5b77835f-d97f-42da-af79-991a04e88829"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("5be68f0f-c05e-4e79-bff2-f1892d5f968b"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("5cd1608e-3f02-44f6-a909-f440364323a9"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("5dc08b3e-0af0-411e-9ec2-f43db7c803c6"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("5e5a462b-7ae2-4990-a41e-02154a481083"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("5e904aa2-2d6e-4829-88fd-4331b31cef76"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("5fb3bf91-9665-446d-9c82-fc91370bbf43"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("5fdc3430-5fba-4d46-b43d-8c1f34700497"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("6065a6ce-32cb-4b49-a5aa-b304a9d8b39c"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("61247ec3-f964-435a-9241-9f29991a4b84"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("616c9c2c-8c37-484f-b21e-5bac754dd06d"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("61cc5a7c-e76a-4a1c-b8fe-2a105e0fa348"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("64854252-1b37-434f-8342-94af068b8cb6"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("65713ea3-7a5b-4d27-9dc9-afc15a5b1594"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("65b96311-528e-463f-a7c0-e7ea3a8f6040"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("65d03a02-183c-44f4-b669-bd03701fb271"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("66186be4-79a7-4e21-a757-a1aaa7b78622"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("66e3ea3f-3608-4417-a991-32e268d6a9f7"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("6774f9d0-153f-40a8-93e5-fbb9ede1cdfd"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("6835df51-4407-4052-84ec-b6019ce88a35"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("6855aad3-ffe6-4d7e-8093-2ddf30e1be6f"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("686e5b84-c91c-4152-9118-a60cab6d760d"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("6a0dd354-f52b-4224-b8c6-65392acd4f0a"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("6a90a588-4435-49bf-b72c-93182a03d886"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("6bc32e0d-d1c5-4590-ad03-3b85469fce1a"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("6c48182c-ba9e-434b-8350-26152afaa256"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("6c71337e-e6b0-4dc5-9119-359c95b49805"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("6d90edcc-2b11-4eb6-823d-193c69cc300f"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("6db161d4-24cd-428e-9119-30d41d052171"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("6f5077b0-1a35-4922-806d-d5ad22cf58aa"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("6f8a3580-b8d0-4b19-abb5-cce51de765de"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("72328438-15fb-448f-aa3c-299a2d1268c1"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("72fbee82-5918-4f12-a2a4-d377ed83ef71"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("747e5d60-5387-4725-afac-ae1a2cf0b6b5"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("7486efd4-2180-44af-8f82-c47fa0cb1119"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("75014f39-c8cc-48fa-9662-fed1f3fe2b89"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("75a3152a-be9f-4269-a813-2dc4e4c28cd3"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("76258178-e95c-4ba2-8a16-a1f92df29394"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("76296426-56cd-499c-a39f-9ebfbc5b6844"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("7708e2c1-69ac-4d0f-868a-9745401180dd"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("79168535-6f59-4df2-838e-13add6eebe6c"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("7ab47f95-1f6e-4719-ab69-58a5a3deba91"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("7b3bd50c-e182-47b3-b7a5-f77d8f9484c1"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("7b8e577f-7e5d-4ff0-970a-4c36d8ee36b6"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("7ba12057-db30-4244-b454-c27989cc4f2c"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("7d030045-11f0-4d0d-a1fa-f5f86018f29f"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("7d2959df-0727-46be-ab77-2df9beba17e3"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("7e8af4d3-b2a0-4ad2-95c2-b4ee78d935d1"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("80571f8a-df22-4371-9e04-31255c229386"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("81e38cc0-230d-4122-92a6-dac68965c0b2"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("82a39b92-1116-4b4e-a249-f4bcac43234e"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("82c12e0e-c76d-4d78-aa4c-5021cbcbb65a"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("8340ba22-33f6-4dc3-baae-3e1c8f1b069b"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("847beab2-ccab-47be-ba89-ea19024ab468"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("85f08b24-be6e-41cc-b09c-5f30ee488b8e"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("867e883d-83a0-41c2-8971-82af2ee799cb"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("875372ee-f762-42bb-8672-cc908aecfd14"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("87f9efbc-b97f-4089-83fb-4840e4d630a8"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("880f880d-4c14-492e-939a-1acc344158ee"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("88ee8d91-c548-426c-a410-c8248e534bc9"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("89f1941f-6910-4b53-bfb1-457786b12c72"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("8c736d7f-3071-4c2b-8739-4e7f60e27232"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("8c804458-c2da-4319-8dae-fa841830f512"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("8cfea05c-8699-4314-ac24-53037885fa2d"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("8da37d4b-ff01-47de-be12-eb00fb07ebf2"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("8ea1a07d-d0cc-4fcb-a0f6-5bc94e1916cb"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("8fb14fc5-e0db-426e-99a2-9ce9e68d6c1b"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("8fc83843-bedc-4e23-a394-4eaac40d8f9b"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("8fecd7d7-4020-4d0d-abb6-1372630b7695"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("90746d1f-11f8-4d0c-8e56-2899e55be5bc"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("94b6ac05-9453-44ee-840e-80a4686fb194"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("9576950b-b63b-4510-9265-12e119489e8d"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("95e94b5f-6d65-4bd2-8a5f-1fec5bc99cdb"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("963e9487-507d-436c-b163-923e3e8c9a39"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("97d42393-57dc-48f0-8cf3-1beb5e542309"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("98d1f8eb-2b54-49f5-a0e9-b64e7265d96f"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("99a68dc1-a487-4144-9065-4ccbc19d180f"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("9aa72f35-fff5-4f19-9a58-77968fe1b329"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("9b153db0-7a1e-4651-9ebf-f01c9e4bba9b"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("9c2f3a70-77fe-48e0-8f40-04452373f6e1"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("9cbd5a04-6a15-4e53-ae70-968d20cc1956"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("9cd6db03-5f85-4aab-8d12-b7e51c35c2a8"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("9da58814-fc32-47db-89ee-e1ec4ffdc077"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("a04174c8-42f7-4fe7-aa8d-9b5bf36e8e17"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("a240cd24-5555-4350-8bc6-d9f78a3a8749"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("a372481d-9f01-4d6d-bf6b-d9e496ae2ebf"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("a5ce978b-96e1-47b0-9c3f-6c28148affa8"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("a76ae727-1ae4-489d-9a3e-2459ed3e567f"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("a845a994-b31d-42da-acea-74425a7a84f2"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("a9501f51-536a-45f5-9bb0-31bc724d8adb"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("aa1145e9-39f0-4669-b9f8-b66926be8b24"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("aa243e65-18b6-4767-ba69-bed8fc00e918"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("abfef4a0-e3ce-4ec7-827b-4deb994159f7"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("ad65f893-17f8-4bee-addc-76345c15697b"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("ad68f905-b109-4822-8dc7-934756a5032b"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("afba043a-38ac-4083-882a-a47da7524bd5"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("b02c37ac-ffd5-44b7-ac8b-7d2cf82d503f"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("b044fcb4-1740-4bce-b1f6-c3d7050376df"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("b0b08230-6535-4f78-9a2b-1a58f89d2350"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("b32b7493-f79e-4c9b-98eb-977306439c5b"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("b384ffc0-beb6-47bc-9533-82684b0f1ac7"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("b511c7da-2998-4b04-943d-876734422e4e"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("b6722f8b-cb2e-43c9-b1cc-2066ff0e7d62"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("b712ab55-4823-4297-9e27-2b86e7a3619a"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("b7ba8499-a6d6-4645-a854-641ab4683407"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("b9a0c1fe-5540-4cae-92d8-a9982ae3c171"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("b9c02476-19fe-4209-bfb4-9cc49f403232"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("bac6ddac-71bf-4eb1-a471-1e7dfb6abb75"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("baf408ec-22c0-4fa8-a0ab-151980e057eb"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("bb9ffc89-c5b6-4d5d-a7b2-4a60c0d86861"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("be619ea0-16c6-4173-be51-985da8858a35"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("c02f938b-7fc8-4d5f-bd60-ad8d6bd99f43"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("c288a69d-41f0-42e2-9f1f-1cfe76cb6616"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("c2a6831d-f464-4e46-8813-76bf64d67aa0"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("c2ea5893-9f0f-4ba3-b096-a145541f02ee"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("c38a9655-a3dd-4c64-8ae5-89f3d2276f87"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("c40dc40b-2273-451c-884f-112dea596db7"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("c452c1c6-ae6b-4020-84ed-7a9324140d6e"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("c48c99a9-bc2d-4d4b-a902-b7e86e0a4951"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("c76ee0b5-26ff-460e-a622-9001a7c4e1c8"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("c797cf38-3186-469c-8155-e36c22d044d0"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("c8243a7a-6f0a-46e7-b592-577555473186"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("c8cd92aa-1c29-4ba0-995d-cbca468ff9ea"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("c93b3f51-87ee-4810-9dfb-5ba6bb01cfc4"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("c9aeb37a-d557-4c86-8c02-35e21934c722"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("ca176e21-30bf-4ce9-8dba-7cc425b12dd1"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("caa40b1d-fa7d-4190-b910-12f4eaa6a891"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("cadb7fe4-cdd8-4f61-9231-cd438727db55"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("cae52c8a-755f-44d1-9a34-52eaecefef36"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("cb1b40be-6b95-40ff-ad38-1b6d59a6088f"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("cb97d3c1-b1a6-4054-96ef-8fb78a35d271"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("cce4ae5c-0cf8-48a4-baf2-c1815e57b8d0"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("cd823fb8-24a7-40c9-a085-d206bafc44ed"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("cd957506-9b00-4730-8c6e-71482ff9194a"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("ce559b3d-0925-452a-85a6-b4a4683c633c"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("cefc593c-e347-4bce-b077-3dd9059d174d"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("cff1f908-7fbe-4887-9c1b-f7023223b37b"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("d0c94635-49ea-4639-9742-1ca85276315d"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("d125a6d2-87ad-480c-ad2d-72d292b7845b"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("d257cc22-47e7-4941-b9c9-166d258e14bd"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("d2771db6-d566-45be-8c17-80642a4b9e92"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("d39d3fa8-0b15-40ee-bea7-cd63f20220fa"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("d41a9137-bd89-4f57-907f-24fe5df0138d"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("d49d695c-0082-47ea-b6bf-c0c73a8743f4"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("d4e99ca3-3d52-4ef2-a514-b1334be459c4"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("d5883121-8fe3-4a91-9592-f56acfb1fae5"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("d6b74edf-19e6-420e-b6ec-036b9afc9e8d"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("d8c7f3b2-c7d1-4a8b-a8e3-7281f75dac60"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("d8d197f9-0d92-4d3a-80cc-ffd9d7205bac"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("d994c52d-c011-41d9-ad8e-3186f565a1d7"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("d9cdef95-59b5-40c4-be9d-f7e239f2dfb3"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("da06f286-3ca4-4fcb-ad4c-462c4c52ed86"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("da80ebff-d372-45a0-b9da-d79c0617b247"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("dcd43795-96c9-4141-a6f7-ecd9e4ab6da8"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("dd85773d-8d0f-4dd4-a9ff-a8718bcf042a"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("deb9ef20-5039-4d6d-a548-33a2d771b7e1"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("decb30c7-e01b-4a0c-b5c2-6fc283f556e8"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("df7e2672-1888-4134-b644-a1594e71d060"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("e0b90f61-673c-4326-bf6d-b0ec109d6cab"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("e10da1a3-becc-4877-b4e9-2b8bbe809684"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("e1af883f-365f-4a9b-a0db-b8f6b501b351"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("e2a77b25-378e-4b41-9641-f59f5dd63c2e"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("e2aed87a-c62d-4312-bcfc-a7da679a3ed7"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("e3749504-5967-4311-a370-19b8fff80be0"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("e52ea395-7a20-42c1-bce8-109afda31aa8"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("e8f766a0-5fc2-41fb-8bc4-a1651eeab987"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("e996dcf2-b2de-4471-b4a6-41f94fc76eb9"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("ea89f648-5491-44a8-bdf2-3e327f0161ce"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("ebd0f6ed-7264-4345-86a4-0f417c6212d8"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("ec688798-3e7e-4f51-9dcf-bd41df82c684"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("ee6db7bb-cd6b-45c5-9db0-2d85a28545d4"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("f0082c12-d57c-4f24-812f-28da844f6d4f"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("f0b995b1-1bd3-47ef-8a0d-d46356e55626"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("f0df1a4c-1b03-4200-9069-99f6b3dec160"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("f17be757-3264-4bd8-a5ac-000fd6d4b0e3"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("f1ea90af-6c34-47e4-bcd9-7944bdfb49c4"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("f2bdf65f-cea2-4752-85c1-bfc3724aae23"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("f3b5a7cf-e807-41fe-af9e-50c41d3edc0d"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("f4550f45-257f-455b-86b6-cf07403c7670"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("f5598ef3-b122-4c9a-bb25-74141eccdcb9"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("f5617a49-4534-447d-b782-cbe8fac06892"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("f73af884-3192-4dc6-b9f4-8f3c7e0d9cf8"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("f994a944-8b76-4d71-8c36-9b30e7096732"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("f9fbc680-8745-41b7-b3df-822bf9aaf9b0"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("fa6e99b4-0f43-4bad-ade2-b2b9b63c2242"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("fa7b2fe9-df0f-495f-a908-30fbf8e7cafb"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("fa8e6307-aaf8-4be6-8964-61bcc71bdd9a"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("fbb588fb-6cbb-4530-b2fd-cead8ab69f62"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("fc58cb90-3469-4cc3-99a4-cd1b0aa64c51"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("fd3dabcc-66ad-4f30-99a1-d24dac80e306"));

            migrationBuilder.DeleteData(
                table: "SubjectTypes",
                keyColumn: "Id",
                keyValue: new Guid("fe8c3ff5-ef99-408c-bbb0-2148dfea59bb"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("00a019a4-027c-4fe9-82f8-92669be4d1ba"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("00a269e0-695b-4bbd-962b-523e97381838"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("0167a1ad-8c8e-4487-8cc8-dc9a7ce2913a"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("01a87e32-ca1c-4432-a3fb-a6705fbb1cb1"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("01dd8510-a265-47c8-b9f0-892e0fa2b8cc"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("02964334-1c98-435e-b99c-566f33efb03f"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("030c1cf5-48ca-4893-b767-1b3e2a625e05"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("046396b9-5df1-4fd7-9f6d-b84ef81975c4"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("0590458d-4e5b-4909-9d45-30c705a4e38b"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("078fcbe7-943b-4481-b356-d674e39b22b0"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("07a90d69-f937-4cf1-b123-01b7983ae787"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("0a2c84c9-4a54-4768-88a1-653bf9046ed7"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("0ba0f4c2-77c2-4891-9fed-903e12967a0a"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("0ca1a578-367b-4fca-954c-1f6d9837173c"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("0cb9638f-e51a-4ffd-813c-6bf9d1f3662c"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("0d05d766-c5a5-46d2-9fee-1d1bd7267678"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("0f00eec6-8362-4920-a0d5-bf5d9b08bc8d"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("0ff302de-9074-45ea-8650-6ef046057756"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("1089c444-89c2-49e1-8e31-237773b4bbdb"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("14099075-f935-48c1-a94c-c1348dfd4243"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("1460cdf0-0472-41fe-8d74-5035e4c9d775"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("1544f60d-cbfc-429b-8f6e-1f28029134dc"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("15cd6a94-b0fc-4ed9-8e3c-6632004b05ee"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("1676f974-7e6c-456a-be87-c0606e6a117d"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("18d48ee3-468d-42dc-a29b-40ee0afc9406"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("19171c23-1e58-40e2-ac0f-e6d66941f057"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("195048ec-e7a7-42c2-a6a6-19af598bc581"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("195ac85a-fa25-40db-a58a-6f39a1d65b73"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("19adeea2-9f6d-4192-afe4-8af3a6da06af"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("1c6d8319-9dbf-47df-993d-be839c332ee4"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("1ccfd9df-5e24-4554-8cb5-a3036f85d854"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("1d4dc608-8e58-44a9-a1ba-75d9a117874a"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("1f512176-db86-4bfe-b80f-a3540619179b"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("1fbb0c15-5c65-4723-8668-1f29b76f6db6"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("1fe1633c-a4aa-425e-9d32-12bdd6640561"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("1ff41738-1a8a-4b9a-aab7-75ab6ff026b0"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("21a8e091-fa75-4dbe-abdb-104a9b398538"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("223b3527-20ce-42f7-b231-c5f3e68b790e"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("238ccde9-3991-48b3-876b-a0b6020fb426"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("2599fe6c-4228-4621-a8ac-41894cee75ed"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("2661a04b-369c-4208-b57b-d33f5376d68c"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("271e3a2c-81ba-4720-b3fb-adb22e4de15f"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("28b20f69-2038-408b-b21e-1447e6f43772"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("2984e81a-30cc-46e4-a7a6-560e21e71f8b"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("29def353-605a-4b32-a0a5-2296ec5d6ccb"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("2aebe351-d536-477a-a9d3-4548147acb2c"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("2c2f5243-f65b-46f4-998a-69fc754e8a2c"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("2ca871b6-7612-4ea5-b45f-7f7ecb2be7d7"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("2d166a85-901f-4e76-9b83-3b678d322810"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("2fa8d356-29c6-4f89-865c-244dc6f78889"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("3075a0a1-ef04-40db-b006-a0463b1e1348"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("31216b6b-399f-4f74-be14-71de6483bb6b"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("316d18c5-0714-4f5f-8e83-f13295016f79"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("31b34397-b626-4e31-ab43-61529f13a549"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("34b89a0c-6ab7-4c23-a295-8a93ffb7e01f"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("34d7f666-a6e5-4d30-8ce3-00e1fd0b264b"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("35695035-b37a-44c3-8d47-8f2561bdebd5"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("362a1dce-11f6-458c-8fa2-3a47e5b04b24"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("36c0ed72-24cc-4b9f-bef2-2459959f6512"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("36fddfc6-609d-47d5-8239-3a3f60e9ae8c"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("37298e3e-3d92-494e-b74e-61074a02102b"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("37543324-69ec-4549-9c8f-1ead424fb1d1"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("3781cdeb-55c2-4277-8ee5-aefb9e646572"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("396dde86-8633-4613-8d6c-7c36a76ca074"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("39eaf3fb-f54f-460f-b12d-2f5b24d7e268"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("3a50ea6c-c189-45a5-8807-851b25bbb392"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("3a523640-76a2-4e21-8f65-3f88e9b3862a"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("3a53f64e-2aa3-4c5c-bd44-d7b21832f07f"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("3a5f0bb7-5fb4-4193-aaa8-153eb79f7a2a"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("3a7a1791-9ea6-4d7b-95d1-f2ff68c03819"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("3accec83-2399-4d6a-94c4-d71b9fc41656"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("3b3928bd-120e-431c-be8d-810dc254f283"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("3b9b009a-df7f-47c8-990a-f69340215c7f"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("3d0cf7d4-3beb-4f8a-a08f-4264839800e3"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("3dfc4458-7d85-4a7c-abbe-f83f563d859f"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("3f25c6dc-457e-4633-8ce8-be4f7f3a6c8e"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("405de9c7-e4a3-498e-99ab-410d284a945f"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("41a1794c-dc09-450d-a0c0-71cc1dfe1b29"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("41b8bccf-b0d0-4708-b538-ee56cde49fe3"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("41fe30c7-c6e0-4925-8aae-446b2c736ed0"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("443e5850-fceb-42d0-964f-15e34f5b45c4"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("44c91d5a-7933-4330-a632-e08f50c70136"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("44d5f412-ef46-4734-8a59-b7dc63343876"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("453c56bf-ec06-4f3a-99e5-73455f0834dd"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("46e08432-9754-4d01-ba41-54068e271e2f"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("4775b212-cbc1-4602-8545-4ad5ad1b2ec0"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("48a0299b-6621-40d4-b84d-e9ba9b5abc9b"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("490c6dbc-3fd8-4d7f-95f0-99221aea0214"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("4b8a6e93-0a76-400b-b4dc-102b131e994f"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("4ba9bb5e-3eab-4d1b-8051-8320f79761ac"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("4bc155db-69fd-4245-a738-0db024116c5f"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("4d23acab-169d-411e-b15d-9f9bbefd3607"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("4d4e2e9a-fc4c-400a-b725-de5547e4ea9e"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("4ed74c5e-90e6-4231-84ca-1bd6d3a20c6e"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("503fe743-c681-47ee-a1b8-7da0c6ab8616"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("51c05c3a-1ee6-4600-8ccf-a4e852d03d19"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("5396582a-7256-4319-a5ff-6b59110526ff"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("54081509-ba88-4a54-b6d7-154f4e8c1c41"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("55476c0c-6539-4359-a0a8-a5ae124f63e0"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("55def556-0940-433d-96f2-1a5e95d983c0"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("56819dc3-ea9a-42d6-b919-ffd2a904cd5c"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("56d2d550-7c8b-42b0-a889-46a651bda589"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("57135ba2-6275-45e7-86a7-44b2ffb4b734"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("57d23f92-f675-4766-8601-2cd96eac2975"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("59ec43c5-6fb8-4064-b4f8-89d3320bc1a9"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("5a26a5d0-3325-401a-8cbb-5b634baaee98"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("5a72f36d-e440-4c71-ad6c-c42c50432557"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("5ac949f5-a633-429f-a503-1a23a1c1898e"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("5ad7fa49-9797-499d-b9b4-a73ff589b959"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("5b77835f-d97f-42da-af79-991a04e88829"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("5be68f0f-c05e-4e79-bff2-f1892d5f968b"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("5cd1608e-3f02-44f6-a909-f440364323a9"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("5dc08b3e-0af0-411e-9ec2-f43db7c803c6"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("5e5a462b-7ae2-4990-a41e-02154a481083"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("5e904aa2-2d6e-4829-88fd-4331b31cef76"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("5fb3bf91-9665-446d-9c82-fc91370bbf43"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("5fdc3430-5fba-4d46-b43d-8c1f34700497"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("6065a6ce-32cb-4b49-a5aa-b304a9d8b39c"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("61247ec3-f964-435a-9241-9f29991a4b84"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("616c9c2c-8c37-484f-b21e-5bac754dd06d"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("61cc5a7c-e76a-4a1c-b8fe-2a105e0fa348"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("64854252-1b37-434f-8342-94af068b8cb6"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("65713ea3-7a5b-4d27-9dc9-afc15a5b1594"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("65b96311-528e-463f-a7c0-e7ea3a8f6040"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("65d03a02-183c-44f4-b669-bd03701fb271"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("66186be4-79a7-4e21-a757-a1aaa7b78622"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("66e3ea3f-3608-4417-a991-32e268d6a9f7"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("6774f9d0-153f-40a8-93e5-fbb9ede1cdfd"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("6835df51-4407-4052-84ec-b6019ce88a35"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("6855aad3-ffe6-4d7e-8093-2ddf30e1be6f"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("686e5b84-c91c-4152-9118-a60cab6d760d"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("6a0dd354-f52b-4224-b8c6-65392acd4f0a"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("6a90a588-4435-49bf-b72c-93182a03d886"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("6bc32e0d-d1c5-4590-ad03-3b85469fce1a"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("6c48182c-ba9e-434b-8350-26152afaa256"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("6c71337e-e6b0-4dc5-9119-359c95b49805"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("6d90edcc-2b11-4eb6-823d-193c69cc300f"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("6db161d4-24cd-428e-9119-30d41d052171"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("6f5077b0-1a35-4922-806d-d5ad22cf58aa"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("6f8a3580-b8d0-4b19-abb5-cce51de765de"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("72328438-15fb-448f-aa3c-299a2d1268c1"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("72fbee82-5918-4f12-a2a4-d377ed83ef71"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("747e5d60-5387-4725-afac-ae1a2cf0b6b5"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("7486efd4-2180-44af-8f82-c47fa0cb1119"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("75014f39-c8cc-48fa-9662-fed1f3fe2b89"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("75a3152a-be9f-4269-a813-2dc4e4c28cd3"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("76258178-e95c-4ba2-8a16-a1f92df29394"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("76296426-56cd-499c-a39f-9ebfbc5b6844"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("7708e2c1-69ac-4d0f-868a-9745401180dd"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("79168535-6f59-4df2-838e-13add6eebe6c"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("7ab47f95-1f6e-4719-ab69-58a5a3deba91"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("7b3bd50c-e182-47b3-b7a5-f77d8f9484c1"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("7b8e577f-7e5d-4ff0-970a-4c36d8ee36b6"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("7ba12057-db30-4244-b454-c27989cc4f2c"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("7d030045-11f0-4d0d-a1fa-f5f86018f29f"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("7d2959df-0727-46be-ab77-2df9beba17e3"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("7e8af4d3-b2a0-4ad2-95c2-b4ee78d935d1"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("80571f8a-df22-4371-9e04-31255c229386"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("81e38cc0-230d-4122-92a6-dac68965c0b2"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("82a39b92-1116-4b4e-a249-f4bcac43234e"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("82c12e0e-c76d-4d78-aa4c-5021cbcbb65a"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("8340ba22-33f6-4dc3-baae-3e1c8f1b069b"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("847beab2-ccab-47be-ba89-ea19024ab468"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("85f08b24-be6e-41cc-b09c-5f30ee488b8e"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("867e883d-83a0-41c2-8971-82af2ee799cb"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("875372ee-f762-42bb-8672-cc908aecfd14"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("87f9efbc-b97f-4089-83fb-4840e4d630a8"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("880f880d-4c14-492e-939a-1acc344158ee"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("88ee8d91-c548-426c-a410-c8248e534bc9"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("89f1941f-6910-4b53-bfb1-457786b12c72"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("8c736d7f-3071-4c2b-8739-4e7f60e27232"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("8c804458-c2da-4319-8dae-fa841830f512"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("8cfea05c-8699-4314-ac24-53037885fa2d"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("8da37d4b-ff01-47de-be12-eb00fb07ebf2"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("8ea1a07d-d0cc-4fcb-a0f6-5bc94e1916cb"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("8fb14fc5-e0db-426e-99a2-9ce9e68d6c1b"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("8fc83843-bedc-4e23-a394-4eaac40d8f9b"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("8fecd7d7-4020-4d0d-abb6-1372630b7695"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("90746d1f-11f8-4d0c-8e56-2899e55be5bc"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("94b6ac05-9453-44ee-840e-80a4686fb194"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("9576950b-b63b-4510-9265-12e119489e8d"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("95e94b5f-6d65-4bd2-8a5f-1fec5bc99cdb"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("963e9487-507d-436c-b163-923e3e8c9a39"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("97d42393-57dc-48f0-8cf3-1beb5e542309"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("98d1f8eb-2b54-49f5-a0e9-b64e7265d96f"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("99a68dc1-a487-4144-9065-4ccbc19d180f"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("9aa72f35-fff5-4f19-9a58-77968fe1b329"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("9b153db0-7a1e-4651-9ebf-f01c9e4bba9b"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("9c2f3a70-77fe-48e0-8f40-04452373f6e1"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("9cbd5a04-6a15-4e53-ae70-968d20cc1956"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("9cd6db03-5f85-4aab-8d12-b7e51c35c2a8"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("9da58814-fc32-47db-89ee-e1ec4ffdc077"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("a04174c8-42f7-4fe7-aa8d-9b5bf36e8e17"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("a240cd24-5555-4350-8bc6-d9f78a3a8749"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("a372481d-9f01-4d6d-bf6b-d9e496ae2ebf"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("a5ce978b-96e1-47b0-9c3f-6c28148affa8"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("a76ae727-1ae4-489d-9a3e-2459ed3e567f"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("a845a994-b31d-42da-acea-74425a7a84f2"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("a9501f51-536a-45f5-9bb0-31bc724d8adb"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("aa1145e9-39f0-4669-b9f8-b66926be8b24"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("aa243e65-18b6-4767-ba69-bed8fc00e918"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("abfef4a0-e3ce-4ec7-827b-4deb994159f7"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("ad65f893-17f8-4bee-addc-76345c15697b"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("ad68f905-b109-4822-8dc7-934756a5032b"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("afba043a-38ac-4083-882a-a47da7524bd5"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("b02c37ac-ffd5-44b7-ac8b-7d2cf82d503f"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("b044fcb4-1740-4bce-b1f6-c3d7050376df"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("b0b08230-6535-4f78-9a2b-1a58f89d2350"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("b32b7493-f79e-4c9b-98eb-977306439c5b"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("b384ffc0-beb6-47bc-9533-82684b0f1ac7"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("b511c7da-2998-4b04-943d-876734422e4e"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("b6722f8b-cb2e-43c9-b1cc-2066ff0e7d62"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("b712ab55-4823-4297-9e27-2b86e7a3619a"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("b7ba8499-a6d6-4645-a854-641ab4683407"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("b9a0c1fe-5540-4cae-92d8-a9982ae3c171"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("b9c02476-19fe-4209-bfb4-9cc49f403232"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("bac6ddac-71bf-4eb1-a471-1e7dfb6abb75"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("baf408ec-22c0-4fa8-a0ab-151980e057eb"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("bb9ffc89-c5b6-4d5d-a7b2-4a60c0d86861"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("be619ea0-16c6-4173-be51-985da8858a35"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c02f938b-7fc8-4d5f-bd60-ad8d6bd99f43"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c288a69d-41f0-42e2-9f1f-1cfe76cb6616"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c2a6831d-f464-4e46-8813-76bf64d67aa0"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c2ea5893-9f0f-4ba3-b096-a145541f02ee"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c38a9655-a3dd-4c64-8ae5-89f3d2276f87"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c40dc40b-2273-451c-884f-112dea596db7"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c452c1c6-ae6b-4020-84ed-7a9324140d6e"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c48c99a9-bc2d-4d4b-a902-b7e86e0a4951"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c76ee0b5-26ff-460e-a622-9001a7c4e1c8"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c797cf38-3186-469c-8155-e36c22d044d0"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c8243a7a-6f0a-46e7-b592-577555473186"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c8cd92aa-1c29-4ba0-995d-cbca468ff9ea"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c93b3f51-87ee-4810-9dfb-5ba6bb01cfc4"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c9aeb37a-d557-4c86-8c02-35e21934c722"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("ca176e21-30bf-4ce9-8dba-7cc425b12dd1"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("caa40b1d-fa7d-4190-b910-12f4eaa6a891"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("cadb7fe4-cdd8-4f61-9231-cd438727db55"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("cae52c8a-755f-44d1-9a34-52eaecefef36"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("cb1b40be-6b95-40ff-ad38-1b6d59a6088f"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("cb97d3c1-b1a6-4054-96ef-8fb78a35d271"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("cce4ae5c-0cf8-48a4-baf2-c1815e57b8d0"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("cd823fb8-24a7-40c9-a085-d206bafc44ed"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("cd957506-9b00-4730-8c6e-71482ff9194a"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("ce559b3d-0925-452a-85a6-b4a4683c633c"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("cefc593c-e347-4bce-b077-3dd9059d174d"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("cff1f908-7fbe-4887-9c1b-f7023223b37b"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("d0c94635-49ea-4639-9742-1ca85276315d"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("d125a6d2-87ad-480c-ad2d-72d292b7845b"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("d257cc22-47e7-4941-b9c9-166d258e14bd"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("d2771db6-d566-45be-8c17-80642a4b9e92"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("d39d3fa8-0b15-40ee-bea7-cd63f20220fa"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("d41a9137-bd89-4f57-907f-24fe5df0138d"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("d49d695c-0082-47ea-b6bf-c0c73a8743f4"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("d4e99ca3-3d52-4ef2-a514-b1334be459c4"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("d5883121-8fe3-4a91-9592-f56acfb1fae5"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("d6b74edf-19e6-420e-b6ec-036b9afc9e8d"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("d8c7f3b2-c7d1-4a8b-a8e3-7281f75dac60"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("d8d197f9-0d92-4d3a-80cc-ffd9d7205bac"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("d994c52d-c011-41d9-ad8e-3186f565a1d7"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("d9cdef95-59b5-40c4-be9d-f7e239f2dfb3"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("da06f286-3ca4-4fcb-ad4c-462c4c52ed86"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("da80ebff-d372-45a0-b9da-d79c0617b247"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("dcd43795-96c9-4141-a6f7-ecd9e4ab6da8"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("dd85773d-8d0f-4dd4-a9ff-a8718bcf042a"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("deb9ef20-5039-4d6d-a548-33a2d771b7e1"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("decb30c7-e01b-4a0c-b5c2-6fc283f556e8"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("df7e2672-1888-4134-b644-a1594e71d060"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("e0b90f61-673c-4326-bf6d-b0ec109d6cab"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("e10da1a3-becc-4877-b4e9-2b8bbe809684"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("e1af883f-365f-4a9b-a0db-b8f6b501b351"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("e2a77b25-378e-4b41-9641-f59f5dd63c2e"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("e2aed87a-c62d-4312-bcfc-a7da679a3ed7"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("e3749504-5967-4311-a370-19b8fff80be0"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("e52ea395-7a20-42c1-bce8-109afda31aa8"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("e8f766a0-5fc2-41fb-8bc4-a1651eeab987"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("e996dcf2-b2de-4471-b4a6-41f94fc76eb9"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("ea89f648-5491-44a8-bdf2-3e327f0161ce"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("ebd0f6ed-7264-4345-86a4-0f417c6212d8"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("ec688798-3e7e-4f51-9dcf-bd41df82c684"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("ee6db7bb-cd6b-45c5-9db0-2d85a28545d4"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("f0082c12-d57c-4f24-812f-28da844f6d4f"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("f0b995b1-1bd3-47ef-8a0d-d46356e55626"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("f0df1a4c-1b03-4200-9069-99f6b3dec160"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("f17be757-3264-4bd8-a5ac-000fd6d4b0e3"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("f1ea90af-6c34-47e4-bcd9-7944bdfb49c4"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("f2bdf65f-cea2-4752-85c1-bfc3724aae23"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("f3b5a7cf-e807-41fe-af9e-50c41d3edc0d"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("f4550f45-257f-455b-86b6-cf07403c7670"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("f5598ef3-b122-4c9a-bb25-74141eccdcb9"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("f5617a49-4534-447d-b782-cbe8fac06892"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("f73af884-3192-4dc6-b9f4-8f3c7e0d9cf8"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("f994a944-8b76-4d71-8c36-9b30e7096732"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("f9fbc680-8745-41b7-b3df-822bf9aaf9b0"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("fa6e99b4-0f43-4bad-ade2-b2b9b63c2242"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("fa7b2fe9-df0f-495f-a908-30fbf8e7cafb"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("fa8e6307-aaf8-4be6-8964-61bcc71bdd9a"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("fbb588fb-6cbb-4530-b2fd-cead8ab69f62"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("fc58cb90-3469-4cc3-99a4-cd1b0aa64c51"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("fd3dabcc-66ad-4f30-99a1-d24dac80e306"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("fe8c3ff5-ef99-408c-bbb0-2148dfea59bb"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("0623c709-b6f1-406a-a333-2da97cdef813"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("071ed842-f78b-4e57-82a2-c976f1bdd73a"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("07549a7b-6fa3-4f60-8760-4016b33b59ec"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("0ae0d136-3af3-4e93-a02a-48583641749d"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("1bd05f1b-c95d-466e-bb8c-2e46337c016f"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("1d3dbbde-e547-455e-83fc-a13f8d128fa8"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("21d601c1-f670-4480-aa3e-621557c39d6c"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("24f8603c-ba71-43a0-9e20-ece0671963e6"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("26e9fbb9-4ca4-490d-af8e-f6c8de252318"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("2d6ab54c-e86c-4888-a00a-f46bbe19d3f5"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("33b35b28-36b3-437c-a04f-3df255d090cf"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("33e1703f-c1f8-49ad-b39d-b4c5fa5ceffb"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("358c4a65-6495-45db-a27d-4fb03cbe8c27"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("3a7c08af-096d-4a5c-be05-13d7ca700f25"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("3c328426-c014-493a-aad8-799397391960"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("3dadc217-c96c-4967-98c0-5da966491054"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("3df42c51-0c6c-49b8-96de-65076cb1a434"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("404effa3-fbc9-454a-8001-1ad3d3ac9413"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("41817995-b3d4-4146-8ff4-fde7641aa254"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("4f4ec2b7-5638-4820-ab8a-eaacf205e926"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("5348b7d1-b864-48ff-811b-bd4fe4e6b92c"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("565ed3dc-5efa-44b4-865c-df121c979faa"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("579cb0d0-e312-4570-b8c2-749da843e5e6"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("58e2cba6-8da1-4e61-af78-4b0ab83dded4"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("5975c4b5-3d31-49a9-8b38-11afbe50ba49"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("5d16cb00-fa27-4018-a65c-1095bd4de771"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("5f1404e4-e589-4967-804c-e0dce08b9bd8"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("5f7c945d-dbcf-4b50-9041-acc040048748"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("64b519eb-e8a9-42d4-94f1-5b6983fce245"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("65b6b80c-909f-4ae5-b2c1-eb881c71f4b3"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("678d3c3d-fa4f-4aa2-bff3-f784bb4e9c8b"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("6bb18b63-d075-4be4-817a-f0ea7e01d709"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("7406095b-fcc1-459e-9256-a2d121fb3915"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("7677ced5-2cc6-4e01-af96-8d9e37dcd41b"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("77f58067-695a-4a99-8c6f-be70bf80ec78"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("794bc366-2a63-4abd-b72c-73651e049446"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("79945dc6-ca50-4c2d-a279-3d0aaf3dbf28"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("79e312b9-c9a6-4126-bb7b-7324ac3ad63c"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("7c8923fb-0cf0-49ff-8c40-f890173c4054"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("7de98cff-22c8-417d-8f70-ce6a9bd41704"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("80b5550d-b872-41d0-8aa2-ac81d6af6144"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("815dea25-ac67-414d-9d9a-b62c66b63f2b"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("8306848f-7e77-4328-a5e8-d6de9f52cd2a"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("851aa153-687b-479d-8ac5-b771fcdebb59"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("89e94a97-3cc3-42ed-8d4b-50a3f93dc089"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("9108a295-5066-4b2b-bb42-b9348d7ce005"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("91412b2d-e0d2-4d06-a6f3-efb89df3d507"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("9185be87-3c3b-4205-8b8e-c882cfebb96a"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("9574d6d4-b55f-4aca-9e3b-fcde643ab710"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("95a6b347-fbd2-4403-b674-d2775b93ecd5"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("96971f91-63ab-415c-afa2-63fc9639c0db"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("9820cd84-7fe7-49cd-bdb9-543db13d781e"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("993c6f9d-dd37-46ce-9c16-654c2a71d048"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("9d67e102-d434-4eba-b015-47a6278ea7fb"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("a1373d1a-ba24-4a36-8857-c61480809e4b"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("a2cfcd56-608c-4139-a39a-24a4408ce83b"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("a44ae65e-d8ce-498e-b572-b43fabfbc0d6"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("a594bc71-7449-4bd7-96d5-a35c44dbc76a"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("ae2d28a6-b3c0-4db0-b00f-892001219a20"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("afdccca4-196e-4699-97a9-c1f304091cb3"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("b76dba8a-b35b-4a60-9894-b5bd00d5831f"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("bdd86f5c-d6b8-4015-8c90-aaf011d5a810"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("cbcb8532-1add-4a65-a7c8-2dcf1107e0b0"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("cda5d979-fb9c-4ab3-b183-415fcdf326d4"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("d00bb7ca-215f-445d-98cc-fa54dfebade5"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("d10afde9-dda3-46e3-bcf3-1106f39206ac"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("d1d343f0-3a10-4267-8020-3abfce7a5d9a"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("da75499e-a7be-4b84-9b3d-0ca955b0c1da"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("dc5490f2-702c-4414-921f-9c550d39f517"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("de5b29d8-e4cc-4e05-973d-55eb8154a789"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("e46853a9-703b-4a95-8a74-1b375a3925a6"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("e9a13f12-04c0-4639-a641-cc7886e38aba"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("ef98a29a-1ec5-4002-87b5-0570064befec"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("f52f7a9f-95a0-4a6a-9025-d90367740709"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("fd0f2b23-c1fe-46e5-9c44-4241d2dc64f6"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("0b665598-69f5-4b13-bde4-1394ff5c31dc"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("0d93d483-255a-4943-b456-c170b7309702"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("0f05fada-c852-4f14-beff-141c6ea5c26e"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("1a314662-8534-495b-b374-7ef2bb9b4bae"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("2c8fcd5b-a661-46a3-ac62-fda4e2ef789c"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("35247627-3f8b-4c56-8f6d-7c8ab4c64047"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("3667884a-88e0-48ba-81ad-dd08e4f6513f"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("3fafcc9f-d1f3-410e-a884-d616abadbfd2"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("48e8e41d-9d51-45db-98c6-5247fcf4a102"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("6611d417-e14a-4edf-8ba4-58689b831ee9"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("69706726-60c9-4c05-8855-e54e469466cc"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("718ba29e-2d49-4a4c-a9a6-9680a379181e"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("87b74d9d-d153-4f65-83c4-718345f266aa"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("8e5af34b-4511-4796-9027-7ed8ffdef45a"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a00da874-bb29-4e88-aef6-4ba73aa7c6a8"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b034a33a-0588-4988-8d91-e56505812847"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b1925b99-6048-443d-bb39-9a62fd414bf5"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b9202822-0576-4839-a1d3-9f0a56b39bcd"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("c091d70d-a3ad-405a-b021-5ed4e2079ea1"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("c235096d-5277-4bc6-9ebf-3bd0441bcfc9"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("cc0d0a24-97e6-4fb9-b52b-a4bf3e0c60ed"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d8f60351-f6ec-4823-a7fc-e7660c635bb7"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("ded29ebf-f062-4958-9f78-8df4fe9599cb"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("e540714c-712f-4c9c-bbe0-3c6e536a18cf"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("eb69393b-7dfa-4b8b-b3fe-0e83b6f3a956"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("1f2d8ba2-f238-4997-a776-32d088586268"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("24fdcb96-0e61-434b-b8d4-b3799e61ab81"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("50ea5bc9-6b16-4e67-99f1-507a10a9cf5e"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("65f4bdd4-54de-4386-af36-4dec081e1795"));

            migrationBuilder.DeleteData(
                table: "Campuses",
                keyColumn: "Id",
                keyValue: new Guid("d87e7e65-e11f-4b0c-b0af-a3a83634fa7d"));
        }
    }
}
