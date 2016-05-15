﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Domain;

using Dddml.Wms.Specialization;

namespace Dddml.Wms.Domain
{

	public abstract class AttributeSetInstanceCommandBase : AttributeSetInstanceStateProperties, IAttributeSetInstanceCommand
	{

		string IAggregateCommand<string, long>.AggregateId
		{
			get
			{
				return this.AttributeSetInstanceId;
			}
		}


		long IAggregateCommand<string, long>.AggregateVersion
		{
			get
			{
				return this.Version;
			}
		}

		public virtual long Version { get; set; }

		public virtual string RequesterId { get; set; }//TODO RequesterId 应该是可以支持自定义名称

		public virtual string CommandId { get; set; }//TODO CommandId 太特殊了！！！应该可以支持自定义名称（即不一定要叫 CommandId）

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

	}

	public class CreateAttributeSetInstance : AttributeSetInstanceCommandBase, ICreateAttributeSetInstance
	{
		
		public CreateAttributeSetInstance ()
		{
		}


	}


	public class MergePatchAttributeSetInstance :AttributeSetInstanceCommandBase, IMergePatchAttributeSetInstance
	{

		public virtual bool IsPropertyAttributeSetIdRemoved { get; set; }

		public virtual bool IsPropertyReferenceIdRemoved { get; set; }

		public virtual bool IsPropertySerialNumberRemoved { get; set; }

		public virtual bool IsPropertyLotRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyHashRemoved { get; set; }

		public virtual bool IsProperty_F_B_0_Removed { get; set; }

		public virtual bool IsProperty_F_I_0_Removed { get; set; }

		public virtual bool IsProperty_F_L_0_Removed { get; set; }

		public virtual bool IsProperty_F_DT_0_Removed { get; set; }

		public virtual bool IsProperty_F_N_0_Removed { get; set; }

		public virtual bool IsProperty_F_C5_0_Removed { get; set; }

		public virtual bool IsProperty_F_C10_0_Removed { get; set; }

		public virtual bool IsProperty_F_C20_0_Removed { get; set; }

		public virtual bool IsProperty_F_C50_0_Removed { get; set; }

		public virtual bool IsProperty_F_C100_0_Removed { get; set; }

		public virtual bool IsProperty_F_C200_0_Removed { get; set; }

		public virtual bool IsProperty_F_C500_0_Removed { get; set; }

		public virtual bool IsProperty_F_C1000_0_Removed { get; set; }

		public virtual bool IsProperty_F_B_1_Removed { get; set; }

		public virtual bool IsProperty_F_I_1_Removed { get; set; }

		public virtual bool IsProperty_F_L_1_Removed { get; set; }

		public virtual bool IsProperty_F_DT_1_Removed { get; set; }

		public virtual bool IsProperty_F_N_1_Removed { get; set; }

		public virtual bool IsProperty_F_C5_1_Removed { get; set; }

		public virtual bool IsProperty_F_C10_1_Removed { get; set; }

		public virtual bool IsProperty_F_C20_1_Removed { get; set; }

		public virtual bool IsProperty_F_C50_1_Removed { get; set; }

		public virtual bool IsProperty_F_C100_1_Removed { get; set; }

		public virtual bool IsProperty_F_C200_1_Removed { get; set; }

		public virtual bool IsProperty_F_C500_1_Removed { get; set; }

		public virtual bool IsProperty_F_C1000_1_Removed { get; set; }

		public virtual bool IsProperty_F_B_2_Removed { get; set; }

		public virtual bool IsProperty_F_I_2_Removed { get; set; }

		public virtual bool IsProperty_F_L_2_Removed { get; set; }

		public virtual bool IsProperty_F_DT_2_Removed { get; set; }

		public virtual bool IsProperty_F_N_2_Removed { get; set; }

		public virtual bool IsProperty_F_C5_2_Removed { get; set; }

		public virtual bool IsProperty_F_C10_2_Removed { get; set; }

		public virtual bool IsProperty_F_C20_2_Removed { get; set; }

		public virtual bool IsProperty_F_C50_2_Removed { get; set; }

		public virtual bool IsProperty_F_C100_2_Removed { get; set; }

		public virtual bool IsProperty_F_C200_2_Removed { get; set; }

		public virtual bool IsProperty_F_C500_2_Removed { get; set; }

		public virtual bool IsProperty_F_C1000_2_Removed { get; set; }

		public virtual bool IsProperty_F_B_3_Removed { get; set; }

