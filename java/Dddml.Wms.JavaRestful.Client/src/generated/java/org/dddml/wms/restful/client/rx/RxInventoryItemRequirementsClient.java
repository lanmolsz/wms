package org.dddml.wms.restful.client.rx;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.DELETE;
import retrofit2.http.Field;
import retrofit2.http.FormUrlEncoded;
import retrofit2.http.GET;
import retrofit2.http.Headers;
import retrofit2.http.PATCH;
import retrofit2.http.PUT;
import retrofit2.http.Path;
import retrofit2.http.Query;
import rx.Observable;

import org.dddml.support.criterion.*;
import org.dddml.wms.domain.inventoryitem.*;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.inventoryprtriggered.*;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.inventoryitemrequirement.*;

public interface RxInventoryItemRequirementsClient {

    @Headers("Accept: application/json")
    @GET("InventoryItemRequirements")
    Observable<List<InventoryItemRequirementStateDto>> getAll(@Query("sort") String sort, @Query("fields") String fields, @Query("firstResult") int firstResult, @Query("maxResults") int maxResults, @Query("filter") String filter);

    @Headers("Accept: application/json")
    @GET("InventoryItemRequirements/_count")
    Observable<Long> getCount(@Query("filter") String filter);

    @Headers("Accept: application/json")
    @GET("InventoryItemRequirements/{id}")
    Observable<InventoryItemRequirementStateDto> get(@Path("id") String id, @Query("fields") String fields);

    @Headers("Accept: application/json")
    @GET("InventoryItemRequirements/_metadata/filteringFields")
    Observable<List<PropertyMetadataDto>> getMetadataFilteringFields();

    @Headers("Accept: application/json")
    @GET("InventoryItemRequirements/{id}/_historyStates/{version}")
    Observable<InventoryItemRequirementStateDto> getHistoryState(@Path("id") String id, @Path("version") long version);

    @Headers("Accept: application/json")
    @GET("InventoryItemRequirements/{inventoryItemRequirementId}/InventoryItemRequirementEntries/{entrySeqId}")
    Observable<InventoryItemRequirementEntryStateDto> getInventoryItemRequirementEntry(@Path("inventoryItemRequirementId") String inventoryItemRequirementId, @Path("entrySeqId") Long entrySeqId);
 
    @Headers("Accept: application/json")
    @PUT("InventoryItemRequirements/{id}")
    Observable<String> put(@Path("id") String id, @Body CreateOrMergePatchInventoryItemRequirementDto.CreateInventoryItemRequirementDto value);

    @Headers("Accept: application/json")
    @PATCH("InventoryItemRequirements/{id}")
    Observable<String> patch(@Path("id") String id, @Body CreateOrMergePatchInventoryItemRequirementDto.MergePatchInventoryItemRequirementDto value);

    @Headers("Accept: application/json")
    @DELETE("InventoryItemRequirements/{id}")
    Observable<String> delete(@Path("id") String id, @Query("commandId") String commandId, @Query("version") String version, @Query("requesterId") String requesterId);

}

