// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'IgnoredInformations.xml' the '27/06/2012 15:55:16'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Types
{
	public class IgnoredInformations : AbstractContactInformations
	{
		public const uint Id = 106;
		public override short TypeId
		{
			get
			{
				return 106;
			}
		}
		
		
		public IgnoredInformations()
		{
		}
		
		public IgnoredInformations(int accountId, string accountName)
			 : base(accountId, accountName)
		{
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
		}
	}
}