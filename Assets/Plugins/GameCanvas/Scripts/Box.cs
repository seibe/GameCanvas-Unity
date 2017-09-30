﻿/*------------------------------------------------------------*/
// <summary>GameCanvas for Unity</summary>
// <author>Seibe TAKAHASHI</author>
// <remarks>
// (c) 2015-2017 Smart Device Programming.
// This software is released under the MIT License.
// http://opensource.org/licenses/mit-license.php
// </remarks>
/*------------------------------------------------------------*/

namespace GameCanvas
{
    using UnityEngine;

    public struct Box : System.IEquatable<Box>
    {
        //----------------------------------------------------------
        #region フィールド変数
        //----------------------------------------------------------

        public readonly float MinX;
        public readonly float MinY;
        public readonly float MinZ;
        public readonly float MaxX;
        public readonly float MaxY;
        public readonly float MaxZ;

        #endregion

        //----------------------------------------------------------
        #region パブリック関数
        //----------------------------------------------------------

        public static bool operator ==(Box lh, Box rh)
        {
            return lh.MinX == rh.MinX && lh.MinY == rh.MinY && lh.MinZ == rh.MinZ
                && lh.MaxX == rh.MaxX && lh.MaxY == rh.MaxY && lh.MaxZ == rh.MaxZ;
        }

        public static bool operator !=(Box lh, Box rh)
        {
            return !(lh == rh);
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Box(float x1, float y1, float z1, float x2, float y2, float z2)
        {
            MinX = Mathf.Min(x1, x2);
            MinY = Mathf.Min(y1, y2);
            MinZ = Mathf.Min(z1, z2);
            MaxX = Mathf.Max(x1, x2);
            MaxY = Mathf.Max(y1, y2);
            MaxZ = Mathf.Max(z1, z2);
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Box(Vector3 p1, Vector3 p2) : this(p1.x, p1.y, p1.z, p2.x, p2.y, p2.z) { }

        /// <summary>
        /// 幅
        /// </summary>
        public float Width { get { return (MaxX - MinX); } }

        /// <summary>
        /// 高さ
        /// </summary>
        public float Height { get { return (MaxY - MinY); } }

        /// <summary>
        /// 奥行き
        /// </summary>
        public float Depth { get { return (MaxZ - MinZ); } }

        public float CenterX { get { return (MinX + MaxX) * 0.5f; } }

        public float CenterY { get { return (MinY + MaxY) * 0.5f; } }

        public float CenterZ { get { return (MinZ + MaxZ) * 0.5f; } }

        public Vector3 Min { get { return new Vector3(MinX, MinY, MinZ); } }

        public Vector3 Max { get { return new Vector3(MaxX, MaxY, MaxZ); } }

        /// <summary>
        /// 大きさ
        /// </summary>
        public Vector3 Size { get { return new Vector3(Width, Height, Depth); } }

        /// <summary>
        /// 中心
        /// </summary>
        public Vector3 Center { get { return new Vector3(CenterX, CenterY, CenterZ); } }

        public bool Equals(Box other)
        {
            return (this == other);
        }

        public override bool Equals(object obj)
        {
            return (obj is Box && this == (Box)obj);
        }

        public override int GetHashCode()
        {
            return MinX.GetHashCode() & MinY.GetHashCode() & MinZ.GetHashCode()
                & MaxX.GetHashCode() & MaxY.GetHashCode() & MaxZ.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{{x:[{0:f3}, {1:f3}], y:[{2:f3}, {3:f3}], z:[{4:f3}, {5:f3}]}}", MinX, MaxX, MinY, MaxY, MinZ, MaxZ);
        }

        #endregion
    }
}
