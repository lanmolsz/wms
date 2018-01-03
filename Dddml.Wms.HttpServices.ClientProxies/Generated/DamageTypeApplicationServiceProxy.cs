﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.DamageType;
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

    public partial class DamageTypeApplicationServiceProxy : IDamageTypeApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public DamageTypeApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public DamageTypeApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public DamageTypeApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateDamageTypeDto c)
        {
            var idObj = (c as ICreateDamageType).DamageTypeId;
            var uriParameters = new DamageTypeUriParameters();
            uriParameters.Id = idObj;

            var req = new DamageTypePutRequest(uriParameters, (CreateDamageTypeDto)c);
                
            var resp = await _ramlClient.DamageType.Put(req);
            DamageTypeProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateDamageTypeDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchDamageTypeDto c)
        {
            var idObj = (c as IMergePatchDamageType).DamageTypeId;
            var uriParameters = new DamageTypeUriParameters();
            uriParameters.Id = idObj;

            var req = new DamageTypePatchRequest(uriParameters, (MergePatchDamageTypeDto)c);
            var resp = await _ramlClient.DamageType.Patch(req);
            DamageTypeProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchDamageTypeDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteDamageTypeDto c)
        {
            var idObj = (c as IDeleteDamageType).DamageTypeId;
            var uriParameters = new DamageTypeUriParameters();
            uriParameters.Id = idObj;

            var q = new DamageTypeDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new DamageTypeDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.DamageType.Delete(req);
            DamageTypeProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteDamageTypeDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IDamageTypeApplicationService.When(ICreateDamageType c)
        {
            this.When((CreateDamageTypeDto)c);
        }

        void IDamageTypeApplicationService.When(IMergePatchDamageType c)
        {
            this.When((MergePatchDamageTypeDto)c);
        }

        void IDamageTypeApplicationService.When(IDeleteDamageType c)
        {
            this.When((DeleteDamageTypeDto)c);
        }

        public async Task<IDamageTypeState> GetAsync(string damageTypeId)
        {
            IDamageTypeState state = null;
            var idObj = damageTypeId;
            var uriParameters = new DamageTypeUriParameters();
            uriParameters.Id = idObj;

            var req = new DamageTypeGetRequest(uriParameters);

            var resp = await _ramlClient.DamageType.Get(req);
            DamageTypeProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToDamageTypeState();
            return state;
        }

        public IDamageTypeState Get(string damageTypeId)
        {
            return GetAsync(damageTypeId).GetAwaiter().GetResult();
        }


        public IEnumerable<IDamageTypeState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IDamageTypeState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IDamageTypeState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IDamageTypeState> states = null;
			var q = new DamageTypesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = DamageTypeProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = DamageTypeProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = DamageTypeProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new DamageTypesGetRequest();
            req.Query = q;
            var resp = await _ramlClient.DamageTypes.Get(req);
            DamageTypeProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToDamageTypeState());
            return states;
        }

        public IEnumerable<IDamageTypeState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IDamageTypeState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IDamageTypeState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IDamageTypeState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IDamageTypeState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IDamageTypeState> states = null;
			var q = new DamageTypesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = DamageTypeProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = DamageTypeProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = DamageTypeProxyUtils.GetFilterQueryValueString(filter);
            var req = new DamageTypesGetRequest();
            req.Query = q;
            var resp = await _ramlClient.DamageTypes.Get(req);
            DamageTypeProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToDamageTypeState());
            return states;
        }

        public IEnumerable<IDamageTypeState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new DamageTypesCountGetQuery();
            q.FilterTag = DamageTypeProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new DamageTypesCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.DamageTypesCount.Get(req);
            DamageTypeProxyUtils.ThrowOnHttpResponseError(resp);
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
			var q = new DamageTypesCountGetQuery();
            q.Filter = DamageTypeProxyUtils.GetFilterQueryValueString(filter);
            var req = new DamageTypesCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.DamageTypesCount.Get(req);
            DamageTypeProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IDamageTypeStateEvent> GetStateEventAsync(string damageTypeId, long version)
        {
            var idObj = damageTypeId;
            var uriParameters = new DamageTypeStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new DamageTypeStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.DamageTypeStateEvent.Get(req);
            DamageTypeProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IDamageTypeStateEvent GetStateEvent(string damageTypeId, long version)
        {
            return GetStateEventAsync(damageTypeId, version).GetAwaiter().GetResult();
        }


        public async Task<IDamageTypeState> GetHistoryStateAsync(string damageTypeId, long version)
        {
            var idObj = damageTypeId;
            var uriParameters = new DamageTypeHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new DamageTypeHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.DamageTypeHistoryState.Get(req);
            DamageTypeProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToDamageTypeState();
        }

        public virtual IDamageTypeState GetHistoryState(string damageTypeId, long version)
        {
            return GetHistoryStateAsync(damageTypeId, version).GetAwaiter().GetResult();
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


    public partial class DamageTypeApplicationServiceProxyFactory : ProxyFactoryBase, IDamageTypeApplicationServiceFactory
    {

        public DamageTypeApplicationServiceProxyFactory() : base()
        {}

        public DamageTypeApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IDamageTypeApplicationService DamageTypeApplicationService
        {
            get
            {
                return new DamageTypeApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateDamageType NewCreateDamageType()
        {
            return new CreateDamageTypeDto();
        }

        public IMergePatchDamageType NewMergePatchDamageType()
        {
            return new MergePatchDamageTypeDto();
        }

        public IDeleteDamageType NewDeleteDamageType()
        {
            return new DeleteDamageTypeDto();
        }
    }

    public static class DamageTypeProxyUtils
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

        public static IEnumerable<string> ToIdCollection(IEnumerable<IDamageTypeState> states)
        {
            var ids = new List<string>();
            foreach (var s in states)
            {
                ids.Add(s.DamageTypeId);
            }
            return ids;
        }

    }

}

