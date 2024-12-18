using Common.Application;

namespace Common.API._Helper
{
    public static class EnumHelper
    {
        public static ResponseStatusCode MapStatus(this OperationResultStatus status)
        {
            switch (status)
            {
                case OperationResultStatus.Success:
                    return ResponseStatusCode.Success;

                case OperationResultStatus.NotFound:
                    return ResponseStatusCode.NotFound;

                case OperationResultStatus.Error:
                    return ResponseStatusCode.LogicError;
            }
            return ResponseStatusCode.LogicError;
        }
    }
}
