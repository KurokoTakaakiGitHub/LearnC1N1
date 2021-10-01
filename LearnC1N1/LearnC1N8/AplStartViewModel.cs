using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LearnC1N8
{
    /// <summary>
    /// 他アプリ起動・モデル
    /// </summary>
    public static class AplStartViewModel
    {
        /// <summary>メモ帳exeファイル名</summary>
        private static readonly string ExeFileNameNotePatProcess = "notepad.exe";

        /// <summary>ペイントexeファイル名</summary>
        private static readonly string ExeFileNamePaintProcess = "mspaint.exe";

        /// <summary>
        /// メモ帳起動
        /// </summary>
        public static void StartNotepatProcess()
        {
            ProcessStart(ExeFileNameNotePatProcess);
        }

        /// <summary>
        /// ペイント起動
        /// </summary>
        public static void StartPaintProcess()
        {
            ProcessStart(ExeFileNamePaintProcess);
        }

        /// <summary>
        /// プロセス起動
        /// </summary>
        /// <param name="processFileName">起動するファイル</param>
        private static void ProcessStart(string processFileName)
        {
            var process = new System.Diagnostics.Process();
            process.StartInfo.FileName = processFileName;
            process.Start();
        }
    }
}