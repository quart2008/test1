using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Appeon.PowerBuilder;
using Appeon.CoreService.Data;

namespace WebApplication1
{
    public class ModelMapRetrieve :IModelMapRetrieve
	{
		protected QaDataContext _context;
		
		public ModelMapRetrieve(QaDataContext context, IConfiguration configuration)
        {
        	_context = context;
        }
        /// <summary>
        /// 大数据调用 book
        /// </summary>
        /// <param name="jsonType">简单：0，标准：1</param>
        /// <param name="numbers">返回数据量</param>
        /// <returns>string</returns>
        public IList<Book> BookRetrieve(string jsonType, Int32 numbers)
        {
            var mp = new ModelMapper(_context);
            var num = numbers;
            if(jsonType=="1")
            {
                num = 0;
            }

            var ms = mp.Load<Book>(num);
            return ms.ToList();
        }
	}
}
