namespace SnowShovel.Functional
{
    public partial class Extensions
    {
        public static None None => None.Default;
    }

    public struct None
    {
        internal static readonly None Default = new None();
    }
}
