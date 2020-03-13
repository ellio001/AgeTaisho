using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Test_Okyaku : MonoBehaviour {

    //色が変わるタイミング(時間)を「Cube」のInspector(Duration)で指定、初期値は1.0F
    public float duration = 1.0F;
    float Count;
    float Max;

    private void Start() {
        Max = 600f;
        Count = Max;
    }

    private void Update() {
        Count += 1f;

        if (Count >= Max) {
            //ランダム変数
            float Ten = Random.Range(0f, 3f);
            //print(Ten);
            if (Ten >= 0f && Ten <= 0.9f) {
                print("いか天");
            }
            if (Ten >= 1f && Ten <= 1.9f) {
                print("芋天");
            }
            if (Ten >= 2f && Ten <= 3f) {
                print("エビ天");
            }
            //durationの時間ごとに色が変わる
            float phi = Time.time / Count * 2 * Mathf.PI;
            //マテリアルを変える変数
            float amplitude = Mathf.Cos(phi) * 0.5F + 0.5F;
            //色をRGBではなくHSVで指定
            gameObject.GetComponent<Renderer>().material.color = Color.HSVToRGB(amplitude, 1f, 1f);
            //Countを初期化
            Count = 0;
        }
    }
}
