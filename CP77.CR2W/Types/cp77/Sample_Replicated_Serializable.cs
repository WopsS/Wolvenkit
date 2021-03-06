using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Sample_Replicated_Serializable : ISerializable
	{
		[Ordinal(0)]  [RED("property")] public CBool Property { get; set; }

		public Sample_Replicated_Serializable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
