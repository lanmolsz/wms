package org.dddml.wms.domain.attributesetinstance;

import java.util.*;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;

public abstract class AbstractAttributeSetInstanceStateCommandConverter<TCreateAttributeSetInstance extends AttributeSetInstanceCommand.CreateAttributeSetInstance, TMergePatchAttributeSetInstance extends AttributeSetInstanceCommand.MergePatchAttributeSetInstance, TDeleteAttributeSetInstance extends AttributeSetInstanceCommand.DeleteAttributeSetInstance>
{
    public AttributeSetInstanceCommand toCreateOrMergePatchAttributeSetInstance(AttributeSetInstanceState state)
    {
        //where TCreateAttributeSetInstance : ICreateAttributeSetInstance, new()
        //where TMergePatchAttributeSetInstance : IMergePatchAttributeSetInstance, new()
        boolean bUnsaved = state.isStateUnsaved();
        if (bUnsaved)
        {
            return toCreateAttributeSetInstance(state);
        }
        else 
        {
            return toMergePatchAttributeSetInstance(state);
        }
    }

    public TDeleteAttributeSetInstance toDeleteAttributeSetInstance(AttributeSetInstanceState state) //where TDeleteAttributeSetInstance : IDeleteAttributeSetInstance, new()
    {
        TDeleteAttributeSetInstance cmd = newDeleteAttributeSetInstance();
        cmd.setAttributeSetInstanceId(state.getAttributeSetInstanceId());
        cmd.setVersion(state.getVersion());

        return cmd;
    }

