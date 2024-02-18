using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectibles : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    void Update(){
        transform.Rotate(0,360*speed*Time.deltaTime,0);
    }
}
                