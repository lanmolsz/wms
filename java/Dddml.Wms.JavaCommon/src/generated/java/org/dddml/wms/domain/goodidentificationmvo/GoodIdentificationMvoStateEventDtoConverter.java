package org.dddml.wms.domain.goodidentificationmvo;

import java.util.*;
import org.dddml.wms.domain.product.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;

public class GoodIdentificationMvoStateEventDtoConverter {

    public GoodIdentificationMvoStateEventDto toGoodIdentificationMvoStateEventDto(AbstractGoodIdentificationMvoEvent stateEvent) {
        if (stateEvent instanceof AbstractGoodIdentificationMvoEvent.AbstractGoodIdentificationMvoStateCreated) {
            GoodIdentificationMvoEvent.GoodIdentificationMvoStateCreated e = (GoodIdentificationMvoEvent.GoodIdentificationMvoStateCreated) stateEvent;
            return toGoodIdentificationMvoStateCreatedDto(e);
        } else if (stateEvent instanceof AbstractGoodIdentificationMvoEvent.AbstractGoodIdentificationMvoStateMergePatched) {
            GoodIdentificationMvoEvent.GoodIdentificationMvoStateMergePatched e = (GoodIdentificationMvoEvent.GoodIdentificationMvoStateMergePatched) stateEvent;
            return toGoodIdentificationMvoStateMergePatchedDto(e);
        } else if (stateEvent instanceof AbstractGoodIdentificationMvoEvent.AbstractGoodIdentificationMvoStateDeleted) {
            GoodIdentificationMvoEvent.GoodIdentificationMvoStateDeleted e = (GoodIdentificationMvoEvent.GoodIdentificationMvoStateDeleted) stateEvent;
            return toGoodIdentificationMvoStateDeletedDto(e);
        }

        throw DomainError.named("invalidEventType", String.format("Invalid state event type: %1$s", stateEvent.getEventType()));
    }

