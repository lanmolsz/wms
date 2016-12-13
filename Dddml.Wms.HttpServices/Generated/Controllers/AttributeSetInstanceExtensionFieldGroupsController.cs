﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAggregatesControllers.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Metadata;
using Dddml.Wms.HttpServices.Filters;
using System.Linq;
using System.Net;
using System.ComponentModel;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using Dddml.Support.Criterion;

namespace Dddml.Wms.HttpServices.ApiControllers
{

    [RoutePrefix("api/AttributeSetInstanceExtensionFieldGroups")][Authorize]
    public partial class AttributeSetInstanceExtensionFieldGroupsController : ApiController
    {

        IAttributeSetInstanceExtensionFieldGroupApplicationService _attributeSetInstanceExtensionFieldGroupApplicationService = ApplicationContext.Current["AttributeSetInstanceExtensionFieldGroupApplicationService"] as IAttributeSetInstanceExtensionFieldGroupApplicationService;

        [Route(Order = 1)]
        [HttpGet]
        public IEnumerable<IAttributeSetInstanceExtensionFieldGroupStateDto> GetAll(string sort = null, string fields = null, int firstResult = 0, int maxResults = int.MaxValue, string filter = null)
        {
          try {
            IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> states = null; 
            if (!String.IsNullOrWhiteSpace(filter))
            {
                states = _attributeSetInstanceExtensionFieldGroupApplicationService.Get(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(),new ApiControllerTypeConverter(), new PropertyTypeResolver())
                    , AttributeSetInstanceExtensionFieldGroupsControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            else 
            {
                states = _attributeSetInstanceExtensionFieldGroupApplicationService.Get(AttributeSetInstanceExtensionFieldGroupsControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs())
                    , AttributeSetInstanceExtensionFieldGroupsControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            var stateDtos = new List<IAttributeSetInstanceExtensionFieldGroupStateDto>();
            foreach (var s in states)
            {
                var dto = s is AttributeSetInstanceExtensionFieldGroupStateDtoWrapper ? (AttributeSetInstanceExtensionFieldGroupStateDtoWrapper)s : new AttributeSetInstanceExtensionFieldGroupStateDtoWrapper(s);
                if (String.IsNullOrWhiteSpace(fields))
                {
                    dto.AllFieldsReturned = true;
                }
                else
                {
                    dto.ReturnedFieldsString = fields;
                }
                stateDtos.Add(dto);
            }
            return stateDtos;
          } catch (Exception ex) { var response = AttributeSetInstanceExtensionFieldGroupsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpGet]
        public IAttributeSetInstanceExtensionFieldGroupStateDto Get(string id, string fields = null)
        {
          try {
            var idObj = id;
            var state = _attributeSetInstanceExtensionFieldGroupApplicationService.Get(idObj);
            if (state == null) { return null; }
            var stateDto = new AttributeSetInstanceExtensionFieldGroupStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = AttributeSetInstanceExtensionFieldGroupsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }


        [Route("_count")]
        [HttpGet]
        public long GetCount(string filter = null)
        {
          try
          {
            long count = 0;
            if (!String.IsNullOrWhiteSpace(filter))
            {
                count = _attributeSetInstanceExtensionFieldGroupApplicationService.GetCount(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(),new ApiControllerTypeConverter(), new PropertyTypeResolver()));
            }
            else 
            {
                count = _attributeSetInstanceExtensionFieldGroupApplicationService.GetCount(AttributeSetInstanceExtensionFieldGroupsControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs()));
            }
            return count;
          } catch (Exception ex) { var response = AttributeSetInstanceExtensionFieldGroupsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPut][SetRequesterId]
        public void Put(string id, [FromBody]CreateAttributeSetInstanceExtensionFieldGroupDto value)
        {
          try {
            AttributeSetInstanceExtensionFieldGroupsControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _attributeSetInstanceExtensionFieldGroupApplicationService.When(value as ICreateAttributeSetInstanceExtensionFieldGroup);
          } catch (Exception ex) { var response = AttributeSetInstanceExtensionFieldGroupsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPatch][SetRequesterId]
        public void Patch(string id, [FromBody]MergePatchAttributeSetInstanceExtensionFieldGroupDto value)
        {
          try {
            AttributeSetInstanceExtensionFieldGroupsControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _attributeSetInstanceExtensionFieldGroupApplicationService.When(value as IMergePatchAttributeSetInstanceExtensionFieldGroup);
          } catch (Exception ex) { var response = AttributeSetInstanceExtensionFieldGroupsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpDelete][SetRequesterId]
        public void Delete(string id, string commandId, string version, string requesterId = default(string))
        {
          try {
            var value = new DeleteAttributeSetInstanceExtensionFieldGroupDto();
            value.CommandId = commandId;
            value.RequesterId = requesterId;
            value.Version = (long)Convert.ChangeType(version, typeof(long));
            AttributeSetInstanceExtensionFieldGroupsControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _attributeSetInstanceExtensionFieldGroupApplicationService.When(value as IDeleteAttributeSetInstanceExtensionFieldGroup);
          } catch (Exception ex) { var response = AttributeSetInstanceExtensionFieldGroupsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("_metadata/filteringFields")]
        [HttpGet]
        public IEnumerable<PropertyMetadata> GetMetadataFilteringFields()
        {
          try {
            var filtering = new List<PropertyMetadata>();
            foreach (var p in AttributeSetInstanceExtensionFieldGroupMetadata.Instance.Properties)
            {
                if (p.IsFilteringProperty)
                {
                    filtering.Add(p);
                }
            }
            return filtering;
          } catch (Exception ex) { var response = AttributeSetInstanceExtensionFieldGroupsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_stateEvents/{version}")]
        [HttpGet]
        public AttributeSetInstanceExtensionFieldGroupStateCreatedOrMergePatchedOrDeletedDto GetStateEvent(string id, long version)
        {
          try {
            var idObj = id;
            var conv = new AttributeSetInstanceExtensionFieldGroupStateEventDtoConverter();
            var se = _attributeSetInstanceExtensionFieldGroupApplicationService.GetStateEvent(idObj, version);
            return se == null ? null : conv.ToAttributeSetInstanceExtensionFieldGroupStateEventDto(se);
          } catch (Exception ex) { var response = AttributeSetInstanceExtensionFieldGroupsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_historyStates/{version}")]
        [HttpGet]
        public IAttributeSetInstanceExtensionFieldGroupStateDto GetHistoryState(string id, long version, string fields = null)
        {
          try {
            var idObj = id;
            var state = _attributeSetInstanceExtensionFieldGroupApplicationService.GetHistoryState(idObj, version);
            if (state == null) { return null; }
            var stateDto = new AttributeSetInstanceExtensionFieldGroupStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = AttributeSetInstanceExtensionFieldGroupsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{groupId}/AttributeSetInstanceExtensionFields/{index}")]
        [HttpGet]
        public IAttributeSetInstanceExtensionFieldStateDto GetAttributeSetInstanceExtensionField(string groupId, string index)
        {
          try {
            var state = (AttributeSetInstanceExtensionFieldState)_attributeSetInstanceExtensionFieldGroupApplicationService.GetAttributeSetInstanceExtensionField(groupId, index);
            if (state == null) { return null; }
            var stateDto = new AttributeSetInstanceExtensionFieldStateDtoWrapper(state);
            stateDto.AllFieldsReturned = true;
            return stateDto;
          } catch (Exception ex) { var response = AttributeSetInstanceExtensionFieldGroupsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }


		// /////////////////////////////////////////////////

        protected virtual string QueryOrderSeparator
        {
            get { return ","; }
        }

        // ////////////////////////////////

        private class ApiControllerTypeConverter : Dddml.Support.Criterion.ITypeConverter
        {
            public T ConvertFromString<T>(string text)
            {
                return (T)ApplicationContext.Current.TypeConverter.ConvertFromString(typeof(T), text);
            }

            public object ConvertFromString(Type type, string text)
            {
                return ApplicationContext.Current.TypeConverter.ConvertFromString(type, text);
            }

            public string ConvertToString<T>(T value)
            {
                return ApplicationContext.Current.TypeConverter.ConvertToString(typeof(T), value);
            }

            public string ConvertToString(object value)
            {
                return ApplicationContext.Current.TypeConverter.ConvertToString(value.GetType(), value);
            }

            public string[] ConvertToStringArray(object[] values)
            {
                throw new NotSupportedException();
            }
        }

        private class PropertyTypeResolver : IPropertyTypeResolver
        {

            public Type ResolveTypeByPropertyName(string propertyName)
            {
                return AttributeSetInstanceExtensionFieldGroupsControllerUtils.GetFilterPropertyType(propertyName);
            }
        }

    }


    
    public static class AttributeSetInstanceExtensionFieldGroupsControllerUtils
    {

        public static HttpResponseMessage GetErrorHttpResponseMessage(Exception ex)
        {
            var errorName = ex.GetType().Name;
            var errorMessage = ex.Message;
            if (ex is DomainError)
            {
                DomainError de = ex as DomainError;
                errorName = de.Name;
                errorMessage = de.Message;
            }
            else
            {
                //改进??
                errorMessage = String.IsNullOrWhiteSpace(ex.Message) ? String.Empty : ex.Message.Substring(0, (ex.Message.Length > 140) ? 140 : ex.Message.Length);
            }
            dynamic content = new JObject();
            content.ErrorName = errorName;
            content.ErrorMessage = errorMessage;
            var response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
            {
                Content = new ObjectContent<JObject>(content as JObject, new JsonMediaTypeFormatter()),
                ReasonPhrase = "Server Error"
            };
            return response;
        }

        public static void SetNullIdOrThrowOnInconsistentIds(string id, CreateOrMergePatchOrDeleteAttributeSetInstanceExtensionFieldGroupDto value)
        {
            var idObj = id;
            if (value.Id == null)
            {
                value.Id = idObj;
            }
            else if (!((ICreateOrMergePatchOrDeleteAttributeSetInstanceExtensionFieldGroup)value).Id.Equals(idObj))
            {
                throw DomainError.Named("inconsistentId", "Argument Id {0} NOT equals body Id {1}", id, value.Id);
            }
        }


        public static string GetFilterPropertyName(string fieldName)
        {
            if (String.Equals(fieldName, "sort", StringComparison.InvariantCultureIgnoreCase)
                || String.Equals(fieldName, "firstResult", StringComparison.InvariantCultureIgnoreCase)
                || String.Equals(fieldName, "maxResults", StringComparison.InvariantCultureIgnoreCase)
                || String.Equals(fieldName, "fields", StringComparison.InvariantCultureIgnoreCase))
            {
                return null;
            }
            if (AttributeSetInstanceExtensionFieldGroupMetadata.Instance.PropertyMetadataDictionary.ContainsKey(fieldName))
            {
                var p = AttributeSetInstanceExtensionFieldGroupMetadata.Instance.PropertyMetadataDictionary[fieldName];
                if (p.IsFilteringProperty)
                {
                    var propertyName = fieldName;
                    if (p.IsDerived)
                    {
                        propertyName = p.DerivedFrom;
                    }
                    return propertyName;
                }
            }
            return null;
        }

        public static Type GetFilterPropertyType(string propertyName)
        {
            if (AttributeSetInstanceExtensionFieldGroupMetadata.Instance.PropertyMetadataDictionary.ContainsKey(propertyName))
            {
                return AttributeSetInstanceExtensionFieldGroupMetadata.Instance.PropertyMetadataDictionary[propertyName].Type;
            }
            return typeof(string);
        }

        public static IDictionary<string, object> GetQueryFilterDictionary(IEnumerable<KeyValuePair<string, string>> queryNameValuePairs)
        {
            var filter = new Dictionary<string, object>();
            foreach (var p in queryNameValuePairs)
            {
                var pName = GetFilterPropertyName(p.Key);
                if (!String.IsNullOrWhiteSpace(pName))
                {
                    Type type = GetFilterPropertyType(pName);
                    var pValue = ApplicationContext.Current.TypeConverter.ConvertFromString(type, p.Value);
                    filter.Add(pName, pValue);
                }
            }
            return filter;
        }

        public static IList<string> GetQueryOrders(string str, string separator)
        {
            if (String.IsNullOrWhiteSpace(str))
            {
                return new string[0];
            }
            var arr = str.Split(new string[] { separator }, StringSplitOptions.RemoveEmptyEntries);
            var orders = new List<string>();
            foreach (var a in arr)
            {
                orders.Add(a.Trim());
            }
            return orders;
        }

        public static IEnumerable<IAttributeSetInstanceExtensionFieldGroupStateDto> ToAttributeSetInstanceExtensionFieldGroupStateDtoCollection(IEnumerable<string> ids)
        {
            var states = new List<IAttributeSetInstanceExtensionFieldGroupStateDto>();
            foreach (var id in ids)
            {
                var dto = new AttributeSetInstanceExtensionFieldGroupStateDtoWrapper();
                dto.Id = id;
                states.Add(dto);
            }
            return states;
        }

        public static IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> ToAttributeSetInstanceExtensionFieldGroupStateCollection(IEnumerable<string> ids)
        {
            var states = new List<AttributeSetInstanceExtensionFieldGroupState>();
            foreach (var id in ids)
            {
                var s = new AttributeSetInstanceExtensionFieldGroupState();
                s.Id = id;
                states.Add(s);
            }
            return states;
        }

    }

}

