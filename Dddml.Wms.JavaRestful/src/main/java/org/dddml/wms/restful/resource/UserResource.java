package org.dddml.wms.restful.resource;

import java.util.*;
import javax.servlet.http.HttpServletRequest;
import javax.validation.constraints.*;
import javax.ws.rs.*;
import javax.ws.rs.core.*;

import org.dddml.support.criterion.*;
import java.util.Date;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.meta.*;

import com.alibaba.fastjson.*;
import org.apache.cxf.jaxrs.ext.PATCH;
import org.springframework.beans.factory.annotation.Autowired;
import org.dddml.wms.restful.exception.WebApiApplicationException;


@Path("Users")
@Produces(MediaType.APPLICATION_JSON)
public class UserResource {


    @Autowired
    private UserApplicationService userApplicationService;


    @GET
    public UserStateDto[] getAll(@Context HttpServletRequest request,
                                   @QueryParam("sort") String sort,
                                   @QueryParam("fields") String fields,
                                   @QueryParam("firstResult") @DefaultValue("0") Integer firstResult,
                                   @QueryParam("maxResults") @DefaultValue("2147483647") Integer maxResults,
                                   @QueryParam("filter") String filter) {
        if (firstResult < 0) { firstResult = 0; }
        if (maxResults == null || maxResults < 1) { maxResults = Integer.MAX_VALUE; }
        try {

            Iterable<UserState> states = null; 
            if (!StringHelper.isNullOrEmpty(filter)) {
                states = userApplicationService.get(
                        CriterionDto.toSubclass(
                                JSON.parseObject(filter, CriterionDto.class),
                                getCriterionTypeConverter(), getPropertyTypeResolver()),
                        UserResourceUtils.getQueryOrders(sort, getQueryOrderSeparator()),
                        firstResult, maxResults);
            } else {
                states = userApplicationService.get(
                        UserResourceUtils.getQueryFilterDictionary(request.getParameterMap()),
                        UserResourceUtils.getQueryOrders(sort, getQueryOrderSeparator()),
                        firstResult, maxResults);
            }

            UserStateDto.DtoConverter dtoConverter = new UserStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            return dtoConverter.toUserStateDtoArray(states);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new WebApiApplicationException(ex); }
    }

    @GET
    @Path("{id}")
    public UserStateDto get(@PathParam("id") String id, @QueryParam("fields") String fields) {
        try {
            String idObj = id;
            UserState state = userApplicationService.get(idObj);
            if (state == null) { return null; }

            UserStateDto.DtoConverter dtoConverter = new UserStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            return dtoConverter.toUserStateDto(state);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new WebApiApplicationException(ex); }
    }

    @Path("_count")
    @GET
    public long getCount(@Context HttpServletRequest request,
                         @QueryParam("filter") String filter) {
        try {
            long count = 0;
            if (!StringHelper.isNullOrEmpty(filter)) {
                count = userApplicationService.getCount(CriterionDto.toSubclass(JSONObject.parseObject(filter, CriterionDto.class),
                        getCriterionTypeConverter(), getPropertyTypeResolver()));
            } else {
                count = userApplicationService.getCount(UserResourceUtils.getQueryFilterDictionary(request.getParameterMap()));
            }
            return count;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new WebApiApplicationException(ex); }
    }


