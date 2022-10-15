using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ForbiddenWordsLibrary
{
    public class CensoreWordsClass
    {
        /// <summary>
        /// Замена  слово "редиска" на звёздочки(***) 
        /// </summary>
        /// <param name="textString">
        /// Входящая строка, которая, возможно, содержит запрещённое слово
        /// </param>
        /// <returns>
        /// Возвращает строку, только без запрещённого слова, оно заблюрилось
        /// </returns>
        public static string Censore(string textString)
        {
            if(textString == string.Empty)
                throw new ArgumentNullException("Вы забыли что-то ввести");
            return Regex.Replace(textString, "редиска", "***", RegexOptions.IgnoreCase);//Хочу поработать с падежами, но это только в будущем

        }
    }
}
