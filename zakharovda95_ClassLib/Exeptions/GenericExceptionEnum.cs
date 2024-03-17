using System.ComponentModel.DataAnnotations;

namespace zakharovda95_ClassLib.Exeptions;

/// <summary>
/// Все кастомные коды с текстами ошибок
/// </summary>
public enum GenericExceptionEnum
{
    // Статусы Телеграм-Бота
    [Display(Order = 001, Name = "TelegramBot: Ошибка отправки текстового сообщения",
        Description = "Текстовое сообщение не было отправлено")]
    ErrorTextMessageSending,
}