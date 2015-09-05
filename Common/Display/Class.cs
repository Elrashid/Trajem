

using System;
namespace Common.Display
{

    public enum Statues
        {
            Hide ,
            Show ,
        }

    public enum Element 
        {
            None = 1,
            Hidden,
            Text,
            TextRTL,
            Area,
            AreaRTL,
            Email,
            Tel,
            DropDown,
            DropDownAutoBind,
            Cascade,
            Date,
            Time,
            DateTime,
            Numeric,
            DropDownWithFilter,
            DropDownWithFilterAutoBind,
            NameAr,
            NameEn,
            MultiSelect,
            Integer,
            Decimal,
        }
         //Statues     Group  Type info1
         //Show-Hide   1-2-3   Tel Phone
        [AttributeUsage(AttributeTargets.Property , Inherited = false, AllowMultiple = false)]
        public class T4Attribute : System.Attribute
        {
            public T4Attribute(int group, Statues statues, Element element, string info)
            {
  
             }
        }

        [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
        public class T4GroupCountAttribute : System.Attribute
        {
            public T4GroupCountAttribute(int groupCount)
            {

            }
        }
    
}

