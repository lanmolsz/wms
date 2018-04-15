﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetInstanceDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstance;

namespace Dddml.Wms.Domain.AttributeSetInstance
{

	public abstract class AttributeSetInstanceStateEventBase : IAttributeSetInstanceStateEvent
	{

        private AttributeSetInstanceState _state;

        public virtual AttributeSetInstanceState AttributeSetInstanceState { get { return _state; } }

        public virtual AttributeSetInstanceEventId AttributeSetInstanceEventId
        {
            get
            {
                AttributeSetInstanceEventId eventId = new AttributeSetInstanceEventId(_state.AttributeSetInstanceId, default(long));
                return eventId;
            }
            set
            {
                _state.AttributeSetInstanceId = value.AttributeSetInstanceId;
            }
        }

        public virtual string AttributeSetInstanceId
        {
            get { return AttributeSetInstanceEventId.AttributeSetInstanceId; }
            set { AttributeSetInstanceEventId.AttributeSetInstanceId = value; }
        }

        public virtual string AttributeSetId { get { return _state.AttributeSetId; } set { _state.AttributeSetId = value; } }

        public virtual string OrganizationId { get { return _state.OrganizationId; } set { _state.OrganizationId = value; } }

        public virtual string ReferenceId { get { return _state.ReferenceId; } set { _state.ReferenceId = value; } }

        public virtual string SerialNumber { get { return _state.SerialNumber; } set { _state.SerialNumber = value; } }

        public virtual string LotId { get { return _state.LotId; } set { _state.LotId = value; } }

        public virtual string Description { get { return _state.Description; } set { _state.Description = value; } }

        public virtual string Hash { get { return _state.Hash; } set { _state.Hash = value; } }

        public virtual decimal? WidthInch { get { return _state.WidthInch; } set { _state.WidthInch = value; } }

        public virtual decimal? DiameterInch { get { return _state.DiameterInch; } set { _state.DiameterInch = value; } }

        public virtual decimal? WeightLbs { get { return _state.WeightLbs; } set { _state.WeightLbs = value; } }

        public virtual decimal? WeightKg { get { return _state.WeightKg; } set { _state.WeightKg = value; } }

        public virtual decimal? AirDryWeightLbs { get { return _state.AirDryWeightLbs; } set { _state.AirDryWeightLbs = value; } }

        public virtual decimal? AirDryWeightKg { get { return _state.AirDryWeightKg; } set { _state.AirDryWeightKg = value; } }

        public virtual decimal? AirDryMetricTon { get { return _state.AirDryMetricTon; } set { _state.AirDryMetricTon = value; } }

        public virtual int? PackageCount { get { return _state.PackageCount; } set { _state.PackageCount = value; } }

        public virtual decimal? AirDryPct { get { return _state.AirDryPct; } set { _state.AirDryPct = value; } }

        public virtual bool? _F_B_0_ { get { return _state._F_B_0_; } set { _state._F_B_0_ = value; } }

        public virtual int? _F_I_0_ { get { return _state._F_I_0_; } set { _state._F_I_0_ = value; } }

        public virtual long? _F_L_0_ { get { return _state._F_L_0_; } set { _state._F_L_0_ = value; } }

        public virtual DateTime? _F_DT_0_ { get { return _state._F_DT_0_; } set { _state._F_DT_0_ = value; } }

        public virtual decimal? _F_N_0_ { get { return _state._F_N_0_; } set { _state._F_N_0_ = value; } }

        public virtual string _F_C5_0_ { get { return _state._F_C5_0_; } set { _state._F_C5_0_ = value; } }

        public virtual string _F_C10_0_ { get { return _state._F_C10_0_; } set { _state._F_C10_0_ = value; } }

        public virtual string _F_C20_0_ { get { return _state._F_C20_0_; } set { _state._F_C20_0_ = value; } }

        public virtual string _F_C50_0_ { get { return _state._F_C50_0_; } set { _state._F_C50_0_ = value; } }

        public virtual string _F_C100_0_ { get { return _state._F_C100_0_; } set { _state._F_C100_0_ = value; } }

        public virtual string _F_C200_0_ { get { return _state._F_C200_0_; } set { _state._F_C200_0_ = value; } }

        public virtual string _F_C500_0_ { get { return _state._F_C500_0_; } set { _state._F_C500_0_ = value; } }

        public virtual string _F_C1000_0_ { get { return _state._F_C1000_0_; } set { _state._F_C1000_0_ = value; } }

        public virtual bool? _F_B_1_ { get { return _state._F_B_1_; } set { _state._F_B_1_ = value; } }

        public virtual int? _F_I_1_ { get { return _state._F_I_1_; } set { _state._F_I_1_ = value; } }

        public virtual long? _F_L_1_ { get { return _state._F_L_1_; } set { _state._F_L_1_ = value; } }

        public virtual DateTime? _F_DT_1_ { get { return _state._F_DT_1_; } set { _state._F_DT_1_ = value; } }

        public virtual decimal? _F_N_1_ { get { return _state._F_N_1_; } set { _state._F_N_1_ = value; } }

        public virtual string _F_C5_1_ { get { return _state._F_C5_1_; } set { _state._F_C5_1_ = value; } }

        public virtual string _F_C10_1_ { get { return _state._F_C10_1_; } set { _state._F_C10_1_ = value; } }

        public virtual string _F_C20_1_ { get { return _state._F_C20_1_; } set { _state._F_C20_1_ = value; } }

        public virtual string _F_C50_1_ { get { return _state._F_C50_1_; } set { _state._F_C50_1_ = value; } }

