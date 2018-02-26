using Dealership.Common;
using Dealership.Common.Enums;
using Dealership.Contracts;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Dealership.Models
{
    public class User : IUser
    {
        private string firstName;
        private string lastName;
        private string password;
        private string username;

        public User(string username, string firstName, string lastName, string password, Role role = Role.Normal)
        {
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.Role = role;
            this.Vehicles = new List<IVehicle>();
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                Validator.ValidateNull(value, "First name must not be null");
                Validator.ValidateIntRange(value.Length, Constants.MinNameLength, Constants.MaxNameLength, string.Format(Constants.StringMustBeBetweenMinAndMax, nameof(this.FirstName), Constants.MinNameLength, Constants.MaxNameLength));
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                Validator.ValidateNull(value, "Last name must not be null");
                Validator.ValidateIntRange(value.Length, Constants.MinNameLength, Constants.MaxNameLength, string.Format(Constants.StringMustBeBetweenMinAndMax, nameof(this.LastName), Constants.MinNameLength, Constants.MaxNameLength));
                this.lastName = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            private set
            {
                Validator.ValidateNull(value, "Passwor must not be null");
                Validator.ValidateIntRange(value.Length, Constants.MinPasswordLength, Constants.MaxPasswordLength, string.Format(Constants.StringMustBeBetweenMinAndMax, nameof(this.Password), Constants.MinPasswordLength, Constants.MaxPasswordLength));
                Validator.ValidateSymbols(value, Constants.PasswordPattern, string.Format(Constants.InvalidSymbols, nameof(this.Password)));
                this.password = value;
            }
        }

        public Role Role
        {
            get;
            private set;
        }

        public string Username
        {
            get
            {
                return this.username;
            }
            private set
            {
                Validator.ValidateNull(value, Constants.UserCannotBeNull);
                Validator.ValidateSymbols(value, Constants.UsernamePattern, string.Format(Constants.InvalidSymbols, nameof(this.Username)));
                this.username = value;
            }
        }

        public IList<IVehicle> Vehicles
        {
            get;
            private set;
        }

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
            vehicleToAddComment.Comments.Add(commentToAdd);
        }

        public void AddVehicle(IVehicle vehicle)
        {
            bool isAdmin = this.Role == Role.Admin;
            bool canAddMoreVehicles = this.Role == Role.VIP || this.Vehicles.Count < 5;

            if (isAdmin || !canAddMoreVehicles)
            {
                return;
            }

            //if (this.Role==Role.Admin)
            //{
            //    return;
            //}
            //
            //if (this.Role != Role.VIP && this.Vehicles.Count == 5)
            //{
            //    return;
            //}

            this.Vehicles.Add(vehicle);
        }

        public string PrintVehicles()
        {
            int counter = 1;
            return string.Format(@"--USER {0}--
{1}", this.Username, this.Vehicles.Count > 0 ? string.Join("\n", this.Vehicles.Select(v => $"{counter++}.{v}")) : "--NO VEHICLES--");
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            if (commentToRemove.Author == this.Username && vehicleToRemoveComment.Comments.Contains(commentToRemove))
            {
                vehicleToRemoveComment.Comments.Remove(commentToRemove);
            }
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            if (this.Vehicles.Contains(vehicle))
            {
                this.Vehicles.Remove(vehicle);
            }
        }
    }
}
