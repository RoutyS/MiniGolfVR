using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHand : MonoBehaviour
{
    public GameObject RightHandGrab;
    public GameObject LeftHandGrab;
    public GameObject RightHandTeleport;
    public GameObject LeftHandTeleport;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider col)
    {
        Debug.Log(col.name);
        if (col.name== "colRightHand Controller")
        {
            RightHandGrab.SetActive(!RightHandGrab.activeInHierarchy);
            RightHandTeleport.SetActive(!RightHandTeleport.activeInHierarchy);
            
        }

        if (col.name == "colLeftHand Controller")
        {
            LeftHandGrab.SetActive(!LeftHandGrab.activeInHierarchy);
            LeftHandTeleport.SetActive(!LeftHandTeleport.activeInHierarchy);
        }

        if (col.name == "colRight Teleportation") 
        {
            RightHandGrab.SetActive(!RightHandGrab.activeInHierarchy);
            RightHandTeleport.SetActive(!RightHandTeleport.activeInHierarchy);
        }
        
        if (col.name == "colLeft Teleportation")
        {
            LeftHandGrab.SetActive(!LeftHandGrab.activeInHierarchy);
            LeftHandTeleport.SetActive(!LeftHandTeleport.activeInHierarchy);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
      

    }

   
}
