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
    /// Assembler for <see cref="TBL_PERSONEL "/> and <see cref="TBL_PERSONELDTO"/>.
    /// </summary>
	public  static partial class  TBL_PERSONELMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_PERSONELDTO"/> converted from <see cref="TBL_PERSONEL_MODEL"/>.</param>
		static partial void OnDTO(this TBL_PERSONEL_MODEL entity, TBL_PERSONELDTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_PERSONEL_MODEL"/> converted from <see cref="TBL_PERSONELDTO"/>.</param>
		static partial void OnEntity(this TBL_PERSONELDTO dto, TBL_PERSONEL_MODEL  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_PERSONELDTO"/> to an instance of <see cref="TBL_PERSONEL"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_PERSONELDTO"/> to convert.</param>
         public static TBL_PERSONEL_MODEL    ToEntity(this TBL_PERSONELDTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_PERSONEL_MODEL(); 
               		  entity.TBL_PERSONEL_ID=dto.TBL_PERSONEL_ID;
		       		  entity.PERSONEL_AD_SOYAD=dto.PERSONEL_AD_SOYAD;
		       		  entity.YETKI_SEVIYESI=dto.YETKI_SEVIYESI;
		       		  entity.SIFRE=dto.SIFRE;
		       		  entity.BARKOD_ID=dto.BARKOD_ID;
		       		  entity.PERSONEL_GOREVI=dto.PERSONEL_GOREVI;
		       		  entity.PERSONEL_TELEFON1=dto.PERSONEL_TELEFON1;
		       		  entity.PERSONEL_TELEFON2=dto.PERSONEL_TELEFON2;
		       		  entity.PERSONEL_MAIL=dto.PERSONEL_MAIL;
		       		  entity.PERSONEL_CALISMA_DURUMU=dto.PERSONEL_CALISMA_DURUMU;
		       		  entity.PERSONEL_ISE_BASLAMA_TARIHI=dto.PERSONEL_ISE_BASLAMA_TARIHI;
		       		  entity.PERSONEL_ISTEN_AYRILMA_TARIHI=dto.PERSONEL_ISTEN_AYRILMA_TARIHI;
		       		  entity.PERSONEL_ISE_GELIS_SAATI=dto.PERSONEL_ISE_GELIS_SAATI;
		       		  entity.PERSONEL_ISTEN_CIKIS_SAATI=dto.PERSONEL_ISTEN_CIKIS_SAATI;
		       		  entity.PERSONEL_SSK_NO=dto.PERSONEL_SSK_NO;
		       		  entity.PERSONEL_CINSIYET=dto.PERSONEL_CINSIYET;
		       		  entity.PERSONEL_KIMLIK_NO=dto.PERSONEL_KIMLIK_NO;
		       		  entity.PERSONEL_DOGUM_TARIHI=dto.PERSONEL_DOGUM_TARIHI;
		       		  entity.PERSONEL_DOGUM_YERI=dto.PERSONEL_DOGUM_YERI;
		       		  entity.PERSONEL_EGITIM_DURUMU=dto.PERSONEL_EGITIM_DURUMU;
		       		  entity.PERSONEL_ACIKLAMA=dto.PERSONEL_ACIKLAMA;
		       		  entity.PERSONEL_AYAKKABI_NO=dto.PERSONEL_AYAKKABI_NO;
		       		  entity.PERSONEL_GOMLEK_NO=dto.PERSONEL_GOMLEK_NO;
		       		  entity.PERSONEL_MONT_NO=dto.PERSONEL_MONT_NO;
		       		  entity.PERSONEL_PANTOLON_NO=dto.PERSONEL_PANTOLON_NO;
		       		  entity.YEDEK=dto.YEDEK;
		            
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_PERSONEL_MODEL"/> to an instance of <see cref="TBL_PERSONELDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_PERSONEL"/> to convert.</param>
		  public static TBL_PERSONELDTO ToDTO(this TBL_PERSONEL_MODEL entity)
        {
            if (entity == null) return null;

            var dto = new TBL_PERSONELDTO();

            
                 		  dto.TBL_PERSONEL_ID=entity.TBL_PERSONEL_ID;
		        		  dto.PERSONEL_AD_SOYAD=entity.PERSONEL_AD_SOYAD;
		        		  dto.YETKI_SEVIYESI=entity.YETKI_SEVIYESI;
		        		  dto.SIFRE=entity.SIFRE;
		        		  dto.BARKOD_ID=entity.BARKOD_ID;
		        		  dto.PERSONEL_GOREVI=entity.PERSONEL_GOREVI;
		        		  dto.PERSONEL_TELEFON1=entity.PERSONEL_TELEFON1;
		        		  dto.PERSONEL_TELEFON2=entity.PERSONEL_TELEFON2;
		        		  dto.PERSONEL_MAIL=entity.PERSONEL_MAIL;
		        		  dto.PERSONEL_CALISMA_DURUMU=entity.PERSONEL_CALISMA_DURUMU;
		        		  dto.PERSONEL_ISE_BASLAMA_TARIHI=entity.PERSONEL_ISE_BASLAMA_TARIHI;
		        		  dto.PERSONEL_ISTEN_AYRILMA_TARIHI=entity.PERSONEL_ISTEN_AYRILMA_TARIHI;
		        		  dto.PERSONEL_ISE_GELIS_SAATI=entity.PERSONEL_ISE_GELIS_SAATI;
		        		  dto.PERSONEL_ISTEN_CIKIS_SAATI=entity.PERSONEL_ISTEN_CIKIS_SAATI;
		        		  dto.PERSONEL_SSK_NO=entity.PERSONEL_SSK_NO;
		        		  dto.PERSONEL_CINSIYET=entity.PERSONEL_CINSIYET;
		        		  dto.PERSONEL_KIMLIK_NO=entity.PERSONEL_KIMLIK_NO;
		        		  dto.PERSONEL_DOGUM_TARIHI=entity.PERSONEL_DOGUM_TARIHI;
		        		  dto.PERSONEL_DOGUM_YERI=entity.PERSONEL_DOGUM_YERI;
		        		  dto.PERSONEL_EGITIM_DURUMU=entity.PERSONEL_EGITIM_DURUMU;
		        		  dto.PERSONEL_ACIKLAMA=entity.PERSONEL_ACIKLAMA;
		        		  dto.PERSONEL_AYAKKABI_NO=entity.PERSONEL_AYAKKABI_NO;
		        		  dto.PERSONEL_GOMLEK_NO=entity.PERSONEL_GOMLEK_NO;
		        		  dto.PERSONEL_MONT_NO=entity.PERSONEL_MONT_NO;
		        		  dto.PERSONEL_PANTOLON_NO=entity.PERSONEL_PANTOLON_NO;
		        		  dto.YEDEK=entity.YEDEK;
		              
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_PERSONELDTO"/> to an instance of <see cref=TBL_PERSONEL"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_PERSONEL_MODEL> ToEntities(this IEnumerable<TBL_PERSONELDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_PERSONEL_MODEL"/> to an instance of <see cref="TBL_PERSONELDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_PERSONELDTO> ToDTOs(this IEnumerable<TBL_PERSONEL_MODEL> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}
