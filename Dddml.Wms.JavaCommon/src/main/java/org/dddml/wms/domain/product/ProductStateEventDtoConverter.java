package org.dddml.wms.domain.product;

import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;

public class ProductStateEventDtoConverter {

    public ProductStateEventDto toProductStateEventDto(AbstractProductStateEvent stateEvent) {
        if (stateEvent instanceof AbstractProductStateEvent.AbstractProductStateCreated) {
            ProductStateEvent.ProductStateCreated e = (ProductStateEvent.ProductStateCreated) stateEvent;
            return toProductStateCreatedDto(e);
        } else if (stateEvent instanceof AbstractProductStateEvent.AbstractProductStateMergePatched) {
            ProductStateEvent.ProductStateMergePatched e = (ProductStateEvent.ProductStateMergePatched) stateEvent;
            return toProductStateMergePatchedDto(e);
        }

        throw DomainError.named("invalidStateEventType", String.format("Invalid state event type: %1$s", stateEvent.getStateEventType()));
    }

    public ProductStateEventDto.ProductStateCreatedDto toProductStateCreatedDto(ProductStateEvent.ProductStateCreated e) {
        ProductStateEventDto.ProductStateCreatedDto dto = new ProductStateEventDto.ProductStateCreatedDto();
        dto.setStateEventId(new ProductStateEventIdDtoWrapper(e.getStateEventId()));
        dto.setCreatedAt(e.getCreatedAt());
        dto.setCreatedBy(e.getCreatedBy());
        dto.setCommandId(e.getCommandId());
        dto.setProductTypeId(e.getProductTypeId());
        dto.setPrimaryProductCategoryId(e.getPrimaryProductCategoryId());
        dto.setManufacturerPartyId(e.getManufacturerPartyId());
        dto.setFacilityId(e.getFacilityId());
        dto.setIntroductionDate(e.getIntroductionDate());
        dto.setReleaseDate(e.getReleaseDate());
        dto.setSupportDiscontinuationDate(e.getSupportDiscontinuationDate());
        dto.setSalesDiscontinuationDate(e.getSalesDiscontinuationDate());
        dto.setSalesDiscWhenNotAvail(e.getSalesDiscWhenNotAvail());
        dto.setInternalName(e.getInternalName());
        dto.setBrandName(e.getBrandName());
        dto.setComments(e.getComments());
        dto.setProductName(e.getProductName());
        dto.setDescription(e.getDescription());
        dto.setPriceDetailText(e.getPriceDetailText());
        dto.setSmallImageUrl(e.getSmallImageUrl());
        dto.setMediumImageUrl(e.getMediumImageUrl());
        dto.setLargeImageUrl(e.getLargeImageUrl());
        dto.setDetailImageUrl(e.getDetailImageUrl());
        dto.setOriginalImageUrl(e.getOriginalImageUrl());
        dto.setDetailScreen(e.getDetailScreen());
        dto.setInventoryMessage(e.getInventoryMessage());
        dto.setInventoryItemTypeId(e.getInventoryItemTypeId());
        dto.setRequireInventory(e.getRequireInventory());
        dto.setQuantityUomId(e.getQuantityUomId());
        dto.setQuantityIncluded(e.getQuantityIncluded());
        dto.setPiecesIncluded(e.getPiecesIncluded());
        dto.setRequireAmount(e.getRequireAmount());
        dto.setFixedAmount(e.getFixedAmount());
        dto.setAmountUomTypeId(e.getAmountUomTypeId());
        dto.setWeightUomId(e.getWeightUomId());
        dto.setShippingWeight(e.getShippingWeight());
        dto.setProductWeight(e.getProductWeight());
        dto.setHeightUomId(e.getHeightUomId());
        dto.setProductHeight(e.getProductHeight());
        dto.setShippingHeight(e.getShippingHeight());
        dto.setWidthUomId(e.getWidthUomId());
        dto.setProductWidth(e.getProductWidth());
        dto.setShippingWidth(e.getShippingWidth());
        dto.setDepthUomId(e.getDepthUomId());
        dto.setProductDepth(e.getProductDepth());
        dto.setShippingDepth(e.getShippingDepth());
        dto.setDiameterUomId(e.getDiameterUomId());
        dto.setProductDiameter(e.getProductDiameter());
        dto.setProductRating(e.getProductRating());
        dto.setRatingTypeEnum(e.getRatingTypeEnum());
        dto.setReturnable(e.getReturnable());
        dto.setTaxable(e.getTaxable());
        dto.setChargeShipping(e.getChargeShipping());
        dto.setAutoCreateKeywords(e.getAutoCreateKeywords());
        dto.setIncludeInPromotions(e.getIncludeInPromotions());
        dto.setIsVirtual(e.getIsVirtual());
        dto.setIsVariant(e.getIsVariant());
        dto.setVirtualVariantMethodEnum(e.getVirtualVariantMethodEnum());
        dto.setInShippingBox(e.getInShippingBox());
        dto.setDefaultShipmentBoxTypeId(e.getDefaultShipmentBoxTypeId());
        dto.setLotIdFilledIn(e.getLotIdFilledIn());
        dto.setAttributeSetId(e.getAttributeSetId());
        dto.setActive(e.getActive());
        return dto;
    }

