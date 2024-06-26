using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project002;

namespace TopDownShooter._Managers
{
    public class Button : GameObject
{
    private Action _callback;

    public Button(Texture2D image, Action callback) : base (image)
    {
        _callback = callback;
    }

    public override void Update(float deltaTime)
    {
        MouseState mouseState = Mouse.GetState();
        if (mouseState.LeftButton == ButtonState.Pressed)
        {
            if (_bounds.Contains(mouseState.Position))
            {
                _callback.Invoke();
            }
        }
    }
}
}