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

    public partial class AttributeSetInstanceExtensionFieldGroupApplicationServiceProxy : IAttributeSetInstanceExtensionFieldGroupApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public AttributeSetInstanceExtensionFieldGroupApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public AttributeSetInstanceExtensionFieldGroupApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public AttributeSetInstanceExtensionFieldGroupApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateAttributeSetInstanceExtensionFieldGroupDto c)
        {
            var idObj = ((c as ICreateAttributeSetInstanceExtensionFieldGroup).Id);
            var uriParameters = new AttributeSetInstanceExtensionFieldGroupUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributeSetInstanceExtensionFieldGroupPutRequest(uriParameters, (CreateAttributeSetInstanceExtensionFieldGroupDto)c);
                
            var resp = await _ramlClient.AttributeSetInstanceExtensionFieldGroup.Put(req);
            AttributeSetInstanceExtensionFieldGroupProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateAttributeSetInstanceExtensionFieldGroupDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchAttributeSetInstanceExtensionFieldGroupDto c)
        {
            var idObj = ((c as IMergePatchAttributeSetInstanceExtensionFieldGroup).Id);
            var uriParameters = new AttributeSetInstanceExtensionFieldGroupUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributeSetInstanceExtensionFieldGroupPatchRequest(uriParameters, (MergePatchAttributeSetInstanceExtensionFieldGroupDto)c);
            var resp = await _ramlClient.AttributeSetInstanceExtensionFieldGroup.Patch(req);
            AttributeSetInstanceExtensionFieldGroupProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchAttributeSetInstanceExtensionFieldGroupDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteAttributeSetInstanceExtensionFieldGroupDto c)
        {
            var idObj = ((c as IDeleteAttributeSetInstanceExtensionFieldGroup).Id);
            var uriParameters = new AttributeSetInstanceExtensionFieldGroupUriParameters();
            uriParameters.Id = idObj;

            var q = new AttributeSetInstanceExtensionFieldGroupDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new AttributeSetInstanceExtensionFieldGroupDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.AttributeSetInstanceExtensionFieldGroup.Delete(req);
            AttributeSetInstanceExtensionFieldGroupProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteAttributeSetInstanceExtensionFieldGroupDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IAttributeSetInstanceExtensionFieldGroupApplicationService.When(ICreateAttributeSetInstanceExtensionFieldGroup c)
        {
            this.When((CreateAttributeSetInstanceExtensionFieldGroupDto)c);
        }

        void IAttributeSetInstanceExtensionFieldGroupApplicationService.When(IMergePatchAttributeSetInstanceExtensionFieldGroup c)
        {
            this.When((MergePatchAttributeSetInstanceExtensionFieldGroupDto)c);
        }

        void IAttributeSetInstanceExtensionFieldGroupApplicationService.When(IDeleteAttributeSetInstanceExtensionFieldGroup c)
        {
            this.When((DeleteAttributeSetInstanceExtensionFieldGroupDto)c);
        }

        public async Task<IAttributeSetInstanceExtensionFieldGroupState> GetAsync(string id)
        {
            IAttributeSetInstanceExtensionFieldGroupState state = null;
            var idObj = (id);
            var uriParameters = new AttributeSetInstanceExtensionFieldGroupUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributeSetInstanceExtensionFieldGroupGetRequest(uriParameters);

            var resp = await _ramlClient.AttributeSetInstanceExtensionFieldGroup.Get(req);
            AttributeSetInstanceExtensionFieldGroupProxyUtils.ThrowOnHttpResponseError(resp);
            state = resp.Content;
            return state;
        }

        public IAttributeSetInstanceExtensionFieldGroupState Get(string id)
        {
            return GetAsync(id).GetAwaiter().GetResult();
        }


        public IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IAttributeSetInstanceExtensionFieldGroupState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> states = null;
			var q = new AttributeSetInstanceExtensionFieldGroupsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = AttributeSetInstanceExtensionFieldGroupProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = AttributeSetInstanceExtensionFieldGroupProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = AttributeSetInstanceExtensionFieldGroupProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new AttributeSetInstanceExtensionFieldGroupsGetRequest();
            req.Query = q;
            var resp = await _ramlClient.AttributeSetInstanceExtensionFieldGroups.Get(req);
            AttributeSetInstanceExtensionFieldGroupProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IAttributeSetInstanceExtensionFieldGroupState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> states = null;
			var q = new AttributeSetInstanceExtensionFieldGroupsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = AttributeSetInstanceExtensionFieldGroupProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = AttributeSetInstanceExtensionFieldGroupProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = AttributeSetInstanceExtensionFieldGroupProxyUtils.GetFilterQueryValueString(filter);
            var req = new AttributeSetInstanceExtensionFieldGroupsGetRequest();
            req.Query = q;
            var resp = await _ramlClient.AttributeSetInstanceExtensionFieldGroups.Get(req);
            AttributeSetInstanceExtensionFieldGroupProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new AttributeSetInstanceExtensionFieldGroupsCountGetQuery();
            q.FilterTag = AttributeSetInstanceExtensionFieldGroupProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new AttributeSetInstanceExtensionFieldGroupsCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.AttributeSetInstanceExtensionFieldGroupsCount.Get(req);
            AttributeSetInstanceExtensionFieldGroupProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(await resp.RawContent.ReadAsStringAsync());
		}

        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async virtual Task<long> GetCountAsync(ICriterion filter)
		{
			var q = new AttributeSetInstanceExtensionFieldGroupsCountGetQuery();
            q.Filter = AttributeSetInstanceExtensionFieldGroupProxyUtils.GetFilterQueryValueString(filter);
            var req = new AttributeSetInstanceExtensionFieldGroupsCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.AttributeSetInstanceExtensionFieldGroupsCount.Get(req);
            AttributeSetInstanceExtensionFieldGroupProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(await resp.RawContent.ReadAsStringAsync());
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IAttributeSetInstanceExtensionFieldGroupStateEvent> GetStateEventAsync(string id, long version)
        {
            var idObj = (id);
            var uriParameters = new AttributeSetInstanceExtensionFieldGroupStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new AttributeSetInstanceExtensionFieldGroupStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.AttributeSetInstanceExtensionFieldGroupStateEvent.Get(req);
            AttributeSetInstanceExtensionFieldGroupProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IAttributeSetInstanceExtensionFieldGroupStateEvent GetStateEvent(string id, long version)
        {
            return GetStateEventAsync(id, version).GetAwaiter().GetResult();
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


    public partial class AttributeSetInstanceExtensionFieldGroupApplicationServiceProxyFactory : ProxyFactoryBase, IAttributeSetInstanceExtensionFieldGroupApplicationServiceFactory
    {

        public AttributeSetInstanceExtensionFieldGroupApplicationServiceProxyFactory() : base()
        {}

        public AttributeSetInstanceExtensionFieldGroupApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IAttributeSetInstanceExtensionFieldGroupApplicationService AttributeSetInstanceExtensionFieldGroupApplicationService
        {
            get
            {
                return new AttributeSetInstanceExtensionFieldGroupApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateAttributeSetInstanceExtensionFieldGroup NewCreateAttributeSetInstanceExtensionFieldGroup()
        {
            return new CreateAttributeSetInstanceExtensionFieldGroupDto();
        }

        public IMergePatchAttributeSetInstanceExtensionFieldGroup NewMergePatchAttributeSetInstanceExtensionFieldGroup()
        {
            return new MergePatchAttributeSetInstanceExtensionFieldGroupDto();
        }

        public IDeleteAttributeSetInstanceExtensionFieldGroup NewDeleteAttributeSetInstanceExtensionFieldGroup()
        {
            return new DeleteAttributeSetInstanceExtensionFieldGroupDto();
        }
    }

    public static class AttributeSetInstanceExtensionFieldGroupProxyUtils
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

        public static IEnumerable<string> ToIdCollection(IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> states)
        {
            var ids = new List<string>();
            foreach (var s in states)
            {
                ids.Add(s.Id);
            }
            return ids;
        }

    }

}

