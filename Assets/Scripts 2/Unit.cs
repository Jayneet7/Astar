using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour {

    // get information about unit's loaction
	public Transform target;
	float speed = 5; // speed of the unit
	Vector3[] path; // path arry that unit will follow
	int targetIndex; // for the next node on index

    // request path from the pathrequest manage script
	void Start() {
		PathRequestManager.RequestPath(transform.position,target.position, OnPathFound);
	}

    //to cover up shot distance form one node to another node on the path
	public void OnPathFound(Vector3[] newPath, bool pathSuccessful) {
		if (pathSuccessful) {
			path = newPath;
			targetIndex = 0;
			StopCoroutine("FollowPath");
			StartCoroutine("FollowPath");
		}
	}

    //keep trak of the nodes on the path
	IEnumerator FollowPath() {
		Vector3 currentWaypoint = path[0];
		while (true) {
			if (transform.position == currentWaypoint) {
				targetIndex ++;
				if (targetIndex >= path.Length) {
					yield break;
				}
				currentWaypoint = path[targetIndex];
			}

			transform.position = Vector3.MoveTowards(transform.position,currentWaypoint,speed * Time.deltaTime);
			yield return null;

		}
	}

    // draw the gizmos to visualize the process
	public void OnDrawGizmos() {
		if (path != null) {
			for (int i = targetIndex; i < path.Length; i ++) {
				Gizmos.color = Color.black;
				Gizmos.DrawCube(path[i], Vector3.one);

				if (i == targetIndex) {
					Gizmos.DrawLine(transform.position, path[i]);
				}
				else {
					Gizmos.DrawLine(path[i-1],path[i]);
				}
			}
		}
	}
}
