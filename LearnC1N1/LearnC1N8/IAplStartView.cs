using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC1N8
{
    /// <summary>
    /// 他アプリ起動・インタフェース
    /// </summary>
    public interface IAplStartView
    {
        /// <summary>メモ帳起動</summary>
        public Action StartNotepatProcessAction { get; set; }

        /// <summary>ペイント起動</summary>
        public Action StartPaintProcessAction { get; set; }

        /// <summary>表示/summary>
        public void Show();
    }
}
