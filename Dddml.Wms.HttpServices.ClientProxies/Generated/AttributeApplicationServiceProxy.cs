﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Attribute;
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

    public partial class AttributeApplicationServiceProxy : IAttributeApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public AttributeApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public AttributeApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public AttributeApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateAttributeDto c)
        {
            var idObj = (c as ICreateAttribute).AttributeId;
            var uriParameters = new AttributeUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributePutRequest(uriParameters, (CreateAttributeDto)c);
                
            var resp = await _ramlClient.Attribute.Put(req);
            AttributeProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateAttributeDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchAttributeDto c)
        {
            var idObj = (c as IMergePatchAttribute).AttributeId;
            var uriParameters = new AttributeUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributePatchRequest(uriParameters, (MergePatchAttributeDto)c);
            var resp = await _ramlClient.Attribute.Patch(req);
            AttributeProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchAttributeDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteAttributeDto c)
        {
            var idObj = (c as IDeleteAttribute).AttributeId;
            var uriParameters = new AttributeUriParameters();
            uriParameters.Id = idObj;

            var q = new AttributeDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new AttributeDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.Attribute.Delete(req);
            AttributeProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteAttributeDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IAttributeApplicationService.When(ICreateAttribute c)
        {
            this.When((CreateAttributeDto)c);
        }

        void IAttributeApplicationService.When(IMergePatchAttribute c)
        {
            this.When((MergePatchAttributeDto)c);
        }

        void IAttributeApplicationService.When(IDeleteAttribute c)
        {
            this.When((DeleteAttributeDto)c);
        }

        public async Task<IAttributeState> GetAsync(string attributeId)
        {
            IAttributeState state = null;
            var idObj = attributeId;
            var uriParameters = new AttributeUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributeGetRequest(uriParameters);

            var resp = await _ramlClient.Attribute.Get(req);
            AttributeProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToAttributeState();
            return state;
        }

        public IAttributeState Get(string attributeId)
        {
            return GetAsync(attributeId).GetAwaiter().GetResult();
        }


        public IEnumerable<IAttributeState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IAttributeState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IAttributeState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IAttributeState> states = null;
			var q = new AttributesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = AttributeProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = AttributeProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = AttributeProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new AttributesGetRequest();
            req.Query = q;
            var resp = await _ramlClient.Attributes.Get(req);
            AttributeProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToAttributeState());
            return states;
        }

        public IEnumerable<IAttributeState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IAttributeState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IAttributeState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IAttributeState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IAttributeState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IAttributeState> states = null;
			var q = new AttributesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = AttributeProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = AttributeProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = AttributeProxyUtils.GetFilterQueryValueString(filter);
            var req = new AttributesGetRequest();
            req.Query = q;
            var resp = await _ramlClient.Attributes.Get(req);
            AttributeProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToAttributeState());
            return states;
        }

        public IEnumerable<IAttributeState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new AttributesCountGetQuery();
            q.FilterTag = AttributeProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new AttributesCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.AttributesCount.Get(req);
            AttributeProxyUtils.ThrowOnHttpResponseError(resp);
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
			var q = new AttributesCountGetQuery();
            q.Filter = AttributeProxyUtils.GetFilterQueryValueString(filter);
            var req = new AttributesCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.AttributesCount.Get(req);
            AttributeProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IAttributeStateEvent> GetStateEventAsync(string attributeId, long version)
        {
            var idObj = attributeId;
            var uriParameters = new AttributeStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new AttributeStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.AttributeStateEvent.Get(req);
            AttributeProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IAttributeStateEvent GetStateEvent(string attributeId, long version)
        {
            return GetStateEventAsync(attributeId, version).GetAwaiter().GetResult();
        }


        public async Task<IAttributeState> GetHistoryStateAsync(string attributeId, long version)
        {
            var idObj = attributeId;
            var uriParameters = new AttributeHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new AttributeHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.AttributeHistoryState.Get(req);
            AttributeProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToAttributeState();
        }

        public virtual IAttributeState GetHistoryState(string attributeId, long version)
        {
            return GetHistoryStateAsync(attributeId, version).GetAwaiter().GetResult();
        }

        public async virtual Task<IAttributeValueState> GetAttributeValueAsync(string attributeId, string value)
        {
            var uriParameters = new AttributeValueUriParameters();
            uriParameters.AttributeId = attributeId;
            uriParameters.Value = value;

            var req = new AttributeValueGetRequest(uriParameters);
            var resp = await _ramlClient.AttributeValue.Get(req);
            AttributeProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToAttributeValueState();
        }

        public virtual IAttributeValueState GetAttributeValue(string attributeId, string value)
        {
            return GetAttributeValueAsync(attributeId, value).GetAwaiter().GetResult();
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


    public partial class AttributeApplicationServiceProxyFactory : ProxyFactoryBase, IAttributeApplicationServiceFactory
    {

        public AttributeApplicationServiceProxyFactory() : base()
        {}

        public AttributeApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IAttributeApplicationService AttributeApplicationService
        {
            get
            {
                return new AttributeApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateAttribute NewCreateAttribute()
        {
            return new CreateAttributeDto();
        }

        public IMergePatchAttribute NewMergePatchAttribute()
        {
            return new MergePatchAttributeDto();
        }

        public IDeleteAttribute NewDeleteAttribute()
        {
            return new DeleteAttributeDto();
        }
    }

    public static class AttributeProxyUtils
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

        public static IEnumerable<string> ToIdCollection(IEnumerable<IAttributeState> states)
        {
            var ids = new List<string>();
            foreach (var s in states)
            {
                ids.Add(s.AttributeId);
            }
            return ids;
        }

    }

}

