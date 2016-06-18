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

    public partial class OrganizationStructureApplicationServiceProxy : IOrganizationStructureApplicationService
    {


        private DddmlWmsRamlClient _ramlClient;

        public OrganizationStructureApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public OrganizationStructureApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public void When(CreateOrganizationStructureDto c)
        {
            var idObj = OrganizationStructureProxyUtils.ToIdString((c as ICreateOrganizationStructure).Id);
            var uriParameters = new OrganizationStructureUriParameters();
            uriParameters.Id = idObj;

            var req = new OrganizationStructurePutRequest(uriParameters, (CreateOrganizationStructureDto)c);
                
            var resp = _ramlClient.OrganizationStructure.Put(req).GetAwaiter().GetResult();
            OrganizationStructureProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchOrganizationStructureDto c)
        {
            var idObj = OrganizationStructureProxyUtils.ToIdString((c as IMergePatchOrganizationStructure).Id);
            var uriParameters = new OrganizationStructureUriParameters();
            uriParameters.Id = idObj;

            var req = new OrganizationStructurePatchRequest(uriParameters, (MergePatchOrganizationStructureDto)c);
            var resp = _ramlClient.OrganizationStructure.Patch(req).GetAwaiter().GetResult();
            OrganizationStructureProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteOrganizationStructureDto c)
        {
            //Action act = async () =>
            //{
            var idObj = OrganizationStructureProxyUtils.ToIdString((c as IDeleteOrganizationStructure).Id);
            var uriParameters = new OrganizationStructureUriParameters();
            uriParameters.Id = idObj;

            var q = new OrganizationStructureDeleteQuery();
            q.CommandId = c.CommandId;
                
            var req = new OrganizationStructureDeleteRequest(uriParameters);
            req.Query = q;

            var resp = _ramlClient.OrganizationStructure.Delete(req).GetAwaiter().GetResult();
            OrganizationStructureProxyUtils.ThrowOnHttpResponseError(resp);
            //};
            //act();
        }
		
        void IOrganizationStructureApplicationService.When(ICreateOrganizationStructure c)
        {
            this.When((CreateOrganizationStructureDto)c);
        }

        void IOrganizationStructureApplicationService.When(IMergePatchOrganizationStructure c)
        {
            this.When((MergePatchOrganizationStructureDto)c);
        }

        void IOrganizationStructureApplicationService.When(IDeleteOrganizationStructure c)
        {
            this.When((DeleteOrganizationStructureDto)c);
        }

        public IOrganizationStructureState Get(OrganizationStructureId id)
        {
            IOrganizationStructureState state = null;
            var idObj = OrganizationStructureProxyUtils.ToIdString(id);
            var uriParameters = new OrganizationStructureUriParameters();
            uriParameters.Id = idObj;

            var req = new OrganizationStructureGetRequest(uriParameters);

            var resp = _ramlClient.OrganizationStructure.Get(req).GetAwaiter().GetResult();
            OrganizationStructureProxyUtils.ThrowOnHttpResponseError(resp);
            state = resp.Content;
            return state;
        }

        public IEnumerable<IOrganizationStructureState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IOrganizationStructureState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IOrganizationStructureState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IOrganizationStructureState> states = null;
			var q = new OrganizationStructuresGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = OrganizationStructureProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = OrganizationStructureProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = OrganizationStructureProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new OrganizationStructuresGetRequest();
            req.Query = q;
            var resp = _ramlClient.OrganizationStructures.Get(req).GetAwaiter().GetResult();
            OrganizationStructureProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<IOrganizationStructureState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IOrganizationStructureState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IOrganizationStructureState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IOrganizationStructureState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IOrganizationStructureState> states = null;
			var q = new OrganizationStructuresGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = OrganizationStructureProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = OrganizationStructureProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = OrganizationStructureProxyUtils.GetFilterQueryValueString(filter);
            var req = new OrganizationStructuresGetRequest();
            req.Query = q;
            var resp = _ramlClient.OrganizationStructures.Get(req).GetAwaiter().GetResult();
            OrganizationStructureProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new OrganizationStructuresCountGetQuery();
            q.FilterTag = OrganizationStructureProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new OrganizationStructuresCountGetRequest();
            req.Query = q;
            var resp = _ramlClient.OrganizationStructuresCount.Get(req).GetAwaiter().GetResult();
            OrganizationStructureProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(resp.RawContent.ReadAsStringAsync().GetAwaiter().GetResult());
		}

        public virtual long GetCount(ICriterion filter)
		{
			var q = new OrganizationStructuresCountGetQuery();
            q.Filter = OrganizationStructureProxyUtils.GetFilterQueryValueString(filter);
            var req = new OrganizationStructuresCountGetRequest();
            req.Query = q;
            var resp = _ramlClient.OrganizationStructuresCount.Get(req).GetAwaiter().GetResult();
            OrganizationStructureProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(resp.RawContent.ReadAsStringAsync().GetAwaiter().GetResult());
		}

        public IOrganizationStructureStateEvent GetStateEvent(OrganizationStructureId id, long version)
        {
            var idObj = OrganizationStructureProxyUtils.ToIdString(id);
            var uriParameters = new OrganizationStructureStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new OrganizationStructureStateEventGetRequest(uriParameters);
            var resp = _ramlClient.OrganizationStructureStateEvent.Get(req).GetAwaiter().GetResult();
            OrganizationStructureProxyUtils.ThrowOnHttpResponseError(resp);
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


    public partial class OrganizationStructureApplicationServiceProxyFactory : IOrganizationStructureApplicationServiceFactory
    {

        private string _endpointUrl;

        public OrganizationStructureApplicationServiceProxyFactory(string endpointUrl)
        {
            this._endpointUrl = endpointUrl;
        }

        public IOrganizationStructureApplicationService OrganizationStructureApplicationService
        {
            get
            {
                return new OrganizationStructureApplicationServiceProxy(_endpointUrl);
            }
        }

        public ICreateOrganizationStructure NewCreateOrganizationStructure()
        {
            return new CreateOrganizationStructureDto();
        }

        public IMergePatchOrganizationStructure NewMergePatchOrganizationStructure()
        {
            return new MergePatchOrganizationStructureDto();
        }

        public IDeleteOrganizationStructure NewDeleteOrganizationStructure()
        {
            return new DeleteOrganizationStructureDto();
        }
    }

    public static class OrganizationStructureProxyUtils
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

        public static string ToIdString(OrganizationStructureId id)
        {
            var formatter = new OrganizationStructureIdFlattenedDtoFormatter();
            var idDto = new OrganizationStructureIdFlattenedDto(id);
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

        public static IEnumerable<OrganizationStructureId> ToIdCollection(IEnumerable<IOrganizationStructureState> states)
        {
            var ids = new List<OrganizationStructureId>();
            foreach (var s in states)
            {
                ids.Add(s.Id);
            }
            return ids;
        }

    }

}

