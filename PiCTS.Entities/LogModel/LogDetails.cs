﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PiCTS.Entities.LogModel
{
    public class LogDetails
    {
        public Object? ModelName { get; set; }
        public Object? Controller { get; set; }
        public Object? Action { get; set; }
        public Object? Id { get; set; }
        public Object? CreatedAt { get; set; }

        public LogDetails()
        {
            CreatedAt = DateTime.Now;
        }

        public override string ToString() => JsonSerializer.Serialize(this);
    }
}
