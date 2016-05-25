﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dddml.Wms.Domain;

using Dddml.Wms.Specialization;
using Dddml.Wms.HttpServices.ClientProxies.Raml;
using Dddml.Wms.HttpServices.ClientProxies.Raml.Models;
using System.Text;
using System.ComponentModel;
using RAML.Api.Core;
using Newtonsoft.Json.Linq;
using Dddml.Support.Criterion;


namespace Dddml.Wms.HttpServices.ClientProxies
{

    public partial class AttributeSetInstanceExtensionFieldGroupApplicationServiceProxy : IAttributeSetInstanceExtensionFieldGroupApplicationService
    {


        private DddmlWmsRamlClient _ramlClient;

        public AttributeSetInstanceExtensionFieldGroupApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public AttributeSetInstanceExtensionFieldGroupApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public void When(CreateAttributeSetInstanceExtensionFieldGroupDto c)
        {
            //Action act = async () =>
            //{
            var idObj = ((c as ICreateAttributeSetInstanceExtensionFieldGroup).Id);
            var uriParameters = new AttributeSetInstanceExtensionFieldGroupUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributeSetInstanceExtensionFieldGroupPutRequest(uriParameters, (CreateAttributeSetInstanceExtensionFieldGroupDto)c);
                
            var resp = _ramlClient.AttributeSetInstanceExtensionFieldGroup.Put(req).GetAwaiter().GetResult();
            ThrowOnHttpResponseError(resp);
            //};
            //act();
        }

        public void When(MergePatchAttributeSetInstanceExtensionFieldGroupDto c)
        {
            //Action act = async () =>
            //{
            var idObj = ((c as IMergePatchAttributeSetInstanceExtensionFieldGroup).Id);
            var uriParameters = new AttributeSetInstanceExtensionFieldGroupUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributeSetInstanceExtensionFieldGroupPatchRequest(uriParameters, (MergePatchAttributeSetInstanceExtensionFieldGroupDto)c);
            var resp = _ramlClient.AttributeSetInstanceExtensionFieldGroup.Patch(req).GetAwaiter().GetResult();
            ThrowOnHttpResponseError(resp);
            //};
            //act();
        }

        public void When(DeleteAttributeSetInstanceExtensionFieldGroupDto c)
        {
            //Action act = async () =>
            //{
            var idObj = ((c as IDeleteAttributeSetInstanceExtensionFieldGroup).Id);
            var uriParameters = new AttributeSetInstanceExtensionFieldGroupUriParameters();
            uriParameters.Id = idObj;

            var q = new AttributeSetInstanceExtensionFieldGroupDeleteQuery();
            q.CommandId = c.CommandId;
                
            var req = new AttributeSetInstanceExtensionFieldGroupDeleteRequest(uriParameters);
            req.Query = q;

            var resp = _ramlClient.AttributeSetInstanceExtensionFieldGroup.Delete(req).GetAwaiter().GetResult();
            ThrowOnHttpResponseError(resp);
            //};
            //act();
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

        public IAttributeSetInstanceExtensionFieldGroupState Get(string id)
        {
            IAttributeSetInstanceExtensionFieldGroupState state = null;
            //Action act = async () =>
            //{
            var idObj = (id);
            var uriParameters = new AttributeSetInstanceExtensionFieldGroupUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributeSetInstanceExtensionFieldGroupGetRequest(uriParameters);

            var resp = _ramlClient.AttributeSetInstanceExtensionFieldGroup.Get(req).GetAwaiter().GetResult();
            ThrowOnHttpResponseError(resp);
            state = resp.Content;
            //};
            //act();
            return state;
        }

        public IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> Get(IDictionary<string, object> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> Get(IDictionary<string, object> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> states = null;
			var q = new AttributeSetInstanceExtensionFieldGroupsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = GetOrdersQueryValueString(orders);
            q.Fields = GetReturnedFieldsQueryValueString(fields);
            q.FilterTag = GetFilterTagQueryValueString(filter);
            var req = new AttributeSetInstanceExtensionFieldGroupsGetRequest();
            req.Query = q;
            var resp = _ramlClient.AttributeSetInstanceExtensionFieldGroups.Get(req).GetAwaiter().GetResult();
            ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }


        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IAttributeSetInstanceExtensionFieldGroupStateEvent GetStateEvent(string id, long version)
        {
            throw new NotImplementedException(); // TODO
        }

        public IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> states = null;
			var q = new AttributeSetInstanceExtensionFieldGroupsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = GetOrdersQueryValueString(orders);
            q.Fields = GetReturnedFieldsQueryValueString(fields);
            if (filter != null)
            {
                q.Filter = WebUtility.UrlEncode(JObject.FromObject(new CriterionDto(filter, new ProxyTypeConverter())).ToString());
            }
            var req = new AttributeSetInstanceExtensionFieldGroupsGetRequest();
            req.Query = q;
            var resp = _ramlClient.AttributeSetInstanceExtensionFieldGroups.Get(req).GetAwaiter().GetResult();
            ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }


        protected virtual string GetFilterTagQueryValueString(IDictionary<string, object> filter)
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

        protected virtual string GetReturnedFieldsQueryValueString(IList<string> fields)
        {
            if (fields == null) { return null; }
            StringBuilder sb = new StringBuilder();
            foreach (var f in fields)
            {
                sb.Append(WebUtility.UrlEncode(f));
                sb.Append(QueryFieldValueSeparator);
            }
            return sb.ToString();
        }

        protected virtual string GetOrdersQueryValueString(IList<string> orders)
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


        protected virtual string QueryFieldValueSeparator
        {
            get { return ","; }
        }

        protected virtual string QueryOrderSeparator
        {
            get { return ","; }
        }

        protected virtual void ThrowOnHttpResponseError(ApiResponse resp)
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

    }


    public partial class AttributeSetInstanceExtensionFieldGroupApplicationServiceProxyFactory : IAttributeSetInstanceExtensionFieldGroupApplicationServiceFactory
    {

        private string _endpointUrl;

        public AttributeSetInstanceExtensionFieldGroupApplicationServiceProxyFactory(string endpointUrl)
        {
            this._endpointUrl = endpointUrl;
        }

        public IAttributeSetInstanceExtensionFieldGroupApplicationService AttributeSetInstanceExtensionFieldGroupApplicationService
        {
            get
            {
                return new AttributeSetInstanceExtensionFieldGroupApplicationServiceProxy(_endpointUrl);
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


}

