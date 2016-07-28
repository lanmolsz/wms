<?php

namespace Wms\HttpClient;

use Dddml\Serializer\Type\Long;
use Dddml\Executor\Http\QueryCountRequestInterface;

class AudiencesQueryRequest extends AbstractQueryRequest implements QueryCountRequestInterface
{
    use AudienceFilteringFieldsTrait;

    protected $routePath = 'Audiences';

    public function getReturnType()
    {
        return 'array<Wms\Domain\Audience>';
    }
}

