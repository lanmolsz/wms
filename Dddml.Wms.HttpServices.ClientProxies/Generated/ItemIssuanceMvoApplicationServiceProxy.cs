﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ItemIssuanceMvo;
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

    public partial class ItemIssuanceMvoApplicationServiceProxy : IItemIssuanceMvoApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public ItemIssuanceMvoApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public ItemIssuanceMvoApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public ItemIssuanceMvoApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateItemIssuanceMvoDto c)
        {
            var idObj = ItemIssuanceMvoProxyUtils.ToIdString((c as ICreateItemIssuanceMvo).ShipmentItemIssuanceId);
            var uriParameters = new ItemIssuanceMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new ItemIssuanceMvoPutRequest(uriParameters, (CreateItemIssuanceMvoDto)c);
                
            var resp = await _ramlClient.ItemIssuanceMvo.Put(req);
            ItemIssuanceMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateItemIssuanceMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchItemIssuanceMvoDto c)
        {
            var idObj = ItemIssuanceMvoProxyUtils.ToIdString((c as IMergePatchItemIssuanceMvo).ShipmentItemIssuanceId);
            var uriParameters = new ItemIssuanceMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new ItemIssuanceMvoPatchRequest(uriParameters, (MergePatchItemIssuanceMvoDto)c);
            var resp = await _ramlClient.ItemIssuanceMvo.Patch(req);
            ItemIssuanceMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchItemIssuanceMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteItemIssuanceMvoDto c)
        {
            var idObj = ItemIssuanceMvoProxyUtils.ToIdString((c as IDeleteItemIssuanceMvo).ShipmentItemIssuanceId);
            var uriParameters = new ItemIssuanceMvoUriParameters();
            uriParameters.Id = idObj;

            var q = new ItemIssuanceMvoDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.ShipmentVersion);
                
            var req = new ItemIssuanceMvoDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.ItemIssuanceMvo.Delete(req);
            ItemIssuanceMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteItemIssuanceMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IItemIssuanceMvoApplicationService.When(ICreateItemIssuanceMvo c)
        {
            this.When((CreateItemIssuanceMvoDto)c);
        }

        void IItemIssuanceMvoApplicationService.When(IMergePatchItemIssuanceMvo c)
        {
            this.When((MergePatchItemIssuanceMvoDto)c);
        }

        void IItemIssuanceMvoApplicationService.When(IDeleteItemIssuanceMvo c)
        {
            this.When((DeleteItemIssuanceMvoDto)c);
        }

        public async Task<IItemIssuanceMvoState> GetAsync(ShipmentItemIssuanceId shipmentItemIssuanceId)
        {
            IItemIssuanceMvoState state = null;
            var idObj = ItemIssuanceMvoProxyUtils.ToIdString(shipmentItemIssuanceId);
            var uriParameters = new ItemIssuanceMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new ItemIssuanceMvoGetRequest(uriParameters);

            var resp = await _ramlClient.ItemIssuanceMvo.Get(req);
            ItemIssuanceMvoProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToItemIssuanceMvoState();
            return state;
        }

        public IItemIssuanceMvoState Get(ShipmentItemIssuanceId shipmentItemIssuanceId)
        {
            return GetAsync(shipmentItemIssuanceId).GetAwaiter().GetResult();
        }


        public IEnumerable<IItemIssuanceMvoState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IItemIssuanceMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IItemIssuanceMvoState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IItemIssuanceMvoState> states = null;
			var q = new ItemIssuanceMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = ItemIssuanceMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = ItemIssuanceMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = ItemIssuanceMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new ItemIssuanceMvosGetRequest();
            req.Query = q;
            var resp = await _ramlClient.ItemIssuanceMvos.Get(req);
            ItemIssuanceMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToItemIssuanceMvoState());
            return states;
        }

        public IEnumerable<IItemIssuanceMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IItemIssuanceMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IItemIssuanceMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IItemIssuanceMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IItemIssuanceMvoState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IItemIssuanceMvoState> states = null;
			var q = new ItemIssuanceMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = ItemIssuanceMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = ItemIssuanceMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = ItemIssuanceMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new ItemIssuanceMvosGetRequest();
            req.Query = q;
            var resp = await _ramlClient.ItemIssuanceMvos.Get(req);
            ItemIssuanceMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToItemIssuanceMvoState());
            return states;
        }

        public IEnumerable<IItemIssuanceMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new ItemIssuanceMvosCountGetQuery();
            q.FilterTag = ItemIssuanceMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new ItemIssuanceMvosCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.ItemIssuanceMvosCount.Get(req);
            ItemIssuanceMvoProxyUtils.ThrowOnHttpResponseError(resp);
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
			var q = new ItemIssuanceMvosCountGetQuery();
            q.Filter = ItemIssuanceMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new ItemIssuanceMvosCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.ItemIssuanceMvosCount.Get(req);
            ItemIssuanceMvoProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IItemIssuanceMvoStateEvent> GetStateEventAsync(ShipmentItemIssuanceId shipmentItemIssuanceId, long version)
        {
            var idObj = ItemIssuanceMvoProxyUtils.ToIdString(shipmentItemIssuanceId);
            var uriParameters = new ItemIssuanceMvoStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new ItemIssuanceMvoStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.ItemIssuanceMvoStateEvent.Get(req);
            ItemIssuanceMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IItemIssuanceMvoStateEvent GetStateEvent(ShipmentItemIssuanceId shipmentItemIssuanceId, long version)
        {
            return GetStateEventAsync(shipmentItemIssuanceId, version).GetAwaiter().GetResult();
        }


        public async Task<IItemIssuanceMvoState> GetHistoryStateAsync(ShipmentItemIssuanceId shipmentItemIssuanceId, long version)
        {
            var idObj = ItemIssuanceMvoProxyUtils.ToIdString(shipmentItemIssuanceId);
            var uriParameters = new ItemIssuanceMvoHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new ItemIssuanceMvoHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.ItemIssuanceMvoHistoryState.Get(req);
            ItemIssuanceMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToItemIssuanceMvoState();
        }

        public virtual IItemIssuanceMvoState GetHistoryState(ShipmentItemIssuanceId shipmentItemIssuanceId, long version)
        {
            return GetHistoryStateAsync(shipmentItemIssuanceId, version).GetAwaiter().GetResult();
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


    public partial class ItemIssuanceMvoApplicationServiceProxyFactory : ProxyFactoryBase, IItemIssuanceMvoApplicationServiceFactory
    {

        public ItemIssuanceMvoApplicationServiceProxyFactory() : base()
        {}

        public ItemIssuanceMvoApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IItemIssuanceMvoApplicationService ItemIssuanceMvoApplicationService
        {
            get
            {
                return new ItemIssuanceMvoApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateItemIssuanceMvo NewCreateItemIssuanceMvo()
        {
            return new CreateItemIssuanceMvoDto();
        }

        public IMergePatchItemIssuanceMvo NewMergePatchItemIssuanceMvo()
        {
            return new MergePatchItemIssuanceMvoDto();
        }

        public IDeleteItemIssuanceMvo NewDeleteItemIssuanceMvo()
        {
            return new DeleteItemIssuanceMvoDto();
        }
    }

    public static class ItemIssuanceMvoProxyUtils
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

        public static string ToIdString(ShipmentItemIssuanceId id)
        {
            var formatter = (new ValueObjectTextFormatter<ShipmentItemIssuanceId>());
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

        public static IEnumerable<ShipmentItemIssuanceId> ToIdCollection(IEnumerable<IItemIssuanceMvoState> states)
        {
            var ids = new List<ShipmentItemIssuanceId>();
            foreach (var s in states)
            {
                ids.Add(s.ShipmentItemIssuanceId);
            }
            return ids;
        }

    }

}
