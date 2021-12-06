﻿using Boards.Common.Error;

namespace Boards.Common.Result
{
    public class ResultContainer<T>
    { 
        public T Data { get; set; } 
        public ErrorType? ErrorType { get; set; }  
    }
}