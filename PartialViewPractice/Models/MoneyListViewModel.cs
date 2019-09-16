using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialViewPractice.Models
{
    public class MoneyListViewModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public int Cost { get; set; }
    }
}