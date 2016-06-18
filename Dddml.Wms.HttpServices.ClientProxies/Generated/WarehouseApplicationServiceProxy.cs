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
using System.Net.Http;
using System.Web.Http;
using Dddml.Wms.HttpServices.ClientProxies.Raml;
using Dddml.Wms.HttpServices.ClientProxies.Raml.Models;
using System.Text;
using System.ComponentModel;
using RAML.Api.Core;
using Newtonsoft.Json.Linq;
using Dddml.Support.Criterion;


namespace Dddml.Wms.HttpServices.ClientProxies
{

    public partial class WarehouseApplicationServiceProxy : IWarehouseApplicationService
    {


        private DddmlWmsRamlClient _ramlClient;

        public WarehouseApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public WarehouseApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public void When(CreateWarehouseDto c)
        {
            var idObj = ((c as ICreateWarehouse).WarehouseId);
            var uriParameters = new WarehouseUriParameters();
            uriParameters.Id = idObj;

            var req = new WarehousePutRequest(uriParameters, (CreateWarehouseDto)c);
                
            var resp = _ramlClient.Warehouse.Put(req).GetAwaiter().GetResult();
            WarehouseProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchWarehouseDto c)
        {
            var idObj = ((c as IMergePatchWarehouse).WarehouseId);
            var uriParameters = new WarehouseUriParameters();
            uriParameters.Id = idObj;

            var req = new WarehousePatchRequest(uriParameters, (MergePatchWarehouseDto)c);
            var resp = _ramlClient.Warehouse.Patch(req).GetAwaiter().GetResult();
            WarehouseProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteWarehouseDto c)
        {
            //Action act = async () =>
            //{
            var idObj = ((c as IDeleteWarehouse).WarehouseId);
            var uriParameters = new WarehouseUriParameters();
            uriParameters.Id = idObj;

            var q = new WarehouseDeleteQuery();
            q.CommandId = c.CommandId;
                
            var req = new WarehouseDeleteRequest(uriParameters);
            req.Query = q;

            var resp = _ramlClient.Warehouse.Delete(req).GetAwaiter().GetResult();
            WarehouseProxyUtils.ThrowOnHttpResponseError(resp);
            //};
            //act();
        }
		
        void IWarehouseApplicationService.When(ICreateWarehouse c)
        {
            this.When((CreateWarehouseDto)c);
        }

        void IWarehouseApplicationService.When(IMergePatchWarehouse c)
        {
            this.When((MergePatchWarehouseDto)c);
        }

        void IWarehouseApplicationService.When(IDeleteWarehouse c)
        {
            this.When((DeleteWarehouseDto)c);
        }

        public IWarehouseState Get(string warehouseId)
        {
            IWarehouseState state = null;
            var idObj = (warehouseId);
            var uriParameters = new WarehouseUriParameters();
            uriParameters.Id = idObj;

            var req = new WarehouseGetRequest(uriParameters);

            var resp = _ramlClient.Warehouse.Get(req).GetAwaiter().GetResult();
            WarehouseProxyUtils.ThrowOnHttpResponseError(resp);
            state = resp.Content;
            return state;
        }

        public IEnumerable<IWarehouseState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IWarehouseState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IWarehouseState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IWarehouseState> states = null;
			var q = new WarehousesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = WarehouseProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = WarehouseProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = WarehouseProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new WarehousesGetRequest();
            req.Query = q;
            var resp = _ramlClient.Warehouses.Get(req).GetAwaiter().GetResult();
            WarehouseProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<IWarehouseState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IWarehouseState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IWarehouseState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IWarehouseState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IWarehouseState> states = null;
			var q = new WarehousesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = WarehouseProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = WarehouseProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = WarehouseProxyUtils.GetFilterQueryValueString(filter);
            var req = new WarehousesGetRequest();
            req.Query = q;
            var resp = _ramlClient.Warehouses.Get(req).GetAwaiter().GetResult();
            WarehouseProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new WarehousesCountGetQuery();
            q.FilterTag = WarehouseProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new WarehousesCountGetRequest();
            req.Query = q;
            var resp = _ramlClient.WarehousesCount.Get(req).GetAwaiter().GetResult();
            WarehouseProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(resp.RawContent.ReadAsStringAsync().GetAwaiter().GetResult());
		}

        public virtual long GetCount(ICriterion filter)
		{
			var q = new WarehousesCountGetQuery();
            q.Filter = WarehouseProxyUtils.GetFilterQueryValueString(filter);
            var req = new WarehousesCountGetRequest();
            req.Query = q;
            var resp = _ramlClient.WarehousesCount.Get(req).GetAwaiter().GetResult();
            WarehouseProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(resp.RawContent.ReadAsStringAsync().GetAwaiter().GetResult());
		}

        public IWarehouseStateEvent GetStateEvent(string warehouseId, long version)
        {
            var idObj = (warehouseId);
            var uriParameters = new WarehouseStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new WarehouseStateEventGetRequest(uriParameters);
            var resp = _ramlClient.WarehouseStateEvent.Get(req).GetAwaiter().GetResult();
            WarehouseProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
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


    public partial class WarehouseApplicationServiceProxyFactory : IWarehouseApplicationServiceFactory
    {

        private string _endpointUrl;

        public WarehouseApplicationServiceProxyFactory(string endpointUrl)
        {
            this._endpointUrl = endpointUrl;
        }

        public IWarehouseApplicationService WarehouseApplicationService
        {
            get
            {
                return new WarehouseApplicationServiceProxy(_endpointUrl);
            }
        }

        public ICreateWarehouse NewCreateWarehouse()
        {
            return new CreateWarehouseDto();
        }

        public IMergePatchWarehouse NewMergePatchWarehouse()
        {
            return new MergePatchWarehouseDto();
        }

        public IDeleteWarehouse NewDeleteWarehouse()
        {
            return new DeleteWarehouseDto();
        }
    }

    public static class WarehouseProxyUtils
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

        public static IEnumerable<string> ToIdCollection(IEnumerable<IWarehouseState> states)
        {
            var ids = new List<string>();
            foreach (var s in states)
            {
                ids.Add(s.WarehouseId);
            }
            return ids;
        }

    }

}