		public virtual bool IsProperty_F_I_3_Removed { get; set; }

		public virtual bool IsProperty_F_L_3_Removed { get; set; }

		public virtual bool IsProperty_F_DT_3_Removed { get; set; }

		public virtual bool IsProperty_F_N_3_Removed { get; set; }

		public virtual bool IsProperty_F_C5_3_Removed { get; set; }

		public virtual bool IsProperty_F_C10_3_Removed { get; set; }

		public virtual bool IsProperty_F_C20_3_Removed { get; set; }

		public virtual bool IsProperty_F_C50_3_Removed { get; set; }

		public virtual bool IsProperty_F_C100_3_Removed { get; set; }

		public virtual bool IsProperty_F_C200_3_Removed { get; set; }

		public virtual bool IsProperty_F_C500_3_Removed { get; set; }

		public virtual bool IsProperty_F_C1000_3_Removed { get; set; }

		public virtual bool IsProperty_F_B_4_Removed { get; set; }

		public virtual bool IsProperty_F_I_4_Removed { get; set; }

		public virtual bool IsProperty_F_L_4_Removed { get; set; }

		public virtual bool IsProperty_F_DT_4_Removed { get; set; }

		public virtual bool IsProperty_F_N_4_Removed { get; set; }

		public virtual bool IsProperty_F_C5_4_Removed { get; set; }

		public virtual bool IsProperty_F_C10_4_Removed { get; set; }

		public virtual bool IsProperty_F_C20_4_Removed { get; set; }

		public virtual bool IsProperty_F_C50_4_Removed { get; set; }

		public virtual bool IsProperty_F_C100_4_Removed { get; set; }

		public virtual bool IsProperty_F_C200_4_Removed { get; set; }

		public virtual bool IsProperty_F_C500_4_Removed { get; set; }

		public virtual bool IsProperty_F_C1000_4_Removed { get; set; }

		public virtual bool IsProperty_F_B_5_Removed { get; set; }

		public virtual bool IsProperty_F_I_5_Removed { get; set; }

		public virtual bool IsProperty_F_L_5_Removed { get; set; }

		public virtual bool IsProperty_F_DT_5_Removed { get; set; }

		public virtual bool IsProperty_F_N_5_Removed { get; set; }

		public virtual bool IsProperty_F_C5_5_Removed { get; set; }

		public virtual bool IsProperty_F_C10_5_Removed { get; set; }

		public virtual bool IsProperty_F_C20_5_Removed { get; set; }

		public virtual bool IsProperty_F_C50_5_Removed { get; set; }

		public virtual bool IsProperty_F_C100_5_Removed { get; set; }

		public virtual bool IsProperty_F_C200_5_Removed { get; set; }

		public virtual bool IsProperty_F_C500_5_Removed { get; set; }

		public virtual bool IsProperty_F_B_6_Removed { get; set; }

		public virtual bool IsProperty_F_I_6_Removed { get; set; }

		public virtual bool IsProperty_F_L_6_Removed { get; set; }

		public virtual bool IsProperty_F_DT_6_Removed { get; set; }

		public virtual bool IsProperty_F_N_6_Removed { get; set; }

		public virtual bool IsProperty_F_C5_6_Removed { get; set; }

		public virtual bool IsProperty_F_C10_6_Removed { get; set; }

		public virtual bool IsProperty_F_C20_6_Removed { get; set; }

		public virtual bool IsProperty_F_C50_6_Removed { get; set; }

		public virtual bool IsProperty_F_C100_6_Removed { get; set; }

		public virtual bool IsProperty_F_C200_6_Removed { get; set; }

		public virtual bool IsProperty_F_C500_6_Removed { get; set; }

		public virtual bool IsProperty_F_B_7_Removed { get; set; }

		public virtual bool IsProperty_F_I_7_Removed { get; set; }

		public virtual bool IsProperty_F_L_7_Removed { get; set; }

		public virtual bool IsProperty_F_DT_7_Removed { get; set; }

		public virtual bool IsProperty_F_N_7_Removed { get; set; }

		public virtual bool IsProperty_F_C5_7_Removed { get; set; }

		public virtual bool IsProperty_F_C10_7_Removed { get; set; }

		public virtual bool IsProperty_F_C20_7_Removed { get; set; }

		public virtual bool IsProperty_F_C50_7_Removed { get; set; }

		public virtual bool IsProperty_F_C100_7_Removed { get; set; }

		public virtual bool IsProperty_F_C200_7_Removed { get; set; }

