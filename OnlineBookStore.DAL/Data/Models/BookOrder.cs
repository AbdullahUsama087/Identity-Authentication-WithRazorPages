using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore.DAL.Data.Models
{
    public class BookOrder
    {
        public int Id { get; set; }

        public int BookId { get; set; }
        public int OrderId { get; set; }

    }
}
