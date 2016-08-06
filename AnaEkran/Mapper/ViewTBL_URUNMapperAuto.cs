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
    /// Assembler for <see cref="TBL_URUN "/> and <see cref="TBL_URUNDTO"/>.
    /// </summary>
	public  static partial class  TBL_URUNMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_URUNDTO"/> converted from <see cref="TBL_URUN_MODEL"/>.</param>
		static partial void OnDTO(this TBL_URUN_MODEL entity, TBL_URUNDTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_URUN_MODEL"/> converted from <see cref="TBL_URUNDTO"/>.</param>
		static partial void OnEntity(this TBL_URUNDTO dto, TBL_URUN_MODEL  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_URUNDTO"/> to an instance of <see cref="TBL_URUN"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_URUNDTO"/> to convert.</param>
         public static TBL_URUN_MODEL    ToEntity(this TBL_URUNDTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_URUN_MODEL(); 
               		  entity.TBL_URUN_ID=dto.TBL_URUN_ID;
		       		  entity.URUN_ADI=dto.URUN_ADI;
		       		  entity.URUN_KODU=dto.URUN_KODU;
		       		  entity.TBL_URUN_TIPI_ID=dto.TBL_URUN_TIPI_ID;
		       		  entity.TBL_URUN_CINSI_ID=dto.TBL_URUN_CINSI_ID;
		       		  entity.TBL_URUN_MARKA_ID=dto.TBL_URUN_MARKA_ID;
		       		  entity.TBL_URUN_BIRIM_ID=dto.TBL_URUN_BIRIM_ID;
		       		  entity.TBL_KDV_ID=dto.TBL_KDV_ID;
		       		  entity.URUN_DURUM=dto.URUN_DURUM;
		       		  entity.URUN_ALIS_FIYATI=dto.URUN_ALIS_FIYATI;
		       		  entity.URUN_SATIS_FIYATI=dto.URUN_SATIS_FIYATI;
		       		  entity.TBL_PARA_TIPI_ID=dto.TBL_PARA_TIPI_ID;
		       		  entity.YEDEK=dto.YEDEK;
		                                                         
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_URUN_MODEL"/> to an instance of <see cref="TBL_URUNDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_URUN"/> to convert.</param>
		  public static TBL_URUNDTO ToDTO(this TBL_URUN_MODEL entity)
        {
            if (entity == null) return null;

            var dto = new TBL_URUNDTO();

            
                 		  dto.TBL_URUN_ID=entity.TBL_URUN_ID;
		        		  dto.URUN_ADI=entity.URUN_ADI;
		        		  dto.URUN_KODU=entity.URUN_KODU;
		        		  dto.TBL_URUN_TIPI_ID=entity.TBL_URUN_TIPI_ID;
		        		  dto.TBL_URUN_CINSI_ID=entity.TBL_URUN_CINSI_ID;
		        		  dto.TBL_URUN_MARKA_ID=entity.TBL_URUN_MARKA_ID;
		        		  dto.TBL_URUN_BIRIM_ID=entity.TBL_URUN_BIRIM_ID;
		        		  dto.TBL_KDV_ID=entity.TBL_KDV_ID;
		        		  dto.URUN_DURUM=entity.URUN_DURUM;
		        		  dto.URUN_ALIS_FIYATI=entity.URUN_ALIS_FIYATI;
		        		  dto.URUN_SATIS_FIYATI=entity.URUN_SATIS_FIYATI;
		        		  dto.TBL_PARA_TIPI_ID=entity.TBL_PARA_TIPI_ID;
		        		  dto.YEDEK=entity.YEDEK;
		                                                                    
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_URUNDTO"/> to an instance of <see cref=TBL_URUN"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_URUN_MODEL> ToEntities(this IEnumerable<TBL_URUNDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_URUN_MODEL"/> to an instance of <see cref="TBL_URUNDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_URUNDTO> ToDTOs(this IEnumerable<TBL_URUN_MODEL> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}
