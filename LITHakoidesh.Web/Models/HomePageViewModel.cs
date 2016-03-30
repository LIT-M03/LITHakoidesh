using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LITHakoidesh.Data;

namespace LITHakoidesh.Web.Models
{
    public class HomePageViewModel
    {
        public IEnumerable<GetFiveMostFrequentIPsResult> FiveMostFrequentIPs { get; set; }
        public int TodayCount { get; set; }
        public string MostPopularIP { get; set; }
    }
}