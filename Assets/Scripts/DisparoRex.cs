using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisparoRex : MonoBehaviour
{

    public GameObject letterB;
    public GameObject letterD;
    public GameObject normalBullet;
    public Text selectedText;

    public float bulletDelay = 0.5f;
	public Transform SpawnBala;

    public float bulletReach = 2;

    public float bulletSpeed = 10;

    public bool b_active = true;
    Vector3 shootDirection;
    bool canShoot;

    void Start()
    {
        canShoot = true;
        updateText();
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0) && canShoot)
        {
            Debug.Log("dispara");
            DisparoNormal();
            Invoke("NewBullet", bulletDelay);
            //SoundManager.instance.PlaySound(rifleSound, 0.25f);
        }

        if (Input.GetMouseButtonUp(1) && canShoot)
        {
            DisparoLetra();
            Invoke("NewBullet", bulletDelay);
            //SoundManager.instance.PlaySound(shotgunSound, 0.25f);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            b_active = !b_active;
            updateText();
        }
    }

    void DisparoNormal()
    {
        Debug.Log("Nomal");
        shootDirection = Input.mousePosition;
        shootDirection = Camera.main.ScreenToWorldPoint(shootDirection);
        shootDirection.z = 0.0f;
        shootDirection = shootDirection - transform.position;

		GameObject bullet = Instantiate(normalBullet, SpawnBala.position, Quaternion.Euler(new Vector3(0, 0, 0)));
        Vector2 dir = shootDirection.normalized;

        bullet.GetComponent<Rigidbody2D>().velocity = dir * bulletSpeed; //shootDirection.normalized * bulletSpeed;
        Destroy(bullet, bulletReach);
        canShoot = false;
    }

    void DisparoLetra()
    {
        shootDirection = Input.mousePosition;
        shootDirection = Camera.main.ScreenToWorldPoint(shootDirection);
        shootDirection.z = 0.0f;
        shootDirection = shootDirection - transform.position;

        GameObject bullet;
        if (b_active)
        {
            bullet = Instantiate(letterB, SpawnBala.position, Quaternion.Euler(new Vector3(0, 0, 0)));
        }
        else
        {
            bullet = Instantiate(letterD, SpawnBala.position, Quaternion.Euler(new Vector3(0, 0, 0)));
        }
        Vector2 dir = shootDirection.normalized;

        bullet.GetComponent<Rigidbody2D>().velocity = dir * bulletSpeed; //shootDirection.normalized * bulletSpeed;
        Destroy(bullet, bulletReach);
        canShoot = false;
    }

    private void NewBullet()
    {
        canShoot = true;
    }

    private void updateText()
    {
        selectedText.text = (b_active ? "B" : "D");
    }
}
