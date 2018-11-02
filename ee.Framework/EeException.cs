using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ee.Framework
{
    public class EeException : Exception
    {
        public int ErrorCode { get; protected set; }

        public EeException(int errorCode, string message)
            : base(message)
        {
            ErrorCode = errorCode;
        }
    }
}