    public TMergePatchAttributeSetInstance toMergePatchAttributeSetInstance(AttributeSetInstanceState state) //where TMergePatchAttributeSetInstance : IMergePatchAttributeSetInstance, new()
    {
        TMergePatchAttributeSetInstance cmd = newMergePatchAttributeSetInstance();

        cmd.setVersion(state.getVersion());

        cmd.setAttributeSetInstanceId(state.getAttributeSetInstanceId());
        cmd.setAttributeSetId(state.getAttributeSetId());
        cmd.setOrganizationId(state.getOrganizationId());
        cmd.setReferenceId(state.getReferenceId());
        cmd.setSerialNumber(state.getSerialNumber());
        cmd.setLot(state.getLot());
        cmd.setDescription(state.getDescription());
        cmd.setHash(state.getHash());
        cmd.set_F_B_0_(state.get_F_B_0_());
        cmd.set_F_I_0_(state.get_F_I_0_());
        cmd.set_F_L_0_(state.get_F_L_0_());
        cmd.set_F_DT_0_(state.get_F_DT_0_());
        cmd.set_F_N_0_(state.get_F_N_0_());
        cmd.set_F_C5_0_(state.get_F_C5_0_());
        cmd.set_F_C10_0_(state.get_F_C10_0_());
        cmd.set_F_C20_0_(state.get_F_C20_0_());
        cmd.set_F_C50_0_(state.get_F_C50_0_());
        cmd.set_F_C100_0_(state.get_F_C100_0_());
        cmd.set_F_C200_0_(state.get_F_C200_0_());
        cmd.set_F_C500_0_(state.get_F_C500_0_());
        cmd.set_F_C1000_0_(state.get_F_C1000_0_());
        cmd.set_F_B_1_(state.get_F_B_1_());
        cmd.set_F_I_1_(state.get_F_I_1_());
        cmd.set_F_L_1_(state.get_F_L_1_());
        cmd.set_F_DT_1_(state.get_F_DT_1_());
        cmd.set_F_N_1_(state.get_F_N_1_());
        cmd.set_F_C5_1_(state.get_F_C5_1_());
        cmd.set_F_C10_1_(state.get_F_C10_1_());
        cmd.set_F_C20_1_(state.get_F_C20_1_());
        cmd.set_F_C50_1_(state.get_F_C50_1_());
        cmd.set_F_C100_1_(state.get_F_C100_1_());
        cmd.set_F_C200_1_(state.get_F_C200_1_());
        cmd.set_F_C500_1_(state.get_F_C500_1_());
        cmd.set_F_C1000_1_(state.get_F_C1000_1_());
        cmd.set_F_B_2_(state.get_F_B_2_());
        cmd.set_F_I_2_(state.get_F_I_2_());
        cmd.set_F_L_2_(state.get_F_L_2_());
        cmd.set_F_DT_2_(state.get_F_DT_2_());
        cmd.set_F_N_2_(state.get_F_N_2_());
        cmd.set_F_C5_2_(state.get_F_C5_2_());
        cmd.set_F_C10_2_(state.get_F_C10_2_());
        cmd.set_F_C20_2_(state.get_F_C20_2_());
        cmd.set_F_C50_2_(state.get_F_C50_2_());
        cmd.set_F_C100_2_(state.get_F_C100_2_());
        cmd.set_F_C200_2_(state.get_F_C200_2_());
        cmd.set_F_C500_2_(state.get_F_C500_2_());
        cmd.set_F_C1000_2_(state.get_F_C1000_2_());
        cmd.set_F_B_3_(state.get_F_B_3_());
        cmd.set_F_I_3_(state.get_F_I_3_());
        cmd.set_F_L_3_(state.get_F_L_3_());
        cmd.set_F_DT_3_(state.get_F_DT_3_());
        cmd.set_F_N_3_(state.get_F_N_3_());
        cmd.set_F_C5_3_(state.get_F_C5_3_());
        cmd.set_F_C10_3_(state.get_F_C10_3_());
        cmd.set_F_C20_3_(state.get_F_C20_3_());
        cmd.set_F_C50_3_(state.get_F_C50_3_());
        cmd.set_F_C100_3_(state.get_F_C100_3_());
        cmd.set_F_C200_3_(state.get_F_C200_3_());
        cmd.set_F_C500_3_(state.get_F_C500_3_());
        cmd.set_F_C1000_3_(state.get_F_C1000_3_());
        cmd.set_F_B_4_(state.get_F_B_4_());
        cmd.set_F_I_4_(state.get_F_I_4_());
        cmd.set_F_L_4_(state.get_F_L_4_());
        cmd.set_F_DT_4_(state.get_F_DT_4_());
        cmd.set_F_N_4_(state.get_F_N_4_());
        cmd.set_F_C5_4_(state.get_F_C5_4_());
        cmd.set_F_C10_4_(state.get_F_C10_4_());
        cmd.set_F_C20_4_(state.get_F_C20_4_());
        cmd.set_F_C50_4_(state.get_F_C50_4_());
        cmd.set_F_C100_4_(state.get_F_C100_4_());
        cmd.set_F_C200_4_(state.get_F_C200_4_());
        cmd.set_F_C500_4_(state.get_F_C500_4_());
        cmd.set_F_C1000_4_(state.get_F_C1000_4_());
        cmd.set_F_B_5_(state.get_F_B_5_());
        cmd.set_F_I_5_(state.get_F_I_5_());
        cmd.set_F_L_5_(state.get_F_L_5_());
        cmd.set_F_DT_5_(state.get_F_DT_5_());
        cmd.set_F_N_5_(state.get_F_N_5_());
        cmd.set_F_C5_5_(state.get_F_C5_5_());
        cmd.set_F_C10_5_(state.get_F_C10_5_());
        cmd.set_F_C20_5_(state.get_F_C20_5_());
        cmd.set_F_C50_5_(state.get_F_C50_5_());
        cmd.set_F_C100_5_(state.get_F_C100_5_());
        cmd.set_F_C200_5_(state.get_F_C200_5_());
        cmd.set_F_C500_5_(state.get_F_C500_5_());
        cmd.set_F_B_6_(state.get_F_B_6_());
        cmd.set_F_I_6_(state.get_F_I_6_());
        cmd.set_F_L_6_(state.get_F_L_6_());
        cmd.set_F_DT_6_(state.get_F_DT_6_());
        cmd.set_F_N_6_(state.get_F_N_6_());
        cmd.set_F_C5_6_(state.get_F_C5_6_());
        cmd.set_F_C10_6_(state.get_F_C10_6_());
        cmd.set_F_C20_6_(state.get_F_C20_6_());
        cmd.set_F_C50_6_(state.get_F_C50_6_());
        cmd.set_F_C100_6_(state.get_F_C100_6_());
        cmd.set_F_C200_6_(state.get_F_C200_6_());
        cmd.set_F_C500_6_(state.get_F_C500_6_());
        cmd.set_F_B_7_(state.get_F_B_7_());
        cmd.set_F_I_7_(state.get_F_I_7_());
        cmd.set_F_L_7_(state.get_F_L_7_());
        cmd.set_F_DT_7_(state.get_F_DT_7_());
        cmd.set_F_N_7_(state.get_F_N_7_());
        cmd.set_F_C5_7_(state.get_F_C5_7_());
        cmd.set_F_C10_7_(state.get_F_C10_7_());
        cmd.set_F_C20_7_(state.get_F_C20_7_());
        cmd.set_F_C50_7_(state.get_F_C50_7_());
        cmd.set_F_C100_7_(state.get_F_C100_7_());
        cmd.set_F_C200_7_(state.get_F_C200_7_());
        cmd.set_F_C500_7_(state.get_F_C500_7_());
        cmd.set_F_B_8_(state.get_F_B_8_());
        cmd.set_F_I_8_(state.get_F_I_8_());
        cmd.set_F_L_8_(state.get_F_L_8_());
        cmd.set_F_DT_8_(state.get_F_DT_8_());
        cmd.set_F_N_8_(state.get_F_N_8_());
        cmd.set_F_C5_8_(state.get_F_C5_8_());
        cmd.set_F_C10_8_(state.get_F_C10_8_());
        cmd.set_F_C20_8_(state.get_F_C20_8_());
        cmd.set_F_C50_8_(state.get_F_C50_8_());
        cmd.set_F_C100_8_(state.get_F_C100_8_());
        cmd.set_F_C200_8_(state.get_F_C200_8_());
        cmd.set_F_C500_8_(state.get_F_C500_8_());
        cmd.set_F_B_9_(state.get_F_B_9_());
        cmd.set_F_I_9_(state.get_F_I_9_());
        cmd.set_F_L_9_(state.get_F_L_9_());
        cmd.set_F_DT_9_(state.get_F_DT_9_());
        cmd.set_F_N_9_(state.get_F_N_9_());
        cmd.set_F_C5_9_(state.get_F_C5_9_());
        cmd.set_F_C10_9_(state.get_F_C10_9_());
        cmd.set_F_C20_9_(state.get_F_C20_9_());
        cmd.set_F_C50_9_(state.get_F_C50_9_());
        cmd.set_F_C100_9_(state.get_F_C100_9_());
        cmd.set_F_C200_9_(state.get_F_C200_9_());
        cmd.set_F_C500_9_(state.get_F_C500_9_());
        cmd.set_F_B_10_(state.get_F_B_10_());
        cmd.set_F_I_10_(state.get_F_I_10_());
        cmd.set_F_L_10_(state.get_F_L_10_());
        cmd.set_F_DT_10_(state.get_F_DT_10_());
        cmd.set_F_N_10_(state.get_F_N_10_());
        cmd.set_F_C5_10_(state.get_F_C5_10_());
        cmd.set_F_C10_10_(state.get_F_C10_10_());
        cmd.set_F_C20_10_(state.get_F_C20_10_());
        cmd.set_F_C50_10_(state.get_F_C50_10_());
        cmd.set_F_C100_10_(state.get_F_C100_10_());
        cmd.set_F_C200_10_(state.get_F_C200_10_());
        cmd.set_F_B_11_(state.get_F_B_11_());
        cmd.set_F_I_11_(state.get_F_I_11_());
        cmd.set_F_L_11_(state.get_F_L_11_());
        cmd.set_F_DT_11_(state.get_F_DT_11_());
        cmd.set_F_N_11_(state.get_F_N_11_());
        cmd.set_F_C5_11_(state.get_F_C5_11_());
        cmd.set_F_C10_11_(state.get_F_C10_11_());
        cmd.set_F_C20_11_(state.get_F_C20_11_());
        cmd.set_F_C50_11_(state.get_F_C50_11_());
        cmd.set_F_C100_11_(state.get_F_C100_11_());
        cmd.set_F_C200_11_(state.get_F_C200_11_());
        cmd.set_F_B_12_(state.get_F_B_12_());
        cmd.set_F_I_12_(state.get_F_I_12_());
        cmd.set_F_L_12_(state.get_F_L_12_());
        cmd.set_F_DT_12_(state.get_F_DT_12_());
        cmd.set_F_N_12_(state.get_F_N_12_());
        cmd.set_F_C5_12_(state.get_F_C5_12_());
        cmd.set_F_C10_12_(state.get_F_C10_12_());
        cmd.set_F_C20_12_(state.get_F_C20_12_());
        cmd.set_F_C50_12_(state.get_F_C50_12_());
        cmd.set_F_C100_12_(state.get_F_C100_12_());
        cmd.set_F_C200_12_(state.get_F_C200_12_());
        cmd.set_F_B_13_(state.get_F_B_13_());
        cmd.set_F_I_13_(state.get_F_I_13_());
        cmd.set_F_L_13_(state.get_F_L_13_());
        cmd.set_F_DT_13_(state.get_F_DT_13_());
        cmd.set_F_N_13_(state.get_F_N_13_());
        cmd.set_F_C5_13_(state.get_F_C5_13_());
        cmd.set_F_C10_13_(state.get_F_C10_13_());
        cmd.set_F_C20_13_(state.get_F_C20_13_());
        cmd.set_F_C50_13_(state.get_F_C50_13_());
        cmd.set_F_C100_13_(state.get_F_C100_13_());
        cmd.set_F_C200_13_(state.get_F_C200_13_());
        cmd.set_F_B_14_(state.get_F_B_14_());
        cmd.set_F_I_14_(state.get_F_I_14_());
        cmd.set_F_L_14_(state.get_F_L_14_());
        cmd.set_F_DT_14_(state.get_F_DT_14_());
        cmd.set_F_N_14_(state.get_F_N_14_());
        cmd.set_F_C5_14_(state.get_F_C5_14_());
        cmd.set_F_C10_14_(state.get_F_C10_14_());
        cmd.set_F_C20_14_(state.get_F_C20_14_());
        cmd.set_F_C50_14_(state.get_F_C50_14_());
        cmd.set_F_C100_14_(state.get_F_C100_14_());
        cmd.set_F_C200_14_(state.get_F_C200_14_());
        cmd.set_F_B_15_(state.get_F_B_15_());
        cmd.set_F_I_15_(state.get_F_I_15_());
        cmd.set_F_L_15_(state.get_F_L_15_());
        cmd.set_F_DT_15_(state.get_F_DT_15_());
        cmd.set_F_N_15_(state.get_F_N_15_());
        cmd.set_F_C5_15_(state.get_F_C5_15_());
        cmd.set_F_C10_15_(state.get_F_C10_15_());
        cmd.set_F_C20_15_(state.get_F_C20_15_());
        cmd.set_F_C50_15_(state.get_F_C50_15_());
        cmd.set_F_C100_15_(state.get_F_C100_15_());
        cmd.set_F_C200_15_(state.get_F_C200_15_());
        cmd.set_F_B_16_(state.get_F_B_16_());
        cmd.set_F_I_16_(state.get_F_I_16_());
        cmd.set_F_L_16_(state.get_F_L_16_());
        cmd.set_F_DT_16_(state.get_F_DT_16_());
        cmd.set_F_N_16_(state.get_F_N_16_());
        cmd.set_F_C5_16_(state.get_F_C5_16_());
        cmd.set_F_C10_16_(state.get_F_C10_16_());
        cmd.set_F_C20_16_(state.get_F_C20_16_());
        cmd.set_F_C50_16_(state.get_F_C50_16_());
        cmd.set_F_C100_16_(state.get_F_C100_16_());
        cmd.set_F_C200_16_(state.get_F_C200_16_());
        cmd.set_F_B_17_(state.get_F_B_17_());
        cmd.set_F_I_17_(state.get_F_I_17_());
        cmd.set_F_L_17_(state.get_F_L_17_());
        cmd.set_F_DT_17_(state.get_F_DT_17_());
        cmd.set_F_N_17_(state.get_F_N_17_());
        cmd.set_F_C5_17_(state.get_F_C5_17_());
        cmd.set_F_C10_17_(state.get_F_C10_17_());
        cmd.set_F_C20_17_(state.get_F_C20_17_());
        cmd.set_F_C50_17_(state.get_F_C50_17_());
        cmd.set_F_C100_17_(state.get_F_C100_17_());
        cmd.set_F_C200_17_(state.get_F_C200_17_());
        cmd.set_F_B_18_(state.get_F_B_18_());
        cmd.set_F_I_18_(state.get_F_I_18_());
        cmd.set_F_L_18_(state.get_F_L_18_());
        cmd.set_F_DT_18_(state.get_F_DT_18_());
        cmd.set_F_N_18_(state.get_F_N_18_());
        cmd.set_F_C5_18_(state.get_F_C5_18_());
        cmd.set_F_C10_18_(state.get_F_C10_18_());
        cmd.set_F_C20_18_(state.get_F_C20_18_());
        cmd.set_F_C50_18_(state.get_F_C50_18_());
        cmd.set_F_C100_18_(state.get_F_C100_18_());
        cmd.set_F_C200_18_(state.get_F_C200_18_());
        cmd.set_F_B_19_(state.get_F_B_19_());
        cmd.set_F_I_19_(state.get_F_I_19_());
        cmd.set_F_L_19_(state.get_F_L_19_());
        cmd.set_F_DT_19_(state.get_F_DT_19_());
        cmd.set_F_N_19_(state.get_F_N_19_());
        cmd.set_F_C5_19_(state.get_F_C5_19_());
        cmd.set_F_C10_19_(state.get_F_C10_19_());
        cmd.set_F_C20_19_(state.get_F_C20_19_());
        cmd.set_F_C50_19_(state.get_F_C50_19_());
        cmd.set_F_C100_19_(state.get_F_C100_19_());
        cmd.set_F_C200_19_(state.get_F_C200_19_());
        cmd.set_F_B_20_(state.get_F_B_20_());
        cmd.set_F_I_20_(state.get_F_I_20_());
        cmd.set_F_L_20_(state.get_F_L_20_());
        cmd.set_F_N_20_(state.get_F_N_20_());
        cmd.set_F_C5_20_(state.get_F_C5_20_());
        cmd.set_F_C10_20_(state.get_F_C10_20_());
        cmd.set_F_C20_20_(state.get_F_C20_20_());
        cmd.set_F_C50_20_(state.get_F_C50_20_());
        cmd.set_F_B_21_(state.get_F_B_21_());
        cmd.set_F_I_21_(state.get_F_I_21_());
        cmd.set_F_L_21_(state.get_F_L_21_());
        cmd.set_F_N_21_(state.get_F_N_21_());
        cmd.set_F_C5_21_(state.get_F_C5_21_());
        cmd.set_F_C10_21_(state.get_F_C10_21_());
        cmd.set_F_C20_21_(state.get_F_C20_21_());
        cmd.set_F_C50_21_(state.get_F_C50_21_());
        cmd.set_F_B_22_(state.get_F_B_22_());
        cmd.set_F_I_22_(state.get_F_I_22_());
        cmd.set_F_L_22_(state.get_F_L_22_());
        cmd.set_F_N_22_(state.get_F_N_22_());
        cmd.set_F_C5_22_(state.get_F_C5_22_());
        cmd.set_F_C10_22_(state.get_F_C10_22_());
        cmd.set_F_C20_22_(state.get_F_C20_22_());
        cmd.set_F_C50_22_(state.get_F_C50_22_());
        cmd.set_F_B_23_(state.get_F_B_23_());
        cmd.set_F_I_23_(state.get_F_I_23_());
        cmd.set_F_L_23_(state.get_F_L_23_());
        cmd.set_F_N_23_(state.get_F_N_23_());
        cmd.set_F_C5_23_(state.get_F_C5_23_());
        cmd.set_F_C10_23_(state.get_F_C10_23_());
        cmd.set_F_C20_23_(state.get_F_C20_23_());
        cmd.set_F_C50_23_(state.get_F_C50_23_());
        cmd.set_F_B_24_(state.get_F_B_24_());
        cmd.set_F_I_24_(state.get_F_I_24_());
        cmd.set_F_L_24_(state.get_F_L_24_());
        cmd.set_F_N_24_(state.get_F_N_24_());
        cmd.set_F_C5_24_(state.get_F_C5_24_());
        cmd.set_F_C10_24_(state.get_F_C10_24_());
        cmd.set_F_C20_24_(state.get_F_C20_24_());
        cmd.set_F_C50_24_(state.get_F_C50_24_());
        cmd.set_F_B_25_(state.get_F_B_25_());
        cmd.set_F_I_25_(state.get_F_I_25_());
        cmd.set_F_L_25_(state.get_F_L_25_());
        cmd.set_F_N_25_(state.get_F_N_25_());
        cmd.set_F_C5_25_(state.get_F_C5_25_());
        cmd.set_F_C10_25_(state.get_F_C10_25_());
        cmd.set_F_C20_25_(state.get_F_C20_25_());
        cmd.set_F_C50_25_(state.get_F_C50_25_());
        cmd.set_F_B_26_(state.get_F_B_26_());
        cmd.set_F_I_26_(state.get_F_I_26_());
        cmd.set_F_L_26_(state.get_F_L_26_());
        cmd.set_F_N_26_(state.get_F_N_26_());
        cmd.set_F_C5_26_(state.get_F_C5_26_());
        cmd.set_F_C10_26_(state.get_F_C10_26_());
        cmd.set_F_C20_26_(state.get_F_C20_26_());
        cmd.set_F_C50_26_(state.get_F_C50_26_());
        cmd.set_F_B_27_(state.get_F_B_27_());
        cmd.set_F_I_27_(state.get_F_I_27_());
        cmd.set_F_L_27_(state.get_F_L_27_());
        cmd.set_F_N_27_(state.get_F_N_27_());
        cmd.set_F_C5_27_(state.get_F_C5_27_());
        cmd.set_F_C10_27_(state.get_F_C10_27_());
        cmd.set_F_C20_27_(state.get_F_C20_27_());
        cmd.set_F_C50_27_(state.get_F_C50_27_());
        cmd.set_F_B_28_(state.get_F_B_28_());
        cmd.set_F_I_28_(state.get_F_I_28_());
        cmd.set_F_L_28_(state.get_F_L_28_());
        cmd.set_F_N_28_(state.get_F_N_28_());
        cmd.set_F_C5_28_(state.get_F_C5_28_());
        cmd.set_F_C10_28_(state.get_F_C10_28_());
        cmd.set_F_C20_28_(state.get_F_C20_28_());
        cmd.set_F_C50_28_(state.get_F_C50_28_());
        cmd.set_F_B_29_(state.get_F_B_29_());
        cmd.set_F_I_29_(state.get_F_I_29_());
        cmd.set_F_L_29_(state.get_F_L_29_());
        cmd.set_F_N_29_(state.get_F_N_29_());
        cmd.set_F_C5_29_(state.get_F_C5_29_());
        cmd.set_F_C10_29_(state.get_F_C10_29_());
        cmd.set_F_C20_29_(state.get_F_C20_29_());
        cmd.set_F_C50_29_(state.get_F_C50_29_());
        cmd.set_F_B_30_(state.get_F_B_30_());
        cmd.set_F_I_30_(state.get_F_I_30_());
        cmd.set_F_N_30_(state.get_F_N_30_());
        cmd.set_F_C5_30_(state.get_F_C5_30_());
        cmd.set_F_C10_30_(state.get_F_C10_30_());
        cmd.set_F_C20_30_(state.get_F_C20_30_());
        cmd.set_F_C50_30_(state.get_F_C50_30_());
        cmd.set_F_B_31_(state.get_F_B_31_());
        cmd.set_F_I_31_(state.get_F_I_31_());
        cmd.set_F_N_31_(state.get_F_N_31_());
        cmd.set_F_C5_31_(state.get_F_C5_31_());
        cmd.set_F_C10_31_(state.get_F_C10_31_());
        cmd.set_F_C20_31_(state.get_F_C20_31_());
        cmd.set_F_C50_31_(state.get_F_C50_31_());
        cmd.set_F_B_32_(state.get_F_B_32_());
        cmd.set_F_I_32_(state.get_F_I_32_());
        cmd.set_F_N_32_(state.get_F_N_32_());
        cmd.set_F_C5_32_(state.get_F_C5_32_());
        cmd.set_F_C10_32_(state.get_F_C10_32_());
        cmd.set_F_C20_32_(state.get_F_C20_32_());
        cmd.set_F_C50_32_(state.get_F_C50_32_());
        cmd.set_F_B_33_(state.get_F_B_33_());
        cmd.set_F_I_33_(state.get_F_I_33_());
        cmd.set_F_N_33_(state.get_F_N_33_());
        cmd.set_F_C5_33_(state.get_F_C5_33_());
        cmd.set_F_C10_33_(state.get_F_C10_33_());
        cmd.set_F_C20_33_(state.get_F_C20_33_());
        cmd.set_F_C50_33_(state.get_F_C50_33_());
        cmd.set_F_B_34_(state.get_F_B_34_());
        cmd.set_F_I_34_(state.get_F_I_34_());
        cmd.set_F_N_34_(state.get_F_N_34_());
        cmd.set_F_C5_34_(state.get_F_C5_34_());
        cmd.set_F_C10_34_(state.get_F_C10_34_());
        cmd.set_F_C20_34_(state.get_F_C20_34_());
        cmd.set_F_C50_34_(state.get_F_C50_34_());
        cmd.set_F_B_35_(state.get_F_B_35_());
        cmd.set_F_I_35_(state.get_F_I_35_());
        cmd.set_F_N_35_(state.get_F_N_35_());
        cmd.set_F_C5_35_(state.get_F_C5_35_());
        cmd.set_F_C10_35_(state.get_F_C10_35_());
        cmd.set_F_C20_35_(state.get_F_C20_35_());
        cmd.set_F_C50_35_(state.get_F_C50_35_());
        cmd.set_F_B_36_(state.get_F_B_36_());
        cmd.set_F_I_36_(state.get_F_I_36_());
        cmd.set_F_N_36_(state.get_F_N_36_());
        cmd.set_F_C5_36_(state.get_F_C5_36_());
        cmd.set_F_C10_36_(state.get_F_C10_36_());
        cmd.set_F_C20_36_(state.get_F_C20_36_());
        cmd.set_F_C50_36_(state.get_F_C50_36_());
        cmd.set_F_B_37_(state.get_F_B_37_());
        cmd.set_F_I_37_(state.get_F_I_37_());
        cmd.set_F_N_37_(state.get_F_N_37_());
        cmd.set_F_C5_37_(state.get_F_C5_37_());
        cmd.set_F_C10_37_(state.get_F_C10_37_());
        cmd.set_F_C20_37_(state.get_F_C20_37_());
        cmd.set_F_C50_37_(state.get_F_C50_37_());
        cmd.set_F_B_38_(state.get_F_B_38_());
        cmd.set_F_I_38_(state.get_F_I_38_());
        cmd.set_F_N_38_(state.get_F_N_38_());
        cmd.set_F_C5_38_(state.get_F_C5_38_());
        cmd.set_F_C10_38_(state.get_F_C10_38_());
        cmd.set_F_C20_38_(state.get_F_C20_38_());
        cmd.set_F_C50_38_(state.get_F_C50_38_());
        cmd.set_F_B_39_(state.get_F_B_39_());
        cmd.set_F_I_39_(state.get_F_I_39_());
        cmd.set_F_N_39_(state.get_F_N_39_());
        cmd.set_F_C5_39_(state.get_F_C5_39_());
        cmd.set_F_C10_39_(state.get_F_C10_39_());
        cmd.set_F_C20_39_(state.get_F_C20_39_());
        cmd.set_F_C50_39_(state.get_F_C50_39_());
        cmd.set_F_B_40_(state.get_F_B_40_());
        cmd.set_F_I_40_(state.get_F_I_40_());
        cmd.set_F_N_40_(state.get_F_N_40_());
        cmd.set_F_C5_40_(state.get_F_C5_40_());
        cmd.set_F_C10_40_(state.get_F_C10_40_());
        cmd.set_F_C20_40_(state.get_F_C20_40_());
        cmd.set_F_C50_40_(state.get_F_C50_40_());
        cmd.set_F_B_41_(state.get_F_B_41_());
        cmd.set_F_I_41_(state.get_F_I_41_());
        cmd.set_F_N_41_(state.get_F_N_41_());
        cmd.set_F_C5_41_(state.get_F_C5_41_());
        cmd.set_F_C10_41_(state.get_F_C10_41_());
        cmd.set_F_C20_41_(state.get_F_C20_41_());
        cmd.set_F_C50_41_(state.get_F_C50_41_());
        cmd.set_F_B_42_(state.get_F_B_42_());
        cmd.set_F_I_42_(state.get_F_I_42_());
        cmd.set_F_N_42_(state.get_F_N_42_());
        cmd.set_F_C5_42_(state.get_F_C5_42_());
        cmd.set_F_C10_42_(state.get_F_C10_42_());
        cmd.set_F_C20_42_(state.get_F_C20_42_());
        cmd.set_F_C50_42_(state.get_F_C50_42_());
        cmd.set_F_B_43_(state.get_F_B_43_());
        cmd.set_F_I_43_(state.get_F_I_43_());
        cmd.set_F_N_43_(state.get_F_N_43_());
        cmd.set_F_C5_43_(state.get_F_C5_43_());
        cmd.set_F_C10_43_(state.get_F_C10_43_());
        cmd.set_F_C20_43_(state.get_F_C20_43_());
        cmd.set_F_C50_43_(state.get_F_C50_43_());
        cmd.set_F_B_44_(state.get_F_B_44_());
        cmd.set_F_I_44_(state.get_F_I_44_());
        cmd.set_F_N_44_(state.get_F_N_44_());
        cmd.set_F_C5_44_(state.get_F_C5_44_());
        cmd.set_F_C10_44_(state.get_F_C10_44_());
        cmd.set_F_C20_44_(state.get_F_C20_44_());
        cmd.set_F_C50_44_(state.get_F_C50_44_());
        cmd.set_F_B_45_(state.get_F_B_45_());
        cmd.set_F_I_45_(state.get_F_I_45_());
        cmd.set_F_N_45_(state.get_F_N_45_());
        cmd.set_F_C5_45_(state.get_F_C5_45_());
        cmd.set_F_C10_45_(state.get_F_C10_45_());
        cmd.set_F_C20_45_(state.get_F_C20_45_());
        cmd.set_F_C50_45_(state.get_F_C50_45_());
        cmd.set_F_B_46_(state.get_F_B_46_());
        cmd.set_F_I_46_(state.get_F_I_46_());
        cmd.set_F_N_46_(state.get_F_N_46_());
        cmd.set_F_C5_46_(state.get_F_C5_46_());
        cmd.set_F_C10_46_(state.get_F_C10_46_());
        cmd.set_F_C20_46_(state.get_F_C20_46_());
        cmd.set_F_C50_46_(state.get_F_C50_46_());
        cmd.set_F_B_47_(state.get_F_B_47_());
        cmd.set_F_I_47_(state.get_F_I_47_());
        cmd.set_F_N_47_(state.get_F_N_47_());
        cmd.set_F_C5_47_(state.get_F_C5_47_());
        cmd.set_F_C10_47_(state.get_F_C10_47_());
        cmd.set_F_C20_47_(state.get_F_C20_47_());
        cmd.set_F_C50_47_(state.get_F_C50_47_());
        cmd.set_F_B_48_(state.get_F_B_48_());
        cmd.set_F_I_48_(state.get_F_I_48_());
        cmd.set_F_N_48_(state.get_F_N_48_());
        cmd.set_F_C5_48_(state.get_F_C5_48_());
        cmd.set_F_C10_48_(state.get_F_C10_48_());
        cmd.set_F_C20_48_(state.get_F_C20_48_());
        cmd.set_F_C50_48_(state.get_F_C50_48_());
        cmd.set_F_B_49_(state.get_F_B_49_());
        cmd.set_F_I_49_(state.get_F_I_49_());
        cmd.set_F_N_49_(state.get_F_N_49_());
        cmd.set_F_C5_49_(state.get_F_C5_49_());
        cmd.set_F_C10_49_(state.get_F_C10_49_());
        cmd.set_F_C20_49_(state.get_F_C20_49_());
        cmd.set_F_C50_49_(state.get_F_C50_49_());
        cmd.setActive(state.getActive());
            
        if (state.getAttributeSetId() == null) { cmd.setIsPropertyAttributeSetIdRemoved(true); }
        if (state.getOrganizationId() == null) { cmd.setIsPropertyOrganizationIdRemoved(true); }
        if (state.getReferenceId() == null) { cmd.setIsPropertyReferenceIdRemoved(true); }
        if (state.getSerialNumber() == null) { cmd.setIsPropertySerialNumberRemoved(true); }
        if (state.getLot() == null) { cmd.setIsPropertyLotRemoved(true); }
        if (state.getDescription() == null) { cmd.setIsPropertyDescriptionRemoved(true); }
        if (state.getHash() == null) { cmd.setIsPropertyHashRemoved(true); }
        if (state.get_F_B_0_() == null) { cmd.setIsProperty_F_B_0_Removed(true); }
        if (state.get_F_I_0_() == null) { cmd.setIsProperty_F_I_0_Removed(true); }
        if (state.get_F_L_0_() == null) { cmd.setIsProperty_F_L_0_Removed(true); }
        if (state.get_F_DT_0_() == null) { cmd.setIsProperty_F_DT_0_Removed(true); }
        if (state.get_F_N_0_() == null) { cmd.setIsProperty_F_N_0_Removed(true); }
        if (state.get_F_C5_0_() == null) { cmd.setIsProperty_F_C5_0_Removed(true); }
        if (state.get_F_C10_0_() == null) { cmd.setIsProperty_F_C10_0_Removed(true); }
        if (state.get_F_C20_0_() == null) { cmd.setIsProperty_F_C20_0_Removed(true); }
        if (state.get_F_C50_0_() == null) { cmd.setIsProperty_F_C50_0_Removed(true); }
        if (state.get_F_C100_0_() == null) { cmd.setIsProperty_F_C100_0_Removed(true); }
        if (state.get_F_C200_0_() == null) { cmd.setIsProperty_F_C200_0_Removed(true); }
        if (state.get_F_C500_0_() == null) { cmd.setIsProperty_F_C500_0_Removed(true); }
        if (state.get_F_C1000_0_() == null) { cmd.setIsProperty_F_C1000_0_Removed(true); }
        if (state.get_F_B_1_() == null) { cmd.setIsProperty_F_B_1_Removed(true); }
        if (state.get_F_I_1_() == null) { cmd.setIsProperty_F_I_1_Removed(true); }
        if (state.get_F_L_1_() == null) { cmd.setIsProperty_F_L_1_Removed(true); }
        if (state.get_F_DT_1_() == null) { cmd.setIsProperty_F_DT_1_Removed(true); }
        if (state.get_F_N_1_() == null) { cmd.setIsProperty_F_N_1_Removed(true); }
        if (state.get_F_C5_1_() == null) { cmd.setIsProperty_F_C5_1_Removed(true); }
        if (state.get_F_C10_1_() == null) { cmd.setIsProperty_F_C10_1_Removed(true); }
        if (state.get_F_C20_1_() == null) { cmd.setIsProperty_F_C20_1_Removed(true); }
        if (state.get_F_C50_1_() == null) { cmd.setIsProperty_F_C50_1_Removed(true); }
        if (state.get_F_C100_1_() == null) { cmd.setIsProperty_F_C100_1_Removed(true); }
        if (state.get_F_C200_1_() == null) { cmd.setIsProperty_F_C200_1_Removed(true); }
        if (state.get_F_C500_1_() == null) { cmd.setIsProperty_F_C500_1_Removed(true); }
        if (state.get_F_C1000_1_() == null) { cmd.setIsProperty_F_C1000_1_Removed(true); }
        if (state.get_F_B_2_() == null) { cmd.setIsProperty_F_B_2_Removed(true); }
        if (state.get_F_I_2_() == null) { cmd.setIsProperty_F_I_2_Removed(true); }
        if (state.get_F_L_2_() == null) { cmd.setIsProperty_F_L_2_Removed(true); }
        if (state.get_F_DT_2_() == null) { cmd.setIsProperty_F_DT_2_Removed(true); }
        if (state.get_F_N_2_() == null) { cmd.setIsProperty_F_N_2_Removed(true); }
        if (state.get_F_C5_2_() == null) { cmd.setIsProperty_F_C5_2_Removed(true); }
        if (state.get_F_C10_2_() == null) { cmd.setIsProperty_F_C10_2_Removed(true); }
        if (state.get_F_C20_2_() == null) { cmd.setIsProperty_F_C20_2_Removed(true); }
        if (state.get_F_C50_2_() == null) { cmd.setIsProperty_F_C50_2_Removed(true); }
        if (state.get_F_C100_2_() == null) { cmd.setIsProperty_F_C100_2_Removed(true); }
        if (state.get_F_C200_2_() == null) { cmd.setIsProperty_F_C200_2_Removed(true); }
        if (state.get_F_C500_2_() == null) { cmd.setIsProperty_F_C500_2_Removed(true); }
        if (state.get_F_C1000_2_() == null) { cmd.setIsProperty_F_C1000_2_Removed(true); }
        if (state.get_F_B_3_() == null) { cmd.setIsProperty_F_B_3_Removed(true); }
        if (state.get_F_I_3_() == null) { cmd.setIsProperty_F_I_3_Removed(true); }
        if (state.get_F_L_3_() == null) { cmd.setIsProperty_F_L_3_Removed(true); }
        if (state.get_F_DT_3_() == null) { cmd.setIsProperty_F_DT_3_Removed(true); }
        if (state.get_F_N_3_() == null) { cmd.setIsProperty_F_N_3_Removed(true); }
        if (state.get_F_C5_3_() == null) { cmd.setIsProperty_F_C5_3_Removed(true); }
        if (state.get_F_C10_3_() == null) { cmd.setIsProperty_F_C10_3_Removed(true); }
        if (state.get_F_C20_3_() == null) { cmd.setIsProperty_F_C20_3_Removed(true); }
        if (state.get_F_C50_3_() == null) { cmd.setIsProperty_F_C50_3_Removed(true); }
        if (state.get_F_C100_3_() == null) { cmd.setIsProperty_F_C100_3_Removed(true); }
        if (state.get_F_C200_3_() == null) { cmd.setIsProperty_F_C200_3_Removed(true); }
        if (state.get_F_C500_3_() == null) { cmd.setIsProperty_F_C500_3_Removed(true); }
        if (state.get_F_C1000_3_() == null) { cmd.setIsProperty_F_C1000_3_Removed(true); }
        if (state.get_F_B_4_() == null) { cmd.setIsProperty_F_B_4_Removed(true); }
        if (state.get_F_I_4_() == null) { cmd.setIsProperty_F_I_4_Removed(true); }
        if (state.get_F_L_4_() == null) { cmd.setIsProperty_F_L_4_Removed(true); }
        if (state.get_F_DT_4_() == null) { cmd.setIsProperty_F_DT_4_Removed(true); }
        if (state.get_F_N_4_() == null) { cmd.setIsProperty_F_N_4_Removed(true); }
        if (state.get_F_C5_4_() == null) { cmd.setIsProperty_F_C5_4_Removed(true); }
        if (state.get_F_C10_4_() == null) { cmd.setIsProperty_F_C10_4_Removed(true); }
        if (state.get_F_C20_4_() == null) { cmd.setIsProperty_F_C20_4_Removed(true); }
        if (state.get_F_C50_4_() == null) { cmd.setIsProperty_F_C50_4_Removed(true); }
        if (state.get_F_C100_4_() == null) { cmd.setIsProperty_F_C100_4_Removed(true); }
        if (state.get_F_C200_4_() == null) { cmd.setIsProperty_F_C200_4_Removed(true); }
        if (state.get_F_C500_4_() == null) { cmd.setIsProperty_F_C500_4_Removed(true); }
        if (state.get_F_C1000_4_() == null) { cmd.setIsProperty_F_C1000_4_Removed(true); }
        if (state.get_F_B_5_() == null) { cmd.setIsProperty_F_B_5_Removed(true); }
        if (state.get_F_I_5_() == null) { cmd.setIsProperty_F_I_5_Removed(true); }
        if (state.get_F_L_5_() == null) { cmd.setIsProperty_F_L_5_Removed(true); }
        if (state.get_F_DT_5_() == null) { cmd.setIsProperty_F_DT_5_Removed(true); }
        if (state.get_F_N_5_() == null) { cmd.setIsProperty_F_N_5_Removed(true); }
        if (state.get_F_C5_5_() == null) { cmd.setIsProperty_F_C5_5_Removed(true); }
        if (state.get_F_C10_5_() == null) { cmd.setIsProperty_F_C10_5_Removed(true); }
        if (state.get_F_C20_5_() == null) { cmd.setIsProperty_F_C20_5_Removed(true); }
        if (state.get_F_C50_5_() == null) { cmd.setIsProperty_F_C50_5_Removed(true); }
        if (state.get_F_C100_5_() == null) { cmd.setIsProperty_F_C100_5_Removed(true); }
        if (state.get_F_C200_5_() == null) { cmd.setIsProperty_F_C200_5_Removed(true); }
        if (state.get_F_C500_5_() == null) { cmd.setIsProperty_F_C500_5_Removed(true); }
        if (state.get_F_B_6_() == null) { cmd.setIsProperty_F_B_6_Removed(true); }
        if (state.get_F_I_6_() == null) { cmd.setIsProperty_F_I_6_Removed(true); }
        if (state.get_F_L_6_() == null) { cmd.setIsProperty_F_L_6_Removed(true); }
        if (state.get_F_DT_6_() == null) { cmd.setIsProperty_F_DT_6_Removed(true); }
        if (state.get_F_N_6_() == null) { cmd.setIsProperty_F_N_6_Removed(true); }
        if (state.get_F_C5_6_() == null) { cmd.setIsProperty_F_C5_6_Removed(true); }
        if (state.get_F_C10_6_() == null) { cmd.setIsProperty_F_C10_6_Removed(true); }
        if (state.get_F_C20_6_() == null) { cmd.setIsProperty_F_C20_6_Removed(true); }
        if (state.get_F_C50_6_() == null) { cmd.setIsProperty_F_C50_6_Removed(true); }
        if (state.get_F_C100_6_() == null) { cmd.setIsProperty_F_C100_6_Removed(true); }
        if (state.get_F_C200_6_() == null) { cmd.setIsProperty_F_C200_6_Removed(true); }
        if (state.get_F_C500_6_() == null) { cmd.setIsProperty_F_C500_6_Removed(true); }
        if (state.get_F_B_7_() == null) { cmd.setIsProperty_F_B_7_Removed(true); }
        if (state.get_F_I_7_() == null) { cmd.setIsProperty_F_I_7_Removed(true); }
        if (state.get_F_L_7_() == null) { cmd.setIsProperty_F_L_7_Removed(true); }
        if (state.get_F_DT_7_() == null) { cmd.setIsProperty_F_DT_7_Removed(true); }
        if (state.get_F_N_7_() == null) { cmd.setIsProperty_F_N_7_Removed(true); }
        if (state.get_F_C5_7_() == null) { cmd.setIsProperty_F_C5_7_Removed(true); }
        if (state.get_F_C10_7_() == null) { cmd.setIsProperty_F_C10_7_Removed(true); }
        if (state.get_F_C20_7_() == null) { cmd.setIsProperty_F_C20_7_Removed(true); }
        if (state.get_F_C50_7_() == null) { cmd.setIsProperty_F_C50_7_Removed(true); }
        if (state.get_F_C100_7_() == null) { cmd.setIsProperty_F_C100_7_Removed(true); }
        if (state.get_F_C200_7_() == null) { cmd.setIsProperty_F_C200_7_Removed(true); }
        if (state.get_F_C500_7_() == null) { cmd.setIsProperty_F_C500_7_Removed(true); }
        if (state.get_F_B_8_() == null) { cmd.setIsProperty_F_B_8_Removed(true); }
        if (state.get_F_I_8_() == null) { cmd.setIsProperty_F_I_8_Removed(true); }
        if (state.get_F_L_8_() == null) { cmd.setIsProperty_F_L_8_Removed(true); }
        if (state.get_F_DT_8_() == null) { cmd.setIsProperty_F_DT_8_Removed(true); }
        if (state.get_F_N_8_() == null) { cmd.setIsProperty_F_N_8_Removed(true); }
        if (state.get_F_C5_8_() == null) { cmd.setIsProperty_F_C5_8_Removed(true); }
        if (state.get_F_C10_8_() == null) { cmd.setIsProperty_F_C10_8_Removed(true); }
        if (state.get_F_C20_8_() == null) { cmd.setIsProperty_F_C20_8_Removed(true); }
        if (state.get_F_C50_8_() == null) { cmd.setIsProperty_F_C50_8_Removed(true); }
        if (state.get_F_C100_8_() == null) { cmd.setIsProperty_F_C100_8_Removed(true); }
        if (state.get_F_C200_8_() == null) { cmd.setIsProperty_F_C200_8_Removed(true); }
        if (state.get_F_C500_8_() == null) { cmd.setIsProperty_F_C500_8_Removed(true); }
        if (state.get_F_B_9_() == null) { cmd.setIsProperty_F_B_9_Removed(true); }
        if (state.get_F_I_9_() == null) { cmd.setIsProperty_F_I_9_Removed(true); }
        if (state.get_F_L_9_() == null) { cmd.setIsProperty_F_L_9_Removed(true); }
        if (state.get_F_DT_9_() == null) { cmd.setIsProperty_F_DT_9_Removed(true); }
        if (state.get_F_N_9_() == null) { cmd.setIsProperty_F_N_9_Removed(true); }
        if (state.get_F_C5_9_() == null) { cmd.setIsProperty_F_C5_9_Removed(true); }
        if (state.get_F_C10_9_() == null) { cmd.setIsProperty_F_C10_9_Removed(true); }
        if (state.get_F_C20_9_() == null) { cmd.setIsProperty_F_C20_9_Removed(true); }
        if (state.get_F_C50_9_() == null) { cmd.setIsProperty_F_C50_9_Removed(true); }
        if (state.get_F_C100_9_() == null) { cmd.setIsProperty_F_C100_9_Removed(true); }
        if (state.get_F_C200_9_() == null) { cmd.setIsProperty_F_C200_9_Removed(true); }
        if (state.get_F_C500_9_() == null) { cmd.setIsProperty_F_C500_9_Removed(true); }
        if (state.get_F_B_10_() == null) { cmd.setIsProperty_F_B_10_Removed(true); }
        if (state.get_F_I_10_() == null) { cmd.setIsProperty_F_I_10_Removed(true); }
        if (state.get_F_L_10_() == null) { cmd.setIsProperty_F_L_10_Removed(true); }
        if (state.get_F_DT_10_() == null) { cmd.setIsProperty_F_DT_10_Removed(true); }
        if (state.get_F_N_10_() == null) { cmd.setIsProperty_F_N_10_Removed(true); }
        if (state.get_F_C5_10_() == null) { cmd.setIsProperty_F_C5_10_Removed(true); }
        if (state.get_F_C10_10_() == null) { cmd.setIsProperty_F_C10_10_Removed(true); }
        if (state.get_F_C20_10_() == null) { cmd.setIsProperty_F_C20_10_Removed(true); }
        if (state.get_F_C50_10_() == null) { cmd.setIsProperty_F_C50_10_Removed(true); }
        if (state.get_F_C100_10_() == null) { cmd.setIsProperty_F_C100_10_Removed(true); }
        if (state.get_F_C200_10_() == null) { cmd.setIsProperty_F_C200_10_Removed(true); }
        if (state.get_F_B_11_() == null) { cmd.setIsProperty_F_B_11_Removed(true); }
        if (state.get_F_I_11_() == null) { cmd.setIsProperty_F_I_11_Removed(true); }
        if (state.get_F_L_11_() == null) { cmd.setIsProperty_F_L_11_Removed(true); }
        if (state.get_F_DT_11_() == null) { cmd.setIsProperty_F_DT_11_Removed(true); }
        if (state.get_F_N_11_() == null) { cmd.setIsProperty_F_N_11_Removed(true); }
        if (state.get_F_C5_11_() == null) { cmd.setIsProperty_F_C5_11_Removed(true); }
        if (state.get_F_C10_11_() == null) { cmd.setIsProperty_F_C10_11_Removed(true); }
        if (state.get_F_C20_11_() == null) { cmd.setIsProperty_F_C20_11_Removed(true); }
        if (state.get_F_C50_11_() == null) { cmd.setIsProperty_F_C50_11_Removed(true); }
        if (state.get_F_C100_11_() == null) { cmd.setIsProperty_F_C100_11_Removed(true); }
        if (state.get_F_C200_11_() == null) { cmd.setIsProperty_F_C200_11_Removed(true); }
        if (state.get_F_B_12_() == null) { cmd.setIsProperty_F_B_12_Removed(true); }
        if (state.get_F_I_12_() == null) { cmd.setIsProperty_F_I_12_Removed(true); }
        if (state.get_F_L_12_() == null) { cmd.setIsProperty_F_L_12_Removed(true); }
        if (state.get_F_DT_12_() == null) { cmd.setIsProperty_F_DT_12_Removed(true); }
        if (state.get_F_N_12_() == null) { cmd.setIsProperty_F_N_12_Removed(true); }
        if (state.get_F_C5_12_() == null) { cmd.setIsProperty_F_C5_12_Removed(true); }
        if (state.get_F_C10_12_() == null) { cmd.setIsProperty_F_C10_12_Removed(true); }
        if (state.get_F_C20_12_() == null) { cmd.setIsProperty_F_C20_12_Removed(true); }
        if (state.get_F_C50_12_() == null) { cmd.setIsProperty_F_C50_12_Removed(true); }
        if (state.get_F_C100_12_() == null) { cmd.setIsProperty_F_C100_12_Removed(true); }
        if (state.get_F_C200_12_() == null) { cmd.setIsProperty_F_C200_12_Removed(true); }
        if (state.get_F_B_13_() == null) { cmd.setIsProperty_F_B_13_Removed(true); }
        if (state.get_F_I_13_() == null) { cmd.setIsProperty_F_I_13_Removed(true); }
        if (state.get_F_L_13_() == null) { cmd.setIsProperty_F_L_13_Removed(true); }
        if (state.get_F_DT_13_() == null) { cmd.setIsProperty_F_DT_13_Removed(true); }
        if (state.get_F_N_13_() == null) { cmd.setIsProperty_F_N_13_Removed(true); }
        if (state.get_F_C5_13_() == null) { cmd.setIsProperty_F_C5_13_Removed(true); }
        if (state.get_F_C10_13_() == null) { cmd.setIsProperty_F_C10_13_Removed(true); }
        if (state.get_F_C20_13_() == null) { cmd.setIsProperty_F_C20_13_Removed(true); }
        if (state.get_F_C50_13_() == null) { cmd.setIsProperty_F_C50_13_Removed(true); }
        if (state.get_F_C100_13_() == null) { cmd.setIsProperty_F_C100_13_Removed(true); }
        if (state.get_F_C200_13_() == null) { cmd.setIsProperty_F_C200_13_Removed(true); }
        if (state.get_F_B_14_() == null) { cmd.setIsProperty_F_B_14_Removed(true); }
        if (state.get_F_I_14_() == null) { cmd.setIsProperty_F_I_14_Removed(true); }
        if (state.get_F_L_14_() == null) { cmd.setIsProperty_F_L_14_Removed(true); }
        if (state.get_F_DT_14_() == null) { cmd.setIsProperty_F_DT_14_Removed(true); }
        if (state.get_F_N_14_() == null) { cmd.setIsProperty_F_N_14_Removed(true); }
        if (state.get_F_C5_14_() == null) { cmd.setIsProperty_F_C5_14_Removed(true); }
        if (state.get_F_C10_14_() == null) { cmd.setIsProperty_F_C10_14_Removed(true); }
        if (state.get_F_C20_14_() == null) { cmd.setIsProperty_F_C20_14_Removed(true); }
        if (state.get_F_C50_14_() == null) { cmd.setIsProperty_F_C50_14_Removed(true); }
        if (state.get_F_C100_14_() == null) { cmd.setIsProperty_F_C100_14_Removed(true); }
        if (state.get_F_C200_14_() == null) { cmd.setIsProperty_F_C200_14_Removed(true); }
        if (state.get_F_B_15_() == null) { cmd.setIsProperty_F_B_15_Removed(true); }
        if (state.get_F_I_15_() == null) { cmd.setIsProperty_F_I_15_Removed(true); }
        if (state.get_F_L_15_() == null) { cmd.setIsProperty_F_L_15_Removed(true); }
        if (state.get_F_DT_15_() == null) { cmd.setIsProperty_F_DT_15_Removed(true); }
        if (state.get_F_N_15_() == null) { cmd.setIsProperty_F_N_15_Removed(true); }
        if (state.get_F_C5_15_() == null) { cmd.setIsProperty_F_C5_15_Removed(true); }
        if (state.get_F_C10_15_() == null) { cmd.setIsProperty_F_C10_15_Removed(true); }
        if (state.get_F_C20_15_() == null) { cmd.setIsProperty_F_C20_15_Removed(true); }
        if (state.get_F_C50_15_() == null) { cmd.setIsProperty_F_C50_15_Removed(true); }
        if (state.get_F_C100_15_() == null) { cmd.setIsProperty_F_C100_15_Removed(true); }
        if (state.get_F_C200_15_() == null) { cmd.setIsProperty_F_C200_15_Removed(true); }
        if (state.get_F_B_16_() == null) { cmd.setIsProperty_F_B_16_Removed(true); }
        if (state.get_F_I_16_() == null) { cmd.setIsProperty_F_I_16_Removed(true); }
        if (state.get_F_L_16_() == null) { cmd.setIsProperty_F_L_16_Removed(true); }
        if (state.get_F_DT_16_() == null) { cmd.setIsProperty_F_DT_16_Removed(true); }
        if (state.get_F_N_16_() == null) { cmd.setIsProperty_F_N_16_Removed(true); }
        if (state.get_F_C5_16_() == null) { cmd.setIsProperty_F_C5_16_Removed(true); }
        if (state.get_F_C10_16_() == null) { cmd.setIsProperty_F_C10_16_Removed(true); }
        if (state.get_F_C20_16_() == null) { cmd.setIsProperty_F_C20_16_Removed(true); }
        if (state.get_F_C50_16_() == null) { cmd.setIsProperty_F_C50_16_Removed(true); }
        if (state.get_F_C100_16_() == null) { cmd.setIsProperty_F_C100_16_Removed(true); }
        if (state.get_F_C200_16_() == null) { cmd.setIsProperty_F_C200_16_Removed(true); }
        if (state.get_F_B_17_() == null) { cmd.setIsProperty_F_B_17_Removed(true); }
        if (state.get_F_I_17_() == null) { cmd.setIsProperty_F_I_17_Removed(true); }
        if (state.get_F_L_17_() == null) { cmd.setIsProperty_F_L_17_Removed(true); }
        if (state.get_F_DT_17_() == null) { cmd.setIsProperty_F_DT_17_Removed(true); }
        if (state.get_F_N_17_() == null) { cmd.setIsProperty_F_N_17_Removed(true); }
        if (state.get_F_C5_17_() == null) { cmd.setIsProperty_F_C5_17_Removed(true); }
        if (state.get_F_C10_17_() == null) { cmd.setIsProperty_F_C10_17_Removed(true); }
        if (state.get_F_C20_17_() == null) { cmd.setIsProperty_F_C20_17_Removed(true); }
        if (state.get_F_C50_17_() == null) { cmd.setIsProperty_F_C50_17_Removed(true); }
        if (state.get_F_C100_17_() == null) { cmd.setIsProperty_F_C100_17_Removed(true); }
        if (state.get_F_C200_17_() == null) { cmd.setIsProperty_F_C200_17_Removed(true); }
        if (state.get_F_B_18_() == null) { cmd.setIsProperty_F_B_18_Removed(true); }
        if (state.get_F_I_18_() == null) { cmd.setIsProperty_F_I_18_Removed(true); }
        if (state.get_F_L_18_() == null) { cmd.setIsProperty_F_L_18_Removed(true); }
        if (state.get_F_DT_18_() == null) { cmd.setIsProperty_F_DT_18_Removed(true); }
        if (state.get_F_N_18_() == null) { cmd.setIsProperty_F_N_18_Removed(true); }
        if (state.get_F_C5_18_() == null) { cmd.setIsProperty_F_C5_18_Removed(true); }
        if (state.get_F_C10_18_() == null) { cmd.setIsProperty_F_C10_18_Removed(true); }
        if (state.get_F_C20_18_() == null) { cmd.setIsProperty_F_C20_18_Removed(true); }
        if (state.get_F_C50_18_() == null) { cmd.setIsProperty_F_C50_18_Removed(true); }
        if (state.get_F_C100_18_() == null) { cmd.setIsProperty_F_C100_18_Removed(true); }
        if (state.get_F_C200_18_() == null) { cmd.setIsProperty_F_C200_18_Removed(true); }
        if (state.get_F_B_19_() == null) { cmd.setIsProperty_F_B_19_Removed(true); }
        if (state.get_F_I_19_() == null) { cmd.setIsProperty_F_I_19_Removed(true); }
        if (state.get_F_L_19_() == null) { cmd.setIsProperty_F_L_19_Removed(true); }
        if (state.get_F_DT_19_() == null) { cmd.setIsProperty_F_DT_19_Removed(true); }
        if (state.get_F_N_19_() == null) { cmd.setIsProperty_F_N_19_Removed(true); }
        if (state.get_F_C5_19_() == null) { cmd.setIsProperty_F_C5_19_Removed(true); }
        if (state.get_F_C10_19_() == null) { cmd.setIsProperty_F_C10_19_Removed(true); }
        if (state.get_F_C20_19_() == null) { cmd.setIsProperty_F_C20_19_Removed(true); }
        if (state.get_F_C50_19_() == null) { cmd.setIsProperty_F_C50_19_Removed(true); }
        if (state.get_F_C100_19_() == null) { cmd.setIsProperty_F_C100_19_Removed(true); }
        if (state.get_F_C200_19_() == null) { cmd.setIsProperty_F_C200_19_Removed(true); }
        if (state.get_F_B_20_() == null) { cmd.setIsProperty_F_B_20_Removed(true); }
        if (state.get_F_I_20_() == null) { cmd.setIsProperty_F_I_20_Removed(true); }
        if (state.get_F_L_20_() == null) { cmd.setIsProperty_F_L_20_Removed(true); }
        if (state.get_F_N_20_() == null) { cmd.setIsProperty_F_N_20_Removed(true); }
        if (state.get_F_C5_20_() == null) { cmd.setIsProperty_F_C5_20_Removed(true); }
        if (state.get_F_C10_20_() == null) { cmd.setIsProperty_F_C10_20_Removed(true); }
        if (state.get_F_C20_20_() == null) { cmd.setIsProperty_F_C20_20_Removed(true); }
        if (state.get_F_C50_20_() == null) { cmd.setIsProperty_F_C50_20_Removed(true); }
        if (state.get_F_B_21_() == null) { cmd.setIsProperty_F_B_21_Removed(true); }
        if (state.get_F_I_21_() == null) { cmd.setIsProperty_F_I_21_Removed(true); }
        if (state.get_F_L_21_() == null) { cmd.setIsProperty_F_L_21_Removed(true); }
        if (state.get_F_N_21_() == null) { cmd.setIsProperty_F_N_21_Removed(true); }
        if (state.get_F_C5_21_() == null) { cmd.setIsProperty_F_C5_21_Removed(true); }
        if (state.get_F_C10_21_() == null) { cmd.setIsProperty_F_C10_21_Removed(true); }
        if (state.get_F_C20_21_() == null) { cmd.setIsProperty_F_C20_21_Removed(true); }
        if (state.get_F_C50_21_() == null) { cmd.setIsProperty_F_C50_21_Removed(true); }
        if (state.get_F_B_22_() == null) { cmd.setIsProperty_F_B_22_Removed(true); }
        if (state.get_F_I_22_() == null) { cmd.setIsProperty_F_I_22_Removed(true); }
        if (state.get_F_L_22_() == null) { cmd.setIsProperty_F_L_22_Removed(true); }
        if (state.get_F_N_22_() == null) { cmd.setIsProperty_F_N_22_Removed(true); }
        if (state.get_F_C5_22_() == null) { cmd.setIsProperty_F_C5_22_Removed(true); }
        if (state.get_F_C10_22_() == null) { cmd.setIsProperty_F_C10_22_Removed(true); }
        if (state.get_F_C20_22_() == null) { cmd.setIsProperty_F_C20_22_Removed(true); }
        if (state.get_F_C50_22_() == null) { cmd.setIsProperty_F_C50_22_Removed(true); }
        if (state.get_F_B_23_() == null) { cmd.setIsProperty_F_B_23_Removed(true); }
        if (state.get_F_I_23_() == null) { cmd.setIsProperty_F_I_23_Removed(true); }
        if (state.get_F_L_23_() == null) { cmd.setIsProperty_F_L_23_Removed(true); }
        if (state.get_F_N_23_() == null) { cmd.setIsProperty_F_N_23_Removed(true); }
        if (state.get_F_C5_23_() == null) { cmd.setIsProperty_F_C5_23_Removed(true); }
        if (state.get_F_C10_23_() == null) { cmd.setIsProperty_F_C10_23_Removed(true); }
        if (state.get_F_C20_23_() == null) { cmd.setIsProperty_F_C20_23_Removed(true); }
        if (state.get_F_C50_23_() == null) { cmd.setIsProperty_F_C50_23_Removed(true); }
        if (state.get_F_B_24_() == null) { cmd.setIsProperty_F_B_24_Removed(true); }
        if (state.get_F_I_24_() == null) { cmd.setIsProperty_F_I_24_Removed(true); }
        if (state.get_F_L_24_() == null) { cmd.setIsProperty_F_L_24_Removed(true); }
        if (state.get_F_N_24_() == null) { cmd.setIsProperty_F_N_24_Removed(true); }
        if (state.get_F_C5_24_() == null) { cmd.setIsProperty_F_C5_24_Removed(true); }
        if (state.get_F_C10_24_() == null) { cmd.setIsProperty_F_C10_24_Removed(true); }
        if (state.get_F_C20_24_() == null) { cmd.setIsProperty_F_C20_24_Removed(true); }
        if (state.get_F_C50_24_() == null) { cmd.setIsProperty_F_C50_24_Removed(true); }
        if (state.get_F_B_25_() == null) { cmd.setIsProperty_F_B_25_Removed(true); }
        if (state.get_F_I_25_() == null) { cmd.setIsProperty_F_I_25_Removed(true); }
        if (state.get_F_L_25_() == null) { cmd.setIsProperty_F_L_25_Removed(true); }
        if (state.get_F_N_25_() == null) { cmd.setIsProperty_F_N_25_Removed(true); }
        if (state.get_F_C5_25_() == null) { cmd.setIsProperty_F_C5_25_Removed(true); }
        if (state.get_F_C10_25_() == null) { cmd.setIsProperty_F_C10_25_Removed(true); }
        if (state.get_F_C20_25_() == null) { cmd.setIsProperty_F_C20_25_Removed(true); }
        if (state.get_F_C50_25_() == null) { cmd.setIsProperty_F_C50_25_Removed(true); }
        if (state.get_F_B_26_() == null) { cmd.setIsProperty_F_B_26_Removed(true); }
        if (state.get_F_I_26_() == null) { cmd.setIsProperty_F_I_26_Removed(true); }
        if (state.get_F_L_26_() == null) { cmd.setIsProperty_F_L_26_Removed(true); }
        if (state.get_F_N_26_() == null) { cmd.setIsProperty_F_N_26_Removed(true); }
        if (state.get_F_C5_26_() == null) { cmd.setIsProperty_F_C5_26_Removed(true); }
        if (state.get_F_C10_26_() == null) { cmd.setIsProperty_F_C10_26_Removed(true); }
        if (state.get_F_C20_26_() == null) { cmd.setIsProperty_F_C20_26_Removed(true); }
        if (state.get_F_C50_26_() == null) { cmd.setIsProperty_F_C50_26_Removed(true); }
        if (state.get_F_B_27_() == null) { cmd.setIsProperty_F_B_27_Removed(true); }
        if (state.get_F_I_27_() == null) { cmd.setIsProperty_F_I_27_Removed(true); }
        if (state.get_F_L_27_() == null) { cmd.setIsProperty_F_L_27_Removed(true); }
        if (state.get_F_N_27_() == null) { cmd.setIsProperty_F_N_27_Removed(true); }
        if (state.get_F_C5_27_() == null) { cmd.setIsProperty_F_C5_27_Removed(true); }
        if (state.get_F_C10_27_() == null) { cmd.setIsProperty_F_C10_27_Removed(true); }
        if (state.get_F_C20_27_() == null) { cmd.setIsProperty_F_C20_27_Removed(true); }
        if (state.get_F_C50_27_() == null) { cmd.setIsProperty_F_C50_27_Removed(true); }
        if (state.get_F_B_28_() == null) { cmd.setIsProperty_F_B_28_Removed(true); }
        if (state.get_F_I_28_() == null) { cmd.setIsProperty_F_I_28_Removed(true); }
        if (state.get_F_L_28_() == null) { cmd.setIsProperty_F_L_28_Removed(true); }
        if (state.get_F_N_28_() == null) { cmd.setIsProperty_F_N_28_Removed(true); }
        if (state.get_F_C5_28_() == null) { cmd.setIsProperty_F_C5_28_Removed(true); }
        if (state.get_F_C10_28_() == null) { cmd.setIsProperty_F_C10_28_Removed(true); }
        if (state.get_F_C20_28_() == null) { cmd.setIsProperty_F_C20_28_Removed(true); }
        if (state.get_F_C50_28_() == null) { cmd.setIsProperty_F_C50_28_Removed(true); }
        if (state.get_F_B_29_() == null) { cmd.setIsProperty_F_B_29_Removed(true); }
        if (state.get_F_I_29_() == null) { cmd.setIsProperty_F_I_29_Removed(true); }
        if (state.get_F_L_29_() == null) { cmd.setIsProperty_F_L_29_Removed(true); }
        if (state.get_F_N_29_() == null) { cmd.setIsProperty_F_N_29_Removed(true); }
        if (state.get_F_C5_29_() == null) { cmd.setIsProperty_F_C5_29_Removed(true); }
        if (state.get_F_C10_29_() == null) { cmd.setIsProperty_F_C10_29_Removed(true); }
        if (state.get_F_C20_29_() == null) { cmd.setIsProperty_F_C20_29_Removed(true); }
        if (state.get_F_C50_29_() == null) { cmd.setIsProperty_F_C50_29_Removed(true); }
        if (state.get_F_B_30_() == null) { cmd.setIsProperty_F_B_30_Removed(true); }
        if (state.get_F_I_30_() == null) { cmd.setIsProperty_F_I_30_Removed(true); }
        if (state.get_F_N_30_() == null) { cmd.setIsProperty_F_N_30_Removed(true); }
        if (state.get_F_C5_30_() == null) { cmd.setIsProperty_F_C5_30_Removed(true); }
        if (state.get_F_C10_30_() == null) { cmd.setIsProperty_F_C10_30_Removed(true); }
        if (state.get_F_C20_30_() == null) { cmd.setIsProperty_F_C20_30_Removed(true); }
        if (state.get_F_C50_30_() == null) { cmd.setIsProperty_F_C50_30_Removed(true); }
        if (state.get_F_B_31_() == null) { cmd.setIsProperty_F_B_31_Removed(true); }
        if (state.get_F_I_31_() == null) { cmd.setIsProperty_F_I_31_Removed(true); }
        if (state.get_F_N_31_() == null) { cmd.setIsProperty_F_N_31_Removed(true); }
        if (state.get_F_C5_31_() == null) { cmd.setIsProperty_F_C5_31_Removed(true); }
        if (state.get_F_C10_31_() == null) { cmd.setIsProperty_F_C10_31_Removed(true); }
        if (state.get_F_C20_31_() == null) { cmd.setIsProperty_F_C20_31_Removed(true); }
        if (state.get_F_C50_31_() == null) { cmd.setIsProperty_F_C50_31_Removed(true); }
        if (state.get_F_B_32_() == null) { cmd.setIsProperty_F_B_32_Removed(true); }
        if (state.get_F_I_32_() == null) { cmd.setIsProperty_F_I_32_Removed(true); }
        if (state.get_F_N_32_() == null) { cmd.setIsProperty_F_N_32_Removed(true); }
        if (state.get_F_C5_32_() == null) { cmd.setIsProperty_F_C5_32_Removed(true); }
        if (state.get_F_C10_32_() == null) { cmd.setIsProperty_F_C10_32_Removed(true); }
        if (state.get_F_C20_32_() == null) { cmd.setIsProperty_F_C20_32_Removed(true); }
        if (state.get_F_C50_32_() == null) { cmd.setIsProperty_F_C50_32_Removed(true); }
        if (state.get_F_B_33_() == null) { cmd.setIsProperty_F_B_33_Removed(true); }
        if (state.get_F_I_33_() == null) { cmd.setIsProperty_F_I_33_Removed(true); }
        if (state.get_F_N_33_() == null) { cmd.setIsProperty_F_N_33_Removed(true); }
        if (state.get_F_C5_33_() == null) { cmd.setIsProperty_F_C5_33_Removed(true); }
        if (state.get_F_C10_33_() == null) { cmd.setIsProperty_F_C10_33_Removed(true); }
        if (state.get_F_C20_33_() == null) { cmd.setIsProperty_F_C20_33_Removed(true); }
        if (state.get_F_C50_33_() == null) { cmd.setIsProperty_F_C50_33_Removed(true); }
        if (state.get_F_B_34_() == null) { cmd.setIsProperty_F_B_34_Removed(true); }
        if (state.get_F_I_34_() == null) { cmd.setIsProperty_F_I_34_Removed(true); }
        if (state.get_F_N_34_() == null) { cmd.setIsProperty_F_N_34_Removed(true); }
        if (state.get_F_C5_34_() == null) { cmd.setIsProperty_F_C5_34_Removed(true); }
        if (state.get_F_C10_34_() == null) { cmd.setIsProperty_F_C10_34_Removed(true); }
        if (state.get_F_C20_34_() == null) { cmd.setIsProperty_F_C20_34_Removed(true); }
        if (state.get_F_C50_34_() == null) { cmd.setIsProperty_F_C50_34_Removed(true); }
        if (state.get_F_B_35_() == null) { cmd.setIsProperty_F_B_35_Removed(true); }
        if (state.get_F_I_35_() == null) { cmd.setIsProperty_F_I_35_Removed(true); }
        if (state.get_F_N_35_() == null) { cmd.setIsProperty_F_N_35_Removed(true); }
        if (state.get_F_C5_35_() == null) { cmd.setIsProperty_F_C5_35_Removed(true); }
        if (state.get_F_C10_35_() == null) { cmd.setIsProperty_F_C10_35_Removed(true); }
        if (state.get_F_C20_35_() == null) { cmd.setIsProperty_F_C20_35_Removed(true); }
        if (state.get_F_C50_35_() == null) { cmd.setIsProperty_F_C50_35_Removed(true); }
        if (state.get_F_B_36_() == null) { cmd.setIsProperty_F_B_36_Removed(true); }
        if (state.get_F_I_36_() == null) { cmd.setIsProperty_F_I_36_Removed(true); }
        if (state.get_F_N_36_() == null) { cmd.setIsProperty_F_N_36_Removed(true); }
        if (state.get_F_C5_36_() == null) { cmd.setIsProperty_F_C5_36_Removed(true); }
        if (state.get_F_C10_36_() == null) { cmd.setIsProperty_F_C10_36_Removed(true); }
        if (state.get_F_C20_36_() == null) { cmd.setIsProperty_F_C20_36_Removed(true); }
        if (state.get_F_C50_36_() == null) { cmd.setIsProperty_F_C50_36_Removed(true); }
        if (state.get_F_B_37_() == null) { cmd.setIsProperty_F_B_37_Removed(true); }
        if (state.get_F_I_37_() == null) { cmd.setIsProperty_F_I_37_Removed(true); }
        if (state.get_F_N_37_() == null) { cmd.setIsProperty_F_N_37_Removed(true); }
        if (state.get_F_C5_37_() == null) { cmd.setIsProperty_F_C5_37_Removed(true); }
        if (state.get_F_C10_37_() == null) { cmd.setIsProperty_F_C10_37_Removed(true); }
        if (state.get_F_C20_37_() == null) { cmd.setIsProperty_F_C20_37_Removed(true); }
        if (state.get_F_C50_37_() == null) { cmd.setIsProperty_F_C50_37_Removed(true); }
        if (state.get_F_B_38_() == null) { cmd.setIsProperty_F_B_38_Removed(true); }
        if (state.get_F_I_38_() == null) { cmd.setIsProperty_F_I_38_Removed(true); }
        if (state.get_F_N_38_() == null) { cmd.setIsProperty_F_N_38_Removed(true); }
        if (state.get_F_C5_38_() == null) { cmd.setIsProperty_F_C5_38_Removed(true); }
        if (state.get_F_C10_38_() == null) { cmd.setIsProperty_F_C10_38_Removed(true); }
        if (state.get_F_C20_38_() == null) { cmd.setIsProperty_F_C20_38_Removed(true); }
        if (state.get_F_C50_38_() == null) { cmd.setIsProperty_F_C50_38_Removed(true); }
        if (state.get_F_B_39_() == null) { cmd.setIsProperty_F_B_39_Removed(true); }
        if (state.get_F_I_39_() == null) { cmd.setIsProperty_F_I_39_Removed(true); }
        if (state.get_F_N_39_() == null) { cmd.setIsProperty_F_N_39_Removed(true); }
        if (state.get_F_C5_39_() == null) { cmd.setIsProperty_F_C5_39_Removed(true); }
        if (state.get_F_C10_39_() == null) { cmd.setIsProperty_F_C10_39_Removed(true); }
        if (state.get_F_C20_39_() == null) { cmd.setIsProperty_F_C20_39_Removed(true); }
        if (state.get_F_C50_39_() == null) { cmd.setIsProperty_F_C50_39_Removed(true); }
        if (state.get_F_B_40_() == null) { cmd.setIsProperty_F_B_40_Removed(true); }
        if (state.get_F_I_40_() == null) { cmd.setIsProperty_F_I_40_Removed(true); }
        if (state.get_F_N_40_() == null) { cmd.setIsProperty_F_N_40_Removed(true); }
        if (state.get_F_C5_40_() == null) { cmd.setIsProperty_F_C5_40_Removed(true); }
        if (state.get_F_C10_40_() == null) { cmd.setIsProperty_F_C10_40_Removed(true); }
        if (state.get_F_C20_40_() == null) { cmd.setIsProperty_F_C20_40_Removed(true); }
        if (state.get_F_C50_40_() == null) { cmd.setIsProperty_F_C50_40_Removed(true); }
        if (state.get_F_B_41_() == null) { cmd.setIsProperty_F_B_41_Removed(true); }
        if (state.get_F_I_41_() == null) { cmd.setIsProperty_F_I_41_Removed(true); }
        if (state.get_F_N_41_() == null) { cmd.setIsProperty_F_N_41_Removed(true); }
        if (state.get_F_C5_41_() == null) { cmd.setIsProperty_F_C5_41_Removed(true); }
        if (state.get_F_C10_41_() == null) { cmd.setIsProperty_F_C10_41_Removed(true); }
        if (state.get_F_C20_41_() == null) { cmd.setIsProperty_F_C20_41_Removed(true); }
        if (state.get_F_C50_41_() == null) { cmd.setIsProperty_F_C50_41_Removed(true); }
        if (state.get_F_B_42_() == null) { cmd.setIsProperty_F_B_42_Removed(true); }
        if (state.get_F_I_42_() == null) { cmd.setIsProperty_F_I_42_Removed(true); }
        if (state.get_F_N_42_() == null) { cmd.setIsProperty_F_N_42_Removed(true); }
        if (state.get_F_C5_42_() == null) { cmd.setIsProperty_F_C5_42_Removed(true); }
        if (state.get_F_C10_42_() == null) { cmd.setIsProperty_F_C10_42_Removed(true); }
        if (state.get_F_C20_42_() == null) { cmd.setIsProperty_F_C20_42_Removed(true); }
        if (state.get_F_C50_42_() == null) { cmd.setIsProperty_F_C50_42_Removed(true); }
        if (state.get_F_B_43_() == null) { cmd.setIsProperty_F_B_43_Removed(true); }
        if (state.get_F_I_43_() == null) { cmd.setIsProperty_F_I_43_Removed(true); }
        if (state.get_F_N_43_() == null) { cmd.setIsProperty_F_N_43_Removed(true); }
        if (state.get_F_C5_43_() == null) { cmd.setIsProperty_F_C5_43_Removed(true); }
        if (state.get_F_C10_43_() == null) { cmd.setIsProperty_F_C10_43_Removed(true); }
        if (state.get_F_C20_43_() == null) { cmd.setIsProperty_F_C20_43_Removed(true); }
        if (state.get_F_C50_43_() == null) { cmd.setIsProperty_F_C50_43_Removed(true); }
        if (state.get_F_B_44_() == null) { cmd.setIsProperty_F_B_44_Removed(true); }
        if (state.get_F_I_44_() == null) { cmd.setIsProperty_F_I_44_Removed(true); }
        if (state.get_F_N_44_() == null) { cmd.setIsProperty_F_N_44_Removed(true); }
        if (state.get_F_C5_44_() == null) { cmd.setIsProperty_F_C5_44_Removed(true); }
        if (state.get_F_C10_44_() == null) { cmd.setIsProperty_F_C10_44_Removed(true); }
        if (state.get_F_C20_44_() == null) { cmd.setIsProperty_F_C20_44_Removed(true); }
        if (state.get_F_C50_44_() == null) { cmd.setIsProperty_F_C50_44_Removed(true); }
        if (state.get_F_B_45_() == null) { cmd.setIsProperty_F_B_45_Removed(true); }
        if (state.get_F_I_45_() == null) { cmd.setIsProperty_F_I_45_Removed(true); }
        if (state.get_F_N_45_() == null) { cmd.setIsProperty_F_N_45_Removed(true); }
        if (state.get_F_C5_45_() == null) { cmd.setIsProperty_F_C5_45_Removed(true); }
        if (state.get_F_C10_45_() == null) { cmd.setIsProperty_F_C10_45_Removed(true); }
        if (state.get_F_C20_45_() == null) { cmd.setIsProperty_F_C20_45_Removed(true); }
        if (state.get_F_C50_45_() == null) { cmd.setIsProperty_F_C50_45_Removed(true); }
        if (state.get_F_B_46_() == null) { cmd.setIsProperty_F_B_46_Removed(true); }
        if (state.get_F_I_46_() == null) { cmd.setIsProperty_F_I_46_Removed(true); }
        if (state.get_F_N_46_() == null) { cmd.setIsProperty_F_N_46_Removed(true); }
        if (state.get_F_C5_46_() == null) { cmd.setIsProperty_F_C5_46_Removed(true); }
        if (state.get_F_C10_46_() == null) { cmd.setIsProperty_F_C10_46_Removed(true); }
        if (state.get_F_C20_46_() == null) { cmd.setIsProperty_F_C20_46_Removed(true); }
        if (state.get_F_C50_46_() == null) { cmd.setIsProperty_F_C50_46_Removed(true); }
        if (state.get_F_B_47_() == null) { cmd.setIsProperty_F_B_47_Removed(true); }
        if (state.get_F_I_47_() == null) { cmd.setIsProperty_F_I_47_Removed(true); }
        if (state.get_F_N_47_() == null) { cmd.setIsProperty_F_N_47_Removed(true); }
        if (state.get_F_C5_47_() == null) { cmd.setIsProperty_F_C5_47_Removed(true); }
        if (state.get_F_C10_47_() == null) { cmd.setIsProperty_F_C10_47_Removed(true); }
        if (state.get_F_C20_47_() == null) { cmd.setIsProperty_F_C20_47_Removed(true); }
        if (state.get_F_C50_47_() == null) { cmd.setIsProperty_F_C50_47_Removed(true); }
        if (state.get_F_B_48_() == null) { cmd.setIsProperty_F_B_48_Removed(true); }
        if (state.get_F_I_48_() == null) { cmd.setIsProperty_F_I_48_Removed(true); }
        if (state.get_F_N_48_() == null) { cmd.setIsProperty_F_N_48_Removed(true); }
        if (state.get_F_C5_48_() == null) { cmd.setIsProperty_F_C5_48_Removed(true); }
        if (state.get_F_C10_48_() == null) { cmd.setIsProperty_F_C10_48_Removed(true); }
        if (state.get_F_C20_48_() == null) { cmd.setIsProperty_F_C20_48_Removed(true); }
        if (state.get_F_C50_48_() == null) { cmd.setIsProperty_F_C50_48_Removed(true); }
        if (state.get_F_B_49_() == null) { cmd.setIsProperty_F_B_49_Removed(true); }
        if (state.get_F_I_49_() == null) { cmd.setIsProperty_F_I_49_Removed(true); }
        if (state.get_F_N_49_() == null) { cmd.setIsProperty_F_N_49_Removed(true); }
        if (state.get_F_C5_49_() == null) { cmd.setIsProperty_F_C5_49_Removed(true); }
        if (state.get_F_C10_49_() == null) { cmd.setIsProperty_F_C10_49_Removed(true); }
        if (state.get_F_C20_49_() == null) { cmd.setIsProperty_F_C20_49_Removed(true); }
        if (state.get_F_C50_49_() == null) { cmd.setIsProperty_F_C50_49_Removed(true); }
        if (state.getActive() == null) { cmd.setIsPropertyActiveRemoved(true); }
        return cmd;
    }

