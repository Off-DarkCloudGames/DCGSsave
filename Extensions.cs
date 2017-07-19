//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine;

namespace DGSave
{
	#region Extensions
	//!  DCGExtensions 
	/*!
This class implements a number of custom extension methods used by the DGSave system, but may also be used in the end user's systems as well
	*/
	public static class DCGExtensions{
		/// <summary>
		/// Removes item from Array source at index.
		/// </summary>
		/// <returns>The <see cref="``0[]"/>.</returns>
		/// <param name="source">Source - Array</param>
		/// <param name="index">Index - Int</param>
		/// <typeparam name="T">T - Type</typeparam>
		public static T[] RemoveAt<T>(this T[] source, int index)
		{
			T[] dest = new T[source.Length - 1];
			if( index > 0 )
				Array.Copy(source, 0, dest, 0, index);
			
			if( index < source.Length - 1 )
				Array.Copy(source, index + 1, dest, index, source.Length - index - 1);
			
			return dest;
		}
		/// <summary>
		/// Gets the parsed type of the type LSTypes
		/// </summary>
		/// <returns>Parsed type</returns>
		/// <param name="typeName">typeName - LSTypes</param>
		public static Type GetTypeFromSimpleName(this LSTypes typeName)
		{

			bool isArray = false, isNullable = false;
			
			string parsedTypeName = null;

			int typeid = (int)typeName;

			switch (typeid)
			{
			case 1:
				parsedTypeName = "System.Int32";
				isNullable=true;
				break;
			case 2:
				parsedTypeName = "System.Boolean";
				isNullable=true;
				break;
			case 3:
				parsedTypeName = "System.Byte";
				break;
			case 4:
				parsedTypeName = "System.Char";
				isNullable=true;
				break;
			case 5:
				parsedTypeName = "System.Double";
				isNullable=true;
				break;
			case 6:
				parsedTypeName = "System.Single";
				break;
			case 7:
				parsedTypeName = "System.Int16";
				break;
			case 8:
				parsedTypeName = "System.Int64";
				break;
			case 9:
				parsedTypeName = "System.Object";
				isNullable=true;
				break;
			case 10:
				parsedTypeName = "System.String";
				break;
			case 11:
				parsedTypeName = "System.UInt16";
				break;
			case 12:
				parsedTypeName = "System.UInt32";
				break;
			case 13:
				parsedTypeName = "System.UInt64";
				break;
			case 14:
				parsedTypeName = "UnityEngine.Vector4";
				break;
			case 15:
				parsedTypeName = "UnityEngine.Vector3";
				break;
			case 16:
				parsedTypeName = "UnityEngine.Vector2";
				break;
			case 17:
				parsedTypeName="UnityEngine.Quaternion";
				break;
			case 18:
				parsedTypeName="UnityEngine.Rect";
				break;
			}
			
			if (parsedTypeName != null)
			{
				if (isArray)
					parsedTypeName = parsedTypeName + "[]";
				
				if (isNullable)
					parsedTypeName = String.Concat("System.Nullable`1[", parsedTypeName, "]");
			}
			else
				Debug.LogError("Undefined type specified!");
			
			// Expected to throw an exception in case the type has not been recognized.
			return Type.GetType(parsedTypeName);
		}
		/// <summary>
		/// Pads byte array to a multiple of pad
		/// </summary>
		/// <returns>Byte array the size of multiple of pad</returns>
		/// <param name="src">Source - Byte Array</param>
		/// <param name="pad">Pad - Int</param>
		public static byte[] PadToMultipleOf(this byte[] src, int pad){
			int len = src.Length;
			while(len%pad!=0){
				len++;
			}
			Array.Resize(ref src, len);
			return src;
		}
		/// <summary>
		/// Converts an object from original type to type of T
		/// </summary>
		/// <returns>Supplied object as type of T</returns>
		/// <param name="input">Input - Object</param>
		/// <typeparam name="T">T - Type</typeparam>
		public static T ConvertType<T>(this object input) {
			return (T) Convert.ChangeType(input, typeof(T));
		}
	}
	#endregion
}
