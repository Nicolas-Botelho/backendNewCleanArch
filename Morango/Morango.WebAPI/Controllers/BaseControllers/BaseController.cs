﻿using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace Morango.WebApi.Controllers.BaseControllers
{
    public abstract class BaseController : BaseControllerResult
    {

        protected readonly IMapper _mapper;
        protected readonly ILogger _logger;
        protected readonly IMediator _mediator;

        public BaseController(IMediator mediator, IMapper mapper, ILogger<BaseController> logger)
        {
            _mediator = mediator;
            _mapper = mapper;
            _logger = logger;
        }
    }

    [Authorize]
    public abstract class BaseControllerNotAuthorized : BaseController
    {
        public BaseControllerNotAuthorized(IMediator mediator, IMapper mapper, ILogger<BaseController> logger) : base(mediator, mapper, logger)
        {
        }
    }
}
