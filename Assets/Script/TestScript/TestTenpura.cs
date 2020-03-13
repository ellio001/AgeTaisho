using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTenpura : MonoBehaviour {

    //public bool Flag = false;
    //public int Count = 0;
    //public bool CountFlag = true;


    //// Update is called once per frame
    //void Update() {
    //    //       if (Input.GetMouseButton(0)) {
    //    //           //生成したHandを親子付けする
    //    //           GameObject.Find("ebi").transform.parent =
    //    //               GameObject.Find("EbiNozz").transform;
    //    //           GetComponent<Rigidbody>().isKinematic = true;
    //    //       }
    //    //       else if (Input.GetMouseButtonUp(0)) {
    //    //           GameObject.Find("ebi").transform.parent =
    //    //               null;
    //    //           GetComponent<Rigidbody>().isKinematic = false;
    //    //       }
    //}

    //public void Judgment() {
    //    //エビを持っていたらOffClickを呼ぶ
    //    //持っていなかったらOnClickを呼ぶ
    //    Debug.Log("判定");
    //    if (Flag) {
    //        OnClick();
    //    }
    //    else if (Flag == false) {
    //        OffClick();
    //    }
    //}


    //public void OnClick() {
    //    if (Input.GetMouseButton(0)) {

    //        //生成したHandを親子付けする
    //        GameObject.Find("ebi").transform.parent =
    //            GameObject.Find("EbiNozz").transform;
    //        GetComponent<Rigidbody>().isKinematic = true;
    //        Flag = false;
    //        print(Flag);
    //    }
    //}
    //public void OffClick() {
    //    if (Input.GetMouseButtonUp(0)) {
    //        GameObject.Find("ebi").transform.parent =
    //            null;
    //        GetComponent<Rigidbody>().isKinematic = false;
    //        Flag = true;
    //        print(Flag);
    //    }
    //}

    //private void OnTriggerStay(Collision other) {
    //    if (other.gameObject.tag == "ebiten") {
    //        Debug.Log("鍋で揚げます");
    //        if (CountFlag) {
    //            Count++;
    //            print(Count);
    //            if (Count == 100) {
    //                //プレハブの取得  
    //                GameObject obj = (GameObject)Resources.Load("ebiten");

    //                //座標をとる・角度をとる
    //                Vector3 tmpV = this.gameObject.transform.position;
    //                Quaternion tmpQ = this.gameObject.transform.rotation;

    //                //エビのオブジェクト削除
    //                Debug.Log("オブジェクト消すよ");
    //                Destroy(GameObject.Find("ebi"));

    //                //プレハブ生成
    //                GameObject tenpura = Instantiate(obj, new Vector3(tmpV.x, tmpV.y, tmpV.z), tmpQ) as GameObject;
    //                string tenName = "ebiten";
    //                tenpura.name = tenName;
    //                CountFlag = false;
    //            }
    //        }
    //    }
    //}
}
