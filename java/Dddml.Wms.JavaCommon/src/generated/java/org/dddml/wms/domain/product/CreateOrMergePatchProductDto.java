package org.dddml.wms.domain.product;

import java.util.Date;
import org.dddml.wms.domain.*;

public class CreateOrMergePatchProductDto extends AbstractProductCommandDto
{
    private String productTypeId;

    public String getProductTypeId()
    {
        return this.productTypeId;
    }

    public void setProductTypeId(String productTypeId)
    {
        this.productTypeId = productTypeId;
    }

    private String primaryProductCategoryId;

    public String getPrimaryProductCategoryId()
    {
        return this.primaryProductCategoryId;
    }

    public void setPrimaryProductCategoryId(String primaryProductCategoryId)
    {
        this.primaryProductCategoryId = primaryProductCategoryId;
    }

    private String manufacturerPartyId;

    public String getManufacturerPartyId()
    {
        return this.manufacturerPartyId;
    }

    public void setManufacturerPartyId(String manufacturerPartyId)
    {
        this.manufacturerPartyId = manufacturerPartyId;
    }

    private String facilityId;

    public String getFacilityId()
    {
        return this.facilityId;
    }

    public void setFacilityId(String facilityId)
    {
        this.facilityId = facilityId;
    }

    private java.sql.Timestamp introductionDate;

    public java.sql.Timestamp getIntroductionDate()
    {
        return this.introductionDate;
    }

    public void setIntroductionDate(java.sql.Timestamp introductionDate)
    {
        this.introductionDate = introductionDate;
    }

    private java.sql.Timestamp releaseDate;

    public java.sql.Timestamp getReleaseDate()
    {
        return this.releaseDate;
    }

    public void setReleaseDate(java.sql.Timestamp releaseDate)
    {
        this.releaseDate = releaseDate;
    }

    private java.sql.Timestamp supportDiscontinuationDate;

    public java.sql.Timestamp getSupportDiscontinuationDate()
    {
        return this.supportDiscontinuationDate;
    }

    public void setSupportDiscontinuationDate(java.sql.Timestamp supportDiscontinuationDate)
    {
        this.supportDiscontinuationDate = supportDiscontinuationDate;
    }

    private java.sql.Timestamp salesDiscontinuationDate;

    public java.sql.Timestamp getSalesDiscontinuationDate()
    {
        return this.salesDiscontinuationDate;
    }

    public void setSalesDiscontinuationDate(java.sql.Timestamp salesDiscontinuationDate)
    {
        this.salesDiscontinuationDate = salesDiscontinuationDate;
    }

    private String salesDiscWhenNotAvail;

    public String getSalesDiscWhenNotAvail()
    {
        return this.salesDiscWhenNotAvail;
    }

    public void setSalesDiscWhenNotAvail(String salesDiscWhenNotAvail)
    {
        this.salesDiscWhenNotAvail = salesDiscWhenNotAvail;
    }

    private String internalName;

    public String getInternalName()
    {
        return this.internalName;
    }

    public void setInternalName(String internalName)
    {
        this.internalName = internalName;
    }

    private String brandName;

    public String getBrandName()
    {
        return this.brandName;
    }

    public void setBrandName(String brandName)
    {
        this.brandName = brandName;
    }

    private String comments;

    public String getComments()
    {
        return this.comments;
    }

    public void setComments(String comments)
    {
        this.comments = comments;
    }

    private String productName;

    public String getProductName()
    {
        return this.productName;
    }

    public void setProductName(String productName)
    {
        this.productName = productName;
    }

    private String description;

    public String getDescription()
    {
        return this.description;
    }

    public void setDescription(String description)
    {
        this.description = description;
    }

    private String priceDetailText;

    public String getPriceDetailText()
    {
        return this.priceDetailText;
    }

    public void setPriceDetailText(String priceDetailText)
    {
        this.priceDetailText = priceDetailText;
    }

    private String smallImageUrl;

    public String getSmallImageUrl()
    {
        return this.smallImageUrl;
    }

    public void setSmallImageUrl(String smallImageUrl)
    {
        this.smallImageUrl = smallImageUrl;
    }

    private String mediumImageUrl;

    public String getMediumImageUrl()
    {
        return this.mediumImageUrl;
    }

    public void setMediumImageUrl(String mediumImageUrl)
    {
        this.mediumImageUrl = mediumImageUrl;
    }

    private String largeImageUrl;

    public String getLargeImageUrl()
    {
        return this.largeImageUrl;
    }

    public void setLargeImageUrl(String largeImageUrl)
    {
        this.largeImageUrl = largeImageUrl;
    }

    private String detailImageUrl;

    public String getDetailImageUrl()
    {
        return this.detailImageUrl;
    }

    public void setDetailImageUrl(String detailImageUrl)
    {
        this.detailImageUrl = detailImageUrl;
    }

    private String originalImageUrl;

    public String getOriginalImageUrl()
    {
        return this.originalImageUrl;
    }

    public void setOriginalImageUrl(String originalImageUrl)
    {
        this.originalImageUrl = originalImageUrl;
    }

    private String detailScreen;

    public String getDetailScreen()
    {
        return this.detailScreen;
    }

    public void setDetailScreen(String detailScreen)
    {
        this.detailScreen = detailScreen;
    }

    private String inventoryMessage;

    public String getInventoryMessage()
    {
        return this.inventoryMessage;
    }

    public void setInventoryMessage(String inventoryMessage)
    {
        this.inventoryMessage = inventoryMessage;
    }

    private String inventoryItemTypeId;

    public String getInventoryItemTypeId()
    {
        return this.inventoryItemTypeId;
    }

    public void setInventoryItemTypeId(String inventoryItemTypeId)
    {
        this.inventoryItemTypeId = inventoryItemTypeId;
    }

    private String requireInventory;

    public String getRequireInventory()
    {
        return this.requireInventory;
    }

    public void setRequireInventory(String requireInventory)
    {
        this.requireInventory = requireInventory;
    }

    private String quantityUomId;

    public String getQuantityUomId()
    {
        return this.quantityUomId;
    }

    public void setQuantityUomId(String quantityUomId)
    {
        this.quantityUomId = quantityUomId;
    }

    private java.math.BigDecimal quantityIncluded;

