using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public GameObject camara_tp;
    public GameObject camara_fp;



    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            CameraOne ();
        }

        if (Input.GetKeyDown("2"))
        {
            CameraTwo ();
        }

    }

    void CameraOne()
    {
        camara_tp.SetActive(true);
        camara_fp.SetActive(false);
    }

    void CameraTwo()
    {
        camara_tp.SetActive(false);
        camara_fp.SetActive(true); 
    }
}