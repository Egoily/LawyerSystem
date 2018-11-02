using System.Collections.Generic;
using System.Linq;
using NHibernate;

using ee.ls.Models.Entities;
using ee.Repository;
using ee.ls.Repository.Factory.Sqlite;
using ee.ls.Service.ContactInterfaces;
using ee.ls.Service.Contact;
using ee.ls.Service.Contact.Args;
using System;
using log4net;
using ee.Framework;

namespace ee.ls.Service
{
    public class ServiceProcessor
    {
        private static readonly ILog Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static TR ProcessRequest<T, TR>(T request, Action inbound, Func<T, TR> fun)
            where T : BaseRequest
            where TR : BaseResponse, new()
        {
            try
            {
                if (request == null)
                {
                    throw new EeException(ErrorCodes.NullParameter, "Parameter is null.");
                }
                request.Validate();
                inbound?.Invoke();
                using (var session = SessionManager.GetConnection())
                {
                    return fun(request);
                }

            }
            catch (EeException ex)
            {
                Logger.Error($"[{ex.ErrorCode}]:{ex.Message}");
                return new TR()
                {
                    Code = ex.ErrorCode,
                    Message = ex.Message,
                };
            }
            catch (Exception ex)
            {
                Logger.Error($"[{ErrorCodes.UnknownError}]:{ex.Message + " " + ex.InnerException?.Message}");
                return new TR()
                {
                    Code = ErrorCodes.UnknownError,
                    Message = ex.Message + " " + ex.InnerException?.Message,
                };
            }
        }
    }
}
