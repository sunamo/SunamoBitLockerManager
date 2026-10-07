namespace SunamoBitLockerManager;

    public static class ExceptionHelper
    {
        public static Exception SetCode(this Exception exception, int value)
        {
            BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic;
            FieldInfo fieldInfo = typeof(Exception).GetField("_HResult", flags);

            fieldInfo?.SetValue(exception, value);

            return exception;
        }

        public static Exception SetCode(this Exception exception, uint value)
        {
            BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic;
            FieldInfo fieldInfo = typeof(Exception).GetField("_HResult", flags);

            fieldInfo?.SetValue(exception, unchecked((int)value));

            return exception;
        }
    }