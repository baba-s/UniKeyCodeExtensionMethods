using UnityEngine;

namespace Kogane
{
	public static class KeyCodeExt
	{
		public static bool GetKey( this KeyCode self )
		{
			return Input.GetKey( self );
		}

		public static bool GetKeyDown( this KeyCode self )
		{
			return Input.GetKeyDown( self );
		}

		public static bool GetKeyUp( this KeyCode self )
		{
			return Input.GetKeyUp( self );
		}
	}
}