﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateGoodIdentificationMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.GoodIdentificationMvo;
using Dddml.Wms.Domain.Product;

namespace Dddml.Wms.Domain.GoodIdentificationMvo
{

	public partial class GoodIdentificationMvoState : GoodIdentificationMvoStateProperties, IGoodIdentificationMvoState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }

		public virtual bool Deleted { get; set; }


		#region IIdentity implementation

		ProductGoodIdentificationId IGlobalIdentity<ProductGoodIdentificationId>.GlobalId
		{
			get
			{
				return this.ProductGoodIdentificationId;
			}
		}

		#endregion

		#region IActive implementation

		bool IActive.IsActive()
		{
			return this.Active;
		}

		#endregion

		#region IDeleted implementation

		bool IDeleted.Deleted
		{
			get
			{
				return this.Deleted;
			}
		}

		#endregion

		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
			get
			{
				return this.CreatedBy;
			}
			set
			{
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt
		{
			get
			{
				return this.CreatedAt;
			}
			set
			{
				this.CreatedAt = value;
			}
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
			get { return this.UpdatedBy; }
			set { this.UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
			get { return this.UpdatedAt; }
			set { this.UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
			get
			{
				return this.ProductVersion;
			}
		}


		#endregion

        bool IGoodIdentificationMvoState.IsUnsaved
        {
            get { return this.ProductVersion == VersionZero; }
        }

		public static long VersionZero
		{
			get
			{
				return (long)0;
			}
		}


        public virtual bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }
	
        private bool _forReapplying;

        public virtual bool ForReapplying
        {
            get { return _forReapplying; }
            set { _forReapplying = value; } 
        }

        public GoodIdentificationMvoState(IEnumerable<IEvent> events) : this(true)
        {
            if (events != null && events.Count() > 0)
            {
                this.ProductGoodIdentificationId = ((IGoodIdentificationMvoEvent)events.First()).GoodIdentificationMvoEventId.ProductGoodIdentificationId;
                foreach (var e in events)
                {
                    Mutate(e);
                    this.ProductVersion += 1;
                }
            }
        }

        public GoodIdentificationMvoState() : this(false)
        {
        }

        public GoodIdentificationMvoState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IGoodIdentificationMvoStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.IdValue = e.IdValue;

            this.Version = (e.Version != null && e.Version.HasValue) ? e.Version.Value : default(long);

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.ProductProductTypeId = e.ProductProductTypeId;

			this.ProductPrimaryProductCategoryId = e.ProductPrimaryProductCategoryId;

			this.ProductManufacturerPartyId = e.ProductManufacturerPartyId;

			this.ProductFacilityId = e.ProductFacilityId;

			this.ProductIntroductionDate = e.ProductIntroductionDate;

			this.ProductReleaseDate = e.ProductReleaseDate;

			this.ProductSupportDiscontinuationDate = e.ProductSupportDiscontinuationDate;

			this.ProductSalesDiscontinuationDate = e.ProductSalesDiscontinuationDate;

			this.ProductSalesDiscWhenNotAvail = e.ProductSalesDiscWhenNotAvail;

			this.ProductInternalName = e.ProductInternalName;

			this.ProductBrandName = e.ProductBrandName;

			this.ProductComments = e.ProductComments;

			this.ProductProductName = e.ProductProductName;

			this.ProductDescription = e.ProductDescription;

			this.ProductPriceDetailText = e.ProductPriceDetailText;

			this.ProductSmallImageUrl = e.ProductSmallImageUrl;

			this.ProductMediumImageUrl = e.ProductMediumImageUrl;

			this.ProductLargeImageUrl = e.ProductLargeImageUrl;

			this.ProductDetailImageUrl = e.ProductDetailImageUrl;

			this.ProductOriginalImageUrl = e.ProductOriginalImageUrl;

			this.ProductDetailScreen = e.ProductDetailScreen;

			this.ProductInventoryMessage = e.ProductInventoryMessage;

			this.ProductInventoryItemTypeId = e.ProductInventoryItemTypeId;

			this.ProductRequireInventory = e.ProductRequireInventory;

			this.ProductQuantityUomId = e.ProductQuantityUomId;

			this.ProductQuantityIncluded = e.ProductQuantityIncluded;

			this.ProductPiecesIncluded = e.ProductPiecesIncluded;

			this.ProductRequireAmount = e.ProductRequireAmount;

			this.ProductFixedAmount = e.ProductFixedAmount;

			this.ProductAmountUomTypeId = e.ProductAmountUomTypeId;

			this.ProductWeightUomId = e.ProductWeightUomId;

			this.ProductShippingWeight = e.ProductShippingWeight;

			this.ProductProductWeight = e.ProductProductWeight;

			this.ProductHeightUomId = e.ProductHeightUomId;

			this.ProductProductHeight = e.ProductProductHeight;

			this.ProductShippingHeight = e.ProductShippingHeight;

			this.ProductWidthUomId = e.ProductWidthUomId;

			this.ProductProductWidth = e.ProductProductWidth;

			this.ProductShippingWidth = e.ProductShippingWidth;

			this.ProductDepthUomId = e.ProductDepthUomId;

			this.ProductProductDepth = e.ProductProductDepth;

			this.ProductShippingDepth = e.ProductShippingDepth;

			this.ProductDiameterUomId = e.ProductDiameterUomId;

			this.ProductProductDiameter = e.ProductProductDiameter;

			this.ProductProductRating = e.ProductProductRating;

			this.ProductRatingTypeEnum = e.ProductRatingTypeEnum;

			this.ProductReturnable = e.ProductReturnable;

			this.ProductTaxable = e.ProductTaxable;

			this.ProductChargeShipping = e.ProductChargeShipping;

			this.ProductAutoCreateKeywords = e.ProductAutoCreateKeywords;

			this.ProductIncludeInPromotions = e.ProductIncludeInPromotions;

			this.ProductIsVirtual = e.ProductIsVirtual;

			this.ProductIsVariant = e.ProductIsVariant;

			this.ProductVirtualVariantMethodEnum = e.ProductVirtualVariantMethodEnum;

			this.ProductInShippingBox = e.ProductInShippingBox;

			this.ProductDefaultShipmentBoxTypeId = e.ProductDefaultShipmentBoxTypeId;

            this.ProductIsSerialNumbered = (e.ProductIsSerialNumbered != null && e.ProductIsSerialNumbered.HasValue) ? e.ProductIsSerialNumbered.Value : default(bool);

            this.ProductIsManagedByLot = (e.ProductIsManagedByLot != null && e.ProductIsManagedByLot.HasValue) ? e.ProductIsManagedByLot.Value : default(bool);

			this.ProductAttributeSetId = e.ProductAttributeSetId;

			this.ProductAttributeSetInstanceId = e.ProductAttributeSetInstanceId;

			this.ProductCreatedBy = e.ProductCreatedBy;

            this.ProductCreatedAt = (e.ProductCreatedAt != null && e.ProductCreatedAt.HasValue) ? e.ProductCreatedAt.Value : default(DateTime);

			this.ProductUpdatedBy = e.ProductUpdatedBy;

            this.ProductUpdatedAt = (e.ProductUpdatedAt != null && e.ProductUpdatedAt.HasValue) ? e.ProductUpdatedAt.Value : default(DateTime);

            this.ProductActive = (e.ProductActive != null && e.ProductActive.HasValue) ? e.ProductActive.Value : default(bool);

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IGoodIdentificationMvoStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.IdValue == null)
			{
				if (e.IsPropertyIdValueRemoved)
				{
					this.IdValue = default(string);
				}
			}
			else
			{
				this.IdValue = e.IdValue;
			}

			if (e.Version == null)
			{
				if (e.IsPropertyVersionRemoved)
				{
					this.Version = default(long);
				}
			}
			else
			{
				this.Version = (e.Version != null && e.Version.HasValue) ? e.Version.Value : default(long);
			}

			if (e.Active == null)
			{
				if (e.IsPropertyActiveRemoved)
				{
					this.Active = default(bool);
				}
			}
			else
			{
				this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);
			}

			if (e.ProductProductTypeId == null)
			{
				if (e.IsPropertyProductProductTypeIdRemoved)
				{
					this.ProductProductTypeId = default(string);
				}
			}
			else
			{
				this.ProductProductTypeId = e.ProductProductTypeId;
			}

			if (e.ProductPrimaryProductCategoryId == null)
			{
				if (e.IsPropertyProductPrimaryProductCategoryIdRemoved)
				{
					this.ProductPrimaryProductCategoryId = default(string);
				}
			}
			else
			{
				this.ProductPrimaryProductCategoryId = e.ProductPrimaryProductCategoryId;
			}

			if (e.ProductManufacturerPartyId == null)
			{
				if (e.IsPropertyProductManufacturerPartyIdRemoved)
				{
					this.ProductManufacturerPartyId = default(string);
				}
			}
			else
			{
				this.ProductManufacturerPartyId = e.ProductManufacturerPartyId;
			}

			if (e.ProductFacilityId == null)
			{
				if (e.IsPropertyProductFacilityIdRemoved)
				{
					this.ProductFacilityId = default(string);
				}
			}
			else
			{
				this.ProductFacilityId = e.ProductFacilityId;
			}

			if (e.ProductIntroductionDate == null)
			{
				if (e.IsPropertyProductIntroductionDateRemoved)
				{
					this.ProductIntroductionDate = default(DateTime?);
				}
			}
			else
			{
				this.ProductIntroductionDate = e.ProductIntroductionDate;
			}

			if (e.ProductReleaseDate == null)
			{
				if (e.IsPropertyProductReleaseDateRemoved)
				{
					this.ProductReleaseDate = default(DateTime?);
				}
			}
			else
			{
				this.ProductReleaseDate = e.ProductReleaseDate;
			}

			if (e.ProductSupportDiscontinuationDate == null)
			{
				if (e.IsPropertyProductSupportDiscontinuationDateRemoved)
				{
					this.ProductSupportDiscontinuationDate = default(DateTime?);
				}
			}
			else
			{
				this.ProductSupportDiscontinuationDate = e.ProductSupportDiscontinuationDate;
			}

			if (e.ProductSalesDiscontinuationDate == null)
			{
				if (e.IsPropertyProductSalesDiscontinuationDateRemoved)
				{
					this.ProductSalesDiscontinuationDate = default(DateTime?);
				}
			}
			else
			{
				this.ProductSalesDiscontinuationDate = e.ProductSalesDiscontinuationDate;
			}

			if (e.ProductSalesDiscWhenNotAvail == null)
			{
				if (e.IsPropertyProductSalesDiscWhenNotAvailRemoved)
				{
					this.ProductSalesDiscWhenNotAvail = default(string);
				}
			}
			else
			{
				this.ProductSalesDiscWhenNotAvail = e.ProductSalesDiscWhenNotAvail;
			}

			if (e.ProductInternalName == null)
			{
				if (e.IsPropertyProductInternalNameRemoved)
				{
					this.ProductInternalName = default(string);
				}
			}
			else
			{
				this.ProductInternalName = e.ProductInternalName;
			}

			if (e.ProductBrandName == null)
			{
				if (e.IsPropertyProductBrandNameRemoved)
				{
					this.ProductBrandName = default(string);
				}
			}
			else
			{
				this.ProductBrandName = e.ProductBrandName;
			}

			if (e.ProductComments == null)
			{
				if (e.IsPropertyProductCommentsRemoved)
				{
					this.ProductComments = default(string);
				}
			}
			else
			{
				this.ProductComments = e.ProductComments;
			}

			if (e.ProductProductName == null)
			{
				if (e.IsPropertyProductProductNameRemoved)
				{
					this.ProductProductName = default(string);
				}
			}
			else
			{
				this.ProductProductName = e.ProductProductName;
			}

			if (e.ProductDescription == null)
			{
				if (e.IsPropertyProductDescriptionRemoved)
				{
					this.ProductDescription = default(string);
				}
			}
			else
			{
				this.ProductDescription = e.ProductDescription;
			}

			if (e.ProductPriceDetailText == null)
			{
				if (e.IsPropertyProductPriceDetailTextRemoved)
				{
					this.ProductPriceDetailText = default(string);
				}
			}
			else
			{
				this.ProductPriceDetailText = e.ProductPriceDetailText;
			}

			if (e.ProductSmallImageUrl == null)
			{
				if (e.IsPropertyProductSmallImageUrlRemoved)
				{
					this.ProductSmallImageUrl = default(string);
				}
			}
			else
			{
				this.ProductSmallImageUrl = e.ProductSmallImageUrl;
			}

			if (e.ProductMediumImageUrl == null)
			{
				if (e.IsPropertyProductMediumImageUrlRemoved)
				{
					this.ProductMediumImageUrl = default(string);
				}
			}
			else
			{
				this.ProductMediumImageUrl = e.ProductMediumImageUrl;
			}

			if (e.ProductLargeImageUrl == null)
			{
				if (e.IsPropertyProductLargeImageUrlRemoved)
				{
					this.ProductLargeImageUrl = default(string);
				}
			}
			else
			{
				this.ProductLargeImageUrl = e.ProductLargeImageUrl;
			}

			if (e.ProductDetailImageUrl == null)
			{
				if (e.IsPropertyProductDetailImageUrlRemoved)
				{
					this.ProductDetailImageUrl = default(string);
				}
			}
			else
			{
				this.ProductDetailImageUrl = e.ProductDetailImageUrl;
			}

			if (e.ProductOriginalImageUrl == null)
			{
				if (e.IsPropertyProductOriginalImageUrlRemoved)
				{
					this.ProductOriginalImageUrl = default(string);
				}
			}
			else
			{
				this.ProductOriginalImageUrl = e.ProductOriginalImageUrl;
			}

			if (e.ProductDetailScreen == null)
			{
				if (e.IsPropertyProductDetailScreenRemoved)
				{
					this.ProductDetailScreen = default(string);
				}
			}
			else
			{
				this.ProductDetailScreen = e.ProductDetailScreen;
			}

			if (e.ProductInventoryMessage == null)
			{
				if (e.IsPropertyProductInventoryMessageRemoved)
				{
					this.ProductInventoryMessage = default(string);
				}
			}
			else
			{
				this.ProductInventoryMessage = e.ProductInventoryMessage;
			}

			if (e.ProductInventoryItemTypeId == null)
			{
				if (e.IsPropertyProductInventoryItemTypeIdRemoved)
				{
					this.ProductInventoryItemTypeId = default(string);
				}
			}
			else
			{
				this.ProductInventoryItemTypeId = e.ProductInventoryItemTypeId;
			}

			if (e.ProductRequireInventory == null)
			{
				if (e.IsPropertyProductRequireInventoryRemoved)
				{
					this.ProductRequireInventory = default(string);
				}
			}
			else
			{
				this.ProductRequireInventory = e.ProductRequireInventory;
			}

			if (e.ProductQuantityUomId == null)
			{
				if (e.IsPropertyProductQuantityUomIdRemoved)
				{
					this.ProductQuantityUomId = default(string);
				}
			}
			else
			{
				this.ProductQuantityUomId = e.ProductQuantityUomId;
			}

			if (e.ProductQuantityIncluded == null)
			{
				if (e.IsPropertyProductQuantityIncludedRemoved)
				{
					this.ProductQuantityIncluded = default(decimal?);
				}
			}
			else
			{
				this.ProductQuantityIncluded = e.ProductQuantityIncluded;
			}

			if (e.ProductPiecesIncluded == null)
			{
				if (e.IsPropertyProductPiecesIncludedRemoved)
				{
					this.ProductPiecesIncluded = default(long?);
				}
			}
			else
			{
				this.ProductPiecesIncluded = e.ProductPiecesIncluded;
			}

			if (e.ProductRequireAmount == null)
			{
				if (e.IsPropertyProductRequireAmountRemoved)
				{
					this.ProductRequireAmount = default(string);
				}
			}
			else
			{
				this.ProductRequireAmount = e.ProductRequireAmount;
			}

			if (e.ProductFixedAmount == null)
			{
				if (e.IsPropertyProductFixedAmountRemoved)
				{
					this.ProductFixedAmount = default(decimal?);
				}
			}
			else
			{
				this.ProductFixedAmount = e.ProductFixedAmount;
			}

			if (e.ProductAmountUomTypeId == null)
			{
				if (e.IsPropertyProductAmountUomTypeIdRemoved)
				{
					this.ProductAmountUomTypeId = default(string);
				}
			}
			else
			{
				this.ProductAmountUomTypeId = e.ProductAmountUomTypeId;
			}

			if (e.ProductWeightUomId == null)
			{
				if (e.IsPropertyProductWeightUomIdRemoved)
				{
					this.ProductWeightUomId = default(string);
				}
			}
			else
			{
				this.ProductWeightUomId = e.ProductWeightUomId;
			}

			if (e.ProductShippingWeight == null)
			{
				if (e.IsPropertyProductShippingWeightRemoved)
				{
					this.ProductShippingWeight = default(decimal?);
				}
			}
			else
			{
				this.ProductShippingWeight = e.ProductShippingWeight;
			}

			if (e.ProductProductWeight == null)
			{
				if (e.IsPropertyProductProductWeightRemoved)
				{
					this.ProductProductWeight = default(decimal?);
				}
			}
			else
			{
				this.ProductProductWeight = e.ProductProductWeight;
			}

			if (e.ProductHeightUomId == null)
			{
				if (e.IsPropertyProductHeightUomIdRemoved)
				{
					this.ProductHeightUomId = default(string);
				}
			}
			else
			{
				this.ProductHeightUomId = e.ProductHeightUomId;
			}

			if (e.ProductProductHeight == null)
			{
				if (e.IsPropertyProductProductHeightRemoved)
				{
					this.ProductProductHeight = default(decimal?);
				}
			}
			else
			{
				this.ProductProductHeight = e.ProductProductHeight;
			}

			if (e.ProductShippingHeight == null)
			{
				if (e.IsPropertyProductShippingHeightRemoved)
				{
					this.ProductShippingHeight = default(decimal?);
				}
			}
			else
			{
				this.ProductShippingHeight = e.ProductShippingHeight;
			}

			if (e.ProductWidthUomId == null)
			{
				if (e.IsPropertyProductWidthUomIdRemoved)
				{
					this.ProductWidthUomId = default(string);
				}
			}
			else
			{
				this.ProductWidthUomId = e.ProductWidthUomId;
			}

			if (e.ProductProductWidth == null)
			{
				if (e.IsPropertyProductProductWidthRemoved)
				{
					this.ProductProductWidth = default(decimal?);
				}
			}
			else
			{
				this.ProductProductWidth = e.ProductProductWidth;
			}

			if (e.ProductShippingWidth == null)
			{
				if (e.IsPropertyProductShippingWidthRemoved)
				{
					this.ProductShippingWidth = default(decimal?);
				}
			}
			else
			{
				this.ProductShippingWidth = e.ProductShippingWidth;
			}

			if (e.ProductDepthUomId == null)
			{
				if (e.IsPropertyProductDepthUomIdRemoved)
				{
					this.ProductDepthUomId = default(string);
				}
			}
			else
			{
				this.ProductDepthUomId = e.ProductDepthUomId;
			}

			if (e.ProductProductDepth == null)
			{
				if (e.IsPropertyProductProductDepthRemoved)
				{
					this.ProductProductDepth = default(decimal?);
				}
			}
			else
			{
				this.ProductProductDepth = e.ProductProductDepth;
			}

			if (e.ProductShippingDepth == null)
			{
				if (e.IsPropertyProductShippingDepthRemoved)
				{
					this.ProductShippingDepth = default(decimal?);
				}
			}
			else
			{
				this.ProductShippingDepth = e.ProductShippingDepth;
			}

			if (e.ProductDiameterUomId == null)
			{
				if (e.IsPropertyProductDiameterUomIdRemoved)
				{
					this.ProductDiameterUomId = default(string);
				}
			}
			else
			{
				this.ProductDiameterUomId = e.ProductDiameterUomId;
			}

			if (e.ProductProductDiameter == null)
			{
				if (e.IsPropertyProductProductDiameterRemoved)
				{
					this.ProductProductDiameter = default(decimal?);
				}
			}
			else
			{
				this.ProductProductDiameter = e.ProductProductDiameter;
			}

			if (e.ProductProductRating == null)
			{
				if (e.IsPropertyProductProductRatingRemoved)
				{
					this.ProductProductRating = default(decimal?);
				}
			}
			else
			{
				this.ProductProductRating = e.ProductProductRating;
			}

			if (e.ProductRatingTypeEnum == null)
			{
				if (e.IsPropertyProductRatingTypeEnumRemoved)
				{
					this.ProductRatingTypeEnum = default(string);
				}
			}
			else
			{
				this.ProductRatingTypeEnum = e.ProductRatingTypeEnum;
			}

			if (e.ProductReturnable == null)
			{
				if (e.IsPropertyProductReturnableRemoved)
				{
					this.ProductReturnable = default(string);
				}
			}
			else
			{
				this.ProductReturnable = e.ProductReturnable;
			}

			if (e.ProductTaxable == null)
			{
				if (e.IsPropertyProductTaxableRemoved)
				{
					this.ProductTaxable = default(string);
				}
			}
			else
			{
				this.ProductTaxable = e.ProductTaxable;
			}

			if (e.ProductChargeShipping == null)
			{
				if (e.IsPropertyProductChargeShippingRemoved)
				{
					this.ProductChargeShipping = default(string);
				}
			}
			else
			{
				this.ProductChargeShipping = e.ProductChargeShipping;
			}

			if (e.ProductAutoCreateKeywords == null)
			{
				if (e.IsPropertyProductAutoCreateKeywordsRemoved)
				{
					this.ProductAutoCreateKeywords = default(string);
				}
			}
			else
			{
				this.ProductAutoCreateKeywords = e.ProductAutoCreateKeywords;
			}

			if (e.ProductIncludeInPromotions == null)
			{
				if (e.IsPropertyProductIncludeInPromotionsRemoved)
				{
					this.ProductIncludeInPromotions = default(string);
				}
			}
			else
			{
				this.ProductIncludeInPromotions = e.ProductIncludeInPromotions;
			}

			if (e.ProductIsVirtual == null)
			{
				if (e.IsPropertyProductIsVirtualRemoved)
				{
					this.ProductIsVirtual = default(string);
				}
			}
			else
			{
				this.ProductIsVirtual = e.ProductIsVirtual;
			}

			if (e.ProductIsVariant == null)
			{
				if (e.IsPropertyProductIsVariantRemoved)
				{
					this.ProductIsVariant = default(string);
				}
			}
			else
			{
				this.ProductIsVariant = e.ProductIsVariant;
			}

			if (e.ProductVirtualVariantMethodEnum == null)
			{
				if (e.IsPropertyProductVirtualVariantMethodEnumRemoved)
				{
					this.ProductVirtualVariantMethodEnum = default(string);
				}
			}
			else
			{
				this.ProductVirtualVariantMethodEnum = e.ProductVirtualVariantMethodEnum;
			}

			if (e.ProductInShippingBox == null)
			{
				if (e.IsPropertyProductInShippingBoxRemoved)
				{
					this.ProductInShippingBox = default(string);
				}
			}
			else
			{
				this.ProductInShippingBox = e.ProductInShippingBox;
			}

			if (e.ProductDefaultShipmentBoxTypeId == null)
			{
				if (e.IsPropertyProductDefaultShipmentBoxTypeIdRemoved)
				{
					this.ProductDefaultShipmentBoxTypeId = default(string);
				}
			}
			else
			{
				this.ProductDefaultShipmentBoxTypeId = e.ProductDefaultShipmentBoxTypeId;
			}

			if (e.ProductIsSerialNumbered == null)
			{
				if (e.IsPropertyProductIsSerialNumberedRemoved)
				{
					this.ProductIsSerialNumbered = default(bool);
				}
			}
			else
			{
				this.ProductIsSerialNumbered = (e.ProductIsSerialNumbered != null && e.ProductIsSerialNumbered.HasValue) ? e.ProductIsSerialNumbered.Value : default(bool);
			}

			if (e.ProductIsManagedByLot == null)
			{
				if (e.IsPropertyProductIsManagedByLotRemoved)
				{
					this.ProductIsManagedByLot = default(bool);
				}
			}
			else
			{
				this.ProductIsManagedByLot = (e.ProductIsManagedByLot != null && e.ProductIsManagedByLot.HasValue) ? e.ProductIsManagedByLot.Value : default(bool);
			}

			if (e.ProductAttributeSetId == null)
			{
				if (e.IsPropertyProductAttributeSetIdRemoved)
				{
					this.ProductAttributeSetId = default(string);
				}
			}
			else
			{
				this.ProductAttributeSetId = e.ProductAttributeSetId;
			}

			if (e.ProductAttributeSetInstanceId == null)
			{
				if (e.IsPropertyProductAttributeSetInstanceIdRemoved)
				{
					this.ProductAttributeSetInstanceId = default(string);
				}
			}
			else
			{
				this.ProductAttributeSetInstanceId = e.ProductAttributeSetInstanceId;
			}

			if (e.ProductCreatedBy == null)
			{
				if (e.IsPropertyProductCreatedByRemoved)
				{
					this.ProductCreatedBy = default(string);
				}
			}
			else
			{
				this.ProductCreatedBy = e.ProductCreatedBy;
			}

			if (e.ProductCreatedAt == null)
			{
				if (e.IsPropertyProductCreatedAtRemoved)
				{
					this.ProductCreatedAt = default(DateTime);
				}
			}
			else
			{
				this.ProductCreatedAt = (e.ProductCreatedAt != null && e.ProductCreatedAt.HasValue) ? e.ProductCreatedAt.Value : default(DateTime);
			}

			if (e.ProductUpdatedBy == null)
			{
				if (e.IsPropertyProductUpdatedByRemoved)
				{
					this.ProductUpdatedBy = default(string);
				}
			}
			else
			{
				this.ProductUpdatedBy = e.ProductUpdatedBy;
			}

			if (e.ProductUpdatedAt == null)
			{
				if (e.IsPropertyProductUpdatedAtRemoved)
				{
					this.ProductUpdatedAt = default(DateTime);
				}
			}
			else
			{
				this.ProductUpdatedAt = (e.ProductUpdatedAt != null && e.ProductUpdatedAt.HasValue) ? e.ProductUpdatedAt.Value : default(DateTime);
			}

			if (e.ProductActive == null)
			{
				if (e.IsPropertyProductActiveRemoved)
				{
					this.ProductActive = default(bool);
				}
			}
			else
			{
				this.ProductActive = (e.ProductActive != null && e.ProductActive.HasValue) ? e.ProductActive.Value : default(bool);
			}


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


		}

		public virtual void When(IGoodIdentificationMvoStateDeleted e)
		{
			ThrowOnWrongEvent(e);

			this.Deleted = true;
			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;

		}


		public virtual void Mutate(IEvent e)
		{
            StateReadOnly = false;
			((dynamic)this).When((dynamic)e);
		}

        protected void ThrowOnWrongEvent(IGoodIdentificationMvoEvent e)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("GoodIdentificationMvo|");

            var stateEntityId = this.ProductGoodIdentificationId; // Aggregate Id
            var eventEntityId = e.GoodIdentificationMvoEventId.ProductGoodIdentificationId;
            if (stateEntityId != eventEntityId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
            }
            id.Append(stateEntityId).Append(",");

            id.Append("]");

            var stateVersion = this.ProductVersion;
            var eventVersion = e.GoodIdentificationMvoEventId.ProductVersion;
            if (stateVersion != eventVersion)
            {
                throw OptimisticConcurrencyException.Create(stateVersion, eventVersion, id.ToString());
            }
        }
    }

}