		public virtual bool IsProperty_F_C500_7_Removed { get; set; }

		public virtual bool IsProperty_F_B_8_Removed { get; set; }

		public virtual bool IsProperty_F_I_8_Removed { get; set; }

		public virtual bool IsProperty_F_L_8_Removed { get; set; }

		public virtual bool IsProperty_F_DT_8_Removed { get; set; }

		public virtual bool IsProperty_F_N_8_Removed { get; set; }

		public virtual bool IsProperty_F_C5_8_Removed { get; set; }

		public virtual bool IsProperty_F_C10_8_Removed { get; set; }

		public virtual bool IsProperty_F_C20_8_Removed { get; set; }

		public virtual bool IsProperty_F_C50_8_Removed { get; set; }

		public virtual bool IsProperty_F_C100_8_Removed { get; set; }

		public virtual bool IsProperty_F_C200_8_Removed { get; set; }

		public virtual bool IsProperty_F_C500_8_Removed { get; set; }

		public virtual bool IsProperty_F_B_9_Removed { get; set; }

		public virtual bool IsProperty_F_I_9_Removed { get; set; }

		public virtual bool IsProperty_F_L_9_Removed { get; set; }

		public virtual bool IsProperty_F_DT_9_Removed { get; set; }

		public virtual bool IsProperty_F_N_9_Removed { get; set; }

		public virtual bool IsProperty_F_C5_9_Removed { get; set; }

		public virtual bool IsProperty_F_C10_9_Removed { get; set; }

		public virtual bool IsProperty_F_C20_9_Removed { get; set; }

		public virtual bool IsProperty_F_C50_9_Removed { get; set; }

		public virtual bool IsProperty_F_C100_9_Removed { get; set; }

		public virtual bool IsProperty_F_C200_9_Removed { get; set; }

		public virtual bool IsProperty_F_C500_9_Removed { get; set; }

		public virtual bool IsProperty_F_B_10_Removed { get; set; }

		public virtual bool IsProperty_F_I_10_Removed { get; set; }

		public virtual bool IsProperty_F_L_10_Removed { get; set; }

		public virtual bool IsProperty_F_DT_10_Removed { get; set; }

		public virtual bool IsProperty_F_N_10_Removed { get; set; }

		public virtual bool IsProperty_F_C5_10_Removed { get; set; }

		public virtual bool IsProperty_F_C10_10_Removed { get; set; }

		public virtual bool IsProperty_F_C20_10_Removed { get; set; }

		public virtual bool IsProperty_F_C50_10_Removed { get; set; }

		public virtual bool IsProperty_F_C100_10_Removed { get; set; }

		public virtual bool IsProperty_F_C200_10_Removed { get; set; }

		public virtual bool IsProperty_F_B_11_Removed { get; set; }

		public virtual bool IsProperty_F_I_11_Removed { get; set; }

		public virtual bool IsProperty_F_L_11_Removed { get; set; }

		public virtual bool IsProperty_F_DT_11_Removed { get; set; }

		public virtual bool IsProperty_F_N_11_Removed { get; set; }

		public virtual bool IsProperty_F_C5_11_Removed { get; set; }

		public virtual bool IsProperty_F_C10_11_Removed { get; set; }

		public virtual bool IsProperty_F_C20_11_Removed { get; set; }

		public virtual bool IsProperty_F_C50_11_Removed { get; set; }

		public virtual bool IsProperty_F_C100_11_Removed { get; set; }

		public virtual bool IsProperty_F_C200_11_Removed { get; set; }

		public virtual bool IsProperty_F_B_12_Removed { get; set; }

		public virtual bool IsProperty_F_I_12_Removed { get; set; }

		public virtual bool IsProperty_F_L_12_Removed { get; set; }

		public virtual bool IsProperty_F_DT_12_Removed { get; set; }

		public virtual bool IsProperty_F_N_12_Removed { get; set; }

		public virtual bool IsProperty_F_C5_12_Removed { get; set; }

		public virtual bool IsProperty_F_C10_12_Removed { get; set; }

		public virtual bool IsProperty_F_C20_12_Removed { get; set; }

		public virtual bool IsProperty_F_C50_12_Removed { get; set; }

		public virtual bool IsProperty_F_C100_12_Removed { get; set; }

		public virtual bool IsProperty_F_C200_12_Removed { get; set; }

		public virtual bool IsProperty_F_B_13_Removed { get; set; }

