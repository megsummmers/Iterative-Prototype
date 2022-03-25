using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class collectColour : MonoBehaviour
{
  //public GameObject mazeWalls;
  public GameObject redGem;
  public Material redMat;
  public MeshRenderer gemRend;
  public GameObject walls;
  public TMP_Text redCheck;
  private bool anim = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
      //move walls down
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
        //strikethrough red gem on checklist
        redCheck.fontStyle = FontStyles.Underline;
        //move the walls
        anim = true;
      }
    }
}
