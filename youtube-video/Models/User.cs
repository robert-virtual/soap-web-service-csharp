using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace youtube_video.Models
{
    [DataContract]
    public class User 
    {

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Age { get; set; }


    }
}