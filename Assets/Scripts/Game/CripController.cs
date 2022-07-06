using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CripController : MonoBehaviourPunCallbacks, IPunObservable
{
    private PhotonView photonView;
    private SpriteRenderer spriteRenderer;

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        throw new System.NotImplementedException();
    }

    private void Start()
    {
        photonView = GetComponent<PhotonView>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (!photonView.IsMine) return;

        if (Config.indexPlayer == 0)
        {
            transform.position += Vector3.right * 3f * Time.deltaTime;
        }
        else
        {
            transform.position += Vector3.left * 3f * Time.deltaTime;
        }
    }

    private void fight()
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
