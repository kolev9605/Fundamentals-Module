namespace HotelBookingSystem.Interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// An abstract class used to store data and do operations over the data.
    /// </summary>
    /// <typeparam name="T">Generic type that can be any models that implement IDbEntity</typeparam>
    public interface IRepository<T>
    {
        /// <summary>
        /// Returns a collection of all items currently in the repository
        /// </summary>
        /// <returns>Returns IEnumerable of all elements in the repository</returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Searches a items by ID and returns if present
        /// </summary>
        /// <param name="id">Unique identifier used to search for items in the repository</param>
        /// <returns>Returns the item if found or an exception of not found</returns>
        T Get(int id);

        /// <summary>
        /// Adds item to the repository
        /// </summary>
        /// <param name="item">The item to be added</param>
        void Add(T item);

        /// <summary>
        /// Updates item at given index
        /// </summary>
        /// <param name="id">Unique identifier used to search for items in the repository</param>
        /// <param name="newItem">The new item to be replaced</param>
        /// <returns>Returns true if the update pass or false if it doesn't</returns>
        bool Update(int id, T newItem);

        /// <summary>
        /// Deletes a item in the repository by given id
        /// </summary>
        /// <param name="id">Unique identifier used to search for items in the repository</param>
        /// <returns>Returns true if the delete pass or false if it doesn't</returns>
        bool Delete(int id);
    }
}