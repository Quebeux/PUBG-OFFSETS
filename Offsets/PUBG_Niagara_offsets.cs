/// <summary>
/// Auto-generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class ANiagaraActor
	{
		public const int NiagaraComponent = 0x03A0;
	}

	public class UNiagaraComponent
	{
		public const int UnknownData00 = 0x06D0;
	}

	public class UNiagaraScript
	{
		public const int ByteCode = 0x0028;
		public const int ConstantData = 0x0038;
		public const int Attributes = 0x0098;
		public const int EventReceivers = 0x00A8;
		public const int EventGenerators = 0x00B8;
		public const int Usage = 0x00C8;
		public const int UnknownData00 = 0x00C9;
	}

	public class UNiagaraEmitterProperties
	{
		public const int EmitterName = 0x0028;
		public const int bIsEnabled = 0x0038;
		public const int UnknownData00 = 0x0039;
		public const int SpawnRate = 0x003C;
		public const int Material = 0x0040;
		public const int RenderModuleType = 0x0048;
		public const int UnknownData01 = 0x0049;
		public const int StartTime = 0x004C;
		public const int EndTime = 0x0050;
		public const int UnknownData02 = 0x0054;
		public const int RendererProperties = 0x0058;
		public const int NumLoops = 0x0060;
		public const int UnknownData03 = 0x0064;
		public const int UpdateScriptProps = 0x0068;
		public const int SpawnScriptProps = 0x00C0;
	}

	public class UNiagaraEffect
	{
		public const int EmitterProps = 0x0028;
	}

	public class UNiagaraEffectRendererProperties
	{
		public const int dummy = 0x0028;
	}

	public class UNiagaraMeshRendererProperties
	{
		public const int ParticleMesh = 0x0030;
	}

	public class UNiagaraSpriteRendererProperties
	{
		public const int SubImageInfo = 0x0030;
		public const int bBVelocityAligned = 0x0038;
		public const int UnknownData00 = 0x0039;
	}

	public class UNiagaraEventReceiverEmitterAction_SpawnParticles
	{
		public const int NumParticles = 0x0028;
		public const int UnknownData00 = 0x002C;
	}

	public class UNiagaraScriptSourceBase
	{
		public const int UnknownData00 = 0x0028;
	}

	public class UNiagaraSequence
	{
		public const int MovieScene = 0x0028;
	}

}
