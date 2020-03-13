using UnityEngine;
using System.Collections;

public class TestSceneManager : MonoBehaviour {
    public int objTag = 0;
    private bool beRay = false;
    private bool ebiFlag = false;
    private Vector3 moveTo;

    //テスト用のスクリプトです

    // マウスボタンが押された時にコールされる
    void OnMouseDown() {
        print("クリック！");
        ebiFlag = true;
    }

    //マウスボタンが押された時にコールされる
    public void OnMouseUp() {
        GameObject target2 = GameObject.Find("ebi");
        target2.GetComponent<Rigidbody>().useGravity = true;
    }


    public void OnDrag() {
        Debug.Log("ドラッグスタート");
        GameObject target2 = GameObject.Find("ebi");
        Vector3 TapPos = Input.mousePosition;
        target2.GetComponent<Rigidbody>().useGravity = false;
        TapPos.z = 2f;
        //transform.position = Camera.main.ScreenToWorldPoint(TapPos);
    }
}