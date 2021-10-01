using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LearnC1N8
{
    /// <summary>
    /// プレゼンター
    /// </summary>
    public class AplStartViewPresenter
    {
        /// <summary>View</summary>
        private readonly IAplStartView view;

        /// <summary>
        /// Initializes a new instance of the <see cref="AplStartViewPresenter"/> class.
        /// </summary>
        /// <param name="view">View</param>
        public AplStartViewPresenter(IAplStartView view)
        {
            this.view = view;
            this.view.StartNotepatProcessAction += this.StartNotepatProcessAction;
            this.view.StartPaintProcessAction += this.StartPaintProcessAction;
            this.view.Show();
        }

        /// <summary>
        /// メモ帳起動
        /// </summary>
        private void StartNotepatProcessAction()
        {
            AplStartViewModel.StartNotepatProcess();
        }

        /// <summary>
        /// ペイント起動
        /// </summary>
        private void StartPaintProcessAction()
        {
            AplStartViewModel.StartPaintProcess();
        }
    }
}