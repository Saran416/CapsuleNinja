using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerlife : MonoBehaviour
{
   void OnCollisionEnter(Collision collision){
    if(collision.gameObject.CompareTag("enemy")){
        die();
    } 
   }

   void Update(){
     if(transform.position.y < -5f){
        die();
     }
   }

   void die(){
        GetComponent<Rigidbody>().isKinematic=true; 
        GetComponent<MeshRenderer>().enabled=false;
        GetComponent<PlayerMovement>().enabled= false;
        Invoke(nameof(respawn),1.3f);
   }

    void respawn(){
        SceneManager.LoadScene(1);
    }
}
