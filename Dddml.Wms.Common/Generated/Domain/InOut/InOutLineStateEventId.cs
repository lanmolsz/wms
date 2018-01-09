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

	public class InOutLineStateEventId
	{

		private string _inOutDocumentNumber;

		public virtual string InOutDocumentNumber { 
			get { return this._inOutDocumentNumber; } 
			internal set { _inOutDocumentNumber = value; } 
		}

		private string _lineNumber;

		public virtual string LineNumber { 
			get { return this._lineNumber; } 
			internal set { _lineNumber = value; } 
		}

		private long _inOutVersion;

		public virtual long InOutVersion { 
			get { return this._inOutVersion; } 
			internal set { _inOutVersion = value; } 
		}


        #region  Flattened Properties


        #endregion

		internal InOutLineStateEventId ()
		{
		}

		public InOutLineStateEventId (string inOutDocumentNumber, string lineNumber, long inOutVersion)
		{
			this._inOutDocumentNumber = inOutDocumentNumber;
			this._lineNumber = lineNumber;
			this._inOutVersion = inOutVersion;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			InOutLineStateEventId other = obj as InOutLineStateEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.InOutDocumentNumber, other.InOutDocumentNumber)
				&& Object.Equals (this.LineNumber, other.LineNumber)
				&& Object.Equals (this.InOutVersion, other.InOutVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.InOutDocumentNumber != null) {
				hash += 13 * this.InOutDocumentNumber.GetHashCode ();
			}
			if (this.LineNumber != null) {
				hash += 13 * this.LineNumber.GetHashCode ();
			}
			if (this.InOutVersion != null) {
				hash += 13 * this.InOutVersion.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(InOutLineStateEventId obj1, InOutLineStateEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(InOutLineStateEventId obj1, InOutLineStateEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override string ToString()
        {
            return String.Empty
                + "InOutDocumentNumber: " + this.InOutDocumentNumber + ", "
                + "LineNumber: " + this.LineNumber + ", "
                + "InOutVersion: " + this.InOutVersion + ", "
                ;
        }
	}

}


