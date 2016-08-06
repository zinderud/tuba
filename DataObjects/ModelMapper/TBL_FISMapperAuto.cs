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
    /// Assembler for <see cref="TBL_FIS "/> and <see cref="TBL_FISDTO"/>.
    /// </summary>
	public  static partial class  TBL_FISMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_FISDTO"/> converted from <see cref="TBL_FIS"/>.</param>
		static partial void OnDTO(this TBL_FIS entity, TBL_FISDTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_FIS"/> converted from <see cref="TBL_FISDTO"/>.</param>
		static partial void OnEntity(this TBL_FISDTO dto, TBL_FIS  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_FISDTO"/> to an instance of <see cref="TBL_FIS"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_FISDTO"/> to convert.</param>
         public static TBL_FIS    ToEntity(this TBL_FISDTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_FIS(); 
          		           		  entity.TBL_FIS_ID=dto.TBL_FIS_ID;
		  		           		  entity.ACIKLAMA=dto.ACIKLAMA;
		  		           		  entity.YEDEK=dto.YEDEK;
		  		           		           		           		           
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_FIS"/> to an instance of <see cref="TBL_FISDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_FIS"/> to convert.</param>
		  public static TBL_FISDTO ToDTO(this TBL_FIS entity)
        {
            if (entity == null) return null;

            var dto = new TBL_FISDTO();

            
 //EdmProperty

                         		  dto.TBL_FIS_ID=entity.TBL_FIS_ID;
		                		  dto.ACIKLAMA=entity.ACIKLAMA;
		                		  dto.YEDEK=entity.YEDEK;
		                                                          
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_FISDTO"/> to an instance of <see cref=TBL_FIS"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_FIS> ToEntities(this IEnumerable<TBL_FISDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_FIS"/> to an instance of <see cref="TBL_FISDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_FISDTO> ToDTOs(this IEnumerable<TBL_FIS> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}





