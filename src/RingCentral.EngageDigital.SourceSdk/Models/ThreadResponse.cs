using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RingCentral.EngageDigital.SourceSdk.Models
{
    class ThreadResponse : ResponseBase
    {

        /// <summary>
        /// Example: `1.2.3.4`
        /// </summary>
        public string ip { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        public string title { get; set; }
    }
}
