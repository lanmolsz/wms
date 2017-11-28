package org.dddml.wms.domain.attributesetinstance;

import java.util.*;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;

public abstract class AbstractAttributeSetInstanceAggregate extends AbstractAggregate implements AttributeSetInstanceAggregate
{
    private AttributeSetInstanceState state;

    private List<Event> changes = new ArrayList<Event>();

    public AbstractAttributeSetInstanceAggregate(AttributeSetInstanceState state)
    {
        this.state = state;
    }

    public AttributeSetInstanceState getState() {
        return this.state;
    }

    public List<Event> getChanges() {
        return this.changes;
    }

    public void create(AttributeSetInstanceCommand.CreateAttributeSetInstance c)
    {
        if (c.getVersion() == null) { c.setVersion(AttributeSetInstanceState.VERSION_NULL); }
        AttributeSetInstanceStateEvent e = map(c);
        apply(e);
    }

    public void throwOnInvalidStateTransition(Command c)
    {
        if (this.state.getVersion() == null)
        {
            if (isCommandCreate((AttributeSetInstanceCommand)c))
            {
                return;
            }
            throw DomainError.named("premature", "Can't do anything to unexistent aggregate");
        }
        if (isCommandCreate((AttributeSetInstanceCommand)c))
            throw DomainError.named("rebirth", "Can't create aggregate that already exists");
    }

    protected void apply(Event e)
    {
        onApplying(e);
        state.mutate(e);
        changes.add(e);
    }

