using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectColour : MonoBehaviour
{
  //public GameObject mazeWalls;
  public GameObject redGem;
  public Material redMat;
  bool anim = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    void OnTriggerEnter(Collider other)
    {
      if(other.CompareTag("Player")){
        //hides object
        gameObject.SetActive(false);
        //change gem colour
        redGem.GetComponent<Renderer>().material = redMat;
        Debug.Log(":D");
        anim = true;
        //move walls
        if(anim == true){
          Debug.Log(":D");
          transform.parent.transform.Translate(0, -Time.deltaTime, 0, Space.World);
          float posY = gameObject.transform.parent.transform.position.y;
          if (posY <= -8){
            anim = false;
          }
        }
      }
    }
}
