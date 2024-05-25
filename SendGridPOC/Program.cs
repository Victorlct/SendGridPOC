using SendGrid.Helpers.Mail;
using SendGrid;

static async Task EnviarEmail()
{
    var apiKey = "SG.iv1DK12hR6qanutIvv5iHA.y618MRvtEXSH7SLqYhGzD....";
    var client = new SendGridClient(apiKey);
    var from = new EmailAddress("teste@gmail.com", "Victor");
    var subject = "Assunto do email";
    var to = new EmailAddress("teste@gmail.com", "Victor Dest");
    var plainTextContent = "Olá, {nome}";
    var htmlContent = "<strong> estrutura HTML com table aqui :) </strong>";
    var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
    var response = await client.SendEmailAsync(msg);
    Console.WriteLine(response.Body);
}

await EnviarEmail();

Console.ReadLine();
