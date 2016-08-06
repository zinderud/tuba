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
    /// Assembler for <see cref="TBL_URUN_MARKA "/> and <see cref="TBL_URUN_MARKADTO"/>.
    /// </summary>
	public  static partial class  TBL_URUN_MARKAMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_URUN_MARKADTO"/> converted from <see cref="TBL_URUN_MARKA"/>.</param>
		static partial void OnDTO(this TBL_URUN_MARKA entity, TBL_URUN_MARKADTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_URUN_MARKA"/> converted from <see cref="TBL_URUN_MARKADTO"/>.</param>
		static partial void OnEntity(this TBL_URUN_MARKADTO dto, TBL_URUN_MARKA  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_URUN_MARKADTO"/> to an instance of <see cref="TBL_URUN_MARKA"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_URUN_MARKADTO"/> to convert.</param>
         public static TBL_URUN_MARKA    ToEntity(this TBL_URUN_MARKADTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_URUN_MARKA(); 
          		           		  entity.TBL_URUN_MARKA_ID=dto.TBL_URUN_MARKA_ID;
		  		           		  entity.TBL_URUN_TIPI_ID=dto.TBL_URUN_TIPI_ID;
		  		           		  entity.TBL_URUN_CINSI_ID=dto.TBL_URUN_CINSI_ID;
		  		           		  entity.URUN_MARKA_ADI=dto.URUN_MARKA_ADI;
		  		           		  entity.URUN_MARKA_ACIKLAMA=dto.URUN_MARKA_ACIKLAMA;
		  		           		  entity.YEDEK=dto.YEDEK;
		  		           		           		           
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_URUN_MARKA"/> to an instance of <see cref="TBL_URUN_MARKADTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_URUN_MARKA"/> to convert.</param>
		  public static TBL_URUN_MARKADTO ToDTO(this TBL_URUN_MARKA entity)
        {
            if (entity == null) return null;

            var dto = new TBL_URUN_MARKADTO();

            
 //EdmProperty

                         		  dto.TBL_URUN_MARKA_ID=entity.TBL_URUN_MARKA_ID;
		                		  dto.TBL_URUN_TIPI_ID=entity.TBL_URUN_TIPI_ID;
		                		  dto.TBL_URUN_CINSI_ID=entity.TBL_URUN_CINSI_ID;
		                		  dto.URUN_MARKA_ADI=entity.URUN_MARKA_ADI;
		                		  dto.URUN_MARKA_ACIKLAMA=entity.URUN_MARKA_ACIKLAMA;
		                		  dto.YEDEK=entity.YEDEK;
		                                            
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_URUN_MARKADTO"/> to an instance of <see cref=TBL_URUN_MARKA"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_URUN_MARKA> ToEntities(this IEnumerable<TBL_URUN_MARKADTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_URUN_MARKA"/> to an instance of <see cref="TBL_URUN_MARKADTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_URUN_MARKADTO> ToDTOs(this IEnumerable<TBL_URUN_MARKA> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}





