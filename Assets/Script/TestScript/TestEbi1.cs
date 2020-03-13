using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEbi1 : MonoBehaviour {

    public bool Flag = false;
    public int Count = 0;
    public bool CountFlag = true;

    GameObject ebiPrefab;
    GameObject ebinozz;

    private void Start()
    {
        ebiPrefab = (GameObject)Resources.Load("ebi");
        ebinozz = GameObject.Find("EbiNozz");
    }

    // Update is called once per frame
    void Update() {
        //       if (Input.GetMouseButton(0)) {
        //           //生成したHandを親子付けする
        //           GameObject.Find("ebi").transform.parent =
        //               GameObject.Find("EbiNozz").transform;
        //           GetComponent<Rigidbody>().isKinematic = true;
        //       }
        //       else if (Input.GetMouseButtonUp(0)) {
        //           GameObject.Find("ebi").transform.parent =
        //               null;
        //           GetComponent<Rigidbody>().isKinematic = false;
        //       }
    }

    public void Judgment() {
        //エビを持っていたらOffClickを呼ぶ
        //持っていなかったらOnClickを呼ぶ
        Debug.Log("判定");
        if (Flag) {
            OnClick();
        }
        else if (Flag == false) {
            OffClick();
        }
    }


    public void OnClick() {
        if (Input.GetMouseButtonDown(0)) {

            //Instantiate(ebiPrefab, new Vector3(0.0f, 5.0f, 0.0f), Quaternion.identity);
            Instantiate(ebiPrefab, ebinozz.transform.position, Quaternion.identity);

            //生成したHandを親子付けする
            GameObject.Find("ebi(Clone)").transform.parent = ebinozz.transform;
            GetComponent<Rigidbody>().isKinematic = true;
            Flag = false;
            print(Flag);
        }
    }
    public void OffClick() {
        if (Input.GetMouseButtonUp(0)) {
            GameObject.Find("ebi(Clone)").transform.parent =
                null;
            GetComponent<Rigidbody>().isKinematic = false;
            Flag = true;
            print(Flag);
        }
    }

    private void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "tenpura") {
            Debug.Log("鍋で揚げます");
            if (CountFlag) {

                Count++;
                print(Count);

                if (Count == 100)
                {
                    //プレハブの取得  
                    GameObject obj = (GameObject)Resources.Load("tenpura");

                    //座標をとる・角度をとる
                    Vector3 tmpV = this.gameObject.transform.position;
                    Quaternion tmpQ = this.gameObject.transform.rotation;

                    //エビのオブジェクト削除
                    Debug.Log("オブジェクト消すよ");
                    Destroy(GameObject.Find("ebi"));

                    //プレハブ生成
                    GameObject tenpura = Instantiate(obj, new Vector3(tmpV.x, tmpV.y, tmpV.z), tmpQ) as GameObject;
                    string tenName = "tenpura";
                    tenpura.name = tenName;
                    CountFlag = false;
                }
            }
        }
    }
}