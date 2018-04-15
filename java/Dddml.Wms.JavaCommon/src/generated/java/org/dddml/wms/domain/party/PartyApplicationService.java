package org.dddml.wms.domain.party;

import java.util.Map;
import java.util.List;
import org.dddml.support.criterion.Criterion;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.Event;
import org.dddml.wms.domain.Command;

public interface PartyApplicationService
{
    void when(PartyCommand.CreateParty c);

    void when(PartyCommand.MergePatchParty c);

    void when(PartyCommand.DeleteParty c);

    PartyState get(String id);

    Iterable<PartyState> getAll(Integer firstResult, Integer maxResults);

    Iterable<PartyState> get(Iterable<Map.Entry<String, Object>> filter, List<String> orders, Integer firstResult, Integer maxResults);

    Iterable<PartyState> get(Criterion filter, List<String> orders, Integer firstResult, Integer maxResults);

    Iterable<PartyState> getByProperty(String propertyName, Object propertyValue, List<String> orders, Integer firstResult, Integer maxResults);

    long getCount(Iterable<Map.Entry<String, Object>> filter);

    long getCount(Criterion filter);

    Iterable<PartyState> getAll(Class<? extends PartyState> stateType, Integer firstResult, Integer maxResults);

    Iterable<PartyState> get(Class<? extends PartyState> stateType, Iterable<Map.Entry<String, Object>> filter, List<String> orders, Integer firstResult, Integer maxResults);

    Iterable<PartyState> get(Class<? extends PartyState> stateType, Criterion filter, List<String> orders, Integer firstResult, Integer maxResults);

    Iterable<PartyState> getByProperty(Class<? extends PartyState> stateType, String propertyName, Object propertyValue, List<String> orders, Integer firstResult, Integer maxResults);

    long getCount(Class<? extends PartyState> stateType, Iterable<Map.Entry<String, Object>> filter);

    long getCount(Class<? extends PartyState> stateType, Criterion filter);

    PartyEvent getEvent(String partyId, long version);

    PartyState getHistoryState(String partyId, long version);

}

