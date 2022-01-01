using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Domain.Frameworks.Abstract
{
   public interface IEntity<P_PrimaryKey>
    {
        P_PrimaryKey Id { get; set; }
    }
}
