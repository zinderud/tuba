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
    /// Assembler for <see cref="TBL_URUN_FATURA "/> and <see cref="TBL_URUN_FATURADTO"/>.
    /// </summary>
	public  static partial class  TBL_URUN_FATURAMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_URUN_FATURADTO"/> converted from <see cref="TBL_URUN_FATURA_MODEL"/>.</param>
		static partial void OnDTO(this TBL_URUN_FATURA_MODEL entity, TBL_URUN_FATURADTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_URUN_FATURA_MODEL"/> converted from <see cref="TBL_URUN_FATURADTO"/>.</param>
		static partial void OnEntity(this TBL_URUN_FATURADTO dto, TBL_URUN_FATURA_MODEL  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_URUN_FATURADTO"/> to an instance of <see cref="TBL_URUN_FATURA"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_URUN_FATURADTO"/> to convert.</param>
         public static TBL_URUN_FATURA_MODEL    ToEntity(this TBL_URUN_FATURADTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_URUN_FATURA_MODEL(); 
               		  entity.TBL_URUN_FATURA_ID=dto.TBL_URUN_FATURA_ID;
		       		  entity.TBL_URUN_ID=dto.TBL_URUN_ID;
		       		  entity.TBL_FATURA_ID=dto.TBL_FATURA_ID;
		       		  entity.URUN_FATURA_MIKTAR=dto.URUN_FATURA_MIKTAR;
		       		  entity.ACIKLAMA=dto.ACIKLAMA;
		       		  entity.YEDEK=dto.YEDEK;
		            
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_URUN_FATURA_MODEL"/> to an instance of <see cref="TBL_URUN_FATURADTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_URUN_FATURA"/> to convert.</param>
		  public static TBL_URUN_FATURADTO ToDTO(this TBL_URUN_FATURA_MODEL entity)
        {
            if (entity == null) return null;

            var dto = new TBL_URUN_FATURADTO();

            
                 		  dto.TBL_URUN_FATURA_ID=entity.TBL_URUN_FATURA_ID;
		        		  dto.TBL_URUN_ID=entity.TBL_URUN_ID;
		        		  dto.TBL_FATURA_ID=entity.TBL_FATURA_ID;
		        		  dto.URUN_FATURA_MIKTAR=entity.URUN_FATURA_MIKTAR;
		        		  dto.ACIKLAMA=entity.ACIKLAMA;
		        		  dto.YEDEK=entity.YEDEK;
		              
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_URUN_FATURADTO"/> to an instance of <see cref=TBL_URUN_FATURA"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_URUN_FATURA_MODEL> ToEntities(this IEnumerable<TBL_URUN_FATURADTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_URUN_FATURA_MODEL"/> to an instance of <see cref="TBL_URUN_FATURADTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_URUN_FATURADTO> ToDTOs(this IEnumerable<TBL_URUN_FATURA_MODEL> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}
