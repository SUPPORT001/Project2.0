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
            transform.position += Vector3.right * (GetComponent<Crip>().speed * 0.2f) * Time.deltaTime;
        }
        else
        {
            transform.position += Vector3.left * (GetComponent<Crip>().speed * 0.2f) * Time.deltaTime;
        }
    }
}
