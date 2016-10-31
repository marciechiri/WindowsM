using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.model
{
    class Note
    {
        public String Title { get; set; }
        public String Content { get; set; }
        public String Category { get; set; }
        public Double Latitude { get; set; }
        public Double Longitude { get; set; }
        public String User { get { return "91793-61623-91675"; } }
    }
}
