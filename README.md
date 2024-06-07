
# AbstractOverrideSample

## 程式背景

出貨程式每天都會運作，撈取 SQL DB 上出貨資訊必需串接很長一串 SQL 條件、多表，且資料範圍僅限於每天有時候遇到資料異常時，必需限縮範圍在前幾天的出貨資料，就必須改程式內複數條件的 SQL。
因此經常發現 SQL 修改不完全或修改完後未復原的問題，測試環境和正式環境共用同一組程式碼。
為突破這種窘境，提議拆分出測試環境／正式環境用的 SQL，在測試環境確認完畢再逐項對正式環境修改。

![程式變革說明圖](https://github.com/SquZareZz/AbstractOverrideSample/blob/main/pictures/%E7%A8%8B%E5%BC%8F%E8%AE%8A%E9%9D%A9%E8%AA%AA%E6%98%8E%E5%9C%96.jpg)

### 介紹

抽象方法不會直接實作，而是由測試環境 Model 和正式環境 Model 繼承而成。測試環境可以隨人員需求直接 override 要測試的項目使用，當測試完確定會成為通則後，改抽象方法的（Abstract Model）內的原始規範，原則上不直接 override  Release Model，會 override  Release Model 除非需要利用正式環境做一些測試，或是針對單一客戶新增特例，否則盡可能讓它成為通則

![抽象方法說明圖](https://github.com/SquZareZz/AbstractOverrideSample/blob/main/pictures/%E6%8A%BD%E8%B1%A1%E6%96%B9%E6%B3%95%E8%AA%AA%E6%98%8E%E5%9C%96.jpg)