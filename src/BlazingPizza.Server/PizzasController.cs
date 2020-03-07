using Microsoft.AspNetCore.Mvc;

namespace BlazingPizza.Server
{
    [Route("pizzas")]
    [ApiController]
    public class PizzasController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PizzasController(ApplicationDbContext db)
        {
            _db = db;
        }
    }
}
