using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace youtube_video.Models
{
    [DataContract]
    public class BasicResponse<T>
    {
        [DataMember]
        public T Data { get; set; }
        [DataMember]
        public string Error { get; set; }


    }
}