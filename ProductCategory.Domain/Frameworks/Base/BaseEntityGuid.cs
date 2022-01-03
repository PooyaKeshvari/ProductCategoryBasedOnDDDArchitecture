using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Domain.Frameworks.Base
{
    public class BaseEntityGuid : Abstract.IEntity<Guid?>
    {
        public Guid? Id { get ; set ; }
    }
}