		public virtual bool IsProperty_F_I_13_Removed { get; set; }

		public virtual bool IsProperty_F_L_13_Removed { get; set; }

		public virtual bool IsProperty_F_DT_13_Removed { get; set; }

		public virtual bool IsProperty_F_N_13_Removed { get; set; }

		public virtual bool IsProperty_F_C5_13_Removed { get; set; }

		public virtual bool IsProperty_F_C10_13_Removed { get; set; }

		public virtual bool IsProperty_F_C20_13_Removed { get; set; }

		public virtual bool IsProperty_F_C50_13_Removed { get; set; }

		public virtual bool IsProperty_F_C100_13_Removed { get; set; }

		public virtual bool IsProperty_F_C200_13_Removed { get; set; }

		public virtual bool IsProperty_F_B_14_Removed { get; set; }

		public virtual bool IsProperty_F_I_14_Removed { get; set; }

		public virtual bool IsProperty_F_L_14_Removed { get; set; }

		public virtual bool IsProperty_F_DT_14_Removed { get; set; }

		public virtual bool IsProperty_F_N_14_Removed { get; set; }

		public virtual bool IsProperty_F_C5_14_Removed { get; set; }

		public virtual bool IsProperty_F_C10_14_Removed { get; set; }

		public virtual bool IsProperty_F_C20_14_Removed { get; set; }

		public virtual bool IsProperty_F_C50_14_Removed { get; set; }

		public virtual bool IsProperty_F_C100_14_Removed { get; set; }

		public virtual bool IsProperty_F_C200_14_Removed { get; set; }

		public virtual bool IsProperty_F_B_15_Removed { get; set; }

		public virtual bool IsProperty_F_I_15_Removed { get; set; }

		public virtual bool IsProperty_F_L_15_Removed { get; set; }

		public virtual bool IsProperty_F_DT_15_Removed { get; set; }

		public virtual bool IsProperty_F_N_15_Removed { get; set; }

		public virtual bool IsProperty_F_C5_15_Removed { get; set; }

		public virtual bool IsProperty_F_C10_15_Removed { get; set; }

		public virtual bool IsProperty_F_C20_15_Removed { get; set; }

		public virtual bool IsProperty_F_C50_15_Removed { get; set; }

		public virtual bool IsProperty_F_C100_15_Removed { get; set; }

		public virtual bool IsProperty_F_C200_15_Removed { get; set; }

		public virtual bool IsProperty_F_B_16_Removed { get; set; }

		public virtual bool IsProperty_F_I_16_Removed { get; set; }

		public virtual bool IsProperty_F_L_16_Removed { get; set; }

		public virtual bool IsProperty_F_DT_16_Removed { get; set; }

		public virtual bool IsProperty_F_N_16_Removed { get; set; }

		public virtual bool IsProperty_F_C5_16_Removed { get; set; }

		public virtual bool IsProperty_F_C10_16_Removed { get; set; }

		public virtual bool IsProperty_F_C20_16_Removed { get; set; }

		public virtual bool IsProperty_F_C50_16_Removed { get; set; }

		public virtual bool IsProperty_F_C100_16_Removed { get; set; }

		public virtual bool IsProperty_F_C200_16_Removed { get; set; }

		public virtual bool IsProperty_F_B_17_Removed { get; set; }

		public virtual bool IsProperty_F_I_17_Removed { get; set; }

		public virtual bool IsProperty_F_L_17_Removed { get; set; }

		public virtual bool IsProperty_F_DT_17_Removed { get; set; }

		public virtual bool IsProperty_F_N_17_Removed { get; set; }

		public virtual bool IsProperty_F_C5_17_Removed { get; set; }

		public virtual bool IsProperty_F_C10_17_Removed { get; set; }

		public virtual bool IsProperty_F_C20_17_Removed { get; set; }

		public virtual bool IsProperty_F_C50_17_Removed { get; set; }

		public virtual bool IsProperty_F_C100_17_Removed { get; set; }

		public virtual bool IsProperty_F_C200_17_Removed { get; set; }

		public virtual bool IsProperty_F_B_18_Removed { get; set; }

		public virtual bool IsProperty_F_I_18_Removed { get; set; }

		public virtual bool IsProperty_F_L_18_Removed { get; set; }

		public virtual bool IsProperty_F_DT_18_Removed { get; set; }

		public virtual bool IsProperty_F_N_18_Removed { get; set; }

		public virtual bool IsProperty_F_C5_18_Removed { get; set; }

