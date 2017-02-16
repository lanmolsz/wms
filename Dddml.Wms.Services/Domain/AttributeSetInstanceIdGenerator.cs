﻿using Dddml.Wms.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Dddml.Wms.Domain
{
   
    public class AttributeSetInstanceIdGenerator : AttributeSetInstanceIdGeneratorBase
    {
        public IAttributeSetInstanceStateQueryRepository AttributeSetInstanceStateQueryRepository { get; set; }

        public override string GenerateId(ICreateAttributeSetInstance command)
        {
            throw new NotSupportedException();
        }

        public override string GetOrGenerateId(ICreateAttributeSetInstance command, out bool reused)
        {
            string hash = AttributeSetInstancePropertyUtils.GetHash(command);
            command.Hash = hash;

            IAttributeSetInstanceState old = AttributeSetInstanceStateQueryRepository.GetFirst(new KeyValuePair<string, object>("Hash", hash));
            if (old != null)
            {
                if (AttributeSetInstancePropertyUtils.Equals((ICreateAttributeSetInstance)command, (IAttributeSetInstanceState)old))
                {
                    reused = true;
                    return old.AttributeSetInstanceId;
                }
            }
            reused = false;
            return GetNextId();
        }

        public override string GetNextId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
