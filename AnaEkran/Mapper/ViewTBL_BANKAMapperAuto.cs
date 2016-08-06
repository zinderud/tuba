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
    /// Assembler for <see cref="TBL_BANKA "/> and <see cref="TBL_BANKADTO"/>.
    /// </summary>
	public  static partial class  TBL_BANKAMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_BANKADTO"/> converted from <see cref="TBL_BANKA_MODEL"/>.</param>
		static partial void OnDTO(this TBL_BANKA_MODEL entity, TBL_BANKADTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_BANKA_MODEL"/> converted from <see cref="TBL_BANKADTO"/>.</param>
		static partial void OnEntity(this TBL_BANKADTO dto, TBL_BANKA_MODEL  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_BANKADTO"/> to an instance of <see cref="TBL_BANKA"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_BANKADTO"/> to convert.</param>
         public static TBL_BANKA_MODEL    ToEntity(this TBL_BANKADTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_BANKA_MODEL(); 
               		  entity.TBL_BANKA_ID=dto.TBL_BANKA_ID;
		       		  entity.BANKA_ADI=dto.BANKA_ADI;
		       		  entity.BANKA_SUBE_ADI=dto.BANKA_SUBE_ADI;
		       		  entity.BANKA_IBAN_NO=dto.BANKA_IBAN_NO;
		       		  entity.TBL_PARA_TIPI_ID=dto.TBL_PARA_TIPI_ID;
		       		  entity.BANKA_TELEFON_1=dto.BANKA_TELEFON_1;
		       		  entity.BANKA_TELEFON_2=dto.BANKA_TELEFON_2;
		       		  entity.BANKA_ADRES=dto.BANKA_ADRES;
		       		  entity.BANKA_IL=dto.BANKA_IL;
		       		  entity.BANKA_ILCE=dto.BANKA_ILCE;
		       		  entity.BANKA_MAIL=dto.BANKA_MAIL;
		       		  entity.BANKA_ACIKLAMA=dto.BANKA_ACIKLAMA;
		       		  entity.YEDEK=dto.YEDEK;
		            
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_BANKA_MODEL"/> to an instance of <see cref="TBL_BANKADTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_BANKA"/> to convert.</param>
		  public static TBL_BANKADTO ToDTO(this TBL_BANKA_MODEL entity)
        {
            if (entity == null) return null;

            var dto = new TBL_BANKADTO();

            
                 		  dto.TBL_BANKA_ID=entity.TBL_BANKA_ID;
		        		  dto.BANKA_ADI=entity.BANKA_ADI;
		        		  dto.BANKA_SUBE_ADI=entity.BANKA_SUBE_ADI;
		        		  dto.BANKA_IBAN_NO=entity.BANKA_IBAN_NO;
		        		  dto.TBL_PARA_TIPI_ID=entity.TBL_PARA_TIPI_ID;
		        		  dto.BANKA_TELEFON_1=entity.BANKA_TELEFON_1;
		        		  dto.BANKA_TELEFON_2=entity.BANKA_TELEFON_2;
		        		  dto.BANKA_ADRES=entity.BANKA_ADRES;
		        		  dto.BANKA_IL=entity.BANKA_IL;
		        		  dto.BANKA_ILCE=entity.BANKA_ILCE;
		        		  dto.BANKA_MAIL=entity.BANKA_MAIL;
		        		  dto.BANKA_ACIKLAMA=entity.BANKA_ACIKLAMA;
		        		  dto.YEDEK=entity.YEDEK;
		              
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_BANKADTO"/> to an instance of <see cref=TBL_BANKA"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_BANKA_MODEL> ToEntities(this IEnumerable<TBL_BANKADTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_BANKA_MODEL"/> to an instance of <see cref="TBL_BANKADTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_BANKADTO> ToDTOs(this IEnumerable<TBL_BANKA_MODEL> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}
