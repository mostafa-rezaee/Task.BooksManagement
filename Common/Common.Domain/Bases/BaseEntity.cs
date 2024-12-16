using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain.Bases
{
    public class BaseEntity
    {
        public Guid Id { get; private set; }

        //You can put here other properties (that, are common in entities) - پراپرتیهای مشترک بیشتر در صورت وجود اینجا تعریف میشوند
        //public Datetime CreateDate { get; private set;}
    }
}
