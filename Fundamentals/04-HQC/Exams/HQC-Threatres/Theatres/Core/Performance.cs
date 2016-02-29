namespace Theatres.Core
{
    using System;

    public class Performance : IComparable<Performance>
    {
        public Performance(string theatreName, 
            string performanceTitle, 
            DateTime startDateTime, 
            TimeSpan duration, 
            decimal price)
        {
            this.TheatreName = theatreName;
            this.PerformanceTitle = performanceTitle;
            this.StartDateTime = startDateTime;
            this.Duration = duration;
            this.Price = price;
        }

        public string TheatreName { get; private set; }

        public string PerformanceTitle { get; private set; }

        public DateTime StartDateTime { get; set; }

        public TimeSpan Duration { get; private set; }
        
        protected internal decimal Price { get; private set; }

        int IComparable<Performance>.CompareTo(Performance otherPerformance)
        {
            int result = this.StartDateTime.CompareTo(otherPerformance.StartDateTime);

            return result;
        }

        //public override string ToString()
        //{
        //    string result = string.Format(
        //        "BuoiDien(Tr32: {0}; Tr23: {1}; s2: {2}, ThoiGian: {3}, Gia: {4})",
        //        this.TheatreName,
        //        this.PerformanceTitle,
        //        this.StartDateTime.ToString("dd.MM.yyyy HH:mm"),
        //        this.Duration.ToString("hh':'mm"),
        //        this.Price.ToString("f2"));
        //    return result;
        //}
    }
}