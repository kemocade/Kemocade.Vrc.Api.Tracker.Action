using CommandLine;

namespace Kemocade.Vrc.Api.Tracker.Action;

internal record ActionInputs
{
    [Option('W', "workspace", Required = true)]
    public string Workspace { get; init; } = null!;

    [Option('O', "output", Required = true)]
    public string Output { get; init; } = null!;

    [Option('u', "username", Required = true)]
    public string Username { get; init; } = null!;

    [Option('p', "password", Required = true)]
    public string Password { get; init; } = null!;

    [Option('k', "key", Required = true)]
    public string Key { get; init; } = null!;

    [Option('w', "worlds")]
    public string Worlds { get; init; } = null!;

    [Option('g', "groups")]
    public string Groups { get; init; } = null!;

    [Option('b', "bot")]
    public string Bot { get; init; } = null!;

    [Option('d', "discords")]
    public string Discords { get; init; } = null!;

    [Option('c', "channels")]
    public string Channels { get; init; } = null!;
}