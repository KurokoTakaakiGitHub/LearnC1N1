using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC1N1
{
    /// <summary>
    /// 名前
    /// </summary>
    public class Name
    {
        /// <summary>Value</summary>
        public string Value { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Name"/> class.
        /// </summary>
        /// <param name="name">名前</param>
        public Name(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name), "名前が未入力です。");
            }

            this.Value = name;
        }

        /// <summary>
        /// オーバーライド
        /// </summary>
        /// <returns>名前</returns>
        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