    public ProductStateEventDto.ProductStateMergePatchedDto toProductStateMergePatchedDto(ProductStateEvent.ProductStateMergePatched e) {
        ProductStateEventDto.ProductStateMergePatchedDto dto = new ProductStateEventDto.ProductStateMergePatchedDto();
        dto.setStateEventId(new ProductStateEventIdDtoWrapper(e.getStateEventId()));
        dto.setCreatedAt(e.getCreatedAt());
        dto.setCreatedBy(e.getCreatedBy());
        dto.setCommandId(e.getCommandId());
        dto.setProductTypeId(e.getProductTypeId());
        dto.setPrimaryProductCategoryId(e.getPrimaryProductCategoryId());
        dto.setManufacturerPartyId(e.getManufacturerPartyId());
        dto.setFacilityId(e.getFacilityId());
        dto.setIntroductionDate(e.getIntroductionDate());
        dto.setReleaseDate(e.getReleaseDate());
        dto.setSupportDiscontinuationDate(e.getSupportDiscontinuationDate());
        dto.setSalesDiscontinuationDate(e.getSalesDiscontinuationDate());
        dto.setSalesDiscWhenNotAvail(e.getSalesDiscWhenNotAvail());
        dto.setInternalName(e.getInternalName());
        dto.setBrandName(e.getBrandName());
        dto.setComments(e.getComments());
        dto.setProductName(e.getProductName());
        dto.setDescription(e.getDescription());
        dto.setPriceDetailText(e.getPriceDetailText());
        dto.setSmallImageUrl(e.getSmallImageUrl());
        dto.setMediumImageUrl(e.getMediumImageUrl());
        dto.setLargeImageUrl(e.getLargeImageUrl());
        dto.setDetailImageUrl(e.getDetailImageUrl());
        dto.setOriginalImageUrl(e.getOriginalImageUrl());
        dto.setDetailScreen(e.getDetailScreen());
        dto.setInventoryMessage(e.getInventoryMessage());
        dto.setInventoryItemTypeId(e.getInventoryItemTypeId());
        dto.setRequireInventory(e.getRequireInventory());
        dto.setQuantityUomId(e.getQuantityUomId());
        dto.setQuantityIncluded(e.getQuantityIncluded());
        dto.setPiecesIncluded(e.getPiecesIncluded());
        dto.setRequireAmount(e.getRequireAmount());
        dto.setFixedAmount(e.getFixedAmount());
        dto.setAmountUomTypeId(e.getAmountUomTypeId());
        dto.setWeightUomId(e.getWeightUomId());
        dto.setShippingWeight(e.getShippingWeight());
        dto.setProductWeight(e.getProductWeight());
        dto.setHeightUomId(e.getHeightUomId());
        dto.setProductHeight(e.getProductHeight());
        dto.setShippingHeight(e.getShippingHeight());
        dto.setWidthUomId(e.getWidthUomId());
        dto.setProductWidth(e.getProductWidth());
        dto.setShippingWidth(e.getShippingWidth());
        dto.setDepthUomId(e.getDepthUomId());
        dto.setProductDepth(e.getProductDepth());
        dto.setShippingDepth(e.getShippingDepth());
        dto.setDiameterUomId(e.getDiameterUomId());
        dto.setProductDiameter(e.getProductDiameter());
        dto.setProductRating(e.getProductRating());
        dto.setRatingTypeEnum(e.getRatingTypeEnum());
        dto.setReturnable(e.getReturnable());
        dto.setTaxable(e.getTaxable());
        dto.setChargeShipping(e.getChargeShipping());
        dto.setAutoCreateKeywords(e.getAutoCreateKeywords());
        dto.setIncludeInPromotions(e.getIncludeInPromotions());
        dto.setIsVirtual(e.getIsVirtual());
        dto.setIsVariant(e.getIsVariant());
        dto.setVirtualVariantMethodEnum(e.getVirtualVariantMethodEnum());
        dto.setInShippingBox(e.getInShippingBox());
        dto.setDefaultShipmentBoxTypeId(e.getDefaultShipmentBoxTypeId());
        dto.setLotIdFilledIn(e.getLotIdFilledIn());
        dto.setAttributeSetId(e.getAttributeSetId());
        dto.setActive(e.getActive());
        dto.setIsPropertyProductTypeIdRemoved(e.getIsPropertyProductTypeIdRemoved());
        dto.setIsPropertyPrimaryProductCategoryIdRemoved(e.getIsPropertyPrimaryProductCategoryIdRemoved());
        dto.setIsPropertyManufacturerPartyIdRemoved(e.getIsPropertyManufacturerPartyIdRemoved());
        dto.setIsPropertyFacilityIdRemoved(e.getIsPropertyFacilityIdRemoved());
        dto.setIsPropertyIntroductionDateRemoved(e.getIsPropertyIntroductionDateRemoved());
        dto.setIsPropertyReleaseDateRemoved(e.getIsPropertyReleaseDateRemoved());
        dto.setIsPropertySupportDiscontinuationDateRemoved(e.getIsPropertySupportDiscontinuationDateRemoved());
        dto.setIsPropertySalesDiscontinuationDateRemoved(e.getIsPropertySalesDiscontinuationDateRemoved());
        dto.setIsPropertySalesDiscWhenNotAvailRemoved(e.getIsPropertySalesDiscWhenNotAvailRemoved());
        dto.setIsPropertyInternalNameRemoved(e.getIsPropertyInternalNameRemoved());
        dto.setIsPropertyBrandNameRemoved(e.getIsPropertyBrandNameRemoved());
        dto.setIsPropertyCommentsRemoved(e.getIsPropertyCommentsRemoved());
        dto.setIsPropertyProductNameRemoved(e.getIsPropertyProductNameRemoved());
        dto.setIsPropertyDescriptionRemoved(e.getIsPropertyDescriptionRemoved());
        dto.setIsPropertyPriceDetailTextRemoved(e.getIsPropertyPriceDetailTextRemoved());
        dto.setIsPropertySmallImageUrlRemoved(e.getIsPropertySmallImageUrlRemoved());
        dto.setIsPropertyMediumImageUrlRemoved(e.getIsPropertyMediumImageUrlRemoved());
        dto.setIsPropertyLargeImageUrlRemoved(e.getIsPropertyLargeImageUrlRemoved());
        dto.setIsPropertyDetailImageUrlRemoved(e.getIsPropertyDetailImageUrlRemoved());
        dto.setIsPropertyOriginalImageUrlRemoved(e.getIsPropertyOriginalImageUrlRemoved());
        dto.setIsPropertyDetailScreenRemoved(e.getIsPropertyDetailScreenRemoved());
        dto.setIsPropertyInventoryMessageRemoved(e.getIsPropertyInventoryMessageRemoved());
        dto.setIsPropertyInventoryItemTypeIdRemoved(e.getIsPropertyInventoryItemTypeIdRemoved());
        dto.setIsPropertyRequireInventoryRemoved(e.getIsPropertyRequireInventoryRemoved());
        dto.setIsPropertyQuantityUomIdRemoved(e.getIsPropertyQuantityUomIdRemoved());
        dto.setIsPropertyQuantityIncludedRemoved(e.getIsPropertyQuantityIncludedRemoved());
        dto.setIsPropertyPiecesIncludedRemoved(e.getIsPropertyPiecesIncludedRemoved());
        dto.setIsPropertyRequireAmountRemoved(e.getIsPropertyRequireAmountRemoved());
        dto.setIsPropertyFixedAmountRemoved(e.getIsPropertyFixedAmountRemoved());
        dto.setIsPropertyAmountUomTypeIdRemoved(e.getIsPropertyAmountUomTypeIdRemoved());
        dto.setIsPropertyWeightUomIdRemoved(e.getIsPropertyWeightUomIdRemoved());
        dto.setIsPropertyShippingWeightRemoved(e.getIsPropertyShippingWeightRemoved());
        dto.setIsPropertyProductWeightRemoved(e.getIsPropertyProductWeightRemoved());
        dto.setIsPropertyHeightUomIdRemoved(e.getIsPropertyHeightUomIdRemoved());
        dto.setIsPropertyProductHeightRemoved(e.getIsPropertyProductHeightRemoved());
        dto.setIsPropertyShippingHeightRemoved(e.getIsPropertyShippingHeightRemoved());
        dto.setIsPropertyWidthUomIdRemoved(e.getIsPropertyWidthUomIdRemoved());
        dto.setIsPropertyProductWidthRemoved(e.getIsPropertyProductWidthRemoved());
        dto.setIsPropertyShippingWidthRemoved(e.getIsPropertyShippingWidthRemoved());
        dto.setIsPropertyDepthUomIdRemoved(e.getIsPropertyDepthUomIdRemoved());
        dto.setIsPropertyProductDepthRemoved(e.getIsPropertyProductDepthRemoved());
        dto.setIsPropertyShippingDepthRemoved(e.getIsPropertyShippingDepthRemoved());
        dto.setIsPropertyDiameterUomIdRemoved(e.getIsPropertyDiameterUomIdRemoved());
        dto.setIsPropertyProductDiameterRemoved(e.getIsPropertyProductDiameterRemoved());
        dto.setIsPropertyProductRatingRemoved(e.getIsPropertyProductRatingRemoved());
        dto.setIsPropertyRatingTypeEnumRemoved(e.getIsPropertyRatingTypeEnumRemoved());
        dto.setIsPropertyReturnableRemoved(e.getIsPropertyReturnableRemoved());
        dto.setIsPropertyTaxableRemoved(e.getIsPropertyTaxableRemoved());
        dto.setIsPropertyChargeShippingRemoved(e.getIsPropertyChargeShippingRemoved());
        dto.setIsPropertyAutoCreateKeywordsRemoved(e.getIsPropertyAutoCreateKeywordsRemoved());
        dto.setIsPropertyIncludeInPromotionsRemoved(e.getIsPropertyIncludeInPromotionsRemoved());
        dto.setIsPropertyIsVirtualRemoved(e.getIsPropertyIsVirtualRemoved());
        dto.setIsPropertyIsVariantRemoved(e.getIsPropertyIsVariantRemoved());
        dto.setIsPropertyVirtualVariantMethodEnumRemoved(e.getIsPropertyVirtualVariantMethodEnumRemoved());
        dto.setIsPropertyInShippingBoxRemoved(e.getIsPropertyInShippingBoxRemoved());
        dto.setIsPropertyDefaultShipmentBoxTypeIdRemoved(e.getIsPropertyDefaultShipmentBoxTypeIdRemoved());
        dto.setIsPropertyLotIdFilledInRemoved(e.getIsPropertyLotIdFilledInRemoved());
        dto.setIsPropertyAttributeSetIdRemoved(e.getIsPropertyAttributeSetIdRemoved());
        dto.setIsPropertyActiveRemoved(e.getIsPropertyActiveRemoved());
        return dto;
    }


}

