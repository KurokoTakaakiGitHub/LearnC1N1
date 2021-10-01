using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC1N5
{
    /// <summary>
    /// 持ち物種類
    /// </summary>
    public enum BelongingsType
    {
        /// <summary>カバン</summary>
        Bag,

        /// <summary>腕時計</summary>
        WristWatch,

        /// <summary>スマートフォン</summary>
        SmartPhones,

        /// <summary>ノートパソコン</summary>
        Laptop,

        /// <summary>財布</summary>
        Purse,

        /// <summary>定期券</summary>
        SeasonTicket,
    }

    /// <summary>
    /// 持ち物種類・拡張
    /// </summary>
    public static class BelongingsTypeExt
    {
        /// <summary>持ち物リスト</summary>
        public static string[] BelongingsList
        {
            get
            {
                return BelongingsListValue.ToArray();
            }
        }

        /// <summary>持ち物リスト</summary>
        private static readonly IEnumerable<string> BelongingsListValue = new List<string>() { "カバン", "腕時計", "スマートフォン", "ノートパソコン", "財布", "定期券" };

        /// <summary>
        /// 持ち物種類名称取得
        /// </summary>
        /// <param name="belongingsType">持ち物</param>
        /// <returns>持ち物名称</returns>
        public static string DisplayName(this BelongingsType belongingsType)
        {
            string[] names = BelongingsListValue.ToArray();
            return names[(int)belongingsType];
        }

        /// <summary>
        /// 持ち物種類名称が存在するか
        /// </summary>
        /// <param name="displayName">持ち物</param>
        /// <returns>持ち物名称</returns>
        public static bool ExistDisplayName(string displayName)
        {
            return BelongingsListValue.Any(x => x == displayName);
        }
    }
}
