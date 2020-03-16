using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//テスト用のスクリプトです

public class TestEbi3 : MonoBehaviour {

    public void OffClick() {
        GetComponent<Rigidbody>().isKinematic = false;
    }

    public void OnClick() {
        Vector3 TapPos = Input.mousePosition;
        //Vector3 TapPos = Camera.;
        GetComponent<Rigidbody>().isKinematic = true;
        transform.position = Camera.main.ScreenToWorldPoint(TapPos);
        Debug.Log(Camera.main.ScreenToWorldPoint(TapPos));
        //Vector3 hosei = new Vector3();
        //hosei = cameraObj.right;
        //hosei.y *= 0;
        //transform.position = hosei;
        //Debug.Log(cameraObj.forward);
    }
}