    protected AttributeSetInstanceStateEvent map(AttributeSetInstanceCommand.CreateAttributeSetInstance c) {
        AttributeSetInstanceStateEventId stateEventId = new AttributeSetInstanceStateEventId(c.getAttributeSetInstanceId(), c.getVersion());
        AttributeSetInstanceStateEvent.AttributeSetInstanceStateCreated e = newAttributeSetInstanceStateCreated(stateEventId);
        e.setAttributeSetId(c.getAttributeSetId());
        e.setOrganizationId(c.getOrganizationId());
        e.setReferenceId(c.getReferenceId());
        e.setSerialNumber(c.getSerialNumber());
        e.setLot(c.getLot());
        e.setDescription(c.getDescription());
        e.setHash(c.getHash());
        e.set_F_B_0_(c.get_F_B_0_());
        e.set_F_I_0_(c.get_F_I_0_());
        e.set_F_L_0_(c.get_F_L_0_());
        e.set_F_DT_0_(c.get_F_DT_0_());
        e.set_F_N_0_(c.get_F_N_0_());
        e.set_F_C5_0_(c.get_F_C5_0_());
        e.set_F_C10_0_(c.get_F_C10_0_());
        e.set_F_C20_0_(c.get_F_C20_0_());
        e.set_F_C50_0_(c.get_F_C50_0_());
        e.set_F_C100_0_(c.get_F_C100_0_());
        e.set_F_C200_0_(c.get_F_C200_0_());
        e.set_F_C500_0_(c.get_F_C500_0_());
        e.set_F_C1000_0_(c.get_F_C1000_0_());
        e.set_F_B_1_(c.get_F_B_1_());
        e.set_F_I_1_(c.get_F_I_1_());
        e.set_F_L_1_(c.get_F_L_1_());
        e.set_F_DT_1_(c.get_F_DT_1_());
        e.set_F_N_1_(c.get_F_N_1_());
        e.set_F_C5_1_(c.get_F_C5_1_());
        e.set_F_C10_1_(c.get_F_C10_1_());
        e.set_F_C20_1_(c.get_F_C20_1_());
        e.set_F_C50_1_(c.get_F_C50_1_());
        e.set_F_C100_1_(c.get_F_C100_1_());
        e.set_F_C200_1_(c.get_F_C200_1_());
        e.set_F_C500_1_(c.get_F_C500_1_());
        e.set_F_C1000_1_(c.get_F_C1000_1_());
        e.set_F_B_2_(c.get_F_B_2_());
        e.set_F_I_2_(c.get_F_I_2_());
        e.set_F_L_2_(c.get_F_L_2_());
        e.set_F_DT_2_(c.get_F_DT_2_());
        e.set_F_N_2_(c.get_F_N_2_());
        e.set_F_C5_2_(c.get_F_C5_2_());
        e.set_F_C10_2_(c.get_F_C10_2_());
        e.set_F_C20_2_(c.get_F_C20_2_());
        e.set_F_C50_2_(c.get_F_C50_2_());
        e.set_F_C100_2_(c.get_F_C100_2_());
        e.set_F_C200_2_(c.get_F_C200_2_());
        e.set_F_C500_2_(c.get_F_C500_2_());
        e.set_F_C1000_2_(c.get_F_C1000_2_());
        e.set_F_B_3_(c.get_F_B_3_());
        e.set_F_I_3_(c.get_F_I_3_());
        e.set_F_L_3_(c.get_F_L_3_());
        e.set_F_DT_3_(c.get_F_DT_3_());
        e.set_F_N_3_(c.get_F_N_3_());
        e.set_F_C5_3_(c.get_F_C5_3_());
        e.set_F_C10_3_(c.get_F_C10_3_());
        e.set_F_C20_3_(c.get_F_C20_3_());
        e.set_F_C50_3_(c.get_F_C50_3_());
        e.set_F_C100_3_(c.get_F_C100_3_());
        e.set_F_C200_3_(c.get_F_C200_3_());
        e.set_F_C500_3_(c.get_F_C500_3_());
        e.set_F_C1000_3_(c.get_F_C1000_3_());
        e.set_F_B_4_(c.get_F_B_4_());
        e.set_F_I_4_(c.get_F_I_4_());
        e.set_F_L_4_(c.get_F_L_4_());
        e.set_F_DT_4_(c.get_F_DT_4_());
        e.set_F_N_4_(c.get_F_N_4_());
        e.set_F_C5_4_(c.get_F_C5_4_());
        e.set_F_C10_4_(c.get_F_C10_4_());
        e.set_F_C20_4_(c.get_F_C20_4_());
        e.set_F_C50_4_(c.get_F_C50_4_());
        e.set_F_C100_4_(c.get_F_C100_4_());
        e.set_F_C200_4_(c.get_F_C200_4_());
        e.set_F_C500_4_(c.get_F_C500_4_());
        e.set_F_C1000_4_(c.get_F_C1000_4_());
        e.set_F_B_5_(c.get_F_B_5_());
        e.set_F_I_5_(c.get_F_I_5_());
        e.set_F_L_5_(c.get_F_L_5_());
        e.set_F_DT_5_(c.get_F_DT_5_());
        e.set_F_N_5_(c.get_F_N_5_());
        e.set_F_C5_5_(c.get_F_C5_5_());
        e.set_F_C10_5_(c.get_F_C10_5_());
        e.set_F_C20_5_(c.get_F_C20_5_());
        e.set_F_C50_5_(c.get_F_C50_5_());
        e.set_F_C100_5_(c.get_F_C100_5_());
        e.set_F_C200_5_(c.get_F_C200_5_());
        e.set_F_C500_5_(c.get_F_C500_5_());
        e.set_F_B_6_(c.get_F_B_6_());
        e.set_F_I_6_(c.get_F_I_6_());
        e.set_F_L_6_(c.get_F_L_6_());
        e.set_F_DT_6_(c.get_F_DT_6_());
        e.set_F_N_6_(c.get_F_N_6_());
        e.set_F_C5_6_(c.get_F_C5_6_());
        e.set_F_C10_6_(c.get_F_C10_6_());
        e.set_F_C20_6_(c.get_F_C20_6_());
        e.set_F_C50_6_(c.get_F_C50_6_());
        e.set_F_C100_6_(c.get_F_C100_6_());
        e.set_F_C200_6_(c.get_F_C200_6_());
        e.set_F_C500_6_(c.get_F_C500_6_());
        e.set_F_B_7_(c.get_F_B_7_());
        e.set_F_I_7_(c.get_F_I_7_());
        e.set_F_L_7_(c.get_F_L_7_());
        e.set_F_DT_7_(c.get_F_DT_7_());
        e.set_F_N_7_(c.get_F_N_7_());
        e.set_F_C5_7_(c.get_F_C5_7_());
        e.set_F_C10_7_(c.get_F_C10_7_());
        e.set_F_C20_7_(c.get_F_C20_7_());
        e.set_F_C50_7_(c.get_F_C50_7_());
        e.set_F_C100_7_(c.get_F_C100_7_());
        e.set_F_C200_7_(c.get_F_C200_7_());
        e.set_F_C500_7_(c.get_F_C500_7_());
        e.set_F_B_8_(c.get_F_B_8_());
        e.set_F_I_8_(c.get_F_I_8_());
        e.set_F_L_8_(c.get_F_L_8_());
        e.set_F_DT_8_(c.get_F_DT_8_());
        e.set_F_N_8_(c.get_F_N_8_());
        e.set_F_C5_8_(c.get_F_C5_8_());
        e.set_F_C10_8_(c.get_F_C10_8_());
        e.set_F_C20_8_(c.get_F_C20_8_());
        e.set_F_C50_8_(c.get_F_C50_8_());
        e.set_F_C100_8_(c.get_F_C100_8_());
        e.set_F_C200_8_(c.get_F_C200_8_());
        e.set_F_C500_8_(c.get_F_C500_8_());
        e.set_F_B_9_(c.get_F_B_9_());
        e.set_F_I_9_(c.get_F_I_9_());
        e.set_F_L_9_(c.get_F_L_9_());
        e.set_F_DT_9_(c.get_F_DT_9_());
        e.set_F_N_9_(c.get_F_N_9_());
        e.set_F_C5_9_(c.get_F_C5_9_());
        e.set_F_C10_9_(c.get_F_C10_9_());
        e.set_F_C20_9_(c.get_F_C20_9_());
        e.set_F_C50_9_(c.get_F_C50_9_());
        e.set_F_C100_9_(c.get_F_C100_9_());
        e.set_F_C200_9_(c.get_F_C200_9_());
        e.set_F_C500_9_(c.get_F_C500_9_());
        e.set_F_B_10_(c.get_F_B_10_());
        e.set_F_I_10_(c.get_F_I_10_());
        e.set_F_L_10_(c.get_F_L_10_());
        e.set_F_DT_10_(c.get_F_DT_10_());
        e.set_F_N_10_(c.get_F_N_10_());
        e.set_F_C5_10_(c.get_F_C5_10_());
        e.set_F_C10_10_(c.get_F_C10_10_());
        e.set_F_C20_10_(c.get_F_C20_10_());
        e.set_F_C50_10_(c.get_F_C50_10_());
        e.set_F_C100_10_(c.get_F_C100_10_());
        e.set_F_C200_10_(c.get_F_C200_10_());
        e.set_F_B_11_(c.get_F_B_11_());
        e.set_F_I_11_(c.get_F_I_11_());
        e.set_F_L_11_(c.get_F_L_11_());
        e.set_F_DT_11_(c.get_F_DT_11_());
        e.set_F_N_11_(c.get_F_N_11_());
        e.set_F_C5_11_(c.get_F_C5_11_());
        e.set_F_C10_11_(c.get_F_C10_11_());
        e.set_F_C20_11_(c.get_F_C20_11_());
        e.set_F_C50_11_(c.get_F_C50_11_());
        e.set_F_C100_11_(c.get_F_C100_11_());
        e.set_F_C200_11_(c.get_F_C200_11_());
        e.set_F_B_12_(c.get_F_B_12_());
        e.set_F_I_12_(c.get_F_I_12_());
        e.set_F_L_12_(c.get_F_L_12_());
        e.set_F_DT_12_(c.get_F_DT_12_());
        e.set_F_N_12_(c.get_F_N_12_());
        e.set_F_C5_12_(c.get_F_C5_12_());
        e.set_F_C10_12_(c.get_F_C10_12_());
        e.set_F_C20_12_(c.get_F_C20_12_());
        e.set_F_C50_12_(c.get_F_C50_12_());
        e.set_F_C100_12_(c.get_F_C100_12_());
        e.set_F_C200_12_(c.get_F_C200_12_());
        e.set_F_B_13_(c.get_F_B_13_());
        e.set_F_I_13_(c.get_F_I_13_());
        e.set_F_L_13_(c.get_F_L_13_());
        e.set_F_DT_13_(c.get_F_DT_13_());
        e.set_F_N_13_(c.get_F_N_13_());
        e.set_F_C5_13_(c.get_F_C5_13_());
        e.set_F_C10_13_(c.get_F_C10_13_());
        e.set_F_C20_13_(c.get_F_C20_13_());
        e.set_F_C50_13_(c.get_F_C50_13_());
        e.set_F_C100_13_(c.get_F_C100_13_());
        e.set_F_C200_13_(c.get_F_C200_13_());
        e.set_F_B_14_(c.get_F_B_14_());
        e.set_F_I_14_(c.get_F_I_14_());
        e.set_F_L_14_(c.get_F_L_14_());
        e.set_F_DT_14_(c.get_F_DT_14_());
        e.set_F_N_14_(c.get_F_N_14_());
        e.set_F_C5_14_(c.get_F_C5_14_());
        e.set_F_C10_14_(c.get_F_C10_14_());
        e.set_F_C20_14_(c.get_F_C20_14_());
        e.set_F_C50_14_(c.get_F_C50_14_());
        e.set_F_C100_14_(c.get_F_C100_14_());
        e.set_F_C200_14_(c.get_F_C200_14_());
        e.set_F_B_15_(c.get_F_B_15_());
        e.set_F_I_15_(c.get_F_I_15_());
        e.set_F_L_15_(c.get_F_L_15_());
        e.set_F_DT_15_(c.get_F_DT_15_());
        e.set_F_N_15_(c.get_F_N_15_());
        e.set_F_C5_15_(c.get_F_C5_15_());
        e.set_F_C10_15_(c.get_F_C10_15_());
        e.set_F_C20_15_(c.get_F_C20_15_());
        e.set_F_C50_15_(c.get_F_C50_15_());
        e.set_F_C100_15_(c.get_F_C100_15_());
        e.set_F_C200_15_(c.get_F_C200_15_());
        e.set_F_B_16_(c.get_F_B_16_());
        e.set_F_I_16_(c.get_F_I_16_());
        e.set_F_L_16_(c.get_F_L_16_());
        e.set_F_DT_16_(c.get_F_DT_16_());
        e.set_F_N_16_(c.get_F_N_16_());
        e.set_F_C5_16_(c.get_F_C5_16_());
        e.set_F_C10_16_(c.get_F_C10_16_());
        e.set_F_C20_16_(c.get_F_C20_16_());
        e.set_F_C50_16_(c.get_F_C50_16_());
        e.set_F_C100_16_(c.get_F_C100_16_());
        e.set_F_C200_16_(c.get_F_C200_16_());
        e.set_F_B_17_(c.get_F_B_17_());
        e.set_F_I_17_(c.get_F_I_17_());
        e.set_F_L_17_(c.get_F_L_17_());
        e.set_F_DT_17_(c.get_F_DT_17_());
        e.set_F_N_17_(c.get_F_N_17_());
        e.set_F_C5_17_(c.get_F_C5_17_());
        e.set_F_C10_17_(c.get_F_C10_17_());
        e.set_F_C20_17_(c.get_F_C20_17_());
        e.set_F_C50_17_(c.get_F_C50_17_());
        e.set_F_C100_17_(c.get_F_C100_17_());
        e.set_F_C200_17_(c.get_F_C200_17_());
        e.set_F_B_18_(c.get_F_B_18_());
        e.set_F_I_18_(c.get_F_I_18_());
        e.set_F_L_18_(c.get_F_L_18_());
        e.set_F_DT_18_(c.get_F_DT_18_());
        e.set_F_N_18_(c.get_F_N_18_());
        e.set_F_C5_18_(c.get_F_C5_18_());
        e.set_F_C10_18_(c.get_F_C10_18_());
        e.set_F_C20_18_(c.get_F_C20_18_());
        e.set_F_C50_18_(c.get_F_C50_18_());
        e.set_F_C100_18_(c.get_F_C100_18_());
        e.set_F_C200_18_(c.get_F_C200_18_());
        e.set_F_B_19_(c.get_F_B_19_());
        e.set_F_I_19_(c.get_F_I_19_());
        e.set_F_L_19_(c.get_F_L_19_());
        e.set_F_DT_19_(c.get_F_DT_19_());
        e.set_F_N_19_(c.get_F_N_19_());
        e.set_F_C5_19_(c.get_F_C5_19_());
        e.set_F_C10_19_(c.get_F_C10_19_());
        e.set_F_C20_19_(c.get_F_C20_19_());
        e.set_F_C50_19_(c.get_F_C50_19_());
        e.set_F_C100_19_(c.get_F_C100_19_());
        e.set_F_C200_19_(c.get_F_C200_19_());
        e.set_F_B_20_(c.get_F_B_20_());
        e.set_F_I_20_(c.get_F_I_20_());
        e.set_F_L_20_(c.get_F_L_20_());
        e.set_F_N_20_(c.get_F_N_20_());
        e.set_F_C5_20_(c.get_F_C5_20_());
        e.set_F_C10_20_(c.get_F_C10_20_());
        e.set_F_C20_20_(c.get_F_C20_20_());
        e.set_F_C50_20_(c.get_F_C50_20_());
        e.set_F_B_21_(c.get_F_B_21_());
        e.set_F_I_21_(c.get_F_I_21_());
        e.set_F_L_21_(c.get_F_L_21_());
        e.set_F_N_21_(c.get_F_N_21_());
        e.set_F_C5_21_(c.get_F_C5_21_());
        e.set_F_C10_21_(c.get_F_C10_21_());
        e.set_F_C20_21_(c.get_F_C20_21_());
        e.set_F_C50_21_(c.get_F_C50_21_());
        e.set_F_B_22_(c.get_F_B_22_());
        e.set_F_I_22_(c.get_F_I_22_());
        e.set_F_L_22_(c.get_F_L_22_());
        e.set_F_N_22_(c.get_F_N_22_());
        e.set_F_C5_22_(c.get_F_C5_22_());
        e.set_F_C10_22_(c.get_F_C10_22_());
        e.set_F_C20_22_(c.get_F_C20_22_());
        e.set_F_C50_22_(c.get_F_C50_22_());
        e.set_F_B_23_(c.get_F_B_23_());
        e.set_F_I_23_(c.get_F_I_23_());
        e.set_F_L_23_(c.get_F_L_23_());
        e.set_F_N_23_(c.get_F_N_23_());
        e.set_F_C5_23_(c.get_F_C5_23_());
        e.set_F_C10_23_(c.get_F_C10_23_());
        e.set_F_C20_23_(c.get_F_C20_23_());
        e.set_F_C50_23_(c.get_F_C50_23_());
        e.set_F_B_24_(c.get_F_B_24_());
        e.set_F_I_24_(c.get_F_I_24_());
        e.set_F_L_24_(c.get_F_L_24_());
        e.set_F_N_24_(c.get_F_N_24_());
        e.set_F_C5_24_(c.get_F_C5_24_());
        e.set_F_C10_24_(c.get_F_C10_24_());
        e.set_F_C20_24_(c.get_F_C20_24_());
        e.set_F_C50_24_(c.get_F_C50_24_());
        e.set_F_B_25_(c.get_F_B_25_());
        e.set_F_I_25_(c.get_F_I_25_());
        e.set_F_L_25_(c.get_F_L_25_());
        e.set_F_N_25_(c.get_F_N_25_());
        e.set_F_C5_25_(c.get_F_C5_25_());
        e.set_F_C10_25_(c.get_F_C10_25_());
        e.set_F_C20_25_(c.get_F_C20_25_());
        e.set_F_C50_25_(c.get_F_C50_25_());
        e.set_F_B_26_(c.get_F_B_26_());
        e.set_F_I_26_(c.get_F_I_26_());
        e.set_F_L_26_(c.get_F_L_26_());
        e.set_F_N_26_(c.get_F_N_26_());
        e.set_F_C5_26_(c.get_F_C5_26_());
        e.set_F_C10_26_(c.get_F_C10_26_());
        e.set_F_C20_26_(c.get_F_C20_26_());
        e.set_F_C50_26_(c.get_F_C50_26_());
        e.set_F_B_27_(c.get_F_B_27_());
        e.set_F_I_27_(c.get_F_I_27_());
        e.set_F_L_27_(c.get_F_L_27_());
        e.set_F_N_27_(c.get_F_N_27_());
        e.set_F_C5_27_(c.get_F_C5_27_());
        e.set_F_C10_27_(c.get_F_C10_27_());
        e.set_F_C20_27_(c.get_F_C20_27_());
        e.set_F_C50_27_(c.get_F_C50_27_());
        e.set_F_B_28_(c.get_F_B_28_());
        e.set_F_I_28_(c.get_F_I_28_());
        e.set_F_L_28_(c.get_F_L_28_());
        e.set_F_N_28_(c.get_F_N_28_());
        e.set_F_C5_28_(c.get_F_C5_28_());
        e.set_F_C10_28_(c.get_F_C10_28_());
        e.set_F_C20_28_(c.get_F_C20_28_());
        e.set_F_C50_28_(c.get_F_C50_28_());
        e.set_F_B_29_(c.get_F_B_29_());
        e.set_F_I_29_(c.get_F_I_29_());
        e.set_F_L_29_(c.get_F_L_29_());
        e.set_F_N_29_(c.get_F_N_29_());
        e.set_F_C5_29_(c.get_F_C5_29_());
        e.set_F_C10_29_(c.get_F_C10_29_());
        e.set_F_C20_29_(c.get_F_C20_29_());
        e.set_F_C50_29_(c.get_F_C50_29_());
        e.set_F_B_30_(c.get_F_B_30_());
        e.set_F_I_30_(c.get_F_I_30_());
        e.set_F_N_30_(c.get_F_N_30_());
        e.set_F_C5_30_(c.get_F_C5_30_());
        e.set_F_C10_30_(c.get_F_C10_30_());
        e.set_F_C20_30_(c.get_F_C20_30_());
        e.set_F_C50_30_(c.get_F_C50_30_());
        e.set_F_B_31_(c.get_F_B_31_());
        e.set_F_I_31_(c.get_F_I_31_());
        e.set_F_N_31_(c.get_F_N_31_());
        e.set_F_C5_31_(c.get_F_C5_31_());
        e.set_F_C10_31_(c.get_F_C10_31_());
        e.set_F_C20_31_(c.get_F_C20_31_());
        e.set_F_C50_31_(c.get_F_C50_31_());
        e.set_F_B_32_(c.get_F_B_32_());
        e.set_F_I_32_(c.get_F_I_32_());
        e.set_F_N_32_(c.get_F_N_32_());
        e.set_F_C5_32_(c.get_F_C5_32_());
        e.set_F_C10_32_(c.get_F_C10_32_());
        e.set_F_C20_32_(c.get_F_C20_32_());
        e.set_F_C50_32_(c.get_F_C50_32_());
        e.set_F_B_33_(c.get_F_B_33_());
        e.set_F_I_33_(c.get_F_I_33_());
        e.set_F_N_33_(c.get_F_N_33_());
        e.set_F_C5_33_(c.get_F_C5_33_());
        e.set_F_C10_33_(c.get_F_C10_33_());
        e.set_F_C20_33_(c.get_F_C20_33_());
        e.set_F_C50_33_(c.get_F_C50_33_());
        e.set_F_B_34_(c.get_F_B_34_());
        e.set_F_I_34_(c.get_F_I_34_());
        e.set_F_N_34_(c.get_F_N_34_());
        e.set_F_C5_34_(c.get_F_C5_34_());
        e.set_F_C10_34_(c.get_F_C10_34_());
        e.set_F_C20_34_(c.get_F_C20_34_());
        e.set_F_C50_34_(c.get_F_C50_34_());
        e.set_F_B_35_(c.get_F_B_35_());
        e.set_F_I_35_(c.get_F_I_35_());
        e.set_F_N_35_(c.get_F_N_35_());
        e.set_F_C5_35_(c.get_F_C5_35_());
        e.set_F_C10_35_(c.get_F_C10_35_());
        e.set_F_C20_35_(c.get_F_C20_35_());
        e.set_F_C50_35_(c.get_F_C50_35_());
        e.set_F_B_36_(c.get_F_B_36_());
        e.set_F_I_36_(c.get_F_I_36_());
        e.set_F_N_36_(c.get_F_N_36_());
        e.set_F_C5_36_(c.get_F_C5_36_());
        e.set_F_C10_36_(c.get_F_C10_36_());
        e.set_F_C20_36_(c.get_F_C20_36_());
        e.set_F_C50_36_(c.get_F_C50_36_());
        e.set_F_B_37_(c.get_F_B_37_());
        e.set_F_I_37_(c.get_F_I_37_());
        e.set_F_N_37_(c.get_F_N_37_());
        e.set_F_C5_37_(c.get_F_C5_37_());
        e.set_F_C10_37_(c.get_F_C10_37_());
        e.set_F_C20_37_(c.get_F_C20_37_());
        e.set_F_C50_37_(c.get_F_C50_37_());
        e.set_F_B_38_(c.get_F_B_38_());
        e.set_F_I_38_(c.get_F_I_38_());
        e.set_F_N_38_(c.get_F_N_38_());
        e.set_F_C5_38_(c.get_F_C5_38_());
        e.set_F_C10_38_(c.get_F_C10_38_());
        e.set_F_C20_38_(c.get_F_C20_38_());
        e.set_F_C50_38_(c.get_F_C50_38_());
        e.set_F_B_39_(c.get_F_B_39_());
        e.set_F_I_39_(c.get_F_I_39_());
        e.set_F_N_39_(c.get_F_N_39_());
        e.set_F_C5_39_(c.get_F_C5_39_());
        e.set_F_C10_39_(c.get_F_C10_39_());
        e.set_F_C20_39_(c.get_F_C20_39_());
        e.set_F_C50_39_(c.get_F_C50_39_());
        e.set_F_B_40_(c.get_F_B_40_());
        e.set_F_I_40_(c.get_F_I_40_());
        e.set_F_N_40_(c.get_F_N_40_());
        e.set_F_C5_40_(c.get_F_C5_40_());
        e.set_F_C10_40_(c.get_F_C10_40_());
        e.set_F_C20_40_(c.get_F_C20_40_());
        e.set_F_C50_40_(c.get_F_C50_40_());
        e.set_F_B_41_(c.get_F_B_41_());
        e.set_F_I_41_(c.get_F_I_41_());
        e.set_F_N_41_(c.get_F_N_41_());
        e.set_F_C5_41_(c.get_F_C5_41_());
        e.set_F_C10_41_(c.get_F_C10_41_());
        e.set_F_C20_41_(c.get_F_C20_41_());
        e.set_F_C50_41_(c.get_F_C50_41_());
        e.set_F_B_42_(c.get_F_B_42_());
        e.set_F_I_42_(c.get_F_I_42_());
        e.set_F_N_42_(c.get_F_N_42_());
        e.set_F_C5_42_(c.get_F_C5_42_());
        e.set_F_C10_42_(c.get_F_C10_42_());
        e.set_F_C20_42_(c.get_F_C20_42_());
        e.set_F_C50_42_(c.get_F_C50_42_());
        e.set_F_B_43_(c.get_F_B_43_());
        e.set_F_I_43_(c.get_F_I_43_());
        e.set_F_N_43_(c.get_F_N_43_());
        e.set_F_C5_43_(c.get_F_C5_43_());
        e.set_F_C10_43_(c.get_F_C10_43_());
        e.set_F_C20_43_(c.get_F_C20_43_());
        e.set_F_C50_43_(c.get_F_C50_43_());
        e.set_F_B_44_(c.get_F_B_44_());
        e.set_F_I_44_(c.get_F_I_44_());
        e.set_F_N_44_(c.get_F_N_44_());
        e.set_F_C5_44_(c.get_F_C5_44_());
        e.set_F_C10_44_(c.get_F_C10_44_());
        e.set_F_C20_44_(c.get_F_C20_44_());
        e.set_F_C50_44_(c.get_F_C50_44_());
        e.set_F_B_45_(c.get_F_B_45_());
        e.set_F_I_45_(c.get_F_I_45_());
        e.set_F_N_45_(c.get_F_N_45_());
        e.set_F_C5_45_(c.get_F_C5_45_());
        e.set_F_C10_45_(c.get_F_C10_45_());
        e.set_F_C20_45_(c.get_F_C20_45_());
        e.set_F_C50_45_(c.get_F_C50_45_());
        e.set_F_B_46_(c.get_F_B_46_());
        e.set_F_I_46_(c.get_F_I_46_());
        e.set_F_N_46_(c.get_F_N_46_());
        e.set_F_C5_46_(c.get_F_C5_46_());
        e.set_F_C10_46_(c.get_F_C10_46_());
        e.set_F_C20_46_(c.get_F_C20_46_());
        e.set_F_C50_46_(c.get_F_C50_46_());
        e.set_F_B_47_(c.get_F_B_47_());
        e.set_F_I_47_(c.get_F_I_47_());
        e.set_F_N_47_(c.get_F_N_47_());
        e.set_F_C5_47_(c.get_F_C5_47_());
        e.set_F_C10_47_(c.get_F_C10_47_());
        e.set_F_C20_47_(c.get_F_C20_47_());
        e.set_F_C50_47_(c.get_F_C50_47_());
        e.set_F_B_48_(c.get_F_B_48_());
        e.set_F_I_48_(c.get_F_I_48_());
        e.set_F_N_48_(c.get_F_N_48_());
        e.set_F_C5_48_(c.get_F_C5_48_());
        e.set_F_C10_48_(c.get_F_C10_48_());
        e.set_F_C20_48_(c.get_F_C20_48_());
        e.set_F_C50_48_(c.get_F_C50_48_());
        e.set_F_B_49_(c.get_F_B_49_());
        e.set_F_I_49_(c.get_F_I_49_());
        e.set_F_N_49_(c.get_F_N_49_());
        e.set_F_C5_49_(c.get_F_C5_49_());
        e.set_F_C10_49_(c.get_F_C10_49_());
        e.set_F_C20_49_(c.get_F_C20_49_());
        e.set_F_C50_49_(c.get_F_C50_49_());
        e.setActive(c.getActive());
        ((AbstractAttributeSetInstanceStateEvent)e).setCommandId(c.getCommandId());
        e.setCreatedBy(c.getRequesterId());
        e.setCreatedAt((java.util.Date)ApplicationContext.current.getTimestampService().now(java.util.Date.class));
        return e;
    }


