namespace Domain.Customers.ValueObjects
{
    using System;

    public readonly struct CustomerId
    {
        private readonly Guid _customerId;

        public CustomerId(Guid customerId)
        {
            if (customerId == Guid.Empty)
            {
                throw new EmptyCustomerIdException($"{nameof(customerId)} cannot be empty.");
            }

            this._customerId = customerId;
        }

        public override string ToString()
        {
            return this._customerId.ToString();
        }

        public Guid ToGuid() => this._customerId;
    }
}
