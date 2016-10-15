using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {
    public GameObject bottombullet;
    Transform firepos;
	// Use this for initialization
	void Start ()
    {
        firepos = transform.FindChild("firepos");
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            fire();
        }
	}

    void fire()
    {
        Instantiate(bottombullet, firepos.position, Quaternion.identity);
    }
}
