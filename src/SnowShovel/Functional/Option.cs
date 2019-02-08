using System;

namespace SnowShovel.Functional
{
    public partial class Statics
    {
        public static Option<T> Some<T>(T value) => (Option<T>)value;
    }

    public struct Option<T>
    {
        private readonly bool _hasValue;
        private readonly T _value;

        private Option(T value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            _hasValue = true;
            _value = value;
        }

        public static implicit operator Option<T>(T value) => new Option<T>(value);

        public void Match(Action none, Action<T> some)
        {
            if (_hasValue)
                some(_value);
            else
                none();
        }
    }
}
