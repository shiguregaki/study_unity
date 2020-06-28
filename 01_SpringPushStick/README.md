# SpringPushStick
## 概要
「Spring Joint」を使ったバネの動きを確認するために作成したサンプルコードです。

棒と床の間に「Spring Joint」を設定しており、マウスの距離に応じて棒に力がかかるようになっています。

![](docs/spring_joint.gif)

## ハマったこと1
マウスの距離の分に応じて力をかけるにあたって、ばねからの反発力が棒の位置を安定させなかったため、マウスの距離からの力以外にばねにかかる力を打ち消すような力を加えるようにコードを書いていた。

ばねにかかる力はSpringJointコンポーネントの`currentForce`によってとれそうだったので、それを`AddForce()`で打ち消す方向に力かけていたが、、、下のように棒が大暴走した笑

結局、`currentForce`は使わず、マウスの移動距離を`AddForce()`でかけるのみにしたら安定した。

`currentForce`で取得できるのは実際にばねにかかっている力ではないのかも？？？

![](docs/NG1.gif)

このときに書いたコードは以下に格納した。

[NG_CASE/ハマったこと1/NG1_StickController.cs](NG_CASE/ハマったこと1/NG1_StickController.cs)

## 参考

* [Spring Jointのマニュアル](https://docs.unity3d.com/ja/current/Manual/class-SpringJoint.html)
* [UnityのSpring Jointを使う](https://qiita.com/yanosen_jp/items/1642fb928a140146cf1b)