    public java.math.BigDecimal getQuantityIncluded()
    {
        return this.quantityIncluded;
    }

    public void setQuantityIncluded(java.math.BigDecimal quantityIncluded)
    {
        this.quantityIncluded = quantityIncluded;
    }

    private Long piecesIncluded;

    public Long getPiecesIncluded()
    {
        return this.piecesIncluded;
    }

    public void setPiecesIncluded(Long piecesIncluded)
    {
        this.piecesIncluded = piecesIncluded;
    }

    private String requireAmount;

    public String getRequireAmount()
    {
        return this.requireAmount;
    }

    public void setRequireAmount(String requireAmount)
    {
        this.requireAmount = requireAmount;
    }

    private java.math.BigDecimal fixedAmount;

    public java.math.BigDecimal getFixedAmount()
    {
        return this.fixedAmount;
    }

    public void setFixedAmount(java.math.BigDecimal fixedAmount)
    {
        this.fixedAmount = fixedAmount;
    }

    private String amountUomTypeId;

    public String getAmountUomTypeId()
    {
        return this.amountUomTypeId;
    }

    public void setAmountUomTypeId(String amountUomTypeId)
    {
        this.amountUomTypeId = amountUomTypeId;
    }

    private String weightUomId;

    public String getWeightUomId()
    {
        return this.weightUomId;
    }

    public void setWeightUomId(String weightUomId)
    {
        this.weightUomId = weightUomId;
    }

    private java.math.BigDecimal shippingWeight;

    public java.math.BigDecimal getShippingWeight()
    {
        return this.shippingWeight;
    }

    public void setShippingWeight(java.math.BigDecimal shippingWeight)
    {
        this.shippingWeight = shippingWeight;
    }

    private java.math.BigDecimal productWeight;

    public java.math.BigDecimal getProductWeight()
    {
        return this.productWeight;
    }

    public void setProductWeight(java.math.BigDecimal productWeight)
    {
        this.productWeight = productWeight;
    }

    private String heightUomId;

    public String getHeightUomId()
    {
        return this.heightUomId;
    }

    public void setHeightUomId(String heightUomId)
    {
        this.heightUomId = heightUomId;
    }

    private java.math.BigDecimal productHeight;

    public java.math.BigDecimal getProductHeight()
    {
        return this.productHeight;
    }

    public void setProductHeight(java.math.BigDecimal productHeight)
    {
        this.productHeight = productHeight;
    }

    private java.math.BigDecimal shippingHeight;

    public java.math.BigDecimal getShippingHeight()
    {
        return this.shippingHeight;
    }

    public void setShippingHeight(java.math.BigDecimal shippingHeight)
    {
        this.shippingHeight = shippingHeight;
    }

    private String widthUomId;

    public String getWidthUomId()
    {
        return this.widthUomId;
    }

    public void setWidthUomId(String widthUomId)
    {
        this.widthUomId = widthUomId;
    }

    private java.math.BigDecimal productWidth;

    public java.math.BigDecimal getProductWidth()
    {
        return this.productWidth;
    }

    public void setProductWidth(java.math.BigDecimal productWidth)
    {
        this.productWidth = productWidth;
    }

    private java.math.BigDecimal shippingWidth;

    public java.math.BigDecimal getShippingWidth()
    {
        return this.shippingWidth;
    }

    public void setShippingWidth(java.math.BigDecimal shippingWidth)
    {
        this.shippingWidth = shippingWidth;
    }

    private String depthUomId;

    public String getDepthUomId()
    {
        return this.depthUomId;
    }

    public void setDepthUomId(String depthUomId)
    {
        this.depthUomId = depthUomId;
    }

    private java.math.BigDecimal productDepth;

    public java.math.BigDecimal getProductDepth()
    {
        return this.productDepth;
    }

    public void setProductDepth(java.math.BigDecimal productDepth)
    {
        this.productDepth = productDepth;
    }

    private java.math.BigDecimal shippingDepth;

    public java.math.BigDecimal getShippingDepth()
    {
        return this.shippingDepth;
    }

    public void setShippingDepth(java.math.BigDecimal shippingDepth)
    {
        this.shippingDepth = shippingDepth;
    }

    private String diameterUomId;

    public String getDiameterUomId()
    {
        return this.diameterUomId;
    }

    public void setDiameterUomId(String diameterUomId)
    {
        this.diameterUomId = diameterUomId;
    }

    private java.math.BigDecimal productDiameter;

    public java.math.BigDecimal getProductDiameter()
    {
        return this.productDiameter;
    }

    public void setProductDiameter(java.math.BigDecimal productDiameter)
    {
        this.productDiameter = productDiameter;
    }

    private java.math.BigDecimal productRating;

    public java.math.BigDecimal getProductRating()
    {
        return this.productRating;
    }

    public void setProductRating(java.math.BigDecimal productRating)
    {
        this.productRating = productRating;
    }

    private String ratingTypeEnum;

    public String getRatingTypeEnum()
    {
        return this.ratingTypeEnum;
    }

    public void setRatingTypeEnum(String ratingTypeEnum)
    {
        this.ratingTypeEnum = ratingTypeEnum;
    }

    private String returnable;

    public String getReturnable()
    {
        return this.returnable;
    }

    public void setReturnable(String returnable)
    {
        this.returnable = returnable;
    }

    private String taxable;

    public String getTaxable()
    {
        return this.taxable;
    }

    public void setTaxable(String taxable)
    {
        this.taxable = taxable;
    }

    private String chargeShipping;

    public String getChargeShipping()
    {
        return this.chargeShipping;
    }

    public void setChargeShipping(String chargeShipping)
    {
        this.chargeShipping = chargeShipping;
    }

    private String autoCreateKeywords;

    public String getAutoCreateKeywords()
    {
        return this.autoCreateKeywords;
    }

    public void setAutoCreateKeywords(String autoCreateKeywords)
    {
        this.autoCreateKeywords = autoCreateKeywords;
    }

    private String includeInPromotions;

    public String getIncludeInPromotions()
    {
        return this.includeInPromotions;
    }

    public void setIncludeInPromotions(String includeInPromotions)
    {
        this.includeInPromotions = includeInPromotions;
    }

    private String isVirtual;

