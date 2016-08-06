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
    /// Assembler for <see cref="TBL_URUN_SPARIS "/> and <see cref="TBL_URUN_SPARISDTO"/>.
    /// </summary>
	public  static partial class  TBL_URUN_SPARISMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_URUN_SPARISDTO"/> converted from <see cref="TBL_URUN_SPARIS"/>.</param>
		static partial void OnDTO(this TBL_URUN_SPARIS entity, TBL_URUN_SPARISDTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_URUN_SPARIS"/> converted from <see cref="TBL_URUN_SPARISDTO"/>.</param>
		static partial void OnEntity(this TBL_URUN_SPARISDTO dto, TBL_URUN_SPARIS  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_URUN_SPARISDTO"/> to an instance of <see cref="TBL_URUN_SPARIS"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_URUN_SPARISDTO"/> to convert.</param>
         public static TBL_URUN_SPARIS    ToEntity(this TBL_URUN_SPARISDTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_URUN_SPARIS(); 
          		           		  entity.TBL_URUN_SPARIS_ID=dto.TBL_URUN_SPARIS_ID;
		  		           		  entity.TBL_URUN_ID=dto.TBL_URUN_ID;
		  		           		  entity.TBL_SIPARIS_ID=dto.TBL_SIPARIS_ID;
		  		           		  entity.URUN_SIPARIS_MIKTAR=dto.URUN_SIPARIS_MIKTAR;
		  		           		  entity.ACIKLAMA=dto.ACIKLAMA;
		  		           		  entity.YEDEK=dto.YEDEK;
		  		           		           
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_URUN_SPARIS"/> to an instance of <see cref="TBL_URUN_SPARISDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_URUN_SPARIS"/> to convert.</param>
		  public static TBL_URUN_SPARISDTO ToDTO(this TBL_URUN_SPARIS entity)
        {
            if (entity == null) return null;

            var dto = new TBL_URUN_SPARISDTO();

            
 //EdmProperty

                         		  dto.TBL_URUN_SPARIS_ID=entity.TBL_URUN_SPARIS_ID;
		                		  dto.TBL_URUN_ID=entity.TBL_URUN_ID;
		                		  dto.TBL_SIPARIS_ID=entity.TBL_SIPARIS_ID;
		                		  dto.URUN_SIPARIS_MIKTAR=entity.URUN_SIPARIS_MIKTAR;
		                		  dto.ACIKLAMA=entity.ACIKLAMA;
		                		  dto.YEDEK=entity.YEDEK;
		                              
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_URUN_SPARISDTO"/> to an instance of <see cref=TBL_URUN_SPARIS"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_URUN_SPARIS> ToEntities(this IEnumerable<TBL_URUN_SPARISDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_URUN_SPARIS"/> to an instance of <see cref="TBL_URUN_SPARISDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_URUN_SPARISDTO> ToDTOs(this IEnumerable<TBL_URUN_SPARIS> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}





