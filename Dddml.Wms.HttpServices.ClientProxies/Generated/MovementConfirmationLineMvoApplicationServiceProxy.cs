﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementConfirmationLineMvo;
using Dddml.Wms.Domain.Movement;
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

    public partial class MovementConfirmationLineMvoApplicationServiceProxy : IMovementConfirmationLineMvoApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public MovementConfirmationLineMvoApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public MovementConfirmationLineMvoApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public MovementConfirmationLineMvoApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateMovementConfirmationLineMvoDto c)
        {
            var idObj = MovementConfirmationLineMvoProxyUtils.ToIdString((c as ICreateMovementConfirmationLineMvo).MovementConfirmationLineId);
            var uriParameters = new MovementConfirmationLineMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new MovementConfirmationLineMvoPutRequest(uriParameters, (CreateMovementConfirmationLineMvoDto)c);
                
            var resp = await _ramlClient.MovementConfirmationLineMvo.Put(req);
            MovementConfirmationLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateMovementConfirmationLineMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchMovementConfirmationLineMvoDto c)
        {
            var idObj = MovementConfirmationLineMvoProxyUtils.ToIdString((c as IMergePatchMovementConfirmationLineMvo).MovementConfirmationLineId);
            var uriParameters = new MovementConfirmationLineMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new MovementConfirmationLineMvoPatchRequest(uriParameters, (MergePatchMovementConfirmationLineMvoDto)c);
            var resp = await _ramlClient.MovementConfirmationLineMvo.Patch(req);
            MovementConfirmationLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchMovementConfirmationLineMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteMovementConfirmationLineMvoDto c)
        {
            var idObj = MovementConfirmationLineMvoProxyUtils.ToIdString((c as IDeleteMovementConfirmationLineMvo).MovementConfirmationLineId);
            var uriParameters = new MovementConfirmationLineMvoUriParameters();
            uriParameters.Id = idObj;

            var q = new MovementConfirmationLineMvoDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.MovementVersion);
                
            var req = new MovementConfirmationLineMvoDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.MovementConfirmationLineMvo.Delete(req);
            MovementConfirmationLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteMovementConfirmationLineMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IMovementConfirmationLineMvoApplicationService.When(ICreateMovementConfirmationLineMvo c)
        {
            this.When((CreateMovementConfirmationLineMvoDto)c);
        }

        void IMovementConfirmationLineMvoApplicationService.When(IMergePatchMovementConfirmationLineMvo c)
        {
            this.When((MergePatchMovementConfirmationLineMvoDto)c);
        }

        void IMovementConfirmationLineMvoApplicationService.When(IDeleteMovementConfirmationLineMvo c)
        {
            this.When((DeleteMovementConfirmationLineMvoDto)c);
        }

        public async Task<IMovementConfirmationLineMvoState> GetAsync(MovementConfirmationLineId movementConfirmationLineId)
        {
            IMovementConfirmationLineMvoState state = null;
            var idObj = MovementConfirmationLineMvoProxyUtils.ToIdString(movementConfirmationLineId);
            var uriParameters = new MovementConfirmationLineMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new MovementConfirmationLineMvoGetRequest(uriParameters);

            var resp = await _ramlClient.MovementConfirmationLineMvo.Get(req);
            MovementConfirmationLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToMovementConfirmationLineMvoState();
            return state;
        }

        public IMovementConfirmationLineMvoState Get(MovementConfirmationLineId movementConfirmationLineId)
        {
            return GetAsync(movementConfirmationLineId).GetAwaiter().GetResult();
        }


        public IEnumerable<IMovementConfirmationLineMvoState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IMovementConfirmationLineMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IMovementConfirmationLineMvoState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IMovementConfirmationLineMvoState> states = null;
			var q = new MovementConfirmationLineMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = MovementConfirmationLineMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = MovementConfirmationLineMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = MovementConfirmationLineMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new MovementConfirmationLineMvosGetRequest();
            req.Query = q;
            var resp = await _ramlClient.MovementConfirmationLineMvos.Get(req);
            MovementConfirmationLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToMovementConfirmationLineMvoState());
            return states;
        }

        public IEnumerable<IMovementConfirmationLineMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IMovementConfirmationLineMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IMovementConfirmationLineMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IMovementConfirmationLineMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IMovementConfirmationLineMvoState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IMovementConfirmationLineMvoState> states = null;
			var q = new MovementConfirmationLineMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = MovementConfirmationLineMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = MovementConfirmationLineMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = MovementConfirmationLineMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new MovementConfirmationLineMvosGetRequest();
            req.Query = q;
            var resp = await _ramlClient.MovementConfirmationLineMvos.Get(req);
            MovementConfirmationLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToMovementConfirmationLineMvoState());
            return states;
        }

        public IEnumerable<IMovementConfirmationLineMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new MovementConfirmationLineMvosCountGetQuery();
            q.FilterTag = MovementConfirmationLineMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new MovementConfirmationLineMvosCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.MovementConfirmationLineMvosCount.Get(req);
            MovementConfirmationLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
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
			var q = new MovementConfirmationLineMvosCountGetQuery();
            q.Filter = MovementConfirmationLineMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new MovementConfirmationLineMvosCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.MovementConfirmationLineMvosCount.Get(req);
            MovementConfirmationLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IMovementConfirmationLineMvoStateEvent> GetStateEventAsync(MovementConfirmationLineId movementConfirmationLineId, long version)
        {
            var idObj = MovementConfirmationLineMvoProxyUtils.ToIdString(movementConfirmationLineId);
            var uriParameters = new MovementConfirmationLineMvoStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new MovementConfirmationLineMvoStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.MovementConfirmationLineMvoStateEvent.Get(req);
            MovementConfirmationLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IMovementConfirmationLineMvoStateEvent GetStateEvent(MovementConfirmationLineId movementConfirmationLineId, long version)
        {
            return GetStateEventAsync(movementConfirmationLineId, version).GetAwaiter().GetResult();
        }


        public async Task<IMovementConfirmationLineMvoState> GetHistoryStateAsync(MovementConfirmationLineId movementConfirmationLineId, long version)
        {
            var idObj = MovementConfirmationLineMvoProxyUtils.ToIdString(movementConfirmationLineId);
            var uriParameters = new MovementConfirmationLineMvoHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new MovementConfirmationLineMvoHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.MovementConfirmationLineMvoHistoryState.Get(req);
            MovementConfirmationLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToMovementConfirmationLineMvoState();
        }

        public virtual IMovementConfirmationLineMvoState GetHistoryState(MovementConfirmationLineId movementConfirmationLineId, long version)
        {
            return GetHistoryStateAsync(movementConfirmationLineId, version).GetAwaiter().GetResult();
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


    public partial class MovementConfirmationLineMvoApplicationServiceProxyFactory : ProxyFactoryBase, IMovementConfirmationLineMvoApplicationServiceFactory
    {

        public MovementConfirmationLineMvoApplicationServiceProxyFactory() : base()
        {}

        public MovementConfirmationLineMvoApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IMovementConfirmationLineMvoApplicationService MovementConfirmationLineMvoApplicationService
        {
            get
            {
                return new MovementConfirmationLineMvoApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateMovementConfirmationLineMvo NewCreateMovementConfirmationLineMvo()
        {
            return new CreateMovementConfirmationLineMvoDto();
        }

        public IMergePatchMovementConfirmationLineMvo NewMergePatchMovementConfirmationLineMvo()
        {
            return new MergePatchMovementConfirmationLineMvoDto();
        }

        public IDeleteMovementConfirmationLineMvo NewDeleteMovementConfirmationLineMvo()
        {
            return new DeleteMovementConfirmationLineMvoDto();
        }
    }

    public static class MovementConfirmationLineMvoProxyUtils
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

        public static string ToIdString(MovementConfirmationLineId id)
        {
            var formatter = new MovementConfirmationLineIdFlattenedDtoFormatter();
            var idDto = new MovementConfirmationLineIdFlattenedDto(id);
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

        public static IEnumerable<MovementConfirmationLineId> ToIdCollection(IEnumerable<IMovementConfirmationLineMvoState> states)
        {
            var ids = new List<MovementConfirmationLineId>();
            foreach (var s in states)
            {
                ids.Add(s.MovementConfirmationLineId);
            }
            return ids;
        }

    }

}

