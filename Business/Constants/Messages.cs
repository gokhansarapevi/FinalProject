using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product is added";
        public static string ProductNameInvalid = "Product name is invalid.";
        public static string MaintenanceTime = "System is under maintenance.";
        public static string ProductsListed = "Products are listed.";
        public static string ProductCountOfCategoryError = "Product count of a category cannot exceed 10.";
        public static string ProductNameAlreadyExists = "Product name already exists.";
        public static string CategoryLimitExceeded = "Category limit of 15 is reached.";
        public static string AuthorizationDenied = "Auth denied.";
        public static string UserRegistered="User is registered.";
        public static string UserNotFound="User not found.";
        public static string PasswordError="Password is incorret.";
        public static string SuccessfulLogin="Login succesful.";
        public static string UserAlreadyExists="User already exists.";
        public static string AccessTokenCreated="Access token is created.";
    }
}
