using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class OrderDTO
    {
        public int OrderId { get; set; }
        public string OrderDate { get; set; }
        public int OrderSum { get; set; }
        public string UserName { get; set; }

        public string[] ProductName { get; set; }
        public int Quentity { get; set; }
       
    }




}

