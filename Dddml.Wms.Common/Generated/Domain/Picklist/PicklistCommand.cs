﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Picklist;
using Dddml.Wms.Domain.PartyRole;

namespace Dddml.Wms.Domain.Picklist
{

	public abstract class PicklistCommandBase : IPicklistCommand
	{
		public virtual string PicklistId { get; set; }


		string IAggregateCommand<string, long>.AggregateId
		{
			get
			{
				return this.PicklistId;
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

		public virtual string RequesterId { get; set; }

		public virtual string CommandId { get; set; }

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

		public virtual string Description { get; set; }

		public virtual string FacilityId { get; set; }

		public virtual string ShipmentMethodTypeId { get; set; }

		public virtual string StatusId { get; set; }

		public virtual DateTime? PicklistDate { get; set; }

		public virtual long? PickwaveId { get; set; }

		public virtual bool? Active { get; set; }


		// //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();


	}


	public class CreatePicklist : PicklistCommandBase, ICreatePicklist
	{
		
		public CreatePicklist ()
		{
		}


        private CreatePicklistRoleCommands _picklistRoles = new CreatePicklistRoleCommands();

        public ICreatePicklistRoleCommands PicklistRoles
        {
            get
            {
                return this._picklistRoles;
            }
        }

        public CreatePicklistRole NewCreatePicklistRole()
        {
            var c = new CreatePicklistRole();
            c.PicklistId = this.PicklistId;

            return c;
        }

        ICreatePicklistRole ICreatePicklist.NewCreatePicklistRole()
        {
            return this.NewCreatePicklistRole();
        }



        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }
	}


	public class MergePatchPicklist :PicklistCommandBase, IMergePatchPicklist
	{

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyFacilityIdRemoved { get; set; }

		public virtual bool IsPropertyShipmentMethodTypeIdRemoved { get; set; }

		public virtual bool IsPropertyStatusIdRemoved { get; set; }

		public virtual bool IsPropertyPicklistDateRemoved { get; set; }

		public virtual bool IsPropertyPickwaveIdRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public MergePatchPicklist ()
		{
		}

        private PicklistRoleCommands _picklistRoleCommands = new PicklistRoleCommands();

        public IPicklistRoleCommands PicklistRoleCommands
        {
            get
            {
                return this._picklistRoleCommands;
            }
        }


        public CreatePicklistRole NewCreatePicklistRole()
        {
            var c = new CreatePicklistRole();
            c.PicklistId = this.PicklistId;

            return c;
        }

        ICreatePicklistRole IMergePatchPicklist.NewCreatePicklistRole()
        {
            return this.NewCreatePicklistRole();
        }

        public MergePatchPicklistRole NewMergePatchPicklistRole()
        {
            var c = new MergePatchPicklistRole();
            c.PicklistId = this.PicklistId;

            return c;
        }

        IMergePatchPicklistRole IMergePatchPicklist.NewMergePatchPicklistRole()
        {
            return this.NewMergePatchPicklistRole();
        }


        public RemovePicklistRole NewRemovePicklistRole()
        {
            var c = new RemovePicklistRole();
            c.PicklistId = this.PicklistId;

            return c;
        }

        IRemovePicklistRole IMergePatchPicklist.NewRemovePicklistRole()
        {
            return this.NewRemovePicklistRole();
        }


        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeletePicklist : PicklistCommandBase, IDeletePicklist
	{
		public DeletePicklist ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }

	}


    public class CreatePicklistRoleCommands : ICreatePicklistRoleCommands
    {
        private List<ICreatePicklistRole> _innerCommands = new List<ICreatePicklistRole>();

        public void Add(ICreatePicklistRole c)
        {
            _innerCommands.Add(c);
        }

        public void Remove(ICreatePicklistRole c)
        {
            _innerCommands.Remove(c);
        }

        public void Clear()
        {
            _innerCommands.Clear();
        }

        public IEnumerator<ICreatePicklistRole> GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }

    public class PicklistRoleCommands : IPicklistRoleCommands
    {
        private List<IPicklistRoleCommand> _innerCommands = new List<IPicklistRoleCommand>();

        public void Add(IPicklistRoleCommand c)
        {
            _innerCommands.Add(c);
        }

        public void Remove(IPicklistRoleCommand c)
        {
            _innerCommands.Remove(c);
        }

        public void Clear()
        {
            _innerCommands.Clear();
        }

        public IEnumerator<IPicklistRoleCommand> GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }

    public static partial class PicklistCommands
    {
    }

}