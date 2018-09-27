﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateProductDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Product;

namespace Dddml.Wms.Domain.Product
{

    public class GoodIdentificationStates : IGoodIdentificationStates
    {
        
		protected IGoodIdentificationStateDao GoodIdentificationStateDao
		{
			get
			{
				return ApplicationContext.Current["GoodIdentificationStateDao"] as IGoodIdentificationStateDao;
			}
		}

		private Dictionary<ProductGoodIdentificationId, IGoodIdentificationState> _loadedGoodIdentificationStates = new Dictionary<ProductGoodIdentificationId, IGoodIdentificationState>();

		private Dictionary<ProductGoodIdentificationId, IGoodIdentificationState> _removedGoodIdentificationStates = new Dictionary<ProductGoodIdentificationId, IGoodIdentificationState>();

		protected virtual IEnumerable<IGoodIdentificationState> LoadedGoodIdentificationStates {
			get {
				return this._loadedGoodIdentificationStates.Values;
			}
		}

        private IProductState _productState;

        private IEnumerable<IGoodIdentificationState> InnerEnumeralbe
        {
            get
            {
                if (!ForReapplying)
                {
                    return GoodIdentificationStateDao.FindByProductId(_productState.ProductId);
                }
                else
                {
                    return _loadedGoodIdentificationStates.Values.Where(s => !(_removedGoodIdentificationStates.ContainsKey(s.GlobalId) && s.Deleted));
                }
            }
        }

        private bool _forReapplying;

        public virtual bool ForReapplying
        {
            get { return _forReapplying; }
            set { _forReapplying = value; } 
        }

        public GoodIdentificationStates(IProductState outerState)
        {
            this._productState = outerState;
            this._forReapplying = outerState.ForReapplying;
        }

        public IEnumerator<IGoodIdentificationState> GetEnumerator()
        {
            return InnerEnumeralbe.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return InnerEnumeralbe.GetEnumerator();
        }

        public virtual void Remove(IGoodIdentificationState state)
        {
            this._removedGoodIdentificationStates.Add(state.GlobalId, state);
        }

        public virtual IGoodIdentificationState Get(string goodIdentificationTypeId)
		{
			return Get(goodIdentificationTypeId, false, false);
		}

        public virtual IGoodIdentificationState Get(string goodIdentificationTypeId, bool forCreation)
        {
			return Get(goodIdentificationTypeId, forCreation, false);
        }

        public virtual IGoodIdentificationState Get(string goodIdentificationTypeId, bool forCreation, bool nullAllowed)
        {
            ProductGoodIdentificationId globalId = new ProductGoodIdentificationId(_productState.ProductId, goodIdentificationTypeId);
            if (_loadedGoodIdentificationStates.ContainsKey(globalId)) {
                var state = _loadedGoodIdentificationStates[globalId];
                if (this._productState != null && this._productState.ReadOnly == false) { ((IGoodIdentificationState)state).ReadOnly = false; }
                return state;
            }
            if (forCreation || ForReapplying)
            {
                var state = new GoodIdentificationState(ForReapplying);
                state.ProductGoodIdentificationId = globalId;
                _loadedGoodIdentificationStates.Add(globalId, state);
                if (this._productState != null && this._productState.ReadOnly == false) { ((IGoodIdentificationState)state).ReadOnly = false; }
                return state;
            }
            else
            {
                var state = GoodIdentificationStateDao.Get(globalId, nullAllowed);
                if (state != null)
                {
                    _loadedGoodIdentificationStates.Add(globalId, state);
                }
                if (this._productState != null && this._productState.ReadOnly == false) { ((IGoodIdentificationState)state).ReadOnly = false; }
                return state;
            }
        }

        public virtual void AddToSave(IGoodIdentificationState state)
        {
            this._loadedGoodIdentificationStates[state.GlobalId] = state;
        }

		#region Saveable Implements

		public virtual void Save ()
		{
			foreach (IGoodIdentificationState s in this.LoadedGoodIdentificationStates) {
                GoodIdentificationStateDao.Save(s);
			}
            foreach(IGoodIdentificationState s in this._removedGoodIdentificationStates.Values)
            {
                GoodIdentificationStateDao.Delete(s);
            }
		}

		#endregion


    }



}