		public virtual bool IsProperty_F_C10_18_Removed { get; set; }

		public virtual bool IsProperty_F_C20_18_Removed { get; set; }

		public virtual bool IsProperty_F_C50_18_Removed { get; set; }

		public virtual bool IsProperty_F_C100_18_Removed { get; set; }

		public virtual bool IsProperty_F_C200_18_Removed { get; set; }

		public virtual bool IsProperty_F_B_19_Removed { get; set; }

		public virtual bool IsProperty_F_I_19_Removed { get; set; }

		public virtual bool IsProperty_F_L_19_Removed { get; set; }

		public virtual bool IsProperty_F_DT_19_Removed { get; set; }

		public virtual bool IsProperty_F_N_19_Removed { get; set; }

		public virtual bool IsProperty_F_C5_19_Removed { get; set; }

		public virtual bool IsProperty_F_C10_19_Removed { get; set; }

		public virtual bool IsProperty_F_C20_19_Removed { get; set; }

		public virtual bool IsProperty_F_C50_19_Removed { get; set; }

		public virtual bool IsProperty_F_C100_19_Removed { get; set; }

		public virtual bool IsProperty_F_C200_19_Removed { get; set; }

		public virtual bool IsProperty_F_B_20_Removed { get; set; }

		public virtual bool IsProperty_F_I_20_Removed { get; set; }

		public virtual bool IsProperty_F_L_20_Removed { get; set; }

		public virtual bool IsProperty_F_N_20_Removed { get; set; }

		public virtual bool IsProperty_F_C5_20_Removed { get; set; }

		public virtual bool IsProperty_F_C10_20_Removed { get; set; }

		public virtual bool IsProperty_F_C20_20_Removed { get; set; }

		public virtual bool IsProperty_F_C50_20_Removed { get; set; }

		public virtual bool IsProperty_F_B_21_Removed { get; set; }

		public virtual bool IsProperty_F_I_21_Removed { get; set; }

		public virtual bool IsProperty_F_L_21_Removed { get; set; }

		public virtual bool IsProperty_F_N_21_Removed { get; set; }

		public virtual bool IsProperty_F_C5_21_Removed { get; set; }

		public virtual bool IsProperty_F_C10_21_Removed { get; set; }

		public virtual bool IsProperty_F_C20_21_Removed { get; set; }

		public virtual bool IsProperty_F_C50_21_Removed { get; set; }

		public virtual bool IsProperty_F_B_22_Removed { get; set; }

		public virtual bool IsProperty_F_I_22_Removed { get; set; }

		public virtual bool IsProperty_F_L_22_Removed { get; set; }

		public virtual bool IsProperty_F_N_22_Removed { get; set; }

		public virtual bool IsProperty_F_C5_22_Removed { get; set; }

		public virtual bool IsProperty_F_C10_22_Removed { get; set; }

		public virtual bool IsProperty_F_C20_22_Removed { get; set; }

		public virtual bool IsProperty_F_C50_22_Removed { get; set; }

		public virtual bool IsProperty_F_B_23_Removed { get; set; }

		public virtual bool IsProperty_F_I_23_Removed { get; set; }

		public virtual bool IsProperty_F_L_23_Removed { get; set; }

		public virtual bool IsProperty_F_N_23_Removed { get; set; }

		public virtual bool IsProperty_F_C5_23_Removed { get; set; }

		public virtual bool IsProperty_F_C10_23_Removed { get; set; }

		public virtual bool IsProperty_F_C20_23_Removed { get; set; }

		public virtual bool IsProperty_F_C50_23_Removed { get; set; }

		public virtual bool IsProperty_F_B_24_Removed { get; set; }

		public virtual bool IsProperty_F_I_24_Removed { get; set; }

		public virtual bool IsProperty_F_L_24_Removed { get; set; }

		public virtual bool IsProperty_F_N_24_Removed { get; set; }

		public virtual bool IsProperty_F_C5_24_Removed { get; set; }

		public virtual bool IsProperty_F_C10_24_Removed { get; set; }

		public virtual bool IsProperty_F_C20_24_Removed { get; set; }

		public virtual bool IsProperty_F_C50_24_Removed { get; set; }

		public virtual bool IsProperty_F_B_25_Removed { get; set; }

		public virtual bool IsProperty_F_I_25_Removed { get; set; }

		public virtual bool IsProperty_F_L_25_Removed { get; set; }

		public virtual bool IsProperty_F_N_25_Removed { get; set; }

