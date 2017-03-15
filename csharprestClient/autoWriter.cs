using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharprestClient
{
    class autoWriter
    {
        private RestClient rClient { get; set; }
        private string filePath { get; set; } 
        private int interval { get; set; }

        public autoWriter(RestClient r, string f, int i)
        {
            rClient = r;
            filePath = f;
            interval = i;
        }

        public async void updateFilePeriodically()
        {
            
        }
    }
}
