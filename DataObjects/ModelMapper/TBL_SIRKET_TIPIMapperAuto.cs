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
    /// Assembler for <see cref="TBL_SIRKET_TIPI "/> and <see cref="TBL_SIRKET_TIPIDTO"/>.
    /// </summary>
	public  static partial class  TBL_SIRKET_TIPIMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_SIRKET_TIPIDTO"/> converted from <see cref="TBL_SIRKET_TIPI"/>.</param>
		static partial void OnDTO(this TBL_SIRKET_TIPI entity, TBL_SIRKET_TIPIDTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_SIRKET_TIPI"/> converted from <see cref="TBL_SIRKET_TIPIDTO"/>.</param>
		static partial void OnEntity(this TBL_SIRKET_TIPIDTO dto, TBL_SIRKET_TIPI  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_SIRKET_TIPIDTO"/> to an instance of <see cref="TBL_SIRKET_TIPI"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_SIRKET_TIPIDTO"/> to convert.</param>
         public static TBL_SIRKET_TIPI    ToEntity(this TBL_SIRKET_TIPIDTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_SIRKET_TIPI(); 
          		           		  entity.TBL_SIRKET_TIPI_ID=dto.TBL_SIRKET_TIPI_ID;
		  		           		  entity.SIRKET_TIPI_ADI=dto.SIRKET_TIPI_ADI;
		  		           		  entity.YEDEK=dto.YEDEK;
		  		           
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_SIRKET_TIPI"/> to an instance of <see cref="TBL_SIRKET_TIPIDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_SIRKET_TIPI"/> to convert.</param>
		  public static TBL_SIRKET_TIPIDTO ToDTO(this TBL_SIRKET_TIPI entity)
        {
            if (entity == null) return null;

            var dto = new TBL_SIRKET_TIPIDTO();

            
 //EdmProperty

                         		  dto.TBL_SIRKET_TIPI_ID=entity.TBL_SIRKET_TIPI_ID;
		                		  dto.SIRKET_TIPI_ADI=entity.SIRKET_TIPI_ADI;
		                		  dto.YEDEK=entity.YEDEK;
		                
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_SIRKET_TIPIDTO"/> to an instance of <see cref=TBL_SIRKET_TIPI"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_SIRKET_TIPI> ToEntities(this IEnumerable<TBL_SIRKET_TIPIDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_SIRKET_TIPI"/> to an instance of <see cref="TBL_SIRKET_TIPIDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_SIRKET_TIPIDTO> ToDTOs(this IEnumerable<TBL_SIRKET_TIPI> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}





