namespace zakharovda95_ClassLib.Exeptions;

/// <summary>
/// Универсальный объект ошибки
/// </summary>
/// <param name="innerException">Внутренняя ошибка (отлавливаемая в блоке catch)</param>
public class GenericExceptionObject(Exception innerException) :
    Exception(message: innerException.Message, innerException: innerException)
{
    public int? StatusCode { get; init; }
    public string? StatusMessage { get; init; }
    public string? ErrorMessage { get; init; } = innerException.Message;
}