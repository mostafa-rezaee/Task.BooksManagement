using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.API._Helper
{
    public class ApiResult
    {
        public bool IsSuccess { get; set; }
        public MetaData MetaData { get; set; }
    }

    public class ApiResult<TData>
    {
        public bool IsSuccess { get; set; }
        public TData? Data { get; set; }
        public MetaData MetaData { get; set; }
    }
}
