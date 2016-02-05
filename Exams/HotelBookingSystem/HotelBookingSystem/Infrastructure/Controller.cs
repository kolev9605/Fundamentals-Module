namespace HotelBookingSystem.Infrastructure
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection;
    using Identity;
    using Interfaces;
    using Models;
    using Utilities;
    using Views.Shared;

    /// <summary>
    /// An apstract class that is used to be inherited by the specific controllers. A controller itself executes commands over the database and always returns a view. 
    /// </summary>
    public abstract class Controller
    {
        /// <summary>
        /// Initialize the specific controller.
        /// </summary>
        /// <param name="data">The database which will be used by the specific controller.</param>
        /// <param name="user">The user who is sending the request</param>
        protected Controller(IHotelBookingSystemData data, User user)
        {
            this.Data = data;
            this.CurrentUser = user;
        }

        /// <summary>
        /// Holds the current user.
        /// </summary>
        public User CurrentUser { get; set; }

        /// <summary>
        /// Returns wether the current user is valid
        /// </summary>
        public bool HasCurrentUser
        {
            get { return this.CurrentUser != null; }
        }

        /// <summary>
        /// Holds the database used by the controller.
        /// </summary>
        protected IHotelBookingSystemData Data { get; private set; }

        /// <summary>
        /// The method which returns a view after the controller finishes its operations.
        /// </summary>
        /// <param name="model">Determines which view should be returned.</param>
        /// <returns>Returns a view based on the controller and wether the operation was valid or not.</returns>
        protected IView View(object model)
        {
            string fullNamespace = this.GetType().Namespace;
            int firstSeparatorIndex = fullNamespace.IndexOf(Constants.NamespaceSeparator);
            string baseNamespace = fullNamespace.Substring(0, firstSeparatorIndex);
            string controllerName = this.GetType().Name.Replace(Constants.ControllerSuffix, string.Empty);
            string actionName = new StackTrace().GetFrame(1).GetMethod().Name;
            string fullPath = string.Join(
                Constants.NamespaceSeparator,
                new[] { baseNamespace, Constants.ViewsFolder, controllerName, actionName });
            var viewType = Assembly
                .GetExecutingAssembly()
                .GetType(fullPath);
            return Activator.CreateInstance(viewType, model) as IView;
        }

        /// <summary>
        /// A specific view which returns an Error object which indicates of invalid view.
        /// </summary>
        /// <param name="message">Message to signal the user for the invalid operation</param>
        /// <returns></returns>
        protected IView NotFound(string message)
        {
            return new Error(message);
        }

        /// <summary>
        /// Verifies wether the required role matches with the allowed ones.
        /// </summary>
        /// <param name="roles">Parameters array of the roles to be authorized.</param>
        protected void Authorize(params Roles[] roles)
        {
            if (!this.HasCurrentUser)
            {
                throw new ArgumentException("There is no currently logged in user.");
            }

            if (!roles.Any(role => this.CurrentUser.Role == role))
            {
                throw new AuthorizationFailedException("The currently logged in user doesn't have sufficient rights to perform this operation.", this.CurrentUser);
            }
        }
    }
}
