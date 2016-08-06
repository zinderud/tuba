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
    /// Assembler for <see cref="TBL_FATURA_TURU "/> and <see cref="TBL_FATURA_TURUDTO"/>.
    /// </summary>
	public  static partial class  TBL_FATURA_TURUMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_FATURA_TURUDTO"/> converted from <see cref="TBL_FATURA_TURU_MODEL"/>.</param>
		static partial void OnDTO(this TBL_FATURA_TURU_MODEL entity, TBL_FATURA_TURUDTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_FATURA_TURU_MODEL"/> converted from <see cref="TBL_FATURA_TURUDTO"/>.</param>
		static partial void OnEntity(this TBL_FATURA_TURUDTO dto, TBL_FATURA_TURU_MODEL  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_FATURA_TURUDTO"/> to an instance of <see cref="TBL_FATURA_TURU"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_FATURA_TURUDTO"/> to convert.</param>
         public static TBL_FATURA_TURU_MODEL    ToEntity(this TBL_FATURA_TURUDTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_FATURA_TURU_MODEL(); 
               		  entity.TBL_FATURA_TURU_ID=dto.TBL_FATURA_TURU_ID;
		       		  entity.FATURA_TURU_ADI=dto.FATURA_TURU_ADI;
		       		  entity.FATURA_TURU_ACIKLAMA=dto.FATURA_TURU_ACIKLAMA;
		       		  entity.YEDEK=dto.YEDEK;
		       
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_FATURA_TURU_MODEL"/> to an instance of <see cref="TBL_FATURA_TURUDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_FATURA_TURU"/> to convert.</param>
		  public static TBL_FATURA_TURUDTO ToDTO(this TBL_FATURA_TURU_MODEL entity)
        {
            if (entity == null) return null;

            var dto = new TBL_FATURA_TURUDTO();

            
                 		  dto.TBL_FATURA_TURU_ID=entity.TBL_FATURA_TURU_ID;
		        		  dto.FATURA_TURU_ADI=entity.FATURA_TURU_ADI;
		        		  dto.FATURA_TURU_ACIKLAMA=entity.FATURA_TURU_ACIKLAMA;
		        		  dto.YEDEK=entity.YEDEK;
		        
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_FATURA_TURUDTO"/> to an instance of <see cref=TBL_FATURA_TURU"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_FATURA_TURU_MODEL> ToEntities(this IEnumerable<TBL_FATURA_TURUDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_FATURA_TURU_MODEL"/> to an instance of <see cref="TBL_FATURA_TURUDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_FATURA_TURUDTO> ToDTOs(this IEnumerable<TBL_FATURA_TURU_MODEL> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}