		public virtual bool IsProperty_F_C5_25_Removed { get; set; }

		public virtual bool IsProperty_F_C10_25_Removed { get; set; }

		public virtual bool IsProperty_F_C20_25_Removed { get; set; }

		public virtual bool IsProperty_F_C50_25_Removed { get; set; }

		public virtual bool IsProperty_F_B_26_Removed { get; set; }

		public virtual bool IsProperty_F_I_26_Removed { get; set; }

		public virtual bool IsProperty_F_L_26_Removed { get; set; }

		public virtual bool IsProperty_F_N_26_Removed { get; set; }

		public virtual bool IsProperty_F_C5_26_Removed { get; set; }

		public virtual bool IsProperty_F_C10_26_Removed { get; set; }

		public virtual bool IsProperty_F_C20_26_Removed { get; set; }

		public virtual bool IsProperty_F_C50_26_Removed { get; set; }

		public virtual bool IsProperty_F_B_27_Removed { get; set; }

		public virtual bool IsProperty_F_I_27_Removed { get; set; }

		public virtual bool IsProperty_F_L_27_Removed { get; set; }

		public virtual bool IsProperty_F_N_27_Removed { get; set; }

		public virtual bool IsProperty_F_C5_27_Removed { get; set; }

		public virtual bool IsProperty_F_C10_27_Removed { get; set; }

		public virtual bool IsProperty_F_C20_27_Removed { get; set; }

		public virtual bool IsProperty_F_C50_27_Removed { get; set; }

		public virtual bool IsProperty_F_B_28_Removed { get; set; }

		public virtual bool IsProperty_F_I_28_Removed { get; set; }

		public virtual bool IsProperty_F_L_28_Removed { get; set; }

		public virtual bool IsProperty_F_N_28_Removed { get; set; }

		public virtual bool IsProperty_F_C5_28_Removed { get; set; }

		public virtual bool IsProperty_F_C10_28_Removed { get; set; }

		public virtual bool IsProperty_F_C20_28_Removed { get; set; }

		public virtual bool IsProperty_F_C50_28_Removed { get; set; }

		public virtual bool IsProperty_F_B_29_Removed { get; set; }

		public virtual bool IsProperty_F_I_29_Removed { get; set; }

		public virtual bool IsProperty_F_L_29_Removed { get; set; }

		public virtual bool IsProperty_F_N_29_Removed { get; set; }

		public virtual bool IsProperty_F_C5_29_Removed { get; set; }

		public virtual bool IsProperty_F_C10_29_Removed { get; set; }

		public virtual bool IsProperty_F_C20_29_Removed { get; set; }

		public virtual bool IsProperty_F_C50_29_Removed { get; set; }

		public virtual bool IsProperty_F_B_30_Removed { get; set; }

		public virtual bool IsProperty_F_I_30_Removed { get; set; }

		public virtual bool IsProperty_F_N_30_Removed { get; set; }

		public virtual bool IsProperty_F_C5_30_Removed { get; set; }

		public virtual bool IsProperty_F_C10_30_Removed { get; set; }

		public virtual bool IsProperty_F_C20_30_Removed { get; set; }

		public virtual bool IsProperty_F_C50_30_Removed { get; set; }

		public virtual bool IsProperty_F_B_31_Removed { get; set; }

		public virtual bool IsProperty_F_I_31_Removed { get; set; }

		public virtual bool IsProperty_F_N_31_Removed { get; set; }

		public virtual bool IsProperty_F_C5_31_Removed { get; set; }

		public virtual bool IsProperty_F_C10_31_Removed { get; set; }

		public virtual bool IsProperty_F_C20_31_Removed { get; set; }

		public virtual bool IsProperty_F_C50_31_Removed { get; set; }

		public virtual bool IsProperty_F_B_32_Removed { get; set; }

		public virtual bool IsProperty_F_I_32_Removed { get; set; }

		public virtual bool IsProperty_F_N_32_Removed { get; set; }

		public virtual bool IsProperty_F_C5_32_Removed { get; set; }

		public virtual bool IsProperty_F_C10_32_Removed { get; set; }

		public virtual bool IsProperty_F_C20_32_Removed { get; set; }

		public virtual bool IsProperty_F_C50_32_Removed { get; set; }

		public virtual bool IsProperty_F_B_33_Removed { get; set; }

		public virtual bool IsProperty_F_I_33_Removed { get; set; }

		public virtual bool IsProperty_F_N_33_Removed { get; set; }

