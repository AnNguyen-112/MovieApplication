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
    public class CastRepository : BaseRepository<Cast>, ICastRepository
    {

        public CastRepository(MovieDbContext context) : base(context) 
        {
            
        }
    }
}
