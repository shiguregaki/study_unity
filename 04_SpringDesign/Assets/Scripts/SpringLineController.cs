using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringLineController : MonoBehaviour
{
    // 参考
    // [2点間に引く線をLine Rendererで描画する[Unity5][2D]](https://qiita.com/otuki0191/items/0be096c527d542d796cc)
    // [LineRenderer](https://docs.unity3d.com/ja/current/ScriptReference/LineRenderer.html)

    LineRenderer line;
    GameObject Stick, Floor;

    // Start is called before the first frame update
    void Start()
    {
        this.Stick = GameObject.Find("Stick");
        this.Floor = GameObject.Find("Floor");

        //コンポーネントを取得する
        this.line = GetComponent<LineRenderer>();

        //線の色と幅を決める
        this.line.startColor = new Color(0.821f, 0.750f, 0.097f, 1.0f);
        this.line.endColor = new Color(0.821f, 0.750f, 0.097f, 1.0f);
        this.line.startWidth = 0.3f;
        this.line.endWidth = 0.3f;

        //頂点の数を決める
        this.line.positionCount = 2;
    }

    // Update is called once per frame
    void Update()
    {
        line.SetPosition(0, Stick.transform.position);
        line.SetPosition(1, Floor.transform.position);
    }
}
