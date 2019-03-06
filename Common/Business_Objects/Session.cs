using System;

namespace Common.Business_Objects
{
    public class Session
    {
        public int SessionID { set; get; }
        public int MovieID { set; get; }
        public DateTime SessionDate { set; get; }
        public byte CinemaNumber { set; get; }

        public String ShortFormat
        {
            get
            {
                return string.Format("{0:HH:mm}-Cinema {1}", SessionDate, CinemaNumber);
            }
        }

        public Session()
        {



        }
    }
}

