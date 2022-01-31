using UnityEngine;

public class Player : MonoBehaviour
{
    #region Singleton
    private static Player _instance;
    public static Player Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType(typeof(Player)) as Player;
            }
            return _instance;
        }
    }
    #endregion

    public delegate void ChangeEnemyColor(Color color);
    public event ChangeEnemyColor onEnemyHit;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(onEnemyHit != null)
            {
                onEnemyHit(Color.red);
            }
        }
    }
}
