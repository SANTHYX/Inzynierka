﻿using Farmino.Service.Commands.OrderCommands;
using Farmino.Service.Handlers.Interfaces;
using Farmino.Service.Service.Interfaces;
using System.Threading.Tasks;

namespace Farmino.Service.Handlers.OrderHandler
{
    public class EditOrderHandler : ICommandHandler<EditOrder>
    {
        private readonly IOrderService _orderService;

        public EditOrderHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task HandleAsync(EditOrder command)
        {
            await _orderService.EditOrder(command.OfferId, command.CustomerId, command.Quantity);
        }
    }
}
