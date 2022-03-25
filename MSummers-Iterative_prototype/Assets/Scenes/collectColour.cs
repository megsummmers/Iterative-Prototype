using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectColour : MonoBehaviour
{
  //public GameObject mazeWalls;
  public GameObject redGem;
  public Material redMat;
  public MeshRenderer gemRend;
  public GameObject walls;
  private bool anim = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
      if(anim){
        Debug.Log(":D");
        walls.transform.Translate(0, -0.1f, 0);
      }
    }

    void OnTriggerEnter(Collider other)
    {
      if(other.CompareTag("Player")){
        //hides object
        gemRend.enabled = false;
        //change gem colour
        redGem.GetComponent<Renderer>().material = redMat;
        anim = true;
        //move walls

        // if(anim == true){
        //   Debug.Log(":D");
        //   walls = GameObject.FindGameObjectsWithTag("Movable");
        //   foreach(GameObject w in walls){
        //     w.transform.Translate (Vector3.down * Time.deltaTime, Space.World);
        //     float posY = gameObject.transform.position.y;
        //     if (posY <= -8){
        //       anim = false;
        //     }
        //   }
        // }
      }
    }
}
