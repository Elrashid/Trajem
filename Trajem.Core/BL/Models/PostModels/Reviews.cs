using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trajem.Core.BL.Models.PostModels
{
    class Reviews
    {
        public int ID { get; set; }
        public int TranslatorID { get; set; }
        public int TranslatorName { get; set; }
        public int TranslatorMobile { get; set; }
        public int TotalActive { get; set; }
        public int Total { get; set; }
        public int OnTime { get; set; }
        public int LastjobOnTime { get; set; }
        public List<string> UsersReview { get; set; }



    }
}
