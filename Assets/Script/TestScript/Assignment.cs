using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment : MonoBehaviour {

    //Boxを生成
    int Box;

    // Use this for initialization
    void Start() {
        //初期化
        Box = 0;
    }
    // Update is called once per frame
    void Update() {

        if (Input.GetAxisRaw("L_Horizontal") < 0/* && -0.4 < transform.rotation.y*/) {
            Debug.Log("左に傾いている");
            //transform.Rotate(new Vector3(0, -2.0f, 0));
            //Judgement();
            switch (Box) {
                case 0:
                    Debug.Log(Box);
                    //transform.Rotate(new Vector3(0, -2.0f, 0));
                    break;

                case 1:
                    Debug.Log(Box);
                    camera(10f, 0f, 10f);
                    break;

                case 2:
                    Debug.Log(Box);
                    camera(20f, 0f, 10f);
                    break;

                case 3:
                    Debug.Log(Box);
                    camera(30f, 0f, 30f);
                    break;
            }

        }
        else if (0 < Input.GetAxisRaw("L_Horizontal")/* && transform.rotation.x > 0.4*/) {
            Debug.Log("右に傾いている");
            switch (Box) {
                case 0:
                    Debug.Log(Box);
                    camera(10f, 0f, 10f);
                    //transform.Rotate(new Vector3(0, 2.0f, 0));
                    break;

                case 1:
                    Debug.Log(Box);
                    camera(10f, 0f, 10f);
                    break;

                case 2:
                    Debug.Log(Box);
                    camera(20f, 0f, 10f);
                    break;

                case 3:
                    Debug.Log(Box);
                    camera(30f, 0f, 30f);
                    break;
            }

            //transform.Rotate(new Vector3(0, 2.0f, 0));
            //Judgement();
        }
        else {
            //左右方向には傾いていない
        }

        //if (Input.GetKey(KeyCode.RightArrow)) {
        //    transform.Rotate(new Vector3(0, 2.0f, 0));
        //}
        //else if (Input.GetKey(KeyCode.LeftArrow)) {
        //    transform.Rotate(new Vector3(0, -2.0f, 0));
        //}
    }

    //どこを向いているか確認する
    public void Judgement() {
        switch (Box) {
            case 0:
                Debug.Log(Box);
                camera(0f, 0f, 0f);
                break;

            case 1:
                Debug.Log(Box);
                camera(10f, 0f, 10f);
                break;

            case 2:
                Debug.Log(Box);
                camera(20f, 0f, 10f);
                break;

            case 3:
                Debug.Log(Box);
                camera(30f, 0f, 30f);
                break;
        }
    }

    //カメラの角度処理
    public new void camera(float x, float y, float z) {

        Debug.Log("カメラを動かす");
//        transform.Rotate(new Vector3(x, y, z));

        //GameObject.Find("Main Camera").transform.Rotate(x,y,z);
    }
}