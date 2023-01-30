using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;
using WebApplication4.Models.DTOs.Requests;
using WebApplication4.Services;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private PgagoContext _context;
        private readonly IDbService _databseService;

        public ClientsController(PgagoContext context, IDbService databseService)
        {
            _context = context;
            _databseService = databseService;
        }

        [HttpGet]
        public async Task<IActionResult> GetClients()
        {
            var context = new PgagoContext();
            var client = context.Clients
                                .Select(c => new
                                {
                                    cos = c.LastName
                                });
            return Ok(client);
        }

        [HttpPost]
        public IActionResult CreateClientAndTrip(CreateClientAndTripRequestDto request)
        {

            var client = new Client
            {
                LastName = request.LastName
            };
            var trip = new Trip
            {
                Name = request.TripName
            };

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetTrips()
        {
            var data = await _databseService.GetTrips();
            return Ok(data);
        }

        [HttpDelete("{clientId}")]
        public async Task<IActionResult> DeleteClient(int clientId)
        {
            var data = await _databseService.DeleteClient(clientId);

            if (!data)
            {
                return Conflict("Nie mozna usunac, aktywne wycieczki");
            }
            else
            {
                return Ok("pomyslnie usunieto");
            }
        }
    }
}
