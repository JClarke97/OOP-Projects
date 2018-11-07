using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    private stat Experiance;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Experiance.CurrentVal -= 10;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Experiance.CurrentVal += 10;
            
}
