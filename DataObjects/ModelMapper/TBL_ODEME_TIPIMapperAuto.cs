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
    /// Assembler for <see cref="TBL_ODEME_TIPI "/> and <see cref="TBL_ODEME_TIPIDTO"/>.
    /// </summary>
	public  static partial class  TBL_ODEME_TIPIMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_ODEME_TIPIDTO"/> converted from <see cref="TBL_ODEME_TIPI"/>.</param>
		static partial void OnDTO(this TBL_ODEME_TIPI entity, TBL_ODEME_TIPIDTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_ODEME_TIPI"/> converted from <see cref="TBL_ODEME_TIPIDTO"/>.</param>
		static partial void OnEntity(this TBL_ODEME_TIPIDTO dto, TBL_ODEME_TIPI  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_ODEME_TIPIDTO"/> to an instance of <see cref="TBL_ODEME_TIPI"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_ODEME_TIPIDTO"/> to convert.</param>
         public static TBL_ODEME_TIPI    ToEntity(this TBL_ODEME_TIPIDTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_ODEME_TIPI(); 
          		           		  entity.TBL_ODEME_TIPI_ID=dto.TBL_ODEME_TIPI_ID;
		  		           		  entity.ODEME_TIPI_ADI=dto.ODEME_TIPI_ADI;
		  		           		  entity.ODEME_TIPI_ACIKLAMA=dto.ODEME_TIPI_ACIKLAMA;
		  		           		  entity.YEDEK=dto.YEDEK;
		  		           		           		           
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_ODEME_TIPI"/> to an instance of <see cref="TBL_ODEME_TIPIDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_ODEME_TIPI"/> to convert.</param>
		  public static TBL_ODEME_TIPIDTO ToDTO(this TBL_ODEME_TIPI entity)
        {
            if (entity == null) return null;

            var dto = new TBL_ODEME_TIPIDTO();

            
 //EdmProperty

                         		  dto.TBL_ODEME_TIPI_ID=entity.TBL_ODEME_TIPI_ID;
		                		  dto.ODEME_TIPI_ADI=entity.ODEME_TIPI_ADI;
		                		  dto.ODEME_TIPI_ACIKLAMA=entity.ODEME_TIPI_ACIKLAMA;
		                		  dto.YEDEK=entity.YEDEK;
		                                            
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_ODEME_TIPIDTO"/> to an instance of <see cref=TBL_ODEME_TIPI"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_ODEME_TIPI> ToEntities(this IEnumerable<TBL_ODEME_TIPIDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_ODEME_TIPI"/> to an instance of <see cref="TBL_ODEME_TIPIDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_ODEME_TIPIDTO> ToDTOs(this IEnumerable<TBL_ODEME_TIPI> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}