    @PUT
    @Path("/{id}")
    public void put(@PathParam("id") String id, CreateOrMergePatchUserDto.CreateUserDto value) {
        try {

            UserCommand.CreateUser cmd = value.toCreateUser();
            UserResourceUtils.setNullIdOrThrowOnInconsistentIds(id, cmd);
            userApplicationService.when(cmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new WebApiApplicationException(ex); }
    }


    @PATCH
    @Path("/{id}")
    public void patch(@PathParam("id") String id, CreateOrMergePatchUserDto.MergePatchUserDto value) {
        try {

            UserCommand.MergePatchUser cmd = value.toMergePatchUser();
            UserResourceUtils.setNullIdOrThrowOnInconsistentIds(id, cmd);
            userApplicationService.when(cmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new WebApiApplicationException(ex); }
    }

    @DELETE
    @Path("/{id}")
    public void delete(@PathParam("id") String id,
                       @NotNull @QueryParam("commandId") String commandId,
                       @NotNull @QueryParam("version") @Min(value = -1) Long version,
                       @QueryParam("requesterId") String requesterId) {
        try {

            UserCommand.DeleteUser deleteCmd = new AbstractUserCommand.SimpleDeleteUser();

            deleteCmd.setCommandId(commandId);
            deleteCmd.setRequesterId(requesterId);
            deleteCmd.setVersion(version);
            UserResourceUtils.setNullIdOrThrowOnInconsistentIds(id, deleteCmd);
            userApplicationService.when(deleteCmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new WebApiApplicationException(ex); }
    }

    @Path("_metadata/filteringFields")
    @GET
    public List<PropertyMetadataDto> getMetadataFilteringFields() {
        try {

            List<PropertyMetadataDto> filtering = new ArrayList<>();
            UserFilteringProperties.propertyTypeMap.forEach((key, value) -> {
                filtering.add(new PropertyMetadataDto(key, value, true));
            });
            return filtering;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new WebApiApplicationException(ex); }
    }

    @Path("{id}/_stateEvents/{version}")
    @GET
    public UserStateEvent getStateEvent(@PathParam("id") String id, @PathParam("version") long version) {
        try {

            String idObj = id;
            return userApplicationService.getStateEvent(idObj, version);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new WebApiApplicationException(ex); }
    }

    @Path("{userId}/UserRoles/{roleId}")
    @GET
    public UserRoleStateDto getUserRole(@PathParam("userId") String userId, @PathParam("roleId") String roleId) {
        try {

            UserRoleState state = userApplicationService.getUserRole(userId, roleId);
            if (state == null) { return null; }
            UserRoleStateDto.DtoConverter dtoConverter = new UserRoleStateDto.DtoConverter();
            UserRoleStateDto stateDto = dtoConverter.toUserRoleStateDto(state);
            dtoConverter.setAllFieldsReturned(true);
            return stateDto;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new WebApiApplicationException(ex); }
    }

    @Path("{userId}/UserClaims/{claimId}")
    @GET
    public UserClaimStateDto getUserClaim(@PathParam("userId") String userId, @PathParam("claimId") Integer claimId) {
        try {

            UserClaimState state = userApplicationService.getUserClaim(userId, claimId);
            if (state == null) { return null; }
            UserClaimStateDto.DtoConverter dtoConverter = new UserClaimStateDto.DtoConverter();
            UserClaimStateDto stateDto = dtoConverter.toUserClaimStateDto(state);
            dtoConverter.setAllFieldsReturned(true);
            return stateDto;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new WebApiApplicationException(ex); }
    }

    @Path("{userId}/UserPermissions/{permissionId}")
    @GET
    public UserPermissionStateDto getUserPermission(@PathParam("userId") String userId, @PathParam("permissionId") String permissionId) {
        try {

            UserPermissionState state = userApplicationService.getUserPermission(userId, permissionId);
            if (state == null) { return null; }
            UserPermissionStateDto.DtoConverter dtoConverter = new UserPermissionStateDto.DtoConverter();
            UserPermissionStateDto stateDto = dtoConverter.toUserPermissionStateDto(state);
            dtoConverter.setAllFieldsReturned(true);
            return stateDto;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new WebApiApplicationException(ex); }
    }

    @Path("{userId}/UserLogins/{loginKey}")
    @GET
    public UserLoginStateDto getUserLogin(@PathParam("userId") String userId, @PathParam("loginKey") String loginKey) {
        try {

            UserLoginState state = userApplicationService.getUserLogin(userId, (new LoginKeyFlattenedDtoFormatter().parse(loginKey)).toLoginKey());
            if (state == null) { return null; }
            UserLoginStateDto.DtoConverter dtoConverter = new UserLoginStateDto.DtoConverter();
            UserLoginStateDto stateDto = dtoConverter.toUserLoginStateDto(state);
            dtoConverter.setAllFieldsReturned(true);
            return stateDto;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new WebApiApplicationException(ex); }
    }


    protected String getQueryOrderSeparator() {
        return ",";
    }

    protected TypeConverter getCriterionTypeConverter() {
        return new DefaultTypeConverter();
    }

    protected PropertyTypeResolver getPropertyTypeResolver() {
        return new UserPropertyTypeResolver();
    }

    // ////////////////////////////////

    private class UserPropertyTypeResolver implements PropertyTypeResolver {
        @Override
        public Class resolveTypeByPropertyName(String propertyName) {
            return UserResourceUtils.getFilterPropertyType(propertyName);
        }
    }

 
    public static class UserResourceUtils {

        public static List<String> getQueryOrders(String str, String separator) {
            List<String> orders = new ArrayList<>();
            if (StringHelper.isNullOrEmpty(str)) {
                return orders;
            }
            String[] splits = str.split(separator);
            for (String item : splits) {
                if (!StringHelper.isNullOrEmpty(item)) {
                    orders.add(item);
                }
            }
            return orders;
        }

        public static void setNullIdOrThrowOnInconsistentIds(String id, UserCommand value) {
            String idObj = id;
            if (value.getUserId() == null) {
                value.setUserId(idObj);
            } else if (!value.getUserId().equals(idObj)) {
                throw DomainError.named("inconsistentId", "Argument Id %1$s NOT equals body Id %2$s", id, value.getUserId());
            }
        }
    


        public static String getFilterPropertyName(String fieldName) {
            if ("sort".equalsIgnoreCase(fieldName)
                    || "firstResult".equalsIgnoreCase(fieldName)
                    || "maxResults".equalsIgnoreCase(fieldName)
                    || "fields".equalsIgnoreCase(fieldName)) {
                return null;
            }
            if (UserFilteringProperties.propertyTypeMap.containsKey(fieldName)) {
/* TODO...
                var p = UserMetadata.Instance.PropertyMetadataDictionary[fieldName];
                if (p.IsFilteringProperty)
                {
                    var propertyName = fieldName;
                    if (p.IsDerived)
                    {
                        propertyName = p.DerivedFrom;
                    }
                    return propertyName;
                }
*/
                return fieldName;
            }
            return null;
        }

        public static Class getFilterPropertyType(String propertyName) {
            if (UserFilteringProperties.propertyTypeMap.containsKey(propertyName)) {
                String propertyType = UserFilteringProperties.propertyTypeMap.get(propertyName);
                if (!StringHelper.isNullOrEmpty(propertyType)) {
                    if (ReflectUtils.CLASS_MAP.containsKey(propertyType)) {
                        return ReflectUtils.CLASS_MAP.get(propertyType);
                    }
                }
            }
            return String.class;
        }

        public static Iterable<Map.Entry<String, Object>> getQueryFilterDictionary(Map<String, String[]> queryNameValuePairs) {
            Map<String, Object> filter = new HashMap<>();
            queryNameValuePairs.forEach((key, values) -> {
                if (values.length > 0) {
                    String pName = getFilterPropertyName(key);
                    if (!StringHelper.isNullOrEmpty(pName)) {
                        Class pClass = getFilterPropertyType(pName);
                        filter.put(pName, ApplicationContext.current.getTypeConverter().convertFromString(pClass, values[0]));
                    }
                }
            });
            return filter.entrySet();
        }

    }

}

