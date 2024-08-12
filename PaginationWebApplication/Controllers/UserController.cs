using Microsoft.AspNetCore.Mvc;

namespace PaginationWebApplication.Controllers
{
    public class User 
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public DateTime LastModified { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime LastDeleted { get; set; }
    }

    public class PaginationParameters
    {
        private int _pageSize = 10;

        public int PageNumber { get; set; } = 1;

        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > 0) ? value : _pageSize;
        }
    }

    public class PagedResult<T>
    {
        public int TotalCount { get; set; }
        public List<T>? Items { get; set; }
    }

    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] PaginationParameters paginationParameters)
        {
            int totalCount = users.Length;
            var userList = users
                .Skip((paginationParameters.PageNumber - 1) 
                       * paginationParameters.PageSize)
                .Take(paginationParameters.PageSize).ToList();
            var result = new PagedResult<User>
            {
                TotalCount = totalCount,
                Items = userList
            };
            return Ok(result);
        }

        User[] users = new User[]
                {
                    new User()
                    {
                        FirstName = "Adrián",
                        LastName = "Vega",
                        Email = "bb2730d7-3797-4e83-8b8f-45b943ac340e@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "José",
                        LastName = "Hurtado",
                        Email = "ddb837d2-d4da-4c9a-9040-c0c7b3a7268a@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Luis",
                        LastName = "Trujillo",
                        Email = "a3047347-d94b-4b00-ab64-b2fdf9c97d07@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "María",
                        LastName = "Serrano",
                        Email = "fdd16603-fa62-407c-a8db-7c29df490a58@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Nuria",
                        LastName = "Ochoa",
                        Email = "56cda595-8c72-4292-a638-324c19f43744@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "María José",
                        LastName = "Ruiz",
                        Email = "84bf9434-cc6c-45be-931c-80f08f7a208c@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Nora",
                        LastName = "Hernández",
                        Email = "45d42959-a3d0-4768-958f-27c2076e87e9@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Aitor",
                        LastName = "Gómez",
                        Email = "bc866703-f4c5-49d5-863f-5488654691cc@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Aitor",
                        LastName = "Uribe",
                        Email = "00401d8e-fb92-447f-b0c7-be5828eb78d8@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Alberto",
                        LastName = "Hernández",
                        Email = "62f30c58-278b-44e8-ad16-84210fee5f4a@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Ricardo",
                        LastName = "Lara",
                        Email = "bb48bb0f-c63b-4372-8cb6-24ec99dcd8cc@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Gabriela",
                        LastName = "Valencia",
                        Email = "0fee0e46-21b1-4c50-8185-9db5ecf742f3@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "María Pilar",
                        LastName = "García",
                        Email = "06d81ef0-5137-4327-8f86-f808406d8120@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Simón",
                        LastName = "Ospina",
                        Email = "80cc62df-73b2-4091-bd6d-45c3e2e39875@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Tomás",
                        LastName = "Martínez",
                        Email = "e56c78ac-fca3-4f9f-aaaf-34b95414d54c@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Adriana",
                        LastName = "Márquez",
                        Email = "fd481117-936c-4c13-ab36-ba7f4ac91b6d@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Javier Luis",
                        LastName = "Rincón",
                        Email = "0d649daa-8313-438a-bdd8-43d659be1952@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Marisol",
                        LastName = "Hernández",
                        Email = "ac620244-a54e-420c-a1a4-b5e467a23701@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Alfonso",
                        LastName = "Rodríguez",
                        Email = "65122e02-b74d-4473-bca8-c1558750a647@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Lorena",
                        LastName = "Cruz",
                        Email = "84a23994-5b58-40ae-9407-ab1b99780344@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Hugo",
                        LastName = "García",
                        Email = "f72d378e-1ce9-4949-8483-4c06e930fba5@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Mariana",
                        LastName = "Navarro",
                        Email = "0c3ff70c-dbb1-4261-aaee-4df7f0f5c4e8@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "María",
                        LastName = "Vélez",
                        Email = "528496f4-ab9e-4992-96c3-fed537ede245@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Jonás",
                        LastName = "Montoya",
                        Email = "b48c3c92-5097-400f-8f48-5e1e50a13413@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Julia",
                        LastName = "Ríos",
                        Email = "c06ccfd8-9530-4873-b419-500ca9ff8c3e@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Clara",
                        LastName = "Guzmán",
                        Email = "643b701d-3e05-4545-b7ec-71021f05e798@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Aitor",
                        LastName = "García",
                        Email = "003f76b2-6ab7-49e4-a942-090a62236cca@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "María Luisa",
                        LastName = "González",
                        Email = "e136aaf2-4882-4990-b7e0-7dc985f40c16@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Mariana",
                        LastName = "Arango",
                        Email = "0e5eebba-c86c-4ea1-8709-e9f43d861d85@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Francisco Javier",
                        LastName = "López",
                        Email = "b640a66e-38d5-4e79-8e47-bcb9b56d606d@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Rubén",
                        LastName = "Zapata",
                        Email = "b3496718-93a7-4a9a-8250-686616699d17@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Eduardo",
                        LastName = "Reyes",
                        Email = "73ef82e9-696c-49aa-a602-28aee9dd4ed9@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Santiago",
                        LastName = "Márquez",
                        Email = "0bd30b6a-a596-45e7-b5d6-1103da5b9680@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Andrea",
                        LastName = "González",
                        Email = "4a51d2cd-de53-4a4e-a12c-182318a3690a@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "María Fernanda",
                        LastName = "Vélez",
                        Email = "8af3b4c3-0728-4b44-900c-bbc1c8e4d1f8@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Alicia",
                        LastName = "Ospina",
                        Email = "0a094469-8dd1-4298-aa5f-c7d9eb48f80c@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Mario",
                        LastName = "Gómez",
                        Email = "f9bac0e1-1749-4550-a594-8e4d2ba68e75@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Andrés",
                        LastName = "Martínez",
                        Email = "1a9416fc-a79f-4ca2-8338-bf4f53570f0c@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Felipe",
                        LastName = "Zapata",
                        Email = "90da1a82-aeee-4e87-9523-8841b7010309@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Andrea",
                        LastName = "Gallego",
                        Email = "29a908bc-a3fc-4eb2-9d3a-00d08f97e955@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Francisco",
                        LastName = "Guzmán",
                        Email = "8b55a302-1c7f-4d69-8ff6-bfbc4f655f49@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Joaquín",
                        LastName = "Rivera",
                        Email = "eaaf3db7-1cf4-465b-a51f-794a1479887a@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Julia",
                        LastName = "Jaramillo",
                        Email = "d1ee1142-ef7f-449d-ab9b-d4816811c83b@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Rafael",
                        LastName = "Moya",
                        Email = "a3d0477c-4ee0-466c-b174-7ab8d90d0be3@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Daniel",
                        LastName = "Herrera",
                        Email = "445286b7-66d0-4c4d-b627-dea76cc105e2@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Natalia",
                        LastName = "Romero",
                        Email = "346b8b81-d32d-4585-8153-82f69a51e129@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Miguel",
                        LastName = "Rojas",
                        Email = "626532d3-f953-4408-8d81-0950b768637a@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Julián",
                        LastName = "Ayala",
                        Email = "542b3cb3-9f14-4c4c-85d1-3aaa3d7da837@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "María Jesús",
                        LastName = "García",
                        Email = "d840180a-7612-4203-903a-1b3988155f91@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Martín",
                        LastName = "Gómez",
                        Email = "fc678bba-c73e-4103-af05-a4add8690535@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Lorena",
                        LastName = "Rodríguez",
                        Email = "4a4a23aa-90a7-4b34-acd9-2d95c0ff0dde@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Rosario",
                        LastName = "Guzmán",
                        Email = "e6206ee8-d8eb-4f6d-85d7-b1f914194ab8@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Patricia",
                        LastName = "Hernández",
                        Email = "cec1d314-0104-442a-a6d0-2dee372cf940@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Alan",
                        LastName = "Ríos",
                        Email = "77b48873-1dff-4609-873b-c0202fa53e29@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Rodrigo",
                        LastName = "Ortiz",
                        Email = "9eeb0c42-f655-487a-8289-d6629cfb0018@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Agustín",
                        LastName = "Serna",
                        Email = "5d73e24a-c79d-4b4c-a7c8-d17d20c2017d@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "José",
                        LastName = "Rodríguez",
                        Email = "d3bbebf8-33ff-4773-9390-966d5c3806c2@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Lorena",
                        LastName = "Álvarez",
                        Email = "26315337-77a9-4036-a807-24579c9a9746@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Nicolás",
                        LastName = "Pérez",
                        Email = "d4a147af-4f9d-4061-94dc-8338aef92081@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Benjamín",
                        LastName = "Vega",
                        Email = "651cc2bb-d4a9-4c88-a752-d285ef7ceed3@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Juana",
                        LastName = "Alonso",
                        Email = "bf02f549-21f9-439d-9cf5-3dbd680bc8f9@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Sergio",
                        LastName = "Díaz",
                        Email = "a6a8be92-f243-471c-bc10-7778ec8cf419@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Pedro",
                        LastName = "García",
                        Email = "48db06f1-b9ba-49f0-9b04-f3051b3878bb@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Alejandra",
                        LastName = "Herrera",
                        Email = "959ca441-df3e-4bbf-956e-2c691fbcc7b5@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Guillermo",
                        LastName = "Ramos",
                        Email = "011afed3-fe4c-4f12-960a-cd81f73a5570@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Claudio",
                        LastName = "Hurtado",
                        Email = "207d96ba-1ac4-499b-91d9-274044410a25@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Juana",
                        LastName = "Chávez",
                        Email = "6ab28973-03e0-4560-9811-c3803356930f@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "María Teresa",
                        LastName = "Hurtado",
                        Email = "f58839a9-f421-4110-9f45-5c92523efa0d@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Cecilia",
                        LastName = "Paredes",
                        Email = "0dd4f164-888a-4550-9525-7052ce94b158@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Juan",
                        LastName = "Melo",
                        Email = "28538d4d-dcdc-4a7d-b43f-b3e1338f4a81@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "César",
                        LastName = "Ríos",
                        Email = "2e487fdf-b8c5-4842-a203-08d9d8495c3c@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Mario",
                        LastName = "Bravo",
                        Email = "77b496a9-29c3-44e2-b356-bf617dfb42b6@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Patricia",
                        LastName = "Ruiz",
                        Email = "25254351-0f7a-4feb-b5c4-b5cf1003c702@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Mario",
                        LastName = "Villarreal",
                        Email = "8e646383-698b-4f5a-b149-9edba2ef9a50@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Agustín",
                        LastName = "Vázquez",
                        Email = "f083c6d6-ea38-4e5c-9b15-db6ea4f2c2af@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Gabriela",
                        LastName = "Sánchez",
                        Email = "55f68ba8-a08f-4877-88ec-0a222559bdf0@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Gloria",
                        LastName = "Agudelo",
                        Email = "dbf43411-d3bf-4f68-ad26-d4adbd76d33c@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Ana",
                        LastName = "Arévalo",
                        Email = "5e189474-5e18-47fd-a99e-67f95eba7391@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Jesús",
                        LastName = "Jaramillo",
                        Email = "4a68d545-64b4-4287-be3b-bdbad4cba948@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Francisco Javier",
                        LastName = "Henao",
                        Email = "4639baa7-f1f2-42c0-acfa-624778d15018@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Mariana",
                        LastName = "Álvarez",
                        Email = "1167a1a2-e5e5-4fbc-987c-ca8cb88c6a17@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Adrián",
                        LastName = "Trujillo",
                        Email = "8279ea7c-b7b2-459c-b6a5-7df1052ee046@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Juan",
                        LastName = "Vásquez",
                        Email = "451bd237-44bd-4a7f-93a8-4c7c31269fad@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Fabián",
                        LastName = "Vega",
                        Email = "93249950-61cc-4cbb-a9bb-26ced62ba47b@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Samuel",
                        LastName = "Gómez",
                        Email = "ffcc729c-dfaf-41c1-a90d-c4e541d989a4@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Felipe",
                        LastName = "García",
                        Email = "82ab258e-7e4e-42fc-a2f4-8ab8bc695fec@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Alejandra",
                        LastName = "Jiménez",
                        Email = "02f5922c-5721-4e87-a7d1-cbf031999b6a@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Alberto",
                        LastName = "García",
                        Email = "5d929d20-6368-47f6-b547-134002747765@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Mariana",
                        LastName = "Paredes",
                        Email = "e24810c6-b99a-4e46-89af-81ca0f810dff@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Antonio",
                        LastName = "Rodríguez",
                        Email = "360a3767-6986-4b7c-b993-822935e71185@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "María Teresa",
                        LastName = "Arango",
                        Email = "f1a74b2a-1370-4904-8082-ededf7b8ba05@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "César",
                        LastName = "Lozano",
                        Email = "e71f6445-f4bc-4175-869b-2c7624bc8a1c@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "María Fernanda",
                        LastName = "Cárdenas",
                        Email = "52c64ab9-bb7e-49c5-8bdf-190fa43f1eb8@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Víctor Manuel",
                        LastName = "Mendoza",
                        Email = "0f346dc9-c891-4fcb-b5e0-8b41ae042506@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Francisco",
                        LastName = "Mora",
                        Email = "613ccf67-6ee9-4d22-9182-15657fe2f6c6@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Teresa",
                        LastName = "Figueroa",
                        Email = "55bb7448-cefd-49ab-91a0-fac426ed1827@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Laura",
                        LastName = "Suárez",
                        Email = "5e93222f-a599-4fa9-ad47-b04f81f489ea@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Antonio",
                        LastName = "Gómez",
                        Email = "2f5e107c-466d-4c6c-8afa-77a152371430@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Andrea",
                        LastName = "Guzmán",
                        Email = "c794c95f-2752-429e-800f-e3fa824a4dec@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Ramón",
                        LastName = "Medina",
                        Email = "3d76e3a4-fdd2-4696-8614-0c47e38fa362@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Alejandra",
                        LastName = "Rodríguez",
                        Email = "480d1068-1748-4321-92fb-5b9207295405@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Guillermo",
                        LastName = "Pérez",
                        Email = "8c0fad8c-f3ae-4b9f-8bd6-196dde54999f@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Eugenia",
                        LastName = "Jurado",
                        Email = "e5d5f5c9-9bfe-48e0-bac9-c536661b4d01@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Teresa",
                        LastName = "Gómez",
                        Email = "7716aaac-c80a-4cb2-91e5-a24047ba0013@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Elena",
                        LastName = "García",
                        Email = "40eb04f6-6504-449b-a187-e3ab9fb3c1fb@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Mónica",
                        LastName = "Márquez",
                        Email = "91c8ab1a-0f33-4ab0-b865-26ad774d8e5a@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Alan",
                        LastName = "Bautista",
                        Email = "c54ee271-bcef-4ce2-a87b-b482e3ff6819@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Guillermo",
                        LastName = "Hurtado",
                        Email = "af7c8b79-4180-48a3-bd8c-021e28b78b6c@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Hugo",
                        LastName = "García",
                        Email = "dfea83c5-fa90-496f-a7de-5c47baffa615@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Sergio",
                        LastName = "Gutiérrez",
                        Email = "ce11d63a-fc47-436c-8a8b-65ac8226e95d@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Rosario",
                        LastName = "Díaz",
                        Email = "e3e713e2-b633-4934-afea-5ff726fc6606@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Julia",
                        LastName = "Rincón",
                        Email = "12097c48-731b-4d7f-af93-a91021b30345@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Julián",
                        LastName = "Hernández",
                        Email = "9b522d4d-2d8e-40de-9deb-fa581b056ee9@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Silvia",
                        LastName = "Bermúdez",
                        Email = "8a34497b-fbd4-4213-8f90-9cbeea184655@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Adriana",
                        LastName = "Ocampo",
                        Email = "c6254ac1-14c9-4551-b2d0-9176c5b60fb5@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Marta",
                        LastName = "Mendoza",
                        Email = "4a12173c-4085-4857-92ba-a4ce6a8fd199@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Daniel",
                        LastName = "Cardenas",
                        Email = "1a0c9dff-f3a7-4373-991b-3233e408998f@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Federico",
                        LastName = "Velázquez",
                        Email = "84c9dc06-98a3-4c0d-8aa2-eba69587426a@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Aitor",
                        LastName = "Arango",
                        Email = "949878f0-7fa8-4f73-acd1-61fdbf91168f@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Alejandra",
                        LastName = "Cardenas",
                        Email = "287eab24-1a00-466a-8e96-5a4f3123dc92@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Francisco Javier",
                        LastName = "Sánchez",
                        Email = "3ca02b41-db74-4746-8e5f-69d743b51249@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Angélica",
                        LastName = "Rodríguez",
                        Email = "ba08a730-e7c0-4536-846b-ab28a0119bbb@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Jaime",
                        LastName = "Murillo",
                        Email = "5984000f-d9dd-4165-bfba-0645ab3a7294@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Laura",
                        LastName = "Guzmán",
                        Email = "1955be26-91fb-4ab0-b9d3-52b6bdf9967d@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Carmen",
                        LastName = "Jaramillo",
                        Email = "e35fc54b-8ead-4150-a25e-d5186261c270@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Luis Miguel",
                        LastName = "Ospina",
                        Email = "d43c300f-3bca-42e7-9b77-471edc7a6463@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Natalia",
                        LastName = "García",
                        Email = "10dc41de-b79d-46c2-a3eb-b50bdf896e02@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Gabriela",
                        LastName = "Suárez",
                        Email = "bc06dceb-7f24-4efc-b77a-4edfc3265f08@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Inés",
                        LastName = "Ochoa",
                        Email = "e5869a8d-067e-4674-8e6c-c4bef447040f@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "César",
                        LastName = "Cruz",
                        Email = "0d923420-69d7-443c-83f2-fc1763f543d4@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Eduardo",
                        LastName = "Ramos",
                        Email = "4376a571-0aaa-40a7-b2a2-3e6ff0766094@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Moisés",
                        LastName = "Salazar",
                        Email = "d1514cf8-d6ed-404e-afc0-9c20e705f917@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "María Fernanda",
                        LastName = "Fernández",
                        Email = "284e7994-1539-4f6a-904a-33be57deaf47@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Aitor",
                        LastName = "Núñez",
                        Email = "611e0c86-57bc-4d23-812f-49e812c33885@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Marta",
                        LastName = "Cruz",
                        Email = "0d508e26-7546-4d07-b64c-856d94be9608@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Hugo",
                        LastName = "Márquez",
                        Email = "73b6445e-d54b-4ab0-b99d-37743e9b2852@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Marcos",
                        LastName = "Morales",
                        Email = "0775189c-a135-4a11-b0a3-a14779f52bde@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Juana María",
                        LastName = "Medina",
                        Email = "ec1c5020-edc8-4a77-ade0-ce0b1033be2b@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Carmen María",
                        LastName = "García",
                        Email = "f1f6c1ed-bafa-4a16-add3-d00afd7d552e@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Adrián",
                        LastName = "Medina",
                        Email = "386a818b-85fd-406b-883e-b977b499d0b9@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Luis Miguel",
                        LastName = "Bautista",
                        Email = "e4231f06-787d-442f-967e-c1839d021f7b@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Francisco",
                        LastName = "García",
                        Email = "448bf123-9969-46d6-8823-8eaf304f8c98@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Francisco Manuel",
                        LastName = "Alvarez",
                        Email = "c919a0cd-5f27-4e33-9d74-e4def43f0d44@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Alejandro",
                        LastName = "Ríos",
                        Email = "2208e58a-3f5e-4b71-98eb-a83e42c9eadd@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Tomás",
                        LastName = "Gómez",
                        Email = "bddc9a1b-1a75-4478-901a-edfd6d3f6de3@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Paula",
                        LastName = "Vega",
                        Email = "ce9287cb-0483-413e-b3c9-477a98bdf1ae@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Teresa",
                        LastName = "Gómez",
                        Email = "94ebc27a-d042-4b20-814d-ab8720bd4e1b@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Manuel Jesús",
                        LastName = "Alvarez",
                        Email = "7f6d162e-3c0c-4c7b-ac75-da501c67c7d0@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Mariana",
                        LastName = "Velázquez",
                        Email = "06feb174-0dfd-4ec3-9098-b8cf42f565e4@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Marta",
                        LastName = "Hernández",
                        Email = "17255b4b-e60e-4d0a-bfe7-8684e472c3a0@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Angélica",
                        LastName = "Aristizábal",
                        Email = "77961293-0c00-45e7-91ef-c836b7cf3cfc@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Juana",
                        LastName = "Bermúdez",
                        Email = "099a16ce-d991-401a-ad3f-e5a0b40bd394@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Julia",
                        LastName = "Palacios",
                        Email = "bb4dea5d-fd8e-41e7-85fa-099a18157326@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Marta",
                        LastName = "Salazar",
                        Email = "64cd42e4-330b-44ca-b369-511d6f2e3514@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Francisco Javier",
                        LastName = "Romero",
                        Email = "99ca9f5d-9c5d-4a26-a0b4-2b4f0426ec52@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Silvia",
                        LastName = "López",
                        Email = "f4579f2c-ca34-4b1b-a883-4b334f60f530@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Teresa",
                        LastName = "Serrano",
                        Email = "8e1e0ae1-c7ab-4d93-ad20-2e8247a8d686@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "César",
                        LastName = "Vargas",
                        Email = "46059a7e-6596-4c1e-8713-6f047e73dfee@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Carmen",
                        LastName = "Correa",
                        Email = "1f7b21a5-3bba-45bb-9178-54c2bad45def@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Silvia",
                        LastName = "García",
                        Email = "9ed92eab-4233-41f3-aff4-72dd325755cb@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Patricia",
                        LastName = "Rincón",
                        Email = "bd94dd7d-4037-4ec4-9c42-1a70f3fce5be@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Emilia",
                        LastName = "Bravo",
                        Email = "941777ba-6fdf-4223-9b6e-958e413aa02a@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Raquel",
                        LastName = "Rojas",
                        Email = "9a09dbf0-5d20-4ea6-a88b-34e7b69e13dd@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Nicolás",
                        LastName = "Guzmán",
                        Email = "9251c1e9-cfc9-4860-b959-545278a4b7d4@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Martín",
                        LastName = "Reyes",
                        Email = "bd33adcb-042b-4084-9570-a5208f35f590@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Eduardo",
                        LastName = "Pérez",
                        Email = "60da0da5-eae0-4c6f-a0f7-51379df673c1@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Víctor Manuel",
                        LastName = "López",
                        Email = "231d48c3-9806-47b9-8930-fba871f568d6@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Nicolás",
                        LastName = "González",
                        Email = "85818d47-4265-4eff-bfa1-e23876d2a2ca@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "César",
                        LastName = "Torres",
                        Email = "298aca03-78c4-4989-a4bf-f6859528bdf1@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Samuel",
                        LastName = "Palacios",
                        Email = "a49ac508-1a9f-4633-b07f-aabc99406682@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Marta",
                        LastName = "Zapata",
                        Email = "cb74aef0-2d80-43c7-93b4-e087755860e2@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Nicolás",
                        LastName = "Cardenas",
                        Email = "f05a3edc-828d-4f2f-aeb6-278d8075156c@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "María Pilar",
                        LastName = "Guzmán",
                        Email = "88c5defe-b569-45f7-88ff-fe3928333c1a@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Fabiola",
                        LastName = "González",
                        Email = "efa32a6b-161e-4b01-ac21-dcd3a0cd9fef@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Ramón",
                        LastName = "Mendoza",
                        Email = "ef7e66c5-92b7-49a9-8ccc-c9b5c2052f53@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Teresa",
                        LastName = "García",
                        Email = "455db3e9-66df-438d-aba4-f2a67770665a@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Manuel Jesús",
                        LastName = "Márquez",
                        Email = "29b661d7-606b-45d2-8b30-a1051321d239@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Emilia",
                        LastName = "Pérez",
                        Email = "e2c2b182-5d8f-4465-82fd-ca1b6a808fbe@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Rosario",
                        LastName = "Alonso",
                        Email = "7448e016-7736-43f2-a523-9ceb0f2a355c@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Nicolás",
                        LastName = "Herrera",
                        Email = "8239ae46-3a9f-46eb-83f6-4eb6a02f8f59@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Víctor",
                        LastName = "Ospina",
                        Email = "b66a4d25-f346-46fb-a5c2-a3703fb99865@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "José",
                        LastName = "Chávez",
                        Email = "07f27b3c-6be0-45c7-8f93-1953399ce315@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Víctor",
                        LastName = "Zapata",
                        Email = "ff981b6f-72d2-4ff1-9b9a-082baf28372c@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Octavio",
                        LastName = "Bravo",
                        Email = "ae67fe4a-01ec-4f92-91eb-c9153f5a5815@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Gabriela",
                        LastName = "Montoya",
                        Email = "e1ff83e0-b42b-47b5-9f4e-730c13d7f3d0@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "José",
                        LastName = "Bermúdez",
                        Email = "e3767946-ab32-40f9-8f03-9b7d54fc42b2@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Ángel Luis",
                        LastName = "Núñez",
                        Email = "0911c243-8bf0-4973-9cea-916b511273fa@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Jaime",
                        LastName = "Gallego",
                        Email = "3bf91b97-905e-4794-8835-9040dd2f1641@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Adriana",
                        LastName = "Villarreal",
                        Email = "e0f2fc88-0e1c-440f-91fe-2bcc6973ee2e@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Alberto",
                        LastName = "Ayala",
                        Email = "6b062522-e306-4078-8cb1-5cddf9003d6f@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Teresa",
                        LastName = "Gómez",
                        Email = "2f4fcca8-cf91-42a5-af52-23b5258fd2d1@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Teresa",
                        LastName = "Sánchez",
                        Email = "71e89cbe-0c17-45cf-a2e9-753a219dc22c@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Pedro",
                        LastName = "Serna",
                        Email = "a7d98ae5-b17f-4c83-8250-662c7988d6d5@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "María Luisa",
                        LastName = "Rincón",
                        Email = "5f5f22e9-a802-4278-aa52-2f37bd3da2b5@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Javier Luis",
                        LastName = "Serna",
                        Email = "58a4f927-175b-437b-bfd8-b22eb07364c3@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Agustín",
                        LastName = "Alvarez",
                        Email = "13535bc3-baf7-4e73-901c-0ed23beaf11c@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "José",
                        LastName = "Salazar",
                        Email = "8294d7fd-6ad6-4df8-8c6d-1c296e621518@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "María Jesús",
                        LastName = "Gómez",
                        Email = "990abfe8-16c5-4e4c-8d7c-e66f4a09dd51@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Francisco José",
                        LastName = "Vega",
                        Email = "8476196f-f152-46df-bd6d-ab5010bc1bf6@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    },
                    new User()
                    {
                        FirstName = "Santiago",
                        LastName = "Trujillo",
                        Email = "6edf08e1-a5cf-4807-a233-92087f623301@gmail.com",
                        PasswordHash =
                            "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5",
                        LastModified = new DateTime(2024, 8, 8),
                        IsDeleted = false,
                        LastDeleted = new DateTime(2024, 8, 8)
                    }
                };
    }
}
