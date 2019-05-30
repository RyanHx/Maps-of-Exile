namespace PoEMapsViewModel.Helper
{
    public static class UtilityClass
    {
        public static int SafeGetHashCode<T>(this T value) where T : class
        {
            return value == null ? 0 : value.GetHashCode();
        }
    }
}