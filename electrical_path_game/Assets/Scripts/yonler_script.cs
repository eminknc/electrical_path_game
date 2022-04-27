using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yonler_script : MonoBehaviour
{
    public GameObject temas_obje=null;
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "zemin") {
            temas_obje = other.gameObject;
            transform.parent.GetComponent<zemin_script>().items.Add(other.gameObject);
            transform.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
