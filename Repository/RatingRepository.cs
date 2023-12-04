using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RatingRepository : IRatingRepository
    {
        private readonly StoreDataBase2Context dbContext;

        public RatingRepository(StoreDataBase2Context dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task addRating(Rating rating)
        {
            await dbContext.Ratings.AddAsync(rating);
            await dbContext.SaveChangesAsync();
            


        }

    }
}