    public String getIsVirtual()
    {
        return this.isVirtual;
    }

    public void setIsVirtual(String isVirtual)
    {
        this.isVirtual = isVirtual;
    }

    private String isVariant;

    public String getIsVariant()
    {
        return this.isVariant;
    }

    public void setIsVariant(String isVariant)
    {
        this.isVariant = isVariant;
    }

    private String virtualVariantMethodEnum;

    public String getVirtualVariantMethodEnum()
    {
        return this.virtualVariantMethodEnum;
    }

    public void setVirtualVariantMethodEnum(String virtualVariantMethodEnum)
    {
        this.virtualVariantMethodEnum = virtualVariantMethodEnum;
    }

    private String inShippingBox;

    public String getInShippingBox()
    {
        return this.inShippingBox;
    }

    public void setInShippingBox(String inShippingBox)
    {
        this.inShippingBox = inShippingBox;
    }

    private String defaultShipmentBoxTypeId;

    public String getDefaultShipmentBoxTypeId()
    {
        return this.defaultShipmentBoxTypeId;
    }

    public void setDefaultShipmentBoxTypeId(String defaultShipmentBoxTypeId)
    {
        this.defaultShipmentBoxTypeId = defaultShipmentBoxTypeId;
    }

    private Boolean isSerialNumbered;

    public Boolean getIsSerialNumbered()
    {
        return this.isSerialNumbered;
    }

    public void setIsSerialNumbered(Boolean isSerialNumbered)
    {
        this.isSerialNumbered = isSerialNumbered;
    }

    private Boolean isManagedByLot;

    public Boolean getIsManagedByLot()
    {
        return this.isManagedByLot;
    }

    public void setIsManagedByLot(Boolean isManagedByLot)
    {
        this.isManagedByLot = isManagedByLot;
    }

    private String attributeSetId;

    public String getAttributeSetId()
    {
        return this.attributeSetId;
    }

    public void setAttributeSetId(String attributeSetId)
    {
        this.attributeSetId = attributeSetId;
    }

    private String attributeSetInstanceId;

    public String getAttributeSetInstanceId()
    {
        return this.attributeSetInstanceId;
    }

    public void setAttributeSetInstanceId(String attributeSetInstanceId)
    {
        this.attributeSetInstanceId = attributeSetInstanceId;
    }

    private Boolean active;

    public Boolean getActive()
    {
        return this.active;
    }

    public void setActive(Boolean active)
    {
        this.active = active;
    }

    private CreateOrMergePatchGoodIdentificationDto[] goodIdentifications;

    public CreateOrMergePatchGoodIdentificationDto[] getGoodIdentifications()
    {
        return this.goodIdentifications;
    }

    public void setGoodIdentifications(CreateOrMergePatchGoodIdentificationDto[] goodIdentifications)
    {
        this.goodIdentifications = goodIdentifications;
    }

    private Boolean isPropertyProductTypeIdRemoved;

    public Boolean getIsPropertyProductTypeIdRemoved()
    {
        return this.isPropertyProductTypeIdRemoved;
    }

    public void setIsPropertyProductTypeIdRemoved(Boolean removed)
    {
        this.isPropertyProductTypeIdRemoved = removed;
    }

    private Boolean isPropertyPrimaryProductCategoryIdRemoved;

    public Boolean getIsPropertyPrimaryProductCategoryIdRemoved()
    {
        return this.isPropertyPrimaryProductCategoryIdRemoved;
    }

    public void setIsPropertyPrimaryProductCategoryIdRemoved(Boolean removed)
    {
        this.isPropertyPrimaryProductCategoryIdRemoved = removed;
    }

    private Boolean isPropertyManufacturerPartyIdRemoved;

    public Boolean getIsPropertyManufacturerPartyIdRemoved()
    {
        return this.isPropertyManufacturerPartyIdRemoved;
    }

    public void setIsPropertyManufacturerPartyIdRemoved(Boolean removed)
    {
        this.isPropertyManufacturerPartyIdRemoved = removed;
    }

    private Boolean isPropertyFacilityIdRemoved;

    public Boolean getIsPropertyFacilityIdRemoved()
    {
        return this.isPropertyFacilityIdRemoved;
    }

    public void setIsPropertyFacilityIdRemoved(Boolean removed)
    {
        this.isPropertyFacilityIdRemoved = removed;
    }

    private Boolean isPropertyIntroductionDateRemoved;

    public Boolean getIsPropertyIntroductionDateRemoved()
    {
        return this.isPropertyIntroductionDateRemoved;
    }

    public void setIsPropertyIntroductionDateRemoved(Boolean removed)
    {
        this.isPropertyIntroductionDateRemoved = removed;
    }

    private Boolean isPropertyReleaseDateRemoved;

    public Boolean getIsPropertyReleaseDateRemoved()
    {
        return this.isPropertyReleaseDateRemoved;
    }

    public void setIsPropertyReleaseDateRemoved(Boolean removed)
    {
        this.isPropertyReleaseDateRemoved = removed;
    }

    private Boolean isPropertySupportDiscontinuationDateRemoved;

    public Boolean getIsPropertySupportDiscontinuationDateRemoved()
    {
        return this.isPropertySupportDiscontinuationDateRemoved;
    }

    public void setIsPropertySupportDiscontinuationDateRemoved(Boolean removed)
    {
        this.isPropertySupportDiscontinuationDateRemoved = removed;
    }

    private Boolean isPropertySalesDiscontinuationDateRemoved;

    public Boolean getIsPropertySalesDiscontinuationDateRemoved()
    {
        return this.isPropertySalesDiscontinuationDateRemoved;
    }

    public void setIsPropertySalesDiscontinuationDateRemoved(Boolean removed)
    {
        this.isPropertySalesDiscontinuationDateRemoved = removed;
    }

    private Boolean isPropertySalesDiscWhenNotAvailRemoved;

    public Boolean getIsPropertySalesDiscWhenNotAvailRemoved()
    {
        return this.isPropertySalesDiscWhenNotAvailRemoved;
    }

    public void setIsPropertySalesDiscWhenNotAvailRemoved(Boolean removed)
    {
        this.isPropertySalesDiscWhenNotAvailRemoved = removed;
    }

