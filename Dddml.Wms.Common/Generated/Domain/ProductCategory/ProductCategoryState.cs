﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateProductCategoryDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ProductCategory;

namespace Dddml.Wms.Domain.ProductCategory
{

	public partial class ProductCategoryState : ProductCategoryStateProperties, IProductCategoryState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }

		public virtual bool Deleted { get; set; }


		#region IIdentity implementation

		string IGlobalIdentity<string>.GlobalId
		{
			get
			{
				return this.ProductCategoryId;
			}
		}

		#endregion

		#region IActive implementation

		bool IActive.IsActive()
		{
			return this.Active;
		}

		#endregion

		#region IDeleted implementation

		bool IDeleted.Deleted
		{
			get
			{
				return this.Deleted;
			}
		}

		#endregion

		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
			get
			{
				return this.CreatedBy;
			}
			set
			{
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt
		{
			get
			{
				return this.CreatedAt;
			}
			set
			{
				this.CreatedAt = value;
			}
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
			get { return this.UpdatedBy; }
			set { this.UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
			get { return this.UpdatedAt; }
			set { this.UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
			get
			{
				return this.Version;
			}
		}


		#endregion

        bool IProductCategoryState.IsUnsaved
        {
            get { return this.Version == VersionZero; }
        }

		public static long VersionZero
		{
			get
			{
				return (long)0;
			}
		}


        public virtual bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }
	
        private bool _forReapplying;

        public virtual bool ForReapplying
        {
            get { return _forReapplying; }
            set { _forReapplying = value; } 
        }

        public ProductCategoryState(IEnumerable<IEvent> events) : this(true)
        {
            if (events != null && events.Count() > 0)
            {
                this.ProductCategoryId = ((IProductCategoryStateEvent)events.First()).StateEventId.ProductCategoryId;
                foreach (var e in events)
                {
                    Mutate(e);
                    this.Version += 1;
                }
            }
        }

        public ProductCategoryState() : this(false)
        {
        }

        public ProductCategoryState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IProductCategoryStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.ProductCategoryTypeId = e.ProductCategoryTypeId;

			this.PrimaryParentCategoryId = e.PrimaryParentCategoryId;

			this.CategoryName = e.CategoryName;

			this.Description = e.Description;

			this.CategoryImageUrl = e.CategoryImageUrl;

			this.DetailScreen = e.DetailScreen;

            this.ShowInSelect = (e.ShowInSelect != null && e.ShowInSelect.HasValue) ? e.ShowInSelect.Value : default(bool);

			this.AttributeSetId = e.AttributeSetId;

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IProductCategoryStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.ProductCategoryTypeId == null)
			{
				if (e.IsPropertyProductCategoryTypeIdRemoved)
				{
					this.ProductCategoryTypeId = default(string);
				}
			}
			else
			{
				this.ProductCategoryTypeId = e.ProductCategoryTypeId;
			}

			if (e.PrimaryParentCategoryId == null)
			{
				if (e.IsPropertyPrimaryParentCategoryIdRemoved)
				{
					this.PrimaryParentCategoryId = default(string);
				}
			}
			else
			{
				this.PrimaryParentCategoryId = e.PrimaryParentCategoryId;
			}

			if (e.CategoryName == null)
			{
				if (e.IsPropertyCategoryNameRemoved)
				{
					this.CategoryName = default(string);
				}
			}
			else
			{
				this.CategoryName = e.CategoryName;
			}

			if (e.Description == null)
			{
				if (e.IsPropertyDescriptionRemoved)
				{
					this.Description = default(string);
				}
			}
			else
			{
				this.Description = e.Description;
			}

			if (e.CategoryImageUrl == null)
			{
				if (e.IsPropertyCategoryImageUrlRemoved)
				{
					this.CategoryImageUrl = default(string);
				}
			}
			else
			{
				this.CategoryImageUrl = e.CategoryImageUrl;
			}

			if (e.DetailScreen == null)
			{
				if (e.IsPropertyDetailScreenRemoved)
				{
					this.DetailScreen = default(string);
				}
			}
			else
			{
				this.DetailScreen = e.DetailScreen;
			}

			if (e.ShowInSelect == null)
			{
				if (e.IsPropertyShowInSelectRemoved)
				{
					this.ShowInSelect = default(bool);
				}
			}
			else
			{
				this.ShowInSelect = (e.ShowInSelect != null && e.ShowInSelect.HasValue) ? e.ShowInSelect.Value : default(bool);
			}

			if (e.AttributeSetId == null)
			{
				if (e.IsPropertyAttributeSetIdRemoved)
				{
					this.AttributeSetId = default(string);
				}
			}
			else
			{
				this.AttributeSetId = e.AttributeSetId;
			}

			if (e.Active == null)
			{
				if (e.IsPropertyActiveRemoved)
				{
					this.Active = default(bool);
				}
			}
			else
			{
				this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);
			}


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


		}

		public virtual void When(IProductCategoryStateDeleted e)
		{
			ThrowOnWrongEvent(e);

			this.Deleted = true;
			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;

		}


		public virtual void Mutate(IEvent e)
		{
            StateReadOnly = false;
			((dynamic)this).When((dynamic)e);
		}

        protected void ThrowOnWrongEvent(IProductCategoryStateEvent stateEvent)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("ProductCategory|");

            var stateEntityId = this.ProductCategoryId; // Aggregate Id
            var eventEntityId = stateEvent.StateEventId.ProductCategoryId; // EntityBase.Aggregate.GetStateEventIdPropertyIdName();
            if (stateEntityId != eventEntityId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
            }
            id.Append(stateEntityId).Append(",");

            id.Append("]");

            var stateVersion = this.Version;
            var eventVersion = stateEvent.StateEventId.Version;
            if (stateVersion > eventVersion)//!=
            {
                throw OptimisticConcurrencyException.Create(stateVersion, eventVersion, id.ToString());
            }
        }
    }

}

