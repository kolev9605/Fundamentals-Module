﻿namespace HotelBookingSystem.Controllers
{
    using System;
    using Infrastructure;
    using Interfaces;
    using Models;
    using Utilities;

    public class UsersController : Controller
    {
        public UsersController(IHotelBookingSystemData data, User user)
            : base(data, user)
        {
        }

        public IView Register(string username, string password, string confirmPassword, string role)
        {
            if (password != confirmPassword)
            {
                throw new ArgumentException("The provided passwords do not match.");
            }

            this.EnsureNoLoggedInUser();
            this.CheckForDuplicateUsers(username);

            Roles userRole = (Roles)Enum.Parse(typeof(Roles), role, true);
            var user = new User(username, password, userRole);
            this.Data.UsersRepository.Add(user);

            return this.View(user);
        }

        public IView Login(string username, string password)
        {
            this.EnsureNoLoggedInUser();

            var existingUser = this.Data.UsersRepository.GetByUsername(username);
            if (existingUser == null)
            {
                throw new ArgumentException(string.Format("A user with username {0} does not exist.", username));
            }

            if (existingUser.PasswordHash != HashUtilities.GetSha256Hash(password))
            {
                throw new ArgumentException("The provided password is wrong.");
            }

            this.CurrentUser = existingUser;
            return this.View(existingUser);
        }

        public IView MyProfile()
        {
            this.Authorize(Roles.User, Roles.VenueAdmin);

            return this.View(this.CurrentUser);
        }

        public IView Logout()
        {
            this.Authorize(Roles.User, Roles.VenueAdmin);
            var user = this.CurrentUser;
            this.CurrentUser = null;

            return this.View(user);
        }

        private void CheckForDuplicateUsers(string username)
        {
            var existingUser = this.Data.UsersRepository.GetByUsername(username);
            if (existingUser != null)
            {
                throw new ArgumentException(string.Format("A user with username {0} already exists.", username));
            }
        }

        private void EnsureNoLoggedInUser()
        {
            foreach (var user in this.Data.UsersRepository.GetAll())
            {
                if (this.CurrentUser != null && this.CurrentUser.Username == user.Username)
                {
                    throw new ArgumentException("There is already a logged in user.");
                }
            }
        }
    }
}
