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

    public partial class OrganizationApplicationServiceProxy : IOrganizationApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public OrganizationApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public OrganizationApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public OrganizationApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateOrganizationDto c)
        {
            var idObj = ((c as ICreateOrganization).OrganizationId);
            var uriParameters = new OrganizationUriParameters();
            uriParameters.Id = idObj;

            var req = new OrganizationPutRequest(uriParameters, (CreateOrganizationDto)c);
                
            var resp = await _ramlClient.Organization.Put(req);
            OrganizationProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateOrganizationDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchOrganizationDto c)
        {
            var idObj = ((c as IMergePatchOrganization).OrganizationId);
            var uriParameters = new OrganizationUriParameters();
            uriParameters.Id = idObj;

            var req = new OrganizationPatchRequest(uriParameters, (MergePatchOrganizationDto)c);
            var resp = await _ramlClient.Organization.Patch(req);
            OrganizationProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchOrganizationDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteOrganizationDto c)
        {
            var idObj = ((c as IDeleteOrganization).OrganizationId);
            var uriParameters = new OrganizationUriParameters();
            uriParameters.Id = idObj;

            var q = new OrganizationDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new OrganizationDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.Organization.Delete(req);
            OrganizationProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteOrganizationDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IOrganizationApplicationService.When(ICreateOrganization c)
        {
            this.When((CreateOrganizationDto)c);
        }

        void IOrganizationApplicationService.When(IMergePatchOrganization c)
        {
            this.When((MergePatchOrganizationDto)c);
        }

        void IOrganizationApplicationService.When(IDeleteOrganization c)
        {
            this.When((DeleteOrganizationDto)c);
        }

        public async Task<IOrganizationState> GetAsync(string organizationId)
        {
            IOrganizationState state = null;
            var idObj = (organizationId);
            var uriParameters = new OrganizationUriParameters();
            uriParameters.Id = idObj;

            var req = new OrganizationGetRequest(uriParameters);

            var resp = await _ramlClient.Organization.Get(req);
            OrganizationProxyUtils.ThrowOnHttpResponseError(resp);
            state = resp.Content;
            return state;
        }

        public IOrganizationState Get(string organizationId)
        {
            return GetAsync(organizationId).GetAwaiter().GetResult();
        }


        public IEnumerable<IOrganizationState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IOrganizationState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IOrganizationState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IOrganizationState> states = null;
			var q = new OrganizationsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = OrganizationProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = OrganizationProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = OrganizationProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new OrganizationsGetRequest();
            req.Query = q;
            var resp = await _ramlClient.Organizations.Get(req);
            OrganizationProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<IOrganizationState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IOrganizationState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IOrganizationState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IOrganizationState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IOrganizationState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IOrganizationState> states = null;
			var q = new OrganizationsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = OrganizationProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = OrganizationProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = OrganizationProxyUtils.GetFilterQueryValueString(filter);
            var req = new OrganizationsGetRequest();
            req.Query = q;
            var resp = await _ramlClient.Organizations.Get(req);
            OrganizationProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<IOrganizationState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new OrganizationsCountGetQuery();
            q.FilterTag = OrganizationProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new OrganizationsCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.OrganizationsCount.Get(req);
            OrganizationProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(await resp.RawContent.ReadAsStringAsync());
		}

        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async virtual Task<long> GetCountAsync(ICriterion filter)
		{
			var q = new OrganizationsCountGetQuery();
            q.Filter = OrganizationProxyUtils.GetFilterQueryValueString(filter);
            var req = new OrganizationsCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.OrganizationsCount.Get(req);
            OrganizationProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(await resp.RawContent.ReadAsStringAsync());
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IOrganizationStateEvent> GetStateEventAsync(string organizationId, long version)
        {
            var idObj = (organizationId);
            var uriParameters = new OrganizationStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new OrganizationStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.OrganizationStateEvent.Get(req);
            OrganizationProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IOrganizationStateEvent GetStateEvent(string organizationId, long version)
        {
            return GetStateEventAsync(organizationId, version).GetAwaiter().GetResult();
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


    public partial class OrganizationApplicationServiceProxyFactory : ProxyFactoryBase, IOrganizationApplicationServiceFactory
    {

        public OrganizationApplicationServiceProxyFactory() : base()
        {}

        public OrganizationApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IOrganizationApplicationService OrganizationApplicationService
        {
            get
            {
                return new OrganizationApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateOrganization NewCreateOrganization()
        {
            return new CreateOrganizationDto();
        }

        public IMergePatchOrganization NewMergePatchOrganization()
        {
            return new MergePatchOrganizationDto();
        }

        public IDeleteOrganization NewDeleteOrganization()
        {
            return new DeleteOrganizationDto();
        }
    }

    public static class OrganizationProxyUtils
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

        public static IEnumerable<string> ToIdCollection(IEnumerable<IOrganizationState> states)
        {
            var ids = new List<string>();
            foreach (var s in states)
            {
                ids.Add(s.OrganizationId);
            }
            return ids;
        }

    }

}

