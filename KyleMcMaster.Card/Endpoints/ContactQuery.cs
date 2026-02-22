using TimeWarp.Nuru;
using TimeWarp.Terminal;

[NuruRoute("contact", Description = "Display contact and social links")]
public sealed class ContactQuery : IQuery<Unit>
{
  public sealed class Handler : IQueryHandler<ContactQuery, Unit>
  {
    public ValueTask<Unit> Handle(ContactQuery query, CancellationToken ct)
    {
      var terminal = TimeWarpTerminal.Default;

      string body = "Website 🌐".Link(Profile.Website).Yellow().Bold() + $": {Profile.Website}" + "\n" +
        "GitHub 🧑‍💻".Link(Profile.GitHub).Yellow().Bold() + $": {Profile.GitHub}" + "\n" +
        "LinkedIn 💼".Link(Profile.LinkedIn).Yellow().Bold() + $": {Profile.LinkedIn}" + "\n" +
        "X (Twitter) 🐦".Link(Profile.Twitter).Yellow().Bold() + $": {Profile.Twitter}" + "\n" +
        "Bluesky 🦋".Link(Profile.Bluesky).Yellow().Bold() + $": {Profile.Bluesky}";

      terminal.WritePanel(panel => panel
        .Header("Contact & Social Links".BrightBlue().Bold())
        .Content(body)
        .Border(BorderStyle.Rounded)
        .BorderColor("\x1b[34m")
        .Padding(2, 1));

      terminal.WriteLine();

      return default;
    }
  }
}
