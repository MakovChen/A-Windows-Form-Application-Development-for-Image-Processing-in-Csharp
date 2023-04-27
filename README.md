# 自動化光學檢測之Windows Form (C#)釋例

## 目錄

- [開發工具介紹](#背景)
    - [Visual Studio & Visual Studio Code]()
    - [C#(C-sharp)]()
    - [EmguCV]()
- [相關實作]()
    - [一、數位影像邏輯]()

## 開發工具
### Visual Studio & Visual Studio Code
Visual Studio是Microsoft提供的程式編譯IDE，並以完善的開發工具著名。就以本次要開發的GUI為例，其就提供了拖拉式介面幫助我們編輯GUI的版型，並根據這個版型生成程式碼模板，使我們只要在每個物件寫上客製化的功能就能夠完成開發，減少很多不必要的開發時程。
*/紅色區塊為對應到視窗程序的程式碼*
### C#(C-sharp)
C#則是基於Windows系統衍伸的程式語言(也就是說它在windows上的執行效率最高)，而其也在繼承了C和C++優點的同時去掉了一些複雜繁瑣的功能，幫助我們更快地編輯所需實現的功能。

### EmguCV
EmguCV是一個基於OpenCV且支援$.$NET Framework的影像處理模組，可以直接使用`NuGet`第三方管理工具來獲取所需的套件。
*/[專案]>[管理NuGet套件(N)]*

## 影像處理

