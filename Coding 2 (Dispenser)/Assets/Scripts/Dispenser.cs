using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispenser : MonoBehaviour
{
    public GameObject[] inventoryItems;      // List of items that are in the dispenser
    public Transform dispensePosition;  // Position where the items were come out

    public AudioClip audioClip;
    public AudioSource audioSource;

    public bool hasInsertedCoin = false;

    /// <summary>
    /// Use this method to dispense the item.
    /// </summary>
    /// <param name="itemNumber">ID of the item in the </param>
    public void Dispense(int itemNumber)
    {
        if (hasInsertedCoin == true)
        {
            audioSource.PlayOneShot(audioClip, 1);

            // Dispense an object here using the Instantiate<> function
            //Dispense an object here  Instantiate<GameObject>  urgeljluul
            GameObject newGameObject = Instantiate<GameObject>(inventoryItems[itemNumber]);

            newGameObject.transform.position = dispensePosition.position;

            //Debug.Log("Thilo raises hand" + item ); for testing
            hasInsertedCoin = false;
        }
    }

    public void InsertCoin(int value)
    {
        hasInsertedCoin = true;
    }
}
