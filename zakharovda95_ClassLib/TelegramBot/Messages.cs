using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using zakharovda95_ClassLib.Exeptions;
using zakharovda95_ClassLib.Extensions;
using zakharovda95_ClassLib.Results;

namespace zakharovda95_ClassLib.TelegramBot;

public static class Messages
{
    public static async Task<GenericResultObject<Message?>> SendTextMessage(ITelegramBotClient botClient, Update update,
        CancellationToken cancellationToken, string message, bool replyMarkup = true)
    {
        try
        {
            var resultMessage = await botClient.SendTextMessageAsync(
                chatId: update.Message!.Chat.Id,
                text: message,
                cancellationToken: cancellationToken,
                replyToMessageId: replyMarkup ? update.Message.MessageId : null,
                parseMode: ParseMode.Html,
                disableNotification: true
                );

            return new GenericResultObject<Message?>
            {
                IsSuccess = true,
                Message = SystemMessages.SuccessTextMessageSending,
                ReturnedData = resultMessage
            };
        }
        catch (Exception e)
        {
            return new GenericResultObject<Message?>
            {
                IsSuccess = false,
                Message = SystemMessages.ErrorTextMessageSending,
                Exception = new GenericExceptionObject(innerException: e)
                {
                    StatusCode = GenericExceptionEnum.ErrorTextMessageSending.GetOrder(),
                    StatusMessage = GenericExceptionEnum.ErrorTextMessageSending.GetName(),
                }
            };
        }
    }
}