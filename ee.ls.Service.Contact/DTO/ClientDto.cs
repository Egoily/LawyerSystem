﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ee.ls.Service.Contact.DTO
{
    public class ClientDto
    {
        /// <summary>
        /// 主键
        /// </summary>
        public virtual int Id { get; set; }
        /// <summary>
        /// 是否是自然人
        /// </summary>
        public virtual bool IsNP { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// 简称
        /// </summary>
        public virtual string Abbreviation { get; set; }
        /// <summary>
        /// 属性列表
        /// </summary>
        public virtual Dictionary<int,string> Properties { get; set; }

    }
}
