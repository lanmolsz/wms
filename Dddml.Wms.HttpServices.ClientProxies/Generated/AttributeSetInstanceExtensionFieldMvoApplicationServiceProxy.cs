﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldMvo;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldGroup;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web.Http;
using Dddml.Wms.HttpServices.ClientProxies.Raml;
using Dddml.Wms.HttpServices.ClientProxies.Raml.Models;
using System.Text;
using System.ComponentModel;
using RAML.Api.Core;
using Newtonsoft.Json.Linq;
using Dddml.Support.Criterion;
using Dddml.Wms.Specialization.HttpServices.ClientProxies;


namespace Dddml.Wms.HttpServices.ClientProxies
{

    public partial class AttributeSetInstanceExtensionFieldMvoApplicationServiceProxy : IAttributeSetInstanceExtensionFieldMvoApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public AttributeSetInstanceExtensionFieldMvoApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public AttributeSetInstanceExtensionFieldMvoApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public AttributeSetInstanceExtensionFieldMvoApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateAttributeSetInstanceExtensionFieldMvoDto c)
        {
            var idObj = AttributeSetInstanceExtensionFieldMvoProxyUtils.ToIdString((c as ICreateAttributeSetInstanceExtensionFieldMvo).AttributeSetInstanceExtensionFieldId);
            var uriParameters = new AttributeSetInstanceExtensionFieldMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributeSetInstanceExtensionFieldMvoPutRequest(uriParameters, (CreateAttributeSetInstanceExtensionFieldMvoDto)c);
                
            var resp = await _ramlClient.AttributeSetInstanceExtensionFieldMvo.Put(req);
            AttributeSetInstanceExtensionFieldMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateAttributeSetInstanceExtensionFieldMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchAttributeSetInstanceExtensionFieldMvoDto c)
        {
            var idObj = AttributeSetInstanceExtensionFieldMvoProxyUtils.ToIdString((c as IMergePatchAttributeSetInstanceExtensionFieldMvo).AttributeSetInstanceExtensionFieldId);
            var uriParameters = new AttributeSetInstanceExtensionFieldMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributeSetInstanceExtensionFieldMvoPatchRequest(uriParameters, (MergePatchAttributeSetInstanceExtensionFieldMvoDto)c);
            var resp = await _ramlClient.AttributeSetInstanceExtensionFieldMvo.Patch(req);
            AttributeSetInstanceExtensionFieldMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchAttributeSetInstanceExtensionFieldMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteAttributeSetInstanceExtensionFieldMvoDto c)
        {
            var idObj = AttributeSetInstanceExtensionFieldMvoProxyUtils.ToIdString((c as IDeleteAttributeSetInstanceExtensionFieldMvo).AttributeSetInstanceExtensionFieldId);
            var uriParameters = new AttributeSetInstanceExtensionFieldMvoUriParameters();
            uriParameters.Id = idObj;

            var q = new AttributeSetInstanceExtensionFieldMvoDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.AttrSetInstEFGroupVersion);
                
            var req = new AttributeSetInstanceExtensionFieldMvoDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.AttributeSetInstanceExtensionFieldMvo.Delete(req);
            AttributeSetInstanceExtensionFieldMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteAttributeSetInstanceExtensionFieldMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IAttributeSetInstanceExtensionFieldMvoApplicationService.When(ICreateAttributeSetInstanceExtensionFieldMvo c)
        {
            this.When((CreateAttributeSetInstanceExtensionFieldMvoDto)c);
        }

        void IAttributeSetInstanceExtensionFieldMvoApplicationService.When(IMergePatchAttributeSetInstanceExtensionFieldMvo c)
        {
            this.When((MergePatchAttributeSetInstanceExtensionFieldMvoDto)c);
        }

        void IAttributeSetInstanceExtensionFieldMvoApplicationService.When(IDeleteAttributeSetInstanceExtensionFieldMvo c)
        {
            this.When((DeleteAttributeSetInstanceExtensionFieldMvoDto)c);
        }

        public async Task<IAttributeSetInstanceExtensionFieldMvoState> GetAsync(AttributeSetInstanceExtensionFieldId attributeSetInstanceExtensionFieldId)
        {
            IAttributeSetInstanceExtensionFieldMvoState state = null;
            var idObj = AttributeSetInstanceExtensionFieldMvoProxyUtils.ToIdString(attributeSetInstanceExtensionFieldId);
            var uriParameters = new AttributeSetInstanceExtensionFieldMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributeSetInstanceExtensionFieldMvoGetRequest(uriParameters);

            var resp = await _ramlClient.AttributeSetInstanceExtensionFieldMvo.Get(req);
            AttributeSetInstanceExtensionFieldMvoProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToAttributeSetInstanceExtensionFieldMvoState();
            return state;
        }

        public IAttributeSetInstanceExtensionFieldMvoState Get(AttributeSetInstanceExtensionFieldId attributeSetInstanceExtensionFieldId)
        {
            return GetAsync(attributeSetInstanceExtensionFieldId).GetAwaiter().GetResult();
        }


        public IEnumerable<IAttributeSetInstanceExtensionFieldMvoState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IAttributeSetInstanceExtensionFieldMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IAttributeSetInstanceExtensionFieldMvoState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IAttributeSetInstanceExtensionFieldMvoState> states = null;
			var q = new AttributeSetInstanceExtensionFieldMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = AttributeSetInstanceExtensionFieldMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = AttributeSetInstanceExtensionFieldMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = AttributeSetInstanceExtensionFieldMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new AttributeSetInstanceExtensionFieldMvosGetRequest();
            req.Query = q;
            var resp = await _ramlClient.AttributeSetInstanceExtensionFieldMvos.Get(req);
            AttributeSetInstanceExtensionFieldMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToAttributeSetInstanceExtensionFieldMvoState());
            return states;
        }

        public IEnumerable<IAttributeSetInstanceExtensionFieldMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IAttributeSetInstanceExtensionFieldMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IAttributeSetInstanceExtensionFieldMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IAttributeSetInstanceExtensionFieldMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IAttributeSetInstanceExtensionFieldMvoState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IAttributeSetInstanceExtensionFieldMvoState> states = null;
			var q = new AttributeSetInstanceExtensionFieldMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = AttributeSetInstanceExtensionFieldMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = AttributeSetInstanceExtensionFieldMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = AttributeSetInstanceExtensionFieldMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new AttributeSetInstanceExtensionFieldMvosGetRequest();
            req.Query = q;
            var resp = await _ramlClient.AttributeSetInstanceExtensionFieldMvos.Get(req);
            AttributeSetInstanceExtensionFieldMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToAttributeSetInstanceExtensionFieldMvoState());
            return states;
        }

        public IEnumerable<IAttributeSetInstanceExtensionFieldMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new AttributeSetInstanceExtensionFieldMvosCountGetQuery();
            q.FilterTag = AttributeSetInstanceExtensionFieldMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new AttributeSetInstanceExtensionFieldMvosCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.AttributeSetInstanceExtensionFieldMvosCount.Get(req);
            AttributeSetInstanceExtensionFieldMvoProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async virtual Task<long> GetCountAsync(ICriterion filter)
		{
			var q = new AttributeSetInstanceExtensionFieldMvosCountGetQuery();
            q.Filter = AttributeSetInstanceExtensionFieldMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new AttributeSetInstanceExtensionFieldMvosCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.AttributeSetInstanceExtensionFieldMvosCount.Get(req);
            AttributeSetInstanceExtensionFieldMvoProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IAttributeSetInstanceExtensionFieldMvoStateEvent> GetStateEventAsync(AttributeSetInstanceExtensionFieldId attributeSetInstanceExtensionFieldId, long version)
        {
            var idObj = AttributeSetInstanceExtensionFieldMvoProxyUtils.ToIdString(attributeSetInstanceExtensionFieldId);
            var uriParameters = new AttributeSetInstanceExtensionFieldMvoStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new AttributeSetInstanceExtensionFieldMvoStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.AttributeSetInstanceExtensionFieldMvoStateEvent.Get(req);
            AttributeSetInstanceExtensionFieldMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IAttributeSetInstanceExtensionFieldMvoStateEvent GetStateEvent(AttributeSetInstanceExtensionFieldId attributeSetInstanceExtensionFieldId, long version)
        {
            return GetStateEventAsync(attributeSetInstanceExtensionFieldId, version).GetAwaiter().GetResult();
        }


        public async Task<IAttributeSetInstanceExtensionFieldMvoState> GetHistoryStateAsync(AttributeSetInstanceExtensionFieldId attributeSetInstanceExtensionFieldId, long version)
        {
            var idObj = AttributeSetInstanceExtensionFieldMvoProxyUtils.ToIdString(attributeSetInstanceExtensionFieldId);
            var uriParameters = new AttributeSetInstanceExtensionFieldMvoHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new AttributeSetInstanceExtensionFieldMvoHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.AttributeSetInstanceExtensionFieldMvoHistoryState.Get(req);
            AttributeSetInstanceExtensionFieldMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToAttributeSetInstanceExtensionFieldMvoState();
        }

        public virtual IAttributeSetInstanceExtensionFieldMvoState GetHistoryState(AttributeSetInstanceExtensionFieldId attributeSetInstanceExtensionFieldId, long version)
        {
            return GetHistoryStateAsync(attributeSetInstanceExtensionFieldId, version).GetAwaiter().GetResult();
        }


        protected virtual string QueryFieldValueSeparator
        {
            get { return ","; }
        }

        protected virtual string QueryOrderSeparator
        {
            get { return ","; }
        }

    }


    public partial class AttributeSetInstanceExtensionFieldMvoApplicationServiceProxyFactory : ProxyFactoryBase, IAttributeSetInstanceExtensionFieldMvoApplicationServiceFactory
    {

        public AttributeSetInstanceExtensionFieldMvoApplicationServiceProxyFactory() : base()
        {}

        public AttributeSetInstanceExtensionFieldMvoApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IAttributeSetInstanceExtensionFieldMvoApplicationService AttributeSetInstanceExtensionFieldMvoApplicationService
        {
            get
            {
                return new AttributeSetInstanceExtensionFieldMvoApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateAttributeSetInstanceExtensionFieldMvo NewCreateAttributeSetInstanceExtensionFieldMvo()
        {
            return new CreateAttributeSetInstanceExtensionFieldMvoDto();
        }

        public IMergePatchAttributeSetInstanceExtensionFieldMvo NewMergePatchAttributeSetInstanceExtensionFieldMvo()
        {
            return new MergePatchAttributeSetInstanceExtensionFieldMvoDto();
        }

        public IDeleteAttributeSetInstanceExtensionFieldMvo NewDeleteAttributeSetInstanceExtensionFieldMvo()
        {
            return new DeleteAttributeSetInstanceExtensionFieldMvoDto();
        }
    }

    public static class AttributeSetInstanceExtensionFieldMvoProxyUtils
    {

        private class ProxyTypeConverter : Dddml.Support.Criterion.ITypeConverter
        {
            public T ConvertFromString<T>(string text)
            {
                throw new NotSupportedException();
            }

            public object ConvertFromString(Type type, string text)
            {
                throw new NotSupportedException();
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
                var list = new List<string>();
                foreach (var o in values)
                {
                    list.Add(ConvertToString(o));
                }
                return list.ToArray();
            }
        }

        public static string ToIdString(AttributeSetInstanceExtensionFieldId id)
        {
            var formatter = new AttributeSetInstanceExtensionFieldIdFlattenedDtoFormatter();
            var idDto = new AttributeSetInstanceExtensionFieldIdFlattenedDto(id);
            var idStr = formatter.ToString(idDto);
            return idStr;
        }


        public static string GetFilterQueryValueString(ICriterion filter)
        {
            if (filter == null) { return null; }
            return WebUtility.UrlEncode(JObject.FromObject(new CriterionDto(filter, new ProxyTypeConverter())).ToString());
        }

        public static string GetFilterTagQueryValueString(IEnumerable<KeyValuePair<string, object>> filter)
        {
            if (filter == null) { return null; }
            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.Now.Ticks);
            foreach (var p in filter)
            {
                var k = p.Key;
                var v = p.Value;
                sb.Append("&");
                sb.Append(k);
                sb.Append("=");
                if (v != null)
                {
                    string valStr = ApplicationContext.Current.TypeConverter.ConvertToString(v.GetType(), v);
                    sb.Append(WebUtility.UrlEncode(valStr));
                }

            }
            return sb.ToString();
        }

        public static string GetReturnedFieldsQueryValueString(IList<string> fields, string separator)
        {
            if (fields == null) { return null; }
            StringBuilder sb = new StringBuilder();
            foreach (var f in fields)
            {
                sb.Append(WebUtility.UrlEncode(f));
                sb.Append(separator);
            }
            return sb.ToString();
        }

        public static string GetOrdersQueryValueString(IList<string> orders)
        {
            if (orders == null) { return null; }
            StringBuilder sb = new StringBuilder();
            foreach (var ord in orders)
            {
                sb.Append(WebUtility.UrlEncode(ord));
                sb.Append(",");
            }
            return sb.ToString();
        }

        public static void ThrowOnHttpResponseError(ApiResponse resp)
        {
            var httpResponseMessage = new HttpResponseMessage()
            {
                StatusCode = resp.StatusCode,
                Content = resp.RawContent,
                ReasonPhrase = resp.ReasonPhrase
            };
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                return;
            }
            try
            {
                if (resp.StatusCode == HttpStatusCode.InternalServerError)
                {
                    IEnumerable<string> headerValues = new List<string>();
                    if (resp.RawContent != null && resp.RawContent.Headers != null)
                        resp.RawContent.Headers.TryGetValues("Content-Type", out headerValues);
                    if (headerValues.Any(hv => hv.ToLowerInvariant().Contains("json")))
                    {
                        JObject jObj = JObject.Parse(httpResponseMessage.Content.ReadAsStringAsync().GetAwaiter().GetResult());
                        var errorName = jObj.GetValue("ErrorName").ToObject<string>();
                        var errorMessage = jObj.GetValue("ErrorMessage").ToObject<string>();
                        throw DomainError.Named(errorName, errorMessage);
                    }
                }
                throw new HttpResponseException(httpResponseMessage);
            }
            catch
            {
                throw new HttpResponseException(httpResponseMessage);
            }
        }

        public static IEnumerable<AttributeSetInstanceExtensionFieldId> ToIdCollection(IEnumerable<IAttributeSetInstanceExtensionFieldMvoState> states)
        {
            var ids = new List<AttributeSetInstanceExtensionFieldId>();
            foreach (var s in states)
            {
                ids.Add(s.AttributeSetInstanceExtensionFieldId);
            }
            return ids;
        }

    }

}

