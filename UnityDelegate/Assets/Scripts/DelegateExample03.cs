using UnityEngine;

public class DelegateExample03 : MonoBehaviour
{
    public delegate void OnMessageReceived();

    // Start is called before the first frame update
    void Start()
    {
        OnMessageReceived onMessageReceived = WriteMessage;
        onMessageReceived();
    }

    void WriteMessage()
    {
        Debug.Log("WriteMessage() Called!!");
    }
}
