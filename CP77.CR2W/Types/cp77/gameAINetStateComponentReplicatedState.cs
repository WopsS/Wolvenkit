using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameAINetStateComponentReplicatedState : netIComponentState
	{
		[Ordinal(0)]  [RED("replBehaviorState")] public gameNetAIState ReplBehaviorState { get; set; }
		[Ordinal(1)]  [RED("replDefenseMode")] public gameNetAIState ReplDefenseMode { get; set; }
		[Ordinal(2)]  [RED("replHighLevelState")] public gameNetAIState ReplHighLevelState { get; set; }
		[Ordinal(3)]  [RED("replHitReactionModeState")] public gameNetAIState ReplHitReactionModeState { get; set; }
		[Ordinal(4)]  [RED("replLocomotionMode")] public gameNetAIState ReplLocomotionMode { get; set; }
		[Ordinal(5)]  [RED("replPhaseState")] public gameNetAIState ReplPhaseState { get; set; }
		[Ordinal(6)]  [RED("replStanceState")] public gameNetAIState ReplStanceState { get; set; }
		[Ordinal(7)]  [RED("replUpperBodyState")] public gameNetAIState ReplUpperBodyState { get; set; }

		public gameAINetStateComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
