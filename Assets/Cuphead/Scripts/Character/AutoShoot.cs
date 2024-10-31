using UnityEngine;

public class AutoShoot : MonoBehaviour
{
    public CharacterShot shotBehavior;


    public float timeBtwShot = 1;
    private float timeBtwShotCurrent;

    private void Start()
    {
        timeBtwShotCurrent = timeBtwShot;
    }

    private void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        timeBtwShotCurrent -= Time.deltaTime;
        if (timeBtwShotCurrent <= 0) // Thời gian cooldown để bắn giữa mỗi lần
        {
            shotBehavior.Shot();
            timeBtwShotCurrent = timeBtwShot; // Reset thời gian đếm ngược để bắn
        }
    }
}