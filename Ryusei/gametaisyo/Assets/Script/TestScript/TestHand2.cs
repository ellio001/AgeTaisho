using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Handオブジェクトを削除し
//Ebiオブジェを作ります

public class TestHand2 : MonoBehaviour {
    public void OnHand() {
        //EbiプレハブをGameObject型で取得
        GameObject obj = (GameObject)Resources.Load("Ebi");
        Debug.Log("座標取るよ");

        //座標をとる・角度をとる
        Vector3 tmpV = this.gameObject.transform.position;
        Quaternion tmpQ = this.gameObject.transform.rotation;

        Debug.Log("オブジェクト消すよ");
        //Handオブジェ消去
        //Destroy(GameObject.Find("Hand"));

        Debug.Log("Ebi作るよ");
        //Ebiプレハブを元に、インスタンスを生成
        Instantiate(obj, new Vector3(tmpV.x, tmpV.y, tmpV.z), tmpQ);
        GameObject.Find("Ebi(Clone)").name = ("Ebi");

        Debug.Log("Ebi親子付けするよ");
        //生成したエビを親子付けする
        GameObject.Find("Ebi").transform.parent =
            GameObject.Find("FPSPlayer").transform;

        Debug.Log("処理を終えるよ");
    }
}