// XenFX
// Assembly = Xen.Graphics.ShaderSystem.CustomTool, Version=7.0.1.1, Culture=neutral, PublicKeyToken=e706afd07878dfca
// SourceFile = Simple.fx
// Namespace = Xen.Ex.Shaders

namespace Xen.Ex.Shaders
{
	
	/// <summary><para>Technique 'FillVertexColour' generated from file 'Simple.fx'</para><para>Vertex Shader: approximately 5 instruction slots used, 4 registers</para><para>Pixel Shader: approximately 1 instruction slot used, 0 registers</para></summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("Xen.Graphics.ShaderSystem.CustomTool.dll", "e03e5007-ea04-4dcc-8690-d7e2837ab13f")]
	public sealed class FillVertexColour : Xen.Graphics.ShaderSystem.BaseShader
	{
		/// <summary>Construct an instance of the 'FillVertexColour' shader</summary>
		public FillVertexColour()
		{
			this.sc0 = -1;
			this.sc1 = -1;
			this.sc2 = -1;
		}
		/// <summary>Setup shader static values</summary><param name="state"/>
		private void gdInit(Xen.Graphics.ShaderSystem.ShaderSystemBase state)
		{
			// set the graphics ID
			FillVertexColour.gd = state.DeviceUniqueIndex;
			this.GraphicsID = state.DeviceUniqueIndex;
		}
		/// <summary>Bind the shader, 'ic' indicates the shader instance has changed and 'ec' indicates the extension has changed.</summary><param name="state"/><param name="ic"/><param name="ec"/><param name="ext"/>
		protected override void BeginImpl(Xen.Graphics.ShaderSystem.ShaderSystemBase state, bool ic, bool ec, Xen.Graphics.ShaderSystem.ShaderExtension ext)
		{
			// if the device changed, call Warm()
			if ((state.DeviceUniqueIndex != FillVertexColour.gd))
			{
				this.WarmShader(state);
				ic = true;
			}
			// Force updating if the instance has changed
			this.vreg_change = (this.vreg_change | ic);
			this.vbreg_change = (this.vbreg_change | ic);
			this.vireg_change = (this.vireg_change | ic);
			// Set the value for attribute 'worldViewProj'
			this.vreg_change = (this.vreg_change | state.SetWorldViewProjectionMatrix(ref this.vreg[0], ref this.vreg[1], ref this.vreg[2], ref this.vreg[3], ref this.sc0));
			if ((this.vreg_change == true))
			{
				FillVertexColour.fx.vs_c.SetValue(this.vreg);
				this.vreg_change = false;
				ic = true;
			}
			if ((ext == Xen.Graphics.ShaderSystem.ShaderExtension.Blending))
			{
				ic = (ic | state.SetBlendMatricesDirect(FillVertexColour.fx.vsb_c, ref this.sc1));
			}
			if ((ext == Xen.Graphics.ShaderSystem.ShaderExtension.Instancing))
			{
				this.vireg_change = (this.vireg_change | state.SetViewProjectionMatrix(ref this.vireg[0], ref this.vireg[1], ref this.vireg[2], ref this.vireg[3], ref this.sc2));
				if ((this.vireg_change == true))
				{
					FillVertexColour.fx.vsi_c.SetValue(this.vireg);
					this.vireg_change = false;
					ic = true;
				}
			}
			// Finally, bind the effect
			if ((ic | ec))
			{
				state.SetEffect(this, ref FillVertexColour.fx, ext);
			}
		}
		/// <summary>Warm (Preload) the shader</summary><param name="state"/>
		protected override void WarmShader(Xen.Graphics.ShaderSystem.ShaderSystemBase state)
		{
			// Shader is already warmed
			if ((FillVertexColour.gd == state.DeviceUniqueIndex))
			{
				return;
			}
			// Setup the shader
			if ((FillVertexColour.gd != state.DeviceUniqueIndex))
			{
				this.gdInit(state);
			}
			FillVertexColour.fx.Dispose();
			// Create the effect instance
			state.CreateEffect(out FillVertexColour.fx, FillVertexColour.fxb, 7, 2);
		}
		/// <summary>True if a shader constant has changed since the last Bind()</summary>
		protected override bool Changed()
		{
			return this.vreg_change;
		}
		/// <summary>Returns the number of vertex inputs used by this shader</summary>
		protected override int GetVertexInputCountImpl()
		{
			return 2;
		}
		/// <summary>Returns a vertex input used by this shader</summary><param name="i"/><param name="usage"/><param name="index"/>
		protected override void GetVertexInputImpl(int i, out Microsoft.Xna.Framework.Graphics.VertexElementUsage usage, out int index)
		{
			usage = ((Microsoft.Xna.Framework.Graphics.VertexElementUsage)(FillVertexColour.vin[i]));
			index = FillVertexColour.vin[(i + 2)];
		}
		/// <summary>Static graphics ID</summary>
		private static int gd;
		/// <summary>Static effect container instance</summary>
		private static Xen.Graphics.ShaderSystem.ShaderEffect fx;
		/// <summary/>
		private bool vreg_change;
		/// <summary/>
		private bool vbreg_change;
		/// <summary/>
		private bool vireg_change;
		/// <summary>Return the supported modes for this shader</summary><param name="blendingSupport"/><param name="instancingSupport"/>
		protected override void GetExtensionSupportImpl(out bool blendingSupport, out bool instancingSupport)
		{
			blendingSupport = true;
			instancingSupport = true;
		}
		/// <summary>Change ID for Semantic bound attribute 'worldViewProj'</summary>
		private int sc0;
		/// <summary>Change ID for Semantic bound attribute '__BLENDMATRICES__GENMATRIX'</summary>
		private int sc1;
		/// <summary>Change ID for Semantic bound attribute '__VIEWPROJECTION__GENMATRIX'</summary>
		private int sc2;
		/// <summary>array storing vertex usages, and element indices</summary>
readonly 
		private static int[] vin = new int[] {0,1,0,0};
		/// <summary>Vertex shader register storage</summary>
readonly 
		private Microsoft.Xna.Framework.Vector4[] vreg = new Microsoft.Xna.Framework.Vector4[4];
		/// <summary>Instancing shader register storage</summary>
readonly 
		private Microsoft.Xna.Framework.Vector4[] vireg = new Microsoft.Xna.Framework.Vector4[4];
#if XBOX360
		/// <summary>Static RLE compressed shader byte code (Xbox360)</summary>
		private static byte[] fxb
		{
			get
			{
				return new byte[] {4,188,240,11,207,131,0,1,32,152,0,8,254,255,9,1,0,0,15,60,135,0,1,3,131,0,1,1,131,0,1,96,135,0,1,4,131,0,1,4,131,0,1,1,195,0,6,6,95,118,115,95,99,134,0,1,3,131,0,5,1,0,0,14,8,135,0,1,216,131,0,1,4,131,0,1,1,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,153,0,0,1,7,1,95,1,118,1,115,1,98,1,95,1,99,133,0,0,1,3,131,0,0,1,1,1,0,1,0,1,14,1,112,135,0,0,1,4,131,0,0,1,4,131,0,0,1,1,195,0,0,1,7,1,95,1,118,1,115,1,105,1,95,1,99,133,0,0,1,1,131,0,0,1,16,131,0,0,1,4,143,0,0,1,2,131,0,0,1,15,131,0,0,1,4,147,0,0,1,3,131,0,0,1,16,131,0,0,1,4,143,0,0,1,4,131,0,0,1,15,131,0,0,1,4,143,0,0,1,9,1,66,1,108,1,101,1,110,1,100,1,105,1,110,1,103,135,0,0,1,5,131,0,0,1,16,131,0,0,1,4,143,0,0,1,6,131,0,0,1,15,131,0,0,1,4,143,0,0,1,11,1,73,1,110,1,115,1,116,1,97,1,110,1,99,1,105,1,110,1,103,133,0,0,1,7,1,83,1,104,1,97,1,100,1,101,1,114,133,0,0,1,3,131,0,0,1,1,131,0,0,1,9,131,0,0,1,7,131,0,0,1,4,131,0,0,1,32,139,0,0,1,108,131,0,0,1,136,138,0,0,1,14,1,20,1,0,1,0,1,14,1,48,138,0,0,1,15,1,48,135,0,0,1,3,1,0,1,0,1,14,1,172,135,0,0,1,2,131,0,0,1,92,134,0,0,1,14,1,128,1,0,1,0,1,14,1,124,131,0,0,1,93,134,0,0,1,14,1,152,1,0,1,0,1,14,1,148,1,0,1,0,1,14,1,224,135,0,0,1,2,131,0,0,1,92,134,0,0,1,14,1,180,1,0,1,0,1,14,1,176,131,0,0,1,93,134,0,0,1,14,1,204,1,0,1,0,1,14,1,200,1,0,1,0,1,15,1,32,135,0,0,1,2,131,0,0,1,92,134,0,0,1,14,1,244,1,0,1,0,1,14,1,240,131,0,0,1,93,134,0,0,1,15,1,12,1,0,1,0,1,15,1,8,135,0,0,1,6,135,0,0,1,2,132,255,0,131,0,0,1,1,135,0,0,1,160,1,16,1,42,1,17,132,0,0,1,124,131,0,0,1,36,135,0,0,1,36,135,0,0,1,88,139,0,0,1,48,131,0,0,1,28,131,0,0,1,35,1,255,1,255,1,3,144,0,0,1,28,1,112,1,115,1,95,1,51,1,95,1,48,1,0,1,50,1,46,1,48,1,46,1,49,1,49,1,54,1,50,1,54,1,46,1,48,1,0,1,171,135,0,0,1,36,1,16,141,0,0,1,16,1,33,131,0,0,1,1,131,0,0,1,1,1,0,1,0,1,240,1,160,132,0,0,1,16,1,1,1,196,1,0,1,34,131,0,0,1,200,1,15,1,128,133,0,0,1,226,150,0,0,1,2,132,255,0,138,0,0,1,1,1,240,1,16,1,42,1,17,1,1,1,0,1,0,1,1,1,12,131,0,0,1,228,135,0,0,1,36,135,0,0,1,196,139,0,0,1,156,131,0,0,1,28,131,0,0,1,143,1,255,1,254,1,3,132,0,0,1,1,131,0,0,1,28,135,0,0,1,136,131,0,0,1,48,1,0,1,2,1,0,1,4,1,0,1,4,133,0,0,1,56,131,0,0,1,72,1,95,1,118,1,115,1,105,1,95,1,99,1,0,1,171,1,0,1,1,1,0,1,3,1,0,1,1,1,0,1,4,1,0,1,4,198,0,0,1,118,1,115,1,95,1,51,1,95,1,48,1,0,1,50,1,46,1,48,1,46,1,49,1,49,1,54,1,50,1,54,1,46,1,48,1,0,1,171,135,0,0,1,228,1,0,1,1,1,0,1,5,138,0,0,1,16,1,33,131,0,0,1,1,131,0,0,1,6,131,0,0,1,1,1,0,1,0,1,2,1,144,1,0,1,16,1,0,1,3,1,0,1,0,1,160,1,4,1,0,1,12,1,0,1,5,1,0,1,13,1,0,1,6,1,0,1,14,1,0,1,7,1,0,1,63,1,0,1,8,1,0,1,0,1,240,1,160,1,0,1,0,1,16,1,17,1,245,1,85,1,96,1,3,1,0,1,0,1,18,1,3,1,194,133,0,0,1,96,1,9,1,32,1,15,1,18,1,0,1,18,135,0,0,1,16,1,17,1,196,1,0,1,34,131,0,0,1,5,1,248,1,48,131,0,0,1,6,1,136,132,0,0,1,5,1,248,1,16,131,0,0,1,6,1,136,132,0,0,1,5,1,248,1,32,131,0,0,1,6,1,136,132,0,0,1,5,1,248,1,64,131,0,0,1,6,1,136,132,0,0,1,5,1,248,1,80,131,0,0,1,6,1,136,132,0,0,1,5,1,248,132,0,0,1,6,1,136,132,0,0,1,200,1,15,131,0,0,1,27,1,0,1,0,1,225,1,3,1,0,1,0,1,200,1,15,131,0,0,1,198,1,0,1,0,1,235,1,3,1,5,1,0,1,200,1,15,131,0,0,1,177,1,148,1,148,1,235,1,3,1,4,1,0,1,200,1,15,131,0,0,1,108,1,248,1,148,1,235,1,3,1,2,1,0,1,200,1,1,1,128,1,62,1,0,1,233,1,167,1,0,1,175,1,0,1,4,1,0,1,200,1,2,1,128,1,62,1,0,1,233,1,167,1,0,1,175,1,0,1,5,1,0,1,200,1,4,1,128,1,62,1,0,1,233,1,167,1,0,1,175,1,0,1,6,1,0,1,200,1,8,1,128,1,62,1,0,1,233,1,167,1,0,1,175,1,0,1,7,1,0,1,200,1,15,1,128,133,0,0,1,226,1,1,1,1,148,0,0,1,1,132,255,0,131,0,0,1,1,135,0,0,1,160,1,16,1,42,1,17,132,0,0,1,124,131,0,0,1,36,135,0,0,1,36,135,0,0,1,88,139,0,0,1,48,131,0,0,1,28,131,0,0,1,35,1,255,1,255,1,3,144,0,0,1,28,1,112,1,115,1,95,1,51,1,95,1,48,1,0,1,50,1,46,1,48,1,46,1,49,1,49,1,54,1,50,1,54,1,46,1,48,1,0,1,171,135,0,0,1,36,1,16,141,0,0,1,16,1,33,131,0,0,1,1,131,0,0,1,1,1,0,1,0,1,240,1,160,132,0,0,1,16,1,1,1,196,1,0,1,34,131,0,0,1,200,1,15,1,128,133,0,0,1,226,150,0,0,1,1,132,255,0,138,0,0,1,16,1,200,1,16,1,42,1,17,1,1,1,0,1,0,1,14,1,216,1,0,1,0,1,1,1,240,135,0,0,1,36,1,0,1,0,1,14,1,112,1,0,1,0,1,14,1,152,138,0,0,1,14,1,72,131,0,0,1,28,1,0,1,0,1,14,1,59,1,255,1,254,1,3,132,0,0,1,2,131,0,0,1,28,134,0,0,1,14,1,52,131,0,0,1,68,1,0,1,2,131,0,0,1,4,133,0,0,1,76,131,0,0,1,92,131,0,0,1,156,1,0,1,2,1,0,1,4,1,0,1,216,133,0,0,1,164,131,0,0,1,180,1,95,1,118,1,115,1,95,1,99,1,0,1,171,1,171,1,0,1,1,1,0,1,3,1,0,1,1,1,0,1,4,1,0,1,4,198,0,0,1,95,1,118,1,115,1,98,1,95,1,99,1,0,1,171,1,0,1,1,1,0,1,3,1,0,1,1,1,0,1,4,1,0,1,216,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,156,0,0,1,118,1,115,1,95,1,51,1,95,1,48,1,0,1,50,1,46,1,48,1,46,1,49,1,49,1,54,1,50,1,54,1,46,1,48,1,0,1,171,135,0,0,1,1,139,0,0,1,20,1,0,1,252,1,0,1,16,147,0,0,1,64,1,0,1,0,1,1,1,176,1,0,1,1,1,0,1,7,138,0,0,1,16,1,33,131,0,0,1,1,131,0,0,1,4,131,0,0,1,1,1,0,1,0,1,2,1,144,1,0,1,16,1,0,1,5,1,0,1,0,1,160,1,6,1,0,1,0,1,16,1,7,1,0,1,48,1,32,1,8,1,0,1,0,1,240,1,160,1,0,1,0,1,16,1,34,176,0,0,1,64,1,64,142,0,0,1,240,1,85,1,64,1,5,1,0,1,0,1,18,1,0,1,194,133,0,0,1,96,1,9,1,96,1,15,1,18,1,0,1,18,133,0,0,1,96,1,21,1,96,1,27,1,18,1,0,1,18,133,0,0,1,16,1,33,1,0,1,0,1,18,1,0,1,196,133,0,0,1,16,1,34,1,0,1,0,1,34,133,0,0,1,5,1,248,1,64,131,0,0,1,6,1,136,132,0,0,1,5,1,248,1,16,131,0,0,1,6,1,136,132,0,0,1,5,1,248,1,48,131,0,0,1,2,1,208,132,0,0,1,5,1,248,132,0,0,1,6,1,136,132,0,0,1,200,1,15,1,0,1,7,1,0,1,0,1,108,1,0,1,161,1,0,1,255,1,0,1,92,1,8,1,0,1,2,1,0,131,27,0,1,161,1,4,1,2,1,7,1,200,1,15,1,0,1,0,1,160,1,198,1,136,1,0,1,161,1,3,1,4,1,0,1,200,1,15,1,0,1,6,1,160,1,198,1,136,1,0,1,161,1,3,1,5,1,0,1,92,1,15,1,0,1,5,1,160,1,198,1,136,1,198,1,161,1,3,1,6,1,7,1,200,1,15,1,0,1,5,1,160,1,177,1,136,1,0,1,171,1,3,1,6,1,5,1,200,1,15,1,0,1,6,1,160,1,177,1,136,1,0,1,171,1,3,1,5,1,6,1,200,1,15,1,0,1,0,1,160,1,177,1,136,1,0,1,171,1,3,1,4,1,0,1,92,1,2,1,0,1,3,1,0,1,27,1,27,1,177,1,161,1,4,1,0,1,7,1,200,1,15,1,0,1,0,1,160,1,27,1,52,1,148,1,171,1,3,1,4,1,0,1,200,1,15,1,0,1,6,1,160,1,27,1,52,1,148,1,171,1,3,1,5,1,6,1,200,1,15,1,0,1,5,1,160,1,27,1,52,1,148,1,171,1,3,1,6,1,5,1,92,1,8,1,0,1,3,1,0,1,27,1,27,1,108,1,161,1,4,1,1,1,7,1,200,1,15,1,0,1,5,1,160,1,108,1,208,1,148,1,171,1,3,1,6,1,5,1,200,1,15,1,0,1,6,1,160,1,108,1,208,1,148,1,171,1,3,1,5,1,6,1,200,1,15,1,0,1,0,1,160,1,108,1,208,1,148,1,171,1,3,1,4,1,0,1,200,1,2,131,0,0,1,170,1,167,1,0,1,239,1,0,1,4,1,0,1,200,1,4,131,0,0,1,170,1,167,1,0,1,239,1,6,1,4,1,0,1,200,1,8,131,0,0,1,170,1,167,1,0,1,239,1,5,1,4,1,0,1,200,1,1,1,0,1,2,1,0,1,195,1,190,1,0,1,176,1,0,1,3,1,0,1,200,1,4,1,0,1,2,1,0,1,195,1,190,1,0,1,176,1,0,1,2,1,0,1,20,1,17,1,0,1,3,1,0,1,195,1,190,1,27,1,176,1,0,1,0,1,4,1,168,1,36,1,2,1,3,1,0,1,195,1,190,1,0,1,144,1,0,1,1,1,3,1,200,1,3,1,128,1,62,1,0,1,196,1,25,1,0,1,224,1,3,1,3,1,0,1,200,1,12,1,128,1,62,1,0,1,70,1,155,1,0,1,224,1,2,1,2,1,0,1,200,1,15,1,128,133,0,0,1,226,1,1,1,1,149,0,0,132,255,0,131,0,0,1,1,135,0,0,1,160,1,16,1,42,1,17,132,0,0,1,124,131,0,0,1,36,135,0,0,1,36,135,0,0,1,88,139,0,0,1,48,131,0,0,1,28,131,0,0,1,35,1,255,1,255,1,3,144,0,0,1,28,1,112,1,115,1,95,1,51,1,95,1,48,1,0,1,50,1,46,1,48,1,46,1,49,1,49,1,54,1,50,1,54,1,46,1,48,1,0,1,171,135,0,0,1,36,1,16,141,0,0,1,16,1,33,131,0,0,1,1,131,0,0,1,1,1,0,1,0,1,240,1,160,132,0,0,1,16,1,1,1,196,1,0,1,34,131,0,0,1,200,1,15,1,128,133,0,0,1,226,151,0,0,132,255,0,138,0,0,1,1,1,128,1,16,1,42,1,17,1,1,131,0,0,1,252,131,0,0,1,132,135,0,0,1,36,135,0,0,1,196,139,0,0,1,156,131,0,0,1,28,131,0,0,1,143,1,255,1,254,1,3,132,0,0,1,1,131,0,0,1,28,135,0,0,1,136,131,0,0,1,48,1,0,1,2,131,0,0,1,4,133,0,0,1,56,131,0,0,1,72,1,95,1,118,1,115,1,95,1,99,1,0,1,171,1,171,1,0,1,1,1,0,1,3,1,0,1,1,1,0,1,4,1,0,1,4,198,0,0,1,118,1,115,1,95,1,51,1,95,1,48,1,0,1,50,1,46,1,48,1,46,1,49,1,49,1,54,1,50,1,54,1,46,1,48,1,0,1,171,135,0,0,1,132,1,0,1,1,1,0,1,1,138,0,0,1,16,1,33,131,0,0,1,1,131,0,0,1,2,131,0,0,1,1,1,0,1,0,1,2,1,144,1,0,1,16,1,0,1,3,1,0,1,48,1,160,1,4,1,0,1,0,1,240,1,160,1,0,1,0,1,16,1,9,1,48,1,5,1,32,1,3,1,0,1,0,1,18,1,0,1,194,133,0,0,1,64,1,5,1,0,1,0,1,18,1,0,1,196,133,0,0,1,16,1,9,1,0,1,0,1,34,133,0,0,1,5,1,248,1,16,131,0,0,1,6,1,136,132,0,0,1,5,1,248,132,0,0,1,6,1,136,132,0,0,1,200,1,1,1,128,1,62,1,0,1,167,1,167,1,0,1,175,1,1,1,0,1,0,1,200,1,2,1,128,1,62,1,0,1,167,1,167,1,0,1,175,1,1,1,1,1,0,1,200,1,4,1,128,1,62,1,0,1,167,1,167,1,0,1,175,1,1,1,2,1,0,1,200,1,8,1,128,1,62,1,0,1,167,1,167,1,0,1,175,1,1,1,3,1,0,1,200,1,15,1,128,133,0,0,1,226,142,0,0,1,0};
			}
		}
#else
		/// <summary>Static Length+DeflateStream compressed shader byte code (Windows)</summary>
		private static byte[] fxb
		{
			get
			{
				return new byte[] {200,37,0,0,236,189,7,96,28,73,150,37,38,47,109,202,123,127,74,245,74,215,224,116,161,8,128,96,19,36,216,144,64,16,236,193,136,205,230,146,236,29,105,71,35,41,171,42,129,202,101,86,101,93,102,22,64,204,237,157,188,247,222,123,239,189,247,222,123,239,189,247,186,59,157,78,39,247,223,255,63,92,102,100,1,108,246,206,74,218,201,158,33,128,170,200,31,63,126,124,31,63,34,254,197,223,240,127,250,251,210,95,99,248,249,53,127,236,255,254,191,126,207,223,84,126,255,181,241,55,253,255,15,208,239,126,29,253,255,175,169,127,127,200,243,235,209,255,127,255,203,230,247,159,254,26,174,159,223,224,55,145,239,254,173,95,227,155,235,231,71,207,143,158,31,61,63,122,126,244,252,232,249,209,243,163,231,71,207,143,158,31,61,63,122,126,244,220,238,249,245,127,13,142,211,38,8,212,76,156,182,210,56,237,155,140,7,181,159,2,253,0,222,111,246,107,8,108,255,249,181,232,255,8,77,187,159,155,254,129,223,111,22,249,30,127,199,222,251,49,250,255,147,50,95,206,138,229,197,175,241,107,252,65,191,199,175,59,240,62,98,213,216,251,191,33,253,255,108,217,180,217,114,202,16,48,134,215,243,108,150,215,191,198,175,99,104,133,62,240,57,222,77,189,119,75,250,255,31,229,253,253,91,17,77,119,148,174,120,246,189,24,252,175,211,207,49,254,63,69,191,255,131,232,179,159,161,255,255,169,250,247,159,69,191,255,105,244,255,255,44,210,246,239,162,207,254,54,175,237,191,68,191,255,115,244,255,223,77,251,240,219,254,111,244,249,47,247,218,254,102,212,230,55,210,118,191,158,252,224,246,255,55,61,134,238,63,131,127,126,237,255,251,255,254,191,254,239,223,230,215,56,121,115,252,228,119,162,63,127,92,63,211,38,120,82,124,190,106,126,255,123,191,255,206,175,241,69,49,173,171,166,58,111,211,173,87,119,210,111,63,127,253,60,21,202,165,39,213,98,85,148,244,203,195,241,222,167,227,135,247,247,198,123,7,251,251,191,198,239,66,221,38,52,108,154,137,63,233,215,4,10,191,193,111,74,191,255,103,127,146,233,193,224,100,58,251,215,128,220,175,253,127,17,78,187,22,167,63,241,215,144,207,240,213,239,196,173,126,141,244,143,162,127,118,248,253,95,135,231,232,128,254,255,237,95,195,242,226,95,251,107,210,12,252,154,250,221,55,241,92,126,192,248,105,38,254,32,140,95,126,255,141,255,160,95,211,254,254,155,252,65,191,150,253,253,55,253,131,126,109,251,251,175,241,7,253,58,250,59,104,247,235,122,191,83,187,255,200,180,33,56,255,209,175,169,239,254,58,68,83,146,131,95,155,62,163,54,95,209,119,255,217,159,68,99,255,117,228,111,188,247,159,17,253,255,179,63,200,125,246,215,80,223,238,179,95,131,63,251,191,9,7,249,236,199,24,214,175,249,31,253,26,252,253,127,246,23,201,223,191,22,255,253,235,218,191,127,29,254,251,215,179,127,255,6,252,247,175,79,127,43,94,255,209,175,235,205,53,230,175,199,127,191,86,132,255,126,173,40,255,237,125,125,250,255,26,127,208,16,255,25,156,76,103,63,243,155,161,127,240,223,159,247,107,27,156,14,127,19,249,12,128,12,255,237,211,103,79,127,13,1,254,235,208,191,207,233,231,239,75,255,255,243,248,179,95,135,115,97,127,25,253,255,111,251,53,76,190,236,175,253,198,121,82,245,187,133,251,111,221,248,198,143,158,31,61,63,122,126,244,252,232,249,209,243,163,231,71,207,143,158,31,61,63,122,254,191,240,252,8,199,255,239,60,151,95,51,86,253,137,95,227,215,248,117,255,189,95,227,55,253,139,126,141,95,227,247,252,61,125,120,126,12,107,242,0,38,135,64,241,171,205,33,80,35,206,33,32,15,32,249,132,255,236,79,250,247,126,141,95,227,47,26,75,44,254,55,73,236,46,177,254,175,245,107,124,245,39,253,58,233,127,70,125,125,245,55,209,7,191,46,231,16,248,239,95,227,111,162,198,127,146,196,253,254,231,127,13,125,254,215,68,62,255,191,233,243,255,155,63,255,49,238,247,215,252,131,16,95,155,190,126,77,237,235,215,245,250,194,103,191,174,215,151,230,32,188,207,165,175,254,231,210,151,201,79,208,176,184,175,95,179,211,215,175,215,233,235,215,27,232,235,215,27,232,235,215,139,246,245,235,216,190,36,183,241,27,208,223,255,247,159,164,99,254,135,48,222,95,67,243,32,244,53,255,253,107,218,191,127,29,254,251,215,178,127,255,6,252,247,175,237,242,36,255,210,175,233,229,36,240,252,191,45,79,98,112,50,191,239,3,185,95,43,146,167,251,181,134,242,116,146,39,57,248,53,108,158,238,103,37,39,242,117,101,111,72,198,188,249,253,147,58,243,251,39,117,230,247,79,234,204,239,159,20,155,223,255,39,0,0,255,255};
			}
		}
#endif
	}
	/// <summary><para>Technique 'FillSolidColour' generated from file 'Simple.fx'</para><para>Vertex Shader: approximately 4 instruction slots used, 4 registers</para><para>Pixel Shader: approximately 1 instruction slot used, 1 register</para></summary>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("Xen.Graphics.ShaderSystem.CustomTool.dll", "e03e5007-ea04-4dcc-8690-d7e2837ab13f")]
	public sealed class FillSolidColour : Xen.Graphics.ShaderSystem.BaseShader
	{
		/// <summary>Construct an instance of the 'FillSolidColour' shader</summary>
		public FillSolidColour()
		{
			this.preg[0] = new Microsoft.Xna.Framework.Vector4(1F, 1F, 1F, 1F);
			this.sc0 = -1;
			this.sc1 = -1;
			this.sc2 = -1;
		}
		/// <summary>Setup shader static values</summary><param name="state"/>
		private void gdInit(Xen.Graphics.ShaderSystem.ShaderSystemBase state)
		{
			// set the graphics ID
			FillSolidColour.gd = state.DeviceUniqueIndex;
			this.GraphicsID = state.DeviceUniqueIndex;
			FillSolidColour.cid0 = state.GetNameUniqueID("FillColour");
		}
		/// <summary>Bind the shader, 'ic' indicates the shader instance has changed and 'ec' indicates the extension has changed.</summary><param name="state"/><param name="ic"/><param name="ec"/><param name="ext"/>
		protected override void BeginImpl(Xen.Graphics.ShaderSystem.ShaderSystemBase state, bool ic, bool ec, Xen.Graphics.ShaderSystem.ShaderExtension ext)
		{
			// if the device changed, call Warm()
			if ((state.DeviceUniqueIndex != FillSolidColour.gd))
			{
				this.WarmShader(state);
				ic = true;
			}
			// Force updating if the instance has changed
			this.vreg_change = (this.vreg_change | ic);
			this.preg_change = (this.preg_change | ic);
			this.vbreg_change = (this.vbreg_change | ic);
			this.vireg_change = (this.vireg_change | ic);
			// Set the value for attribute 'worldViewProj'
			this.vreg_change = (this.vreg_change | state.SetWorldViewProjectionMatrix(ref this.vreg[0], ref this.vreg[1], ref this.vreg[2], ref this.vreg[3], ref this.sc0));
			if ((this.vreg_change == true))
			{
				FillSolidColour.fx.vs_c.SetValue(this.vreg);
				this.vreg_change = false;
				ic = true;
			}
			if ((this.preg_change == true))
			{
				FillSolidColour.fx.ps_c.SetValue(this.preg);
				this.preg_change = false;
				ic = true;
			}
			if ((ext == Xen.Graphics.ShaderSystem.ShaderExtension.Blending))
			{
				ic = (ic | state.SetBlendMatricesDirect(FillSolidColour.fx.vsb_c, ref this.sc1));
			}
			if ((ext == Xen.Graphics.ShaderSystem.ShaderExtension.Instancing))
			{
				this.vireg_change = (this.vireg_change | state.SetViewProjectionMatrix(ref this.vireg[0], ref this.vireg[1], ref this.vireg[2], ref this.vireg[3], ref this.sc2));
				if ((this.vireg_change == true))
				{
					FillSolidColour.fx.vsi_c.SetValue(this.vireg);
					this.vireg_change = false;
					ic = true;
				}
			}
			// Finally, bind the effect
			if ((ic | ec))
			{
				state.SetEffect(this, ref FillSolidColour.fx, ext);
			}
		}
		/// <summary>Warm (Preload) the shader</summary><param name="state"/>
		protected override void WarmShader(Xen.Graphics.ShaderSystem.ShaderSystemBase state)
		{
			// Shader is already warmed
			if ((FillSolidColour.gd == state.DeviceUniqueIndex))
			{
				return;
			}
			// Setup the shader
			if ((FillSolidColour.gd != state.DeviceUniqueIndex))
			{
				this.gdInit(state);
			}
			FillSolidColour.fx.Dispose();
			// Create the effect instance
			state.CreateEffect(out FillSolidColour.fx, FillSolidColour.fxb, 5, 1);
		}
		/// <summary>True if a shader constant has changed since the last Bind()</summary>
		protected override bool Changed()
		{
			return (this.vreg_change | this.preg_change);
		}
		/// <summary>Returns the number of vertex inputs used by this shader</summary>
		protected override int GetVertexInputCountImpl()
		{
			return 1;
		}
		/// <summary>Returns a vertex input used by this shader</summary><param name="i"/><param name="usage"/><param name="index"/>
		protected override void GetVertexInputImpl(int i, out Microsoft.Xna.Framework.Graphics.VertexElementUsage usage, out int index)
		{
			usage = ((Microsoft.Xna.Framework.Graphics.VertexElementUsage)(FillSolidColour.vin[i]));
			index = FillSolidColour.vin[(i + 1)];
		}
		/// <summary>Static graphics ID</summary>
		private static int gd;
		/// <summary>Static effect container instance</summary>
		private static Xen.Graphics.ShaderSystem.ShaderEffect fx;
		/// <summary/>
		private bool vreg_change;
		/// <summary/>
		private bool preg_change;
		/// <summary/>
		private bool vbreg_change;
		/// <summary/>
		private bool vireg_change;
		/// <summary>Return the supported modes for this shader</summary><param name="blendingSupport"/><param name="instancingSupport"/>
		protected override void GetExtensionSupportImpl(out bool blendingSupport, out bool instancingSupport)
		{
			blendingSupport = true;
			instancingSupport = true;
		}
		/// <summary>Name ID for 'FillColour'</summary>
		private static int cid0;
		/// <summary>Set the shader value 'float4 FillColour'</summary><param name="value"/>
		public void SetFillColour(ref Microsoft.Xna.Framework.Vector4 value)
		{
			this.preg[0] = value;
			this.preg_change = true;
		}
		/// <summary>Assign the shader value 'float4 FillColour'</summary>
		public Microsoft.Xna.Framework.Vector4 FillColour
		{
			set
			{
				this.SetFillColour(ref value);
			}
		}
		/// <summary>Change ID for Semantic bound attribute 'worldViewProj'</summary>
		private int sc0;
		/// <summary>Change ID for Semantic bound attribute '__BLENDMATRICES__GENMATRIX'</summary>
		private int sc1;
		/// <summary>Change ID for Semantic bound attribute '__VIEWPROJECTION__GENMATRIX'</summary>
		private int sc2;
		/// <summary>array storing vertex usages, and element indices</summary>
readonly 
		private static int[] vin = new int[] {0,0};
		/// <summary>Vertex shader register storage</summary>
readonly 
		private Microsoft.Xna.Framework.Vector4[] vreg = new Microsoft.Xna.Framework.Vector4[4];
		/// <summary>Pixel shader register storage</summary>
readonly 
		private Microsoft.Xna.Framework.Vector4[] preg = new Microsoft.Xna.Framework.Vector4[1];
		/// <summary>Instancing shader register storage</summary>
readonly 
		private Microsoft.Xna.Framework.Vector4[] vireg = new Microsoft.Xna.Framework.Vector4[4];
#if XBOX360
		/// <summary>Static RLE compressed shader byte code (Xbox360)</summary>
		private static byte[] fxb
		{
			get
			{
				return new byte[] {4,188,240,11,207,131,0,1,32,152,0,8,254,255,9,1,0,0,15,116,135,0,1,3,131,0,1,1,131,0,1,96,135,0,1,4,131,0,1,4,131,0,1,1,195,0,6,6,95,118,115,95,99,134,0,1,3,131,0,1,1,131,0,1,152,135,0,1,1,131,0,1,4,131,0,1,1,147,0,0,1,6,1,95,1,112,1,115,1,95,1,99,134,0,0,1,3,131,0,0,1,1,1,0,1,0,1,14,1,64,135,0,0,1,216,131,0,0,1,4,131,0,0,1,1,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,153,0,0,1,7,1,95,1,118,1,115,1,98,1,95,1,99,133,0,0,1,3,131,0,0,1,1,1,0,1,0,1,14,1,168,135,0,0,1,4,131,0,0,1,4,131,0,0,1,1,195,0,0,1,7,1,95,1,118,1,115,1,105,1,95,1,99,133,0,0,1,1,131,0,0,1,16,131,0,0,1,4,143,0,0,1,2,131,0,0,1,15,131,0,0,1,4,147,0,0,1,3,131,0,0,1,16,131,0,0,1,4,143,0,0,1,4,131,0,0,1,15,131,0,0,1,4,143,0,0,1,9,1,66,1,108,1,101,1,110,1,100,1,105,1,110,1,103,135,0,0,1,5,131,0,0,1,16,131,0,0,1,4,143,0,0,1,6,131,0,0,1,15,131,0,0,1,4,143,0,0,1,11,1,73,1,110,1,115,1,116,1,97,1,110,1,99,1,105,1,110,1,103,133,0,0,1,7,1,83,1,104,1,97,1,100,1,101,1,114,133,0,0,1,4,131,0,0,1,1,131,0,0,1,9,131,0,0,1,7,131,0,0,1,4,131,0,0,1,32,139,0,0,1,108,131,0,0,1,136,139,0,0,1,164,131,0,0,1,192,138,0,0,1,14,1,76,1,0,1,0,1,14,1,104,138,0,0,1,15,1,104,135,0,0,1,3,1,0,1,0,1,14,1,228,135,0,0,1,2,131,0,0,1,92,134,0,0,1,14,1,184,1,0,1,0,1,14,1,180,131,0,0,1,93,134,0,0,1,14,1,208,1,0,1,0,1,14,1,204,1,0,1,0,1,15,1,24,135,0,0,1,2,131,0,0,1,92,134,0,0,1,14,1,236,1,0,1,0,1,14,1,232,131,0,0,1,93,134,0,0,1,15,1,4,1,0,1,0,1,15,131,0,0,1,15,1,88,135,0,0,1,2,131,0,0,1,92,134,0,0,1,15,1,44,1,0,1,0,1,15,1,40,131,0,0,1,93,134,0,0,1,15,1,68,1,0,1,0,1,15,1,64,135,0,0,1,6,135,0,0,1,2,132,255,0,131,0,0,1,1,135,0,0,1,216,1,16,1,42,1,17,132,0,0,1,180,131,0,0,1,36,135,0,0,1,36,135,0,0,1,148,139,0,0,1,108,131,0,0,1,28,131,0,0,1,95,1,255,1,255,1,3,132,0,0,1,1,131,0,0,1,28,135,0,0,1,88,131,0,0,1,48,1,0,1,2,131,0,0,1,1,133,0,0,1,56,131,0,0,1,72,1,95,1,112,1,115,1,95,1,99,1,0,1,171,1,171,1,0,1,1,1,0,1,3,1,0,1,1,1,0,1,4,1,0,1,1,150,0,0,1,112,1,115,1,95,1,51,1,95,1,48,1,0,1,50,1,46,1,48,1,46,1,49,1,49,1,54,1,50,1,54,1,46,1,48,1,0,1,171,135,0,0,1,36,1,16,150,0,0,1,1,132,0,0,1,16,1,1,1,196,1,0,1,34,131,0,0,1,200,1,15,1,128,133,0,0,1,34,150,0,0,1,2,132,255,0,138,0,0,1,1,1,204,1,16,1,42,1,17,1,1,1,0,1,0,1,1,132,0,0,1,204,135,0,0,1,36,135,0,0,1,196,139,0,0,1,156,131,0,0,1,28,131,0,0,1,143,1,255,1,254,1,3,132,0,0,1,1,131,0,0,1,28,135,0,0,1,136,131,0,0,1,48,1,0,1,2,1,0,1,4,1,0,1,4,133,0,0,1,56,131,0,0,1,72,1,95,1,118,1,115,1,105,1,95,1,99,1,0,1,171,1,0,1,1,1,0,1,3,1,0,1,1,1,0,1,4,1,0,1,4,198,0,0,1,118,1,115,1,95,1,51,1,95,1,48,1,0,1,50,1,46,1,48,1,46,1,49,1,49,1,54,1,50,1,54,1,46,1,48,1,0,1,171,135,0,0,1,204,1,0,1,1,1,0,1,4,143,0,0,1,1,131,0,0,1,5,134,0,0,1,2,1,144,1,0,1,16,1,0,1,3,1,0,1,12,1,0,1,4,1,0,1,13,1,0,1,5,1,0,1,14,1,0,1,6,1,0,1,63,1,0,1,7,1,241,1,85,1,80,1,3,1,0,1,0,1,18,1,1,1,194,133,0,0,1,96,1,8,1,32,1,14,1,18,1,0,1,18,136,0,0,1,3,1,196,1,0,1,34,131,0,0,1,5,1,248,1,32,131,0,0,1,6,1,136,132,0,0,1,5,1,248,1,16,131,0,0,1,6,1,136,132,0,0,1,5,1,248,1,48,131,0,0,1,6,1,136,132,0,0,1,5,1,248,1,64,131,0,0,1,6,1,136,132,0,0,1,5,1,248,132,0,0,1,6,1,136,132,0,0,1,200,1,15,131,0,0,1,27,1,0,1,0,1,225,1,2,1,0,1,0,1,200,1,15,131,0,0,1,198,1,0,1,0,1,235,1,2,1,4,1,0,1,200,1,15,131,0,0,1,177,1,148,1,148,1,235,1,2,1,3,1,0,1,200,1,15,131,0,0,1,108,1,248,1,148,1,235,1,2,1,1,1,0,1,200,1,1,1,128,1,62,1,0,1,233,1,167,1,0,1,175,1,0,1,4,1,0,1,200,1,2,1,128,1,62,1,0,1,233,1,167,1,0,1,175,1,0,1,5,1,0,1,200,1,4,1,128,1,62,1,0,1,233,1,167,1,0,1,175,1,0,1,6,1,0,1,200,1,8,1,128,1,62,1,0,1,233,1,167,1,0,1,175,1,0,1,7,148,0,0,1,1,132,255,0,131,0,0,1,1,135,0,0,1,216,1,16,1,42,1,17,132,0,0,1,180,131,0,0,1,36,135,0,0,1,36,135,0,0,1,148,139,0,0,1,108,131,0,0,1,28,131,0,0,1,95,1,255,1,255,1,3,132,0,0,1,1,131,0,0,1,28,135,0,0,1,88,131,0,0,1,48,1,0,1,2,131,0,0,1,1,133,0,0,1,56,131,0,0,1,72,1,95,1,112,1,115,1,95,1,99,1,0,1,171,1,171,1,0,1,1,1,0,1,3,1,0,1,1,1,0,1,4,1,0,1,1,150,0,0,1,112,1,115,1,95,1,51,1,95,1,48,1,0,1,50,1,46,1,48,1,46,1,49,1,49,1,54,1,50,1,54,1,46,1,48,1,0,1,171,135,0,0,1,36,1,16,150,0,0,1,1,132,0,0,1,16,1,1,1,196,1,0,1,34,131,0,0,1,200,1,15,1,128,133,0,0,1,34,150,0,0,1,1,132,255,0,138,0,0,1,16,1,164,1,16,1,42,1,17,1,1,1,0,1,0,1,14,1,204,1,0,1,0,1,1,1,216,135,0,0,1,36,1,0,1,0,1,14,1,112,1,0,1,0,1,14,1,152,138,0,0,1,14,1,72,131,0,0,1,28,1,0,1,0,1,14,1,59,1,255,1,254,1,3,132,0,0,1,2,131,0,0,1,28,134,0,0,1,14,1,52,131,0,0,1,68,1,0,1,2,131,0,0,1,4,133,0,0,1,76,131,0,0,1,92,131,0,0,1,156,1,0,1,2,1,0,1,4,1,0,1,216,133,0,0,1,164,131,0,0,1,180,1,95,1,118,1,115,1,95,1,99,1,0,1,171,1,171,1,0,1,1,1,0,1,3,1,0,1,1,1,0,1,4,1,0,1,4,198,0,0,1,95,1,118,1,115,1,98,1,95,1,99,1,0,1,171,1,0,1,1,1,0,1,3,1,0,1,1,1,0,1,4,1,0,1,216,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,229,0,0,156,0,0,1,118,1,115,1,95,1,51,1,95,1,48,1,0,1,50,1,46,1,48,1,46,1,49,1,49,1,54,1,50,1,54,1,46,1,48,1,0,1,171,135,0,0,1,1,139,0,0,1,20,1,0,1,252,1,0,1,16,147,0,0,1,64,1,0,1,0,1,1,1,152,1,0,1,1,1,0,1,6,143,0,0,1,1,131,0,0,1,3,134,0,0,1,2,1,144,1,0,1,16,1,0,1,5,1,0,1,0,1,16,1,6,1,0,1,48,1,32,1,7,176,0,0,1,64,1,64,142,0,0,1,112,1,21,1,48,1,5,1,0,1,0,1,18,1,0,1,194,133,0,0,1,96,1,8,1,96,1,14,1,18,1,0,1,18,133,0,0,1,96,1,20,1,96,1,26,1,18,1,0,1,18,133,0,0,1,16,1,32,1,0,1,0,1,18,1,0,1,196,134,0,0,1,5,1,0,1,0,1,34,133,0,0,1,5,1,248,1,48,131,0,0,1,6,1,136,132,0,0,1,5,1,248,1,32,131,0,0,1,2,1,208,132,0,0,1,5,1,248,132,0,0,1,6,1,136,132,0,0,1,200,1,15,1,0,1,6,1,0,1,0,1,108,1,0,1,161,1,0,1,255,1,0,1,92,1,8,1,0,1,1,1,0,131,27,0,1,161,1,3,1,2,1,6,1,200,1,15,1,0,1,0,1,160,1,198,1,136,1,0,1,161,1,2,1,4,1,0,1,200,1,15,1,0,1,5,1,160,1,198,1,136,1,0,1,161,1,2,1,5,1,0,1,92,1,15,1,0,1,4,1,160,1,198,1,136,1,198,1,161,1,2,1,6,1,6,1,200,1,15,1,0,1,4,1,160,1,177,1,136,1,0,1,171,1,2,1,6,1,4,1,200,1,15,1,0,1,5,1,160,1,177,1,136,1,0,1,171,1,2,1,5,1,5,1,200,1,15,1,0,1,0,1,160,1,177,1,136,1,0,1,171,1,2,1,4,1,0,1,92,1,2,1,0,1,2,1,0,1,27,1,27,1,177,1,161,1,3,1,0,1,6,1,200,1,15,1,0,1,0,1,160,1,27,1,52,1,148,1,171,1,2,1,4,1,0,1,200,1,15,1,0,1,5,1,160,1,27,1,52,1,148,1,171,1,2,1,5,1,5,1,200,1,15,1,0,1,4,1,160,1,27,1,52,1,148,1,171,1,2,1,6,1,4,1,92,1,8,1,0,1,2,1,0,1,27,1,27,1,108,1,161,1,3,1,1,1,6,1,200,1,15,1,0,1,4,1,160,1,108,1,208,1,148,1,171,1,2,1,6,1,4,1,200,1,15,1,0,1,5,1,160,1,108,1,208,1,148,1,171,1,2,1,5,1,5,1,200,1,15,1,0,1,0,1,160,1,108,1,208,1,148,1,171,1,2,1,4,1,0,1,200,1,2,131,0,0,1,170,1,167,1,0,1,239,1,0,1,3,1,0,1,200,1,4,131,0,0,1,170,1,167,1,0,1,239,1,5,1,3,1,0,1,200,1,8,131,0,0,1,170,1,167,1,0,1,239,1,4,1,3,1,0,1,200,1,1,1,0,1,1,1,0,1,195,1,190,1,0,1,176,1,0,1,3,1,0,1,200,1,4,1,0,1,1,1,0,1,195,1,190,1,0,1,176,1,0,1,2,1,0,1,20,1,17,1,0,1,2,1,0,1,195,1,190,1,27,1,176,1,0,1,0,1,3,1,168,1,36,1,1,1,2,1,0,1,195,1,190,1,0,1,144,1,0,1,1,1,3,1,200,1,3,1,128,1,62,1,0,1,196,1,25,1,0,1,224,1,2,1,2,1,0,1,200,1,12,1,128,1,62,1,0,1,70,1,155,1,0,1,224,1,1,1,1,149,0,0,132,255,0,131,0,0,1,1,135,0,0,1,216,1,16,1,42,1,17,132,0,0,1,180,131,0,0,1,36,135,0,0,1,36,135,0,0,1,148,139,0,0,1,108,131,0,0,1,28,131,0,0,1,95,1,255,1,255,1,3,132,0,0,1,1,131,0,0,1,28,135,0,0,1,88,131,0,0,1,48,1,0,1,2,131,0,0,1,1,133,0,0,1,56,131,0,0,1,72,1,95,1,112,1,115,1,95,1,99,1,0,1,171,1,171,1,0,1,1,1,0,1,3,1,0,1,1,1,0,1,4,1,0,1,1,150,0,0,1,112,1,115,1,95,1,51,1,95,1,48,1,0,1,50,1,46,1,48,1,46,1,49,1,49,1,54,1,50,1,54,1,46,1,48,1,0,1,171,135,0,0,1,36,1,16,150,0,0,1,1,132,0,0,1,16,1,1,1,196,1,0,1,34,131,0,0,1,200,1,15,1,128,133,0,0,1,34,151,0,0,132,255,0,138,0,0,1,1,1,92,1,16,1,42,1,17,1,1,131,0,0,1,240,131,0,0,1,108,135,0,0,1,36,135,0,0,1,196,139,0,0,1,156,131,0,0,1,28,131,0,0,1,143,1,255,1,254,1,3,132,0,0,1,1,131,0,0,1,28,135,0,0,1,136,131,0,0,1,48,1,0,1,2,131,0,0,1,4,133,0,0,1,56,131,0,0,1,72,1,95,1,118,1,115,1,95,1,99,1,0,1,171,1,171,1,0,1,1,1,0,1,3,1,0,1,1,1,0,1,4,1,0,1,4,198,0,0,1,118,1,115,1,95,1,51,1,95,1,48,1,0,1,50,1,46,1,48,1,46,1,49,1,49,1,54,1,50,1,54,1,46,1,48,1,0,1,171,135,0,0,1,108,1,0,1,1,145,0,0,1,1,131,0,0,1,1,134,0,0,1,2,1,144,131,0,0,1,3,1,16,1,1,1,16,1,3,1,0,1,0,1,18,1,0,1,194,133,0,0,1,64,1,4,1,0,1,0,1,18,1,0,1,196,134,0,0,1,3,1,0,1,0,1,34,133,0,0,1,5,1,248,132,0,0,1,6,1,136,132,0,0,1,200,1,1,1,128,1,62,1,0,1,167,1,167,1,0,1,175,131,0,0,1,200,1,2,1,128,1,62,1,0,1,167,1,167,1,0,1,175,1,0,1,1,1,0,1,200,1,4,1,128,1,62,1,0,1,167,1,167,1,0,1,175,1,0,1,2,1,0,1,200,1,8,1,128,1,62,1,0,1,167,1,167,1,0,1,175,1,0,1,3,140,0,0,1,0};
			}
		}
#else
		/// <summary>Static Length+DeflateStream compressed shader byte code (Windows)</summary>
		private static byte[] fxb
		{
			get
			{
				return new byte[] {76,38,0,0,236,189,7,96,28,73,150,37,38,47,109,202,123,127,74,245,74,215,224,116,161,8,128,96,19,36,216,144,64,16,236,193,136,205,230,146,236,29,105,71,35,41,171,42,129,202,101,86,101,93,102,22,64,204,237,157,188,247,222,123,239,189,247,222,123,239,189,247,186,59,157,78,39,247,223,255,63,92,102,100,1,108,246,206,74,218,201,158,33,128,170,200,31,63,126,124,31,63,34,254,197,223,240,127,250,251,210,95,99,248,249,53,127,236,255,254,191,222,253,166,242,251,175,141,191,233,255,127,128,126,247,235,232,255,127,77,253,251,67,158,95,143,254,255,251,95,54,191,255,244,215,112,253,252,89,250,29,126,31,234,135,223,91,133,239,253,158,191,137,124,247,111,109,120,239,71,207,143,158,31,61,63,122,126,244,252,232,249,209,243,163,231,71,207,143,158,31,61,63,122,126,244,252,236,60,191,254,175,193,241,221,132,2,181,95,215,196,105,127,149,198,105,223,100,28,169,253,20,8,8,1,239,55,251,53,4,182,255,252,90,244,127,132,180,221,207,77,255,192,239,55,139,124,143,191,99,239,253,24,253,255,73,153,47,103,197,242,2,127,255,186,191,70,252,125,196,170,177,247,127,67,250,255,217,178,105,179,229,148,33,96,12,175,231,217,44,175,127,141,202,208,5,125,224,115,252,157,122,239,150,244,255,63,202,251,251,47,163,255,255,67,222,223,207,137,198,115,165,51,183,247,98,249,255,76,63,7,61,254,20,253,254,239,162,207,254,54,250,255,159,170,127,255,75,244,251,63,71,255,255,157,244,61,191,237,255,68,159,255,119,94,219,223,128,218,252,58,244,255,223,55,210,118,135,62,27,253,166,174,237,183,233,247,167,218,238,215,147,31,220,254,255,166,199,204,195,95,135,127,126,237,255,251,255,254,191,254,239,223,253,215,56,121,115,252,228,119,162,63,127,127,253,12,109,240,55,61,233,239,13,248,250,254,175,73,255,30,0,254,175,97,242,2,127,237,95,251,107,210,104,127,77,162,220,16,127,81,179,123,191,255,206,175,241,69,49,173,171,166,58,111,211,173,87,119,210,111,63,127,253,60,149,89,72,79,170,197,170,40,233,151,135,227,189,79,199,15,239,239,141,247,14,246,247,1,239,215,162,65,255,65,68,201,191,232,255,254,191,5,150,25,131,129,253,55,161,211,95,251,255,162,49,236,218,49,252,137,191,134,124,230,143,225,143,250,53,204,24,126,29,158,227,131,95,67,199,32,188,108,199,208,229,157,175,251,92,126,205,49,255,46,60,196,223,232,15,34,78,254,147,228,247,223,248,15,250,53,237,239,191,201,31,244,107,217,223,127,211,63,232,215,182,191,255,26,127,208,175,227,253,78,223,253,71,191,166,182,249,117,126,141,255,236,79,34,121,249,181,9,6,125,254,21,193,250,207,254,36,26,227,175,35,127,163,237,127,246,39,209,103,127,144,251,236,175,161,62,220,103,191,6,127,246,127,83,95,242,217,143,49,107,255,154,255,209,175,193,223,255,103,127,145,252,253,107,241,223,191,174,253,251,215,225,191,127,61,251,247,111,192,127,255,250,222,60,98,110,122,188,248,107,69,120,241,215,250,198,121,113,239,235,204,75,140,23,205,24,12,236,217,111,70,255,252,90,224,197,63,239,215,54,99,56,252,77,228,51,224,107,198,176,79,159,61,253,53,100,12,191,14,253,251,156,126,254,190,244,255,63,143,63,251,117,56,175,6,61,243,183,253,26,38,103,231,198,245,77,241,167,218,10,11,247,223,186,241,141,31,61,63,122,126,244,252,232,249,209,243,163,231,71,207,143,158,31,61,63,122,126,244,220,244,252,232,251,31,61,239,243,92,126,205,248,244,39,40,45,246,239,253,26,191,233,95,244,107,252,26,191,231,239,233,195,243,114,2,156,31,160,152,213,230,19,232,11,206,39,252,186,28,163,255,166,28,247,255,123,191,198,175,241,23,141,37,119,240,55,73,76,47,57,128,95,243,215,248,234,79,250,117,210,255,140,224,127,245,55,253,58,156,130,163,220,2,255,205,41,152,63,73,242,1,254,231,127,13,125,254,215,68,62,255,191,233,243,255,155,63,215,92,194,31,132,28,132,233,235,215,212,190,126,93,175,47,124,246,235,122,125,105,110,194,251,92,250,234,127,46,125,185,188,197,175,197,125,253,154,157,190,126,189,78,95,191,222,64,95,191,222,64,95,191,94,180,175,95,199,246,37,185,152,223,128,254,254,191,255,36,29,243,63,132,241,34,151,160,120,241,223,191,166,203,159,240,223,191,150,203,159,240,223,191,182,151,123,192,243,255,245,252,9,30,63,127,242,59,161,211,95,43,146,203,251,181,134,114,121,146,63,57,248,53,108,46,239,103,37,87,242,117,101,210,151,61,111,222,255,164,206,188,255,73,157,121,255,147,58,243,254,39,153,121,255,127,2,0,0,255,255};
			}
		}
#endif
		/// <summary>Set a shader attribute of type 'Vector4' by global unique ID, see <see cref="Xen.Graphics.ShaderSystem.ShaderSystemBase.GetNameUniqueID"/> for details.</summary><param name="state"/><param name="id"/><param name="value"/>
		protected override bool SetAttributeImpl(Xen.Graphics.ShaderSystem.ShaderSystemBase state, int id, ref Microsoft.Xna.Framework.Vector4 value)
		{
			if ((FillSolidColour.gd != state.DeviceUniqueIndex))
			{
				this.WarmShader(state);
			}
			if ((id == FillSolidColour.cid0))
			{
				this.SetFillColour(ref value);
				return true;
			}
			return false;
		}
	}
}
