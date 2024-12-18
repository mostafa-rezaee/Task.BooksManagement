using Common.API._Helper;
using Common.Application;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Common.API.Bases
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        protected ApiResult CommandResult(OperationResult result)
        {
            return new ApiResult
            {
                IsSuccess = result.Status == OperationResultStatus.Success,
                MetaData = new MetaData
                {
                    Message = result.Message,
                    StatusCode = result.Status.MapStatus()
                }
            };
        }
        //For Commands
        protected ApiResult<TData?> CommandResult<TData>(OperationResult<TData> result, HttpStatusCode status = HttpStatusCode.OK, string headerUrl = null)
        {
            bool isSuccess = result.Status == OperationResultStatus.Success;
            if (isSuccess)
            {
                HttpContext.Response.StatusCode = (int)status;
                if (string.IsNullOrWhiteSpace(headerUrl))
                {
                    HttpContext.Response.Headers.Add("location", headerUrl);
                }
            }
            return new ApiResult<TData?>()
            {
                IsSuccess = isSuccess,
                Data = isSuccess ? result.Data : default,
                MetaData = new MetaData
                {
                    Message = result.Message,
                    StatusCode = result.Status.MapStatus()
                }
            };

        }

        //For Queries
        protected ApiResult<TData> QueryResult<TData>(TData result)
        {
            if (result == null)
                return new ApiResult<TData>
                {
                    IsSuccess = false,
                    Data = result,
                    MetaData = new MetaData
                    {
                        Message = "موردی یافت نشد",
                        StatusCode = ResponseStatusCode.NotFound
                    }
                };
            return new ApiResult<TData>()
            {
                IsSuccess = true,
                Data = result,
                MetaData = new MetaData
                {
                    Message = "عملیات با موفقیت انجام شد",
                    StatusCode = ResponseStatusCode.Success
                }
            };
        }
    }
}
