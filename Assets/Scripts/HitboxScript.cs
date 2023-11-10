using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxScript : MonoBehaviour
{
    public float windupTimeSeconds;
    public float activeTimeSeconds;
    public float cooldownTimeSeconds;
    public bool coolingDown = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        Debug.Log("Hits trigger");
    }
}
