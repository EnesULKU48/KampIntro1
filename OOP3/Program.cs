using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekranda açılan kutu
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();           
            IKrediManager tasitKrediManager = new TasitKrediManager();            
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            //List<ILoggerService> loggers = new List<ILoggerService> {new FileLoggerService, new SmsLoggerService }();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService> {databaseLoggerService, smsLoggerService});

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
