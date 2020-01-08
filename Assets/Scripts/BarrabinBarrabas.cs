using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BarrabinBarrabas : MonoBehaviour {

    public EnemyBullet bulletD;
    public EnemyBullet bulletB;
    EnemyBullet bullet;

    public bool bMode = true;

    public TextMesh letter;

    public int health = 3;

    public Transform player;
    public Transform shootTransform;
    public Transform barrabin;

    Vector2 shootDirection;
    public int bulletSpeed = 1;

    public PlayerHealth playerHealth;

    public SpriteRenderer sprite;

    public GameObject flecha;

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
        if (health > 0)
        {
            int bulletType = Random.Range(1, 3);
            if (bulletType == 1)
                bullet = bulletB;
            else
                bullet = bulletD;

            Debug.Log("banana");
            shootDirection = player.position - gameObject.transform.position;

            EnemyBullet enemyBullet = Instantiate(bullet, shootTransform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
            enemyBullet.barrabas = this;
            enemyBullet.bMode = bMode;
            enemyBullet.health = playerHealth;
            Destroy(enemyBullet, 5);
            Vector2 dir = shootDirection.normalized;

            enemyBullet.GetComponent<Rigidbody2D>().velocity = dir * bulletSpeed; //shootDirection.normalized * bulletSpeed;*/
        }
    }

    public void loseHealth()
    {
        health--;
        if (health <= 0)
        {
            Invoke("ChangeScene", 3);
            gameObject.SetActive(false);
        }
        if (barrabin.position.x >= 0 && health > 0)
        {
            barrabin.position = new Vector3(-2, barrabin.position.y, barrabin.position.z);
            GameObject arrow = Instantiate(flecha, player.position - new Vector3(2,0,0), Quaternion.Euler(new Vector3(0, 0, 0)));
            arrow.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            barrabin.position = new Vector3(4, barrabin.position.y, barrabin.position.z);
            GameObject arrow = Instantiate(flecha, player.position + new Vector3(2, 0, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            arrow.GetComponent<SpriteRenderer>().flipX = false;
        }

        bMode = !bMode;
        if (bMode)
        {
            letter.text = "B";
        }
        else
        {
            letter.text = "D";
        }
        gameObject.transform.localScale = new Vector3(-gameObject.transform.localScale.x, gameObject.transform.localScale.y, gameObject.transform.localScale.z);
        letter.transform.localScale = new Vector3(-letter.transform.localScale.x, letter.transform.localScale.y, letter.transform.localScale.z);
        letter.transform.position += new Vector3(-0.1f, 0, 0);


    }

    public void ChangeScene()
    {
        Debug.Log("cambioEscena");
        SceneManager.LoadScene("Victoria");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "BulletNormal" || other.gameObject.tag == "BulletB" || other.gameObject.tag == "BulletD")
        {
            Destroy(other);
        }
    }
}
