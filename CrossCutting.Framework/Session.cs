//===================================================================================
// This code is released under the terms of the MS-LPL license
// GABRIELGI - linkedin.com/in/gabrielgonzaleziglesias
//===================================================================================

#region

using System.Runtime.Serialization;

#endregion

namespace Company.Client.Project.CrossCutting.Framework
{
    [DataContract]
    public class Session
    {
        #region Properties

        //[Display(ResourceType = typeof(ApplicationResources), Name = "User")]
        //[Required(ErrorMessageResourceType = typeof(ApplicationResources), ErrorMessageResourceName = "ValidationFieldRequired")]
        //[StringLength(11, ErrorMessageResourceType = typeof(ApplicationResources), ErrorMessageResourceName = "ValidationFieldMaxLenght")]
        [DataMember]
        public string User { get; set; }

        //[Display(ResourceType = typeof(ApplicationResources), Name = "Password")]
        //[Required(ErrorMessageResourceType = typeof(ApplicationResources), ErrorMessageResourceName = "ValidationFieldRequired")]
        //[StringLength(10, ErrorMessageResourceType = typeof(ApplicationResources), ErrorMessageResourceName = "ValidationFieldMaxLenght")]
        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string ConnectionString { get; set; }

        [DataMember]
        public string IdCache { get; set; }

        [DataMember]
        public int[] Permissions { get; set; }

        #endregion
    }
}
