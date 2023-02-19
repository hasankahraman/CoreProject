using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BlogRating
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public int BlogTotalScore { get; set; }
        public int RatingCount { get; set; }
        public double RatingAverage { get; set; }
    }
}
