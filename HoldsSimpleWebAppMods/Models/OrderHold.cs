using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoldsSimpleWebApp.Models
{
    public class OrderHold
    {
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public int OrderID { get; set; }
        public int OrderHoldID { get; set; }
        public string OrderHoldCode { get; set; }
        public string OrderHoldDesc { get; set; }
    }
}
