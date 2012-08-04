// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'DebugInClientMessage.xml' the '27/06/2012 15:54:56'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class DebugInClientMessage : NetworkMessage
	{
		public const uint Id = 6028;
		public override uint MessageId
		{
			get
			{
				return 6028;
			}
		}
		
		public sbyte level;
		public string message;
		
		public DebugInClientMessage()
		{
		}
		
		public DebugInClientMessage(sbyte level, string message)
		{
			this.level = level;
			this.message = message;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(level);
			writer.WriteUTF(message);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			level = reader.ReadSByte();
			if ( level < 0 )
			{
				throw new Exception("Forbidden value on level = " + level + ", it doesn't respect the following condition : level < 0");
			}
			message = reader.ReadUTF();
		}
	}
}