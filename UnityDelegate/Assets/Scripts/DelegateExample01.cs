using UnityEngine;

public class DelegateExample01 : MonoBehaviour
{
    private delegate int IntDelegate(int a, int b);
    IntDelegate addDelegate;
    IntDelegate subDelegate;

    private int Add(int a, int b)
    {
        return a + b;
    }

    private int Sub(int a, int b)
    {
        return a - b;
    }

    void Start()
    {
        addDelegate = new IntDelegate(Add);
        int sum = addDelegate(3, 5);
        Debug.Log("sum : " + sum);

        subDelegate = new IntDelegate(Sub);
        int sub = subDelegate(5, 3);
        Debug.Log("sub : " + sub);
    }
}
