﻿using Ambev.DeveloperEvaluation.Domain.Entities.Sale;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale
{
    /// <summary>
    /// Profile for mapping between Sale entity and GetSaleResult
    /// </summary>
    public class GetSaleProfile : Profile
    {
        /// <summary>
        /// Initializes the mappings for GetSale operation
        /// </summary>
        public GetSaleProfile()
        {
            CreateMap<Sale, GetSaleResult>();
        }
    }
}
