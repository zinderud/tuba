﻿//===================================================================================
// Microsoft Developer & Platform Evangelism
//=================================================================================== 
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
//===================================================================================
// Copyright (c) Microsoft Corporation.  All Rights Reserved.
// This code is released under the terms of the MS-LPL license, 
// http://microsoftnlayerapp.codeplex.com/license
//===================================================================================

namespace Company.Client.Project.CrossCutting.Framework.Validator
{
    /// <summary>
    ///   Entity Validator Factory
    /// </summary>
    public static class EntityValidatorFactory
    {
        #region Fields

        private static IEntityValidatorFactory _factory;

        #endregion

        #region Public Methods

        /// <summary>
        ///   Set the  log factory to use
        /// </summary>
        /// <param name="factory"> Log factory to use </param>
        public static void SetCurrent(IEntityValidatorFactory factory)
        {
            _factory = factory;
        }

        /// <summary>
        ///   Createt a new <paramref name="Company.Client.Project.CrossCutting.Logging.ILog" />
        /// </summary>
        /// <returns> Created ILog </returns>
        public static IEntityValidator CreateValidator()
        {
            return (_factory != null) ? _factory.Create() : null;
        }

        #endregion
    }
}