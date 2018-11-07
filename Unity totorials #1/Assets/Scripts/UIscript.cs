using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIscript : MonoBehaviour {

    [SerializeField]
    private Text valueText;
    public float Value
    {
        set
        {
            valueText.text = Value,0,MaxValue;
            ;

        }
          // Use this for initialization
    void Start()
    {
       





    }

    // Update is called once per frame
    void Update () {
		
	}
}
