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
    /// Assembler for <see cref="TBL_SPARIS "/> and <see cref="TBL_SPARISDTO"/>.
    /// </summary>
	public  static partial class  TBL_SPARISMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_SPARISDTO"/> converted from <see cref="TBL_SPARIS_MODEL"/>.</param>
		static partial void OnDTO(this TBL_SPARIS_MODEL entity, TBL_SPARISDTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_SPARIS_MODEL"/> converted from <see cref="TBL_SPARISDTO"/>.</param>
		static partial void OnEntity(this TBL_SPARISDTO dto, TBL_SPARIS_MODEL  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_SPARISDTO"/> to an instance of <see cref="TBL_SPARIS"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_SPARISDTO"/> to convert.</param>
         public static TBL_SPARIS_MODEL    ToEntity(this TBL_SPARISDTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_SPARIS_MODEL(); 
               		  entity.TBL_SPARIS_ID=dto.TBL_SPARIS_ID;
		       		  entity.TBL_SIRKET_ID=dto.TBL_SIRKET_ID;
		       		  entity.TBL_SPARIS_TURU_ID=dto.TBL_SPARIS_TURU_ID;
		       		  entity.SPARIS_TARIH=dto.SPARIS_TARIH;
		       		  entity.SPARIS_VADE_TARIH=dto.SPARIS_VADE_TARIH;
		       		  entity.SPARIS_FATURA_SERI_NO=dto.SPARIS_FATURA_SERI_NO;
		       		  entity.TBL_PARA_TIPI_ID=dto.TBL_PARA_TIPI_ID;
		       		  entity.TBL_ODEME_TIPI_ID=dto.TBL_ODEME_TIPI_ID;
		       		  entity.TBL_KASA_ID=dto.TBL_KASA_ID;
		       		  entity.TBL_DEPO_ID=dto.TBL_DEPO_ID;
		       		  entity.TBL_PERSONEL_ID=dto.TBL_PERSONEL_ID;
		       		  entity.YEDEK=dto.YEDEK;
		                                               
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_SPARIS_MODEL"/> to an instance of <see cref="TBL_SPARISDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_SPARIS"/> to convert.</param>
		  public static TBL_SPARISDTO ToDTO(this TBL_SPARIS_MODEL entity)
        {
            if (entity == null) return null;

            var dto = new TBL_SPARISDTO();

            
                 		  dto.TBL_SPARIS_ID=entity.TBL_SPARIS_ID;
		        		  dto.TBL_SIRKET_ID=entity.TBL_SIRKET_ID;
		        		  dto.TBL_SPARIS_TURU_ID=entity.TBL_SPARIS_TURU_ID;
		        		  dto.SPARIS_TARIH=entity.SPARIS_TARIH;
		        		  dto.SPARIS_VADE_TARIH=entity.SPARIS_VADE_TARIH;
		        		  dto.SPARIS_FATURA_SERI_NO=entity.SPARIS_FATURA_SERI_NO;
		        		  dto.TBL_PARA_TIPI_ID=entity.TBL_PARA_TIPI_ID;
		        		  dto.TBL_ODEME_TIPI_ID=entity.TBL_ODEME_TIPI_ID;
		        		  dto.TBL_KASA_ID=entity.TBL_KASA_ID;
		        		  dto.TBL_DEPO_ID=entity.TBL_DEPO_ID;
		        		  dto.TBL_PERSONEL_ID=entity.TBL_PERSONEL_ID;
		        		  dto.YEDEK=entity.YEDEK;
		                                                        
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_SPARISDTO"/> to an instance of <see cref=TBL_SPARIS"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_SPARIS_MODEL> ToEntities(this IEnumerable<TBL_SPARISDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_SPARIS_MODEL"/> to an instance of <see cref="TBL_SPARISDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_SPARISDTO> ToDTOs(this IEnumerable<TBL_SPARIS_MODEL> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}
