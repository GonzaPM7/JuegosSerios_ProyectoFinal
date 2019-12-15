using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrabinBarrabas : MonoBehaviour {

    public EnemyBullet bulletD;
    public EnemyBullet bulletB;
    EnemyBullet bullet;

    public bool bMode = true;

    public TextMesh letter;

    public int health = 3;

    public Transform player;
    public Transform shootTransform;

    Vector2 shootDirection;
    public int bulletSpeed = 1;

	// Use this for initialization
	void Start () {
        if (bMode)
        {
            letter.text = "B"; 
        }
        else
        {
            letter.text = "D"; 
        }

        InvokeRepeating("shootBullet", 2.0f, 3.0f);

    }

    // Update is called once per frame
    void Update () {
    }

    public void shootBullet()
    {
        int bulletType = Random.Range(1, 3);
        if(bulletType == 1)
            bullet = bulletB;
        else
            bullet = bulletD;

        Debug.Log("banana");
        shootDirection = player.position - gameObject.transform.position;

        EnemyBullet enemyBullet = Instantiate(bullet, shootTransform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
        enemyBullet.barrabas = this;
        enemyBullet.bMode = bMode;
        Destroy(enemyBullet, 5);
        Vector2 dir = shootDirection.normalized;

        enemyBullet.GetComponent<Rigidbody2D>().velocity = dir * bulletSpeed; //shootDirection.normalized * bulletSpeed;*/
    }

    public void loseHealth()
    {
        health--;
        if (health <= 0)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "BulletNormal" || other.gameObject.tag == "BulletB" || other.gameObject.tag == "BulletD")
        {
            Destroy(other);
        }
    }
}