        public virtual string _F_C100_1_ { get { return _state._F_C100_1_; } set { _state._F_C100_1_ = value; } }

        public virtual string _F_C200_1_ { get { return _state._F_C200_1_; } set { _state._F_C200_1_ = value; } }

        public virtual bool? _F_B_2_ { get { return _state._F_B_2_; } set { _state._F_B_2_ = value; } }

        public virtual int? _F_I_2_ { get { return _state._F_I_2_; } set { _state._F_I_2_ = value; } }

        public virtual long? _F_L_2_ { get { return _state._F_L_2_; } set { _state._F_L_2_ = value; } }

        public virtual DateTime? _F_DT_2_ { get { return _state._F_DT_2_; } set { _state._F_DT_2_ = value; } }

        public virtual decimal? _F_N_2_ { get { return _state._F_N_2_; } set { _state._F_N_2_ = value; } }

        public virtual string _F_C5_2_ { get { return _state._F_C5_2_; } set { _state._F_C5_2_ = value; } }

        public virtual string _F_C10_2_ { get { return _state._F_C10_2_; } set { _state._F_C10_2_ = value; } }

        public virtual string _F_C20_2_ { get { return _state._F_C20_2_; } set { _state._F_C20_2_ = value; } }

        public virtual string _F_C50_2_ { get { return _state._F_C50_2_; } set { _state._F_C50_2_ = value; } }

        public virtual bool? _F_B_3_ { get { return _state._F_B_3_; } set { _state._F_B_3_ = value; } }

        public virtual int? _F_I_3_ { get { return _state._F_I_3_; } set { _state._F_I_3_ = value; } }

        public virtual long? _F_L_3_ { get { return _state._F_L_3_; } set { _state._F_L_3_ = value; } }

        public virtual DateTime? _F_DT_3_ { get { return _state._F_DT_3_; } set { _state._F_DT_3_ = value; } }

        public virtual decimal? _F_N_3_ { get { return _state._F_N_3_; } set { _state._F_N_3_ = value; } }

        public virtual string _F_C5_3_ { get { return _state._F_C5_3_; } set { _state._F_C5_3_ = value; } }

        public virtual string _F_C10_3_ { get { return _state._F_C10_3_; } set { _state._F_C10_3_ = value; } }

        public virtual string _F_C20_3_ { get { return _state._F_C20_3_; } set { _state._F_C20_3_ = value; } }

        public virtual string _F_C50_3_ { get { return _state._F_C50_3_; } set { _state._F_C50_3_ = value; } }

        public virtual bool? _F_B_4_ { get { return _state._F_B_4_; } set { _state._F_B_4_ = value; } }

        public virtual int? _F_I_4_ { get { return _state._F_I_4_; } set { _state._F_I_4_ = value; } }

        public virtual long? _F_L_4_ { get { return _state._F_L_4_; } set { _state._F_L_4_ = value; } }

        public virtual DateTime? _F_DT_4_ { get { return _state._F_DT_4_; } set { _state._F_DT_4_ = value; } }

        public virtual decimal? _F_N_4_ { get { return _state._F_N_4_; } set { _state._F_N_4_ = value; } }

        public virtual string _F_C5_4_ { get { return _state._F_C5_4_; } set { _state._F_C5_4_ = value; } }

        public virtual string _F_C10_4_ { get { return _state._F_C10_4_; } set { _state._F_C10_4_ = value; } }

        public virtual string _F_C20_4_ { get { return _state._F_C20_4_; } set { _state._F_C20_4_ = value; } }

        public virtual string _F_C50_4_ { get { return _state._F_C50_4_; } set { _state._F_C50_4_ = value; } }

        public virtual bool? Active { get { return _state.Active; } set { _state.Active = (value != null && value.HasValue) ? value.Value : default(bool); } }

		public virtual string CreatedBy { get { return _state.CreatedBy; } set { _state.CreatedBy = value; } }

		public virtual DateTime CreatedAt { get { return _state.CreatedAt; } set { _state.CreatedAt = value; } }

        public virtual string CommandId { get { return _state.CommandId; } set { _state.CommandId = value; } }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		AttributeSetInstanceEventId IGlobalIdentity<AttributeSetInstanceEventId>.GlobalId {
			get
			{
				return this.AttributeSetInstanceEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IAttributeSetInstanceStateEvent.ReadOnly
        {
            get
            {
                return this.EventReadOnly;
            }
            set
            {
                this.EventReadOnly = value;
            }
        }


		string ICreated<string>.CreatedBy {
			get {
				return this.CreatedBy;
			}
			set {
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt {
			get {
				return this.CreatedAt;
			}
			set {
				this.CreatedAt = value;
			}
		}

        protected AttributeSetInstanceStateEventBase() : this(new AttributeSetInstanceState())
        {
        }

        protected AttributeSetInstanceStateEventBase(AttributeSetInstanceEventId stateEventId) : this(new AttributeSetInstanceState())
        {
            this.AttributeSetInstanceEventId = stateEventId;
        }

        protected AttributeSetInstanceStateEventBase(AttributeSetInstanceState state)
        {
            if (state == null) { throw new ArgumentNullException(); }
            this._state = state;
        }


        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class AttributeSetInstanceStateCreated : AttributeSetInstanceStateEventBase, IAttributeSetInstanceStateCreated
	{
		public AttributeSetInstanceStateCreated () : this(new AttributeSetInstanceEventId())
		{
		}

		public AttributeSetInstanceStateCreated (AttributeSetInstanceEventId stateEventId) : base(stateEventId)
		{
		}

        public AttributeSetInstanceStateCreated(AttributeSetInstanceState state) : base(state)
        {
        }


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}




}

