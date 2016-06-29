﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
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

    public partial class AttributeValueMvoApplicationServiceProxy : IAttributeValueMvoApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public AttributeValueMvoApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public AttributeValueMvoApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public AttributeValueMvoApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateAttributeValueMvoDto c)
        {
            var idObj = AttributeValueMvoProxyUtils.ToIdString((c as ICreateAttributeValueMvo).AttributeValueId);
            var uriParameters = new AttributeValueMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributeValueMvoPutRequest(uriParameters, (CreateAttributeValueMvoDto)c);
                
            var resp = await _ramlClient.AttributeValueMvo.Put(req);
            AttributeValueMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateAttributeValueMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchAttributeValueMvoDto c)
        {
            var idObj = AttributeValueMvoProxyUtils.ToIdString((c as IMergePatchAttributeValueMvo).AttributeValueId);
            var uriParameters = new AttributeValueMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributeValueMvoPatchRequest(uriParameters, (MergePatchAttributeValueMvoDto)c);
            var resp = await _ramlClient.AttributeValueMvo.Patch(req);
            AttributeValueMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchAttributeValueMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteAttributeValueMvoDto c)
        {
            var idObj = AttributeValueMvoProxyUtils.ToIdString((c as IDeleteAttributeValueMvo).AttributeValueId);
            var uriParameters = new AttributeValueMvoUriParameters();
            uriParameters.Id = idObj;

            var q = new AttributeValueMvoDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new AttributeValueMvoDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.AttributeValueMvo.Delete(req);
            AttributeValueMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteAttributeValueMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IAttributeValueMvoApplicationService.When(ICreateAttributeValueMvo c)
        {
            this.When((CreateAttributeValueMvoDto)c);
        }

        void IAttributeValueMvoApplicationService.When(IMergePatchAttributeValueMvo c)
        {
            this.When((MergePatchAttributeValueMvoDto)c);
        }

        void IAttributeValueMvoApplicationService.When(IDeleteAttributeValueMvo c)
        {
            this.When((DeleteAttributeValueMvoDto)c);
        }

        public async Task<IAttributeValueMvoState> GetAsync(AttributeValueId attributeValueId)
        {
            IAttributeValueMvoState state = null;
            var idObj = AttributeValueMvoProxyUtils.ToIdString(attributeValueId);
            var uriParameters = new AttributeValueMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributeValueMvoGetRequest(uriParameters);

            var resp = await _ramlClient.AttributeValueMvo.Get(req);
            AttributeValueMvoProxyUtils.ThrowOnHttpResponseError(resp);
            state = resp.Content;
            return state;
        }

        public IAttributeValueMvoState Get(AttributeValueId attributeValueId)
        {
            return GetAsync(attributeValueId).GetAwaiter().GetResult();
        }


        public IEnumerable<IAttributeValueMvoState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IAttributeValueMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IAttributeValueMvoState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IAttributeValueMvoState> states = null;
			var q = new AttributeValueMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = AttributeValueMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = AttributeValueMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = AttributeValueMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new AttributeValueMvosGetRequest();
            req.Query = q;
            var resp = await _ramlClient.AttributeValueMvos.Get(req);
            AttributeValueMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<IAttributeValueMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IAttributeValueMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IAttributeValueMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IAttributeValueMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IAttributeValueMvoState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IAttributeValueMvoState> states = null;
			var q = new AttributeValueMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = AttributeValueMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = AttributeValueMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = AttributeValueMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new AttributeValueMvosGetRequest();
            req.Query = q;
            var resp = await _ramlClient.AttributeValueMvos.Get(req);
            AttributeValueMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<IAttributeValueMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new AttributeValueMvosCountGetQuery();
            q.FilterTag = AttributeValueMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new AttributeValueMvosCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.AttributeValueMvosCount.Get(req);
            AttributeValueMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(await resp.RawContent.ReadAsStringAsync());
		}

        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async virtual Task<long> GetCountAsync(ICriterion filter)
		{
			var q = new AttributeValueMvosCountGetQuery();
            q.Filter = AttributeValueMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new AttributeValueMvosCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.AttributeValueMvosCount.Get(req);
            AttributeValueMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(await resp.RawContent.ReadAsStringAsync());
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IAttributeValueMvoStateEvent> GetStateEventAsync(AttributeValueId attributeValueId, long version)
        {
            var idObj = AttributeValueMvoProxyUtils.ToIdString(attributeValueId);
            var uriParameters = new AttributeValueMvoStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new AttributeValueMvoStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.AttributeValueMvoStateEvent.Get(req);
            AttributeValueMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IAttributeValueMvoStateEvent GetStateEvent(AttributeValueId attributeValueId, long version)
        {
            return GetStateEventAsync(attributeValueId, version).GetAwaiter().GetResult();
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


    public partial class AttributeValueMvoApplicationServiceProxyFactory : ProxyFactoryBase, IAttributeValueMvoApplicationServiceFactory
    {

        public AttributeValueMvoApplicationServiceProxyFactory() : base()
        {}

        public AttributeValueMvoApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IAttributeValueMvoApplicationService AttributeValueMvoApplicationService
        {
            get
            {
                return new AttributeValueMvoApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateAttributeValueMvo NewCreateAttributeValueMvo()
        {
            return new CreateAttributeValueMvoDto();
        }

        public IMergePatchAttributeValueMvo NewMergePatchAttributeValueMvo()
        {
            return new MergePatchAttributeValueMvoDto();
        }

        public IDeleteAttributeValueMvo NewDeleteAttributeValueMvo()
        {
            return new DeleteAttributeValueMvoDto();
        }
    }

    public static class AttributeValueMvoProxyUtils
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
                throw new NotSupportedException();
            }
        }

        public static string ToIdString(AttributeValueId id)
        {
            var formatter = new AttributeValueIdFlattenedDtoFormatter();
            var idDto = new AttributeValueIdFlattenedDto(id);
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

        public static IEnumerable<AttributeValueId> ToIdCollection(IEnumerable<IAttributeValueMvoState> states)
        {
            var ids = new List<AttributeValueId>();
            foreach (var s in states)
            {
                ids.Add(s.AttributeValueId);
            }
            return ids;
        }

    }

}

