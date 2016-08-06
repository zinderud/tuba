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
    /// Assembler for <see cref="TBL_DEPO_TRANSFER "/> and <see cref="TBL_DEPO_TRANSFERDTO"/>.
    /// </summary>
	public  static partial class  TBL_DEPO_TRANSFERMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_DEPO_TRANSFERDTO"/> converted from <see cref="TBL_DEPO_TRANSFER"/>.</param>
		static partial void OnDTO(this TBL_DEPO_TRANSFER entity, TBL_DEPO_TRANSFERDTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_DEPO_TRANSFER"/> converted from <see cref="TBL_DEPO_TRANSFERDTO"/>.</param>
		static partial void OnEntity(this TBL_DEPO_TRANSFERDTO dto, TBL_DEPO_TRANSFER  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_DEPO_TRANSFERDTO"/> to an instance of <see cref="TBL_DEPO_TRANSFER"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_DEPO_TRANSFERDTO"/> to convert.</param>
         public static TBL_DEPO_TRANSFER    ToEntity(this TBL_DEPO_TRANSFERDTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_DEPO_TRANSFER(); 
          		           		  entity.TBL_DEPO_TRANSFER_ID=dto.TBL_DEPO_TRANSFER_ID;
		  		           		  entity.DEPO_TRANSFER_ADI=dto.DEPO_TRANSFER_ADI;
		  		           		  entity.DEPO_TRANSFER_TARIHI=dto.DEPO_TRANSFER_TARIHI;
		  		           		  entity.DEPO_TRANSFER_NEREDEN=dto.DEPO_TRANSFER_NEREDEN;
		  		           		  entity.DEPO_TRANSFER_NEREYE=dto.DEPO_TRANSFER_NEREYE;
		  		           		  entity.TBL_URUN_ID=dto.TBL_URUN_ID;
		  		           		  entity.DEPO_TRANSFER_ACIKLAMA=dto.DEPO_TRANSFER_ACIKLAMA;
		  		           		  entity.YEDEK=dto.YEDEK;
		  		           
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_DEPO_TRANSFER"/> to an instance of <see cref="TBL_DEPO_TRANSFERDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_DEPO_TRANSFER"/> to convert.</param>
		  public static TBL_DEPO_TRANSFERDTO ToDTO(this TBL_DEPO_TRANSFER entity)
        {
            if (entity == null) return null;

            var dto = new TBL_DEPO_TRANSFERDTO();

            
 //EdmProperty

                         		  dto.TBL_DEPO_TRANSFER_ID=entity.TBL_DEPO_TRANSFER_ID;
		                		  dto.DEPO_TRANSFER_ADI=entity.DEPO_TRANSFER_ADI;
		                		  dto.DEPO_TRANSFER_TARIHI=entity.DEPO_TRANSFER_TARIHI;
		                		  dto.DEPO_TRANSFER_NEREDEN=entity.DEPO_TRANSFER_NEREDEN;
		                		  dto.DEPO_TRANSFER_NEREYE=entity.DEPO_TRANSFER_NEREYE;
		                		  dto.TBL_URUN_ID=entity.TBL_URUN_ID;
		                		  dto.DEPO_TRANSFER_ACIKLAMA=entity.DEPO_TRANSFER_ACIKLAMA;
		                		  dto.YEDEK=entity.YEDEK;
		                
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_DEPO_TRANSFERDTO"/> to an instance of <see cref=TBL_DEPO_TRANSFER"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_DEPO_TRANSFER> ToEntities(this IEnumerable<TBL_DEPO_TRANSFERDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_DEPO_TRANSFER"/> to an instance of <see cref="TBL_DEPO_TRANSFERDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_DEPO_TRANSFERDTO> ToDTOs(this IEnumerable<TBL_DEPO_TRANSFER> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}





