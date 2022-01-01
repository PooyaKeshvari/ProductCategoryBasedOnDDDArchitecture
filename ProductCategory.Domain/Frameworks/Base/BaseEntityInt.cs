using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Domain.Frameworks.Base
{
    public class BaseEntityInt : Abstract.IEntity<int>
    {
        public int Id { get; set; }
    }
}
