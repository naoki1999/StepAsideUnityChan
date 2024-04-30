using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemDelete : MonoBehaviour
{
    //Unity�����̃I�u�W�F�N�g
    private GameObject unitychan;
    //carPrefab������
    public GameObject carPrefab;
    //coinPrefab
    public GameObject coinPrefab;
    //conePrefab������
    public GameObject TrafficConePrefab;
    //Unity�����Ɗe��I�u�W�F�N�g�̋���
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        //Unity�����̃I�u�W�F�N�g���擾
        this.unitychan = GameObject.Find("unitychan");
        //�Ԃ̃I�u�W�F�N�g���擾
        this.carPrefab = GameObject.Find("CarPrefab");
        //�R�C���̃I�u�W�F�N�g���擾
        this.coinPrefab = GameObject.Find("CoinPrefab");
        //�R�[���̃I�u�W�F�N�g���擾
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
