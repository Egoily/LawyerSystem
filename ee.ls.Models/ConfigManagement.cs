using Newtonsoft.Json;
using System.IO;
using System.Web;

namespace ee.ls.Models
{
    public class ConfigManagement
    {
        /// <summary>
        /// 明文配置文件路径
        /// </summary>
        private static string ConfigFile = HttpRuntime.BinDirectory + @"\data.json";

        /// <summary>
        /// 系统配置信息
        /// </summary>
        public static SystemConfiguration SystemConfiguration { get; set; }

        /// <summary>
        /// 加载系统配置
        /// </summary>
        public static void Load()
        {
            #region 加载系统配置
            if (!File.Exists(ConfigFile))
            {
                var fs = new FileStream(ConfigFile, FileMode.Create, FileAccess.ReadWrite);
                fs.Close();
            }

            //读出密文
            var encryptText = File.ReadAllText(ConfigFile);

            SystemConfiguration = JsonConvert.DeserializeObject<SystemConfiguration>(encryptText);


            if (SystemConfiguration == null)
            {
                SystemConfiguration = new SystemConfiguration();
            }
            #endregion
        }
        /// <summary>
        /// 保存系统配置
        /// </summary>
        public static void Save()
        {
            var jsonSetting = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };
            var json = JsonConvert.SerializeObject(SystemConfiguration, jsonSetting);

            File.WriteAllText(ConfigFile, json);
        }

    }
}
