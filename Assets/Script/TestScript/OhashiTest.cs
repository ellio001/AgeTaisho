using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//テスト用のスクリプトです
//Handオブジェクトを削除し
//Ebiオブジェを作ります



public class OhashiTest : MonoBehaviour {

    public int Flagebi = 0;

    public void Onebi() {


        //EbiプレハブをGameObject型で取得
        GameObject obj = (GameObject)Resources.Load("ebi");

        Debug.Log("座標取るよ");
        //座標をとる・角度をとる
        Vector3 tmpV = this.gameObject.transform.position;
        Quaternion tmpQ = this.gameObject.transform.rotation;

        Debug.Log("オブジェクト消すよ");
        //Handオブジェ消去
        Destroy(GameObject.Find("ebi"));

        Debug.Log("Ebi作るよ");
        //GameObject ebi = Instantiate(obj, new Vector3(tmpV.x + 0.12f, tmpV.y + 0.13f, tmpV.z + 0.2f), tmpQ) as GameObject;
        GameObject ebi = Instantiate(obj, new Vector3(tmpV.x, tmpV.y, tmpV.z), tmpQ) as GameObject;
        string ebiname = "ebi";
        ebi.name = ebiname;

        Debug.Log("Ebi親子付けするよ");
        //生成したエビを親子付けする
        ebi.transform.parent = gameObject.transform;

        if(transform.root.gameObject)

        Debug.Log("処理を終えるよ");
    }
}