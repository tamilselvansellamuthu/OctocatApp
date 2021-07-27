using System;
using System.Globalization;

namespace OctocatApp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//         }
//     }
// }




public class Example
{
   public static void Main()
   {
      DateTime localDate = DateTime.Now;
      DateTime utcDate = DateTime.UtcNow;
      String[] cultureNames = { "en-US", "en-GB", "fr-FR",
                                "de-DE", "ru-RU" } ;

      foreach (var cultureName in cultureNames) {
         var culture = new CultureInfo(cultureName);
         Console.WriteLine("Hello World!");
         Console.WriteLine("{0}:", culture.NativeName);
         Console.WriteLine("   Local date and time: {0}, {1:G}",
                           localDate.ToString(culture), localDate.Kind);
         Console.WriteLine("   UTC date and time: {0}, {1:G}\n",
                           utcDate.ToString(culture), utcDate.Kind);
      }
   }
}
