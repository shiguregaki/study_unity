# SpringPushStick
## 概要
「Spring Joint」を使ったバネの動きを確認するために作成したサンプルコードです。
棒と床の間に「Spring Joint」を設定しており、マウスの距離に応じて棒に力がかかるようになっています。

![](docs/spring_joint.gif)

## ハマったこと1
マウスの距離の分に応じて力をかけるにあたって、ばねからの反発力が棒の位置を安定させなかったため、ばねにかかる力を打ち消すようにコードを書いていた。
ばねにかかる力はSpringJointコンポーネントの`currentForce`によってとれそうだったので、それを`AddForce()`で打ち消す方向に力かけていたが、、、下のように棒が大暴走した笑
結局原因は分からずで、`currentForce`は使わず、マウスの移動距離を`AddForce()`でかけるのみにした。
`currentForce`で取得できるのは実際にばねにかかっている力ではないのかも？？？

![](docs/NG1.gif)

このときに書いたコードは以下。
NG_CASE/ハマったこと1/NG1_StickController.cs

