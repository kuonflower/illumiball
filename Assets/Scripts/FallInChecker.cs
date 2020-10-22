using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallInChecker : MonoBehaviour
{
    public Hole red;
    public Hole blue;
    public Hole green;

    void OnGUI()
    {
        string label = " ";

        //全てのボールが入ったらラベルを表示
        if(red.IsFallIn() && blue.IsFallIn() && green.IsFallIn())
        {
            label = "Fall in hole!";
        }

        //おまけ　文字が小さい画面から見えない場合以下のように書き換えてください

        GUIStyle font = new GUIStyle();

        font.fontSize = 50;

        GUIStyleState state = new GUIStyleState();

        state.textColor = Color.white;

        font.normal = state;

        GUI.Label(new Rect(50, 100, 200, 200), label,font);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
