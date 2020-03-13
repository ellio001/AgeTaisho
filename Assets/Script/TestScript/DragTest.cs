using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//テスト用のスクリプトです

public class DragTest : MonoBehaviour {

    //GameObject target1 = GameObject.Find("cube");

    public void OnMouseUp() {
        GetComponent<Rigidbody>().useGravity = true;
    }

    public void OnDrag() {
        //Vector3 TapPos = Input.mousePosition;
        //GetComponent<Rigidbody>().useGravity = false;
        //TapPos.z = 10f;
        //transform.position = Camera.main.ScreenToWorldPoint(TapPos);
    }
}