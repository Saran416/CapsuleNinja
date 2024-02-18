using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class donutcollector : MonoBehaviour
{
    [SerializeField] Text countText;
    [SerializeField] int count=0;

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("donuts")){
            count++;
            countText.text= "Donuts:" + count;
            print("Collected");
            Destroy(collision.gameObject);
        }
    }
}
