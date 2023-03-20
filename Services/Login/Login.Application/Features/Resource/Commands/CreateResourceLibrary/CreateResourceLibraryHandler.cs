﻿using BuildrOps.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BuildrOps.Application.Features.Resource.Commands.CreateResourceLibrary
{
   public class CreateResourceLibraryHandler:IRequestHandler<CreateResourceLibraryCommand,CreateResourceLibraryResponse>
    {
        IResourceType _resourceType;
        public CreateResourceLibraryHandler(IResourceType ResourceType)
        {
            _resourceType = ResourceType;
        }

        public async Task<CreateResourceLibraryResponse> Handle(CreateResourceLibraryCommand request, CancellationToken cancellationToken)
        {
            return await _resourceType.CreateResourceLibrary(request);
        }
    }
}
