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
    /// Assembler for <see cref="TBL_SIRKET_GRUB "/> and <see cref="TBL_SIRKET_GRUBDTO"/>.
    /// </summary>
	public  static partial class  TBL_SIRKET_GRUBMaping   
    {
		/// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="TBL_SIRKET_GRUBDTO"/> converted from <see cref="TBL_SIRKET_GRUB"/>.</param>
		static partial void OnDTO(this TBL_SIRKET_GRUB entity, TBL_SIRKET_GRUBDTO dto);
		/// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="TBL_SIRKET_GRUB"/> converted from <see cref="TBL_SIRKET_GRUBDTO"/>.</param>
		static partial void OnEntity(this TBL_SIRKET_GRUBDTO dto, TBL_SIRKET_GRUB  entity);
		/// <summary>
        /// Converts this instance of <see cref="TBL_SIRKET_GRUBDTO"/> to an instance of <see cref="TBL_SIRKET_GRUB"/>.
        /// </summary>
        /// <param name="dto"><see cref="TBL_SIRKET_GRUBDTO"/> to convert.</param>
         public static TBL_SIRKET_GRUB    ToEntity(this TBL_SIRKET_GRUBDTO dto)
        {
            if (dto == null) return null; 
            var entity = new TBL_SIRKET_GRUB(); 
          		           		  entity.TBL_SIRKET_GRUB_ID=dto.TBL_SIRKET_GRUB_ID;
		  		           		  entity.SIRKET_GRUP_ADI=dto.SIRKET_GRUP_ADI;
		  		           		  entity.ACIKLAMA=dto.ACIKLAMA;
		  		           		  entity.YEDEK=dto.YEDEK;
		  		           
            dto.OnEntity(entity);

            return entity;
        }
		/// <summary>
        /// Converts this instance of <see cref="TBL_SIRKET_GRUB"/> to an instance of <see cref="TBL_SIRKET_GRUBDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="TBL_SIRKET_GRUB"/> to convert.</param>
		  public static TBL_SIRKET_GRUBDTO ToDTO(this TBL_SIRKET_GRUB entity)
        {
            if (entity == null) return null;

            var dto = new TBL_SIRKET_GRUBDTO();

            
 //EdmProperty

                         		  dto.TBL_SIRKET_GRUB_ID=entity.TBL_SIRKET_GRUB_ID;
		                		  dto.SIRKET_GRUP_ADI=entity.SIRKET_GRUP_ADI;
		                		  dto.ACIKLAMA=entity.ACIKLAMA;
		                		  dto.YEDEK=entity.YEDEK;
		                
            entity.OnDTO(dto);

            return dto;
        }
		//
		 
		//
		//

		/// <summary>
        /// Converts each instance of <see cref="TBL_SIRKET_GRUBDTO"/> to an instance of <see cref=TBL_SIRKET_GRUB"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
		 public static List<TBL_SIRKET_GRUB> ToEntities(this IEnumerable<TBL_SIRKET_GRUBDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }
		 /// <summary>
        /// Converts each instance of <see cref="TBL_SIRKET_GRUB"/> to an instance of <see cref="TBL_SIRKET_GRUBDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
		 public static List<TBL_SIRKET_GRUBDTO> ToDTOs(this IEnumerable<TBL_SIRKET_GRUB> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }
         
	}
}





