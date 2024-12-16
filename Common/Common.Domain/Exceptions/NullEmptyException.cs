using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain.Exceptions
{
    public class NullEmptyException : BaseDomainException
    {
        public NullEmptyException() { }
        public NullEmptyException(string message) : base(message) { }

        public static void CheckNotEmpty(object objectValue, string objectName)
        {
            if (objectValue == null)
            {
                throw new NullEmptyException($"{objectName} is null.");
            }

            if (objectValue.GetType() == typeof(string))
            {
                if (string.IsNullOrWhiteSpace((string)objectValue))
                {
                    throw new NullEmptyException($"{objectName} is null or empty.");
                }
            }
        }
    }
}
