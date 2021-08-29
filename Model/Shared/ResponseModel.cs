using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;

namespace Model.Shared
{
    public class ResponseModel<T>
    {
        public bool Response { get; set; }
        public T data { get; set; }
        public string Message { get; set; }        
    }
}