    public GoodIdentificationMvoStateEventDto.GoodIdentificationMvoStateCreatedDto toGoodIdentificationMvoStateCreatedDto(GoodIdentificationMvoEvent.GoodIdentificationMvoStateCreated e) {
        GoodIdentificationMvoStateEventDto.GoodIdentificationMvoStateCreatedDto dto = new GoodIdentificationMvoStateEventDto.GoodIdentificationMvoStateCreatedDto();
        dto.setGoodIdentificationMvoEventId(e.getGoodIdentificationMvoEventId());
        dto.setCreatedAt(e.getCreatedAt());
        dto.setCreatedBy(e.getCreatedBy());
        dto.setCommandId(e.getCommandId());
        dto.setIdValue(e.getIdValue());
        dto.setVersion(e.getVersion());
        dto.setActive(e.getActive());
        dto.setProductProductTypeId(e.getProductProductTypeId());
        dto.setProductPrimaryProductCategoryId(e.getProductPrimaryProductCategoryId());
        dto.setProductManufacturerPartyId(e.getProductManufacturerPartyId());
        dto.setProductFacilityId(e.getProductFacilityId());
        dto.setProductIntroductionDate(e.getProductIntroductionDate());
        dto.setProductReleaseDate(e.getProductReleaseDate());
        dto.setProductSupportDiscontinuationDate(e.getProductSupportDiscontinuationDate());
        dto.setProductSalesDiscontinuationDate(e.getProductSalesDiscontinuationDate());
        dto.setProductSalesDiscWhenNotAvail(e.getProductSalesDiscWhenNotAvail());
        dto.setProductInternalName(e.getProductInternalName());
        dto.setProductBrandName(e.getProductBrandName());
        dto.setProductComments(e.getProductComments());
        dto.setProductProductName(e.getProductProductName());
        dto.setProductDescription(e.getProductDescription());
        dto.setProductPriceDetailText(e.getProductPriceDetailText());
        dto.setProductSmallImageUrl(e.getProductSmallImageUrl());
        dto.setProductMediumImageUrl(e.getProductMediumImageUrl());
        dto.setProductLargeImageUrl(e.getProductLargeImageUrl());
        dto.setProductDetailImageUrl(e.getProductDetailImageUrl());
        dto.setProductOriginalImageUrl(e.getProductOriginalImageUrl());
        dto.setProductDetailScreen(e.getProductDetailScreen());
        dto.setProductInventoryMessage(e.getProductInventoryMessage());
        dto.setProductInventoryItemTypeId(e.getProductInventoryItemTypeId());
        dto.setProductRequireInventory(e.getProductRequireInventory());
        dto.setProductQuantityUomId(e.getProductQuantityUomId());
        dto.setProductQuantityIncluded(e.getProductQuantityIncluded());
        dto.setProductPiecesIncluded(e.getProductPiecesIncluded());
        dto.setProductRequireAmount(e.getProductRequireAmount());
        dto.setProductFixedAmount(e.getProductFixedAmount());
        dto.setProductAmountUomTypeId(e.getProductAmountUomTypeId());
        dto.setProductWeightUomId(e.getProductWeightUomId());
        dto.setProductShippingWeight(e.getProductShippingWeight());
        dto.setProductProductWeight(e.getProductProductWeight());
        dto.setProductHeightUomId(e.getProductHeightUomId());
        dto.setProductProductHeight(e.getProductProductHeight());
        dto.setProductShippingHeight(e.getProductShippingHeight());
        dto.setProductWidthUomId(e.getProductWidthUomId());
        dto.setProductProductWidth(e.getProductProductWidth());
        dto.setProductShippingWidth(e.getProductShippingWidth());
        dto.setProductDepthUomId(e.getProductDepthUomId());
        dto.setProductProductDepth(e.getProductProductDepth());
        dto.setProductShippingDepth(e.getProductShippingDepth());
        dto.setProductDiameterUomId(e.getProductDiameterUomId());
        dto.setProductProductDiameter(e.getProductProductDiameter());
        dto.setProductProductRating(e.getProductProductRating());
        dto.setProductRatingTypeEnum(e.getProductRatingTypeEnum());
        dto.setProductReturnable(e.getProductReturnable());
        dto.setProductTaxable(e.getProductTaxable());
        dto.setProductChargeShipping(e.getProductChargeShipping());
        dto.setProductAutoCreateKeywords(e.getProductAutoCreateKeywords());
        dto.setProductIncludeInPromotions(e.getProductIncludeInPromotions());
        dto.setProductIsVirtual(e.getProductIsVirtual());
        dto.setProductIsVariant(e.getProductIsVariant());
        dto.setProductVirtualVariantMethodEnum(e.getProductVirtualVariantMethodEnum());
        dto.setProductInShippingBox(e.getProductInShippingBox());
        dto.setProductDefaultShipmentBoxTypeId(e.getProductDefaultShipmentBoxTypeId());
        dto.setProductIsSerialNumbered(e.getProductIsSerialNumbered());
        dto.setProductIsManagedByLot(e.getProductIsManagedByLot());
        dto.setProductAttributeSetId(e.getProductAttributeSetId());
        dto.setProductAttributeSetInstanceId(e.getProductAttributeSetInstanceId());
        dto.setProductCreatedBy(e.getProductCreatedBy());
        dto.setProductCreatedAt(e.getProductCreatedAt());
        dto.setProductUpdatedBy(e.getProductUpdatedBy());
        dto.setProductUpdatedAt(e.getProductUpdatedAt());
        dto.setProductActive(e.getProductActive());
        return dto;
    }

