using System.Net;
using System.Net.Mail;

namespace AspNetIdentity.Api.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(string toEmail, string subject, string content);
        string GetNewLoginNotification();
    }

    public class MailService : IMailService
    {

        private IConfiguration _configuration;

        public MailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task SendEmailAsync(string toEmail, string subject, string content)
        {
            #region Config
            var mailSettings = _configuration.GetSection("Smtp");
            var mail = _configuration["Smtp:Username"];
            var pw = _configuration["Smtp:Password"];

            var client = new SmtpClient(mailSettings["Host"], int.Parse(mailSettings["Port"]))
            {
                EnableSsl = bool.Parse(mailSettings["EnableSsl"]),
                Credentials = new NetworkCredential(mail, pw)
            };


            var mailMessage = new MailMessage
            {
                From = new MailAddress(mail),
                Subject = subject,
                Body = content,
                IsBodyHtml = true
            };

            mailMessage.To.Add(toEmail);

            return client.SendMailAsync(mailMessage);
            #endregion
        }

        //Templates
        public string GetNewLoginNotification()
        {
            #region Content
            return $@"
            <!DOCTYPE html>
            <html lang='es'>
                <head>
                    <meta charset='UTF-8'>
                    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                    <title>Nuevo Inicio de Sesión</title>
                    <style>
                        body {{
                            font-family: Arial, sans-serif;
                            background-color: #f4f4f4;
                            margin: 0;
                            padding: 0;
                        }}
                        .container {{
                            max-width: 600px;
                            margin: 20px auto;
                            padding: 20px;
                            background-color: #ffffff;
                            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
                        }}
                        .header {{
                            background-color: #43327B;
                            color: #FBC046;
                            padding: 10px 0;
                            text-align: center;
                        }}
                        .header img {{
                            height: 40px;
                            margin-right: 10px;
                        }}
                        .content {{
                            margin: 20px 0;
                        }}
                        .footer {{
                            text-align: center;
                            color: #777;
                            font-size: 12px;
                            margin-top: 20px;
                        }}
                    </style>
                    </head>
                    <body>
                        <div class='container'>
                            <div class='header'>
                                <h1>Nuevo Inicio de Sesión</h1>
                                <img src='https://i.imgur.com/2yuGC6i.png' alt='Logo'>
                            </div>

                            <div class='content'>
                                <p>Hola,</p>
                                <p>Se ha detectado un nuevo inicio de sesión en tu cuenta.</p>
                                <p><strong>Hora:</strong> {DateTime.UtcNow:yyyy-MM-dd HH:mm:ss} UTC</p>
                                <p>Si no fuiste tú, por favor, asegúrate de cambiar tu contraseña y revisar la actividad reciente de tu cuenta.</p>
                            </div>
                            <div class='footer'>
                                <p>Este es un mensaje automático, por favor no respondas a este correo.</p>
                            </div>
                        </div>
                    </body>
            </html>";
#endregion
        }
    }
}
