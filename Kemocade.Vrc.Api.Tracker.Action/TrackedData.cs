namespace Kemocade.Vrc.Api.Tracker.Action;

internal record TrackedData
{
    public required long FileTimeUtc { get; init; }
    public required string[] VrcUserDisplayNames { get; init; }
    public required Dictionary<string, TrackedVrcWorld> VrcWorldsById { get; init; }
    public required Dictionary<string, TrackedVrcGroup> VrcGroupsById { get; init; }
    public required Dictionary<string, TrackedDiscordServer> DiscordServersById { get; init; }

    internal record TrackedVrcWorld
    {
        public required string Name { get; init; }
        public required int Visits { get; init; }
        public required int Favorites { get; init; }
        public required int Occupants { get; init; }
    }

    internal record TrackedVrcGroup
    {
        public required string Name { get; init; }
        public required int[] VrcUsers { get; init; }
        public required Dictionary<string, TrackedVrcGroupRole> Roles { get; init; }

        internal record TrackedVrcGroupRole
        {
            public required string Name { get; init; }
            public required bool IsAdmin { get; init; }
            public required bool IsModerator { get; init; }
            public required int[] VrcUsers { get; init; }
        }
    }

    internal record TrackedDiscordServer
    {
        public required string Name { get; init; }
        public required int MemberCount { get; init; }
        public required int[] VrcUsers { get; init; }
        public required Dictionary<string, TrackedDiscordServerRole> Roles { get; init; }

        internal record TrackedDiscordServerRole
        {
            public required string Name { get; init; }
            public required bool IsAdmin { get; init; }
            public required bool IsModerator { get; init; }
            public required int[] VrcUsers { get; init; }
        }
    }
}
