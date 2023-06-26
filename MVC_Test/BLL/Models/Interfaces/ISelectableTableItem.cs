using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models.Interfaces
{
    public interface ISelectableTableItem<T> where T : class
    {
        public T ItemData { get; set; }
        public bool IsSelected { get; set; }
    }
}
