 using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;
using AutoBusinessObjects;
using DataObjects.EntityFramework;
using System.Data.Objects.DataClasses;

namespace DataObjects.ModelMapper
{ 
    /// <summary>
    /// Assembler for <see cref="TBL_KASA_BAKIYE "/> and <see cref="TBL_KASA_BAKIYEDTO"/>.
    /// </summary>
	public  static partial class  TBL_KASA_BAKIYEMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_KASA_BAKIYEDTO"/> converted from <see cref="TBL_KASA_BAKIYE"/>.</param>
		static partial void OnDTO(this TBL_KASA_BAKIYE entity, TBL_KASA_BAKIYEDTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_KASA_BAKIYE"/> converted from <see cref="TBL_KASA_BAKIYEDTO"/>.</param>
		static partial void OnEntity(this TBL_KASA_BAKIYEDTO dto, TBL_KASA_BAKIYE  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_KASA_BAKIYEDTO"/> to an instance of <see cref="TBL_KASA_BAKIYE"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_KASA_BAKIYEDTO"/> to convert.</param>
         public static TBL_KASA_BAKIYE    ToEntity(this TBL_KASA_BAKIYEDTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_KASA_BAKIYE(); 
          		           		  entity.TBL_KASA_BAKIYE_ID=dto.TBL_KASA_BAKIYE_ID;
		  		           		  entity.TBL_KASA_ID=dto.TBL_KASA_ID;
		  		           		  entity.TBL_PARA_TIPI_ID=dto.TBL_PARA_TIPI_ID;
		  		           		  entity.TBL_FIS_ID=dto.TBL_FIS_ID;
		  		           		  entity.KUR=dto.KUR;
		  		           		  entity.TARIH=dto.TARIH;
		  		           		  entity.TUTAR=dto.TUTAR;
		  		           		  entity.ACIKLAMA=dto.ACIKLAMA;
		  		           		  entity.YEDEK=dto.YEDEK;
		  		           		           		           
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_KASA_BAKIYE"/> to an instance of <see cref="TBL_KASA_BAKIYEDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_KASA_BAKIYE"/> to convert.</param>
		  public static TBL_KASA_BAKIYEDTO ToDTO(this TBL_KASA_BAKIYE entity)
        {
            if (entity == null) return null;

            var dto = new TBL_KASA_BAKIYEDTO();

            
 //EdmProperty

                         		  dto.TBL_KASA_BAKIYE_ID=entity.TBL_KASA_BAKIYE_ID;
		                		  dto.TBL_KASA_ID=entity.TBL_KASA_ID;
		                		  dto.TBL_PARA_TIPI_ID=entity.TBL_PARA_TIPI_ID;
		                		  dto.TBL_FIS_ID=entity.TBL_FIS_ID;
		                		  dto.KUR=entity.KUR;
		                		  dto.TARIH=entity.TARIH;
		                		  dto.TUTAR=entity.TUTAR;
		                		  dto.ACIKLAMA=entity.ACIKLAMA;
		                		  dto.YEDEK=entity.YEDEK;
		                                            
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_KASA_BAKIYEDTO"/> to an instance of <see cref=TBL_KASA_BAKIYE"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_KASA_BAKIYE> ToEntities(this IEnumerable<TBL_KASA_BAKIYEDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_KASA_BAKIYE"/> to an instance of <see cref="TBL_KASA_BAKIYEDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_KASA_BAKIYEDTO> ToDTOs(this IEnumerable<TBL_KASA_BAKIYE> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}