    public TCreateAttributeSetInstance toCreateAttributeSetInstance(AttributeSetInstanceState state) //where TCreateAttributeSetInstance : ICreateAttributeSetInstance, new()
    {
        TCreateAttributeSetInstance cmd = newCreateAttributeSetInstance();

        cmd.setVersion(state.getVersion());
        cmd.setAttributeSetInstanceId(state.getAttributeSetInstanceId());
        cmd.setAttributeSetId(state.getAttributeSetId());
        cmd.setOrganizationId(state.getOrganizationId());
        cmd.setReferenceId(state.getReferenceId());
        cmd.setSerialNumber(state.getSerialNumber());
        cmd.setLot(state.getLot());
        cmd.setDescription(state.getDescription());
        cmd.setHash(state.getHash());
        cmd.set_F_B_0_(state.get_F_B_0_());
        cmd.set_F_I_0_(state.get_F_I_0_());
        cmd.set_F_L_0_(state.get_F_L_0_());
        cmd.set_F_DT_0_(state.get_F_DT_0_());
        cmd.set_F_N_0_(state.get_F_N_0_());
        cmd.set_F_C5_0_(state.get_F_C5_0_());
        cmd.set_F_C10_0_(state.get_F_C10_0_());
        cmd.set_F_C20_0_(state.get_F_C20_0_());
        cmd.set_F_C50_0_(state.get_F_C50_0_());
        cmd.set_F_C100_0_(state.get_F_C100_0_());
        cmd.set_F_C200_0_(state.get_F_C200_0_());
        cmd.set_F_C500_0_(state.get_F_C500_0_());
        cmd.set_F_C1000_0_(state.get_F_C1000_0_());
        cmd.set_F_B_1_(state.get_F_B_1_());
        cmd.set_F_I_1_(state.get_F_I_1_());
        cmd.set_F_L_1_(state.get_F_L_1_());
        cmd.set_F_DT_1_(state.get_F_DT_1_());
        cmd.set_F_N_1_(state.get_F_N_1_());
        cmd.set_F_C5_1_(state.get_F_C5_1_());
        cmd.set_F_C10_1_(state.get_F_C10_1_());
        cmd.set_F_C20_1_(state.get_F_C20_1_());
        cmd.set_F_C50_1_(state.get_F_C50_1_());
        cmd.set_F_C100_1_(state.get_F_C100_1_());
        cmd.set_F_C200_1_(state.get_F_C200_1_());
        cmd.set_F_C500_1_(state.get_F_C500_1_());
        cmd.set_F_C1000_1_(state.get_F_C1000_1_());
        cmd.set_F_B_2_(state.get_F_B_2_());
        cmd.set_F_I_2_(state.get_F_I_2_());
        cmd.set_F_L_2_(state.get_F_L_2_());
        cmd.set_F_DT_2_(state.get_F_DT_2_());
        cmd.set_F_N_2_(state.get_F_N_2_());
        cmd.set_F_C5_2_(state.get_F_C5_2_());
        cmd.set_F_C10_2_(state.get_F_C10_2_());
        cmd.set_F_C20_2_(state.get_F_C20_2_());
        cmd.set_F_C50_2_(state.get_F_C50_2_());
        cmd.set_F_C100_2_(state.get_F_C100_2_());
        cmd.set_F_C200_2_(state.get_F_C200_2_());
        cmd.set_F_C500_2_(state.get_F_C500_2_());
        cmd.set_F_C1000_2_(state.get_F_C1000_2_());
        cmd.set_F_B_3_(state.get_F_B_3_());
        cmd.set_F_I_3_(state.get_F_I_3_());
        cmd.set_F_L_3_(state.get_F_L_3_());
        cmd.set_F_DT_3_(state.get_F_DT_3_());
        cmd.set_F_N_3_(state.get_F_N_3_());
        cmd.set_F_C5_3_(state.get_F_C5_3_());
        cmd.set_F_C10_3_(state.get_F_C10_3_());
        cmd.set_F_C20_3_(state.get_F_C20_3_());
        cmd.set_F_C50_3_(state.get_F_C50_3_());
        cmd.set_F_C100_3_(state.get_F_C100_3_());
        cmd.set_F_C200_3_(state.get_F_C200_3_());
        cmd.set_F_C500_3_(state.get_F_C500_3_());
        cmd.set_F_C1000_3_(state.get_F_C1000_3_());
        cmd.set_F_B_4_(state.get_F_B_4_());
        cmd.set_F_I_4_(state.get_F_I_4_());
        cmd.set_F_L_4_(state.get_F_L_4_());
        cmd.set_F_DT_4_(state.get_F_DT_4_());
        cmd.set_F_N_4_(state.get_F_N_4_());
        cmd.set_F_C5_4_(state.get_F_C5_4_());
        cmd.set_F_C10_4_(state.get_F_C10_4_());
        cmd.set_F_C20_4_(state.get_F_C20_4_());
        cmd.set_F_C50_4_(state.get_F_C50_4_());
        cmd.set_F_C100_4_(state.get_F_C100_4_());
        cmd.set_F_C200_4_(state.get_F_C200_4_());
        cmd.set_F_C500_4_(state.get_F_C500_4_());
        cmd.set_F_C1000_4_(state.get_F_C1000_4_());
        cmd.set_F_B_5_(state.get_F_B_5_());
        cmd.set_F_I_5_(state.get_F_I_5_());
        cmd.set_F_L_5_(state.get_F_L_5_());
        cmd.set_F_DT_5_(state.get_F_DT_5_());
        cmd.set_F_N_5_(state.get_F_N_5_());
        cmd.set_F_C5_5_(state.get_F_C5_5_());
        cmd.set_F_C10_5_(state.get_F_C10_5_());
        cmd.set_F_C20_5_(state.get_F_C20_5_());
        cmd.set_F_C50_5_(state.get_F_C50_5_());
        cmd.set_F_C100_5_(state.get_F_C100_5_());
        cmd.set_F_C200_5_(state.get_F_C200_5_());
        cmd.set_F_C500_5_(state.get_F_C500_5_());
        cmd.set_F_B_6_(state.get_F_B_6_());
        cmd.set_F_I_6_(state.get_F_I_6_());
        cmd.set_F_L_6_(state.get_F_L_6_());
        cmd.set_F_DT_6_(state.get_F_DT_6_());
        cmd.set_F_N_6_(state.get_F_N_6_());
        cmd.set_F_C5_6_(state.get_F_C5_6_());
        cmd.set_F_C10_6_(state.get_F_C10_6_());
        cmd.set_F_C20_6_(state.get_F_C20_6_());
        cmd.set_F_C50_6_(state.get_F_C50_6_());
        cmd.set_F_C100_6_(state.get_F_C100_6_());
        cmd.set_F_C200_6_(state.get_F_C200_6_());
        cmd.set_F_C500_6_(state.get_F_C500_6_());
        cmd.set_F_B_7_(state.get_F_B_7_());
        cmd.set_F_I_7_(state.get_F_I_7_());
        cmd.set_F_L_7_(state.get_F_L_7_());
        cmd.set_F_DT_7_(state.get_F_DT_7_());
        cmd.set_F_N_7_(state.get_F_N_7_());
        cmd.set_F_C5_7_(state.get_F_C5_7_());
        cmd.set_F_C10_7_(state.get_F_C10_7_());
        cmd.set_F_C20_7_(state.get_F_C20_7_());
        cmd.set_F_C50_7_(state.get_F_C50_7_());
        cmd.set_F_C100_7_(state.get_F_C100_7_());
        cmd.set_F_C200_7_(state.get_F_C200_7_());
        cmd.set_F_C500_7_(state.get_F_C500_7_());
        cmd.set_F_B_8_(state.get_F_B_8_());
        cmd.set_F_I_8_(state.get_F_I_8_());
        cmd.set_F_L_8_(state.get_F_L_8_());
        cmd.set_F_DT_8_(state.get_F_DT_8_());
        cmd.set_F_N_8_(state.get_F_N_8_());
        cmd.set_F_C5_8_(state.get_F_C5_8_());
        cmd.set_F_C10_8_(state.get_F_C10_8_());
        cmd.set_F_C20_8_(state.get_F_C20_8_());
        cmd.set_F_C50_8_(state.get_F_C50_8_());
        cmd.set_F_C100_8_(state.get_F_C100_8_());
        cmd.set_F_C200_8_(state.get_F_C200_8_());
        cmd.set_F_C500_8_(state.get_F_C500_8_());
        cmd.set_F_B_9_(state.get_F_B_9_());
        cmd.set_F_I_9_(state.get_F_I_9_());
        cmd.set_F_L_9_(state.get_F_L_9_());
        cmd.set_F_DT_9_(state.get_F_DT_9_());
        cmd.set_F_N_9_(state.get_F_N_9_());
        cmd.set_F_C5_9_(state.get_F_C5_9_());
        cmd.set_F_C10_9_(state.get_F_C10_9_());
        cmd.set_F_C20_9_(state.get_F_C20_9_());
        cmd.set_F_C50_9_(state.get_F_C50_9_());
        cmd.set_F_C100_9_(state.get_F_C100_9_());
        cmd.set_F_C200_9_(state.get_F_C200_9_());
        cmd.set_F_C500_9_(state.get_F_C500_9_());
        cmd.set_F_B_10_(state.get_F_B_10_());
        cmd.set_F_I_10_(state.get_F_I_10_());
        cmd.set_F_L_10_(state.get_F_L_10_());
        cmd.set_F_DT_10_(state.get_F_DT_10_());
        cmd.set_F_N_10_(state.get_F_N_10_());
        cmd.set_F_C5_10_(state.get_F_C5_10_());
        cmd.set_F_C10_10_(state.get_F_C10_10_());
        cmd.set_F_C20_10_(state.get_F_C20_10_());
        cmd.set_F_C50_10_(state.get_F_C50_10_());
        cmd.set_F_C100_10_(state.get_F_C100_10_());
        cmd.set_F_C200_10_(state.get_F_C200_10_());
        cmd.set_F_B_11_(state.get_F_B_11_());
        cmd.set_F_I_11_(state.get_F_I_11_());
        cmd.set_F_L_11_(state.get_F_L_11_());
        cmd.set_F_DT_11_(state.get_F_DT_11_());
        cmd.set_F_N_11_(state.get_F_N_11_());
        cmd.set_F_C5_11_(state.get_F_C5_11_());
        cmd.set_F_C10_11_(state.get_F_C10_11_());
        cmd.set_F_C20_11_(state.get_F_C20_11_());
        cmd.set_F_C50_11_(state.get_F_C50_11_());
        cmd.set_F_C100_11_(state.get_F_C100_11_());
        cmd.set_F_C200_11_(state.get_F_C200_11_());
        cmd.set_F_B_12_(state.get_F_B_12_());
        cmd.set_F_I_12_(state.get_F_I_12_());
        cmd.set_F_L_12_(state.get_F_L_12_());
        cmd.set_F_DT_12_(state.get_F_DT_12_());
        cmd.set_F_N_12_(state.get_F_N_12_());
        cmd.set_F_C5_12_(state.get_F_C5_12_());
        cmd.set_F_C10_12_(state.get_F_C10_12_());
        cmd.set_F_C20_12_(state.get_F_C20_12_());
        cmd.set_F_C50_12_(state.get_F_C50_12_());
        cmd.set_F_C100_12_(state.get_F_C100_12_());
        cmd.set_F_C200_12_(state.get_F_C200_12_());
        cmd.set_F_B_13_(state.get_F_B_13_());
        cmd.set_F_I_13_(state.get_F_I_13_());
        cmd.set_F_L_13_(state.get_F_L_13_());
        cmd.set_F_DT_13_(state.get_F_DT_13_());
        cmd.set_F_N_13_(state.get_F_N_13_());
        cmd.set_F_C5_13_(state.get_F_C5_13_());
        cmd.set_F_C10_13_(state.get_F_C10_13_());
        cmd.set_F_C20_13_(state.get_F_C20_13_());
        cmd.set_F_C50_13_(state.get_F_C50_13_());
        cmd.set_F_C100_13_(state.get_F_C100_13_());
        cmd.set_F_C200_13_(state.get_F_C200_13_());
        cmd.set_F_B_14_(state.get_F_B_14_());
        cmd.set_F_I_14_(state.get_F_I_14_());
        cmd.set_F_L_14_(state.get_F_L_14_());
        cmd.set_F_DT_14_(state.get_F_DT_14_());
        cmd.set_F_N_14_(state.get_F_N_14_());
        cmd.set_F_C5_14_(state.get_F_C5_14_());
        cmd.set_F_C10_14_(state.get_F_C10_14_());
        cmd.set_F_C20_14_(state.get_F_C20_14_());
        cmd.set_F_C50_14_(state.get_F_C50_14_());
        cmd.set_F_C100_14_(state.get_F_C100_14_());
        cmd.set_F_C200_14_(state.get_F_C200_14_());
        cmd.set_F_B_15_(state.get_F_B_15_());
        cmd.set_F_I_15_(state.get_F_I_15_());
        cmd.set_F_L_15_(state.get_F_L_15_());
        cmd.set_F_DT_15_(state.get_F_DT_15_());
        cmd.set_F_N_15_(state.get_F_N_15_());
        cmd.set_F_C5_15_(state.get_F_C5_15_());
        cmd.set_F_C10_15_(state.get_F_C10_15_());
        cmd.set_F_C20_15_(state.get_F_C20_15_());
        cmd.set_F_C50_15_(state.get_F_C50_15_());
        cmd.set_F_C100_15_(state.get_F_C100_15_());
        cmd.set_F_C200_15_(state.get_F_C200_15_());
        cmd.set_F_B_16_(state.get_F_B_16_());
        cmd.set_F_I_16_(state.get_F_I_16_());
        cmd.set_F_L_16_(state.get_F_L_16_());
        cmd.set_F_DT_16_(state.get_F_DT_16_());
        cmd.set_F_N_16_(state.get_F_N_16_());
        cmd.set_F_C5_16_(state.get_F_C5_16_());
        cmd.set_F_C10_16_(state.get_F_C10_16_());
        cmd.set_F_C20_16_(state.get_F_C20_16_());
        cmd.set_F_C50_16_(state.get_F_C50_16_());
        cmd.set_F_C100_16_(state.get_F_C100_16_());
        cmd.set_F_C200_16_(state.get_F_C200_16_());
        cmd.set_F_B_17_(state.get_F_B_17_());
        cmd.set_F_I_17_(state.get_F_I_17_());
        cmd.set_F_L_17_(state.get_F_L_17_());
        cmd.set_F_DT_17_(state.get_F_DT_17_());
        cmd.set_F_N_17_(state.get_F_N_17_());
        cmd.set_F_C5_17_(state.get_F_C5_17_());
        cmd.set_F_C10_17_(state.get_F_C10_17_());
        cmd.set_F_C20_17_(state.get_F_C20_17_());
        cmd.set_F_C50_17_(state.get_F_C50_17_());
        cmd.set_F_C100_17_(state.get_F_C100_17_());
        cmd.set_F_C200_17_(state.get_F_C200_17_());
        cmd.set_F_B_18_(state.get_F_B_18_());
        cmd.set_F_I_18_(state.get_F_I_18_());
        cmd.set_F_L_18_(state.get_F_L_18_());
        cmd.set_F_DT_18_(state.get_F_DT_18_());
        cmd.set_F_N_18_(state.get_F_N_18_());
        cmd.set_F_C5_18_(state.get_F_C5_18_());
        cmd.set_F_C10_18_(state.get_F_C10_18_());
        cmd.set_F_C20_18_(state.get_F_C20_18_());
        cmd.set_F_C50_18_(state.get_F_C50_18_());
        cmd.set_F_C100_18_(state.get_F_C100_18_());
        cmd.set_F_C200_18_(state.get_F_C200_18_());
        cmd.set_F_B_19_(state.get_F_B_19_());
        cmd.set_F_I_19_(state.get_F_I_19_());
        cmd.set_F_L_19_(state.get_F_L_19_());
        cmd.set_F_DT_19_(state.get_F_DT_19_());
        cmd.set_F_N_19_(state.get_F_N_19_());
        cmd.set_F_C5_19_(state.get_F_C5_19_());
        cmd.set_F_C10_19_(state.get_F_C10_19_());
        cmd.set_F_C20_19_(state.get_F_C20_19_());
        cmd.set_F_C50_19_(state.get_F_C50_19_());
        cmd.set_F_C100_19_(state.get_F_C100_19_());
        cmd.set_F_C200_19_(state.get_F_C200_19_());
        cmd.set_F_B_20_(state.get_F_B_20_());
        cmd.set_F_I_20_(state.get_F_I_20_());
        cmd.set_F_L_20_(state.get_F_L_20_());
        cmd.set_F_N_20_(state.get_F_N_20_());
        cmd.set_F_C5_20_(state.get_F_C5_20_());
        cmd.set_F_C10_20_(state.get_F_C10_20_());
        cmd.set_F_C20_20_(state.get_F_C20_20_());
        cmd.set_F_C50_20_(state.get_F_C50_20_());
        cmd.set_F_B_21_(state.get_F_B_21_());
        cmd.set_F_I_21_(state.get_F_I_21_());
        cmd.set_F_L_21_(state.get_F_L_21_());
        cmd.set_F_N_21_(state.get_F_N_21_());
        cmd.set_F_C5_21_(state.get_F_C5_21_());
        cmd.set_F_C10_21_(state.get_F_C10_21_());
        cmd.set_F_C20_21_(state.get_F_C20_21_());
        cmd.set_F_C50_21_(state.get_F_C50_21_());
        cmd.set_F_B_22_(state.get_F_B_22_());
        cmd.set_F_I_22_(state.get_F_I_22_());
        cmd.set_F_L_22_(state.get_F_L_22_());
        cmd.set_F_N_22_(state.get_F_N_22_());
        cmd.set_F_C5_22_(state.get_F_C5_22_());
        cmd.set_F_C10_22_(state.get_F_C10_22_());
        cmd.set_F_C20_22_(state.get_F_C20_22_());
        cmd.set_F_C50_22_(state.get_F_C50_22_());
        cmd.set_F_B_23_(state.get_F_B_23_());
        cmd.set_F_I_23_(state.get_F_I_23_());
        cmd.set_F_L_23_(state.get_F_L_23_());
        cmd.set_F_N_23_(state.get_F_N_23_());
        cmd.set_F_C5_23_(state.get_F_C5_23_());
        cmd.set_F_C10_23_(state.get_F_C10_23_());
        cmd.set_F_C20_23_(state.get_F_C20_23_());
        cmd.set_F_C50_23_(state.get_F_C50_23_());
        cmd.set_F_B_24_(state.get_F_B_24_());
        cmd.set_F_I_24_(state.get_F_I_24_());
        cmd.set_F_L_24_(state.get_F_L_24_());
        cmd.set_F_N_24_(state.get_F_N_24_());
        cmd.set_F_C5_24_(state.get_F_C5_24_());
        cmd.set_F_C10_24_(state.get_F_C10_24_());
        cmd.set_F_C20_24_(state.get_F_C20_24_());
        cmd.set_F_C50_24_(state.get_F_C50_24_());
        cmd.set_F_B_25_(state.get_F_B_25_());
        cmd.set_F_I_25_(state.get_F_I_25_());
        cmd.set_F_L_25_(state.get_F_L_25_());
        cmd.set_F_N_25_(state.get_F_N_25_());
        cmd.set_F_C5_25_(state.get_F_C5_25_());
        cmd.set_F_C10_25_(state.get_F_C10_25_());
        cmd.set_F_C20_25_(state.get_F_C20_25_());
        cmd.set_F_C50_25_(state.get_F_C50_25_());
        cmd.set_F_B_26_(state.get_F_B_26_());
        cmd.set_F_I_26_(state.get_F_I_26_());
        cmd.set_F_L_26_(state.get_F_L_26_());
        cmd.set_F_N_26_(state.get_F_N_26_());
        cmd.set_F_C5_26_(state.get_F_C5_26_());
        cmd.set_F_C10_26_(state.get_F_C10_26_());
        cmd.set_F_C20_26_(state.get_F_C20_26_());
        cmd.set_F_C50_26_(state.get_F_C50_26_());
        cmd.set_F_B_27_(state.get_F_B_27_());
        cmd.set_F_I_27_(state.get_F_I_27_());
        cmd.set_F_L_27_(state.get_F_L_27_());
        cmd.set_F_N_27_(state.get_F_N_27_());
        cmd.set_F_C5_27_(state.get_F_C5_27_());
        cmd.set_F_C10_27_(state.get_F_C10_27_());
        cmd.set_F_C20_27_(state.get_F_C20_27_());
        cmd.set_F_C50_27_(state.get_F_C50_27_());
        cmd.set_F_B_28_(state.get_F_B_28_());
        cmd.set_F_I_28_(state.get_F_I_28_());
        cmd.set_F_L_28_(state.get_F_L_28_());
        cmd.set_F_N_28_(state.get_F_N_28_());
        cmd.set_F_C5_28_(state.get_F_C5_28_());
        cmd.set_F_C10_28_(state.get_F_C10_28_());
        cmd.set_F_C20_28_(state.get_F_C20_28_());
        cmd.set_F_C50_28_(state.get_F_C50_28_());
        cmd.set_F_B_29_(state.get_F_B_29_());
        cmd.set_F_I_29_(state.get_F_I_29_());
        cmd.set_F_L_29_(state.get_F_L_29_());
        cmd.set_F_N_29_(state.get_F_N_29_());
        cmd.set_F_C5_29_(state.get_F_C5_29_());
        cmd.set_F_C10_29_(state.get_F_C10_29_());
        cmd.set_F_C20_29_(state.get_F_C20_29_());
        cmd.set_F_C50_29_(state.get_F_C50_29_());
        cmd.set_F_B_30_(state.get_F_B_30_());
        cmd.set_F_I_30_(state.get_F_I_30_());
        cmd.set_F_N_30_(state.get_F_N_30_());
        cmd.set_F_C5_30_(state.get_F_C5_30_());
        cmd.set_F_C10_30_(state.get_F_C10_30_());
        cmd.set_F_C20_30_(state.get_F_C20_30_());
        cmd.set_F_C50_30_(state.get_F_C50_30_());
        cmd.set_F_B_31_(state.get_F_B_31_());
        cmd.set_F_I_31_(state.get_F_I_31_());
        cmd.set_F_N_31_(state.get_F_N_31_());
        cmd.set_F_C5_31_(state.get_F_C5_31_());
        cmd.set_F_C10_31_(state.get_F_C10_31_());
        cmd.set_F_C20_31_(state.get_F_C20_31_());
        cmd.set_F_C50_31_(state.get_F_C50_31_());
        cmd.set_F_B_32_(state.get_F_B_32_());
        cmd.set_F_I_32_(state.get_F_I_32_());
        cmd.set_F_N_32_(state.get_F_N_32_());
        cmd.set_F_C5_32_(state.get_F_C5_32_());
        cmd.set_F_C10_32_(state.get_F_C10_32_());
        cmd.set_F_C20_32_(state.get_F_C20_32_());
        cmd.set_F_C50_32_(state.get_F_C50_32_());
        cmd.set_F_B_33_(state.get_F_B_33_());
        cmd.set_F_I_33_(state.get_F_I_33_());
        cmd.set_F_N_33_(state.get_F_N_33_());
        cmd.set_F_C5_33_(state.get_F_C5_33_());
        cmd.set_F_C10_33_(state.get_F_C10_33_());
        cmd.set_F_C20_33_(state.get_F_C20_33_());
        cmd.set_F_C50_33_(state.get_F_C50_33_());
        cmd.set_F_B_34_(state.get_F_B_34_());
        cmd.set_F_I_34_(state.get_F_I_34_());
        cmd.set_F_N_34_(state.get_F_N_34_());
        cmd.set_F_C5_34_(state.get_F_C5_34_());
        cmd.set_F_C10_34_(state.get_F_C10_34_());
        cmd.set_F_C20_34_(state.get_F_C20_34_());
        cmd.set_F_C50_34_(state.get_F_C50_34_());
        cmd.set_F_B_35_(state.get_F_B_35_());
        cmd.set_F_I_35_(state.get_F_I_35_());
        cmd.set_F_N_35_(state.get_F_N_35_());
        cmd.set_F_C5_35_(state.get_F_C5_35_());
        cmd.set_F_C10_35_(state.get_F_C10_35_());
        cmd.set_F_C20_35_(state.get_F_C20_35_());
        cmd.set_F_C50_35_(state.get_F_C50_35_());
        cmd.set_F_B_36_(state.get_F_B_36_());
        cmd.set_F_I_36_(state.get_F_I_36_());
        cmd.set_F_N_36_(state.get_F_N_36_());
        cmd.set_F_C5_36_(state.get_F_C5_36_());
        cmd.set_F_C10_36_(state.get_F_C10_36_());
        cmd.set_F_C20_36_(state.get_F_C20_36_());
        cmd.set_F_C50_36_(state.get_F_C50_36_());
        cmd.set_F_B_37_(state.get_F_B_37_());
        cmd.set_F_I_37_(state.get_F_I_37_());
        cmd.set_F_N_37_(state.get_F_N_37_());
        cmd.set_F_C5_37_(state.get_F_C5_37_());
        cmd.set_F_C10_37_(state.get_F_C10_37_());
        cmd.set_F_C20_37_(state.get_F_C20_37_());
        cmd.set_F_C50_37_(state.get_F_C50_37_());
        cmd.set_F_B_38_(state.get_F_B_38_());
        cmd.set_F_I_38_(state.get_F_I_38_());
        cmd.set_F_N_38_(state.get_F_N_38_());
        cmd.set_F_C5_38_(state.get_F_C5_38_());
        cmd.set_F_C10_38_(state.get_F_C10_38_());
        cmd.set_F_C20_38_(state.get_F_C20_38_());
        cmd.set_F_C50_38_(state.get_F_C50_38_());
        cmd.set_F_B_39_(state.get_F_B_39_());
        cmd.set_F_I_39_(state.get_F_I_39_());
        cmd.set_F_N_39_(state.get_F_N_39_());
        cmd.set_F_C5_39_(state.get_F_C5_39_());
        cmd.set_F_C10_39_(state.get_F_C10_39_());
        cmd.set_F_C20_39_(state.get_F_C20_39_());
        cmd.set_F_C50_39_(state.get_F_C50_39_());
        cmd.set_F_B_40_(state.get_F_B_40_());
        cmd.set_F_I_40_(state.get_F_I_40_());
        cmd.set_F_N_40_(state.get_F_N_40_());
        cmd.set_F_C5_40_(state.get_F_C5_40_());
        cmd.set_F_C10_40_(state.get_F_C10_40_());
        cmd.set_F_C20_40_(state.get_F_C20_40_());
        cmd.set_F_C50_40_(state.get_F_C50_40_());
        cmd.set_F_B_41_(state.get_F_B_41_());
        cmd.set_F_I_41_(state.get_F_I_41_());
        cmd.set_F_N_41_(state.get_F_N_41_());
        cmd.set_F_C5_41_(state.get_F_C5_41_());
        cmd.set_F_C10_41_(state.get_F_C10_41_());
        cmd.set_F_C20_41_(state.get_F_C20_41_());
        cmd.set_F_C50_41_(state.get_F_C50_41_());
        cmd.set_F_B_42_(state.get_F_B_42_());
        cmd.set_F_I_42_(state.get_F_I_42_());
        cmd.set_F_N_42_(state.get_F_N_42_());
        cmd.set_F_C5_42_(state.get_F_C5_42_());
        cmd.set_F_C10_42_(state.get_F_C10_42_());
        cmd.set_F_C20_42_(state.get_F_C20_42_());
        cmd.set_F_C50_42_(state.get_F_C50_42_());
        cmd.set_F_B_43_(state.get_F_B_43_());
        cmd.set_F_I_43_(state.get_F_I_43_());
        cmd.set_F_N_43_(state.get_F_N_43_());
        cmd.set_F_C5_43_(state.get_F_C5_43_());
        cmd.set_F_C10_43_(state.get_F_C10_43_());
        cmd.set_F_C20_43_(state.get_F_C20_43_());
        cmd.set_F_C50_43_(state.get_F_C50_43_());
        cmd.set_F_B_44_(state.get_F_B_44_());
        cmd.set_F_I_44_(state.get_F_I_44_());
        cmd.set_F_N_44_(state.get_F_N_44_());
        cmd.set_F_C5_44_(state.get_F_C5_44_());
        cmd.set_F_C10_44_(state.get_F_C10_44_());
        cmd.set_F_C20_44_(state.get_F_C20_44_());
        cmd.set_F_C50_44_(state.get_F_C50_44_());
        cmd.set_F_B_45_(state.get_F_B_45_());
        cmd.set_F_I_45_(state.get_F_I_45_());
        cmd.set_F_N_45_(state.get_F_N_45_());
        cmd.set_F_C5_45_(state.get_F_C5_45_());
        cmd.set_F_C10_45_(state.get_F_C10_45_());
        cmd.set_F_C20_45_(state.get_F_C20_45_());
        cmd.set_F_C50_45_(state.get_F_C50_45_());
        cmd.set_F_B_46_(state.get_F_B_46_());
        cmd.set_F_I_46_(state.get_F_I_46_());
        cmd.set_F_N_46_(state.get_F_N_46_());
        cmd.set_F_C5_46_(state.get_F_C5_46_());
        cmd.set_F_C10_46_(state.get_F_C10_46_());
        cmd.set_F_C20_46_(state.get_F_C20_46_());
        cmd.set_F_C50_46_(state.get_F_C50_46_());
        cmd.set_F_B_47_(state.get_F_B_47_());
        cmd.set_F_I_47_(state.get_F_I_47_());
        cmd.set_F_N_47_(state.get_F_N_47_());
        cmd.set_F_C5_47_(state.get_F_C5_47_());
        cmd.set_F_C10_47_(state.get_F_C10_47_());
        cmd.set_F_C20_47_(state.get_F_C20_47_());
        cmd.set_F_C50_47_(state.get_F_C50_47_());
        cmd.set_F_B_48_(state.get_F_B_48_());
        cmd.set_F_I_48_(state.get_F_I_48_());
        cmd.set_F_N_48_(state.get_F_N_48_());
        cmd.set_F_C5_48_(state.get_F_C5_48_());
        cmd.set_F_C10_48_(state.get_F_C10_48_());
        cmd.set_F_C20_48_(state.get_F_C20_48_());
        cmd.set_F_C50_48_(state.get_F_C50_48_());
        cmd.set_F_B_49_(state.get_F_B_49_());
        cmd.set_F_I_49_(state.get_F_I_49_());
        cmd.set_F_N_49_(state.get_F_N_49_());
        cmd.set_F_C5_49_(state.get_F_C5_49_());
        cmd.set_F_C10_49_(state.get_F_C10_49_());
        cmd.set_F_C20_49_(state.get_F_C20_49_());
        cmd.set_F_C50_49_(state.get_F_C50_49_());
        cmd.setActive(state.getActive());
        return cmd;
    }

