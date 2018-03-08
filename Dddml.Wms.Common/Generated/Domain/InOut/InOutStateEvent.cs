﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOut;

namespace Dddml.Wms.Domain.InOut
{

	public abstract class InOutStateEventBase : IInOutStateEvent
	{

		public virtual InOutEventId StateEventId { get; set; }

        public virtual string DocumentNumber
        {
            get { return StateEventId.DocumentNumber; }
            set { StateEventId.DocumentNumber = value; }
        }

		public virtual string DocumentStatusId { get; set; }

		public virtual bool? Posted { get; set; }

		public virtual bool? Processed { get; set; }

		public virtual string Processing { get; set; }

		public virtual string DocumentTypeId { get; set; }

		public virtual string Description { get; set; }

		public virtual string OrderId { get; set; }

		public virtual DateTime? DateOrdered { get; set; }

		public virtual bool? IsPrinted { get; set; }

		public virtual string MovementTypeId { get; set; }

		public virtual DateTime? MovementDate { get; set; }

		public virtual string BusinessPartnerId { get; set; }

		public virtual string WarehouseId { get; set; }

		public virtual string POReference { get; set; }

		public virtual decimal? FreightAmount { get; set; }

		public virtual string ShipperId { get; set; }

		public virtual decimal? ChargeAmount { get; set; }

		public virtual DateTime? DatePrinted { get; set; }

		public virtual string CreatedFrom { get; set; }

		public virtual string SalesRepresentativeId { get; set; }

		public virtual int? NumberOfPackages { get; set; }

		public virtual DateTime? PickDate { get; set; }

		public virtual DateTime? ShipDate { get; set; }

		public virtual string TrackingNumber { get; set; }

		public virtual DateTime? DateReceived { get; set; }

		public virtual bool? IsInTransit { get; set; }

		public virtual bool? IsApproved { get; set; }

		public virtual bool? IsInDispute { get; set; }

		public virtual string RmaDocumentNumber { get; set; }

