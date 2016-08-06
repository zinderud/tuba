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
    /// Assembler for <see cref="TBL_GIDER "/> and <see cref="TBL_GIDERDTO"/>.
    /// </summary>
	public  static partial class  TBL_GIDERMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_GIDERDTO"/> converted from <see cref="TBL_GIDER"/>.</param>
		static partial void OnDTO(this TBL_GIDER entity, TBL_GIDERDTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_GIDER"/> converted from <see cref="TBL_GIDERDTO"/>.</param>
		static partial void OnEntity(this TBL_GIDERDTO dto, TBL_GIDER  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_GIDERDTO"/> to an instance of <see cref="TBL_GIDER"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_GIDERDTO"/> to convert.</param>
         public static TBL_GIDER    ToEntity(this TBL_GIDERDTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_GIDER(); 
          		           		  entity.TBL_GIDER_ID=dto.TBL_GIDER_ID;
		  		           		  entity.TBL_PARA_TIPI_ID=dto.TBL_PARA_TIPI_ID;
		  		           		  entity.GİDER_ADI=dto.GİDER_ADI;
		  		           		  entity.GİDER_ACIKLAMA=dto.GİDER_ACIKLAMA;
		  		           		  entity.YEDEK=dto.YEDEK;
		  		           		           
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_GIDER"/> to an instance of <see cref="TBL_GIDERDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_GIDER"/> to convert.</param>
		  public static TBL_GIDERDTO ToDTO(this TBL_GIDER entity)
        {
            if (entity == null) return null;

            var dto = new TBL_GIDERDTO();

            
 //EdmProperty

                         		  dto.TBL_GIDER_ID=entity.TBL_GIDER_ID;
		                		  dto.TBL_PARA_TIPI_ID=entity.TBL_PARA_TIPI_ID;
		                		  dto.GİDER_ADI=entity.GİDER_ADI;
		                		  dto.GİDER_ACIKLAMA=entity.GİDER_ACIKLAMA;
		                		  dto.YEDEK=entity.YEDEK;
		                              
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_GIDERDTO"/> to an instance of <see cref=TBL_GIDER"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_GIDER> ToEntities(this IEnumerable<TBL_GIDERDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_GIDER"/> to an instance of <see cref="TBL_GIDERDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_GIDERDTO> ToDTOs(this IEnumerable<TBL_GIDER> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}





