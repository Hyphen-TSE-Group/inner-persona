using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
// public TMP_Text hint_txt;


/**This script is for an event in Unity game engine. 
It sets the text of two TextMeshPro text objects and plays an audio clip. 
And starts an animation when the player enters the trigger area of the game object. **/

public class Event1 : MonoBehaviour

{
public TMP_Text obj_txt;
public TMP_Text objUpdated;
public AudioSource updatedSound;
public GameObject Creature;
public Animator anim;
public bool trigger= true;
    // // Start is called before the first frame update
    void Start()
    {
          
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }


/**This function is called when the player enters the trigger area of the game object
It starts a coroutine function called waitForSec which waits for 1.7 seconds 
And then sets the text of TextMeshPro text objects and plays an audio clip and starts an animation. **/

     private void OnTriggerEnter(Collider other) {

        // objUpdated.SetText("Objective Updated");
        // updatedSound.Play();
        // anim.Play("IntroText", 0,0.0f);
        if(trigger){
        StartCoroutine(waitForSec()); 
        Creature.SetActive(true);
        trigger= false;
        // Destroy(gameObject);
        } 
        
    }

    IEnumerator waitForSec(){
        yield return new WaitForSeconds(1.7f);
        Creature.SetActive(false);
        // yield return new WaitForSeconds(1.8f);
        objUpdated.SetText("Objective Updated");
        obj_txt.SetText("Explore the house !!");
        updatedSound.Play();
        anim.Play("IntroText", 0,0.0f);
        
    }





}