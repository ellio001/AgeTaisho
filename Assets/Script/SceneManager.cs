using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {
    //public string cubeTag = "Cube";
    //public string ebiTag = "ebi";
    //public string tenTag = "tenpura";
    //public string karaTag;
    //public int objTag = 0;
    //private bool beRay = false;
    //private Vector3 moveTo;

    GameObject ebiPrefab;

    private void Start()
    {
        // CubeプレハブをGameObject型で取得
        ebiPrefab = (GameObject)Resources.Load("ebi");

        // Cubeプレハブを元に、インスタンスを生成、
        //Instantiate(ebiPrefab, new Vector3(0.0f, 5.0f, 0.0f), Quaternion.identity);
    }

    // Update is called once per frame  
    void Update() {
        //if (Input.GetMouseButton(0)) {
        Ray ray = new Ray();
        RaycastHit hit = new RaycastHit();
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //Rayを飛ばし、オブジェクトがあればtrue 
        if (Physics.Raycast(ray.origin, ray.direction, out hit, 2f)){
            switch (hit.collider.gameObject.tag) {
                //クリックしたタグを判定
                case "Cube":
                    Debug.Log("キューブ判定成功");
                    break;
                case "ebibox":
                    Debug.Log("エビの箱");
                    // Cubeプレハブを元に、インスタンスを生成、
                    //Instantiate(ebiPrefab, new Vector3(0.0f, 5.0f, 0.0f), Quaternion.identity);

                    GameObject target1 = GameObject.Find("ebi");
                    target1.gameObject.GetComponent<TestEbi1>().Judgment();
                    break;
                case "ebiten":
                    Debug.Log("てんぷら判定成功");
                    break;
            }
        }
    }
}