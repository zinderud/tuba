using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;
using AnaEkran.Models;
using AutoBusinessObjects;

namespace AnaEkran.Mapper
{ 
    /// <summary>
    /// Assembler for <see cref="TBL_PARA_TIPI "/> and <see cref="TBL_PARA_TIPIDTO"/>.
    /// </summary>
	public  static partial class  TBL_PARA_TIPIMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_PARA_TIPIDTO"/> converted from <see cref="TBL_PARA_TIPI_MODEL"/>.</param>
		static partial void OnDTO(this TBL_PARA_TIPI_MODEL entity, TBL_PARA_TIPIDTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_PARA_TIPI_MODEL"/> converted from <see cref="TBL_PARA_TIPIDTO"/>.</param>
		static partial void OnEntity(this TBL_PARA_TIPIDTO dto, TBL_PARA_TIPI_MODEL  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_PARA_TIPIDTO"/> to an instance of <see cref="TBL_PARA_TIPI"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_PARA_TIPIDTO"/> to convert.</param>
         public static TBL_PARA_TIPI_MODEL    ToEntity(this TBL_PARA_TIPIDTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_PARA_TIPI_MODEL(); 
               		  entity.TBL_PARA_TIPI_ID=dto.TBL_PARA_TIPI_ID;
		       		  entity.PARA_TIPI_ADI=dto.PARA_TIPI_ADI;
		       		  entity.YEDEK=dto.YEDEK;
		                                                         
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_PARA_TIPI_MODEL"/> to an instance of <see cref="TBL_PARA_TIPIDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_PARA_TIPI"/> to convert.</param>
		  public static TBL_PARA_TIPIDTO ToDTO(this TBL_PARA_TIPI_MODEL entity)
        {
            if (entity == null) return null;

            var dto = new TBL_PARA_TIPIDTO();

            
                 		  dto.TBL_PARA_TIPI_ID=entity.TBL_PARA_TIPI_ID;
		        		  dto.PARA_TIPI_ADI=entity.PARA_TIPI_ADI;
		        		  dto.YEDEK=entity.YEDEK;
		                                                                    
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_PARA_TIPIDTO"/> to an instance of <see cref=TBL_PARA_TIPI"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_PARA_TIPI_MODEL> ToEntities(this IEnumerable<TBL_PARA_TIPIDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_PARA_TIPI_MODEL"/> to an instance of <see cref="TBL_PARA_TIPIDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_PARA_TIPIDTO> ToDTOs(this IEnumerable<TBL_PARA_TIPI_MODEL> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}
