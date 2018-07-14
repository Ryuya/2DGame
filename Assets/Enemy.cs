using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	GameObject player;
	public GameObject bullet;

	public float bulletSpeed = 1.0f;

	public float time;
	public float span = 3.0f;

	// Use this for initialization
	void Start ()
	{
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (time < span) {
			time += Time.deltaTime;
		} else {
			time = 0f;
			Shot ();
		}
	}

	public void Shot ()
	{
		GameObject bullet = GameObject.Instantiate (Resources.Load ("Prefabs/Bullet") as GameObject);
		bullet.transform.position = transform.position;
		//ターゲットの方向に弾を回転させる
		//座標(1,0)がプレイヤーに向くように回転させる（つまりX軸をプレイヤーに向かせる）
		//ちなみに、Y軸が(0,1)の時、進むべき方向だという思想の場合はVector3.upを使用する。
		bullet.transform.LookAt2D (player.transform, Vector2.right);

		bullet.GetComponent<Rigidbody2D> ().velocity = bullet.transform.right * bulletSpeed;
	}
}
