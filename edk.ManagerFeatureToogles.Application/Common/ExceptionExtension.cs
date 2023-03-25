namespace edk.ManagerFeatureToogles.Application.Common;

public static class ExceptionExtension
{
    public static IEnumerable<string> ToStringList(this List<Exception> exceptions)
    {
        foreach (var ex in exceptions)
        {
            yield return $"[Exception] {ex.Message}";
        }

    }
}
