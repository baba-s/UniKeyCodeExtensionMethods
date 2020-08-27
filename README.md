# UniKeyCodeExtensionMethods

KeyCode 型の拡張メソッド

## 使用例

```cs
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Update()
    {
        // 通常
        if ( Input.GetKeyDown( KeyCode.Z ) )
        {
        }
        if ( Input.GetKey( KeyCode.Z ) )
        {
        }
        if ( Input.GetKeyUp( KeyCode.Z ) )
        {
        }

        // 拡張メソッド
        if ( KeyCode.Z.GetKeyDown() )
        {
        }
        if ( KeyCode.Z.GetKey() )
        {
        }
        if ( KeyCode.Z.GetKeyUp() )
        {
        }
    }
}
```
