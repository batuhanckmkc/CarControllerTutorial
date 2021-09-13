using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public GameHandler GH;
    public AudioClip coinSound;
   
    void Start()
    {
        GH = GameObject.Find("Canvas").GetComponent<GameHandler>();
    }

    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        GH.coins++;
        Destroy(gameObject);
        AudioSource.PlayClipAtPoint(coinSound, transform.position, 0.5f);
    }
}
