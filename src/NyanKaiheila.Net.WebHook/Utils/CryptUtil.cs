using System.Security.Cryptography;
using System.Text;

namespace NyanKaiheila.Net.WebHook.Utils
{
    /// <summary>
    /// 解密工具 如果你在开黑啦文档看到及其相似的代码，不用怀疑我是不是抄代码，因为那个文档的代码就是我写的
    /// </summary>
    public class CryptUtil
    {
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="data">密文</param>
        /// <param name="encryptKey">Encrypt Key</param>
        /// <returns></returns>
        public static async Task<string> Decrypt(string data, string encryptKey)
        {
            // 在 encrypKey 右侧填充 \0 到 32 位
            encryptKey = encryptKey.PadRight(32, '\0');

            // 用 base64 解析原密文
            var originCipher = Encoding.UTF8.GetString(Convert.FromBase64String(data));
            // 取前 16 位为 iv，16 位后的文本为新密文
            var iv = originCipher.Substring(0, 16);
            var newCipher = originCipher.Substring(16);

            // 用 base64 解密新密文
            var newCipherByte = Convert.FromBase64String(newCipher);

            // 使用 aes-256-cbc 解密数据
            using (var aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(encryptKey);
                aes.IV = Encoding.UTF8.GetBytes(iv);

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using var memoryStream = new MemoryStream(newCipherByte);
                using var csDecrypt = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                using var reader = new StreamReader(csDecrypt);
                return await reader.ReadToEndAsync();
            }
        }
    }
}