    private Boolean isPropertyInternalNameRemoved;

    public Boolean getIsPropertyInternalNameRemoved()
    {
        return this.isPropertyInternalNameRemoved;
    }

    public void setIsPropertyInternalNameRemoved(Boolean removed)
    {
        this.isPropertyInternalNameRemoved = removed;
    }

    private Boolean isPropertyBrandNameRemoved;

    public Boolean getIsPropertyBrandNameRemoved()
    {
        return this.isPropertyBrandNameRemoved;
    }

    public void setIsPropertyBrandNameRemoved(Boolean removed)
    {
        this.isPropertyBrandNameRemoved = removed;
    }

    private Boolean isPropertyCommentsRemoved;

    public Boolean getIsPropertyCommentsRemoved()
    {
        return this.isPropertyCommentsRemoved;
    }

    public void setIsPropertyCommentsRemoved(Boolean removed)
    {
        this.isPropertyCommentsRemoved = removed;
    }

    private Boolean isPropertyProductNameRemoved;

    public Boolean getIsPropertyProductNameRemoved()
    {
        return this.isPropertyProductNameRemoved;
    }

    public void setIsPropertyProductNameRemoved(Boolean removed)
    {
        this.isPropertyProductNameRemoved = removed;
    }

    private Boolean isPropertyDescriptionRemoved;

    public Boolean getIsPropertyDescriptionRemoved()
    {
        return this.isPropertyDescriptionRemoved;
    }

    public void setIsPropertyDescriptionRemoved(Boolean removed)
    {
        this.isPropertyDescriptionRemoved = removed;
    }

    private Boolean isPropertyPriceDetailTextRemoved;

    public Boolean getIsPropertyPriceDetailTextRemoved()
    {
        return this.isPropertyPriceDetailTextRemoved;
    }

    public void setIsPropertyPriceDetailTextRemoved(Boolean removed)
    {
        this.isPropertyPriceDetailTextRemoved = removed;
    }

    private Boolean isPropertySmallImageUrlRemoved;

    public Boolean getIsPropertySmallImageUrlRemoved()
    {
        return this.isPropertySmallImageUrlRemoved;
    }

    public void setIsPropertySmallImageUrlRemoved(Boolean removed)
    {
        this.isPropertySmallImageUrlRemoved = removed;
    }

    private Boolean isPropertyMediumImageUrlRemoved;

    public Boolean getIsPropertyMediumImageUrlRemoved()
    {
        return this.isPropertyMediumImageUrlRemoved;
    }

    public void setIsPropertyMediumImageUrlRemoved(Boolean removed)
    {
        this.isPropertyMediumImageUrlRemoved = removed;
    }

    private Boolean isPropertyLargeImageUrlRemoved;

    public Boolean getIsPropertyLargeImageUrlRemoved()
    {
        return this.isPropertyLargeImageUrlRemoved;
    }

    public void setIsPropertyLargeImageUrlRemoved(Boolean removed)
    {
        this.isPropertyLargeImageUrlRemoved = removed;
    }

    private Boolean isPropertyDetailImageUrlRemoved;

    public Boolean getIsPropertyDetailImageUrlRemoved()
    {
        return this.isPropertyDetailImageUrlRemoved;
    }

    public void setIsPropertyDetailImageUrlRemoved(Boolean removed)
    {
        this.isPropertyDetailImageUrlRemoved = removed;
    }

    private Boolean isPropertyOriginalImageUrlRemoved;

    public Boolean getIsPropertyOriginalImageUrlRemoved()
    {
        return this.isPropertyOriginalImageUrlRemoved;
    }

    public void setIsPropertyOriginalImageUrlRemoved(Boolean removed)
    {
        this.isPropertyOriginalImageUrlRemoved = removed;
    }

    private Boolean isPropertyDetailScreenRemoved;

    public Boolean getIsPropertyDetailScreenRemoved()
    {
        return this.isPropertyDetailScreenRemoved;
    }

    public void setIsPropertyDetailScreenRemoved(Boolean removed)
    {
        this.isPropertyDetailScreenRemoved = removed;
    }

    private Boolean isPropertyInventoryMessageRemoved;

    public Boolean getIsPropertyInventoryMessageRemoved()
    {
        return this.isPropertyInventoryMessageRemoved;
    }

    public void setIsPropertyInventoryMessageRemoved(Boolean removed)
    {
        this.isPropertyInventoryMessageRemoved = removed;
    }

    private Boolean isPropertyInventoryItemTypeIdRemoved;

    public Boolean getIsPropertyInventoryItemTypeIdRemoved()
    {
        return this.isPropertyInventoryItemTypeIdRemoved;
    }

    public void setIsPropertyInventoryItemTypeIdRemoved(Boolean removed)
    {
        this.isPropertyInventoryItemTypeIdRemoved = removed;
    }

    private Boolean isPropertyRequireInventoryRemoved;

    public Boolean getIsPropertyRequireInventoryRemoved()
    {
        return this.isPropertyRequireInventoryRemoved;
    }

    public void setIsPropertyRequireInventoryRemoved(Boolean removed)
    {
        this.isPropertyRequireInventoryRemoved = removed;
    }

    private Boolean isPropertyQuantityUomIdRemoved;

    public Boolean getIsPropertyQuantityUomIdRemoved()
    {
        return this.isPropertyQuantityUomIdRemoved;
    }

    public void setIsPropertyQuantityUomIdRemoved(Boolean removed)
    {
        this.isPropertyQuantityUomIdRemoved = removed;
    }

    private Boolean isPropertyQuantityIncludedRemoved;

    public Boolean getIsPropertyQuantityIncludedRemoved()
    {
        return this.isPropertyQuantityIncludedRemoved;
    }

    public void setIsPropertyQuantityIncludedRemoved(Boolean removed)
    {
        this.isPropertyQuantityIncludedRemoved = removed;
    }

    private Boolean isPropertyPiecesIncludedRemoved;

    public Boolean getIsPropertyPiecesIncludedRemoved()
    {
        return this.isPropertyPiecesIncludedRemoved;
    }

    public void setIsPropertyPiecesIncludedRemoved(Boolean removed)
    {
        this.isPropertyPiecesIncludedRemoved = removed;
    }

