using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemDelete : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;
    //carPrefabを入れる
    public GameObject carPrefab;
    //coinPrefab
    public GameObject coinPrefab;
    //conePrefabを入れる
    public GameObject TrafficConePrefab;
    //Unityちゃんと各種オブジェクトの距離
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        //車のオブジェクトを取得
        this.carPrefab = GameObject.Find("CarPrefab");
        //コインのオブジェクトを取得
        this.coinPrefab = GameObject.Find("CoinPrefab");
        //コーンのオブジェクトを取得
        this.TrafficConePrefab = GameObject.Find("TrafficConePrefab");
    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんと各オブジェクトの相対距離を求める
        this.difference 
            = this.unitychan.transform.position.z - this.transform.position.z;

        //各オブジェクトがUnityちゃんよりも後方の画面外に遷移した場合 (画面外 = 相対距離が6以上)
        if (this.difference > 6.0f) 
        {
            //オブジェクトを破棄
            Destroy(this.gameObject);
        }
        
    }
}
