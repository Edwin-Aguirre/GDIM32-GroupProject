using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TooltipManager : MonoBehaviour
{
    //Written by Edwin Aguirre/tutorial
    //Singleton Pattern
    //This script handles the tooltips in the game
    //Also makes sure to know when to activate the UI from showing

    public static TooltipManager instance;

    [SerializeField]
    private Text statsText;

    private void Awake() 
    {
        if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Input.mousePosition;
    }

    public void ShowToolTip(string message)
    {
        gameObject.SetActive(true);
        statsText.text = message;
    }

    public void HideToolTip()
    {
        gameObject.SetActive(false);
        statsText.text = string.Empty;
    }
}
