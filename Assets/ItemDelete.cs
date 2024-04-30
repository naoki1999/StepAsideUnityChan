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
        //Unity�����Ɗe�I�u�W�F�N�g�̑��΋��������߂�
        this.difference 
            = this.unitychan.transform.position.z - this.transform.position.z;

        //�e�I�u�W�F�N�g��Unity������������̉�ʊO�ɑJ�ڂ����ꍇ (��ʊO = ���΋�����6�ȏ�)
        if (this.difference > 6.0f) 
        {
            //�I�u�W�F�N�g��j��
            Destroy(this.gameObject);
        }
        
    }
}
