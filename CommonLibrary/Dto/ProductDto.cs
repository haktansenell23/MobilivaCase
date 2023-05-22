using CommonLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public CategoryEnum CategoryEnum { get; set; }

        public int  Unit { get; set; }

        public int UnitPrice { get; set; }
    }
}
