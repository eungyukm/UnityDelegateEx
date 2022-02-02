using UnityEngine;

public class DelegateExample05 : MonoBehaviour
{
    delegate void Del();
    // Start is called before the first frame update
    void Start()
    {
        Handler(Hellow);
    }

    private void Handler(Del callback)
    {
        callback();
    }

    private void Hellow()
    {
        Debug.Log("Hello!!");
    }
}
