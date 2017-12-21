/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class ANiagaraActor
	{
		///<summary>UNiagaraComponent *</summary>
		public const int NiagaraComponent = 0x03B0;

	}

	public class UNiagaraComponent
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x0850;

		///<summary>TArray&lt;FNiagaraVariable&gt;</summary>
		public const int EffectParameterLocalOverrides = 0x0860;

		///<summary>TArray&lt;FNiagaraScriptDataInterfaceInfo&gt;</summary>
		public const int EffectDataInterfaceLocalOverrides = 0x0870;

		///<summary>TArray&lt;UNiagaraDataInterface * &gt;</summary>
		public const int InstanceDataInterfaces = 0x0880;

		///<summary>bool</summary>
		public const int bRenderingEnabled = 0x0890;

		///<summary>unsigned char[0xF]</summary>
		public const int UnknownData01 = 0x0891;

	}

	public class UNiagaraDataInterfaceCurve
	{
		///<summary>FRichCurve</summary>
		public const int Curve = 0x0028;

	}

	public class UNiagaraDataInterfaceVectorCurve
	{
		///<summary>FRichCurve</summary>
		public const int XCurve = 0x0028;

		///<summary>FRichCurve</summary>
		public const int YCurve = 0x0098;

		///<summary>FRichCurve</summary>
		public const int ZCurve = 0x0108;

	}

	public class UNiagaraDataInterfaceColorCurve
	{
		///<summary>FRichCurve</summary>
		public const int RedCurve = 0x0028;

		///<summary>FRichCurve</summary>
		public const int GreenCurve = 0x0098;

		///<summary>FRichCurve</summary>
		public const int BlueCurve = 0x0108;

		///<summary>FRichCurve</summary>
		public const int AlphaCurve = 0x0178;

	}

	public class UNiagaraDataInterfaceSpline
	{
		///<summary>AActor *</summary>
		public const int Source = 0x0028;

		///<summary>unsigned char[0x90]</summary>
		public const int UnknownData00 = 0x0030;

	}

	public class UNiagaraDataInterfaceStaticMesh
	{
		///<summary>UStaticMesh *</summary>
		public const int DefaultMesh = 0x0028;

		///<summary>AActor *</summary>
		public const int Source = 0x0030;

		///<summary>FNDIStaticMeshSectionFilter</summary>
		public const int SectionFilter = 0x0038;

		///<summary>bool</summary>
		public const int bEnableVertexColorRangeSorting = 0x00A0;

		///<summary>unsigned char[0x14F]</summary>
		public const int UnknownData00 = 0x00A1;

	}

	public class UNiagaraEffect
	{
		///<summary>TArray&lt;FNiagaraEmitterHandle&gt;</summary>
		public const int EmitterHandles = 0x0028;

		///<summary>UNiagaraScript *</summary>
		public const int EffectScript = 0x0038;

		///<summary>TArray&lt;FNiagaraParameterBinding&gt;</summary>
		public const int ParameterBindings = 0x0040;

		///<summary>TArray&lt;FNiagaraParameterBinding&gt;</summary>
		public const int DataInterfaceBindings = 0x0050;

		///<summary>TArray&lt;FNiagaraEmitterInternalVariableBinding&gt;</summary>
		public const int InternalEmitterVariableBindings = 0x0060;

	}

	public class UNiagaraLightRendererProperties
	{
		///<summary>float</summary>
		public const int RadiusScale = 0x0028;

		///<summary>FVector</summary>
		public const int ColorAdd = 0x002C;

	}

	public class UNiagaraMeshRendererProperties
	{
		///<summary>UStaticMesh *</summary>
		public const int ParticleMesh = 0x0028;

	}

	public class UNiagaraSpriteRendererProperties
	{
		///<summary>FVector2D</summary>
		public const int SubImageSize = 0x0028;

		///<summary>ENiagaraSpriteAlignment</summary>
		public const int Alignment = 0x0030;

		///<summary>ENiagaraSpriteFacingMode</summary>
		public const int FacingMode = 0x0031;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData00 = 0x0032;

		///<summary>FVector</summary>
		public const int CustomFacingVectorMask = 0x0034;

		///<summary>ENiagaraSortMode</summary>
		public const int SortMode = 0x0040;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData01 = 0x0041;

	}

	public class UNiagaraScript
	{
		///<summary>TArray&lt;unsigned char&gt;</summary>
		public const int ByteCode = 0x0028;

		///<summary>FNiagaraParameters</summary>
		public const int Parameters = 0x0038;

		///<summary>FNiagaraParameters</summary>
		public const int InternalParameters = 0x0048;

		///<summary>TArray&lt;FNiagaraVariable&gt;</summary>
		public const int Attributes = 0x0058;

		///<summary>TArray&lt;FNiagaraDataSetProperties&gt;</summary>
		public const int EventReceivers = 0x0068;

		///<summary>TArray&lt;FNiagaraDataSetProperties&gt;</summary>
		public const int EventGenerators = 0x0078;

		///<summary>FNiagaraScriptDataUsageInfo</summary>
		public const int DataUsage = 0x0088;

		///<summary>ENiagaraScriptUsage</summary>
		public const int Usage = 0x0089;

		///<summary>unsigned char[0x6]</summary>
		public const int UnknownData00 = 0x008A;

		///<summary>TArray&lt;FNiagaraScriptDataInterfaceInfo&gt;</summary>
		public const int DataInterfaceInfo = 0x0090;

		///<summary>TArray&lt;FVMExternalFunctionBindingInfo&gt;</summary>
		public const int CalledVMExternalFunctions = 0x00A0;

		///<summary>ENiagaraNumericOutputTypeSelectionMode</summary>
		public const int NumericOutputTypeSelectionMode = 0x00B0;

		///<summary>unsigned char[0x27]</summary>
		public const int UnknownData01 = 0x00B1;

		///<summary>TArray&lt;FNiagaraStatScope&gt;</summary>
		public const int StatScopes = 0x00D8;

	}

	public class UNiagaraEventReceiverEmitterAction_SpawnParticles
	{
		///<summary>uint32_t</summary>
		public const int NumParticles = 0x0028;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x002C;

	}

	public class UNiagaraEmitterProperties
	{
		///<summary>float</summary>
		public const int SpawnRate = 0x0028;

		///<summary>bool</summary>
		public const int bLocalSpace = 0x002C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x002D;

		///<summary>UMaterial *</summary>
		public const int Material = 0x0030;

		///<summary>float</summary>
		public const int StartTime = 0x0038;

		///<summary>float</summary>
		public const int EndTime = 0x003C;

		///<summary>int</summary>
		public const int NumLoops = 0x0040;

		///<summary>ENiagaraCollisionMode</summary>
		public const int CollisionMode = 0x0044;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0045;

		///<summary>UNiagaraEffectRendererProperties *</summary>
		public const int RendererProperties = 0x0048;

		///<summary>FNiagaraEmitterScriptProperties</summary>
		public const int UpdateScriptProps = 0x0050;

		///<summary>FNiagaraEmitterScriptProperties</summary>
		public const int SpawnScriptProps = 0x0078;

		///<summary>FNiagaraEventScriptProperties</summary>
		public const int EventHandlerScriptProps = 0x00A0;

		///<summary>TArray&lt;FNiagaraEmitterBurst&gt;</summary>
		public const int Bursts = 0x00F0;

		///<summary>unsigned char:1</summary>
		public const int bInterpolatedSpawning = 0x0100;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData02 = 0x0101;

	}

	public class UNiagaraScriptSourceBase
	{
		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UNiagaraSettings
	{
		///<summary>FStringAssetReference</summary>
		public const int DefaultEffect = 0x0038;

		///<summary>FStringAssetReference</summary>
		public const int DefaultEmitter = 0x0048;

		///<summary>FStringAssetReference</summary>
		public const int DefaultScript = 0x0058;

		///<summary>TArray&lt;FStringAssetReference&gt;</summary>
		public const int AdditionalParameterTypes = 0x0068;

		///<summary>TArray&lt;FStringAssetReference&gt;</summary>
		public const int AdditionalPayloadTypes = 0x0078;

	}

}