    private Boolean isPropertyRequireAmountRemoved;

    public Boolean getIsPropertyRequireAmountRemoved()
    {
        return this.isPropertyRequireAmountRemoved;
    }

    public void setIsPropertyRequireAmountRemoved(Boolean removed)
    {
        this.isPropertyRequireAmountRemoved = removed;
    }

    private Boolean isPropertyFixedAmountRemoved;

    public Boolean getIsPropertyFixedAmountRemoved()
    {
        return this.isPropertyFixedAmountRemoved;
    }

    public void setIsPropertyFixedAmountRemoved(Boolean removed)
    {
        this.isPropertyFixedAmountRemoved = removed;
    }

    private Boolean isPropertyAmountUomTypeIdRemoved;

    public Boolean getIsPropertyAmountUomTypeIdRemoved()
    {
        return this.isPropertyAmountUomTypeIdRemoved;
    }

    public void setIsPropertyAmountUomTypeIdRemoved(Boolean removed)
    {
        this.isPropertyAmountUomTypeIdRemoved = removed;
    }

    private Boolean isPropertyWeightUomIdRemoved;

    public Boolean getIsPropertyWeightUomIdRemoved()
    {
        return this.isPropertyWeightUomIdRemoved;
    }

    public void setIsPropertyWeightUomIdRemoved(Boolean removed)
    {
        this.isPropertyWeightUomIdRemoved = removed;
    }

    private Boolean isPropertyShippingWeightRemoved;

    public Boolean getIsPropertyShippingWeightRemoved()
    {
        return this.isPropertyShippingWeightRemoved;
    }

    public void setIsPropertyShippingWeightRemoved(Boolean removed)
    {
        this.isPropertyShippingWeightRemoved = removed;
    }

    private Boolean isPropertyProductWeightRemoved;

    public Boolean getIsPropertyProductWeightRemoved()
    {
        return this.isPropertyProductWeightRemoved;
    }

    public void setIsPropertyProductWeightRemoved(Boolean removed)
    {
        this.isPropertyProductWeightRemoved = removed;
    }

    private Boolean isPropertyHeightUomIdRemoved;

    public Boolean getIsPropertyHeightUomIdRemoved()
    {
        return this.isPropertyHeightUomIdRemoved;
    }

    public void setIsPropertyHeightUomIdRemoved(Boolean removed)
    {
        this.isPropertyHeightUomIdRemoved = removed;
    }

    private Boolean isPropertyProductHeightRemoved;

    public Boolean getIsPropertyProductHeightRemoved()
    {
        return this.isPropertyProductHeightRemoved;
    }

    public void setIsPropertyProductHeightRemoved(Boolean removed)
    {
        this.isPropertyProductHeightRemoved = removed;
    }

    private Boolean isPropertyShippingHeightRemoved;

    public Boolean getIsPropertyShippingHeightRemoved()
    {
        return this.isPropertyShippingHeightRemoved;
    }

    public void setIsPropertyShippingHeightRemoved(Boolean removed)
    {
        this.isPropertyShippingHeightRemoved = removed;
    }

    private Boolean isPropertyWidthUomIdRemoved;

    public Boolean getIsPropertyWidthUomIdRemoved()
    {
        return this.isPropertyWidthUomIdRemoved;
    }

    public void setIsPropertyWidthUomIdRemoved(Boolean removed)
    {
        this.isPropertyWidthUomIdRemoved = removed;
    }

    private Boolean isPropertyProductWidthRemoved;

    public Boolean getIsPropertyProductWidthRemoved()
    {
        return this.isPropertyProductWidthRemoved;
    }

    public void setIsPropertyProductWidthRemoved(Boolean removed)
    {
        this.isPropertyProductWidthRemoved = removed;
    }

    private Boolean isPropertyShippingWidthRemoved;

    public Boolean getIsPropertyShippingWidthRemoved()
    {
        return this.isPropertyShippingWidthRemoved;
    }

    public void setIsPropertyShippingWidthRemoved(Boolean removed)
    {
        this.isPropertyShippingWidthRemoved = removed;
    }

    private Boolean isPropertyDepthUomIdRemoved;

    public Boolean getIsPropertyDepthUomIdRemoved()
    {
        return this.isPropertyDepthUomIdRemoved;
    }

    public void setIsPropertyDepthUomIdRemoved(Boolean removed)
    {
        this.isPropertyDepthUomIdRemoved = removed;
    }

    private Boolean isPropertyProductDepthRemoved;

    public Boolean getIsPropertyProductDepthRemoved()
    {
        return this.isPropertyProductDepthRemoved;
    }

    public void setIsPropertyProductDepthRemoved(Boolean removed)
    {
        this.isPropertyProductDepthRemoved = removed;
    }

    private Boolean isPropertyShippingDepthRemoved;

    public Boolean getIsPropertyShippingDepthRemoved()
    {
        return this.isPropertyShippingDepthRemoved;
    }

    public void setIsPropertyShippingDepthRemoved(Boolean removed)
    {
        this.isPropertyShippingDepthRemoved = removed;
    }

    private Boolean isPropertyDiameterUomIdRemoved;

    public Boolean getIsPropertyDiameterUomIdRemoved()
    {
        return this.isPropertyDiameterUomIdRemoved;
    }

    public void setIsPropertyDiameterUomIdRemoved(Boolean removed)
    {
        this.isPropertyDiameterUomIdRemoved = removed;
    }

    private Boolean isPropertyProductDiameterRemoved;

    public Boolean getIsPropertyProductDiameterRemoved()
    {
        return this.isPropertyProductDiameterRemoved;
    }

    public void setIsPropertyProductDiameterRemoved(Boolean removed)
    {
        this.isPropertyProductDiameterRemoved = removed;
    }

    private Boolean isPropertyProductRatingRemoved;

    public Boolean getIsPropertyProductRatingRemoved()
    {
        return this.isPropertyProductRatingRemoved;
    }

    public void setIsPropertyProductRatingRemoved(Boolean removed)
    {
        this.isPropertyProductRatingRemoved = removed;
    }

    private Boolean isPropertyRatingTypeEnumRemoved;

    public Boolean getIsPropertyRatingTypeEnumRemoved()
    {
        return this.isPropertyRatingTypeEnumRemoved;
    }

