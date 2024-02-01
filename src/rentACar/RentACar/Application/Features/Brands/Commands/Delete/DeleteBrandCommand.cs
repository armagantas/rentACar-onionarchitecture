﻿using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.Delete
{
    public class DeleteBrandCommand : IRequest<DeletedBrandResponse>
    {
        public Guid Id { get; set; }

        public class DeleteBrandResponseHandler : IRequestHandler<DeleteBrandCommand, DeletedBrandResponse>
        {

            private readonly IBrandRepository _brandRepository;
            private readonly IMapper _mapper;   

            public DeleteBrandResponseHandler(IBrandRepository brandRepository, IMapper mapper)
            {
                _brandRepository = brandRepository;
                _mapper = mapper;
            }

            public async Task<DeletedBrandResponse> Handle(DeleteBrandCommand request, CancellationToken cancellationToken)
            {
                Brand? brand = await _brandRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken);

                await _brandRepository.DeleteAsync(brand);

                DeletedBrandResponse deletedBrandResponse = _mapper.Map<DeletedBrandResponse>(brand);

                return deletedBrandResponse;
                
            }
        }

    }
}