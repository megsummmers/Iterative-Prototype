using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class cutscene : MonoBehaviour
{
  public Camera playerCam;
  public Camera cutsceneCam;
  public GameObject introtxt;
  public GameObject bookText;

  bool playing = true;
    // Start is called before the first frame update
    void Start()
    {
      playerCam.enabled = false;
      cutsceneCam.enabled = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      Debug.Log(":D");
      if(playing == true){
        float posY = gameObject.transform.position.y;
        float posX = gameObject.transform.position.x;
        if(posX >= 42){
          playing = false;
          playerCam.enabled = true;
          cutsceneCam.enabled = false;
          introtxt.gameObject.SetActive(false);
          bookText.GetComponent<Canvas>().enabled = true;
        } else if(posY <= 6){
          transform.Translate(Time.deltaTime, 0, 0, Space.World);
        } else {
          transform.Translate(Time.deltaTime, -Time.deltaTime, 0, Space.World);
        }
      }
    }
}
