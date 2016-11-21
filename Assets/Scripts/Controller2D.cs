using UnityEngine;
using System.Collections;

[RequireComponent (typeof (BoxCollider2D))]
public class Controller2D : MonoBehaviour {

	public int horizontalRayCount = 4;
	public int verticalRayCount = 4;
	const float skinWidth = .015f;

	BoxCollider2D collider;
	RaycastOrigins raycastOrigins;

	void Start(){
		collider = GetComponent<BoxCollider2D> ();
	}

	void UpdateRaycastOrigins(){
		Bounds bounds = collider.bounds;
		bounds.Expand (skinWidth * -2);

		raycastOrigins.bottomLeft = new Vector2(bounds.min.x, bounds.min.y);
		raycastOrigins.bottomLeft = new Vector2(bounds.max.x, bounds.min.y);
		raycastOrigins.bottomLeft = new Vector2(bounds.min.x, bounds.max.y);
		raycastOrigins.bottomLeft = new Vector2(bounds.max.x, bounds.max.y);

	}

	struct RaycastOrigins {
		public Vector2 topLeft, topRight;
		public Vector2 bottomLeft, bottomRight;
	}

}
