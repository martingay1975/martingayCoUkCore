
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DiaryEntryUI.Models.Data
{
    [DataContract]
    public class SiteOptions
    {
        public SiteOptions()
        {
            this.DateLastUpdated = DateTime.Now.ToString("D");
        }

        [DataMember(Name = "dateLastUpdated")]
        public string DateLastUpdated { get; set; }

        [DataMember(Name = "hashes")]
        public Dictionary<string, int> Hashes { get; set; }

    }
}