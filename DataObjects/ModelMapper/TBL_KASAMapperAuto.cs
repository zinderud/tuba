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
    /// Assembler for <see cref="TBL_KASA "/> and <see cref="TBL_KASADTO"/>.
    /// </summary>
	public  static partial class  TBL_KASAMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_KASADTO"/> converted from <see cref="TBL_KASA"/>.</param>
		static partial void OnDTO(this TBL_KASA entity, TBL_KASADTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_KASA"/> converted from <see cref="TBL_KASADTO"/>.</param>
		static partial void OnEntity(this TBL_KASADTO dto, TBL_KASA  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_KASADTO"/> to an instance of <see cref="TBL_KASA"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_KASADTO"/> to convert.</param>
         public static TBL_KASA    ToEntity(this TBL_KASADTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_KASA(); 
          		           		  entity.TBL_KASA_ID=dto.TBL_KASA_ID;
		  		           		  entity.TBL_PARA_TIPI_ID=dto.TBL_PARA_TIPI_ID;
		  		           		  entity.KASA_ADI=dto.KASA_ADI;
		  		           		  entity.KASA_ACIKLAMA=dto.KASA_ACIKLAMA;
		  		           		  entity.YEDEK=dto.YEDEK;
		  		           		           		           		           		           
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_KASA"/> to an instance of <see cref="TBL_KASADTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_KASA"/> to convert.</param>
		  public static TBL_KASADTO ToDTO(this TBL_KASA entity)
        {
            if (entity == null) return null;

            var dto = new TBL_KASADTO();

            
 //EdmProperty

                         		  dto.TBL_KASA_ID=entity.TBL_KASA_ID;
		                		  dto.TBL_PARA_TIPI_ID=entity.TBL_PARA_TIPI_ID;
		                		  dto.KASA_ADI=entity.KASA_ADI;
		                		  dto.KASA_ACIKLAMA=entity.KASA_ACIKLAMA;
		                		  dto.YEDEK=entity.YEDEK;
		                                                                        
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_KASADTO"/> to an instance of <see cref=TBL_KASA"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_KASA> ToEntities(this IEnumerable<TBL_KASADTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_KASA"/> to an instance of <see cref="TBL_KASADTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_KASADTO> ToDTOs(this IEnumerable<TBL_KASA> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}





