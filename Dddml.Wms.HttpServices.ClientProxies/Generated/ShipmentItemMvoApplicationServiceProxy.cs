﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentItemMvo;
using Dddml.Wms.Domain.Shipment;
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

    public partial class ShipmentItemMvoApplicationServiceProxy : IShipmentItemMvoApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public ShipmentItemMvoApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public ShipmentItemMvoApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public ShipmentItemMvoApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateShipmentItemMvoDto c)
        {
            var idObj = ShipmentItemMvoProxyUtils.ToIdString((c as ICreateShipmentItemMvo).ShipmentItemId);
            var uriParameters = new ShipmentItemMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new ShipmentItemMvoPutRequest(uriParameters, (CreateShipmentItemMvoDto)c);
                
            var resp = await _ramlClient.ShipmentItemMvo.Put(req);
            ShipmentItemMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateShipmentItemMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchShipmentItemMvoDto c)
        {
            var idObj = ShipmentItemMvoProxyUtils.ToIdString((c as IMergePatchShipmentItemMvo).ShipmentItemId);
            var uriParameters = new ShipmentItemMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new ShipmentItemMvoPatchRequest(uriParameters, (MergePatchShipmentItemMvoDto)c);
            var resp = await _ramlClient.ShipmentItemMvo.Patch(req);
            ShipmentItemMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchShipmentItemMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteShipmentItemMvoDto c)
        {
            var idObj = ShipmentItemMvoProxyUtils.ToIdString((c as IDeleteShipmentItemMvo).ShipmentItemId);
            var uriParameters = new ShipmentItemMvoUriParameters();
            uriParameters.Id = idObj;

            var q = new ShipmentItemMvoDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.ShipmentVersion);
                
            var req = new ShipmentItemMvoDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.ShipmentItemMvo.Delete(req);
            ShipmentItemMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteShipmentItemMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IShipmentItemMvoApplicationService.When(ICreateShipmentItemMvo c)
        {
            this.When((CreateShipmentItemMvoDto)c);
        }

        void IShipmentItemMvoApplicationService.When(IMergePatchShipmentItemMvo c)
        {
            this.When((MergePatchShipmentItemMvoDto)c);
        }

        public async Task<IShipmentItemMvoState> GetAsync(ShipmentItemId shipmentItemId)
        {
            IShipmentItemMvoState state = null;
            var idObj = ShipmentItemMvoProxyUtils.ToIdString(shipmentItemId);
            var uriParameters = new ShipmentItemMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new ShipmentItemMvoGetRequest(uriParameters);

            var resp = await _ramlClient.ShipmentItemMvo.Get(req);
            ShipmentItemMvoProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToShipmentItemMvoState();
            return state;
        }

        public IShipmentItemMvoState Get(ShipmentItemId shipmentItemId)
        {
            return GetAsync(shipmentItemId).GetAwaiter().GetResult();
        }


        public IEnumerable<IShipmentItemMvoState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IShipmentItemMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IShipmentItemMvoState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IShipmentItemMvoState> states = null;
			var q = new ShipmentItemMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = ShipmentItemMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = ShipmentItemMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = ShipmentItemMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new ShipmentItemMvosGetRequest();
            req.Query = q;
            var resp = await _ramlClient.ShipmentItemMvos.Get(req);
            ShipmentItemMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToShipmentItemMvoState());
            return states;
        }

        public IEnumerable<IShipmentItemMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IShipmentItemMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IShipmentItemMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IShipmentItemMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IShipmentItemMvoState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IShipmentItemMvoState> states = null;
			var q = new ShipmentItemMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = ShipmentItemMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = ShipmentItemMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = ShipmentItemMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new ShipmentItemMvosGetRequest();
            req.Query = q;
            var resp = await _ramlClient.ShipmentItemMvos.Get(req);
            ShipmentItemMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToShipmentItemMvoState());
            return states;
        }

        public IEnumerable<IShipmentItemMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new ShipmentItemMvosCountGetQuery();
            q.FilterTag = ShipmentItemMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new ShipmentItemMvosCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.ShipmentItemMvosCount.Get(req);
            ShipmentItemMvoProxyUtils.ThrowOnHttpResponseError(resp);
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
			var q = new ShipmentItemMvosCountGetQuery();
            q.Filter = ShipmentItemMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new ShipmentItemMvosCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.ShipmentItemMvosCount.Get(req);
            ShipmentItemMvoProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IShipmentItemMvoEvent> GetStateEventAsync(ShipmentItemId shipmentItemId, long version)
        {
            var idObj = ShipmentItemMvoProxyUtils.ToIdString(shipmentItemId);
            var uriParameters = new ShipmentItemMvoStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new ShipmentItemMvoStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.ShipmentItemMvoStateEvent.Get(req);
            ShipmentItemMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IShipmentItemMvoEvent GetEvent(ShipmentItemId shipmentItemId, long version)
        {
            return GetStateEventAsync(shipmentItemId, version).GetAwaiter().GetResult();
        }


        public async Task<IShipmentItemMvoState> GetHistoryStateAsync(ShipmentItemId shipmentItemId, long version)
        {
            var idObj = ShipmentItemMvoProxyUtils.ToIdString(shipmentItemId);
            var uriParameters = new ShipmentItemMvoHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new ShipmentItemMvoHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.ShipmentItemMvoHistoryState.Get(req);
            ShipmentItemMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToShipmentItemMvoState();
        }

        public virtual IShipmentItemMvoState GetHistoryState(ShipmentItemId shipmentItemId, long version)
        {
            return GetHistoryStateAsync(shipmentItemId, version).GetAwaiter().GetResult();
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


    public partial class ShipmentItemMvoApplicationServiceProxyFactory : ProxyFactoryBase, IShipmentItemMvoApplicationServiceFactory
    {

        public ShipmentItemMvoApplicationServiceProxyFactory() : base()
        {}

        public ShipmentItemMvoApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IShipmentItemMvoApplicationService ShipmentItemMvoApplicationService
        {
            get
            {
                return new ShipmentItemMvoApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateShipmentItemMvo NewCreateShipmentItemMvo()
        {
            return new CreateShipmentItemMvoDto();
        }

        public IMergePatchShipmentItemMvo NewMergePatchShipmentItemMvo()
        {
            return new MergePatchShipmentItemMvoDto();
        }

        public IDeleteShipmentItemMvo NewDeleteShipmentItemMvo()
        {
            return new DeleteShipmentItemMvoDto();
        }
    }

    public static class ShipmentItemMvoProxyUtils
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

        public static string ToIdString(ShipmentItemId id)
        {
            var formatter = (new ValueObjectTextFormatter<ShipmentItemId>());
            var idStr = formatter.ToString(id);
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

        public static IEnumerable<ShipmentItemId> ToIdCollection(IEnumerable<IShipmentItemMvoState> states)
        {
            var ids = new List<ShipmentItemId>();
            foreach (var s in states)
            {
                ids.Add(s.ShipmentItemId);
            }
            return ids;
        }

    }

}

