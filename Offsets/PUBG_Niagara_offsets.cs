/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class ANiagaraActor
	{
		///<summary>UNiagaraComponent *</summary>
		public const int NiagaraComponent = 0x03A0;

	}

	public class UNiagaraComponent
	{
		///<summary>unsigned char[0x10]</summary>
		public const int UnknownData00 = 0x06D0;

	}

	public class UNiagaraScript
	{
		///<summary>TArray<unsigned char></summary>
		public const int ByteCode = 0x0028;

		///<summary>FNiagaraScriptConstantData</summary>
		public const int ConstantData = 0x0038;

		///<summary>TArray<FNiagaraVariableInfo></summary>
		public const int Attributes = 0x0098;

		///<summary>TArray<FNiagaraDataSetProperties></summary>
		public const int EventReceivers = 0x00A8;

		///<summary>TArray<FNiagaraDataSetProperties></summary>
		public const int EventGenerators = 0x00B8;

		///<summary>FNiagaraScriptUsageInfo</summary>
		public const int Usage = 0x00C8;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x00C9;

	}

	public class UNiagaraEmitterProperties
	{
		///<summary>FString</summary>
		public const int EmitterName = 0x0028;

		///<summary>bool</summary>
		public const int bIsEnabled = 0x0038;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData00 = 0x0039;

		///<summary>float</summary>
		public const int SpawnRate = 0x003C;

		///<summary>UMaterial *</summary>
		public const int Material = 0x0040;

		///<summary>TEnumAsByte<EEmitterRenderModuleType></summary>
		public const int RenderModuleType = 0x0048;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0049;

		///<summary>float</summary>
		public const int StartTime = 0x004C;

		///<summary>float</summary>
		public const int EndTime = 0x0050;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x0054;

		///<summary>UNiagaraEffectRendererProperties *</summary>
		public const int RendererProperties = 0x0058;

		///<summary>int</summary>
		public const int NumLoops = 0x0060;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x0064;

		///<summary>FNiagaraEmitterScriptProperties</summary>
		public const int UpdateScriptProps = 0x0068;

		///<summary>FNiagaraEmitterScriptProperties</summary>
		public const int SpawnScriptProps = 0x00C0;

	}

	public class UNiagaraEffect
	{
		///<summary>TArray<UNiagaraEmitterProperties * ></summary>
		public const int EmitterProps = 0x0028;

	}

	public class UNiagaraEffectRendererProperties
	{
		///<summary>FName</summary>
		public const int dummy = 0x0028;

	}

	public class UNiagaraMeshRendererProperties
	{
		///<summary>UStaticMesh *</summary>
		public const int ParticleMesh = 0x0030;

	}

	public class UNiagaraSpriteRendererProperties
	{
		///<summary>FVector2D</summary>
		public const int SubImageInfo = 0x0030;

		///<summary>bool</summary>
		public const int bBVelocityAligned = 0x0038;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0039;

	}

	public class UNiagaraEventReceiverEmitterAction_SpawnParticles
	{
		///<summary>uint32_t</summary>
		public const int NumParticles = 0x0028;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData00 = 0x002C;

	}

	public class UNiagaraScriptSourceBase
	{
		///<summary>unsigned char[0x20]</summary>
		public const int UnknownData00 = 0x0028;

	}

	public class UNiagaraSequence
	{
		///<summary>UMovieScene *</summary>
		public const int MovieScene = 0x0028;

	}

}
