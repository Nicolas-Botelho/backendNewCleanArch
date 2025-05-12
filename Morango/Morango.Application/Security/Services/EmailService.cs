using MimeKit;
using Morango.Application.Security.Interfaces;
using Morango.Domain.Security.Account;
using Morango.Domain.Security.Account.Entities;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace Morango.Application.Security.Services
{
    public class EmailService : IService
    {
        public async Task SendVerificationEmailAsync(User user, CancellationToken cancellationToken)
        {
            var email = new MimeMessage();

            email.From.Add(new MailboxAddress("Sender Name", Configuration.Email.DefaultFromEmail));
            email.To.Add(new MailboxAddress("Receiver Name", user.Email.Address));

            email.Subject = "Verifique sua conta";
            email.Body = new TextPart(MimeKit.Text.TextFormat.Text)
            {
                Text = $"Código de verificação de email: {user.Email.Verification.Code}"
            };

            using (var smtp = new SmtpClient())
            {
                smtp.Connect("smtp.gmail.com", 587, false);

                // Note: only needed if the SMTP server requires authentication
                smtp.Authenticate(Configuration.Email.DefaultFromEmail, Configuration.Email.ApiKey);

                smtp.Send(email);
                smtp.Disconnect(true);
            }

        }

        public async Task SendResetPasswordAsync(User user, CancellationToken cancellationToken)
        {
            var email = new MimeMessage();

            email.From.Add(new MailboxAddress("Sender Name", Configuration.Email.DefaultFromEmail));
            email.To.Add(new MailboxAddress("Receiver Name", user.Email.Address));

            email.Subject = "Alterar Senha";
            email.Body = new TextPart(MimeKit.Text.TextFormat.Text)
            {
                Text = $"Código de alteração de senha: {user.Password.ResetCode}"
            };

            using (var smtp = new SmtpClient())
            {
                smtp.Connect("smtp.gmail.com", 587, false);

                // Note: only needed if the SMTP server requires authentication
                smtp.Authenticate(Configuration.Email.DefaultFromEmail, Configuration.Email.ApiKey);

                smtp.Send(email);
                smtp.Disconnect(true);
            }

        }
    }
}
