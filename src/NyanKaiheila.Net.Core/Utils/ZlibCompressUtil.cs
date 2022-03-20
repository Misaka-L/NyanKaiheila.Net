using System.IO.Compression;

namespace NyanKaiheila.Net.Core.Utils
{
    /// <summary>
    /// 解压工具
    /// </summary>
    public class ZlibCompressUtil
    {
        /// <summary>
        /// 解压到文本
        /// </summary>
        /// <param name="stream">加密数据的流</param>
        /// <returns>解压后的文本</returns>
        public static async Task<string> DecompressString(Stream stream)
        {
            using var rawSteam = new MemoryStream();
            await stream.CopyToAsync(rawSteam);
            var buffers = rawSteam.ToArray();
            // 跳过前 2 个字节，因为傻逼微软
            var compressStream = new MemoryStream(buffers, 2, buffers.Length - 2);

            using var deflateStream = new DeflateStream(compressStream, CompressionMode.Decompress);

            using var reader = new StreamReader(deflateStream);
            return await reader.ReadToEndAsync();
        }
    }
}