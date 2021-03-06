﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateGoodIdentificationMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.GoodIdentificationMvo;
using Dddml.Wms.Domain.Product;

namespace Dddml.Wms.Domain.GoodIdentificationMvo
{

	public abstract class GoodIdentificationMvoCommandBase : IGoodIdentificationMvoCommand
	{
		public virtual ProductGoodIdentificationId ProductGoodIdentificationId { get; set; }


		ProductGoodIdentificationId IAggregateCommand<ProductGoodIdentificationId, long>.AggregateId
		{
			get
			{
				return this.ProductGoodIdentificationId;
			}
		}


		long IAggregateCommand<ProductGoodIdentificationId, long>.AggregateVersion
		{
			get
			{
				return this.ProductVersion;
			}
		}

		public virtual long ProductVersion { get; set; }

		public virtual string RequesterId { get; set; }

		public virtual string CommandId { get; set; }

        object ICommand.RequesterId
        {
            get { return this.RequesterId; }
            set { this.RequesterId = (string)value; }
        }

        string ICommand.CommandId
        {
            get { return this.CommandId; }
            set { this.CommandId = value; }
        }

		public virtual string IdValue { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string ProductProductTypeId { get; set; }

		public virtual string ProductPrimaryProductCategoryId { get; set; }

		public virtual string ProductManufacturerPartyId { get; set; }

		public virtual string ProductFacilityId { get; set; }

		public virtual DateTime? ProductIntroductionDate { get; set; }

		public virtual DateTime? ProductReleaseDate { get; set; }

		public virtual DateTime? ProductSupportDiscontinuationDate { get; set; }

		public virtual DateTime? ProductSalesDiscontinuationDate { get; set; }

		public virtual string ProductSalesDiscWhenNotAvail { get; set; }

		public virtual string ProductInternalName { get; set; }

		public virtual string ProductBrandName { get; set; }

		public virtual string ProductComments { get; set; }

		public virtual string ProductProductName { get; set; }

		public virtual string ProductDescription { get; set; }

		public virtual string ProductPriceDetailText { get; set; }

		public virtual string ProductSmallImageUrl { get; set; }

		public virtual string ProductMediumImageUrl { get; set; }

		public virtual string ProductLargeImageUrl { get; set; }

		public virtual string ProductDetailImageUrl { get; set; }

		public virtual string ProductOriginalImageUrl { get; set; }

		public virtual string ProductDetailScreen { get; set; }

		public virtual string ProductInventoryMessage { get; set; }

		public virtual string ProductInventoryItemTypeId { get; set; }

		public virtual string ProductRequireInventory { get; set; }

		public virtual string ProductQuantityUomId { get; set; }

		public virtual decimal? ProductQuantityIncluded { get; set; }

		public virtual long? ProductPiecesIncluded { get; set; }

		public virtual string ProductRequireAmount { get; set; }

		public virtual decimal? ProductFixedAmount { get; set; }

		public virtual string ProductAmountUomTypeId { get; set; }

		public virtual string ProductWeightUomId { get; set; }

		public virtual decimal? ProductShippingWeight { get; set; }

		public virtual decimal? ProductProductWeight { get; set; }

		public virtual string ProductHeightUomId { get; set; }

		public virtual decimal? ProductProductHeight { get; set; }

		public virtual decimal? ProductShippingHeight { get; set; }

		public virtual string ProductWidthUomId { get; set; }

		public virtual decimal? ProductProductWidth { get; set; }

		public virtual decimal? ProductShippingWidth { get; set; }

		public virtual string ProductDepthUomId { get; set; }

		public virtual decimal? ProductProductDepth { get; set; }

		public virtual decimal? ProductShippingDepth { get; set; }

		public virtual string ProductDiameterUomId { get; set; }

		public virtual decimal? ProductProductDiameter { get; set; }

		public virtual decimal? ProductProductRating { get; set; }

		public virtual string ProductRatingTypeEnum { get; set; }

		public virtual string ProductReturnable { get; set; }

		public virtual string ProductTaxable { get; set; }

		public virtual string ProductChargeShipping { get; set; }

		public virtual string ProductAutoCreateKeywords { get; set; }

		public virtual string ProductIncludeInPromotions { get; set; }

		public virtual string ProductIsVirtual { get; set; }

		public virtual string ProductIsVariant { get; set; }

		public virtual string ProductVirtualVariantMethodEnum { get; set; }

		public virtual string ProductInShippingBox { get; set; }

		public virtual string ProductDefaultShipmentBoxTypeId { get; set; }

		public virtual bool? ProductIsSerialNumbered { get; set; }

		public virtual bool? ProductIsManagedByLot { get; set; }

		public virtual string ProductAttributeSetId { get; set; }

		public virtual string ProductAttributeSetInstanceId { get; set; }

		public virtual string ProductCreatedBy { get; set; }

		public virtual DateTime? ProductCreatedAt { get; set; }

		public virtual string ProductUpdatedBy { get; set; }

		public virtual DateTime? ProductUpdatedAt { get; set; }

		public virtual bool? ProductActive { get; set; }


		// //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();


	}


	public class CreateGoodIdentificationMvo : GoodIdentificationMvoCommandBase, ICreateGoodIdentificationMvo
	{
		
		public CreateGoodIdentificationMvo ()
		{
		}


        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }
	}


	public class MergePatchGoodIdentificationMvo :GoodIdentificationMvoCommandBase, IMergePatchGoodIdentificationMvo
	{

		public virtual bool IsPropertyIdValueRemoved { get; set; }

		public virtual bool IsPropertyVersionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }

		public virtual bool IsPropertyProductProductTypeIdRemoved { get; set; }

