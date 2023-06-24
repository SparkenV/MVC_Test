using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models.Interfaces
{
    public interface ISelectableTableItem
    {
        public int NumberInTable { get; set; }
        public bool Selected { get; set; }
    }
}
