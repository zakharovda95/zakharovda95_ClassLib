using zakharovda95_ClassLib.Exeptions;

namespace zakharovda95_ClassLib.Results;

/// <summary>
/// Универсальный объект для возвращения результата каких то операций
/// </summary>
/// <typeparam name="T">Опционально можно передать данные любого типа</typeparam>
public struct GenericResultObject<T>
{
    public bool IsSuccess { get; init; }
    public string Message { get; init; }
    public GenericExceptionObject? Exception { get; init; }
    public T? ReturnedData { get; init; }
}