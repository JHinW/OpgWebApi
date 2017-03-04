using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpgWebApi.Src.Entitys.Storage
{
    public class AppServerErrEntity: TableEntity
    {

        public AppServerErrEntity(string lastName, string firstName)
        {
            this.PartitionKey = lastName;
            this.RowKey = firstName;
        }

        public AppServerErrEntity()
        {
        }
        public string ExceptionSource { get; set; }

        public string RequestInfo { get; set; }

        public string StackInfo { get; set; }

        public string Message { get; set; }
    }
}
