using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class toggleBook : MonoBehaviour
{
  public MeshRenderer bookRend;
  public GameObject txt;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown("return")){
        if(bookRend.enabled){
          bookRend.enabled = !bookRend.enabled;
          txt.gameObject.SetActive(false);
        } else if(!bookRend.enabled){
          bookRend.enabled = !bookRend.enabled;
          txt.gameObject.SetActive(true);
        }
      }
    }
}
