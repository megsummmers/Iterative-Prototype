using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class cutscene : MonoBehaviour
{
  public Camera playerCam;
  public Camera cutsceneCam;
  public GameObject introText;
  public GameObject bookText;
  public GameObject doorL;
  public GameObject doorR;
  public GameObject rGem;
  public GameObject oGem;
  public GameObject yGem;
  public GameObject gGem;
  public GameObject bGem;
  public GameObject vGem;
  public GameObject pGem;
  private Material rGem_mat;
  private Material oGem_mat;
  private Material yGem_mat;
  private Material gGem_mat;
  private Material bGem_mat;
  private Material vGem_mat;
  private Material pGem_mat;
  private Material old_rGem_mat;
  private Material old_oGem_mat;
  private Material old_yGem_mat;
  private Material old_gGem_mat;
  private Material old_bGem_mat;
  private Material old_vGem_mat;
  private Material old_pGem_mat;

  bool playing = true;
    // Start is called before the first frame update
    void Start()
    {
      playerCam.enabled = false;
      cutsceneCam.enabled = true;

      //get materials
      old_rGem_mat =  rGem.GetComponent<Renderer>().material;
      old_oGem_mat =  oGem.GetComponent<Renderer>().material;
      old_yGem_mat =  yGem.GetComponent<Renderer>().material;
      old_gGem_mat =  gGem.GetComponent<Renderer>().material;
      old_bGem_mat =  bGem.GetComponent<Renderer>().material;
      old_vGem_mat =  vGem.GetComponent<Renderer>().material;
      old_pGem_mat =  pGem.GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      if(playing == true){
        float posY = gameObject.transform.position.y;
        float posX = gameObject.transform.position.x;
        if(posX >= 42){
          playing = false;
          playerCam.enabled = true;
          cutsceneCam.enabled = false;
          introText.gameObject.SetActive(false);
          bookText.gameObject.SetActive(true);
        } else if(posY <= 6){
          transform.Translate(Time.deltaTime, 0, 0, Space.World);
        } else {
          transform.Translate(Time.deltaTime, -Time.deltaTime, 0, Space.World);
          bookText.gameObject.SetActive(false);
        }
      }
      //check mats for change
      rGem_mat =  rGem.GetComponent<Renderer>().material;
      oGem_mat =  oGem.GetComponent<Renderer>().material;
      yGem_mat =  yGem.GetComponent<Renderer>().material;
      gGem_mat =  gGem.GetComponent<Renderer>().material;
      bGem_mat =  bGem.GetComponent<Renderer>().material;
      vGem_mat =  vGem.GetComponent<Renderer>().material;
      pGem_mat =  pGem.GetComponent<Renderer>().material;
      //check if all have changed
      if(old_rGem_mat!= rGem_mat & old_oGem_mat!= oGem_mat & old_yGem_mat!= yGem_mat & old_gGem_mat!= gGem_mat & old_bGem_mat!= bGem_mat & old_vGem_mat!= vGem_mat & old_pGem_mat!= pGem_mat){
        playerCam.enabled = false;
        cutsceneCam.enabled = true;
        doorR.transform.Translate(9.7f, -7f, -22.7f);
        doorR.transform.Rotate(0, 90, 0);
        doorL.transform.Translate(-4f, -7f, -17.3f);
        doorL.transform.Rotate(0, 270, 0);

        float posY = gameObject.transform.position.y;
        float posX = gameObject.transform.position.x;
        if(posX >= 24){
          playing = false;
          playerCam.enabled = true;
          cutsceneCam.enabled = false;
        } else if(posY <= 5){
          transform.Translate(Time.deltaTime, 0, 0, Space.World);
        } else {
          transform.Translate(Time.deltaTime, -Time.deltaTime, 0, Space.World);
        }
      }
    }
}
