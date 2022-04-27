using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_play_script : MonoBehaviour
{
    public List<GameObject> borulu_zeminler;
    public Transform baslangic_zemin;
    public GameObject gecici_boru;
    void Start()
    {
        borulu_zeminler.Add(baslangic_zemin.gameObject); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void sag_üst() {
        Instantiate(gecici_boru, baslangic_zemin.GetChild(2).GetComponent<yonler_script>().temas_obje.transform.GetChild(5).position, Quaternion.identity);
        baslangic_zemin = baslangic_zemin.GetChild(2).GetComponent<yonler_script>().temas_obje.transform;
    }
    public void sol_üst()
    {
        Instantiate(gecici_boru, baslangic_zemin.GetChild(1).GetComponent<yonler_script>().temas_obje.transform.GetChild(5).position, Quaternion.identity);
        baslangic_zemin = baslangic_zemin.GetChild(1).GetComponent<yonler_script>().temas_obje.transform;

    }
    public void sag_alt()
    {
        Instantiate(gecici_boru, baslangic_zemin.GetChild(4).GetComponent<yonler_script>().temas_obje.transform.GetChild(5).position, Quaternion.identity);
        baslangic_zemin = baslangic_zemin.GetChild(4).GetComponent<yonler_script>().temas_obje.transform;

    }
    public void sol_alt()
    {
        Instantiate(gecici_boru, baslangic_zemin.GetChild(3).GetComponent<yonler_script>().temas_obje.transform.GetChild(5).position, Quaternion.identity);
        baslangic_zemin = baslangic_zemin.GetChild(3).GetComponent<yonler_script>().temas_obje.transform;

    }
}
