﻿using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace EShopOnAbp.OrderingService.Orders;

public interface IOrderAppService : IApplicationService
{
    Task<OrderDto> CreateAsync(OrderCreateDto input);
    Task<OrderDto> GetAsync(Guid id);
    Task<OrderDto> GetByOrderNoAsync(int orderNo);
}