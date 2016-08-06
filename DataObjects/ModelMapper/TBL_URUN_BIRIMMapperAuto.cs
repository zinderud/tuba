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
    /// Assembler for <see cref="TBL_URUN_BIRIM "/> and <see cref="TBL_URUN_BIRIMDTO"/>.
    /// </summary>
	public  static partial class  TBL_URUN_BIRIMMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_URUN_BIRIMDTO"/> converted from <see cref="TBL_URUN_BIRIM"/>.</param>
		static partial void OnDTO(this TBL_URUN_BIRIM entity, TBL_URUN_BIRIMDTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_URUN_BIRIM"/> converted from <see cref="TBL_URUN_BIRIMDTO"/>.</param>
		static partial void OnEntity(this TBL_URUN_BIRIMDTO dto, TBL_URUN_BIRIM  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_URUN_BIRIMDTO"/> to an instance of <see cref="TBL_URUN_BIRIM"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_URUN_BIRIMDTO"/> to convert.</param>
         public static TBL_URUN_BIRIM    ToEntity(this TBL_URUN_BIRIMDTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_URUN_BIRIM(); 
          		           		  entity.TBL_URUN_BIRIM_ID=dto.TBL_URUN_BIRIM_ID;
		  		           		  entity.URUN_BIRIM_ADI=dto.URUN_BIRIM_ADI;
		  		           		  entity.URUN_BIRIM_ACIKLAMA=dto.URUN_BIRIM_ACIKLAMA;
		  		           		  entity.YEDEK=dto.YEDEK;
		  		           
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_URUN_BIRIM"/> to an instance of <see cref="TBL_URUN_BIRIMDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_URUN_BIRIM"/> to convert.</param>
		  public static TBL_URUN_BIRIMDTO ToDTO(this TBL_URUN_BIRIM entity)
        {
            if (entity == null) return null;

            var dto = new TBL_URUN_BIRIMDTO();

            
 //EdmProperty

                         		  dto.TBL_URUN_BIRIM_ID=entity.TBL_URUN_BIRIM_ID;
		                		  dto.URUN_BIRIM_ADI=entity.URUN_BIRIM_ADI;
		                		  dto.URUN_BIRIM_ACIKLAMA=entity.URUN_BIRIM_ACIKLAMA;
		                		  dto.YEDEK=entity.YEDEK;
		                
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_URUN_BIRIMDTO"/> to an instance of <see cref=TBL_URUN_BIRIM"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_URUN_BIRIM> ToEntities(this IEnumerable<TBL_URUN_BIRIMDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_URUN_BIRIM"/> to an instance of <see cref="TBL_URUN_BIRIMDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_URUN_BIRIMDTO> ToDTOs(this IEnumerable<TBL_URUN_BIRIM> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}





