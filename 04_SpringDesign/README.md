# SpringDesign
バネのデザインを調査したところ、Blenderなどの3Dモデル作成ツールを使えばバネを作成することが分かりました。

しかし、、、少しBlenderを触ってみましたが、まったくわからなかったため、苦肉の策としてバネの部分を線で結ぶことにしました。

*****************************************************************

## Spring Jointの間を線で結ぶ
*****************************************************************

### 概要
シーン名：「SpringDesign」

Spring Jointを設定したオブジェクト(押し出し棒)と床の間に`LineRenderer()`で線をひきました。

![](docs/SpringDesign.gif)

全然バネに見えませんが、、、苦肉の策です。

Blenderを勉強したら、再度挑戦したいと思います。

### 使い方
1. study_unity/04_SpringDesignをご自分の環境に読み込ませてください。
2. シーン名：「SpringDesign」を開いてください。

### 参考

* [2点間に引く線をLine Rendererで描画する[Unity5][2D]](https://qiita.com/otuki0191/items/0be096c527d542d796cc)
* [LineRenderer](https://docs.unity3d.com/ja/current/ScriptReference/LineRenderer.html)
