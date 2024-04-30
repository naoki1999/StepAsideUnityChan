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
        if (this.transform.position.z < this.unitychan.transform.position.z) 
        {
            Destroy(this.gameObject);
        }
        
    }
}
