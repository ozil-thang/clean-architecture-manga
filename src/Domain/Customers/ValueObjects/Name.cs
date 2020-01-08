namespace Domain.Customers.ValueObjects
{
    public readonly struct Name
    {
        private readonly string _text;

        public Name(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new NameShouldNotBeEmptyException($"The {nameof(text)} field is required.");
            }

            this._text = text;
        }

        public override string ToString()
        {
            return this._text;
        }
    }
}
