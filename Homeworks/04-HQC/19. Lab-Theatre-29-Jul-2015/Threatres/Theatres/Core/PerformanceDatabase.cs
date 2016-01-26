namespace Theatres.Core
{
    using System;
    using System.Collections.Generic;
    using Exceptions;
    using Interfaces;

    public class PerformanceDatabase : IPerformanceDatabase
    {
        private readonly SortedDictionary<string, SortedSet<Performance>> 
            performanceDatabase = new SortedDictionary<string, SortedSet<Performance>>();

        public void AddTheatre(string theatreName)
        {
            if (this.performanceDatabase.ContainsKey(theatreName))
            {
                throw new DuplicateTheatreException("Duplicate theatre");
            }

            this.performanceDatabase[theatreName] = new SortedSet<Performance>();
        }

        public IEnumerable<string> ListTheatres()
        {
            var theatres = this.performanceDatabase.Keys;
            return theatres;
        }

        void IPerformanceDatabase.AddPerformance(string theatreName,
            string performanceTitle, 
            DateTime startDateTime, 
            TimeSpan duration, 
            decimal price)
        {
            if (!this.performanceDatabase.ContainsKey(theatreName))
            {
                throw new TheatreNotFoundException("Theatre does not exist");
            }

            var performances = this.performanceDatabase[theatreName];
            var endDateTime = startDateTime + duration;

            if (IsOverlapping(performances, startDateTime, endDateTime))
            {
                throw new TimeDurationOverlapException("Time/duration overlap");
            }

            var p = new Performance(theatreName, performanceTitle, startDateTime, duration, price);
            performances.Add(p);
        }

        public IEnumerable<Performance> ListAllPerformances()
        {
            var theatres = this.performanceDatabase.Keys;
            var result2 = new List<Performance>();

            foreach (var t in theatres)
            {
                var performances = this.performanceDatabase[t];
                result2.AddRange(performances);
            }

            return result2;
        }

        IEnumerable<Performance> IPerformanceDatabase.ListOfPerformances(string theatreName)
        {
            if (!this.performanceDatabase.ContainsKey(theatreName))
            {
                throw new TheatreNotFoundException("Theatre does not exist");
            }

            var theatre = this.performanceDatabase[theatreName];
            return theatre;
        }

        protected internal static bool IsOverlapping(
            IEnumerable<Performance> performances, 
            DateTime otherStartDateTime, 
            DateTime otherEndDateTime)
        {
            foreach (var performance in performances)
            {
                var currentStartDateTime = performance.StartDateTime;

                var currentEndDateTime = performance.StartDateTime + performance.Duration;

                var isOverLapping =
                    (currentStartDateTime <= otherStartDateTime && otherStartDateTime <= currentEndDateTime) ||
                    (currentStartDateTime <= otherEndDateTime && otherEndDateTime <= currentEndDateTime) ||
                    (otherStartDateTime <= currentStartDateTime && currentStartDateTime <= otherEndDateTime) ||
                    (otherStartDateTime <= currentEndDateTime && currentEndDateTime <= otherEndDateTime);

                if (isOverLapping)
                {
                    return true;
                }
            }

            return false;
        }
    }
}