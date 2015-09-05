using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trajem.Core.BL.Models.PostModels
{
   public class PostInfo
    {
        public int ID { get; set; }
        public String FileName { get; set; }
        public DateTime PostDate { get; set; }
        public DateTime DeadLine { get; set; }
        public int Statues { get; set; }
        public string DeliveryLocation { get; set; }


    }
    public enum PostStatues
    {
        WaitingTranslationRequest = 1 ,
        HasTranslationRequest = 2 ,
        WaitingForTheTranslatorToAcceptTheRequest = 3,
        RejectedByTranslator = 4,
        AcceptedByTranslator = 5,
        TranslationOnprogress = 6,
        TranslationDoen= 7,
        Delivered = 8,
        IsCanceledByTheApplicant = 51,
        IsCanceledByTheTranslator = 52,

    }
}
