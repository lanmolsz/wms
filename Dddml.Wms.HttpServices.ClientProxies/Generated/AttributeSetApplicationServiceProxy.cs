﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSet;
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

    public partial class AttributeSetApplicationServiceProxy : IAttributeSetApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public AttributeSetApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public AttributeSetApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public AttributeSetApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateAttributeSetDto c)
        {
            var idObj = (c as ICreateAttributeSet).AttributeSetId;
            var uriParameters = new AttributeSetUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributeSetPutRequest(uriParameters, (CreateAttributeSetDto)c);
                
            var resp = await _ramlClient.AttributeSet.Put(req);
            AttributeSetProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateAttributeSetDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchAttributeSetDto c)
        {
            var idObj = (c as IMergePatchAttributeSet).AttributeSetId;
            var uriParameters = new AttributeSetUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributeSetPatchRequest(uriParameters, (MergePatchAttributeSetDto)c);
            var resp = await _ramlClient.AttributeSet.Patch(req);
            AttributeSetProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchAttributeSetDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteAttributeSetDto c)
        {
            var idObj = (c as IDeleteAttributeSet).AttributeSetId;
            var uriParameters = new AttributeSetUriParameters();
            uriParameters.Id = idObj;

            var q = new AttributeSetDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new AttributeSetDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.AttributeSet.Delete(req);
            AttributeSetProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteAttributeSetDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IAttributeSetApplicationService.When(ICreateAttributeSet c)
        {
            this.When((CreateAttributeSetDto)c);
        }

        void IAttributeSetApplicationService.When(IMergePatchAttributeSet c)
        {
            this.When((MergePatchAttributeSetDto)c);
        }

        void IAttributeSetApplicationService.When(IDeleteAttributeSet c)
        {
            this.When((DeleteAttributeSetDto)c);
        }

        public async Task<IAttributeSetState> GetAsync(string attributeSetId)
        {
            IAttributeSetState state = null;
            var idObj = attributeSetId;
            var uriParameters = new AttributeSetUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributeSetGetRequest(uriParameters);

            var resp = await _ramlClient.AttributeSet.Get(req);
            AttributeSetProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToAttributeSetState();
            return state;
        }

        public IAttributeSetState Get(string attributeSetId)
        {
            return GetAsync(attributeSetId).GetAwaiter().GetResult();
        }


        public IEnumerable<IAttributeSetState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IAttributeSetState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IAttributeSetState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IAttributeSetState> states = null;
			var q = new AttributeSetsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = AttributeSetProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = AttributeSetProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = AttributeSetProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new AttributeSetsGetRequest();
            req.Query = q;
            var resp = await _ramlClient.AttributeSets.Get(req);
            AttributeSetProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToAttributeSetState());
            return states;
        }

        public IEnumerable<IAttributeSetState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IAttributeSetState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IAttributeSetState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IAttributeSetState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IAttributeSetState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IAttributeSetState> states = null;
			var q = new AttributeSetsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = AttributeSetProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = AttributeSetProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = AttributeSetProxyUtils.GetFilterQueryValueString(filter);
            var req = new AttributeSetsGetRequest();
            req.Query = q;
            var resp = await _ramlClient.AttributeSets.Get(req);
            AttributeSetProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToAttributeSetState());
            return states;
        }

        public IEnumerable<IAttributeSetState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new AttributeSetsCountGetQuery();
            q.FilterTag = AttributeSetProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new AttributeSetsCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.AttributeSetsCount.Get(req);
            AttributeSetProxyUtils.ThrowOnHttpResponseError(resp);
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
			var q = new AttributeSetsCountGetQuery();
            q.Filter = AttributeSetProxyUtils.GetFilterQueryValueString(filter);
            var req = new AttributeSetsCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.AttributeSetsCount.Get(req);
            AttributeSetProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IAttributeSetStateEvent> GetStateEventAsync(string attributeSetId, long version)
        {
            var idObj = attributeSetId;
            var uriParameters = new AttributeSetStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new AttributeSetStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.AttributeSetStateEvent.Get(req);
            AttributeSetProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IAttributeSetStateEvent GetStateEvent(string attributeSetId, long version)
        {
            return GetStateEventAsync(attributeSetId, version).GetAwaiter().GetResult();
        }


        public async Task<IAttributeSetState> GetHistoryStateAsync(string attributeSetId, long version)
        {
            var idObj = attributeSetId;
            var uriParameters = new AttributeSetHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new AttributeSetHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.AttributeSetHistoryState.Get(req);
            AttributeSetProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToAttributeSetState();
        }

        public virtual IAttributeSetState GetHistoryState(string attributeSetId, long version)
        {
            return GetHistoryStateAsync(attributeSetId, version).GetAwaiter().GetResult();
        }

        public async virtual Task<IAttributeUseState> GetAttributeUseAsync(string attributeSetId, string attributeId)
        {
            var uriParameters = new AttributeUseUriParameters();
            uriParameters.AttributeSetId = attributeSetId;
            uriParameters.AttributeId = attributeId;

            var req = new AttributeUseGetRequest(uriParameters);
            var resp = await _ramlClient.AttributeUse.Get(req);
            AttributeSetProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToAttributeUseState();
        }

        public virtual IAttributeUseState GetAttributeUse(string attributeSetId, string attributeId)
        {
            return GetAttributeUseAsync(attributeSetId, attributeId).GetAwaiter().GetResult();
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


    public partial class AttributeSetApplicationServiceProxyFactory : ProxyFactoryBase, IAttributeSetApplicationServiceFactory
    {

        public AttributeSetApplicationServiceProxyFactory() : base()
        {}

        public AttributeSetApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IAttributeSetApplicationService AttributeSetApplicationService
        {
            get
            {
                return new AttributeSetApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateAttributeSet NewCreateAttributeSet()
        {
            return new CreateAttributeSetDto();
        }

        public IMergePatchAttributeSet NewMergePatchAttributeSet()
        {
            return new MergePatchAttributeSetDto();
        }

        public IDeleteAttributeSet NewDeleteAttributeSet()
        {
            return new DeleteAttributeSetDto();
        }
    }

    public static class AttributeSetProxyUtils
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

        public static IEnumerable<string> ToIdCollection(IEnumerable<IAttributeSetState> states)
        {
            var ids = new List<string>();
            foreach (var s in states)
            {
                ids.Add(s.AttributeSetId);
            }
            return ids;
        }

    }

}

