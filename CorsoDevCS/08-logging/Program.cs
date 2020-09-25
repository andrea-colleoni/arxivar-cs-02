using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_logging
{
    public class Program
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            log.Debug("inizio del programma");

            try
            {
                log.Info("scrivo il testo in minuscolo");
                string testo = null;
                FaiQualcosaConIlTesto(testo);
            }
            catch (TestoNulloException) // eccezione specifica e personalizzata (creata da noi)
            {
                Console.WriteLine("default");
            }
            catch (NullReferenceException e) // eccezione specifica
            {
                log.Warn("qualcosa era null", e);
                Console.WriteLine("...");
            }
            catch (Exception e) // catch all (Exception è la superclasse di tutte le exception)
            {
                log.Error("si è verificato un errore generico", e);
            }

            log.Debug("fine del programma");

            //log.Warn("questo è un messaggio di warning");
            //log.Error("questo è un messaggio di error");
            //log.Fatal("questo è un messaggio fatal");

            //Console.ReadLine();
        }


        static void FaiQualcosaConIlTesto(string testo)
        {
            if (testo == null)
            {
                log.Warn("il testo era null");
                throw new TestoNulloException("il testo è nullo");
            }
            Console.WriteLine(testo.ToLower());
        }
    }
}
