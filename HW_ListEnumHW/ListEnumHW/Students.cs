using System;
using System.Collections.Generic;
using System.Text;

namespace ListEnumHW
{
    abstract class Students
    {
        private string _LastName;

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

    }

    enum ClassSize
    {
        Large,
        VeryLarge,
        ExtremelyLarge
    }

    enum Colors
    {
        red,
        blue,
        green
    }

    class GradeSchool : Students
    {
        public ClassSize Size { get; set;}

        public Colors FavoriteColor { get; set; }

        public GradeSchool(Enum pColor, string pLastName)
        {
            FavoriteColor = (Colors)pColor;
            LastName = pLastName;
            Size = ClassSize.Large;
        }
    }

    class HighSchool : Students
    {
        public ClassSize Size { get; set; }
        public Colors FavoriteColor { get; set; }

        public HighSchool(Enum pColor, string pLastName)
        {
            FavoriteColor = (Colors)pColor;
            LastName = pLastName;
            Size = ClassSize.VeryLarge;
        }
    }

    class College : Students
    {
        public ClassSize Size { get; set; }
        public Colors FavoriteColor { get; set; }

        public College(Enum pColor, string pLastName)
        {
            FavoriteColor = (Colors)pColor;
            LastName = pLastName;
            Size = ClassSize.ExtremelyLarge;
        }
    }
}