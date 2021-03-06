using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorPatrolActionNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(0)]  [RED("dependentWorkspotData")] public CHandle<AIArgumentMapping> DependentWorkspotData { get; set; }
		[Ordinal(1)]  [RED("lookAtTarget")] public CHandle<AIArgumentMapping> LookAtTarget { get; set; }
		[Ordinal(2)]  [RED("path")] public CHandle<AIArgumentMapping> Path { get; set; }
		[Ordinal(3)]  [RED("patrolProgress")] public CHandle<AIArgumentMapping> PatrolProgress { get; set; }
		[Ordinal(4)]  [RED("playStartAnimation")] public CHandle<AIArgumentMapping> PlayStartAnimation { get; set; }
		[Ordinal(5)]  [RED("startFromClosestPoint")] public CHandle<AIArgumentMapping> StartFromClosestPoint { get; set; }
		[Ordinal(6)]  [RED("workspotData")] public CHandle<AIArgumentMapping> WorkspotData { get; set; }

		public AIbehaviorPatrolActionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
