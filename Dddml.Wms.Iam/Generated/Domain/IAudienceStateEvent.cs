﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{
	public interface IAudienceStateEvent : IEvent, IStateEventDto, IGlobalIdentity<AudienceStateEventId>, ICreated<string>
	{
		AudienceStateEventId StateEventId { get; }

        bool ReadOnly { get; set; }

		string Name { get; set; }

		string Base64Secret { get; set; }

		bool? Active { get; set; }

	}

	public interface IAudienceStateCreated : IAudienceStateEvent//, IAudienceStateProperties
	{
	
	}


	public interface IAudienceStateMergePatched : IAudienceStateEvent//, IAudienceStateProperties
	{
		bool IsPropertyNameRemoved { get; set; }

		bool IsPropertyBase64SecretRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IAudienceStateDeleted : IAudienceStateEvent
	{
	}


}
