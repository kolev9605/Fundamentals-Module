namespace Theatres.Interfaces
{
    using System;
    using System.Collections.Generic;
    using Core;

    /// <summary>
    /// Holds all performances and theatres sorted 
    /// </summary>
    public interface IPerformanceDatabase
    {
        /// <summary>
        /// Adds a theatre in the database. Throws Exception if dublicate theatres are beeing added.
        /// </summary>
        /// <param name="theatreName">Name of the theatre beeing added</param>
        void AddTheatre(string theatreName);

        /// <summary>
        /// Holds a list of all theatres currently in the database
        /// </summary>
        /// <returns>Returns IEnumerable collection of the current theatres in the database.</returns>
        IEnumerable<string> ListTheatres();

        /// <summary>
        /// Adds a performance in a theatre held by the database. Throws exception if the theatre does not exist. Throws exception if the performance is overlapping with an existing one
        /// </summary>
        /// <param name="theatreName">The theatre we are adding performance to</param>
        /// <param name="performanceTitle">The title of the performance</param>
        /// <param name="startDateTime">Starting date and time of the performance we are adding</param>
        /// <param name="duration">The duration of the performance</param>
        /// <param name="price">The price of the performance</param>
        void AddPerformance(string theatreName, string performanceTitle, DateTime startDateTime, TimeSpan duration, decimal price);

        /// <summary>
        /// Holds and returns all performances in all existing theatres
        /// </summary>
        /// <returns>Returns all existing performances</returns>
        IEnumerable<Performance> ListAllPerformances();

        /// <summary>
        /// Holds and returns all performances in the pointed theatre
        /// </summary>
        /// <param name="theatreName">The theatre which performances we are returning</param>
        /// <returns>>Returns all existing performances in the pointed theatre</returns>
        IEnumerable<Performance> ListOfPerformances(string theatreName);
    }
}