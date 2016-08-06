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
    /// Assembler for <see cref="TBL_DEPO "/> and <see cref="TBL_DEPODTO"/>.
    /// </summary>
	public  static partial class  TBL_DEPOMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_DEPODTO"/> converted from <see cref="TBL_DEPO_MODEL"/>.</param>
		static partial void OnDTO(this TBL_DEPO_MODEL entity, TBL_DEPODTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_DEPO_MODEL"/> converted from <see cref="TBL_DEPODTO"/>.</param>
		static partial void OnEntity(this TBL_DEPODTO dto, TBL_DEPO_MODEL  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_DEPODTO"/> to an instance of <see cref="TBL_DEPO"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_DEPODTO"/> to convert.</param>
         public static TBL_DEPO_MODEL    ToEntity(this TBL_DEPODTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_DEPO_MODEL(); 
               		  entity.TBL_DEPO_ID=dto.TBL_DEPO_ID;
		       		  entity.DEPO_ADI=dto.DEPO_ADI;
		       		  entity.DEPO_ACIKLAMA=dto.DEPO_ACIKLAMA;
		       		  entity.YEDEK=dto.YEDEK;
		                      
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_DEPO_MODEL"/> to an instance of <see cref="TBL_DEPODTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_DEPO"/> to convert.</param>
		  public static TBL_DEPODTO ToDTO(this TBL_DEPO_MODEL entity)
        {
            if (entity == null) return null;

            var dto = new TBL_DEPODTO();

            
                 		  dto.TBL_DEPO_ID=entity.TBL_DEPO_ID;
		        		  dto.DEPO_ADI=entity.DEPO_ADI;
		        		  dto.DEPO_ACIKLAMA=entity.DEPO_ACIKLAMA;
		        		  dto.YEDEK=entity.YEDEK;
		                          
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_DEPODTO"/> to an instance of <see cref=TBL_DEPO"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_DEPO_MODEL> ToEntities(this IEnumerable<TBL_DEPODTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_DEPO_MODEL"/> to an instance of <see cref="TBL_DEPODTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_DEPODTO> ToDTOs(this IEnumerable<TBL_DEPO_MODEL> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}