    public GoodIdentificationMvoStateEventDto.GoodIdentificationMvoStateMergePatchedDto toGoodIdentificationMvoStateMergePatchedDto(GoodIdentificationMvoEvent.GoodIdentificationMvoStateMergePatched e) {
        GoodIdentificationMvoStateEventDto.GoodIdentificationMvoStateMergePatchedDto dto = new GoodIdentificationMvoStateEventDto.GoodIdentificationMvoStateMergePatchedDto();
        dto.setGoodIdentificationMvoEventId(e.getGoodIdentificationMvoEventId());
        dto.setCreatedAt(e.getCreatedAt());
        dto.setCreatedBy(e.getCreatedBy());
        dto.setCommandId(e.getCommandId());
        dto.setIdValue(e.getIdValue());
        dto.setVersion(e.getVersion());
        dto.setActive(e.getActive());
        dto.setProductProductTypeId(e.getProductProductTypeId());
        dto.setProductPrimaryProductCategoryId(e.getProductPrimaryProductCategoryId());
        dto.setProductManufacturerPartyId(e.getProductManufacturerPartyId());
        dto.setProductFacilityId(e.getProductFacilityId());
        dto.setProductIntroductionDate(e.getProductIntroductionDate());
        dto.setProductReleaseDate(e.getProductReleaseDate());
        dto.setProductSupportDiscontinuationDate(e.getProductSupportDiscontinuationDate());
        dto.setProductSalesDiscontinuationDate(e.getProductSalesDiscontinuationDate());
        dto.setProductSalesDiscWhenNotAvail(e.getProductSalesDiscWhenNotAvail());
        dto.setProductInternalName(e.getProductInternalName());
        dto.setProductBrandName(e.getProductBrandName());
        dto.setProductComments(e.getProductComments());
        dto.setProductProductName(e.getProductProductName());
        dto.setProductDescription(e.getProductDescription());
        dto.setProductPriceDetailText(e.getProductPriceDetailText());
        dto.setProductSmallImageUrl(e.getProductSmallImageUrl());
        dto.setProductMediumImageUrl(e.getProductMediumImageUrl());
        dto.setProductLargeImageUrl(e.getProductLargeImageUrl());
        dto.setProductDetailImageUrl(e.getProductDetailImageUrl());
        dto.setProductOriginalImageUrl(e.getProductOriginalImageUrl());
        dto.setProductDetailScreen(e.getProductDetailScreen());
        dto.setProductInventoryMessage(e.getProductInventoryMessage());
        dto.setProductInventoryItemTypeId(e.getProductInventoryItemTypeId());
        dto.setProductRequireInventory(e.getProductRequireInventory());
        dto.setProductQuantityUomId(e.getProductQuantityUomId());
        dto.setProductQuantityIncluded(e.getProductQuantityIncluded());
        dto.setProductPiecesIncluded(e.getProductPiecesIncluded());
        dto.setProductRequireAmount(e.getProductRequireAmount());
        dto.setProductFixedAmount(e.getProductFixedAmount());
        dto.setProductAmountUomTypeId(e.getProductAmountUomTypeId());
        dto.setProductWeightUomId(e.getProductWeightUomId());
        dto.setProductShippingWeight(e.getProductShippingWeight());
        dto.setProductProductWeight(e.getProductProductWeight());
        dto.setProductHeightUomId(e.getProductHeightUomId());
        dto.setProductProductHeight(e.getProductProductHeight());
        dto.setProductShippingHeight(e.getProductShippingHeight());
        dto.setProductWidthUomId(e.getProductWidthUomId());
        dto.setProductProductWidth(e.getProductProductWidth());
        dto.setProductShippingWidth(e.getProductShippingWidth());
        dto.setProductDepthUomId(e.getProductDepthUomId());
        dto.setProductProductDepth(e.getProductProductDepth());
        dto.setProductShippingDepth(e.getProductShippingDepth());
        dto.setProductDiameterUomId(e.getProductDiameterUomId());
        dto.setProductProductDiameter(e.getProductProductDiameter());
        dto.setProductProductRating(e.getProductProductRating());
        dto.setProductRatingTypeEnum(e.getProductRatingTypeEnum());
        dto.setProductReturnable(e.getProductReturnable());
        dto.setProductTaxable(e.getProductTaxable());
        dto.setProductChargeShipping(e.getProductChargeShipping());
        dto.setProductAutoCreateKeywords(e.getProductAutoCreateKeywords());
        dto.setProductIncludeInPromotions(e.getProductIncludeInPromotions());
        dto.setProductIsVirtual(e.getProductIsVirtual());
        dto.setProductIsVariant(e.getProductIsVariant());
        dto.setProductVirtualVariantMethodEnum(e.getProductVirtualVariantMethodEnum());
        dto.setProductInShippingBox(e.getProductInShippingBox());
        dto.setProductDefaultShipmentBoxTypeId(e.getProductDefaultShipmentBoxTypeId());
        dto.setProductIsSerialNumbered(e.getProductIsSerialNumbered());
        dto.setProductIsManagedByLot(e.getProductIsManagedByLot());
        dto.setProductAttributeSetId(e.getProductAttributeSetId());
        dto.setProductAttributeSetInstanceId(e.getProductAttributeSetInstanceId());
        dto.setProductCreatedBy(e.getProductCreatedBy());
        dto.setProductCreatedAt(e.getProductCreatedAt());
        dto.setProductUpdatedBy(e.getProductUpdatedBy());
        dto.setProductUpdatedAt(e.getProductUpdatedAt());
        dto.setProductActive(e.getProductActive());
        dto.setIsPropertyIdValueRemoved(e.getIsPropertyIdValueRemoved());
        dto.setIsPropertyVersionRemoved(e.getIsPropertyVersionRemoved());
        dto.setIsPropertyActiveRemoved(e.getIsPropertyActiveRemoved());
        dto.setIsPropertyProductProductTypeIdRemoved(e.getIsPropertyProductProductTypeIdRemoved());
        dto.setIsPropertyProductPrimaryProductCategoryIdRemoved(e.getIsPropertyProductPrimaryProductCategoryIdRemoved());
        dto.setIsPropertyProductManufacturerPartyIdRemoved(e.getIsPropertyProductManufacturerPartyIdRemoved());
        dto.setIsPropertyProductFacilityIdRemoved(e.getIsPropertyProductFacilityIdRemoved());
        dto.setIsPropertyProductIntroductionDateRemoved(e.getIsPropertyProductIntroductionDateRemoved());
        dto.setIsPropertyProductReleaseDateRemoved(e.getIsPropertyProductReleaseDateRemoved());
        dto.setIsPropertyProductSupportDiscontinuationDateRemoved(e.getIsPropertyProductSupportDiscontinuationDateRemoved());
        dto.setIsPropertyProductSalesDiscontinuationDateRemoved(e.getIsPropertyProductSalesDiscontinuationDateRemoved());
        dto.setIsPropertyProductSalesDiscWhenNotAvailRemoved(e.getIsPropertyProductSalesDiscWhenNotAvailRemoved());
        dto.setIsPropertyProductInternalNameRemoved(e.getIsPropertyProductInternalNameRemoved());
        dto.setIsPropertyProductBrandNameRemoved(e.getIsPropertyProductBrandNameRemoved());
        dto.setIsPropertyProductCommentsRemoved(e.getIsPropertyProductCommentsRemoved());
        dto.setIsPropertyProductProductNameRemoved(e.getIsPropertyProductProductNameRemoved());
        dto.setIsPropertyProductDescriptionRemoved(e.getIsPropertyProductDescriptionRemoved());
        dto.setIsPropertyProductPriceDetailTextRemoved(e.getIsPropertyProductPriceDetailTextRemoved());
        dto.setIsPropertyProductSmallImageUrlRemoved(e.getIsPropertyProductSmallImageUrlRemoved());
        dto.setIsPropertyProductMediumImageUrlRemoved(e.getIsPropertyProductMediumImageUrlRemoved());
        dto.setIsPropertyProductLargeImageUrlRemoved(e.getIsPropertyProductLargeImageUrlRemoved());
        dto.setIsPropertyProductDetailImageUrlRemoved(e.getIsPropertyProductDetailImageUrlRemoved());
        dto.setIsPropertyProductOriginalImageUrlRemoved(e.getIsPropertyProductOriginalImageUrlRemoved());
        dto.setIsPropertyProductDetailScreenRemoved(e.getIsPropertyProductDetailScreenRemoved());
        dto.setIsPropertyProductInventoryMessageRemoved(e.getIsPropertyProductInventoryMessageRemoved());
        dto.setIsPropertyProductInventoryItemTypeIdRemoved(e.getIsPropertyProductInventoryItemTypeIdRemoved());
        dto.setIsPropertyProductRequireInventoryRemoved(e.getIsPropertyProductRequireInventoryRemoved());
        dto.setIsPropertyProductQuantityUomIdRemoved(e.getIsPropertyProductQuantityUomIdRemoved());
        dto.setIsPropertyProductQuantityIncludedRemoved(e.getIsPropertyProductQuantityIncludedRemoved());
        dto.setIsPropertyProductPiecesIncludedRemoved(e.getIsPropertyProductPiecesIncludedRemoved());
        dto.setIsPropertyProductRequireAmountRemoved(e.getIsPropertyProductRequireAmountRemoved());
        dto.setIsPropertyProductFixedAmountRemoved(e.getIsPropertyProductFixedAmountRemoved());
        dto.setIsPropertyProductAmountUomTypeIdRemoved(e.getIsPropertyProductAmountUomTypeIdRemoved());
        dto.setIsPropertyProductWeightUomIdRemoved(e.getIsPropertyProductWeightUomIdRemoved());
        dto.setIsPropertyProductShippingWeightRemoved(e.getIsPropertyProductShippingWeightRemoved());
        dto.setIsPropertyProductProductWeightRemoved(e.getIsPropertyProductProductWeightRemoved());
        dto.setIsPropertyProductHeightUomIdRemoved(e.getIsPropertyProductHeightUomIdRemoved());
        dto.setIsPropertyProductProductHeightRemoved(e.getIsPropertyProductProductHeightRemoved());
        dto.setIsPropertyProductShippingHeightRemoved(e.getIsPropertyProductShippingHeightRemoved());
        dto.setIsPropertyProductWidthUomIdRemoved(e.getIsPropertyProductWidthUomIdRemoved());
        dto.setIsPropertyProductProductWidthRemoved(e.getIsPropertyProductProductWidthRemoved());
        dto.setIsPropertyProductShippingWidthRemoved(e.getIsPropertyProductShippingWidthRemoved());
        dto.setIsPropertyProductDepthUomIdRemoved(e.getIsPropertyProductDepthUomIdRemoved());
        dto.setIsPropertyProductProductDepthRemoved(e.getIsPropertyProductProductDepthRemoved());
        dto.setIsPropertyProductShippingDepthRemoved(e.getIsPropertyProductShippingDepthRemoved());
        dto.setIsPropertyProductDiameterUomIdRemoved(e.getIsPropertyProductDiameterUomIdRemoved());
        dto.setIsPropertyProductProductDiameterRemoved(e.getIsPropertyProductProductDiameterRemoved());
        dto.setIsPropertyProductProductRatingRemoved(e.getIsPropertyProductProductRatingRemoved());
        dto.setIsPropertyProductRatingTypeEnumRemoved(e.getIsPropertyProductRatingTypeEnumRemoved());
        dto.setIsPropertyProductReturnableRemoved(e.getIsPropertyProductReturnableRemoved());
        dto.setIsPropertyProductTaxableRemoved(e.getIsPropertyProductTaxableRemoved());
        dto.setIsPropertyProductChargeShippingRemoved(e.getIsPropertyProductChargeShippingRemoved());
        dto.setIsPropertyProductAutoCreateKeywordsRemoved(e.getIsPropertyProductAutoCreateKeywordsRemoved());
        dto.setIsPropertyProductIncludeInPromotionsRemoved(e.getIsPropertyProductIncludeInPromotionsRemoved());
        dto.setIsPropertyProductIsVirtualRemoved(e.getIsPropertyProductIsVirtualRemoved());
        dto.setIsPropertyProductIsVariantRemoved(e.getIsPropertyProductIsVariantRemoved());
        dto.setIsPropertyProductVirtualVariantMethodEnumRemoved(e.getIsPropertyProductVirtualVariantMethodEnumRemoved());
        dto.setIsPropertyProductInShippingBoxRemoved(e.getIsPropertyProductInShippingBoxRemoved());
        dto.setIsPropertyProductDefaultShipmentBoxTypeIdRemoved(e.getIsPropertyProductDefaultShipmentBoxTypeIdRemoved());
        dto.setIsPropertyProductIsSerialNumberedRemoved(e.getIsPropertyProductIsSerialNumberedRemoved());
        dto.setIsPropertyProductIsManagedByLotRemoved(e.getIsPropertyProductIsManagedByLotRemoved());
        dto.setIsPropertyProductAttributeSetIdRemoved(e.getIsPropertyProductAttributeSetIdRemoved());
        dto.setIsPropertyProductAttributeSetInstanceIdRemoved(e.getIsPropertyProductAttributeSetInstanceIdRemoved());
        dto.setIsPropertyProductCreatedByRemoved(e.getIsPropertyProductCreatedByRemoved());
        dto.setIsPropertyProductCreatedAtRemoved(e.getIsPropertyProductCreatedAtRemoved());
        dto.setIsPropertyProductUpdatedByRemoved(e.getIsPropertyProductUpdatedByRemoved());
        dto.setIsPropertyProductUpdatedAtRemoved(e.getIsPropertyProductUpdatedAtRemoved());
        dto.setIsPropertyProductActiveRemoved(e.getIsPropertyProductActiveRemoved());
        return dto;
    }


    public GoodIdentificationMvoStateEventDto.GoodIdentificationMvoStateDeletedDto toGoodIdentificationMvoStateDeletedDto(GoodIdentificationMvoEvent.GoodIdentificationMvoStateDeleted e) {
        GoodIdentificationMvoStateEventDto.GoodIdentificationMvoStateDeletedDto dto = new GoodIdentificationMvoStateEventDto.GoodIdentificationMvoStateDeletedDto();
        dto.setGoodIdentificationMvoEventId(e.getGoodIdentificationMvoEventId());
        dto.setCreatedAt(e.getCreatedAt());
        dto.setCreatedBy(e.getCreatedBy());
        dto.setCommandId(e.getCommandId());
        return dto;
    }

}

