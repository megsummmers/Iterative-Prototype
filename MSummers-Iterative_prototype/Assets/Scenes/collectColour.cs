using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class collectColour : MonoBehaviour
{
  //public GameObject mazeWalls;
  public GameObject gem;
  public Material mat;
  public MeshRenderer rend;
  public GameObject walls;
  public TMP_Text gemCheck;
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
        walls.transform.Translate(0, -0.1f, 0);
      }
    }

    void OnTriggerEnter(Collider other)
    {
      if(other.CompareTag("Player")){
        //change gem colour
        gem.GetComponent<Renderer>().material = mat;
        //strikethrough red gem on checklist
        gemCheck.fontStyle = FontStyles.Underline;
        //hides object
        rend.enabled = false;
        if(gem.name == "Red_gem"){
          anim = true;
        }
      }
    }
}
