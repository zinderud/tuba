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
    /// Assembler for <see cref="TBL_SIRKET "/> and <see cref="TBL_SIRKETDTO"/>.
    /// </summary>
	public  static partial class  TBL_SIRKETMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_SIRKETDTO"/> converted from <see cref="TBL_SIRKET"/>.</param>
		static partial void OnDTO(this TBL_SIRKET entity, TBL_SIRKETDTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_SIRKET"/> converted from <see cref="TBL_SIRKETDTO"/>.</param>
		static partial void OnEntity(this TBL_SIRKETDTO dto, TBL_SIRKET  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_SIRKETDTO"/> to an instance of <see cref="TBL_SIRKET"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_SIRKETDTO"/> to convert.</param>
         public static TBL_SIRKET    ToEntity(this TBL_SIRKETDTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_SIRKET(); 
          		           		  entity.TBL_SIRKET_ID=dto.TBL_SIRKET_ID;
		  		           		  entity.TBL_SIRKET_GRUB_ID=dto.TBL_SIRKET_GRUB_ID;
		  		           		  entity.TBL_SIRKET_SINIF_ID=dto.TBL_SIRKET_SINIF_ID;
		  		           		  entity.TBL_SIRKET_TIPI_ID=dto.TBL_SIRKET_TIPI_ID;
		  		           		  entity.SIRKET_ADI=dto.SIRKET_ADI;
		  		           		  entity.SIRKET_TELEFON_1=dto.SIRKET_TELEFON_1;
		  		           		  entity.SIRKET_TELEFON_2=dto.SIRKET_TELEFON_2;
		  		           		  entity.SIRKET_FAX_1=dto.SIRKET_FAX_1;
		  		           		  entity.SIRKET_FAX_2=dto.SIRKET_FAX_2;
		  		           		  entity.SIRKET_MAIL_1=dto.SIRKET_MAIL_1;
		  		           		  entity.SIRKET_MAIL_2=dto.SIRKET_MAIL_2;
		  		           		  entity.SIRKET_WEB_ADRES=dto.SIRKET_WEB_ADRES;
		  		           		  entity.SIRKET_VERGI_DAIRESI=dto.SIRKET_VERGI_DAIRESI;
		  		           		  entity.SIRKET_VERGI_NO=dto.SIRKET_VERGI_NO;
		  		           		  entity.SIRKET_ADRES=dto.SIRKET_ADRES;
		  		           		  entity.SIRKET_IL=dto.SIRKET_IL;
		  		           		  entity.SIRKET_ILCE=dto.SIRKET_ILCE;
		  		           		  entity.SIRKET_POSTA_KODU=dto.SIRKET_POSTA_KODU;
		  		           		  entity.SIRKET_BANKA_ADI=dto.SIRKET_BANKA_ADI;
		  		           		  entity.SIRKET_BANKA_SUBE_ADI=dto.SIRKET_BANKA_SUBE_ADI;
		  		           		  entity.SIRKET_HESAP_NO=dto.SIRKET_HESAP_NO;
		  		           		  entity.SIRKET_IBAN=dto.SIRKET_IBAN;
		  		           		  entity.SIRKET_ACIKLAMA=dto.SIRKET_ACIKLAMA;
		  		           		  entity.YEDEK=dto.YEDEK;
		  		           		           		           		           		           		           		           
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_SIRKET"/> to an instance of <see cref="TBL_SIRKETDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_SIRKET"/> to convert.</param>
		  public static TBL_SIRKETDTO ToDTO(this TBL_SIRKET entity)
        {
            if (entity == null) return null;

            var dto = new TBL_SIRKETDTO();

            
 //EdmProperty

                         		  dto.TBL_SIRKET_ID=entity.TBL_SIRKET_ID;
		                		  dto.TBL_SIRKET_GRUB_ID=entity.TBL_SIRKET_GRUB_ID;
		                		  dto.TBL_SIRKET_SINIF_ID=entity.TBL_SIRKET_SINIF_ID;
		                		  dto.TBL_SIRKET_TIPI_ID=entity.TBL_SIRKET_TIPI_ID;
		                		  dto.SIRKET_ADI=entity.SIRKET_ADI;
		                		  dto.SIRKET_TELEFON_1=entity.SIRKET_TELEFON_1;
		                		  dto.SIRKET_TELEFON_2=entity.SIRKET_TELEFON_2;
		                		  dto.SIRKET_FAX_1=entity.SIRKET_FAX_1;
		                		  dto.SIRKET_FAX_2=entity.SIRKET_FAX_2;
		                		  dto.SIRKET_MAIL_1=entity.SIRKET_MAIL_1;
		                		  dto.SIRKET_MAIL_2=entity.SIRKET_MAIL_2;
		                		  dto.SIRKET_WEB_ADRES=entity.SIRKET_WEB_ADRES;
		                		  dto.SIRKET_VERGI_DAIRESI=entity.SIRKET_VERGI_DAIRESI;
		                		  dto.SIRKET_VERGI_NO=entity.SIRKET_VERGI_NO;
		                		  dto.SIRKET_ADRES=entity.SIRKET_ADRES;
		                		  dto.SIRKET_IL=entity.SIRKET_IL;
		                		  dto.SIRKET_ILCE=entity.SIRKET_ILCE;
		                		  dto.SIRKET_POSTA_KODU=entity.SIRKET_POSTA_KODU;
		                		  dto.SIRKET_BANKA_ADI=entity.SIRKET_BANKA_ADI;
		                		  dto.SIRKET_BANKA_SUBE_ADI=entity.SIRKET_BANKA_SUBE_ADI;
		                		  dto.SIRKET_HESAP_NO=entity.SIRKET_HESAP_NO;
		                		  dto.SIRKET_IBAN=entity.SIRKET_IBAN;
		                		  dto.SIRKET_ACIKLAMA=entity.SIRKET_ACIKLAMA;
		                		  dto.YEDEK=entity.YEDEK;
		                                                                                                    
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_SIRKETDTO"/> to an instance of <see cref=TBL_SIRKET"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_SIRKET> ToEntities(this IEnumerable<TBL_SIRKETDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_SIRKET"/> to an instance of <see cref="TBL_SIRKETDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_SIRKETDTO> ToDTOs(this IEnumerable<TBL_SIRKET> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}





