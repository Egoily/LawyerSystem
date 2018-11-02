using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ee.Framework
{
    public class ErrorCodes
    {
        private const int BaseErrorCode = 1000;
        public const int UnknownError = -1;
        public const int Ok = 0;
        public const int NullParameter = BaseErrorCode + 1;
        public const int InvalidParameter = BaseErrorCode + 2;
        public const int OperationFailed = BaseErrorCode + 3;
        public const int NotFound = BaseErrorCode + 4;
        public const int Existed = BaseErrorCode + 5;
    }
}