    public void setIsPropertyRatingTypeEnumRemoved(Boolean removed)
    {
        this.isPropertyRatingTypeEnumRemoved = removed;
    }

    private Boolean isPropertyReturnableRemoved;

    public Boolean getIsPropertyReturnableRemoved()
    {
        return this.isPropertyReturnableRemoved;
    }

    public void setIsPropertyReturnableRemoved(Boolean removed)
    {
        this.isPropertyReturnableRemoved = removed;
    }

    private Boolean isPropertyTaxableRemoved;

    public Boolean getIsPropertyTaxableRemoved()
    {
        return this.isPropertyTaxableRemoved;
    }

    public void setIsPropertyTaxableRemoved(Boolean removed)
    {
        this.isPropertyTaxableRemoved = removed;
    }

    private Boolean isPropertyChargeShippingRemoved;

    public Boolean getIsPropertyChargeShippingRemoved()
    {
        return this.isPropertyChargeShippingRemoved;
    }

    public void setIsPropertyChargeShippingRemoved(Boolean removed)
    {
        this.isPropertyChargeShippingRemoved = removed;
    }

    private Boolean isPropertyAutoCreateKeywordsRemoved;

    public Boolean getIsPropertyAutoCreateKeywordsRemoved()
    {
        return this.isPropertyAutoCreateKeywordsRemoved;
    }

    public void setIsPropertyAutoCreateKeywordsRemoved(Boolean removed)
    {
        this.isPropertyAutoCreateKeywordsRemoved = removed;
    }

    private Boolean isPropertyIncludeInPromotionsRemoved;

    public Boolean getIsPropertyIncludeInPromotionsRemoved()
    {
        return this.isPropertyIncludeInPromotionsRemoved;
    }

    public void setIsPropertyIncludeInPromotionsRemoved(Boolean removed)
    {
        this.isPropertyIncludeInPromotionsRemoved = removed;
    }

    private Boolean isPropertyIsVirtualRemoved;

    public Boolean getIsPropertyIsVirtualRemoved()
    {
        return this.isPropertyIsVirtualRemoved;
    }

    public void setIsPropertyIsVirtualRemoved(Boolean removed)
    {
        this.isPropertyIsVirtualRemoved = removed;
    }

    private Boolean isPropertyIsVariantRemoved;

    public Boolean getIsPropertyIsVariantRemoved()
    {
        return this.isPropertyIsVariantRemoved;
    }

    public void setIsPropertyIsVariantRemoved(Boolean removed)
    {
        this.isPropertyIsVariantRemoved = removed;
    }

    private Boolean isPropertyVirtualVariantMethodEnumRemoved;

    public Boolean getIsPropertyVirtualVariantMethodEnumRemoved()
    {
        return this.isPropertyVirtualVariantMethodEnumRemoved;
    }

    public void setIsPropertyVirtualVariantMethodEnumRemoved(Boolean removed)
    {
        this.isPropertyVirtualVariantMethodEnumRemoved = removed;
    }

    private Boolean isPropertyInShippingBoxRemoved;

    public Boolean getIsPropertyInShippingBoxRemoved()
    {
        return this.isPropertyInShippingBoxRemoved;
    }

    public void setIsPropertyInShippingBoxRemoved(Boolean removed)
    {
        this.isPropertyInShippingBoxRemoved = removed;
    }

    private Boolean isPropertyDefaultShipmentBoxTypeIdRemoved;

    public Boolean getIsPropertyDefaultShipmentBoxTypeIdRemoved()
    {
        return this.isPropertyDefaultShipmentBoxTypeIdRemoved;
    }

    public void setIsPropertyDefaultShipmentBoxTypeIdRemoved(Boolean removed)
    {
        this.isPropertyDefaultShipmentBoxTypeIdRemoved = removed;
    }

    private Boolean isPropertyIsSerialNumberedRemoved;

    public Boolean getIsPropertyIsSerialNumberedRemoved()
    {
        return this.isPropertyIsSerialNumberedRemoved;
    }

    public void setIsPropertyIsSerialNumberedRemoved(Boolean removed)
    {
        this.isPropertyIsSerialNumberedRemoved = removed;
    }

    private Boolean isPropertyIsManagedByLotRemoved;

    public Boolean getIsPropertyIsManagedByLotRemoved()
    {
        return this.isPropertyIsManagedByLotRemoved;
    }

    public void setIsPropertyIsManagedByLotRemoved(Boolean removed)
    {
        this.isPropertyIsManagedByLotRemoved = removed;
    }

    private Boolean isPropertyAttributeSetIdRemoved;

    public Boolean getIsPropertyAttributeSetIdRemoved()
    {
        return this.isPropertyAttributeSetIdRemoved;
    }

    public void setIsPropertyAttributeSetIdRemoved(Boolean removed)
    {
        this.isPropertyAttributeSetIdRemoved = removed;
    }

    private Boolean isPropertyAttributeSetInstanceIdRemoved;

    public Boolean getIsPropertyAttributeSetInstanceIdRemoved()
    {
        return this.isPropertyAttributeSetInstanceIdRemoved;
    }

    public void setIsPropertyAttributeSetInstanceIdRemoved(Boolean removed)
    {
        this.isPropertyAttributeSetInstanceIdRemoved = removed;
    }

    private Boolean isPropertyActiveRemoved;

    public Boolean getIsPropertyActiveRemoved()
    {
        return this.isPropertyActiveRemoved;
    }

    public void setIsPropertyActiveRemoved(Boolean removed)
    {
        this.isPropertyActiveRemoved = removed;
    }

