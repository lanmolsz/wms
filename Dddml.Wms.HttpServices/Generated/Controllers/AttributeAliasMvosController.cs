﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAggregatesControllers.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeAliasMvo;
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

    [RoutePrefix("api/AttributeAliasMvos")]
    public partial class AttributeAliasMvosController : ApiController
    {

        IAttributeAliasMvoApplicationService _attributeAliasMvoApplicationService = ApplicationContext.Current["AttributeAliasMvoApplicationService"] as IAttributeAliasMvoApplicationService;

        [Route(Order = 1)]
        [HttpGet]
        public IEnumerable<IAttributeAliasMvoStateDto> GetAll(string sort = null, string fields = null, int firstResult = 0, int maxResults = int.MaxValue, string filter = null)
        {
          try {
            IEnumerable<IAttributeAliasMvoState> states = null; 
            if (!String.IsNullOrWhiteSpace(filter))
            {
                states = _attributeAliasMvoApplicationService.Get(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(), new ApiControllerTypeConverter(), new PropertyTypeResolver()
                    , n => (AttributeAliasMvoMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(n) ? AttributeAliasMvoMetadata.Instance.FilteringPropertyAliasDictionary[n] : n))
                    , AttributeAliasMvosControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            else 
            {
                states = _attributeAliasMvoApplicationService.Get(AttributeAliasMvosControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs())
                    , AttributeAliasMvosControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            var stateDtos = new List<IAttributeAliasMvoStateDto>();
            foreach (var s in states)
            {
                var dto = s is AttributeAliasMvoStateDtoWrapper ? (AttributeAliasMvoStateDtoWrapper)s : new AttributeAliasMvoStateDtoWrapper(s);
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
          } catch (Exception ex) { var response = AttributeAliasMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpGet]
        public IAttributeAliasMvoStateDto Get(string id, string fields = null)
        {
          try {
            var idObj = AttributeAliasMvosControllerUtils.ParseIdString(id);
            var state = _attributeAliasMvoApplicationService.Get(idObj);
            if (state == null) { return null; }
            var stateDto = new AttributeAliasMvoStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = AttributeAliasMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                count = _attributeAliasMvoApplicationService.GetCount(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(), new ApiControllerTypeConverter(), new PropertyTypeResolver()
                    , n => (AttributeAliasMvoMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(n) ? AttributeAliasMvoMetadata.Instance.FilteringPropertyAliasDictionary[n] : n)));
            }
            else 
            {
                count = _attributeAliasMvoApplicationService.GetCount(AttributeAliasMvosControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs()));
            }
            return count;
          } catch (Exception ex) { var response = AttributeAliasMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route(Order = 1)]
        [HttpPost][SetRequesterId]
        public HttpResponseMessage Post([FromBody]CreateAttributeAliasMvoDto value)
        {
          try {
            if (value.AttributeAliasId == default(AttributeAliasId))
            {
                throw DomainError.Named("nullId", "Aggregate Id in cmd is null, aggregate name: {0}.", "AttributeAliasMvo");
            }
            _attributeAliasMvoApplicationService.When(value as ICreateAttributeAliasMvo);
            var idObj = value.AttributeAliasId;

            return Request.CreateResponse<AttributeAliasId>(HttpStatusCode.Created, idObj);
          } catch (Exception ex) { var response = AttributeAliasMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPut][SetRequesterId]
        public void Put(string id, [FromBody]CreateOrMergePatchOrDeleteAttributeAliasMvoDto value)
        {
          try {
              // ///////////////////////////////
              if (value.AttributeVersion != default(long))
              {
                  value.CommandType = CommandType.MergePatch;
                  AttributeAliasMvosControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
                  _attributeAliasMvoApplicationService.When(value as IMergePatchAttributeAliasMvo);
                  return;
              }
              // ///////////////////////////////

            AttributeAliasMvosControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _attributeAliasMvoApplicationService.When(value as ICreateAttributeAliasMvo);
          } catch (Exception ex) { var response = AttributeAliasMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPatch][SetRequesterId]
        public void Patch(string id, [FromBody]MergePatchAttributeAliasMvoDto value)
        {
          try {
            AttributeAliasMvosControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _attributeAliasMvoApplicationService.When(value as IMergePatchAttributeAliasMvo);
          } catch (Exception ex) { var response = AttributeAliasMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpDelete][SetRequesterId]
        public void Delete(string id, string commandId, string version, string requesterId = default(string))
        {
          try {
            var value = new DeleteAttributeAliasMvoDto();
            value.CommandId = commandId;
            value.RequesterId = requesterId;
            value.AttributeVersion = (long)Convert.ChangeType(version, typeof(long));
            AttributeAliasMvosControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _attributeAliasMvoApplicationService.When(value as IDeleteAttributeAliasMvo);
          } catch (Exception ex) { var response = AttributeAliasMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("_metadata/filteringFields")]
        [HttpGet]
        public IEnumerable<PropertyMetadataDto> GetMetadataFilteringFields()
        {
          try {
            var filtering = new List<PropertyMetadataDto>();
            foreach (var p in AttributeAliasMvoMetadata.Instance.Properties)
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
          } catch (Exception ex) { var response = AttributeAliasMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_stateEvents/{version}")]
        [HttpGet]
        public AttributeAliasMvoStateCreatedOrMergePatchedOrDeletedDto GetStateEvent(string id, long version)
        {
          try {
            var idObj = AttributeAliasMvosControllerUtils.ParseIdString(id);
            var conv = new AttributeAliasMvoStateEventDtoConverter();
            var se = _attributeAliasMvoApplicationService.GetEvent(idObj, version);
            return se == null ? null : conv.ToAttributeAliasMvoStateEventDto(se);
          } catch (Exception ex) { var response = AttributeAliasMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_historyStates/{version}")]
        [HttpGet]
        public IAttributeAliasMvoStateDto GetHistoryState(string id, long version, string fields = null)
        {
          try {
            var idObj = AttributeAliasMvosControllerUtils.ParseIdString(id);
            var state = _attributeAliasMvoApplicationService.GetHistoryState(idObj, version);
            if (state == null) { return null; }
            var stateDto = new AttributeAliasMvoStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = AttributeAliasMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                return AttributeAliasMvosControllerUtils.GetFilterPropertyType(propertyName);
            }
        }

    }


    
    public static class AttributeAliasMvosControllerUtils
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

        public static void SetNullIdOrThrowOnInconsistentIds(string id, CreateOrMergePatchOrDeleteAttributeAliasMvoDto value)
        {
            var idObj = ParseIdString(id.IsNormalized() ? id : id.Normalize());
            if (value.AttributeAliasId == null)
            {
                value.AttributeAliasId = idObj;
            }
            else if (!((ICreateOrMergePatchOrDeleteAttributeAliasMvo)value).AttributeAliasId.Equals(idObj))
            {
                throw DomainError.Named("inconsistentId", "Argument Id {0} NOT equals body Id {1}", id, value.AttributeAliasId);
            }
        }

        public static AttributeAliasId ParseIdString(string idString)
        {
            var formatter = new ValueObjectTextFormatter<AttributeAliasId>();
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
            if (AttributeAliasMvoMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(fieldName))
            {
                return AttributeAliasMvoMetadata.Instance.FilteringPropertyAliasDictionary[fieldName];
            }
            return null;
        }

        public static Type GetFilterPropertyType(string propertyName)
        {
            if (AttributeAliasMvoMetadata.Instance.PropertyMetadataDictionary.ContainsKey(propertyName))
            {
                return AttributeAliasMvoMetadata.Instance.PropertyMetadataDictionary[propertyName].Type;
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

        public static IEnumerable<IAttributeAliasMvoStateDto> ToAttributeAliasMvoStateDtoCollection(IEnumerable<AttributeAliasId> ids)
        {
            var states = new List<IAttributeAliasMvoStateDto>();
            foreach (var id in ids)
            {
                var dto = new AttributeAliasMvoStateDtoWrapper();
                dto.AttributeAliasId = id;
                states.Add(dto);
            }
            return states;
        }

        public static IEnumerable<IAttributeAliasMvoState> ToAttributeAliasMvoStateCollection(IEnumerable<AttributeAliasId> ids)
        {
            var states = new List<AttributeAliasMvoState>();
            foreach (var id in ids)
            {
                var s = new AttributeAliasMvoState();
                s.AttributeAliasId = id;
                states.Add(s);
            }
            return states;
        }

    }

}

