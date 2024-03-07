using MyBlazorAppFirst.Data;

namespace MyBlazorAppFirst.Components.Services
{
    public class VendorService
    {
        protected readonly ApplicationDbContext _context;
        public VendorService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Vendor> DisplayVendors()
        {
            return _context.Vendor.ToList();
        }
    }
}
