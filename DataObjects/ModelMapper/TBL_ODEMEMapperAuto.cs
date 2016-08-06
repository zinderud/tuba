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
    /// Assembler for <see cref="TBL_ODEME "/> and <see cref="TBL_ODEMEDTO"/>.
    /// </summary>
	public  static partial class  TBL_ODEMEMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_ODEMEDTO"/> converted from <see cref="TBL_ODEME"/>.</param>
		static partial void OnDTO(this TBL_ODEME entity, TBL_ODEMEDTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_ODEME"/> converted from <see cref="TBL_ODEMEDTO"/>.</param>
		static partial void OnEntity(this TBL_ODEMEDTO dto, TBL_ODEME  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_ODEMEDTO"/> to an instance of <see cref="TBL_ODEME"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_ODEMEDTO"/> to convert.</param>
         public static TBL_ODEME    ToEntity(this TBL_ODEMEDTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_ODEME(); 
          		           		  entity.TBL_ODEME_ID=dto.TBL_ODEME_ID;
		  		           		  entity.ODEME_KAYIT_TARIHI=dto.ODEME_KAYIT_TARIHI;
		  		           		  entity.ODEME_VADE_TARIHI=dto.ODEME_VADE_TARIHI;
		  		           		  entity.TBL_ODEME_TURU_ID=dto.TBL_ODEME_TURU_ID;
		  		           		  entity.TBL_ODEME_TIPI_ID=dto.TBL_ODEME_TIPI_ID;
		  		           		  entity.BELGE_NO=dto.BELGE_NO;
		  		           		  entity.TBL_SIRKET_ID=dto.TBL_SIRKET_ID;
		  		           		  entity.TUTAR=dto.TUTAR;
		  		           		  entity.TBL_PARA_TIPI_ID=dto.TBL_PARA_TIPI_ID;
		  		           		  entity.TBL_KASA_ID=dto.TBL_KASA_ID;
		  		           		  entity.YEDEK=dto.YEDEK;
		  		           		           		           		           		           
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_ODEME"/> to an instance of <see cref="TBL_ODEMEDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_ODEME"/> to convert.</param>
		  public static TBL_ODEMEDTO ToDTO(this TBL_ODEME entity)
        {
            if (entity == null) return null;

            var dto = new TBL_ODEMEDTO();

            
 //EdmProperty

                         		  dto.TBL_ODEME_ID=entity.TBL_ODEME_ID;
		                		  dto.ODEME_KAYIT_TARIHI=entity.ODEME_KAYIT_TARIHI;
		                		  dto.ODEME_VADE_TARIHI=entity.ODEME_VADE_TARIHI;
		                		  dto.TBL_ODEME_TURU_ID=entity.TBL_ODEME_TURU_ID;
		                		  dto.TBL_ODEME_TIPI_ID=entity.TBL_ODEME_TIPI_ID;
		                		  dto.BELGE_NO=entity.BELGE_NO;
		                		  dto.TBL_SIRKET_ID=entity.TBL_SIRKET_ID;
		                		  dto.TUTAR=entity.TUTAR;
		                		  dto.TBL_PARA_TIPI_ID=entity.TBL_PARA_TIPI_ID;
		                		  dto.TBL_KASA_ID=entity.TBL_KASA_ID;
		                		  dto.YEDEK=entity.YEDEK;
		                                                                        
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_ODEMEDTO"/> to an instance of <see cref=TBL_ODEME"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_ODEME> ToEntities(this IEnumerable<TBL_ODEMEDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_ODEME"/> to an instance of <see cref="TBL_ODEMEDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_ODEMEDTO> ToDTOs(this IEnumerable<TBL_ODEME> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}





