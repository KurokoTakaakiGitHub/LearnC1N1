using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LearnC1N6X
{
    /// <summary>
    /// リストボックス２・プレゼンター
    /// </summary>
    public class ListBoxPresenter2
    {
        /// <summary>テキストボックス＆ラベルView</summary>
        private readonly IListBoxView2 view;

        private readonly ListBoxViewModel2 model;

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBoxPresenter2"/> class.
        /// </summary>
        /// <param name="view">View</param>
        public ListBoxPresenter2(IListBoxView2 view)
        {
            this.view = view;
            this.view.ClearShoppingListAction += this.ClearShoppingListAction;
            this.view.AddShoppingListItemButtunAction += this.AddShoppingListItemButtunAction;
            this.view.DeleteShoppingListItemButtunAction += this.DeleteShoppingListItemButtunAction;
            this.view.Show();
            this.model = new ListBoxViewModel2();
        }

        /// <summary>
        /// リストボックスに項目を追加
        /// </summary>
        private void ClearShoppingListAction()
        {
            try
            {
                this.view.ShoppingList = null;
            }
            catch (Exception e)
            {
                Program.ShowErrMessage(e.Message + "\n" + e.StackTrace);
            }
        }

        /// <summary>
        /// 買い物リストに項目を追加するButton
        /// </summary>
        /// <param name="addItem">追加する項目</param>
        private void AddShoppingListItemButtunAction(string addItem)
        {
            try
            {
                if (!model.CreateShoppingListItem(addItem, out var shoppingListItem))
                {
                    this.view.ShowWarningMessage($"買い物の項目が重複しています。({shoppingListItem})");
                    return;
                }

                this.view.AddShoppingListItem = shoppingListItem;
            }
            catch (ArgumentOutOfRangeException e)
            {
                this.view.ShowWarningMessage("買い物の項目が未入力です。");
            }
            catch (Exception e)
            {
                Program.ShowErrMessage(e.Message + "\n" + e.StackTrace);
            }
        }

        /// <summary>
        /// 買い物リストkから項目を削除するButton
        /// </summary>
        /// <param name="selectedItem">選択した項目</param>
        private void DeleteShoppingListItemButtunAction(object selectedItem)
        {
            try
            {
                if (!this.model.DeleteShoppingListItem(selectedItem, out var shoppingListItem))
                {
                    this.view.ShowWarningMessage("買い物リストに削除する項目が存在していません。");
                }
                this.view.DeleteShoppingListItem = shoppingListItem;
            }
            catch (ArgumentNullException e)
            {
                this.view.ShowWarningMessage("買い物リストの項目が未選択です。");
            }
            catch (Exception e)
            {
                Program.ShowErrMessage(e.Message + "\n" + e.StackTrace);
            }
        }
    }
}