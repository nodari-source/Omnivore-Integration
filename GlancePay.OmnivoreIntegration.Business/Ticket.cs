using System.Collections.Generic;
using System.Linq;

namespace GlancePay.OmnivoreIntegration.Business
{
    /// <summary>
    /// Omnivore ticket
    /// </summary>
    public class Ticket
    {
        public List<Payment> payments = new List<Payment>();

        public long TicketId { get; set; }

        /// <summary>
        /// Amount to pay
        /// </summary>
        public decimal Due { get; set; }

        /// <summary>
        /// Overall amount paid by the ticket
        /// </summary>
        public decimal Paid
        {
            get
            {
                decimal paid = 0;
                if (payments != null && payments.Count > 0)
                {
                    paid = payments.Sum(x => x.Amount);
                }
                return paid;
            }
        }

        /// <summary>
        /// List of payments paid by the ticket
        /// </summary>
        public List<Payment> Payments
        {
            get { return payments; }
            set { payments = value; }
        }
    }
}
