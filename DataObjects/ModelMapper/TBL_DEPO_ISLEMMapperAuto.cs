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
    /// Assembler for <see cref="TBL_DEPO_ISLEM "/> and <see cref="TBL_DEPO_ISLEMDTO"/>.
    /// </summary>
	public  static partial class  TBL_DEPO_ISLEMMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_DEPO_ISLEMDTO"/> converted from <see cref="TBL_DEPO_ISLEM"/>.</param>
		static partial void OnDTO(this TBL_DEPO_ISLEM entity, TBL_DEPO_ISLEMDTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_DEPO_ISLEM"/> converted from <see cref="TBL_DEPO_ISLEMDTO"/>.</param>
		static partial void OnEntity(this TBL_DEPO_ISLEMDTO dto, TBL_DEPO_ISLEM  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_DEPO_ISLEMDTO"/> to an instance of <see cref="TBL_DEPO_ISLEM"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_DEPO_ISLEMDTO"/> to convert.</param>
         public static TBL_DEPO_ISLEM    ToEntity(this TBL_DEPO_ISLEMDTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_DEPO_ISLEM(); 
          		           		  entity.TBL_DEPO_ISLEM_ID=dto.TBL_DEPO_ISLEM_ID;
		  		           		  entity.TBL_DEPO_ID=dto.TBL_DEPO_ID;
		  		           		  entity.TBL_URUN_ID=dto.TBL_URUN_ID;
		  		           		  entity.DEPO_ISLEM_ADI=dto.DEPO_ISLEM_ADI;
		  		           		  entity.URUN_MIKTAR=dto.URUN_MIKTAR;
		  		           		  entity.DEPO_ONAY=dto.DEPO_ONAY;
		  		           		  entity.ACIKLAMA=dto.ACIKLAMA;
		  		           		  entity.YEDEK=dto.YEDEK;
		  		           		           
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_DEPO_ISLEM"/> to an instance of <see cref="TBL_DEPO_ISLEMDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_DEPO_ISLEM"/> to convert.</param>
		  public static TBL_DEPO_ISLEMDTO ToDTO(this TBL_DEPO_ISLEM entity)
        {
            if (entity == null) return null;

            var dto = new TBL_DEPO_ISLEMDTO();

            
 //EdmProperty

                         		  dto.TBL_DEPO_ISLEM_ID=entity.TBL_DEPO_ISLEM_ID;
		                		  dto.TBL_DEPO_ID=entity.TBL_DEPO_ID;
		                		  dto.TBL_URUN_ID=entity.TBL_URUN_ID;
		                		  dto.DEPO_ISLEM_ADI=entity.DEPO_ISLEM_ADI;
		                		  dto.URUN_MIKTAR=entity.URUN_MIKTAR;
		                		  dto.DEPO_ONAY=entity.DEPO_ONAY;
		                		  dto.ACIKLAMA=entity.ACIKLAMA;
		                		  dto.YEDEK=entity.YEDEK;
		                              
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_DEPO_ISLEMDTO"/> to an instance of <see cref=TBL_DEPO_ISLEM"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_DEPO_ISLEM> ToEntities(this IEnumerable<TBL_DEPO_ISLEMDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_DEPO_ISLEM"/> to an instance of <see cref="TBL_DEPO_ISLEMDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_DEPO_ISLEMDTO> ToDTOs(this IEnumerable<TBL_DEPO_ISLEM> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}





