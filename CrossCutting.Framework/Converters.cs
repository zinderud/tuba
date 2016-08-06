//===================================================================================
// This code is released under the terms of the MS-LPL license
// GABRIELGI - linkedin.com/in/gabrielgonzaleziglesias
//===================================================================================

#region

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

#endregion

namespace Company.Client.Project.CrossCutting.Framework
{
    public class Converters
    {
        #region Public Methods

        public static List<T> ConvertStringToEnum<T>(string stringArray)
        {
            var permissions= stringArray.Split('|').Select(permission => Convert.ToInt32(permission));
            return (List<T>)permissions.Select(r => (T)Enum.Parse(typeof(T), r.ToString(CultureInfo.InvariantCulture)));
        }

        #endregion
    }
}
