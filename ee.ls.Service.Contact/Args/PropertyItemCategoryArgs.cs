using ee.ls.Models.Entities;
using ee.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ee.ls.Service.Contact.Args
{

    public class GetPropertyCategoryRequest : BasePageRequest
    {
    }
    public class GetPropertyItemCategoryRequest : BasePageRequest
    {
        public virtual string Code { get; set; }
    }

}
