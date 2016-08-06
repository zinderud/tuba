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
    /// Assembler for <see cref="TBL_URUN_TIPI "/> and <see cref="TBL_URUN_TIPIDTO"/>.
    /// </summary>
	public  static partial class  TBL_URUN_TIPIMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_URUN_TIPIDTO"/> converted from <see cref="TBL_URUN_TIPI_MODEL"/>.</param>
		static partial void OnDTO(this TBL_URUN_TIPI_MODEL entity, TBL_URUN_TIPIDTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_URUN_TIPI_MODEL"/> converted from <see cref="TBL_URUN_TIPIDTO"/>.</param>
		static partial void OnEntity(this TBL_URUN_TIPIDTO dto, TBL_URUN_TIPI_MODEL  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_URUN_TIPIDTO"/> to an instance of <see cref="TBL_URUN_TIPI"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_URUN_TIPIDTO"/> to convert.</param>
         public static TBL_URUN_TIPI_MODEL    ToEntity(this TBL_URUN_TIPIDTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_URUN_TIPI_MODEL(); 
               		  entity.TBL_URUN_TIPI_ID=dto.TBL_URUN_TIPI_ID;
		       		  entity.URUN_TIPI_ADI=dto.URUN_TIPI_ADI;
		       		  entity.URUN_TIPI_ACIKLAMA=dto.URUN_TIPI_ACIKLAMA;
		       		  entity.YEDEK=dto.YEDEK;
		                 
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_URUN_TIPI_MODEL"/> to an instance of <see cref="TBL_URUN_TIPIDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_URUN_TIPI"/> to convert.</param>
		  public static TBL_URUN_TIPIDTO ToDTO(this TBL_URUN_TIPI_MODEL entity)
        {
            if (entity == null) return null;

            var dto = new TBL_URUN_TIPIDTO();

            
                 		  dto.TBL_URUN_TIPI_ID=entity.TBL_URUN_TIPI_ID;
		        		  dto.URUN_TIPI_ADI=entity.URUN_TIPI_ADI;
		        		  dto.URUN_TIPI_ACIKLAMA=entity.URUN_TIPI_ACIKLAMA;
		        		  dto.YEDEK=entity.YEDEK;
		                    
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_URUN_TIPIDTO"/> to an instance of <see cref=TBL_URUN_TIPI"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_URUN_TIPI_MODEL> ToEntities(this IEnumerable<TBL_URUN_TIPIDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_URUN_TIPI_MODEL"/> to an instance of <see cref="TBL_URUN_TIPIDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_URUN_TIPIDTO> ToDTOs(this IEnumerable<TBL_URUN_TIPI_MODEL> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}
