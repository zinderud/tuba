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
    /// Assembler for <see cref="TBL_FATURA "/> and <see cref="TBL_FATURADTO"/>.
    /// </summary>
	public  static partial class  TBL_FATURAMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_FATURADTO"/> converted from <see cref="TBL_FATURA"/>.</param>
		static partial void OnDTO(this TBL_FATURA entity, TBL_FATURADTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_FATURA"/> converted from <see cref="TBL_FATURADTO"/>.</param>
		static partial void OnEntity(this TBL_FATURADTO dto, TBL_FATURA  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_FATURADTO"/> to an instance of <see cref="TBL_FATURA"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_FATURADTO"/> to convert.</param>
         public static TBL_FATURA    ToEntity(this TBL_FATURADTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_FATURA(); 
          		           		  entity.TBL_FATURA_ID=dto.TBL_FATURA_ID;
		  		           		  entity.TBL_SIRKET_ID=dto.TBL_SIRKET_ID;
		  		           		  entity.TBL_FATURA_TURU_ID=dto.TBL_FATURA_TURU_ID;
		  		           		  entity.FATURA_TARIH=dto.FATURA_TARIH;
		  		           		  entity.FATURA_VADE_TARIH=dto.FATURA_VADE_TARIH;
		  		           		  entity.FATURA_FATURA_SERI_NO=dto.FATURA_FATURA_SERI_NO;
		  		           		  entity.TBL_PARA_TIPI_ID=dto.TBL_PARA_TIPI_ID;
		  		           		  entity.TBL_ODEME_TIPI_ID=dto.TBL_ODEME_TIPI_ID;
		  		           		  entity.TBL_KASA_ID=dto.TBL_KASA_ID;
		  		           		  entity.TBL_DEPO_ID=dto.TBL_DEPO_ID;
		  		           		  entity.TBL_PERSONEL_ID=dto.TBL_PERSONEL_ID;
		  		           		  entity.ACIKLAMA=dto.ACIKLAMA;
		  		           		  entity.YEDEK=dto.YEDEK;
		  		           		  entity.TBL_SPARIS_ID=dto.TBL_SPARIS_ID;
		  		           		           		           		           		           		           		           		           		           
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_FATURA"/> to an instance of <see cref="TBL_FATURADTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_FATURA"/> to convert.</param>
		  public static TBL_FATURADTO ToDTO(this TBL_FATURA entity)
        {
            if (entity == null) return null;

            var dto = new TBL_FATURADTO();

            
 //EdmProperty

                         		  dto.TBL_FATURA_ID=entity.TBL_FATURA_ID;
		                		  dto.TBL_SIRKET_ID=entity.TBL_SIRKET_ID;
		                		  dto.TBL_FATURA_TURU_ID=entity.TBL_FATURA_TURU_ID;
		                		  dto.FATURA_TARIH=entity.FATURA_TARIH;
		                		  dto.FATURA_VADE_TARIH=entity.FATURA_VADE_TARIH;
		                		  dto.FATURA_FATURA_SERI_NO=entity.FATURA_FATURA_SERI_NO;
		                		  dto.TBL_PARA_TIPI_ID=entity.TBL_PARA_TIPI_ID;
		                		  dto.TBL_ODEME_TIPI_ID=entity.TBL_ODEME_TIPI_ID;
		                		  dto.TBL_KASA_ID=entity.TBL_KASA_ID;
		                		  dto.TBL_DEPO_ID=entity.TBL_DEPO_ID;
		                		  dto.TBL_PERSONEL_ID=entity.TBL_PERSONEL_ID;
		                		  dto.ACIKLAMA=entity.ACIKLAMA;
		                		  dto.YEDEK=entity.YEDEK;
		                		  dto.TBL_SPARIS_ID=entity.TBL_SPARIS_ID;
		                                                                                                                                
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_FATURADTO"/> to an instance of <see cref=TBL_FATURA"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_FATURA> ToEntities(this IEnumerable<TBL_FATURADTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_FATURA"/> to an instance of <see cref="TBL_FATURADTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_FATURADTO> ToDTOs(this IEnumerable<TBL_FATURA> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}





