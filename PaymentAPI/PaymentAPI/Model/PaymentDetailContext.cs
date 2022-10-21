using Microsoft.EntityFrameworkCore;

namespace PaymentAPI.Model
{
    public class PaymentDetailContext:DbContext
    {
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> option) : base(option)
        { }
            public DbSet<PaymentDetail> PaymentDetails { get; set; }

        
    }
}
