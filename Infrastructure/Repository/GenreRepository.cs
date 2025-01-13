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
    public class GenreRepository : BaseRepository<Genre>, IGenreRepository
    {
        
        public GenreRepository(MovieDbContext context) : base(context)
        {
            
        }

        public void Welcome()
        {
            throw new NotImplementedException();
        }
    }
}
