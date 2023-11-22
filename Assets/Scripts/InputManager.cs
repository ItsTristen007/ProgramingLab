using UnityEngine;

public static class InputManager
{
    private static Controls _ctrls;

    private static Vector3 _mousePos;

    private  static Camera cam;
    public static Ray GetCameraRay()
    {
        return cam.ScreenPointToRay(_mousePos);
    }

    public static void Init(Player p)
    {
        _ctrls = new();
        
        cam = Camera.main;
        
        _ctrls.Permenanet.Enable();

        _ctrls.InGame.Shoot.performed += _ =>
        {
            p.Shoot();
        };
        _ctrls.Permenanet.MousePos.performed += ctx =>
        {
            _mousePos = ctx.ReadValue<Vector2>();
        };
        _ctrls.InGame.Reload.performed += ctx =>
        {
            p.Reload();
        };
        _ctrls.InGame.Weapon1.performed += ctx =>
        {
            p.Weapon1();
        };
        _ctrls.InGame.Weapon2.performed += ctx =>
        {
            p.Weapon2();
        };
        _ctrls.InGame.Weapon3.performed += ctx =>
        {
            p.Weapon3();
        };
        _ctrls.InGame.Weapon4.performed += ctx =>
        {
            p.Weapon4();
        };
    }

    public static void EnableInGame()
    {
        _ctrls.InGame.Enable();
    }
}
