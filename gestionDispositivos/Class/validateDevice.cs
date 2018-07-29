using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionDispositivos.Class
{
    public class validateDevice
    {
        /// <summary>
        /// Check if text is empty.
        /// </summary>
        /// <param name="text">string: Text to validate. </param>
        /// <returns>
        /// bool: True if text is empty.
        /// </returns>
        public static  bool isEmpty(string text) {
            return (text == String.Empty);
        }

        /// <summary>
        /// Check if text size is too long.
        /// </summary>
        /// <param name="text">string: text to validate.</param>
        /// <param name="length">int: max length.</param>
        /// <returns>
        /// bool: True if text length is greather than max length.
        /// </returns>
        public static bool isTooLong(string text, int length) {
            return (text.Length > length);
        }

        /// <summary>
        /// Check if text is Negative or Zero.
        /// </summary>
        /// <param name="text">String: number to validate.</param>
        /// <returns>
        /// bool: True if text number is negative or zero.
        /// </returns>
        public static bool isNegativeOrZero(string text) {
            return !isEmpty(text) && Int32.Parse(text) <= 0;
            
        }
        
        /// <summary>
        /// Check if ip field has IPV4 format.
        /// </summary>
        /// <param name="ip">string: Ip to validate.</param>
        /// <returns>
        /// bool: True if ip has IPV4 format.
        /// </returns>
        public static bool isRightFormatIpV4(string ip)
        {
            if (String.IsNullOrWhiteSpace(ip))
            {
                return false;
            }

            string[] splitValues = ip.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }

            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }

        /// <summary>
        /// Throw an ArgumentException with a specific message.
        /// </summary>
        /// <param name="infoMessage">string: Message showed in the exception.</param>
        public static void throwValidateException(string infoMessage) {
            throw new ArgumentException(infoMessage);
        }
    }
}
