using PriceCompare.DAL.Data;

namespace PriceCompare.DAL.Repositories
{
    //Well done!
    public abstract class Repository
    {
        protected readonly PriceCompareDbContext _context;

        protected Repository(PriceCompareDbContext context)
        {
            _context = context;
        }
    }
}
