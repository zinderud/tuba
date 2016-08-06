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
    /// Assembler for <see cref="TBL_URUN_BIRIM "/> and <see cref="TBL_URUN_BIRIMDTO"/>.
    /// </summary>
	public  static partial class  TBL_URUN_BIRIMMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_URUN_BIRIMDTO"/> converted from <see cref="TBL_URUN_BIRIM_MODEL"/>.</param>
		static partial void OnDTO(this TBL_URUN_BIRIM_MODEL entity, TBL_URUN_BIRIMDTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_URUN_BIRIM_MODEL"/> converted from <see cref="TBL_URUN_BIRIMDTO"/>.</param>
		static partial void OnEntity(this TBL_URUN_BIRIMDTO dto, TBL_URUN_BIRIM_MODEL  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_URUN_BIRIMDTO"/> to an instance of <see cref="TBL_URUN_BIRIM"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_URUN_BIRIMDTO"/> to convert.</param>
         public static TBL_URUN_BIRIM_MODEL    ToEntity(this TBL_URUN_BIRIMDTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_URUN_BIRIM_MODEL(); 
               		  entity.TBL_URUN_BIRIM_ID=dto.TBL_URUN_BIRIM_ID;
		       		  entity.URUN_BIRIM_ADI=dto.URUN_BIRIM_ADI;
		       		  entity.URUN_BIRIM_ACIKLAMA=dto.URUN_BIRIM_ACIKLAMA;
		       		  entity.YEDEK=dto.YEDEK;
		       
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_URUN_BIRIM_MODEL"/> to an instance of <see cref="TBL_URUN_BIRIMDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_URUN_BIRIM"/> to convert.</param>
		  public static TBL_URUN_BIRIMDTO ToDTO(this TBL_URUN_BIRIM_MODEL entity)
        {
            if (entity == null) return null;

            var dto = new TBL_URUN_BIRIMDTO();

            
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
		 public static List<TBL_URUN_BIRIM_MODEL> ToEntities(this IEnumerable<TBL_URUN_BIRIMDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_URUN_BIRIM_MODEL"/> to an instance of <see cref="TBL_URUN_BIRIMDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_URUN_BIRIMDTO> ToDTOs(this IEnumerable<TBL_URUN_BIRIM_MODEL> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}
