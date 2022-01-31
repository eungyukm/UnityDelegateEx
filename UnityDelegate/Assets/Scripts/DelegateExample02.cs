using UnityEngine;

public class DelegateExample02 : MonoBehaviour
{
    delegate void MultiDelegate();
    MultiDelegate multiDelegate;


    // Start is called before the first frame update
    void Start()
    {
        multiDelegate += DebugLogPrint;
        multiDelegate += TurnRed;

        if(multiDelegate != null)
        {
            multiDelegate();
        }

        multiDelegate -= DebugLogPrint;
        multiDelegate -= TurnRed;
    }

    private void DebugLogPrint()
    {
        Debug.Log("DebugLogPrint!!");
    }

    private void TurnRed()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
