package org.dddml.wms.domain.attributesetinstance;

import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.AbstractEvent;

public class AttributeSetInstanceStateEventDto extends AbstractEvent
{

    private AttributeSetInstanceEventId attributeSetInstanceEventId;

    AttributeSetInstanceEventId getStateEventId() {
        if (attributeSetInstanceEventId == null) { attributeSetInstanceEventId = new AttributeSetInstanceEventId(); }
        return attributeSetInstanceEventId;
    }

    void setAttributeSetInstanceEventId(AttributeSetInstanceEventId eventId) {
        this.attributeSetInstanceEventId = eventId;
    }

    public String getAttributeSetInstanceId() {
        return getStateEventId().getAttributeSetInstanceId();
    }

    public void setAttributeSetInstanceId(String attributeSetInstanceId) {
        getStateEventId().setAttributeSetInstanceId(attributeSetInstanceId);
    }

    public Long getVersion() {
        return getStateEventId().getVersion();
    }
    
    public void getVersion(Long version) {
        getStateEventId().setVersion(version);
    }

    private String attributeSetId;

    public String getAttributeSetId() {
        return this.attributeSetId;
    }

    public void setAttributeSetId(String attributeSetId) {
        this.attributeSetId = attributeSetId;
    }

    private String organizationId;

    public String getOrganizationId() {
        return this.organizationId;
    }

    public void setOrganizationId(String organizationId) {
        this.organizationId = organizationId;
    }

    private String referenceId;

    public String getReferenceId() {
        return this.referenceId;
    }

    public void setReferenceId(String referenceId) {
        this.referenceId = referenceId;
    }

    private String serialNumber;

    public String getSerialNumber() {
        return this.serialNumber;
    }

    public void setSerialNumber(String serialNumber) {
        this.serialNumber = serialNumber;
    }

    private String lotId;

    public String getLotId() {
        return this.lotId;
    }

    public void setLotId(String lotId) {
        this.lotId = lotId;
    }

    private String description;

