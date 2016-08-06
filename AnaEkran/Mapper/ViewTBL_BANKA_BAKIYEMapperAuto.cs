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
    /// Assembler for <see cref="TBL_BANKA_BAKIYE "/> and <see cref="TBL_BANKA_BAKIYEDTO"/>.
    /// </summary>
	public  static partial class  TBL_BANKA_BAKIYEMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_BANKA_BAKIYEDTO"/> converted from <see cref="TBL_BANKA_BAKIYE_MODEL"/>.</param>
		static partial void OnDTO(this TBL_BANKA_BAKIYE_MODEL entity, TBL_BANKA_BAKIYEDTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_BANKA_BAKIYE_MODEL"/> converted from <see cref="TBL_BANKA_BAKIYEDTO"/>.</param>
		static partial void OnEntity(this TBL_BANKA_BAKIYEDTO dto, TBL_BANKA_BAKIYE_MODEL  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_BANKA_BAKIYEDTO"/> to an instance of <see cref="TBL_BANKA_BAKIYE"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_BANKA_BAKIYEDTO"/> to convert.</param>
         public static TBL_BANKA_BAKIYE_MODEL    ToEntity(this TBL_BANKA_BAKIYEDTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_BANKA_BAKIYE_MODEL(); 
               		  entity.TBL_BANKA_BAKIYE_ID=dto.TBL_BANKA_BAKIYE_ID;
		       		  entity.TBL_BANKA_ID=dto.TBL_BANKA_ID;
		       		  entity.TBL_PARA_TIPI_ID=dto.TBL_PARA_TIPI_ID;
		       		  entity.TBL_FIS_ID=dto.TBL_FIS_ID;
		       		  entity.KUR=dto.KUR;
		       		  entity.TARIH=dto.TARIH;
		       		  entity.TUTAR=dto.TUTAR;
		       		  entity.ACIKLAMA=dto.ACIKLAMA;
		       		  entity.YEDEK=dto.YEDEK;
		                 
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_BANKA_BAKIYE_MODEL"/> to an instance of <see cref="TBL_BANKA_BAKIYEDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_BANKA_BAKIYE"/> to convert.</param>
		  public static TBL_BANKA_BAKIYEDTO ToDTO(this TBL_BANKA_BAKIYE_MODEL entity)
        {
            if (entity == null) return null;

            var dto = new TBL_BANKA_BAKIYEDTO();

            
                 		  dto.TBL_BANKA_BAKIYE_ID=entity.TBL_BANKA_BAKIYE_ID;
		        		  dto.TBL_BANKA_ID=entity.TBL_BANKA_ID;
		        		  dto.TBL_PARA_TIPI_ID=entity.TBL_PARA_TIPI_ID;
		        		  dto.TBL_FIS_ID=entity.TBL_FIS_ID;
		        		  dto.KUR=entity.KUR;
		        		  dto.TARIH=entity.TARIH;
		        		  dto.TUTAR=entity.TUTAR;
		        		  dto.ACIKLAMA=entity.ACIKLAMA;
		        		  dto.YEDEK=entity.YEDEK;
		                    
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_BANKA_BAKIYEDTO"/> to an instance of <see cref=TBL_BANKA_BAKIYE"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_BANKA_BAKIYE_MODEL> ToEntities(this IEnumerable<TBL_BANKA_BAKIYEDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_BANKA_BAKIYE_MODEL"/> to an instance of <see cref="TBL_BANKA_BAKIYEDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_BANKA_BAKIYEDTO> ToDTOs(this IEnumerable<TBL_BANKA_BAKIYE_MODEL> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}
