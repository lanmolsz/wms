﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Movement;

namespace Dddml.Wms.Domain.Movement
{

	public class MovementLineId
	{

		private string _movementDocumentNumber;

		public virtual string MovementDocumentNumber { 
			get { return this._movementDocumentNumber; } 
			set { _movementDocumentNumber = value; } 
		}

		private string _lineNumber;

		public virtual string LineNumber { 
			get { return this._lineNumber; } 
			set { _lineNumber = value; } 
		}


        #region  Flattened Properties


        #endregion

		public MovementLineId ()
		{
		}

		public MovementLineId (string movementDocumentNumber, string lineNumber)
		{
			this._movementDocumentNumber = movementDocumentNumber;
			this._lineNumber = lineNumber;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			MovementLineId other = obj as MovementLineId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.MovementDocumentNumber, other.MovementDocumentNumber)
				&& Object.Equals (this.LineNumber, other.LineNumber)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.MovementDocumentNumber != null) {
				hash += 13 * this.MovementDocumentNumber.GetHashCode ();
			}
			if (this.LineNumber != null) {
				hash += 13 * this.LineNumber.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(MovementLineId obj1, MovementLineId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(MovementLineId obj1, MovementLineId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override string ToString()
        {
            return String.Empty
                + "MovementDocumentNumber: " + this.MovementDocumentNumber + ", "
                + "LineNumber: " + this.LineNumber + ", "
                ;
        }

        protected internal static readonly string[] FlattenedPropertyNames = new string[] { "MovementDocumentNumber", "LineNumber" };

        protected internal static readonly Type[] FlattenedPropertyTypes = new Type[] { typeof(string), typeof(string) };

        protected internal static readonly IDictionary<string, Type> FlattenedPropertyTypeDictionary;

        static MovementLineId()
        {
            var dict = new Dictionary<string, Type>();
            for (int i = 0; i < FlattenedPropertyNames.Length; i++)
            {
                dict.Add(FlattenedPropertyNames[i], FlattenedPropertyTypes[i]);
            }
            FlattenedPropertyTypeDictionary = dict;
        }

        protected internal void ForEachFlattenedProperty(Action<string, object> act)
        {
            for (int i = 0; i < FlattenedPropertyNames.Length; i++)
            {
                string pn = FlattenedPropertyNames[i];
                if (Char.IsLower(pn[0])) { pn = Char.ToUpper(pn[0]) + pn.Substring(1); }
                var m = this.GetType().GetProperty(pn, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                object pv = m.GetValue(this);
                act(pn, pv);
            }
        }

        protected internal void SetFlattenedPropertyValues(params object[] values)
        {
            for (int i = 0; i < FlattenedPropertyNames.Length; i++)
            {
                string pn = FlattenedPropertyNames[i];
                if (Char.IsLower(pn[0])) { pn = Char.ToUpper(pn[0]) + pn.Substring(1); }
                var v = values[i];
                var m = this.GetType().GetProperty(pn, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                m.SetValue(this, v);
            }
        }
	}

}


