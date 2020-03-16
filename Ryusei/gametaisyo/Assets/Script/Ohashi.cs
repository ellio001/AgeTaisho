using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ohashi : MonoBehaviour {

    GameObject target2 = GameObject.Find("ebi");

    public void OnMouseUp() {
        target2.GetComponent<Rigidbody>().useGravity = true;
    }

    public void OnDrag() {
        Debug.Log("ドラッグスタート");
        Vector3 TapPos = Input.mousePosition;
        target2.GetComponent<Rigidbody>().useGravity = false;
        //TapPos.z = 10f;
        //transform.position = Camera.main.ScreenToWorldPoint(TapPos);
    }
}