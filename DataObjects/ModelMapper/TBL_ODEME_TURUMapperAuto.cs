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
    /// Assembler for <see cref="TBL_ODEME_TURU "/> and <see cref="TBL_ODEME_TURUDTO"/>.
    /// </summary>
	public  static partial class  TBL_ODEME_TURUMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_ODEME_TURUDTO"/> converted from <see cref="TBL_ODEME_TURU"/>.</param>
		static partial void OnDTO(this TBL_ODEME_TURU entity, TBL_ODEME_TURUDTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_ODEME_TURU"/> converted from <see cref="TBL_ODEME_TURUDTO"/>.</param>
		static partial void OnEntity(this TBL_ODEME_TURUDTO dto, TBL_ODEME_TURU  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_ODEME_TURUDTO"/> to an instance of <see cref="TBL_ODEME_TURU"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_ODEME_TURUDTO"/> to convert.</param>
         public static TBL_ODEME_TURU    ToEntity(this TBL_ODEME_TURUDTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_ODEME_TURU(); 
          		           		  entity.TBL_ODEME_TURU_ID=dto.TBL_ODEME_TURU_ID;
		  		           		  entity.ODEME_TURU_ADI=dto.ODEME_TURU_ADI;
		  		           		  entity.ODEME_TURU_ACIKLAMA=dto.ODEME_TURU_ACIKLAMA;
		  		           		  entity.YEDEK=dto.YEDEK;
		  		           
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_ODEME_TURU"/> to an instance of <see cref="TBL_ODEME_TURUDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_ODEME_TURU"/> to convert.</param>
		  public static TBL_ODEME_TURUDTO ToDTO(this TBL_ODEME_TURU entity)
        {
            if (entity == null) return null;

            var dto = new TBL_ODEME_TURUDTO();

            
 //EdmProperty

                         		  dto.TBL_ODEME_TURU_ID=entity.TBL_ODEME_TURU_ID;
		                		  dto.ODEME_TURU_ADI=entity.ODEME_TURU_ADI;
		                		  dto.ODEME_TURU_ACIKLAMA=entity.ODEME_TURU_ACIKLAMA;
		                		  dto.YEDEK=entity.YEDEK;
		                
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_ODEME_TURUDTO"/> to an instance of <see cref=TBL_ODEME_TURU"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_ODEME_TURU> ToEntities(this IEnumerable<TBL_ODEME_TURUDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_ODEME_TURU"/> to an instance of <see cref="TBL_ODEME_TURUDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_ODEME_TURUDTO> ToDTOs(this IEnumerable<TBL_ODEME_TURU> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}





