﻿using System;

namespace UnleashedDDD.Contracts.Sales.SalesOrder.Commands
{
    public class CreateNewSalesOrder : AuditableCommand
    {
        public Guid SalesOrderId { get; private set; }

        public Guid CustomerId { get; private set; }

        public Guid WarehouseId { get; private set; }

        public CreateNewSalesOrder(Guid userId, Guid salesOrderId, Guid customerId, Guid warehouseId) : base(userId)
        {
            CustomerId = customerId;
            WarehouseId = warehouseId;
            SalesOrderId = salesOrderId;
        }
    }
}