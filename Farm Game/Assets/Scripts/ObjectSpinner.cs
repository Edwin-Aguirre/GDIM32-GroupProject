using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpinner : MonoBehaviour
{
    //Written by Edwin Aguirre
    //This script spins and bobs objects;
    //Used for the Icons in game
    
    [SerializeField]
    private float spinSpeed;
    [SerializeField]
    private float bobSpeed;
    [SerializeField]
    private float bobHeight;
    
    private Vector3 bobPosition;
    private float bob_Y;

    // Start is called before the first frame update
    void Start()
    {
        bobPosition = transform.position;
        bob_Y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //Spins the powerups
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0, Space.World);
        bobPosition.y = bob_Y + bobHeight * Mathf.Sin(bobSpeed * Time.time);
        transform.position = bobPosition;
    }
}
