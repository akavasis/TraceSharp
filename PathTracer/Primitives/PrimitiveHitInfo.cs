﻿using PathTracer.Math;
using PathTracer.Rendering;
using System.DoubleNumerics;

namespace PathTracer.Primitives
{
    class PrimitiveHitInfo
    {
        /// <summary>
        /// Did the ray hit a surface?
        /// If this is false, the entire hit information structure should be discarded
        /// </summary>
        public bool DidHit;

        /// <summary>
        /// Distance to the hit
        /// </summary>
        public double Distance;

        /// <summary>
        /// Surface normal
        /// </summary>
        public Vector3 Normal;

        /// <summary>
        /// Material of the primitive
        /// </summary>
        public Material SurfaceMaterial;

        /// <summary>
        /// Create new intersection information that defaults to no intersection at all
        /// </summary>
        public PrimitiveHitInfo()
        {
            DidHit      = false;
            Distance    = 0.0d;
            Normal      = Vector3.Zero;
        }
    }
}
