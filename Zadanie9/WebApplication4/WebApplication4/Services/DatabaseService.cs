using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;
using WebApplication4.Models.DTOs.Responses;

namespace WebApplication4.Services
{
    public interface IDbService
    {
        public IEnumerable<GetClientStatistiscsResponseDto> GetReport();

        Task<bool> DeleteClient(int clientId);
        Task<IEnumerable<GetTripsResponseDto>> GetTrips();
    }

    public class DatabaseService : IDbService
    {
        private readonly PgagoContext _context;

        public DatabaseService(PgagoContext context)
        {
            _context = context;
        }

        public IEnumerable<GetClientStatistiscsResponseDto> GetReport()
        {
            return (IEnumerable<GetClientStatistiscsResponseDto>)_context.Clients
                           .Select(c => new
                           {});
        }
        public async Task<bool> DeleteClient(int clientId)
        {
            var res = await _context.ClientTrips.FirstOrDefaultAsync(t => t.IdClient == clientId);

            if (res != null)
                return false;

            Client clientToDelete = new Client { IdClient = clientId };

            _context.Clients.Attach(clientToDelete);
            _context.Entry(clientToDelete).State = EntityState.Deleted;

            var results = await _context.SaveChangesAsync();
            return results > 0;
        }

        public async Task<IEnumerable<GetTripsResponseDto>> GetTrips()
        {
            var results = _context.Trips.OrderByDescending(t => t.DateFrom)
                .Include(e => e.ClientTrips).ThenInclude(ct => ct.IdClientNavigation)
                .Include(e => e.CountryTrips).Select(rec => new GetTripsResponseDto()
                {
                    Name = rec.Name,
                    Description = rec.Description,
                    DateFrom = rec.DateFrom,
                    DateTo = rec.DateTo,
                    MaxPeople = rec.MaxPeople,
                    Clients = rec.ClientTrips.Select(r => new GetClientsTripsResponseDto()
                    {
                        FirstName = r.IdClientNavigation.FirstName,
                        LastName = r.IdClientNavigation.LastName
                    }).ToList(),
                    Countries = rec.CountryTrips.Select(r => new GetCountriesTripsResponseDto()
                    {
                        Name = r.IdCountryNavigation.Name
                    }).ToList()

                }).ToList();
            return results;
        }
    }
}