		public virtual string ReversalDocumentNumber { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		InOutEventId IGlobalIdentity<InOutEventId>.GlobalId {
			get
			{
				return this.StateEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IInOutStateEvent.ReadOnly
        {
            get
            {
                return this.StateEventReadOnly;
            }
            set
            {
                this.StateEventReadOnly = value;
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

        protected InOutStateEventBase()
        {
        }

        protected InOutStateEventBase(InOutEventId stateEventId)
        {
            this.StateEventId = stateEventId;
        }

		protected IInOutLineStateEventDao InOutLineStateEventDao
		{
			get { return ApplicationContext.Current["InOutLineStateEventDao"] as IInOutLineStateEventDao; }
		}

        protected InOutLineEventId NewInOutLineEventId(string lineNumber)
        {
            var stateEventId = new InOutLineEventId(this.StateEventId.DocumentNumber, lineNumber, this.StateEventId.Version);
            return stateEventId;
        }


        protected void ThrowOnInconsistentEventIds(IInOutLineStateEvent e)
        {
            ThrowOnInconsistentEventIds(this, e);
        }

		public static void ThrowOnInconsistentEventIds(IInOutStateEvent oe, IInOutLineStateEvent e)
		{
			if (!oe.StateEventId.DocumentNumber.Equals(e.StateEventId.InOutDocumentNumber))
			{ 
				throw DomainError.Named("inconsistentEventIds", "Outer Id DocumentNumber {0} but inner id InOutDocumentNumber {1}", 
					oe.StateEventId.DocumentNumber, e.StateEventId.InOutDocumentNumber);
			}
		}



        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class InOutStateCreated : InOutStateEventBase, IInOutStateCreated, ISaveable
	{
		public InOutStateCreated () : this(new InOutEventId())
		{
		}

		public InOutStateCreated (InOutEventId stateEventId) : base(stateEventId)
		{
		}

		private Dictionary<InOutLineEventId, IInOutLineStateCreated> _inOutLineEvents = new Dictionary<InOutLineEventId, IInOutLineStateCreated>();
        
        private IEnumerable<IInOutLineStateCreated> _readOnlyInOutLineEvents;

        public virtual IEnumerable<IInOutLineStateCreated> InOutLineEvents
        {
            get
            {
                if (!StateEventReadOnly)
                {
                    return this._inOutLineEvents.Values;
                }
                else
                {
                    if (_readOnlyInOutLineEvents != null) { return _readOnlyInOutLineEvents; }
                    var eventDao = InOutLineStateEventDao;
                    var eL = new List<IInOutLineStateCreated>();
                    foreach (var e in eventDao.FindByInOutEventId(this.StateEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IInOutLineStateCreated)e);
                    }
                    return (_readOnlyInOutLineEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddInOutLineEvent(e);
                    }
                }
                else { this._inOutLineEvents.Clear(); }
            }
        }
    
		public virtual void AddInOutLineEvent(IInOutLineStateCreated e)
		{
			ThrowOnInconsistentEventIds(e);
			this._inOutLineEvents[e.StateEventId] = e;
		}

        public virtual IInOutLineStateCreated NewInOutLineStateCreated(string lineNumber)
        {
            var stateEvent = new InOutLineStateCreated(NewInOutLineEventId(lineNumber));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IInOutLineStateCreated e in this.InOutLineEvents) {
				InOutLineStateEventDao.Save(e);
			}
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class InOutStateMergePatched : InOutStateEventBase, IInOutStateMergePatched, ISaveable
	{
		public virtual bool IsPropertyDocumentStatusIdRemoved { get; set; }

		public virtual bool IsPropertyPostedRemoved { get; set; }

		public virtual bool IsPropertyProcessedRemoved { get; set; }

		public virtual bool IsPropertyProcessingRemoved { get; set; }

		public virtual bool IsPropertyDocumentTypeIdRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyOrderIdRemoved { get; set; }

		public virtual bool IsPropertyDateOrderedRemoved { get; set; }

		public virtual bool IsPropertyIsPrintedRemoved { get; set; }

		public virtual bool IsPropertyMovementTypeIdRemoved { get; set; }

		public virtual bool IsPropertyMovementDateRemoved { get; set; }

		public virtual bool IsPropertyBusinessPartnerIdRemoved { get; set; }

		public virtual bool IsPropertyWarehouseIdRemoved { get; set; }

		public virtual bool IsPropertyPOReferenceRemoved { get; set; }

		public virtual bool IsPropertyFreightAmountRemoved { get; set; }

		public virtual bool IsPropertyShipperIdRemoved { get; set; }

		public virtual bool IsPropertyChargeAmountRemoved { get; set; }

		public virtual bool IsPropertyDatePrintedRemoved { get; set; }

		public virtual bool IsPropertyCreatedFromRemoved { get; set; }

		public virtual bool IsPropertySalesRepresentativeIdRemoved { get; set; }

		public virtual bool IsPropertyNumberOfPackagesRemoved { get; set; }

		public virtual bool IsPropertyPickDateRemoved { get; set; }

		public virtual bool IsPropertyShipDateRemoved { get; set; }

		public virtual bool IsPropertyTrackingNumberRemoved { get; set; }

		public virtual bool IsPropertyDateReceivedRemoved { get; set; }

		public virtual bool IsPropertyIsInTransitRemoved { get; set; }

		public virtual bool IsPropertyIsApprovedRemoved { get; set; }

		public virtual bool IsPropertyIsInDisputeRemoved { get; set; }

		public virtual bool IsPropertyRmaDocumentNumberRemoved { get; set; }

		public virtual bool IsPropertyReversalDocumentNumberRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public InOutStateMergePatched ()
		{
		}

		public InOutStateMergePatched (InOutEventId stateEventId) : base(stateEventId)
		{
		}

		private Dictionary<InOutLineEventId, IInOutLineStateEvent> _inOutLineEvents = new Dictionary<InOutLineEventId, IInOutLineStateEvent>();

        private IEnumerable<IInOutLineStateEvent> _readOnlyInOutLineEvents;
        
        public virtual IEnumerable<IInOutLineStateEvent> InOutLineEvents
        {
            get
            {
                if (!StateEventReadOnly)
                {
                    return this._inOutLineEvents.Values;
                }
                else
                {
                    if (_readOnlyInOutLineEvents != null) { return _readOnlyInOutLineEvents; }
                    var eventDao = InOutLineStateEventDao;
                    var eL = new List<IInOutLineStateEvent>();
                    foreach (var e in eventDao.FindByInOutEventId(this.StateEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IInOutLineStateEvent)e);
                    }
                    return (_readOnlyInOutLineEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddInOutLineEvent(e);
                    }
                }
                else { this._inOutLineEvents.Clear(); }
            }
        }

		public virtual void AddInOutLineEvent(IInOutLineStateEvent e)
		{
			ThrowOnInconsistentEventIds(e);
			this._inOutLineEvents[e.StateEventId] = e;
		}

        public virtual IInOutLineStateCreated NewInOutLineStateCreated(string lineNumber)
        {
            var stateEvent = new InOutLineStateCreated(NewInOutLineEventId(lineNumber));
            return stateEvent;
        }

        public virtual IInOutLineStateMergePatched NewInOutLineStateMergePatched(string lineNumber)
        {
            var stateEvent = new InOutLineStateMergePatched(NewInOutLineEventId(lineNumber));
            return stateEvent;
        }

        public virtual IInOutLineStateRemoved NewInOutLineStateRemoved(string lineNumber)
        {
            var stateEvent = new InOutLineStateRemoved(NewInOutLineEventId(lineNumber));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IInOutLineStateEvent e in this.InOutLineEvents) {
				InOutLineStateEventDao.Save(e);
			}
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}




}