    protected abstract TCreateAttributeSetInstance newCreateAttributeSetInstance();

    protected abstract TMergePatchAttributeSetInstance newMergePatchAttributeSetInstance(); 

    protected abstract TDeleteAttributeSetInstance newDeleteAttributeSetInstance();

    public static class SimpleAttributeSetInstanceStateCommandConverter extends AbstractAttributeSetInstanceStateCommandConverter<AbstractAttributeSetInstanceCommand.SimpleCreateAttributeSetInstance, AbstractAttributeSetInstanceCommand.SimpleMergePatchAttributeSetInstance, AbstractAttributeSetInstanceCommand.SimpleDeleteAttributeSetInstance>
    {
        @Override
        protected AbstractAttributeSetInstanceCommand.SimpleCreateAttributeSetInstance newCreateAttributeSetInstance() {
            return new AbstractAttributeSetInstanceCommand.SimpleCreateAttributeSetInstance();
        }

        @Override
        protected AbstractAttributeSetInstanceCommand.SimpleMergePatchAttributeSetInstance newMergePatchAttributeSetInstance() {
            return new AbstractAttributeSetInstanceCommand.SimpleMergePatchAttributeSetInstance();
        }

        @Override
        protected AbstractAttributeSetInstanceCommand.SimpleDeleteAttributeSetInstance newDeleteAttributeSetInstance() {
            return new AbstractAttributeSetInstanceCommand.SimpleDeleteAttributeSetInstance();
        }


    }

}

