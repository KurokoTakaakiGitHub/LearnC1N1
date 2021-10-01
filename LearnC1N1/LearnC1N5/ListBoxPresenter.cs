using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LearnC1N5
{
    /// <summary>
    /// ラジオボタン・プレゼンター
    /// </summary>
    public class ListBoxPresenter
    {
        /// <summary>テキストボックス＆ラベルView</summary>
        private readonly IListBoxView view;

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBoxPresenter"/> class.
        /// </summary>
        /// <param name="view">View</param>
        public ListBoxPresenter(IListBoxView view)
        {
            this.view = view;
            this.view.SetListBoxItemsAction += this.SetListBoxItemsAction;
            this.view.OkButtonAction += this.OkButtonAction;
            this.view.Show();
        }

        /// <summary>
        /// リストボックスに項目を追加
        /// </summary>
        private void SetListBoxItemsAction()
        {
            try
            {
                this.view.BelongingsList = ListBoxViewModel.GetBelongingsList();
            }
            catch (Exception e)
            {
                Program.ShowErrMessage(e.Message + "\n" + e.StackTrace);
            }
        }

        /// <summary>
        /// Okボタン
        /// </summary>
        /// <param name="selectedItem">選択した持ち物</param>
        private void OkButtonAction(object selectedItem)
        {
            try
            {
                this.view.ShowInfoMessage(ListBoxViewModel.GetSelectedBelongingsStr(selectedItem));
            }
            catch (ArgumentNullException)
            {
                this.view.ShowWarningMessage("アイテムが未選択です。");
            }
            catch (Exception e)
            {
                Program.ShowErrMessage(e.Message + "\n" + e.StackTrace);
            }
        }
    }
}