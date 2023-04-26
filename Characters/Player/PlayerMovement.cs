using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
	[SerializeField] private float speed = 1.5f;

	[SerializeField] private float sensitivity = 3f; // чувствительность мыши
	[SerializeField] private float headMinY = -40f; // ограничение угла для головы
	[SerializeField] private float headMaxY = 40f;

	[SerializeField] private KeyCode jumpButton = KeyCode.Space; // клавиша для прыжка
	[SerializeField] private float jumpForce = 10; // сила прыжка
	[SerializeField] private float jumpDistance = 1.2f; // расстояние от центра объекта, до поверхности

	[SerializeField] private Vector3 direction;
	private float horizontalMove, verticalMove;
	[SerializeField] private LayerMask targetJumpMask;
	[SerializeField] private Rigidbody bodyRb;

	[SerializeField] private Animator animator;

	private void FixedUpdate()
	{
		Vector3 movement = new Vector3(horizontalMove, 0f, verticalMove);

		animator.SetFloat("SpeedMove", movement.magnitude);
		Debug.Log("movement speed: " + movement.magnitude);
		animator.SetFloat("VerticalSpeed", verticalMove);
		animator.SetFloat("HorizontalSpeed", horizontalMove);

		if (movement == Vector3.zero)
			return;

		bodyRb.MovePosition(bodyRb.position + movement * speed * Time.fixedDeltaTime);

		RotateToDirectionMove(movement);
	}

	private bool GetJump() // проверяем, есть ли коллайдер под ногами
	{
		RaycastHit hit;
		Ray ray = new Ray(transform.position, Vector3.down);
		if (Physics.Raycast(ray, out hit, jumpDistance, targetJumpMask))
		{
			return true;
		}

		return false;
	}

	private void Update()
	{
		if (StaticVariables.statusGame == StatusGame.pause)
			return;

		horizontalMove = Input.GetAxis("Horizontal");
		verticalMove = Input.GetAxis("Vertical");

		if (Input.GetKeyDown(jumpButton) && GetJump())
		{
			bodyRb.velocity = new Vector2(0, jumpForce);
		}
	}

	private void RotateToDirectionMove(Vector3 directionMove)
    {
		if (directionMove == Vector3.zero)
			return;
		Quaternion toRotation = Quaternion.LookRotation(directionMove, Vector3.up);
		transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, speed * Time.fixedDeltaTime);
    }

	private void OnDrawGizmosSelected() // подсветка, для визуальной настройки jumpDistance
	{
		Gizmos.color = Color.red;
		Gizmos.DrawRay(transform.position, Vector3.down * jumpDistance);
	}
}

