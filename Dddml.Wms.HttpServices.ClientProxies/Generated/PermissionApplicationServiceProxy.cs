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

    public partial class PermissionApplicationServiceProxy : IPermissionApplicationService
    {


        private DddmlWmsRamlClient _ramlClient;

        public PermissionApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public PermissionApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public void When(CreatePermissionDto c)
        {
            var idObj = ((c as ICreatePermission).PermissionId);
            var uriParameters = new PermissionUriParameters();
            uriParameters.Id = idObj;

            var req = new PermissionPutRequest(uriParameters, (CreatePermissionDto)c);
                
            var resp = _ramlClient.Permission.Put(req).GetAwaiter().GetResult();
            PermissionProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchPermissionDto c)
        {
            var idObj = ((c as IMergePatchPermission).PermissionId);
            var uriParameters = new PermissionUriParameters();
            uriParameters.Id = idObj;

            var req = new PermissionPatchRequest(uriParameters, (MergePatchPermissionDto)c);
            var resp = _ramlClient.Permission.Patch(req).GetAwaiter().GetResult();
            PermissionProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeletePermissionDto c)
        {
            //Action act = async () =>
            //{
            var idObj = ((c as IDeletePermission).PermissionId);
            var uriParameters = new PermissionUriParameters();
            uriParameters.Id = idObj;

            var q = new PermissionDeleteQuery();
            q.CommandId = c.CommandId;
                
            var req = new PermissionDeleteRequest(uriParameters);
            req.Query = q;

            var resp = _ramlClient.Permission.Delete(req).GetAwaiter().GetResult();
            PermissionProxyUtils.ThrowOnHttpResponseError(resp);
            //};
            //act();
        }
		
        void IPermissionApplicationService.When(ICreatePermission c)
        {
            this.When((CreatePermissionDto)c);
        }

        void IPermissionApplicationService.When(IMergePatchPermission c)
        {
            this.When((MergePatchPermissionDto)c);
        }

        void IPermissionApplicationService.When(IDeletePermission c)
        {
            this.When((DeletePermissionDto)c);
        }

        public IPermissionState Get(string permissionId)
        {
            IPermissionState state = null;
            var idObj = (permissionId);
            var uriParameters = new PermissionUriParameters();
            uriParameters.Id = idObj;

            var req = new PermissionGetRequest(uriParameters);

            var resp = _ramlClient.Permission.Get(req).GetAwaiter().GetResult();
            PermissionProxyUtils.ThrowOnHttpResponseError(resp);
            state = resp.Content;
            return state;
        }

        public IEnumerable<IPermissionState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IPermissionState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IPermissionState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IPermissionState> states = null;
			var q = new PermissionsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = PermissionProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = PermissionProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = PermissionProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new PermissionsGetRequest();
            req.Query = q;
            var resp = _ramlClient.Permissions.Get(req).GetAwaiter().GetResult();
            PermissionProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<IPermissionState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IPermissionState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IPermissionState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IPermissionState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IPermissionState> states = null;
			var q = new PermissionsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = PermissionProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = PermissionProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = PermissionProxyUtils.GetFilterQueryValueString(filter);
            var req = new PermissionsGetRequest();
            req.Query = q;
            var resp = _ramlClient.Permissions.Get(req).GetAwaiter().GetResult();
            PermissionProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new PermissionsCountGetQuery();
            q.FilterTag = PermissionProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new PermissionsCountGetRequest();
            req.Query = q;
            var resp = _ramlClient.PermissionsCount.Get(req).GetAwaiter().GetResult();
            PermissionProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(resp.RawContent.ReadAsStringAsync().GetAwaiter().GetResult());
		}

        public virtual long GetCount(ICriterion filter)
		{
			var q = new PermissionsCountGetQuery();
            q.Filter = PermissionProxyUtils.GetFilterQueryValueString(filter);
            var req = new PermissionsCountGetRequest();
            req.Query = q;
            var resp = _ramlClient.PermissionsCount.Get(req).GetAwaiter().GetResult();
            PermissionProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(resp.RawContent.ReadAsStringAsync().GetAwaiter().GetResult());
		}

        public IPermissionStateEvent GetStateEvent(string permissionId, long version)
        {
            var idObj = (permissionId);
            var uriParameters = new PermissionStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new PermissionStateEventGetRequest(uriParameters);
            var resp = _ramlClient.PermissionStateEvent.Get(req).GetAwaiter().GetResult();
            PermissionProxyUtils.ThrowOnHttpResponseError(resp);
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


    public partial class PermissionApplicationServiceProxyFactory : IPermissionApplicationServiceFactory
    {

        private string _endpointUrl;

        public PermissionApplicationServiceProxyFactory(string endpointUrl)
        {
            this._endpointUrl = endpointUrl;
        }

        public IPermissionApplicationService PermissionApplicationService
        {
            get
            {
                return new PermissionApplicationServiceProxy(_endpointUrl);
            }
        }

        public ICreatePermission NewCreatePermission()
        {
            return new CreatePermissionDto();
        }

        public IMergePatchPermission NewMergePatchPermission()
        {
            return new MergePatchPermissionDto();
        }

        public IDeletePermission NewDeletePermission()
        {
            return new DeletePermissionDto();
        }
    }

    public static class PermissionProxyUtils
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

        public static IEnumerable<string> ToIdCollection(IEnumerable<IPermissionState> states)
        {
            var ids = new List<string>();
            foreach (var s in states)
            {
                ids.Add(s.PermissionId);
            }
            return ids;
        }

    }

}