		public virtual bool IsProperty_F_C5_33_Removed { get; set; }

		public virtual bool IsProperty_F_C10_33_Removed { get; set; }

		public virtual bool IsProperty_F_C20_33_Removed { get; set; }

		public virtual bool IsProperty_F_C50_33_Removed { get; set; }

		public virtual bool IsProperty_F_B_34_Removed { get; set; }

		public virtual bool IsProperty_F_I_34_Removed { get; set; }

		public virtual bool IsProperty_F_N_34_Removed { get; set; }

		public virtual bool IsProperty_F_C5_34_Removed { get; set; }

		public virtual bool IsProperty_F_C10_34_Removed { get; set; }

		public virtual bool IsProperty_F_C20_34_Removed { get; set; }

		public virtual bool IsProperty_F_C50_34_Removed { get; set; }

		public virtual bool IsProperty_F_B_35_Removed { get; set; }

		public virtual bool IsProperty_F_I_35_Removed { get; set; }

		public virtual bool IsProperty_F_N_35_Removed { get; set; }

		public virtual bool IsProperty_F_C5_35_Removed { get; set; }

		public virtual bool IsProperty_F_C10_35_Removed { get; set; }

		public virtual bool IsProperty_F_C20_35_Removed { get; set; }

		public virtual bool IsProperty_F_C50_35_Removed { get; set; }

		public virtual bool IsProperty_F_B_36_Removed { get; set; }

		public virtual bool IsProperty_F_I_36_Removed { get; set; }

		public virtual bool IsProperty_F_N_36_Removed { get; set; }

		public virtual bool IsProperty_F_C5_36_Removed { get; set; }

		public virtual bool IsProperty_F_C10_36_Removed { get; set; }

		public virtual bool IsProperty_F_C20_36_Removed { get; set; }

		public virtual bool IsProperty_F_C50_36_Removed { get; set; }

		public virtual bool IsProperty_F_B_37_Removed { get; set; }

		public virtual bool IsProperty_F_I_37_Removed { get; set; }

		public virtual bool IsProperty_F_N_37_Removed { get; set; }

		public virtual bool IsProperty_F_C5_37_Removed { get; set; }

		public virtual bool IsProperty_F_C10_37_Removed { get; set; }

		public virtual bool IsProperty_F_C20_37_Removed { get; set; }

		public virtual bool IsProperty_F_C50_37_Removed { get; set; }

		public virtual bool IsProperty_F_B_38_Removed { get; set; }

		public virtual bool IsProperty_F_I_38_Removed { get; set; }

		public virtual bool IsProperty_F_N_38_Removed { get; set; }

		public virtual bool IsProperty_F_C5_38_Removed { get; set; }

		public virtual bool IsProperty_F_C10_38_Removed { get; set; }

		public virtual bool IsProperty_F_C20_38_Removed { get; set; }

		public virtual bool IsProperty_F_C50_38_Removed { get; set; }

		public virtual bool IsProperty_F_B_39_Removed { get; set; }

		public virtual bool IsProperty_F_I_39_Removed { get; set; }

		public virtual bool IsProperty_F_N_39_Removed { get; set; }

		public virtual bool IsProperty_F_C5_39_Removed { get; set; }

		public virtual bool IsProperty_F_C10_39_Removed { get; set; }

		public virtual bool IsProperty_F_C20_39_Removed { get; set; }

		public virtual bool IsProperty_F_C50_39_Removed { get; set; }

		public virtual bool IsProperty_F_B_40_Removed { get; set; }

		public virtual bool IsProperty_F_I_40_Removed { get; set; }

		public virtual bool IsProperty_F_N_40_Removed { get; set; }

		public virtual bool IsProperty_F_C5_40_Removed { get; set; }

		public virtual bool IsProperty_F_C10_40_Removed { get; set; }

		public virtual bool IsProperty_F_C20_40_Removed { get; set; }

		public virtual bool IsProperty_F_C50_40_Removed { get; set; }

		public virtual bool IsProperty_F_B_41_Removed { get; set; }

		public virtual bool IsProperty_F_I_41_Removed { get; set; }

		public virtual bool IsProperty_F_N_41_Removed { get; set; }

		public virtual bool IsProperty_F_C5_41_Removed { get; set; }

		public virtual bool IsProperty_F_C10_41_Removed { get; set; }

		public virtual bool IsProperty_F_C20_41_Removed { get; set; }

		public virtual bool IsProperty_F_C50_41_Removed { get; set; }

