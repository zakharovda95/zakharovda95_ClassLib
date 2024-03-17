using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace zakharovda95_ClassLib.Extensions;

public static class EnumExtension
{
    public static int? GetOrder(this Enum enumValue)
    {
        return enumValue.GetType()
            .GetMember(enumValue.ToString())
            .First()
            .GetCustomAttribute<DisplayAttribute>()
            ?.GetOrder();
    }

    public static string? GetName(this Enum enumValue)
    {
        return enumValue.GetType()
            .GetMember(enumValue.ToString())
            .First()
            .GetCustomAttribute<DisplayAttribute>()
            ?.GetName();
    }

    public static string? GetDescription(this Enum enumValue)
    {
        return enumValue.GetType()
            .GetMember(enumValue.ToString())
            .First()
            .GetCustomAttribute<DisplayAttribute>()
            ?.GetDescription();
    }
}