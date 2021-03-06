﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ee.ls.Models.Entities
{
    /// <summary>
    /// 属性项类别
    /// </summary>
    public class PropertyItemCategory
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual PropertyItemCategory Parent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual IList<PropertyItemCategory> Children { get; set; }
    }
}
