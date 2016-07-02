namespace BangaloreUniversityLearningSystem.Infrastructure
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection;
    using System.Security.Authentication;
    using Interfaces;
    using Models;
    using Utilities;

    public abstract class Controller
    {
        protected IBangaloreUniversityData Data { get; set; }

        public User CurrentUser { get; set; }

        public bool HasLoggedUser
        {
            get
            {
                return this.CurrentUser != null;
            }
        }

        protected IView View(object model)
        {
            string fullNamespace = this.GetType().Namespace;
            int firstSeparatorIndex = fullNamespace.IndexOf(".");
            string baseNamespace = fullNamespace.Substring(0, firstSeparatorIndex);
            string controllerName = this.GetType().Name.Replace("Controller", "");
            string actionName = new StackTrace().GetFrame(1).GetMethod().Name;
            string fullPath = baseNamespace + ".Views." + controllerName + "." + actionName;
            var viewType = Assembly
                .GetExecutingAssembly()
                .GetType(fullPath);
            return Activator.CreateInstance(viewType, model) as IView;
        }

        protected void EnsureAuthorization(params Role[] roles)
        {
            if (!this.HasLoggedUser)
            {
                throw new ArgumentException("There is no currently logged in user.");
            }
            //PERFORMANCE: Possible bottleneck, unnecessary foreach loop
            //foreach (var user in this.Data.users.GetAll())
            //{
            if (!roles.Any(role => this.CurrentUser.IsInRole(role)))
            {
                throw new AuthenticationException("The current user is not authorized to perform this operation.");
            }
            //}
        }
    }
}