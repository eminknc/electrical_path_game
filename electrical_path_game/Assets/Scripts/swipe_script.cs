using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swipe_script : MonoBehaviour
{
    Vector3 ilk_pos;
    Vector3 current_pos;
    public float swipe_sýnýr = 100f;

    void Update()
    {
        swipe();
    }
    void swipe()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ilk_pos = Input.mousePosition;

        }
        if (Input.GetMouseButton(0))
        {
            current_pos = Input.mousePosition;


            if (Mathf.Abs(ilk_pos.x - current_pos.x) > swipe_sýnýr || Mathf.Abs(ilk_pos.y - current_pos.y) > swipe_sýnýr)
            {
                if (ilk_pos.x < current_pos.x && ilk_pos.y < current_pos.y) { GetComponent<game_play_script>().sag_üst(); }
                else if (ilk_pos.x > current_pos.x && ilk_pos.y < current_pos.y) { GetComponent<game_play_script>().sol_üst(); }
                else if (ilk_pos.x < current_pos.x && ilk_pos.y > current_pos.y) { GetComponent<game_play_script>().sag_alt(); }
                else if (ilk_pos.x > current_pos.x && ilk_pos.y > current_pos.y) { GetComponent<game_play_script>().sol_alt(); }
                ilk_pos = current_pos;

            }

        }


    }
}
