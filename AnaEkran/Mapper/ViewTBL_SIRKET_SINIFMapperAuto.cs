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
    /// Assembler for <see cref="TBL_SIRKET_SINIF "/> and <see cref="TBL_SIRKET_SINIFDTO"/>.
    /// </summary>
	public  static partial class  TBL_SIRKET_SINIFMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_SIRKET_SINIFDTO"/> converted from <see cref="TBL_SIRKET_SINIF_MODEL"/>.</param>
		static partial void OnDTO(this TBL_SIRKET_SINIF_MODEL entity, TBL_SIRKET_SINIFDTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_SIRKET_SINIF_MODEL"/> converted from <see cref="TBL_SIRKET_SINIFDTO"/>.</param>
		static partial void OnEntity(this TBL_SIRKET_SINIFDTO dto, TBL_SIRKET_SINIF_MODEL  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_SIRKET_SINIFDTO"/> to an instance of <see cref="TBL_SIRKET_SINIF"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_SIRKET_SINIFDTO"/> to convert.</param>
         public static TBL_SIRKET_SINIF_MODEL    ToEntity(this TBL_SIRKET_SINIFDTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_SIRKET_SINIF_MODEL(); 
               		  entity.TBL_SIRKET_SINIF_ID=dto.TBL_SIRKET_SINIF_ID;
		       		  entity.SIRKET_SINIF_ADI=dto.SIRKET_SINIF_ADI;
		       		  entity.YEDEK=dto.YEDEK;
		       
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_SIRKET_SINIF_MODEL"/> to an instance of <see cref="TBL_SIRKET_SINIFDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_SIRKET_SINIF"/> to convert.</param>
		  public static TBL_SIRKET_SINIFDTO ToDTO(this TBL_SIRKET_SINIF_MODEL entity)
        {
            if (entity == null) return null;

            var dto = new TBL_SIRKET_SINIFDTO();

            
                 		  dto.TBL_SIRKET_SINIF_ID=entity.TBL_SIRKET_SINIF_ID;
		        		  dto.SIRKET_SINIF_ADI=entity.SIRKET_SINIF_ADI;
		        		  dto.YEDEK=entity.YEDEK;
		        
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_SIRKET_SINIFDTO"/> to an instance of <see cref=TBL_SIRKET_SINIF"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_SIRKET_SINIF_MODEL> ToEntities(this IEnumerable<TBL_SIRKET_SINIFDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_SIRKET_SINIF_MODEL"/> to an instance of <see cref="TBL_SIRKET_SINIFDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_SIRKET_SINIFDTO> ToDTOs(this IEnumerable<TBL_SIRKET_SINIF_MODEL> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}
