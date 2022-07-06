using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CripController : MonoBehaviourPunCallbacks, IPunObservable
{
    private PhotonView photonView;
    private SpriteRenderer spriteRenderer;
    private GameObject enemy;
    private string tagCrip;
 


    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) 
    {
        
    }

    private void Start()
    {
        
        photonView = GetComponent<PhotonView>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (this.tag == "BlueCrip")
        {
            tagCrip = "BlueCrip";
        }
        else tagCrip = "RedCrip";
    }

    private void Update()
    {
        if (!photonView.IsMine) return;

        if (Config.indexPlayer == 0)
        {
            transform.position += Vector3.right * (GetComponent<Crip>().speed * 0.2f) * Time.deltaTime;
        }
        else
        {
            transform.position += Vector3.left * (GetComponent<Crip>().speed * 0.2f) * Time.deltaTime;
        }

        switch (this.GetComponent<Crip>().typeAttack)
        {
            
        }
        Debug.Log(this.GetComponent<Crip>().typeAttack);
    }

    private void Melee()
    {

    }
    private void Archer()
    {

    }
    private void Magik()
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag != tagCrip) enemy = collision.gameObject;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
