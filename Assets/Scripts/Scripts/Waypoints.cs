using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints;
    int waypointindex = 0; 
    [SerializeField] float speed = 1f;
   
    void Update()
    {
        if(Vector3.Distance(transform.position, waypoints[waypointindex].transform.position) < 0.1f){
            waypointindex++;
            if(waypointindex >= waypoints.Length){
                waypointindex=0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointindex].transform.position, speed*Time.deltaTime);
    }
}