    public void copyTo(AbstractProductCommand.AbstractCreateOrMergePatchProduct command)
    {
        ((AbstractProductCommandDto) this).copyTo(command);
        command.setProductTypeId(this.getProductTypeId());
        command.setPrimaryProductCategoryId(this.getPrimaryProductCategoryId());
        command.setManufacturerPartyId(this.getManufacturerPartyId());
        command.setFacilityId(this.getFacilityId());
        command.setIntroductionDate(this.getIntroductionDate());
        command.setReleaseDate(this.getReleaseDate());
        command.setSupportDiscontinuationDate(this.getSupportDiscontinuationDate());
        command.setSalesDiscontinuationDate(this.getSalesDiscontinuationDate());
        command.setSalesDiscWhenNotAvail(this.getSalesDiscWhenNotAvail());
        command.setInternalName(this.getInternalName());
        command.setBrandName(this.getBrandName());
        command.setComments(this.getComments());
        command.setProductName(this.getProductName());
        command.setDescription(this.getDescription());
        command.setPriceDetailText(this.getPriceDetailText());
        command.setSmallImageUrl(this.getSmallImageUrl());
        command.setMediumImageUrl(this.getMediumImageUrl());
        command.setLargeImageUrl(this.getLargeImageUrl());
        command.setDetailImageUrl(this.getDetailImageUrl());
        command.setOriginalImageUrl(this.getOriginalImageUrl());
        command.setDetailScreen(this.getDetailScreen());
        command.setInventoryMessage(this.getInventoryMessage());
        command.setInventoryItemTypeId(this.getInventoryItemTypeId());
        command.setRequireInventory(this.getRequireInventory());
        command.setQuantityUomId(this.getQuantityUomId());
        command.setQuantityIncluded(this.getQuantityIncluded());
        command.setPiecesIncluded(this.getPiecesIncluded());
        command.setRequireAmount(this.getRequireAmount());
        command.setFixedAmount(this.getFixedAmount());
        command.setAmountUomTypeId(this.getAmountUomTypeId());
        command.setWeightUomId(this.getWeightUomId());
        command.setShippingWeight(this.getShippingWeight());
        command.setProductWeight(this.getProductWeight());
        command.setHeightUomId(this.getHeightUomId());
        command.setProductHeight(this.getProductHeight());
        command.setShippingHeight(this.getShippingHeight());
        command.setWidthUomId(this.getWidthUomId());
        command.setProductWidth(this.getProductWidth());
        command.setShippingWidth(this.getShippingWidth());
        command.setDepthUomId(this.getDepthUomId());
        command.setProductDepth(this.getProductDepth());
        command.setShippingDepth(this.getShippingDepth());
        command.setDiameterUomId(this.getDiameterUomId());
        command.setProductDiameter(this.getProductDiameter());
        command.setProductRating(this.getProductRating());
        command.setRatingTypeEnum(this.getRatingTypeEnum());
        command.setReturnable(this.getReturnable());
        command.setTaxable(this.getTaxable());
        command.setChargeShipping(this.getChargeShipping());
        command.setAutoCreateKeywords(this.getAutoCreateKeywords());
        command.setIncludeInPromotions(this.getIncludeInPromotions());
        command.setIsVirtual(this.getIsVirtual());
        command.setIsVariant(this.getIsVariant());
        command.setVirtualVariantMethodEnum(this.getVirtualVariantMethodEnum());
        command.setInShippingBox(this.getInShippingBox());
        command.setDefaultShipmentBoxTypeId(this.getDefaultShipmentBoxTypeId());
        command.setIsSerialNumbered(this.getIsSerialNumbered());
        command.setIsManagedByLot(this.getIsManagedByLot());
        command.setAttributeSetId(this.getAttributeSetId());
        command.setAttributeSetInstanceId(this.getAttributeSetInstanceId());
        command.setActive(this.getActive());
    }

    public ProductCommand toCommand()
    {
        if (getCommandType() == null) {
            setCommandType(COMMAND_TYPE_MERGE_PATCH);
        }
        if (COMMAND_TYPE_CREATE.equals(getCommandType())) {
            AbstractProductCommand.SimpleCreateProduct command = new AbstractProductCommand.SimpleCreateProduct();
            copyTo((AbstractProductCommand.AbstractCreateProduct) command);
            if (this.getGoodIdentifications() != null) {
                for (CreateOrMergePatchGoodIdentificationDto cmd : this.getGoodIdentifications()) {
                    command.getGoodIdentifications().add((GoodIdentificationCommand.CreateGoodIdentification) cmd.toCommand());
                }
            }
            return command;
        } else if (COMMAND_TYPE_MERGE_PATCH.equals(getCommandType())) {
            AbstractProductCommand.SimpleMergePatchProduct command = new AbstractProductCommand.SimpleMergePatchProduct();
            copyTo((AbstractProductCommand.SimpleMergePatchProduct) command);
            if (this.getGoodIdentifications() != null) {
                for (CreateOrMergePatchGoodIdentificationDto cmd : this.getGoodIdentifications()) {
                    command.getGoodIdentificationCommands().add(cmd.toCommand());
                }
            }
            return command;
        } 
        throw new IllegalStateException("Unknown command type:" + getCommandType());
    }

    public void copyTo(AbstractProductCommand.AbstractCreateProduct command)
    {
        copyTo((AbstractProductCommand.AbstractCreateOrMergePatchProduct) command);
    }

