﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ee.Framework
{
    public class BaseRequest
    {
        public virtual void Validate()
        {
            System.Reflection.PropertyInfo[] properties = this.GetType().GetProperties();
            foreach (var pInfo in properties)
            {
                if (pInfo.IsDefined(typeof(ValidateAttibute), true))
                {
                    var customAttributes = pInfo.GetCustomAttributes(typeof(ValidateAttibute), true) as ValidateAttibute[];
                    foreach (var attribute in customAttributes)
                    {
    
                        attribute.InputValue = pInfo.GetValue(this, null);
                        attribute.PropertyName = pInfo.Name;
                        if (!attribute.Validate())
                        {
                            throw new EeException(ErrorCodes.InvalidParameter, attribute.ErrorMessage);
                        }
                    }
                }
            }

        }
    }
    public class BasePageRequest : BaseRequest
    {
        public virtual int PageIndex { get; set; }
        public virtual int PageSize { get; set; }
    }
}