		public virtual bool IsPropertyProductPrimaryProductCategoryIdRemoved { get; set; }

		public virtual bool IsPropertyProductManufacturerPartyIdRemoved { get; set; }

		public virtual bool IsPropertyProductFacilityIdRemoved { get; set; }

		public virtual bool IsPropertyProductIntroductionDateRemoved { get; set; }

		public virtual bool IsPropertyProductReleaseDateRemoved { get; set; }

		public virtual bool IsPropertyProductSupportDiscontinuationDateRemoved { get; set; }

		public virtual bool IsPropertyProductSalesDiscontinuationDateRemoved { get; set; }

		public virtual bool IsPropertyProductSalesDiscWhenNotAvailRemoved { get; set; }

		public virtual bool IsPropertyProductInternalNameRemoved { get; set; }

		public virtual bool IsPropertyProductBrandNameRemoved { get; set; }

		public virtual bool IsPropertyProductCommentsRemoved { get; set; }

		public virtual bool IsPropertyProductProductNameRemoved { get; set; }

		public virtual bool IsPropertyProductDescriptionRemoved { get; set; }

		public virtual bool IsPropertyProductPriceDetailTextRemoved { get; set; }

		public virtual bool IsPropertyProductSmallImageUrlRemoved { get; set; }

		public virtual bool IsPropertyProductMediumImageUrlRemoved { get; set; }

		public virtual bool IsPropertyProductLargeImageUrlRemoved { get; set; }

		public virtual bool IsPropertyProductDetailImageUrlRemoved { get; set; }

		public virtual bool IsPropertyProductOriginalImageUrlRemoved { get; set; }

		public virtual bool IsPropertyProductDetailScreenRemoved { get; set; }

		public virtual bool IsPropertyProductInventoryMessageRemoved { get; set; }

		public virtual bool IsPropertyProductInventoryItemTypeIdRemoved { get; set; }

		public virtual bool IsPropertyProductRequireInventoryRemoved { get; set; }

		public virtual bool IsPropertyProductQuantityUomIdRemoved { get; set; }

		public virtual bool IsPropertyProductQuantityIncludedRemoved { get; set; }

		public virtual bool IsPropertyProductPiecesIncludedRemoved { get; set; }

		public virtual bool IsPropertyProductRequireAmountRemoved { get; set; }

		public virtual bool IsPropertyProductFixedAmountRemoved { get; set; }

		public virtual bool IsPropertyProductAmountUomTypeIdRemoved { get; set; }

		public virtual bool IsPropertyProductWeightUomIdRemoved { get; set; }

		public virtual bool IsPropertyProductShippingWeightRemoved { get; set; }

		public virtual bool IsPropertyProductProductWeightRemoved { get; set; }

		public virtual bool IsPropertyProductHeightUomIdRemoved { get; set; }

		public virtual bool IsPropertyProductProductHeightRemoved { get; set; }

		public virtual bool IsPropertyProductShippingHeightRemoved { get; set; }

		public virtual bool IsPropertyProductWidthUomIdRemoved { get; set; }

		public virtual bool IsPropertyProductProductWidthRemoved { get; set; }

		public virtual bool IsPropertyProductShippingWidthRemoved { get; set; }

		public virtual bool IsPropertyProductDepthUomIdRemoved { get; set; }

		public virtual bool IsPropertyProductProductDepthRemoved { get; set; }

		public virtual bool IsPropertyProductShippingDepthRemoved { get; set; }

		public virtual bool IsPropertyProductDiameterUomIdRemoved { get; set; }

		public virtual bool IsPropertyProductProductDiameterRemoved { get; set; }

		public virtual bool IsPropertyProductProductRatingRemoved { get; set; }

		public virtual bool IsPropertyProductRatingTypeEnumRemoved { get; set; }

		public virtual bool IsPropertyProductReturnableRemoved { get; set; }

		public virtual bool IsPropertyProductTaxableRemoved { get; set; }

		public virtual bool IsPropertyProductChargeShippingRemoved { get; set; }

		public virtual bool IsPropertyProductAutoCreateKeywordsRemoved { get; set; }

		public virtual bool IsPropertyProductIncludeInPromotionsRemoved { get; set; }

		public virtual bool IsPropertyProductIsVirtualRemoved { get; set; }

		public virtual bool IsPropertyProductIsVariantRemoved { get; set; }

		public virtual bool IsPropertyProductVirtualVariantMethodEnumRemoved { get; set; }

		public virtual bool IsPropertyProductInShippingBoxRemoved { get; set; }

		public virtual bool IsPropertyProductDefaultShipmentBoxTypeIdRemoved { get; set; }

		public virtual bool IsPropertyProductIsSerialNumberedRemoved { get; set; }

		public virtual bool IsPropertyProductIsManagedByLotRemoved { get; set; }

		public virtual bool IsPropertyProductAttributeSetIdRemoved { get; set; }

		public virtual bool IsPropertyProductAttributeSetInstanceIdRemoved { get; set; }

		public virtual bool IsPropertyProductCreatedByRemoved { get; set; }

		public virtual bool IsPropertyProductCreatedAtRemoved { get; set; }

		public virtual bool IsPropertyProductUpdatedByRemoved { get; set; }

		public virtual bool IsPropertyProductUpdatedAtRemoved { get; set; }

		public virtual bool IsPropertyProductActiveRemoved { get; set; }


		public MergePatchGoodIdentificationMvo ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteGoodIdentificationMvo : GoodIdentificationMvoCommandBase, IDeleteGoodIdentificationMvo
	{
		public DeleteGoodIdentificationMvo ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }

	}

    public static partial class GoodIdentificationMvoCommands
    {
    }

}
