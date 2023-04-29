using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int HP = 100;

    public void GetDamage()
    {
        HP -= 50;
        if (HP <= 0)
            Destroy(gameObject);
    }
}

