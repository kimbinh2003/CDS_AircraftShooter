using UnityEngine;

public class EnemyAutoMoveToTargetPos : MonoBehaviour
{
    public Transform targetPos;
    public float speed;
    public Vector3 offset;
    private bool isReached;
    private bool canMove = false;
    public void SetPosition(Transform targetPos)
    {
        this.targetPos = targetPos;
        transform.position = targetPos.position + offset;
        canMove = true;
    }

    private void Update()
    {
        if (!canMove) return;
        if (isReached) return;
        if (Vector2.Distance(transform.position, targetPos.position) < 0.2f)
        {
            isReached = true;
            return;
        }
        transform.position = Vector3.MoveTowards(transform.position, targetPos.position, speed * Time.deltaTime);
    }
}