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
    /// Assembler for <see cref="TBL_SPARIS_TURU "/> and <see cref="TBL_SPARIS_TURUDTO"/>.
    /// </summary>
	public  static partial class  TBL_SPARIS_TURUMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_SPARIS_TURUDTO"/> converted from <see cref="TBL_SPARIS_TURU_MODEL"/>.</param>
		static partial void OnDTO(this TBL_SPARIS_TURU_MODEL entity, TBL_SPARIS_TURUDTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_SPARIS_TURU_MODEL"/> converted from <see cref="TBL_SPARIS_TURUDTO"/>.</param>
		static partial void OnEntity(this TBL_SPARIS_TURUDTO dto, TBL_SPARIS_TURU_MODEL  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_SPARIS_TURUDTO"/> to an instance of <see cref="TBL_SPARIS_TURU"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_SPARIS_TURUDTO"/> to convert.</param>
         public static TBL_SPARIS_TURU_MODEL    ToEntity(this TBL_SPARIS_TURUDTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_SPARIS_TURU_MODEL(); 
               		  entity.TBL_SPARIS_TURU_ID=dto.TBL_SPARIS_TURU_ID;
		       		  entity.SPARIS_TURU_ADI=dto.SPARIS_TURU_ADI;
		       		  entity.SPARIS_TURU_ACIKLAMA=dto.SPARIS_TURU_ACIKLAMA;
		       		  entity.YEDEK=dto.YEDEK;
		       
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_SPARIS_TURU_MODEL"/> to an instance of <see cref="TBL_SPARIS_TURUDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_SPARIS_TURU"/> to convert.</param>
		  public static TBL_SPARIS_TURUDTO ToDTO(this TBL_SPARIS_TURU_MODEL entity)
        {
            if (entity == null) return null;

            var dto = new TBL_SPARIS_TURUDTO();

            
                 		  dto.TBL_SPARIS_TURU_ID=entity.TBL_SPARIS_TURU_ID;
		        		  dto.SPARIS_TURU_ADI=entity.SPARIS_TURU_ADI;
		        		  dto.SPARIS_TURU_ACIKLAMA=entity.SPARIS_TURU_ACIKLAMA;
		        		  dto.YEDEK=entity.YEDEK;
		        
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_SPARIS_TURUDTO"/> to an instance of <see cref=TBL_SPARIS_TURU"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_SPARIS_TURU_MODEL> ToEntities(this IEnumerable<TBL_SPARIS_TURUDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_SPARIS_TURU_MODEL"/> to an instance of <see cref="TBL_SPARIS_TURUDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_SPARIS_TURUDTO> ToDTOs(this IEnumerable<TBL_SPARIS_TURU_MODEL> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}
