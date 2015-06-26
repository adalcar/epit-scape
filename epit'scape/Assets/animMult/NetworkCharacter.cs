using UnityEngine;
using System.Collections;

public class NetworkCharacter : Photon.MonoBehaviour {

	Vector3 currentPosition = Vector3.zero;
	Quaternion currentRotation = Quaternion.identity;

	Animator anim;


	void Start () {
		anim = GetComponent<Animator>();
		if(anim == null) {
			Debug.LogError ("prefab!");
		}
	}
	

	void Update () {
		if( photonView.isMine ) {
		}
		else {
			transform.position = Vector3.Lerp(transform.position, currentPosition, 0.1f);
			transform.rotation = Quaternion.Lerp(transform.rotation, currentRotation, 0.1f);
		}
	}

	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) {
		if(stream.isWriting) {
			stream.SendNext(transform.position);
			stream.SendNext(transform.rotation);
			stream.SendNext(anim.GetFloat("Speed"));
		}
		else {
			currentPosition = (Vector3)stream.ReceiveNext();
			currentRotation = (Quaternion)stream.ReceiveNext();
			anim.SetFloat("Speed", (float)stream.ReceiveNext());
		}

	}
}
