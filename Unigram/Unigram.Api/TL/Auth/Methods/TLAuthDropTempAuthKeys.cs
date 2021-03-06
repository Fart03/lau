// <auto-generated/>
using System;

namespace Telegram.Api.TL.Auth.Methods
{
	/// <summary>
	/// RCP method auth.dropTempAuthKeys.
	/// Returns <see cref="Telegram.Api.TL.TLBool"/>
	/// </summary>
	public partial class TLAuthDropTempAuthKeys : TLObject
	{
		public TLVector<Int64> ExceptAuthKeys { get; set; }

		public TLAuthDropTempAuthKeys() { }
		public TLAuthDropTempAuthKeys(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AuthDropTempAuthKeys; } }

		public override void Read(TLBinaryReader from)
		{
			ExceptAuthKeys = TLFactory.Read<TLVector<Int64>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x8E48A188);
			to.WriteObject(ExceptAuthKeys);
		}
	}
}