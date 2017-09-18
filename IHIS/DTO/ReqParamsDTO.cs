using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHIS.DTO
{
    public class ReqDataDTO<T> where T: class
    {
        public string Status { set; get; }

        public T Params { set; get; }
    }
}
