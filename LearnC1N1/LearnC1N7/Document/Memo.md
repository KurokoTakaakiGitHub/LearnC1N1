# 誕生日計算

## 機能概要

- 生年月日を入力できる
- 生年月日に未来日付を入力するとラベルにエラーメッセージを表示できる
- ＯＫボタンをクリックすると次の誕生日までの日数がラベルに表示できる

## 実装

### View
- [x]生年月日が入力できる（DateTimePicker)
- [x]結果やエラーを表示するラベル（Label)
- [x]誕生日を計算するボタン(Button)

### インタフェース
（メソッド）
- [x] 生年月日を計算する-ButtonAction（引数：string:生年月日)
- [ ] View表示

（プロパティ）
- [x] Message(string)  
- [ ] 

### Model
- [x] 生年月日を計算する（引数：string:生年月日)
