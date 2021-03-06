﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSet;

namespace Dddml.Wms.Domain.AttributeSet
{

    public class AttributeUseStates : IAttributeUseStates
    {
        
		protected IAttributeUseStateDao AttributeUseStateDao
		{
			get
			{
				return ApplicationContext.Current["AttributeUseStateDao"] as IAttributeUseStateDao;
			}
		}

		private Dictionary<AttributeSetAttributeUseId, IAttributeUseState> _loadedAttributeUseStates = new Dictionary<AttributeSetAttributeUseId, IAttributeUseState>();

		private Dictionary<AttributeSetAttributeUseId, IAttributeUseState> _removedAttributeUseStates = new Dictionary<AttributeSetAttributeUseId, IAttributeUseState>();

		protected virtual IEnumerable<IAttributeUseState> LoadedAttributeUseStates {
			get {
				return this._loadedAttributeUseStates.Values;
			}
		}

        private IAttributeSetState _attributeSetState;

        private IEnumerable<IAttributeUseState> InnerEnumeralbe
        {
            get
            {
                if (!ForReapplying)
                {
                    return AttributeUseStateDao.FindByAttributeSetId(_attributeSetState.AttributeSetId);
                }
                else
                {
                    return _loadedAttributeUseStates.Values.Where(s => !(_removedAttributeUseStates.ContainsKey(s.GlobalId) && s.Deleted));
                }
            }
        }

        private bool _forReapplying;

        public virtual bool ForReapplying
        {
            get { return _forReapplying; }
            set { _forReapplying = value; } 
        }

        public AttributeUseStates(IAttributeSetState outerState)
        {
            this._attributeSetState = outerState;
            this._forReapplying = outerState.ForReapplying;
        }

        public IEnumerator<IAttributeUseState> GetEnumerator()
        {
            return InnerEnumeralbe.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return InnerEnumeralbe.GetEnumerator();
        }

        public virtual void Remove(IAttributeUseState state)
        {
            this._removedAttributeUseStates.Add(state.GlobalId, state);
        }

        public virtual IAttributeUseState Get(string attributeId)
		{
			return Get(attributeId, false, false);
		}

        public virtual IAttributeUseState Get(string attributeId, bool forCreation)
        {
			return Get(attributeId, forCreation, false);
        }

        public virtual IAttributeUseState Get(string attributeId, bool forCreation, bool nullAllowed)
        {
            AttributeSetAttributeUseId globalId = new AttributeSetAttributeUseId(_attributeSetState.AttributeSetId, attributeId);
            if (_loadedAttributeUseStates.ContainsKey(globalId)) {
                var state = _loadedAttributeUseStates[globalId];
                if (this._attributeSetState != null && this._attributeSetState.ReadOnly == false) { ((IAttributeUseState)state).ReadOnly = false; }
                return state;
            }
            if (forCreation || ForReapplying)
            {
                var state = new AttributeUseState(ForReapplying);
                state.AttributeSetAttributeUseId = globalId;
                _loadedAttributeUseStates.Add(globalId, state);
                if (this._attributeSetState != null && this._attributeSetState.ReadOnly == false) { ((IAttributeUseState)state).ReadOnly = false; }
                return state;
            }
            else
            {
                var state = AttributeUseStateDao.Get(globalId, nullAllowed);
                if (state != null)
                {
                    _loadedAttributeUseStates.Add(globalId, state);
                }
                if (this._attributeSetState != null && this._attributeSetState.ReadOnly == false) { ((IAttributeUseState)state).ReadOnly = false; }
                return state;
            }
        }

        public virtual void AddToSave(IAttributeUseState state)
        {
            this._loadedAttributeUseStates[state.GlobalId] = state;
        }

		#region Saveable Implements

		public virtual void Save ()
		{
			foreach (IAttributeUseState s in this.LoadedAttributeUseStates) {
                AttributeUseStateDao.Save(s);
			}
            foreach(IAttributeUseState s in this._removedAttributeUseStates.Values)
            {
                AttributeUseStateDao.Delete(s);
            }
		}

		#endregion


    }



}


