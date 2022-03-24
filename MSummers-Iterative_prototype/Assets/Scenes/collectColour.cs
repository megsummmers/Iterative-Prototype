using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectColour : MonoBehaviour
{
  //public GameObject mazeWalls;
  bool collected = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (collected == true)
      {
        //mazeWalls.transform.Translate(0, -Time.deltaTime, 0, Space.World);
        Debug.Log(":D");
        transform.parent.transform.Translate(0, -Time.deltaTime, 0, Space.World);
        // float posY = gameObject.transform.parent.transform.position.y;
        // if (posY <= -8){
        //   collected = false;
        // }
      }
    }

    void OnTriggerEnter(Collider other)
    {
      if(other.CompareTag("Player")){
        Debug.Log("Picked up red");
        //hides object
        gameObject.SetActive(false);
        //raise the star
        collected = true;
      }
    }
}
