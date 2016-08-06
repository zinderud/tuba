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
    /// Assembler for <see cref="TBL_URUN_STOK "/> and <see cref="TBL_URUN_STOKDTO"/>.
    /// </summary>
	public  static partial class  TBL_URUN_STOKMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_URUN_STOKDTO"/> converted from <see cref="TBL_URUN_STOK"/>.</param>
		static partial void OnDTO(this TBL_URUN_STOK entity, TBL_URUN_STOKDTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_URUN_STOK"/> converted from <see cref="TBL_URUN_STOKDTO"/>.</param>
		static partial void OnEntity(this TBL_URUN_STOKDTO dto, TBL_URUN_STOK  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_URUN_STOKDTO"/> to an instance of <see cref="TBL_URUN_STOK"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_URUN_STOKDTO"/> to convert.</param>
         public static TBL_URUN_STOK    ToEntity(this TBL_URUN_STOKDTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_URUN_STOK(); 
          		           		  entity.TBL_URUN_STOK_ID=dto.TBL_URUN_STOK_ID;
		  		           		  entity.TBL_URUN_ID=dto.TBL_URUN_ID;
		  		           		  entity.TBL_DEPO_ID=dto.TBL_DEPO_ID;
		  		           		  entity.URUN_BIRIM_MIKTARI=dto.URUN_BIRIM_MIKTARI;
		  		           		  entity.STOK_DURUM=dto.STOK_DURUM;
		  		           		  entity.ACIKLAMA=dto.ACIKLAMA;
		  		           		  entity.YEDEK=dto.YEDEK;
		  		           		           
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_URUN_STOK"/> to an instance of <see cref="TBL_URUN_STOKDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_URUN_STOK"/> to convert.</param>
		  public static TBL_URUN_STOKDTO ToDTO(this TBL_URUN_STOK entity)
        {
            if (entity == null) return null;

            var dto = new TBL_URUN_STOKDTO();

            
 //EdmProperty

                         		  dto.TBL_URUN_STOK_ID=entity.TBL_URUN_STOK_ID;
		                		  dto.TBL_URUN_ID=entity.TBL_URUN_ID;
		                		  dto.TBL_DEPO_ID=entity.TBL_DEPO_ID;
		                		  dto.URUN_BIRIM_MIKTARI=entity.URUN_BIRIM_MIKTARI;
		                		  dto.STOK_DURUM=entity.STOK_DURUM;
		                		  dto.ACIKLAMA=entity.ACIKLAMA;
		                		  dto.YEDEK=entity.YEDEK;
		                              
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_URUN_STOKDTO"/> to an instance of <see cref=TBL_URUN_STOK"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_URUN_STOK> ToEntities(this IEnumerable<TBL_URUN_STOKDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_URUN_STOK"/> to an instance of <see cref="TBL_URUN_STOKDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_URUN_STOKDTO> ToDTOs(this IEnumerable<TBL_URUN_STOK> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}





