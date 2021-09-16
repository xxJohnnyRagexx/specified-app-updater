using System;
using System.Net;
using Spectre.Console;

namespace SpecifiedAppUpdaterClient
{
    class Program
    {
        static void Main(string[] args)
        {
            AnsiConsole.Markup("[underline red]Hello[/] World!");
            AnsiConsole.Markup("Hello :globe_showing_europe_africa:!");
            WebClient Client = new WebClient();
            Client.DownloadFile("https://cdndl.zaycev.net/packie/9777/T5MkP2bJLQzzAzitpfpS4fGEntJASqa9VMRBvc9ECcAfyPzMfQE6S3gMhLiLA6w9cHmkNDPxRaDLgiNTp1kWLzpGnymV2fq4CiYFF9h4Sg978tz1nphReWdRE6Rbip4U6vFcDzybekAFmZHSA5VxyABFBpyvqVwEk5m1DDSc6yCxkwJ2WZsLmJqJ7Nuq2ZeHf6rebCPpfLMxQMATDpaXvDZzS3sGzTXHmRdjJ6bnKMXGzX9PFpoZpkHoWRsHGDa4X8TofTSwmRwdpomAP7WkQUXsZ1b83gHyWbBwBoGbNcDv3yzc9frSN2UXVzzUYQJQ48bd6kHH93mQRKfJR99BcHzGfhNr7P3jcJpcjucVtzUk2Z9BayyGM7pPrfXWx5pJdQ2Vjs4RsthsbUWQ2xP1FuafGrtjpYj9434qxDuwFFwmzoPGkpLTX7iD9joqkE3rmqfY4HXzBuw", "music.zip");
            AnsiConsole.Markup("press any key for continue");
                Console.ReadKey();
        }
    }
}