    public String getDescription() {
        return this.description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    private String hash;

    public String getHash() {
        return this.hash;
    }

    public void setHash(String hash) {
        this.hash = hash;
    }

    private BigDecimal widthInch;

    public BigDecimal getWidthInch() {
        return this.widthInch;
    }

    public void setWidthInch(BigDecimal widthInch) {
        this.widthInch = widthInch;
    }

    private BigDecimal diameterInch;

    public BigDecimal getDiameterInch() {
        return this.diameterInch;
    }

    public void setDiameterInch(BigDecimal diameterInch) {
        this.diameterInch = diameterInch;
    }

    private BigDecimal weightLbs;

    public BigDecimal getWeightLbs() {
        return this.weightLbs;
    }

    public void setWeightLbs(BigDecimal weightLbs) {
        this.weightLbs = weightLbs;
    }

    private BigDecimal weightKg;

    public BigDecimal getWeightKg() {
        return this.weightKg;
    }

    public void setWeightKg(BigDecimal weightKg) {
        this.weightKg = weightKg;
    }

    private BigDecimal airDryWeightLbs;

    public BigDecimal getAirDryWeightLbs() {
        return this.airDryWeightLbs;
    }

    public void setAirDryWeightLbs(BigDecimal airDryWeightLbs) {
        this.airDryWeightLbs = airDryWeightLbs;
    }

    private BigDecimal airDryWeightKg;

    public BigDecimal getAirDryWeightKg() {
        return this.airDryWeightKg;
    }

    public void setAirDryWeightKg(BigDecimal airDryWeightKg) {
        this.airDryWeightKg = airDryWeightKg;
    }

    private BigDecimal airDryMetricTon;

    public BigDecimal getAirDryMetricTon() {
        return this.airDryMetricTon;
    }

    public void setAirDryMetricTon(BigDecimal airDryMetricTon) {
        this.airDryMetricTon = airDryMetricTon;
    }

    private Integer packageCount;

    public Integer getPackageCount() {
        return this.packageCount;
    }

    public void setPackageCount(Integer packageCount) {
        this.packageCount = packageCount;
    }

    private BigDecimal airDryPct;

    public BigDecimal getAirDryPct() {
        return this.airDryPct;
    }

    public void setAirDryPct(BigDecimal airDryPct) {
        this.airDryPct = airDryPct;
    }

    private Boolean _F_B_0_;

    public Boolean get_F_B_0_() {
        return this._F_B_0_;
    }

    public void set_F_B_0_(Boolean _F_B_0_) {
        this._F_B_0_ = _F_B_0_;
    }

    private Integer _F_I_0_;

    public Integer get_F_I_0_() {
        return this._F_I_0_;
    }

    public void set_F_I_0_(Integer _F_I_0_) {
        this._F_I_0_ = _F_I_0_;
    }

    private Long _F_L_0_;

    public Long get_F_L_0_() {
        return this._F_L_0_;
    }

    public void set_F_L_0_(Long _F_L_0_) {
        this._F_L_0_ = _F_L_0_;
    }

    private Date _F_DT_0_;

    public Date get_F_DT_0_() {
        return this._F_DT_0_;
    }

    public void set_F_DT_0_(Date _F_DT_0_) {
        this._F_DT_0_ = _F_DT_0_;
    }

    private BigDecimal _F_N_0_;

    public BigDecimal get_F_N_0_() {
        return this._F_N_0_;
    }

    public void set_F_N_0_(BigDecimal _F_N_0_) {
        this._F_N_0_ = _F_N_0_;
    }

    private String _F_C5_0_;

    public String get_F_C5_0_() {
        return this._F_C5_0_;
    }

    public void set_F_C5_0_(String _F_C5_0_) {
        this._F_C5_0_ = _F_C5_0_;
    }

    private String _F_C10_0_;

    public String get_F_C10_0_() {
        return this._F_C10_0_;
    }

    public void set_F_C10_0_(String _F_C10_0_) {
        this._F_C10_0_ = _F_C10_0_;
    }

    private String _F_C20_0_;

    public String get_F_C20_0_() {
        return this._F_C20_0_;
    }

    public void set_F_C20_0_(String _F_C20_0_) {
        this._F_C20_0_ = _F_C20_0_;
    }

    private String _F_C50_0_;

    public String get_F_C50_0_() {
        return this._F_C50_0_;
    }

    public void set_F_C50_0_(String _F_C50_0_) {
        this._F_C50_0_ = _F_C50_0_;
    }

    private String _F_C100_0_;

    public String get_F_C100_0_() {
        return this._F_C100_0_;
    }

    public void set_F_C100_0_(String _F_C100_0_) {
        this._F_C100_0_ = _F_C100_0_;
    }

    private String _F_C200_0_;

    public String get_F_C200_0_() {
        return this._F_C200_0_;
    }

    public void set_F_C200_0_(String _F_C200_0_) {
        this._F_C200_0_ = _F_C200_0_;
    }

    private String _F_C500_0_;

    public String get_F_C500_0_() {
        return this._F_C500_0_;
    }

    public void set_F_C500_0_(String _F_C500_0_) {
        this._F_C500_0_ = _F_C500_0_;
    }

    private String _F_C1000_0_;

    public String get_F_C1000_0_() {
        return this._F_C1000_0_;
    }

    public void set_F_C1000_0_(String _F_C1000_0_) {
        this._F_C1000_0_ = _F_C1000_0_;
    }

    private Boolean _F_B_1_;

    public Boolean get_F_B_1_() {
        return this._F_B_1_;
    }

    public void set_F_B_1_(Boolean _F_B_1_) {
        this._F_B_1_ = _F_B_1_;
    }

    private Integer _F_I_1_;

    public Integer get_F_I_1_() {
        return this._F_I_1_;
    }

    public void set_F_I_1_(Integer _F_I_1_) {
        this._F_I_1_ = _F_I_1_;
    }

    private Long _F_L_1_;

    public Long get_F_L_1_() {
        return this._F_L_1_;
    }

    public void set_F_L_1_(Long _F_L_1_) {
        this._F_L_1_ = _F_L_1_;
    }

    private Date _F_DT_1_;

    public Date get_F_DT_1_() {
        return this._F_DT_1_;
    }

    public void set_F_DT_1_(Date _F_DT_1_) {
        this._F_DT_1_ = _F_DT_1_;
    }

    private BigDecimal _F_N_1_;

    public BigDecimal get_F_N_1_() {
        return this._F_N_1_;
    }

    public void set_F_N_1_(BigDecimal _F_N_1_) {
        this._F_N_1_ = _F_N_1_;
    }

    private String _F_C5_1_;

    public String get_F_C5_1_() {
        return this._F_C5_1_;
    }

    public void set_F_C5_1_(String _F_C5_1_) {
        this._F_C5_1_ = _F_C5_1_;
    }

    private String _F_C10_1_;

    public String get_F_C10_1_() {
        return this._F_C10_1_;
    }

    public void set_F_C10_1_(String _F_C10_1_) {
        this._F_C10_1_ = _F_C10_1_;
    }

    private String _F_C20_1_;

    public String get_F_C20_1_() {
        return this._F_C20_1_;
    }

    public void set_F_C20_1_(String _F_C20_1_) {
        this._F_C20_1_ = _F_C20_1_;
    }

    private String _F_C50_1_;

    public String get_F_C50_1_() {
        return this._F_C50_1_;
    }

    public void set_F_C50_1_(String _F_C50_1_) {
        this._F_C50_1_ = _F_C50_1_;
    }

    private String _F_C100_1_;

    public String get_F_C100_1_() {
        return this._F_C100_1_;
    }

    public void set_F_C100_1_(String _F_C100_1_) {
        this._F_C100_1_ = _F_C100_1_;
    }

    private String _F_C200_1_;

    public String get_F_C200_1_() {
        return this._F_C200_1_;
    }

    public void set_F_C200_1_(String _F_C200_1_) {
        this._F_C200_1_ = _F_C200_1_;
    }

    private Boolean _F_B_2_;

    public Boolean get_F_B_2_() {
        return this._F_B_2_;
    }

    public void set_F_B_2_(Boolean _F_B_2_) {
        this._F_B_2_ = _F_B_2_;
    }

    private Integer _F_I_2_;

    public Integer get_F_I_2_() {
        return this._F_I_2_;
    }

    public void set_F_I_2_(Integer _F_I_2_) {
        this._F_I_2_ = _F_I_2_;
    }

    private Long _F_L_2_;

    public Long get_F_L_2_() {
        return this._F_L_2_;
    }

    public void set_F_L_2_(Long _F_L_2_) {
        this._F_L_2_ = _F_L_2_;
    }

    private Date _F_DT_2_;

    public Date get_F_DT_2_() {
        return this._F_DT_2_;
    }

    public void set_F_DT_2_(Date _F_DT_2_) {
        this._F_DT_2_ = _F_DT_2_;
    }

    private BigDecimal _F_N_2_;

    public BigDecimal get_F_N_2_() {
        return this._F_N_2_;
    }

    public void set_F_N_2_(BigDecimal _F_N_2_) {
        this._F_N_2_ = _F_N_2_;
    }

    private String _F_C5_2_;

    public String get_F_C5_2_() {
        return this._F_C5_2_;
    }

    public void set_F_C5_2_(String _F_C5_2_) {
        this._F_C5_2_ = _F_C5_2_;
    }

    private String _F_C10_2_;

    public String get_F_C10_2_() {
        return this._F_C10_2_;
    }

    public void set_F_C10_2_(String _F_C10_2_) {
        this._F_C10_2_ = _F_C10_2_;
    }

    private String _F_C20_2_;

    public String get_F_C20_2_() {
        return this._F_C20_2_;
    }

    public void set_F_C20_2_(String _F_C20_2_) {
        this._F_C20_2_ = _F_C20_2_;
    }

    private String _F_C50_2_;

    public String get_F_C50_2_() {
        return this._F_C50_2_;
    }

    public void set_F_C50_2_(String _F_C50_2_) {
        this._F_C50_2_ = _F_C50_2_;
    }

    private Boolean _F_B_3_;

    public Boolean get_F_B_3_() {
        return this._F_B_3_;
    }

    public void set_F_B_3_(Boolean _F_B_3_) {
        this._F_B_3_ = _F_B_3_;
    }

    private Integer _F_I_3_;

    public Integer get_F_I_3_() {
        return this._F_I_3_;
    }

    public void set_F_I_3_(Integer _F_I_3_) {
        this._F_I_3_ = _F_I_3_;
    }

    private Long _F_L_3_;

    public Long get_F_L_3_() {
        return this._F_L_3_;
    }

    public void set_F_L_3_(Long _F_L_3_) {
        this._F_L_3_ = _F_L_3_;
    }

    private Date _F_DT_3_;

    public Date get_F_DT_3_() {
        return this._F_DT_3_;
    }

    public void set_F_DT_3_(Date _F_DT_3_) {
        this._F_DT_3_ = _F_DT_3_;
    }

    private BigDecimal _F_N_3_;

    public BigDecimal get_F_N_3_() {
        return this._F_N_3_;
    }

    public void set_F_N_3_(BigDecimal _F_N_3_) {
        this._F_N_3_ = _F_N_3_;
    }

    private String _F_C5_3_;

    public String get_F_C5_3_() {
        return this._F_C5_3_;
    }

    public void set_F_C5_3_(String _F_C5_3_) {
        this._F_C5_3_ = _F_C5_3_;
    }

    private String _F_C10_3_;

    public String get_F_C10_3_() {
        return this._F_C10_3_;
    }

    public void set_F_C10_3_(String _F_C10_3_) {
        this._F_C10_3_ = _F_C10_3_;
    }

    private String _F_C20_3_;

    public String get_F_C20_3_() {
        return this._F_C20_3_;
    }

    public void set_F_C20_3_(String _F_C20_3_) {
        this._F_C20_3_ = _F_C20_3_;
    }

    private String _F_C50_3_;

    public String get_F_C50_3_() {
        return this._F_C50_3_;
    }

    public void set_F_C50_3_(String _F_C50_3_) {
        this._F_C50_3_ = _F_C50_3_;
    }

    private Boolean _F_B_4_;

    public Boolean get_F_B_4_() {
        return this._F_B_4_;
    }

    public void set_F_B_4_(Boolean _F_B_4_) {
        this._F_B_4_ = _F_B_4_;
    }

    private Integer _F_I_4_;

    public Integer get_F_I_4_() {
        return this._F_I_4_;
    }

    public void set_F_I_4_(Integer _F_I_4_) {
        this._F_I_4_ = _F_I_4_;
    }

    private Long _F_L_4_;

    public Long get_F_L_4_() {
        return this._F_L_4_;
    }

    public void set_F_L_4_(Long _F_L_4_) {
        this._F_L_4_ = _F_L_4_;
    }

    private Date _F_DT_4_;

    public Date get_F_DT_4_() {
        return this._F_DT_4_;
    }

    public void set_F_DT_4_(Date _F_DT_4_) {
        this._F_DT_4_ = _F_DT_4_;
    }

    private BigDecimal _F_N_4_;

    public BigDecimal get_F_N_4_() {
        return this._F_N_4_;
    }

    public void set_F_N_4_(BigDecimal _F_N_4_) {
        this._F_N_4_ = _F_N_4_;
    }

    private String _F_C5_4_;

    public String get_F_C5_4_() {
        return this._F_C5_4_;
    }

    public void set_F_C5_4_(String _F_C5_4_) {
        this._F_C5_4_ = _F_C5_4_;
    }

    private String _F_C10_4_;

    public String get_F_C10_4_() {
        return this._F_C10_4_;
    }

    public void set_F_C10_4_(String _F_C10_4_) {
        this._F_C10_4_ = _F_C10_4_;
    }

    private String _F_C20_4_;

    public String get_F_C20_4_() {
        return this._F_C20_4_;
    }

    public void set_F_C20_4_(String _F_C20_4_) {
        this._F_C20_4_ = _F_C20_4_;
    }

    private String _F_C50_4_;

    public String get_F_C50_4_() {
        return this._F_C50_4_;
    }

    public void set_F_C50_4_(String _F_C50_4_) {
        this._F_C50_4_ = _F_C50_4_;
    }

    private Boolean active;

    public Boolean getActive() {
        return this.active;
    }

    public void setActive(Boolean active) {
        this.active = active;
    }

    private String createdBy;

    public String getCreatedBy() {
        return this.createdBy;
    }

    public void setCreatedBy(String createdBy) {
        this.createdBy = createdBy;
    }

    private Date createdAt;

    public Date getCreatedAt() {
        return this.createdAt;
    }

    public void setCreatedAt(Date createdAt) {
        this.createdAt = createdAt;
    }

    private Boolean isPropertyAttributeSetIdRemoved;

    public Boolean getIsPropertyAttributeSetIdRemoved() {
        return this.isPropertyAttributeSetIdRemoved;
    }

    public void setIsPropertyAttributeSetIdRemoved(Boolean removed) {
        this.isPropertyAttributeSetIdRemoved = removed;
    }

    private Boolean isPropertyOrganizationIdRemoved;

    public Boolean getIsPropertyOrganizationIdRemoved() {
        return this.isPropertyOrganizationIdRemoved;
    }

    public void setIsPropertyOrganizationIdRemoved(Boolean removed) {
        this.isPropertyOrganizationIdRemoved = removed;
    }

    private Boolean isPropertyReferenceIdRemoved;

    public Boolean getIsPropertyReferenceIdRemoved() {
        return this.isPropertyReferenceIdRemoved;
    }

    public void setIsPropertyReferenceIdRemoved(Boolean removed) {
        this.isPropertyReferenceIdRemoved = removed;
    }

    private Boolean isPropertySerialNumberRemoved;

    public Boolean getIsPropertySerialNumberRemoved() {
        return this.isPropertySerialNumberRemoved;
    }

    public void setIsPropertySerialNumberRemoved(Boolean removed) {
        this.isPropertySerialNumberRemoved = removed;
    }

    private Boolean isPropertyLotIdRemoved;

    public Boolean getIsPropertyLotIdRemoved() {
        return this.isPropertyLotIdRemoved;
    }

    public void setIsPropertyLotIdRemoved(Boolean removed) {
        this.isPropertyLotIdRemoved = removed;
    }

    private Boolean isPropertyDescriptionRemoved;

    public Boolean getIsPropertyDescriptionRemoved() {
        return this.isPropertyDescriptionRemoved;
    }

    public void setIsPropertyDescriptionRemoved(Boolean removed) {
        this.isPropertyDescriptionRemoved = removed;
    }

    private Boolean isPropertyHashRemoved;

    public Boolean getIsPropertyHashRemoved() {
        return this.isPropertyHashRemoved;
    }

    public void setIsPropertyHashRemoved(Boolean removed) {
        this.isPropertyHashRemoved = removed;
    }

    private Boolean isPropertyWidthInchRemoved;

    public Boolean getIsPropertyWidthInchRemoved() {
        return this.isPropertyWidthInchRemoved;
    }

    public void setIsPropertyWidthInchRemoved(Boolean removed) {
        this.isPropertyWidthInchRemoved = removed;
    }

    private Boolean isPropertyDiameterInchRemoved;

    public Boolean getIsPropertyDiameterInchRemoved() {
        return this.isPropertyDiameterInchRemoved;
    }

    public void setIsPropertyDiameterInchRemoved(Boolean removed) {
        this.isPropertyDiameterInchRemoved = removed;
    }

    private Boolean isPropertyWeightLbsRemoved;

    public Boolean getIsPropertyWeightLbsRemoved() {
        return this.isPropertyWeightLbsRemoved;
    }

    public void setIsPropertyWeightLbsRemoved(Boolean removed) {
        this.isPropertyWeightLbsRemoved = removed;
    }

    private Boolean isPropertyWeightKgRemoved;

    public Boolean getIsPropertyWeightKgRemoved() {
        return this.isPropertyWeightKgRemoved;
    }

    public void setIsPropertyWeightKgRemoved(Boolean removed) {
        this.isPropertyWeightKgRemoved = removed;
    }

    private Boolean isPropertyAirDryWeightLbsRemoved;

    public Boolean getIsPropertyAirDryWeightLbsRemoved() {
        return this.isPropertyAirDryWeightLbsRemoved;
    }

    public void setIsPropertyAirDryWeightLbsRemoved(Boolean removed) {
        this.isPropertyAirDryWeightLbsRemoved = removed;
    }

    private Boolean isPropertyAirDryWeightKgRemoved;

    public Boolean getIsPropertyAirDryWeightKgRemoved() {
        return this.isPropertyAirDryWeightKgRemoved;
    }

    public void setIsPropertyAirDryWeightKgRemoved(Boolean removed) {
        this.isPropertyAirDryWeightKgRemoved = removed;
    }

    private Boolean isPropertyAirDryMetricTonRemoved;

    public Boolean getIsPropertyAirDryMetricTonRemoved() {
        return this.isPropertyAirDryMetricTonRemoved;
    }

    public void setIsPropertyAirDryMetricTonRemoved(Boolean removed) {
        this.isPropertyAirDryMetricTonRemoved = removed;
    }

    private Boolean isPropertyPackageCountRemoved;

    public Boolean getIsPropertyPackageCountRemoved() {
        return this.isPropertyPackageCountRemoved;
    }

    public void setIsPropertyPackageCountRemoved(Boolean removed) {
        this.isPropertyPackageCountRemoved = removed;
    }

    private Boolean isPropertyAirDryPctRemoved;

    public Boolean getIsPropertyAirDryPctRemoved() {
        return this.isPropertyAirDryPctRemoved;
    }

    public void setIsPropertyAirDryPctRemoved(Boolean removed) {
        this.isPropertyAirDryPctRemoved = removed;
    }

    private Boolean isProperty_F_B_0_Removed;

    public Boolean getIsProperty_F_B_0_Removed() {
        return this.isProperty_F_B_0_Removed;
    }

    public void setIsProperty_F_B_0_Removed(Boolean removed) {
        this.isProperty_F_B_0_Removed = removed;
    }

    private Boolean isProperty_F_I_0_Removed;

    public Boolean getIsProperty_F_I_0_Removed() {
        return this.isProperty_F_I_0_Removed;
    }

    public void setIsProperty_F_I_0_Removed(Boolean removed) {
        this.isProperty_F_I_0_Removed = removed;
    }

    private Boolean isProperty_F_L_0_Removed;

    public Boolean getIsProperty_F_L_0_Removed() {
        return this.isProperty_F_L_0_Removed;
    }

    public void setIsProperty_F_L_0_Removed(Boolean removed) {
        this.isProperty_F_L_0_Removed = removed;
    }

    private Boolean isProperty_F_DT_0_Removed;

    public Boolean getIsProperty_F_DT_0_Removed() {
        return this.isProperty_F_DT_0_Removed;
    }

    public void setIsProperty_F_DT_0_Removed(Boolean removed) {
        this.isProperty_F_DT_0_Removed = removed;
    }

    private Boolean isProperty_F_N_0_Removed;

    public Boolean getIsProperty_F_N_0_Removed() {
        return this.isProperty_F_N_0_Removed;
    }

    public void setIsProperty_F_N_0_Removed(Boolean removed) {
        this.isProperty_F_N_0_Removed = removed;
    }

    private Boolean isProperty_F_C5_0_Removed;

    public Boolean getIsProperty_F_C5_0_Removed() {
        return this.isProperty_F_C5_0_Removed;
    }

    public void setIsProperty_F_C5_0_Removed(Boolean removed) {
        this.isProperty_F_C5_0_Removed = removed;
    }

    private Boolean isProperty_F_C10_0_Removed;

    public Boolean getIsProperty_F_C10_0_Removed() {
        return this.isProperty_F_C10_0_Removed;
    }

    public void setIsProperty_F_C10_0_Removed(Boolean removed) {
        this.isProperty_F_C10_0_Removed = removed;
    }

    private Boolean isProperty_F_C20_0_Removed;

    public Boolean getIsProperty_F_C20_0_Removed() {
        return this.isProperty_F_C20_0_Removed;
    }

    public void setIsProperty_F_C20_0_Removed(Boolean removed) {
        this.isProperty_F_C20_0_Removed = removed;
    }

    private Boolean isProperty_F_C50_0_Removed;

    public Boolean getIsProperty_F_C50_0_Removed() {
        return this.isProperty_F_C50_0_Removed;
    }

    public void setIsProperty_F_C50_0_Removed(Boolean removed) {
        this.isProperty_F_C50_0_Removed = removed;
    }

    private Boolean isProperty_F_C100_0_Removed;

    public Boolean getIsProperty_F_C100_0_Removed() {
        return this.isProperty_F_C100_0_Removed;
    }

    public void setIsProperty_F_C100_0_Removed(Boolean removed) {
        this.isProperty_F_C100_0_Removed = removed;
    }

    private Boolean isProperty_F_C200_0_Removed;

    public Boolean getIsProperty_F_C200_0_Removed() {
        return this.isProperty_F_C200_0_Removed;
    }

    public void setIsProperty_F_C200_0_Removed(Boolean removed) {
        this.isProperty_F_C200_0_Removed = removed;
    }

    private Boolean isProperty_F_C500_0_Removed;

    public Boolean getIsProperty_F_C500_0_Removed() {
        return this.isProperty_F_C500_0_Removed;
    }

    public void setIsProperty_F_C500_0_Removed(Boolean removed) {
        this.isProperty_F_C500_0_Removed = removed;
    }

    private Boolean isProperty_F_C1000_0_Removed;

    public Boolean getIsProperty_F_C1000_0_Removed() {
        return this.isProperty_F_C1000_0_Removed;
    }

    public void setIsProperty_F_C1000_0_Removed(Boolean removed) {
        this.isProperty_F_C1000_0_Removed = removed;
    }

    private Boolean isProperty_F_B_1_Removed;

    public Boolean getIsProperty_F_B_1_Removed() {
        return this.isProperty_F_B_1_Removed;
    }

    public void setIsProperty_F_B_1_Removed(Boolean removed) {
        this.isProperty_F_B_1_Removed = removed;
    }

    private Boolean isProperty_F_I_1_Removed;

    public Boolean getIsProperty_F_I_1_Removed() {
        return this.isProperty_F_I_1_Removed;
    }

    public void setIsProperty_F_I_1_Removed(Boolean removed) {
        this.isProperty_F_I_1_Removed = removed;
    }

    private Boolean isProperty_F_L_1_Removed;

    public Boolean getIsProperty_F_L_1_Removed() {
        return this.isProperty_F_L_1_Removed;
    }

    public void setIsProperty_F_L_1_Removed(Boolean removed) {
        this.isProperty_F_L_1_Removed = removed;
    }

    private Boolean isProperty_F_DT_1_Removed;

    public Boolean getIsProperty_F_DT_1_Removed() {
        return this.isProperty_F_DT_1_Removed;
    }

    public void setIsProperty_F_DT_1_Removed(Boolean removed) {
        this.isProperty_F_DT_1_Removed = removed;
    }

    private Boolean isProperty_F_N_1_Removed;

    public Boolean getIsProperty_F_N_1_Removed() {
        return this.isProperty_F_N_1_Removed;
    }

    public void setIsProperty_F_N_1_Removed(Boolean removed) {
        this.isProperty_F_N_1_Removed = removed;
    }

    private Boolean isProperty_F_C5_1_Removed;

    public Boolean getIsProperty_F_C5_1_Removed() {
        return this.isProperty_F_C5_1_Removed;
    }

    public void setIsProperty_F_C5_1_Removed(Boolean removed) {
        this.isProperty_F_C5_1_Removed = removed;
    }

    private Boolean isProperty_F_C10_1_Removed;

    public Boolean getIsProperty_F_C10_1_Removed() {
        return this.isProperty_F_C10_1_Removed;
    }

    public void setIsProperty_F_C10_1_Removed(Boolean removed) {
        this.isProperty_F_C10_1_Removed = removed;
    }

    private Boolean isProperty_F_C20_1_Removed;

    public Boolean getIsProperty_F_C20_1_Removed() {
        return this.isProperty_F_C20_1_Removed;
    }

    public void setIsProperty_F_C20_1_Removed(Boolean removed) {
        this.isProperty_F_C20_1_Removed = removed;
    }

    private Boolean isProperty_F_C50_1_Removed;

    public Boolean getIsProperty_F_C50_1_Removed() {
        return this.isProperty_F_C50_1_Removed;
    }

    public void setIsProperty_F_C50_1_Removed(Boolean removed) {
        this.isProperty_F_C50_1_Removed = removed;
    }

    private Boolean isProperty_F_C100_1_Removed;

    public Boolean getIsProperty_F_C100_1_Removed() {
        return this.isProperty_F_C100_1_Removed;
    }

    public void setIsProperty_F_C100_1_Removed(Boolean removed) {
        this.isProperty_F_C100_1_Removed = removed;
    }

    private Boolean isProperty_F_C200_1_Removed;

    public Boolean getIsProperty_F_C200_1_Removed() {
        return this.isProperty_F_C200_1_Removed;
    }

    public void setIsProperty_F_C200_1_Removed(Boolean removed) {
        this.isProperty_F_C200_1_Removed = removed;
    }

    private Boolean isProperty_F_B_2_Removed;

    public Boolean getIsProperty_F_B_2_Removed() {
        return this.isProperty_F_B_2_Removed;
    }

    public void setIsProperty_F_B_2_Removed(Boolean removed) {
        this.isProperty_F_B_2_Removed = removed;
    }

    private Boolean isProperty_F_I_2_Removed;

    public Boolean getIsProperty_F_I_2_Removed() {
        return this.isProperty_F_I_2_Removed;
    }

    public void setIsProperty_F_I_2_Removed(Boolean removed) {
        this.isProperty_F_I_2_Removed = removed;
    }

    private Boolean isProperty_F_L_2_Removed;

    public Boolean getIsProperty_F_L_2_Removed() {
        return this.isProperty_F_L_2_Removed;
    }

    public void setIsProperty_F_L_2_Removed(Boolean removed) {
        this.isProperty_F_L_2_Removed = removed;
    }

    private Boolean isProperty_F_DT_2_Removed;

    public Boolean getIsProperty_F_DT_2_Removed() {
        return this.isProperty_F_DT_2_Removed;
    }

    public void setIsProperty_F_DT_2_Removed(Boolean removed) {
        this.isProperty_F_DT_2_Removed = removed;
    }

    private Boolean isProperty_F_N_2_Removed;

    public Boolean getIsProperty_F_N_2_Removed() {
        return this.isProperty_F_N_2_Removed;
    }

    public void setIsProperty_F_N_2_Removed(Boolean removed) {
        this.isProperty_F_N_2_Removed = removed;
    }

    private Boolean isProperty_F_C5_2_Removed;

    public Boolean getIsProperty_F_C5_2_Removed() {
        return this.isProperty_F_C5_2_Removed;
    }

    public void setIsProperty_F_C5_2_Removed(Boolean removed) {
        this.isProperty_F_C5_2_Removed = removed;
    }

    private Boolean isProperty_F_C10_2_Removed;

    public Boolean getIsProperty_F_C10_2_Removed() {
        return this.isProperty_F_C10_2_Removed;
    }

    public void setIsProperty_F_C10_2_Removed(Boolean removed) {
        this.isProperty_F_C10_2_Removed = removed;
    }

    private Boolean isProperty_F_C20_2_Removed;

    public Boolean getIsProperty_F_C20_2_Removed() {
        return this.isProperty_F_C20_2_Removed;
    }

    public void setIsProperty_F_C20_2_Removed(Boolean removed) {
        this.isProperty_F_C20_2_Removed = removed;
    }

    private Boolean isProperty_F_C50_2_Removed;

    public Boolean getIsProperty_F_C50_2_Removed() {
        return this.isProperty_F_C50_2_Removed;
    }

    public void setIsProperty_F_C50_2_Removed(Boolean removed) {
        this.isProperty_F_C50_2_Removed = removed;
    }

    private Boolean isProperty_F_B_3_Removed;

    public Boolean getIsProperty_F_B_3_Removed() {
        return this.isProperty_F_B_3_Removed;
    }

    public void setIsProperty_F_B_3_Removed(Boolean removed) {
        this.isProperty_F_B_3_Removed = removed;
    }

    private Boolean isProperty_F_I_3_Removed;

    public Boolean getIsProperty_F_I_3_Removed() {
        return this.isProperty_F_I_3_Removed;
    }

    public void setIsProperty_F_I_3_Removed(Boolean removed) {
        this.isProperty_F_I_3_Removed = removed;
    }

    private Boolean isProperty_F_L_3_Removed;

    public Boolean getIsProperty_F_L_3_Removed() {
        return this.isProperty_F_L_3_Removed;
    }

    public void setIsProperty_F_L_3_Removed(Boolean removed) {
        this.isProperty_F_L_3_Removed = removed;
    }

    private Boolean isProperty_F_DT_3_Removed;

    public Boolean getIsProperty_F_DT_3_Removed() {
        return this.isProperty_F_DT_3_Removed;
    }

    public void setIsProperty_F_DT_3_Removed(Boolean removed) {
        this.isProperty_F_DT_3_Removed = removed;
    }

    private Boolean isProperty_F_N_3_Removed;

    public Boolean getIsProperty_F_N_3_Removed() {
        return this.isProperty_F_N_3_Removed;
    }

    public void setIsProperty_F_N_3_Removed(Boolean removed) {
        this.isProperty_F_N_3_Removed = removed;
    }

    private Boolean isProperty_F_C5_3_Removed;

    public Boolean getIsProperty_F_C5_3_Removed() {
        return this.isProperty_F_C5_3_Removed;
    }

    public void setIsProperty_F_C5_3_Removed(Boolean removed) {
        this.isProperty_F_C5_3_Removed = removed;
    }

    private Boolean isProperty_F_C10_3_Removed;

    public Boolean getIsProperty_F_C10_3_Removed() {
        return this.isProperty_F_C10_3_Removed;
    }

    public void setIsProperty_F_C10_3_Removed(Boolean removed) {
        this.isProperty_F_C10_3_Removed = removed;
    }

    private Boolean isProperty_F_C20_3_Removed;

    public Boolean getIsProperty_F_C20_3_Removed() {
        return this.isProperty_F_C20_3_Removed;
    }

    public void setIsProperty_F_C20_3_Removed(Boolean removed) {
        this.isProperty_F_C20_3_Removed = removed;
    }

    private Boolean isProperty_F_C50_3_Removed;

    public Boolean getIsProperty_F_C50_3_Removed() {
        return this.isProperty_F_C50_3_Removed;
    }

    public void setIsProperty_F_C50_3_Removed(Boolean removed) {
        this.isProperty_F_C50_3_Removed = removed;
    }

    private Boolean isProperty_F_B_4_Removed;

    public Boolean getIsProperty_F_B_4_Removed() {
        return this.isProperty_F_B_4_Removed;
    }

    public void setIsProperty_F_B_4_Removed(Boolean removed) {
        this.isProperty_F_B_4_Removed = removed;
    }

    private Boolean isProperty_F_I_4_Removed;

    public Boolean getIsProperty_F_I_4_Removed() {
        return this.isProperty_F_I_4_Removed;
    }

    public void setIsProperty_F_I_4_Removed(Boolean removed) {
        this.isProperty_F_I_4_Removed = removed;
    }

    private Boolean isProperty_F_L_4_Removed;

    public Boolean getIsProperty_F_L_4_Removed() {
        return this.isProperty_F_L_4_Removed;
    }

    public void setIsProperty_F_L_4_Removed(Boolean removed) {
        this.isProperty_F_L_4_Removed = removed;
    }

    private Boolean isProperty_F_DT_4_Removed;

    public Boolean getIsProperty_F_DT_4_Removed() {
        return this.isProperty_F_DT_4_Removed;
    }

    public void setIsProperty_F_DT_4_Removed(Boolean removed) {
        this.isProperty_F_DT_4_Removed = removed;
    }

    private Boolean isProperty_F_N_4_Removed;

    public Boolean getIsProperty_F_N_4_Removed() {
        return this.isProperty_F_N_4_Removed;
    }

    public void setIsProperty_F_N_4_Removed(Boolean removed) {
        this.isProperty_F_N_4_Removed = removed;
    }

    private Boolean isProperty_F_C5_4_Removed;

    public Boolean getIsProperty_F_C5_4_Removed() {
        return this.isProperty_F_C5_4_Removed;
    }

    public void setIsProperty_F_C5_4_Removed(Boolean removed) {
        this.isProperty_F_C5_4_Removed = removed;
    }

    private Boolean isProperty_F_C10_4_Removed;

    public Boolean getIsProperty_F_C10_4_Removed() {
        return this.isProperty_F_C10_4_Removed;
    }

    public void setIsProperty_F_C10_4_Removed(Boolean removed) {
        this.isProperty_F_C10_4_Removed = removed;
    }

    private Boolean isProperty_F_C20_4_Removed;

    public Boolean getIsProperty_F_C20_4_Removed() {
        return this.isProperty_F_C20_4_Removed;
    }

    public void setIsProperty_F_C20_4_Removed(Boolean removed) {
        this.isProperty_F_C20_4_Removed = removed;
    }

    private Boolean isProperty_F_C50_4_Removed;

    public Boolean getIsProperty_F_C50_4_Removed() {
        return this.isProperty_F_C50_4_Removed;
    }

    public void setIsProperty_F_C50_4_Removed(Boolean removed) {
        this.isProperty_F_C50_4_Removed = removed;
    }

    private Boolean isPropertyActiveRemoved;

    public Boolean getIsPropertyActiveRemoved() {
        return this.isPropertyActiveRemoved;
    }

    public void setIsPropertyActiveRemoved(Boolean removed) {
        this.isPropertyActiveRemoved = removed;
    }


	public static class AttributeSetInstanceStateCreatedDto extends AttributeSetInstanceStateEventDto
	{
        @Override
        public String getEventType()
        {
            return STATE_EVENT_TYPE_CREATED;
        }

	}


	public static class AttributeSetInstanceStateMergePatchedDto extends AttributeSetInstanceStateEventDto
	{
        @Override
        public String getEventType()
        {
            return STATE_EVENT_TYPE_MERGE_PATCHED;
        }

	}


	public static class AttributeSetInstanceStateDeletedDto extends AttributeSetInstanceStateEventDto
	{
        @Override
        public String getEventType()
        {
            return STATE_EVENT_TYPE_DELETED;
        }

	}


}

