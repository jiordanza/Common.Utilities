using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyGuru.FastKey.Utilities
{
    public class ResultType<T>
    {
        public ResultType()
        {
            this.Messages = new List<string>();//Existing calls to Add() will fail if not initialized
        }
        public ResultType(bool status)
        {
            this.Status = status;
            this.Messages = new List<string>();//Existing calls to Add() will fail if not initialized
        }
        public ResultType(bool status, string message)
        {
            this.Status = status;
            if (this.Messages == null)
            {
                this.Messages = new List<string>();
            }
            this.Messages.Add(message);
        }

        public ResultType(bool status, List<string> messages)
        {
            this.Status = status;
            this.Messages = messages;
        }

        public T Value { get; set; }
        public bool Status { get; set; }
        public string Code { get; set; }
        //public int StatusCode { get; set; }

        public List<string> Messages { get; }

    

    }
}
