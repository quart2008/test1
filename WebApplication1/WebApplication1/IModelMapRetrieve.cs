using System;
using System.Collections.Generic;

namespace WebApplication1
{
    public interface IModelMapRetrieve
	{
		IList<Book> BookRetrieve(string jsonType, Int32 numbers);
	}
}
