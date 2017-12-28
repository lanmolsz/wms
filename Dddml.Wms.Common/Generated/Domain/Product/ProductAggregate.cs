﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateProductDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Product;

namespace Dddml.Wms.Domain.Product
{
    public partial class ProductAggregate : AggregateBase, IProductAggregate
    {

        readonly IProductState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IProductState State
        {
            get
            {
                return _state;
            }
        }

        public IList<IEvent> Changes
        {
            get
            {
                return _changes;
            }
        }

        #region IIdentity implementation

        string IGlobalIdentity<string>.GlobalId
        {
            get
            {
                return this._state.GlobalId;
            }
        }

        #endregion


        public ProductAggregate(IProductState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IProductStateProperties)_state).Version == ProductState.VersionZero)
            {
                if (IsCommandCreate((IProductCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (IsCommandCreate((IProductCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IProductCommand c)
        {
            return c.Version == ProductState.VersionZero;
        }

        protected internal virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateProduct c)
        {
            IProductStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchProduct c)
        {
            IProductStateMergePatched e = Map(c);
            Apply(e);
        }


        protected virtual IProductStateCreated Map(ICreateProduct c)
        {
			var stateEventId = new ProductStateEventId(c.ProductId, c.Version);
            IProductStateCreated e = NewProductStateCreated(stateEventId);
		
            e.ProductTypeId = c.ProductTypeId;
            e.PrimaryProductCategoryId = c.PrimaryProductCategoryId;
            e.ManufacturerPartyId = c.ManufacturerPartyId;
            e.FacilityId = c.FacilityId;
            e.IntroductionDate = c.IntroductionDate;
            e.ReleaseDate = c.ReleaseDate;
            e.SupportDiscontinuationDate = c.SupportDiscontinuationDate;
            e.SalesDiscontinuationDate = c.SalesDiscontinuationDate;
            e.SalesDiscWhenNotAvail = c.SalesDiscWhenNotAvail;
            e.InternalName = c.InternalName;
            e.BrandName = c.BrandName;
            e.Comments = c.Comments;
            e.ProductName = c.ProductName;
            e.Description = c.Description;
            e.PriceDetailText = c.PriceDetailText;
            e.SmallImageUrl = c.SmallImageUrl;
            e.MediumImageUrl = c.MediumImageUrl;
            e.LargeImageUrl = c.LargeImageUrl;
            e.DetailImageUrl = c.DetailImageUrl;
            e.OriginalImageUrl = c.OriginalImageUrl;
            e.DetailScreen = c.DetailScreen;
            e.InventoryMessage = c.InventoryMessage;
            e.InventoryItemTypeId = c.InventoryItemTypeId;
            e.RequireInventory = c.RequireInventory;
            e.QuantityUomId = c.QuantityUomId;
            e.QuantityIncluded = c.QuantityIncluded;
            e.PiecesIncluded = c.PiecesIncluded;
            e.RequireAmount = c.RequireAmount;
            e.FixedAmount = c.FixedAmount;
            e.AmountUomTypeId = c.AmountUomTypeId;
            e.WeightUomId = c.WeightUomId;
            e.ShippingWeight = c.ShippingWeight;
            e.ProductWeight = c.ProductWeight;
            e.HeightUomId = c.HeightUomId;
            e.ProductHeight = c.ProductHeight;
            e.ShippingHeight = c.ShippingHeight;
            e.WidthUomId = c.WidthUomId;
            e.ProductWidth = c.ProductWidth;
            e.ShippingWidth = c.ShippingWidth;
            e.DepthUomId = c.DepthUomId;
            e.ProductDepth = c.ProductDepth;
            e.ShippingDepth = c.ShippingDepth;
            e.DiameterUomId = c.DiameterUomId;
            e.ProductDiameter = c.ProductDiameter;
            e.ProductRating = c.ProductRating;
            e.RatingTypeEnum = c.RatingTypeEnum;
            e.Returnable = c.Returnable;
            e.Taxable = c.Taxable;
            e.ChargeShipping = c.ChargeShipping;
            e.AutoCreateKeywords = c.AutoCreateKeywords;
            e.IncludeInPromotions = c.IncludeInPromotions;
            e.IsVirtual = c.IsVirtual;
            e.IsVariant = c.IsVariant;
            e.VirtualVariantMethodEnum = c.VirtualVariantMethodEnum;
            e.InShippingBox = c.InShippingBox;
            e.DefaultShipmentBoxTypeId = c.DefaultShipmentBoxTypeId;
            e.LotIdFilledIn = c.LotIdFilledIn;
            e.AttributeSetId = c.AttributeSetId;
            e.Active = c.Active;
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
			var version = c.Version;


            return e;
        }

        protected virtual IProductStateMergePatched Map(IMergePatchProduct c)
        {
			var stateEventId = new ProductStateEventId(c.ProductId, c.Version);
            IProductStateMergePatched e = NewProductStateMergePatched(stateEventId);

            e.ProductTypeId = c.ProductTypeId;
            e.PrimaryProductCategoryId = c.PrimaryProductCategoryId;
            e.ManufacturerPartyId = c.ManufacturerPartyId;
            e.FacilityId = c.FacilityId;
            e.IntroductionDate = c.IntroductionDate;
            e.ReleaseDate = c.ReleaseDate;
            e.SupportDiscontinuationDate = c.SupportDiscontinuationDate;
            e.SalesDiscontinuationDate = c.SalesDiscontinuationDate;
            e.SalesDiscWhenNotAvail = c.SalesDiscWhenNotAvail;
            e.InternalName = c.InternalName;
            e.BrandName = c.BrandName;
            e.Comments = c.Comments;
            e.ProductName = c.ProductName;
            e.Description = c.Description;
            e.PriceDetailText = c.PriceDetailText;
            e.SmallImageUrl = c.SmallImageUrl;
            e.MediumImageUrl = c.MediumImageUrl;
            e.LargeImageUrl = c.LargeImageUrl;
            e.DetailImageUrl = c.DetailImageUrl;
            e.OriginalImageUrl = c.OriginalImageUrl;
            e.DetailScreen = c.DetailScreen;
            e.InventoryMessage = c.InventoryMessage;
            e.InventoryItemTypeId = c.InventoryItemTypeId;
            e.RequireInventory = c.RequireInventory;
            e.QuantityUomId = c.QuantityUomId;
            e.QuantityIncluded = c.QuantityIncluded;
            e.PiecesIncluded = c.PiecesIncluded;
            e.RequireAmount = c.RequireAmount;
            e.FixedAmount = c.FixedAmount;
            e.AmountUomTypeId = c.AmountUomTypeId;
            e.WeightUomId = c.WeightUomId;
            e.ShippingWeight = c.ShippingWeight;
            e.ProductWeight = c.ProductWeight;
            e.HeightUomId = c.HeightUomId;
            e.ProductHeight = c.ProductHeight;
            e.ShippingHeight = c.ShippingHeight;
            e.WidthUomId = c.WidthUomId;
            e.ProductWidth = c.ProductWidth;
            e.ShippingWidth = c.ShippingWidth;
            e.DepthUomId = c.DepthUomId;
            e.ProductDepth = c.ProductDepth;
            e.ShippingDepth = c.ShippingDepth;
            e.DiameterUomId = c.DiameterUomId;
            e.ProductDiameter = c.ProductDiameter;
            e.ProductRating = c.ProductRating;
            e.RatingTypeEnum = c.RatingTypeEnum;
            e.Returnable = c.Returnable;
            e.Taxable = c.Taxable;
            e.ChargeShipping = c.ChargeShipping;
            e.AutoCreateKeywords = c.AutoCreateKeywords;
            e.IncludeInPromotions = c.IncludeInPromotions;
            e.IsVirtual = c.IsVirtual;
            e.IsVariant = c.IsVariant;
            e.VirtualVariantMethodEnum = c.VirtualVariantMethodEnum;
            e.InShippingBox = c.InShippingBox;
            e.DefaultShipmentBoxTypeId = c.DefaultShipmentBoxTypeId;
            e.LotIdFilledIn = c.LotIdFilledIn;
            e.AttributeSetId = c.AttributeSetId;
            e.Active = c.Active;
            e.IsPropertyProductTypeIdRemoved = c.IsPropertyProductTypeIdRemoved;
            e.IsPropertyPrimaryProductCategoryIdRemoved = c.IsPropertyPrimaryProductCategoryIdRemoved;
            e.IsPropertyManufacturerPartyIdRemoved = c.IsPropertyManufacturerPartyIdRemoved;
            e.IsPropertyFacilityIdRemoved = c.IsPropertyFacilityIdRemoved;
            e.IsPropertyIntroductionDateRemoved = c.IsPropertyIntroductionDateRemoved;
            e.IsPropertyReleaseDateRemoved = c.IsPropertyReleaseDateRemoved;
            e.IsPropertySupportDiscontinuationDateRemoved = c.IsPropertySupportDiscontinuationDateRemoved;
            e.IsPropertySalesDiscontinuationDateRemoved = c.IsPropertySalesDiscontinuationDateRemoved;
            e.IsPropertySalesDiscWhenNotAvailRemoved = c.IsPropertySalesDiscWhenNotAvailRemoved;
            e.IsPropertyInternalNameRemoved = c.IsPropertyInternalNameRemoved;
            e.IsPropertyBrandNameRemoved = c.IsPropertyBrandNameRemoved;
            e.IsPropertyCommentsRemoved = c.IsPropertyCommentsRemoved;
            e.IsPropertyProductNameRemoved = c.IsPropertyProductNameRemoved;
            e.IsPropertyDescriptionRemoved = c.IsPropertyDescriptionRemoved;
            e.IsPropertyPriceDetailTextRemoved = c.IsPropertyPriceDetailTextRemoved;
            e.IsPropertySmallImageUrlRemoved = c.IsPropertySmallImageUrlRemoved;
            e.IsPropertyMediumImageUrlRemoved = c.IsPropertyMediumImageUrlRemoved;
            e.IsPropertyLargeImageUrlRemoved = c.IsPropertyLargeImageUrlRemoved;
            e.IsPropertyDetailImageUrlRemoved = c.IsPropertyDetailImageUrlRemoved;
            e.IsPropertyOriginalImageUrlRemoved = c.IsPropertyOriginalImageUrlRemoved;
            e.IsPropertyDetailScreenRemoved = c.IsPropertyDetailScreenRemoved;
            e.IsPropertyInventoryMessageRemoved = c.IsPropertyInventoryMessageRemoved;
            e.IsPropertyInventoryItemTypeIdRemoved = c.IsPropertyInventoryItemTypeIdRemoved;
            e.IsPropertyRequireInventoryRemoved = c.IsPropertyRequireInventoryRemoved;
            e.IsPropertyQuantityUomIdRemoved = c.IsPropertyQuantityUomIdRemoved;
            e.IsPropertyQuantityIncludedRemoved = c.IsPropertyQuantityIncludedRemoved;
            e.IsPropertyPiecesIncludedRemoved = c.IsPropertyPiecesIncludedRemoved;
            e.IsPropertyRequireAmountRemoved = c.IsPropertyRequireAmountRemoved;
            e.IsPropertyFixedAmountRemoved = c.IsPropertyFixedAmountRemoved;
            e.IsPropertyAmountUomTypeIdRemoved = c.IsPropertyAmountUomTypeIdRemoved;
            e.IsPropertyWeightUomIdRemoved = c.IsPropertyWeightUomIdRemoved;
            e.IsPropertyShippingWeightRemoved = c.IsPropertyShippingWeightRemoved;
            e.IsPropertyProductWeightRemoved = c.IsPropertyProductWeightRemoved;
            e.IsPropertyHeightUomIdRemoved = c.IsPropertyHeightUomIdRemoved;
            e.IsPropertyProductHeightRemoved = c.IsPropertyProductHeightRemoved;
            e.IsPropertyShippingHeightRemoved = c.IsPropertyShippingHeightRemoved;
            e.IsPropertyWidthUomIdRemoved = c.IsPropertyWidthUomIdRemoved;
            e.IsPropertyProductWidthRemoved = c.IsPropertyProductWidthRemoved;
            e.IsPropertyShippingWidthRemoved = c.IsPropertyShippingWidthRemoved;
            e.IsPropertyDepthUomIdRemoved = c.IsPropertyDepthUomIdRemoved;
            e.IsPropertyProductDepthRemoved = c.IsPropertyProductDepthRemoved;
            e.IsPropertyShippingDepthRemoved = c.IsPropertyShippingDepthRemoved;
            e.IsPropertyDiameterUomIdRemoved = c.IsPropertyDiameterUomIdRemoved;
            e.IsPropertyProductDiameterRemoved = c.IsPropertyProductDiameterRemoved;
            e.IsPropertyProductRatingRemoved = c.IsPropertyProductRatingRemoved;
            e.IsPropertyRatingTypeEnumRemoved = c.IsPropertyRatingTypeEnumRemoved;
            e.IsPropertyReturnableRemoved = c.IsPropertyReturnableRemoved;
            e.IsPropertyTaxableRemoved = c.IsPropertyTaxableRemoved;
            e.IsPropertyChargeShippingRemoved = c.IsPropertyChargeShippingRemoved;
            e.IsPropertyAutoCreateKeywordsRemoved = c.IsPropertyAutoCreateKeywordsRemoved;
            e.IsPropertyIncludeInPromotionsRemoved = c.IsPropertyIncludeInPromotionsRemoved;
            e.IsPropertyIsVirtualRemoved = c.IsPropertyIsVirtualRemoved;
            e.IsPropertyIsVariantRemoved = c.IsPropertyIsVariantRemoved;
            e.IsPropertyVirtualVariantMethodEnumRemoved = c.IsPropertyVirtualVariantMethodEnumRemoved;
            e.IsPropertyInShippingBoxRemoved = c.IsPropertyInShippingBoxRemoved;
            e.IsPropertyDefaultShipmentBoxTypeIdRemoved = c.IsPropertyDefaultShipmentBoxTypeIdRemoved;
            e.IsPropertyLotIdFilledInRemoved = c.IsPropertyLotIdFilledInRemoved;
            e.IsPropertyAttributeSetIdRemoved = c.IsPropertyAttributeSetIdRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

			var version = c.Version;


            return e;
        }

        private void ThrowOnInconsistentIds(object innerObject, string innerIdName, object innerIdValue, string outerIdName, object outerIdValue)
        {
            if (!Object.Equals(innerIdValue, outerIdValue))
            {
                if (innerIdValue is string && outerIdValue is string && ((string)innerIdValue).Normalize() == ((string)outerIdValue).Normalize())
                {
                    return;
                }
                throw DomainError.Named("inconsistentId", "Outer {0} {1} NOT equals inner {2} {3}", outerIdName, outerIdValue, innerIdName, innerIdValue);
            }
        }

////////////////////////

        protected ProductStateCreated NewProductStateCreated(string commandId, string requesterId)
        {
            var stateEventId = new ProductStateEventId(_state.ProductId, ((IProductStateProperties)_state).Version);
            var e = NewProductStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

        protected ProductStateMergePatched NewProductStateMergePatched(string commandId, string requesterId)
        {
            var stateEventId = new ProductStateEventId(_state.ProductId, ((IProductStateProperties)_state).Version);
            var e = NewProductStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }


////////////////////////

		private ProductStateCreated NewProductStateCreated(ProductStateEventId stateEventId)
		{
			return new ProductStateCreated(stateEventId);			
		}

        private ProductStateMergePatched NewProductStateMergePatched(ProductStateEventId stateEventId)
		{
			return new ProductStateMergePatched(stateEventId);
		}


    }

}

