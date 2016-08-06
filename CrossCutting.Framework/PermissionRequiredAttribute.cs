﻿//===================================================================================
// This code is released under the terms of the MS-LPL license
// GABRIELGI - linkedin.com/in/gabrielgonzaleziglesias
//===================================================================================

#region

using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

#endregion

namespace Company.Client.Project.CrossCutting.Framework
{
    [CLSCompliant(false)]
    [AttributeUsage(AttributeTargets.Method)]
    public class PermissionRequiredAttribute : AuthorizeAttribute
    {
        #region Fields

        private readonly int[] _requiredPermission;

        #endregion

        #region Constructor

        public PermissionRequiredAttribute(int[] requiredPermission)
        {
            _requiredPermission = requiredPermission;
        }

        #endregion

        #region Protected Methods

        //protected override bool AuthorizeCore(HttpContextBase httpContext)
        //{
        //    if (httpContext == null)
        //        throw new ArgumentNullException("httpContext");

        //    try
        //    {
        //        var serializeUserData = ((FormsIdentity)httpContext.User.Identity).Ticket.UserData.Split('/');
        //        var permissions = serializeUserData[5].Split('|').Select(permission => Convert.ToInt32(permission));
        //        return Array.TrueForAll(_requiredPermission, permissions.Contains);
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        //{
        //    filterContext.Result = new RedirectResult(new UrlHelper(filterContext.RequestContext).Action("ErrorNoAuthorized", "Error"));
        //}

        #endregion
    }
 }