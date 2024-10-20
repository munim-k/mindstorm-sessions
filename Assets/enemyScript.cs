using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public int moveDistance = 2;
    public int health = 100;
    public int moveSpeed = 2;
    public int damage = 10;
    private bool direction = true;
    
    private void Start()
    {
        StartCoroutine(Move());
    }

    private IEnumerator Move()
    {
        while (true)
        {
            if (direction)
            {
                transform.Translate(Vector3.right * moveDistance);
                direction = false;
            }
            else
            {
                transform.Translate(Vector3.left * moveDistance);
                direction = true;
            }

            yield return new WaitForSeconds(1);
        }
    }
}
