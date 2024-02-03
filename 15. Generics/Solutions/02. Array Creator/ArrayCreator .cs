// ReSharper disable CheckNamespace
namespace GenericArrayCreator;

public static class ArrayCreator
{
    public static T[] Create<T>(int length, T item) => Enumerable.Repeat(item, length).ToArray();
}