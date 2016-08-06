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
    /// Assembler for <see cref="TBL_KDV "/> and <see cref="TBL_KDVDTO"/>.
    /// </summary>
	public  static partial class  TBL_KDVMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_KDVDTO"/> converted from <see cref="TBL_KDV"/>.</param>
		static partial void OnDTO(this TBL_KDV entity, TBL_KDVDTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_KDV"/> converted from <see cref="TBL_KDVDTO"/>.</param>
		static partial void OnEntity(this TBL_KDVDTO dto, TBL_KDV  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_KDVDTO"/> to an instance of <see cref="TBL_KDV"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_KDVDTO"/> to convert.</param>
         public static TBL_KDV    ToEntity(this TBL_KDVDTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_KDV(); 
          		           		  entity.TBL_KDV_ID=dto.TBL_KDV_ID;
		  		           		  entity.KDV_YUZDESI=dto.KDV_YUZDESI;
		  		           		  entity.KDV_ACIKLAMA=dto.KDV_ACIKLAMA;
		  		           		  entity.YEDEK=dto.YEDEK;
		  		           
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_KDV"/> to an instance of <see cref="TBL_KDVDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_KDV"/> to convert.</param>
		  public static TBL_KDVDTO ToDTO(this TBL_KDV entity)
        {
            if (entity == null) return null;

            var dto = new TBL_KDVDTO();

            
 //EdmProperty

                         		  dto.TBL_KDV_ID=entity.TBL_KDV_ID;
		                		  dto.KDV_YUZDESI=entity.KDV_YUZDESI;
		                		  dto.KDV_ACIKLAMA=entity.KDV_ACIKLAMA;
		                		  dto.YEDEK=entity.YEDEK;
		                
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_KDVDTO"/> to an instance of <see cref=TBL_KDV"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_KDV> ToEntities(this IEnumerable<TBL_KDVDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_KDV"/> to an instance of <see cref="TBL_KDVDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_KDVDTO> ToDTOs(this IEnumerable<TBL_KDV> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}





