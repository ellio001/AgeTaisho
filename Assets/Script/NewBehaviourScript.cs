using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public GameObject hand;
    Rigidbody rb;
    public float accelerationScale; // 加速度の大きさ

    　public GameObject objGet;  //追加

    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        //メインカメラ上のマウスポインタのある位置からrayを飛ばす
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButton(0)) {
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                //Rayが当たったオブジェクトの名前と位置情報をログに表示する
                Debug.Log(hit.collider.gameObject.name);
                Debug.Log(hit.collider.gameObject.transform.position);
                objGet = GameObject.Find(hit.collider.gameObject.name); //追加

                if (hit.collider.gameObject.tag == "item")
                {
                    //Rayが当たったオブジェクトのRigidbody取得
                    rb = hit.collider.GetComponent<Rigidbody>();

                    //手の座標-Rayが当たったオブジェクトの座標
                    var direction = hand.transform.position - hit.collider.transform.position;
                    direction.Normalize();

                    //Rigidbodyに力を加える
                    // rb.AddForce(10, 100, 10);
                    rb.AddForce(accelerationScale * direction, ForceMode.Acceleration);
                }
            }
        }
    }
}
