using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkSound : MonoBehaviour
{
  AudioSource footsteps;
    // Start is called before the first frame update
    void Start()
    {
        footsteps = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown("up") || Input.GetKeyDown("down") || Input.GetKeyDown("left") || Input.GetKeyDown("right")){
        footsteps.Play();
      }
      if(Input.GetKeyUp("up") || Input.GetKeyUp("down") || Input.GetKeyUp("left") || Input.GetKeyUp("right")){
        footsteps.Stop();
      }
    }
}
