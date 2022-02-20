using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    //counter for collectables in the screen
    public int counter;
    //the prefacb that will be instantiated
    public GameObject bonusObject;


    // Start is called before the first frame update
    void Start()
    {
        counter = GameObject.FindGameObjectsWithTag("Pick Up").Length;
        Debug.Log("Pick Up.Length" + counter);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pickup()
    {
        counter--;

        if (counter == 0)
            SpawnerBonus();

        Debug.Log("Message has been received - counter: "+ counter);
    }

    void SpawnerBonus()
    {
        Debug.Log("SpawnerBonus() bonusObject: "+ bonusObject.name);
        Instantiate(bonusObject, transform);
    }
}
