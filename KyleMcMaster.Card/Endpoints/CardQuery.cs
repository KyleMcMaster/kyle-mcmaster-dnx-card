using TimeWarp.Nuru;
using TimeWarp.Terminal;

[NuruRoute("", Description = "Display the full business card")]
public sealed class CardQuery : IQuery<Unit>
{
  public sealed class Handler : IQueryHandler<CardQuery, Unit>
  {
    public ValueTask<Unit> Handle(CardQuery query, CancellationToken ct)
    {
      var terminal = TimeWarpTerminal.Default;

      string header = $"Hi, I'm {Profile.Name}! 👋".BrightBlue();

      terminal.WritePanel(panel => panel
        .Content(header.White().Bold())
        .Border(BorderStyle.None)
        .Padding(2, 1));

      terminal.WriteLine();

      string body = Profile.Title.White().Bold() + "\n" +
        Profile.Location.Gray() + "\n\n" +
        "Website 🌐".Link(Profile.Website).Yellow().Bold() + $": {Profile.Website}" + "\n" +
        "GitHub 🧑‍💻".Link(Profile.GitHub).Yellow().Bold() + $": {Profile.GitHub}" + "\n" +
        "LinkedIn 💼".Link(Profile.LinkedIn).Yellow().Bold() + $": {Profile.LinkedIn}" + "\n" +
        "X (Twitter) 🐦".Link(Profile.Twitter).Yellow().Bold() + $": {Profile.Twitter}" + "\n" +
        "Bluesky 🦋".Link(Profile.Bluesky).Yellow().Bold() + $": {Profile.Bluesky}";

      terminal.WritePanel(panel => panel
        .Header("Digital Business Card".BrightBlue().Bold())
        .Content(body)
        .Border(BorderStyle.Rounded)
        .BorderColor("\x1b[34m")
        .Padding(2, 1));

      terminal.WriteLine();

      terminal.WriteLine("Thanks for stopping by! ✨ Feel free to reach out on any of the links above.".Gray());

      return default;
    }
  }
}
