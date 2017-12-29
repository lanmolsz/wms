﻿using Dddml.Wms.HttpServices.ApiControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Services;
using Dddml.Wms.Specialization;
using Dynamitey;
using Dddml.Wms.Domain.AttributeSetInstance;


namespace Dddml.Wms.HttpServices.ApiControllers
{
    public class AttributeSetInstanceDtoJObjectMapper : AttributeSetInstanceDtoJObjectMapperBase
    {
        public IAttributeSetService AttributeSetService { get; set; }

        protected override void MapDynamicProperties(JObject dynamicObject, CreateAttributeSetInstanceDto command)
        {
            var pDic = AttributeSetService.GetPropertyExtensionFieldDictionary(command.AttributeSetId);
            MapExtensionProperties(dynamicObject, command, pDic, null);
        }

        protected override void MapDynamicProperties(JObject dynamicObject, MergePatchAttributeSetInstanceDto command)
        {
            var pDic = AttributeSetService.GetPropertyExtensionFieldDictionary(command.AttributeSetId);
            MapExtensionProperties(dynamicObject, command, pDic, null);
            var propertyRemovedFormat = "IsProperty{0}Removed";
            MapExtensionProperties(dynamicObject, command, pDic, propertyRemovedFormat);
        }

        protected override void MapDynamicProperties(IAttributeSetInstanceStateDto state, JObject dynamicObject)
        {
            var pDic = AttributeSetService.GetPropertyExtensionFieldDictionary(state.AttributeSetId);
            MapExtensionProperties(state, dynamicObject, pDic, null);
        }


        //protected override JObject NewJObject(IAttributeSetInstanceStateDto state)
        //{
        //    dynamic dynamicObject = new JObject();
        //    return dynamicObject;
        //}

        /// <summary>
        /// Map Extension properties.
        /// </summary>
        /// <param name="dynamicObject">Source object.</param>
        /// <param name="command">Target object.</param>
        /// <param name="propertyFieldDictionary">Extension propertyName-to-underlyingFieldName dictionary.</param>
        private static void MapExtensionProperties(JObject dynamicObject, CreateOrMergePatchOrDeleteAttributeSetInstanceDto command, IDictionary<string, string> propertyFieldDictionary, string nameFormat)
        {
            foreach (var p in propertyFieldDictionary)
            {
                var propertyName = (nameFormat == null) ? p.Key : String.Format(nameFormat, p.Key);
                var fieldName = (nameFormat == null) ? p.Value : String.Format(nameFormat, p.Value);
                var pVal = dynamicObject.GetValue(propertyName, StringComparison.InvariantCultureIgnoreCase);
                if (pVal != null)
                {
                    var fieldType = command.GetType().GetProperty(fieldName).PropertyType;
                    Dynamic.InvokeSet(command, fieldName, pVal.ToObject(fieldType));
                }
            }
        }

        private static void MapExtensionProperties(IAttributeSetInstanceStateDto state, JObject dynamicObject, IDictionary<string, string> propertyFieldDictionary, string nameFormat)
        {
            foreach (var p in propertyFieldDictionary)
            {
                var propertyName = (nameFormat == null) ? p.Key : String.Format(nameFormat, p.Key);
                var fieldName = (nameFormat == null) ? p.Value : String.Format(nameFormat, p.Value);
                var pVal = Dynamic.InvokeGet(state, fieldName);
                if (pVal != null)
                {
                    Dynamic.InvokeSet(dynamicObject, propertyName, pVal);
                }
            }
        }

    }

}