using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baslangic_script : MonoBehaviour
{
    GameObject[] zeminler;
    Vector3[] old_poses;

    public Transform yan_boru_baslangic;
    public Transform yan_boru_baslangic_pos_1;
    public Transform yan_boru_baslangic_pos_2;
    public Transform yan_boru_bitis;
    public Transform yan_boru_bitis_pos_1;
    public Transform yan_boru_bitis_pos_2;

    public Transform[] yan_objeler = new Transform[8];
    Vector3[] yan_objeler_old_poses;
    void Start()
    {
        yan_objeler_old_poses = new Vector3[yan_objeler.Length];
        for (int i = 0; i < yan_objeler.Length; i++) {
            yan_objeler_old_poses[i] = yan_objeler[i].position;
        
        }
        for (int i = 0; i < yan_objeler.Length; i++)
        {
            yan_objeler[i].transform.position = new Vector3(yan_objeler[i].transform.position.x, yan_objeler[i].transform.position.y + 25, yan_objeler[i].transform.position.z);

        }

        yan_boru_baslangic.position = yan_boru_baslangic_pos_1.position;
        yan_boru_bitis.position = yan_boru_bitis_pos_1.position;

        zeminler = GameObject.FindGameObjectsWithTag("zemin");
        old_poses = new Vector3[zeminler.Length];
        for (int i = 0; i < zeminler.Length; i++)
        {
            old_poses[i] = zeminler[i].transform.position;
        }
        for (int i = 0; i < zeminler.Length; i++)
        {
            zeminler[i].transform.position = new Vector3(zeminler[i].transform.position.x, zeminler[i].transform.position.y - 25, zeminler[i].transform.position.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("s")) {
            get_start();
        
        }
    }

    void get_start()
    {
        for (int i = 0; i < zeminler.Length; i++)
        {
            
            float rand = UnityEngine.Random.Range(0.5f, 1.7f);
            zeminler[i].transform.DOMove(old_poses[i], rand);
        }
        StartCoroutine(wait());

    }
    IEnumerator wait() {
        yield return new WaitForSeconds(1.5f);
        yan_boru_baslangic.transform.DOMove(yan_boru_baslangic_pos_2.position, 0.7f);
        yan_boru_bitis.transform.DOMove(yan_boru_bitis_pos_2.position, 0.7f);
        for (int i = 0; i < yan_objeler.Length; i++)
        {

            yan_objeler[i].DOMove(yan_objeler_old_poses[i], 0.7f);
        }
    }
}
