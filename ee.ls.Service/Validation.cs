using ee.ls.Service.Contact;
using ee.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ee.ls.Service
{
    public class Validator
    {
        public static void Required(string value, string propertyName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new EeException(ErrorCodes.InvalidParameter, $"{propertyName} is required.");
            }
        }
    }
}
