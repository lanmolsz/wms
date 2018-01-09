﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateProductCategoryMemberDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ProductCategoryMember;

namespace Dddml.Wms.Domain.ProductCategoryMember
{
    public partial class ProductCategoryMemberAggregate : AggregateBase, IProductCategoryMemberAggregate
    {

        readonly IProductCategoryMemberState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IProductCategoryMemberState State
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

        ProductCategoryMemberId IGlobalIdentity<ProductCategoryMemberId>.GlobalId
        {
            get
            {
                return this._state.GlobalId;
            }
        }

        #endregion


        public ProductCategoryMemberAggregate(IProductCategoryMemberState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IProductCategoryMemberStateProperties)_state).Version == ProductCategoryMemberState.VersionZero)
            {
                if (IsCommandCreate((IProductCategoryMemberCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (IsCommandCreate((IProductCategoryMemberCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IProductCategoryMemberCommand c)
        {
            return c.Version == ProductCategoryMemberState.VersionZero;
        }

        protected internal virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateProductCategoryMember c)
        {
            IProductCategoryMemberStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchProductCategoryMember c)
        {
            IProductCategoryMemberStateMergePatched e = Map(c);
            Apply(e);
        }


        protected virtual IProductCategoryMemberStateCreated Map(ICreateProductCategoryMember c)
        {
			var stateEventId = new ProductCategoryMemberStateEventId(c.ProductCategoryMemberId, c.Version);
            IProductCategoryMemberStateCreated e = NewProductCategoryMemberStateCreated(stateEventId);
		
            e.ThruDate = c.ThruDate;
            e.Comments = c.Comments;
            e.SequenceNum = c.SequenceNum;
            e.Quantity = c.Quantity;
            e.Active = c.Active;
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
			var version = c.Version;


            return e;
        }

        protected virtual IProductCategoryMemberStateMergePatched Map(IMergePatchProductCategoryMember c)
        {
			var stateEventId = new ProductCategoryMemberStateEventId(c.ProductCategoryMemberId, c.Version);
            IProductCategoryMemberStateMergePatched e = NewProductCategoryMemberStateMergePatched(stateEventId);

            e.ThruDate = c.ThruDate;
            e.Comments = c.Comments;
            e.SequenceNum = c.SequenceNum;
            e.Quantity = c.Quantity;
            e.Active = c.Active;
            e.IsPropertyThruDateRemoved = c.IsPropertyThruDateRemoved;
            e.IsPropertyCommentsRemoved = c.IsPropertyCommentsRemoved;
            e.IsPropertySequenceNumRemoved = c.IsPropertySequenceNumRemoved;
            e.IsPropertyQuantityRemoved = c.IsPropertyQuantityRemoved;
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

        protected ProductCategoryMemberStateCreated NewProductCategoryMemberStateCreated(long version, string commandId, string requesterId)
        {
            var stateEventId = new ProductCategoryMemberStateEventId(_state.ProductCategoryMemberId, version);
            var e = NewProductCategoryMemberStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

        protected ProductCategoryMemberStateMergePatched NewProductCategoryMemberStateMergePatched(long version, string commandId, string requesterId)
        {
            var stateEventId = new ProductCategoryMemberStateEventId(_state.ProductCategoryMemberId, version);
            var e = NewProductCategoryMemberStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }


////////////////////////

		private ProductCategoryMemberStateCreated NewProductCategoryMemberStateCreated(ProductCategoryMemberStateEventId stateEventId)
		{
			return new ProductCategoryMemberStateCreated(stateEventId);			
		}

        private ProductCategoryMemberStateMergePatched NewProductCategoryMemberStateMergePatched(ProductCategoryMemberStateEventId stateEventId)
		{
			return new ProductCategoryMemberStateMergePatched(stateEventId);
		}

    }

}

