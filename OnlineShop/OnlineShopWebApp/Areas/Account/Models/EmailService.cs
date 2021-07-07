using Microsoft.Extensions.Logging;
using MimeKit;
using OnlineShopWebApp.Models;
using System;

namespace OnlineShopWebApp.Areas.Account.Models
{
    public class EmailService
    {
        private readonly ILogger<EmailService> logger;
        
        public EmailService(ILogger<EmailService> logger)
        {
            this.logger = logger;
        }

        [Obsolete]
        public void SendMailToRegister(string emailAdress)
        {
            try
            {               
                MimeMessage message = new MimeMessage();//Класс библиотеки MailKit
                message.From.Add(new MailboxAddress("On-line Shop", "shop@mail.ru"));//адрес отправления
                message.To.Add(new MailboxAddress(emailAdress)); //адрес назначения
                message.Subject = "Завершение процедуры регистрации";//Тема сообщения
                message.Body = new BodyBuilder() { HtmlBody = "<div style=\"color: black;\">Вы получили это сообщение для подтверждения адреса электронной почты." + '\n' + "Для завершения процедуры регистрации пройдите по <a href=\"https://localhost:5001/Account/Account/Login\">ссылке</a></div>" }.ToMessageBody();//Тело сообщения

                using (MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 465, true);//Подключение к сервису gmail, порт, соединение защищённое
                    client.Authenticate("FrG.397.asE.047@gmail.com", "Mir.732-R37");//Аккаунт Google логин, пароль
                    client.Send(message);

                    client.Disconnect(true);
                    logger.LogInformation("Сообщение отправлено успешно!");
                }
            }
            catch (Exception e)
            {
                logger.LogError(e.GetBaseException().Message);

            }
        }

        [Obsolete]
        public void SendMailToRegisterChangePassword(string accountEmail)
        { 
            try
            {
                MimeMessage message = new MimeMessage();//Класс библиотеки MailKit
                message.From.Add(new MailboxAddress("On-line Shop", "shop@mail.ru"));//адрес отправления
                message.To.Add(new MailboxAddress(accountEmail)); //адрес назначения
                message.Subject = "Завершение процедуры смены пароля";//Тема сообщения
                message.Body = new BodyBuilder() { HtmlBody = "<div style=\"color: black;\">Вы получили это сообщение для подтверждения адреса электронной почты." + '\n' + "Для завершения процедуры регистрации пройдите по <a href=\"https://localhost:5001/Admin/User/ChangePassword\">ссылке</a></div>" }.ToMessageBody();//Тело сообщения

                using (MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 465, true);//Подключение к сервису gmail, порт, соединение защищённое
                    client.Authenticate("FrG.397.asE.047@gmail.com", "Mir.732-R37");//Аккаунт Google логин, пароль
                    client.Send(message);

                    client.Disconnect(true);
                    logger.LogInformation("Сообщение отправлено успешно!");
                }
            }
            catch (Exception e)
            {
                logger.LogError(e.GetBaseException().Message);

            }
        }
    }
}