		public virtual bool IsProperty_F_B_42_Removed { get; set; }

		public virtual bool IsProperty_F_I_42_Removed { get; set; }

		public virtual bool IsProperty_F_N_42_Removed { get; set; }

		public virtual bool IsProperty_F_C5_42_Removed { get; set; }

		public virtual bool IsProperty_F_C10_42_Removed { get; set; }

		public virtual bool IsProperty_F_C20_42_Removed { get; set; }

		public virtual bool IsProperty_F_C50_42_Removed { get; set; }

		public virtual bool IsProperty_F_B_43_Removed { get; set; }

		public virtual bool IsProperty_F_I_43_Removed { get; set; }

		public virtual bool IsProperty_F_N_43_Removed { get; set; }

		public virtual bool IsProperty_F_C5_43_Removed { get; set; }

		public virtual bool IsProperty_F_C10_43_Removed { get; set; }

		public virtual bool IsProperty_F_C20_43_Removed { get; set; }

		public virtual bool IsProperty_F_C50_43_Removed { get; set; }

		public virtual bool IsProperty_F_B_44_Removed { get; set; }

		public virtual bool IsProperty_F_I_44_Removed { get; set; }

		public virtual bool IsProperty_F_N_44_Removed { get; set; }

		public virtual bool IsProperty_F_C5_44_Removed { get; set; }

		public virtual bool IsProperty_F_C10_44_Removed { get; set; }

		public virtual bool IsProperty_F_C20_44_Removed { get; set; }

		public virtual bool IsProperty_F_C50_44_Removed { get; set; }

		public virtual bool IsProperty_F_B_45_Removed { get; set; }

		public virtual bool IsProperty_F_I_45_Removed { get; set; }

		public virtual bool IsProperty_F_N_45_Removed { get; set; }

		public virtual bool IsProperty_F_C5_45_Removed { get; set; }

		public virtual bool IsProperty_F_C10_45_Removed { get; set; }

		public virtual bool IsProperty_F_C20_45_Removed { get; set; }

		public virtual bool IsProperty_F_C50_45_Removed { get; set; }

		public virtual bool IsProperty_F_B_46_Removed { get; set; }

		public virtual bool IsProperty_F_I_46_Removed { get; set; }

		public virtual bool IsProperty_F_N_46_Removed { get; set; }

		public virtual bool IsProperty_F_C5_46_Removed { get; set; }

		public virtual bool IsProperty_F_C10_46_Removed { get; set; }

		public virtual bool IsProperty_F_C20_46_Removed { get; set; }

		public virtual bool IsProperty_F_C50_46_Removed { get; set; }

		public virtual bool IsProperty_F_B_47_Removed { get; set; }

		public virtual bool IsProperty_F_I_47_Removed { get; set; }

		public virtual bool IsProperty_F_N_47_Removed { get; set; }

		public virtual bool IsProperty_F_C5_47_Removed { get; set; }

		public virtual bool IsProperty_F_C10_47_Removed { get; set; }

		public virtual bool IsProperty_F_C20_47_Removed { get; set; }

		public virtual bool IsProperty_F_C50_47_Removed { get; set; }

		public virtual bool IsProperty_F_B_48_Removed { get; set; }

		public virtual bool IsProperty_F_I_48_Removed { get; set; }

		public virtual bool IsProperty_F_N_48_Removed { get; set; }

		public virtual bool IsProperty_F_C5_48_Removed { get; set; }

		public virtual bool IsProperty_F_C10_48_Removed { get; set; }

		public virtual bool IsProperty_F_C20_48_Removed { get; set; }

		public virtual bool IsProperty_F_C50_48_Removed { get; set; }

		public virtual bool IsProperty_F_B_49_Removed { get; set; }

		public virtual bool IsProperty_F_I_49_Removed { get; set; }

		public virtual bool IsProperty_F_N_49_Removed { get; set; }

		public virtual bool IsProperty_F_C5_49_Removed { get; set; }

		public virtual bool IsProperty_F_C10_49_Removed { get; set; }

		public virtual bool IsProperty_F_C20_49_Removed { get; set; }

		public virtual bool IsProperty_F_C50_49_Removed { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public MergePatchAttributeSetInstance ()
		{
		}


	}

	public class DeleteAttributeSetInstance : AttributeSetInstanceCommandBase, IDeleteAttributeSetInstance
	{
		public DeleteAttributeSetInstance ()
		{
		}
	}



}

