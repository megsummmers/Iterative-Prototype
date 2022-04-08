using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class end_scene : MonoBehaviour
{
  public Camera playerCam;
  public Camera cutsceneCam;
  public TMP_Text endText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
      if(other.CompareTag("Player")){
        //change gem colour

        playerCam.enabled = false;
        endText.enabled = true;
        cutsceneCam.transform.position = new Vector3(50f, 12f, 0f);
        cutsceneCam.enabled = true;
      }
    }
}
