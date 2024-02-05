using System.Reflection;
namespace MauiFontGallery.Extensions;

public static class FieldInfoExtensions
{
    public static bool TryGetCustomAttribute<TAttribute>(this FieldInfo fieldInfo, out TAttribute? attribute) 
        where TAttribute : Attribute
    {
        attribute = fieldInfo.GetCustomAttribute<TAttribute>();

        return attribute != null;
    }
}