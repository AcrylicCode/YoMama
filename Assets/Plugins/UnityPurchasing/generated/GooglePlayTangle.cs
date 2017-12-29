#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("qaud5XjPEUEJMMea1Py+uN6wCfO4hStCTxAGeXDU5YuSS+/22KUdFp8xyXgJSelzUX0ef8ybkVT8Ku6DU/rOpdGTDvelAk5eIYzzr5dVkelreXfetFLcusfx0JBzRY0lVk6yq7dtV5N8zlqXuIf2BXwga0S5TwovRLN8XfhlIAgMsvehyRBv74VsdyhU1+LB1LTK57QtgXRsRRK0U3XAHQlWfpkn454bedn/172kDeqbleOtViQrBsAniFukYEQTk0Z3mXWLwzgXlJqVpReUn5cXlJSVWSOEMGoOgqUXlLelmJOcvxPdE2KYlJSUkJWWIwK7gB9h3b5xACIpqypeZglKVeY423/Mum8rbtrb9HXguNsZEJETF6NsbMOzKiB1ipeWlJWU");
        private static int[] order = new int[] { 8,6,3,11,7,10,12,11,13,11,12,13,12,13,14 };
        private static int key = 149;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
