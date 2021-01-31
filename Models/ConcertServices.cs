using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhilarDataApp.Models
{
    public class ConcertServices
    {
        private ConcertDbContext dbContext;

        public ConcertServices(ConcertDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<Concert>> GetConcertsAsync()
        {
            return await dbContext.Concerts.ToListAsync();
        }

        public async Task<Concert> AddConcertAsync(Concert concert)
        {
            try 
            {
                dbContext.Concerts.Add(concert);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception) 
            { 
                throw; 
            }

            return concert;
        }

        public async Task<Concert> UpdateConcertAsync(Concert concert) 
        {
            try
            {
                var concertExist = dbContext.Concerts.FirstOrDefault(p => p.Id == concert.Id);
                if (concertExist != null)
                {
                    dbContext.Update(concert);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return concert;
        }

        public async Task<Concert> RemoveConcertAsync (Concert concert)
        {
            try 
            {
                dbContext.Remove(concert);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception) 
            { 
                throw;
            }
            return concert;
        }
    }
}
