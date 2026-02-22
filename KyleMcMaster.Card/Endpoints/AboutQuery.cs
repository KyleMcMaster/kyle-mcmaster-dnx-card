using TimeWarp.Nuru;
using TimeWarp.Terminal;

[NuruRoute("about", Description = "Display name, title, and location")]
public sealed class AboutQuery : IQuery<Unit>
{
  public sealed class Handler : IQueryHandler<AboutQuery, Unit>
  {
    public ValueTask<Unit> Handle(AboutQuery query, CancellationToken ct)
    {
      var terminal = TimeWarpTerminal.Default;

      string body = Profile.Name.White().Bold() + "\n" +
        Profile.Title.White().Bold() + "\n" +
        Profile.Location.Gray();

      terminal.WritePanel(panel => panel
        .Header("About".BrightBlue().Bold())
        .Content(body)
        .Border(BorderStyle.Rounded)
        .BorderColor("\x1b[34m")
        .Padding(2, 1));

      terminal.WriteLine();

      return default;
    }
  }
}