    private static boolean isCommandCreate(AttributeSetInstanceCommand c)
    {
        return ((c instanceof AttributeSetInstanceCommand.CreateAttributeSetInstance) 
            && c.getVersion().equals(AttributeSetInstanceState.VERSION_NULL));
    }


    ////////////////////////

    protected AttributeSetInstanceStateEvent.AttributeSetInstanceStateCreated newAttributeSetInstanceStateCreated(String commandId, String requesterId) {
        AttributeSetInstanceStateEventId stateEventId = new AttributeSetInstanceStateEventId(this.state.getAttributeSetInstanceId(), this.state.getVersion());
        AttributeSetInstanceStateEvent.AttributeSetInstanceStateCreated e = newAttributeSetInstanceStateCreated(stateEventId);
        ((AbstractAttributeSetInstanceStateEvent)e).setCommandId(commandId);
        e.setCreatedBy(requesterId);
        e.setCreatedAt((java.util.Date)ApplicationContext.current.getTimestampService().now(java.util.Date.class));
        return e;
    }

    protected AttributeSetInstanceStateEvent.AttributeSetInstanceStateCreated newAttributeSetInstanceStateCreated(AttributeSetInstanceStateEventId stateEventId) {
        return new AbstractAttributeSetInstanceStateEvent.SimpleAttributeSetInstanceStateCreated(stateEventId);
    }


    public static class SimpleAttributeSetInstanceAggregate extends AbstractAttributeSetInstanceAggregate
    {
        public SimpleAttributeSetInstanceAggregate(AttributeSetInstanceState state) {
            super(state);
        }

    }

}

