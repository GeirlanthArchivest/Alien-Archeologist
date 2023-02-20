using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public string myStartMessage;
    public string updateMessage;
    public string message1;
    public string message2;
    public string message3;
    public int messageChoice;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(myStartMessage);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(updateMessage);

        if (messageChoice == 1)
        {
            Debug.Log(message1);
        }
        else if (messageChoice == 2)
        {
            Debug.Log(message2);
        }
        else if (messageChoice == 3)
        {
            Debug.Log(message3);
        }
        else
        {
            Debug.Log("Invalid Message Choice");
        }
    }
}