    public void copyTo(AbstractProductCommand.AbstractMergePatchProduct command)
    {
        copyTo((AbstractProductCommand.AbstractCreateOrMergePatchProduct) command);
        command.setIsPropertyProductTypeIdRemoved(this.getIsPropertyProductTypeIdRemoved());
        command.setIsPropertyPrimaryProductCategoryIdRemoved(this.getIsPropertyPrimaryProductCategoryIdRemoved());
        command.setIsPropertyManufacturerPartyIdRemoved(this.getIsPropertyManufacturerPartyIdRemoved());
        command.setIsPropertyFacilityIdRemoved(this.getIsPropertyFacilityIdRemoved());
        command.setIsPropertyIntroductionDateRemoved(this.getIsPropertyIntroductionDateRemoved());
        command.setIsPropertyReleaseDateRemoved(this.getIsPropertyReleaseDateRemoved());
        command.setIsPropertySupportDiscontinuationDateRemoved(this.getIsPropertySupportDiscontinuationDateRemoved());
        command.setIsPropertySalesDiscontinuationDateRemoved(this.getIsPropertySalesDiscontinuationDateRemoved());
        command.setIsPropertySalesDiscWhenNotAvailRemoved(this.getIsPropertySalesDiscWhenNotAvailRemoved());
        command.setIsPropertyInternalNameRemoved(this.getIsPropertyInternalNameRemoved());
        command.setIsPropertyBrandNameRemoved(this.getIsPropertyBrandNameRemoved());
        command.setIsPropertyCommentsRemoved(this.getIsPropertyCommentsRemoved());
        command.setIsPropertyProductNameRemoved(this.getIsPropertyProductNameRemoved());
        command.setIsPropertyDescriptionRemoved(this.getIsPropertyDescriptionRemoved());
        command.setIsPropertyPriceDetailTextRemoved(this.getIsPropertyPriceDetailTextRemoved());
        command.setIsPropertySmallImageUrlRemoved(this.getIsPropertySmallImageUrlRemoved());
        command.setIsPropertyMediumImageUrlRemoved(this.getIsPropertyMediumImageUrlRemoved());
        command.setIsPropertyLargeImageUrlRemoved(this.getIsPropertyLargeImageUrlRemoved());
        command.setIsPropertyDetailImageUrlRemoved(this.getIsPropertyDetailImageUrlRemoved());
        command.setIsPropertyOriginalImageUrlRemoved(this.getIsPropertyOriginalImageUrlRemoved());
        command.setIsPropertyDetailScreenRemoved(this.getIsPropertyDetailScreenRemoved());
        command.setIsPropertyInventoryMessageRemoved(this.getIsPropertyInventoryMessageRemoved());
        command.setIsPropertyInventoryItemTypeIdRemoved(this.getIsPropertyInventoryItemTypeIdRemoved());
        command.setIsPropertyRequireInventoryRemoved(this.getIsPropertyRequireInventoryRemoved());
        command.setIsPropertyQuantityUomIdRemoved(this.getIsPropertyQuantityUomIdRemoved());
        command.setIsPropertyQuantityIncludedRemoved(this.getIsPropertyQuantityIncludedRemoved());
        command.setIsPropertyPiecesIncludedRemoved(this.getIsPropertyPiecesIncludedRemoved());
        command.setIsPropertyRequireAmountRemoved(this.getIsPropertyRequireAmountRemoved());
        command.setIsPropertyFixedAmountRemoved(this.getIsPropertyFixedAmountRemoved());
        command.setIsPropertyAmountUomTypeIdRemoved(this.getIsPropertyAmountUomTypeIdRemoved());
        command.setIsPropertyWeightUomIdRemoved(this.getIsPropertyWeightUomIdRemoved());
        command.setIsPropertyShippingWeightRemoved(this.getIsPropertyShippingWeightRemoved());
        command.setIsPropertyProductWeightRemoved(this.getIsPropertyProductWeightRemoved());
        command.setIsPropertyHeightUomIdRemoved(this.getIsPropertyHeightUomIdRemoved());
        command.setIsPropertyProductHeightRemoved(this.getIsPropertyProductHeightRemoved());
        command.setIsPropertyShippingHeightRemoved(this.getIsPropertyShippingHeightRemoved());
        command.setIsPropertyWidthUomIdRemoved(this.getIsPropertyWidthUomIdRemoved());
        command.setIsPropertyProductWidthRemoved(this.getIsPropertyProductWidthRemoved());
        command.setIsPropertyShippingWidthRemoved(this.getIsPropertyShippingWidthRemoved());
        command.setIsPropertyDepthUomIdRemoved(this.getIsPropertyDepthUomIdRemoved());
        command.setIsPropertyProductDepthRemoved(this.getIsPropertyProductDepthRemoved());
        command.setIsPropertyShippingDepthRemoved(this.getIsPropertyShippingDepthRemoved());
        command.setIsPropertyDiameterUomIdRemoved(this.getIsPropertyDiameterUomIdRemoved());
        command.setIsPropertyProductDiameterRemoved(this.getIsPropertyProductDiameterRemoved());
        command.setIsPropertyProductRatingRemoved(this.getIsPropertyProductRatingRemoved());
        command.setIsPropertyRatingTypeEnumRemoved(this.getIsPropertyRatingTypeEnumRemoved());
        command.setIsPropertyReturnableRemoved(this.getIsPropertyReturnableRemoved());
        command.setIsPropertyTaxableRemoved(this.getIsPropertyTaxableRemoved());
        command.setIsPropertyChargeShippingRemoved(this.getIsPropertyChargeShippingRemoved());
        command.setIsPropertyAutoCreateKeywordsRemoved(this.getIsPropertyAutoCreateKeywordsRemoved());
        command.setIsPropertyIncludeInPromotionsRemoved(this.getIsPropertyIncludeInPromotionsRemoved());
        command.setIsPropertyIsVirtualRemoved(this.getIsPropertyIsVirtualRemoved());
        command.setIsPropertyIsVariantRemoved(this.getIsPropertyIsVariantRemoved());
        command.setIsPropertyVirtualVariantMethodEnumRemoved(this.getIsPropertyVirtualVariantMethodEnumRemoved());
        command.setIsPropertyInShippingBoxRemoved(this.getIsPropertyInShippingBoxRemoved());
        command.setIsPropertyDefaultShipmentBoxTypeIdRemoved(this.getIsPropertyDefaultShipmentBoxTypeIdRemoved());
        command.setIsPropertyIsSerialNumberedRemoved(this.getIsPropertyIsSerialNumberedRemoved());
        command.setIsPropertyIsManagedByLotRemoved(this.getIsPropertyIsManagedByLotRemoved());
        command.setIsPropertyAttributeSetIdRemoved(this.getIsPropertyAttributeSetIdRemoved());
        command.setIsPropertyAttributeSetInstanceIdRemoved(this.getIsPropertyAttributeSetInstanceIdRemoved());
        command.setIsPropertyActiveRemoved(this.getIsPropertyActiveRemoved());
    }

    public static class CreateProductDto extends CreateOrMergePatchProductDto
    {
        @Override
        public String getCommandType() {
            return COMMAND_TYPE_CREATE;
        }
        public ProductCommand.CreateProduct toCreateProduct()
        {
            return (ProductCommand.CreateProduct) toCommand();
        }

    }

    public static class MergePatchProductDto extends CreateOrMergePatchProductDto
    {
        @Override
        public String getCommandType() {
            return COMMAND_TYPE_MERGE_PATCH;
        }
        public ProductCommand.MergePatchProduct toMergePatchProduct()
        {
            return (ProductCommand.MergePatchProduct) toCommand();
        }

    }

}

