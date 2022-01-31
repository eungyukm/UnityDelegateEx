using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnEnable()
    {
        if(Player.Instance != null)
        {
            Player.Instance.onEnemyHit += Damage;
        }
    }

    private void OnDisable()
    {
        if(Player.Instance != null)
        {
            Player.Instance.onEnemyHit -= Damage;
        }
    }

    private void Damage(Color color)
    {
        transform.GetComponent<Renderer>().material.color = color;
    }
}
