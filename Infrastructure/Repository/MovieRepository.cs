using ApplicationCore.Contracts;
using ApplicationCore.Entities;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class MovieRepository: BaseRepository<Movie>, IMovieRepository
    {
        
        public MovieRepository(MovieDbContext context) : base(context)
        {

           

        }

        

        
    }
}
