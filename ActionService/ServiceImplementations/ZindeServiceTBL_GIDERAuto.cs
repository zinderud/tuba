//===================================================================================
// Sio
// Sio
//===================================================================================

#region
using System;
using System.Configuration;
using System.Linq;
using System.Web.Security;
using System.Collections.Generic;
using System.ServiceModel;
using DataObjects.EntityFramework;
using AutoBusinessObjects;
using DataObjects;

 
 using ZindeService.ServiceContracts;
using System.Collections;
#endregion

namespace  ZindeService.ServiceImplementations
{
 	public partial class ZindeService : IZindeService
   {

    public static readonly ITBL_GIDER _tbl_gıder = DataAccess.tbl_gıder;


		/// <summary>
        /// TBL_GIDER ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_GIDER(TBL_GIDERDTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_gıder.Ekle__TBL_GIDER(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_GIDER sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_GIDER(TBL_GIDERDTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_gıder.Sil__TBL_GIDER(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_GIDER degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_GIDER(TBL_GIDERDTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_gıder.Degistir__TBL_GIDER(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_GIDER listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_GIDERDTO> Listele__TBL_GIDER()
        {
            try
            {
                return _tbl_gıder.Listele__TBL_GIDER();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_GIDER Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_GIDERDTO  Bul_TBL_GIDER(int ID)
        { 
                 try
                {
                    return _tbl_gıder.Bul_TBL_GIDER(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
