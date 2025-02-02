﻿using DataAccess;
using DataAccess.Utills;
using Newtonsoft.Json;
using Services.Server.Utills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagesListener.Utills
{
    public class Config: IConfig
    {
        public string APIUrl { get; set; }
        public List<int> QueuePorts { get; set; }
        public string HostName { get; set; }
        public string Queue { get; set; }
        public string ServiceSessionsCollectionName { get; set; }
        public string UserCredentialsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }

        [JsonProperty("quartz.scheduler.instanceName")]
        public string InstanceName { get; set; }
        [JsonProperty("quartz.scheduler.instanceId")]
        public string InstanceId { get; set; }
        [JsonProperty("quartz.jobStore.type")]
        public string JobType { get; set; }
        [JsonProperty("quartz.jobStore.dataSource")]
        public string DataSource { get; set; }
        [JsonProperty("quartz.jobStore.tablePrefix")]
        public string TablePrefix { get; set; }
        [JsonProperty("quartz.dataSource.default.connectionString")]
        public string ProviderConnectionString { get; set; }
        [JsonProperty("quartz.dataSource.default.provider")]
        public string Provider { get; set; }
        [JsonProperty("quartz.serializer.type")]
        public string Type { get; set; }
    }
}
