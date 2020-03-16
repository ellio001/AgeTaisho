using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour {
    private bool beRay = false;
    public bool ebiFlag = false;
    private Vector3 moveTo;

    // マウスボタンが押された時にコールされる
    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            //Rayの宣言
            Ray ray = new Ray();
            RaycastHit hit = new RaycastHit();
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.Log("クリック！");

            //マウスクリックした場所からRayを飛ばし、オブジェクトがあればtrue 
            if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity)) {
                switch (hit.collider.gameObject.tag) {
                    //クリックしたタグを判定
                    case "Cube":
                        Debug.Log("キューブ判定成功");
                        break;
                    case "ebi":
                        Debug.Log("エビ判定成功");
                        Judgment();
                        break;
                    case "tenpura":
                        Debug.Log("てんぷら粉判定成功");
                        break;
                }
            }
        }
    }
    public void Judgment() {
        //エビを持っていたらOffClickを呼ぶ
        //持っていなかったらOnClickを呼ぶ
        Debug.Log("判定");
        if (ebiFlag) {
            Debug.Log("マウスを離した");
            GameObject target1 = GameObject.Find("ebi");
            target1.gameObject.GetComponent<TestEbi3>().OffClick();
            ebiFlag = false;
        }
        else if (ebiFlag == false) {
            Debug.Log("マウスを押した");
            GameObject target1 = GameObject.Find("ebi");
            target1.gameObject.GetComponent<TestEbi3>().OnClick();
            ebiFlag = true;
        }
    }

    //マウスボタンが押された時にコールされる
    //public void OffClick() {
    //    print("マウスを離す");
    //    GameObject target2 = GameObject.Find("ebi");
    //    target2.GetComponent<Rigidbody>().isKinematic = false;
    //}


    //public void OnClick() {
    //    Debug.Log("ドラッグスタート");
    //    Vector3 TapPos = Input.mousePosition;
    //    GetComponent<Rigidbody>().isKinematic = true;
    //    transform.position = Camera.main.ScreenToWorldPoint(TapPos);
    //    Debug.Log(Camera.main.ScreenToWorldPoint(TapPos));
    //    Vector3 hosei = new Vector3();
    //    hosei = cameraObj.right;
    //    hosei.y *= 0;
    //    transform.position = hosei;
    //    Debug.Log(cameraObj.forward);
    //}
}
