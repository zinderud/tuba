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
    /// Assembler for <see cref="TBL_URUN_CINSI "/> and <see cref="TBL_URUN_CINSIDTO"/>.
    /// </summary>
	public  static partial class  TBL_URUN_CINSIMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_URUN_CINSIDTO"/> converted from <see cref="TBL_URUN_CINSI_MODEL"/>.</param>
		static partial void OnDTO(this TBL_URUN_CINSI_MODEL entity, TBL_URUN_CINSIDTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_URUN_CINSI_MODEL"/> converted from <see cref="TBL_URUN_CINSIDTO"/>.</param>
		static partial void OnEntity(this TBL_URUN_CINSIDTO dto, TBL_URUN_CINSI_MODEL  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_URUN_CINSIDTO"/> to an instance of <see cref="TBL_URUN_CINSI"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_URUN_CINSIDTO"/> to convert.</param>
         public static TBL_URUN_CINSI_MODEL    ToEntity(this TBL_URUN_CINSIDTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_URUN_CINSI_MODEL(); 
               		  entity.TBL_URUN_CINSI_ID=dto.TBL_URUN_CINSI_ID;
		       		  entity.TBL_URUN_TIPI_ID=dto.TBL_URUN_TIPI_ID;
		       		  entity.URUN_CINSI_ADI=dto.URUN_CINSI_ADI;
		       		  entity.URUN_CINSI_ACIKLAMA=dto.URUN_CINSI_ACIKLAMA;
		       		  entity.YEDEK=dto.YEDEK;
		                 
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_URUN_CINSI_MODEL"/> to an instance of <see cref="TBL_URUN_CINSIDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_URUN_CINSI"/> to convert.</param>
		  public static TBL_URUN_CINSIDTO ToDTO(this TBL_URUN_CINSI_MODEL entity)
        {
            if (entity == null) return null;

            var dto = new TBL_URUN_CINSIDTO();

            
                 		  dto.TBL_URUN_CINSI_ID=entity.TBL_URUN_CINSI_ID;
		        		  dto.TBL_URUN_TIPI_ID=entity.TBL_URUN_TIPI_ID;
		        		  dto.URUN_CINSI_ADI=entity.URUN_CINSI_ADI;
		        		  dto.URUN_CINSI_ACIKLAMA=entity.URUN_CINSI_ACIKLAMA;
		        		  dto.YEDEK=entity.YEDEK;
		                    
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_URUN_CINSIDTO"/> to an instance of <see cref=TBL_URUN_CINSI"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_URUN_CINSI_MODEL> ToEntities(this IEnumerable<TBL_URUN_CINSIDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_URUN_CINSI_MODEL"/> to an instance of <see cref="TBL_URUN_CINSIDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_URUN_CINSIDTO> ToDTOs(this IEnumerable<TBL_URUN_CINSI_MODEL> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}
