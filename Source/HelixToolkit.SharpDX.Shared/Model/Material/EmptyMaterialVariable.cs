﻿/*
The MIT License (MIT)
Copyright (c) 2018 Helix Toolkit contributors
*/
#if !NETFX_CORE
namespace HelixToolkit.Wpf.SharpDX.Model
#else
namespace HelixToolkit.UWP.Model
#endif
{
    using Core;
    using Render;
    using Shaders;
    public sealed class EmptyMaterialVariable : MaterialVariableBase<bool>
    {
        public static readonly EmptyMaterialVariable EmptyVariable = new EmptyMaterialVariable();

        public ShaderPass MaterialPass => ShaderPass.NullPass;

        public bool RenderDiffuseMap { set; get; }
        public bool RenderDiffuseAlphaMap { set; get; }
        public bool RenderNormalMap { set; get; }
        public bool RenderDisplacementMap { set; get; }
        public override bool RenderShadowMap { set; get; }
        public override bool RenderEnvironmentMap { set; get; }
        public override string DefaultShaderPassName { set; get; }

        public EmptyMaterialVariable() : base(null)
        {

        }

        protected override bool CanUpdateMaterial()
        {
            return false;
        }

        protected override bool OnBindMaterialTextures(DeviceContextProxy context, ShaderPass shaderPass)
        {
            return false;
        }

        public override ShaderPass GetPass(MaterialGeometryRenderCore core, RenderContext context)
        {
            return MaterialPass;
        }

        protected override void AssignVariables()
        {
        }
    }
}
