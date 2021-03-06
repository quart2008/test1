using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1
{
    //[Route("api/[controller]/[action]")]
    [Route("modelmap/[action]")]
    public class ValuesController : ControllerBase
    {
    	private IModelMapRetrieve _service;
    	
    	public ValuesController(IModelMapRetrieve service)
        {
            _service = service;
        }
    	
    	// GET: api/bookretrieve
        [HttpGet]
        public IList<Book> Bookretrieve(string jsontype,Int32 numbers)
        {
            return _service.BookRetrieve(jsontype, numbers);
        }
        [HttpGet]
        public IEnumerable<string> GetAll()
        {
            return new string[] { "value1", "value2" };
        }

        
    }
}
