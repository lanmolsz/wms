﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAggregatesControllers.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeValueMvo;
using Dddml.Wms.Domain.Attribute;
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

    [RoutePrefix("api/AttributeValueMvos")]
    public partial class AttributeValueMvosController : ApiController
    {

        IAttributeValueMvoApplicationService _attributeValueMvoApplicationService = ApplicationContext.Current["AttributeValueMvoApplicationService"] as IAttributeValueMvoApplicationService;

        [Route(Order = 1)]
        [HttpGet]
        public IEnumerable<IAttributeValueMvoStateDto> GetAll(string sort = null, string fields = null, int firstResult = 0, int maxResults = int.MaxValue, string filter = null)
        {
          try {
            IEnumerable<IAttributeValueMvoState> states = null; 
            if (!String.IsNullOrWhiteSpace(filter))
            {
                states = _attributeValueMvoApplicationService.Get(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(), new ApiControllerTypeConverter(), new PropertyTypeResolver()
                    , n => (AttributeValueMvoMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(n) ? AttributeValueMvoMetadata.Instance.FilteringPropertyAliasDictionary[n] : n))
                    , AttributeValueMvosControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            else 
            {
                states = _attributeValueMvoApplicationService.Get(AttributeValueMvosControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs())
                    , AttributeValueMvosControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            var stateDtos = new List<IAttributeValueMvoStateDto>();
            foreach (var s in states)
            {
                var dto = s is AttributeValueMvoStateDtoWrapper ? (AttributeValueMvoStateDtoWrapper)s : new AttributeValueMvoStateDtoWrapper(s);
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
          } catch (Exception ex) { var response = AttributeValueMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpGet]
        public IAttributeValueMvoStateDto Get(string id, string fields = null)
        {
          try {
            var idObj = AttributeValueMvosControllerUtils.ParseIdString(id);
            var state = _attributeValueMvoApplicationService.Get(idObj);
            if (state == null) { return null; }
            var stateDto = new AttributeValueMvoStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = AttributeValueMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                count = _attributeValueMvoApplicationService.GetCount(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(), new ApiControllerTypeConverter(), new PropertyTypeResolver()
                    , n => (AttributeValueMvoMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(n) ? AttributeValueMvoMetadata.Instance.FilteringPropertyAliasDictionary[n] : n)));
            }
            else 
            {
                count = _attributeValueMvoApplicationService.GetCount(AttributeValueMvosControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs()));
            }
            return count;
          } catch (Exception ex) { var response = AttributeValueMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route(Order = 1)]
        [HttpPost][SetRequesterId]
        public HttpResponseMessage Post([FromBody]CreateAttributeValueMvoDto value)
        {
          try {
            if (value.AttributeValueId == default(AttributeValueId))
            {
                throw DomainError.Named("nullId", "Aggregate Id in cmd is null, aggregate name: {0}.", "AttributeValueMvo");
            }
            _attributeValueMvoApplicationService.When(value as ICreateAttributeValueMvo);
            var idObj = value.AttributeValueId;

            return Request.CreateResponse<AttributeValueId>(HttpStatusCode.Created, idObj);
          } catch (Exception ex) { var response = AttributeValueMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPut][SetRequesterId]
        public void Put(string id, [FromBody]CreateOrMergePatchOrDeleteAttributeValueMvoDto value)
        {
          try {
              // ///////////////////////////////
              if (value.AttributeVersion != default(long))
              {
                  value.CommandType = CommandType.MergePatch;
                  AttributeValueMvosControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
                  _attributeValueMvoApplicationService.When(value as IMergePatchAttributeValueMvo);
                  return;
              }
              // ///////////////////////////////

            AttributeValueMvosControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _attributeValueMvoApplicationService.When(value as ICreateAttributeValueMvo);
          } catch (Exception ex) { var response = AttributeValueMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPatch][SetRequesterId]
        public void Patch(string id, [FromBody]MergePatchAttributeValueMvoDto value)
        {
          try {
            AttributeValueMvosControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _attributeValueMvoApplicationService.When(value as IMergePatchAttributeValueMvo);
          } catch (Exception ex) { var response = AttributeValueMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpDelete][SetRequesterId]
        public void Delete(string id, string commandId, string version, string requesterId = default(string))
        {
          try {
            var value = new DeleteAttributeValueMvoDto();
            value.CommandId = commandId;
            value.RequesterId = requesterId;
            value.AttributeVersion = (long)Convert.ChangeType(version, typeof(long));
            AttributeValueMvosControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _attributeValueMvoApplicationService.When(value as IDeleteAttributeValueMvo);
          } catch (Exception ex) { var response = AttributeValueMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("_metadata/filteringFields")]
        [HttpGet]
        public IEnumerable<PropertyMetadataDto> GetMetadataFilteringFields()
        {
          try {
            var filtering = new List<PropertyMetadataDto>();
            foreach (var p in AttributeValueMvoMetadata.Instance.Properties)
            {
                if (p.IsFilteringProperty)
                {
                    var pdto = new PropertyMetadataDto(p.Name, p.TypeName, p.IsFilteringProperty,
                       !String.IsNullOrWhiteSpace(p.SourceChainingName) ? p.SourceChainingName :
                       (!String.IsNullOrWhiteSpace(p.DerivedFrom) ? p.DerivedFrom : p.Name));
                    filtering.Add(pdto);
                }
            }
            return filtering;
          } catch (Exception ex) { var response = AttributeValueMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_stateEvents/{version}")]
        [HttpGet]
        public AttributeValueMvoStateCreatedOrMergePatchedOrDeletedDto GetStateEvent(string id, long version)
        {
          try {
            var idObj = AttributeValueMvosControllerUtils.ParseIdString(id);
            var conv = new AttributeValueMvoStateEventDtoConverter();
            var se = _attributeValueMvoApplicationService.GetEvent(idObj, version);
            return se == null ? null : conv.ToAttributeValueMvoStateEventDto(se);
          } catch (Exception ex) { var response = AttributeValueMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_historyStates/{version}")]
        [HttpGet]
        public IAttributeValueMvoStateDto GetHistoryState(string id, long version, string fields = null)
        {
          try {
            var idObj = AttributeValueMvosControllerUtils.ParseIdString(id);
            var state = _attributeValueMvoApplicationService.GetHistoryState(idObj, version);
            if (state == null) { return null; }
            var stateDto = new AttributeValueMvoStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = AttributeValueMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                return AttributeValueMvosControllerUtils.GetFilterPropertyType(propertyName);
            }
        }

    }


    
    public static class AttributeValueMvosControllerUtils
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

        public static void SetNullIdOrThrowOnInconsistentIds(string id, CreateOrMergePatchOrDeleteAttributeValueMvoDto value)
        {
            var idObj = ParseIdString(id.IsNormalized() ? id : id.Normalize());
            if (value.AttributeValueId == null)
            {
                value.AttributeValueId = idObj;
            }
            else if (!((ICreateOrMergePatchOrDeleteAttributeValueMvo)value).AttributeValueId.Equals(idObj))
            {
                throw DomainError.Named("inconsistentId", "Argument Id {0} NOT equals body Id {1}", id, value.AttributeValueId);
            }
        }

        public static AttributeValueId ParseIdString(string idString)
        {
            var formatter = new ValueObjectTextFormatter<AttributeValueId>();
            return formatter.Parse(idString);
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
            if (AttributeValueMvoMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(fieldName))
            {
                return AttributeValueMvoMetadata.Instance.FilteringPropertyAliasDictionary[fieldName];
            }
            return null;
        }

        public static Type GetFilterPropertyType(string propertyName)
        {
            if (AttributeValueMvoMetadata.Instance.PropertyMetadataDictionary.ContainsKey(propertyName))
            {
                return AttributeValueMvoMetadata.Instance.PropertyMetadataDictionary[propertyName].Type;
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

        public static IEnumerable<IAttributeValueMvoStateDto> ToAttributeValueMvoStateDtoCollection(IEnumerable<AttributeValueId> ids)
        {
            var states = new List<IAttributeValueMvoStateDto>();
            foreach (var id in ids)
            {
                var dto = new AttributeValueMvoStateDtoWrapper();
                dto.AttributeValueId = id;
                states.Add(dto);
            }
            return states;
        }

        public static IEnumerable<IAttributeValueMvoState> ToAttributeValueMvoStateCollection(IEnumerable<AttributeValueId> ids)
        {
            var states = new List<AttributeValueMvoState>();
            foreach (var id in ids)
            {
                var s = new AttributeValueMvoState();
                s.AttributeValueId = id;
                states.Add(s);
            }
            return states;
        }

    }

}

