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
    public string[] messages;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(myStartMessage);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(updateMessage);

         /*if (messageChoice <= messages.Length && messageChoice >=1)
         {
             Debug.Log(messages[messageChoice - 1]);
         }
         else
         {
             Debug.Log("Invalid Message Choice");
         }*/
        for (int i = 0; i < messages.Length; ++i)
        {
            Debug.Log(messages[i]);
        }


        /*if (messageChoice == 1)
        {
            Debug.Log(messages[0]);
        }
        else if (messageChoice == 2)
        {
            Debug.Log(messages[1]);
        }
        else if (messageChoice == 3)
        {
            Debug.Log(messages[2]);
        }
        else
        {
            Debug.Log("Invalid Message Choice");
        }*/

    }
}
