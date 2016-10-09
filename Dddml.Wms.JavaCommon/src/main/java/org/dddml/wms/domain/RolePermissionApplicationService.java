package org.dddml.wms.domain;

import java.util.Map;
import java.util.List;
import org.dddml.support.criterion.Criterion;
import java.util.Date;
import org.dddml.wms.specialization.Event;
import org.dddml.wms.domain.Command;

public interface RolePermissionApplicationService
{
    void when(RolePermissionCommand.CreateRolePermission c);

    void when(RolePermissionCommand.MergePatchRolePermission c);

    void when(RolePermissionCommand.DeleteRolePermission c);

    RolePermissionState get(RolePermissionId id);

    Iterable<RolePermissionState> getAll(Integer firstResult, Integer maxResults);

    Iterable<RolePermissionState> get(Iterable<Map.Entry<String, Object>> filter, List<String> orders, Integer firstResult, Integer maxResults);

    Iterable<RolePermissionState> get(Criterion filter, List<String> orders, Integer firstResult, Integer maxResults);

    Iterable<RolePermissionState> getByProperty(String propertyName, Object propertyValue, List<String> orders, Integer firstResult, Integer maxResults);

    long getCount(Iterable<Map.Entry<String, Object>> filter);

    long getCount(Criterion filter);

    RolePermissionStateEvent getStateEvent(RolePermissionId id, long version);

    RolePermissionState getHistoryState(RolePermissionId id, long version);

}

