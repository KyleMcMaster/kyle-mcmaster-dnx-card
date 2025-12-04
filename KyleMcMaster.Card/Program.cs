using Spectre.Console;

// Basic profile data for Kyle McMaster
var name = "Kyle McMaster";
var title = "Software Engineer & .NET Enthusiast 💻";
var location = "Cleveland, Ohio, USA 🌆";

// Social links – tweak these as needed
var website = "https://kylemcmaster.com";
var github = "https://github.com/kylemcmaster";
var linkedin = "https://www.linkedin.com/in/kylerobertmcmaster";
var twitter = "https://x.com/kylemcmaster";
var bluesky = "https://bsky.app/profile/kylemcmaster.com";

AnsiConsole.Clear();

// Header
var rule = new Rule($"[bold dodgerblue2]Hi, I'm {name}! 👋[/]")
{
	Style = Style.Parse("grey50")
};

AnsiConsole.Write(rule);
AnsiConsole.WriteLine();

// Create a panel that acts like a business card
var card = new Panel(
		new Markup($"[bold white]{title}[/]\n[grey70]{location}[/]\n\n" +
			   $"[bold yellow]Website 🌐[/]: [link={website}]{website}[/]\n" +
			   $"[bold yellow]GitHub 🧑‍💻[/]: [link={github}]{github}[/]\n" +
			   $"[bold yellow]LinkedIn 💼[/]: [link={linkedin}]{linkedin}[/]\n" +
			   $"[bold yellow]X (Twitter) 🐦[/]: [link={twitter}]{twitter}[/]\n" +
			   $"[bold yellow]Bluesky 🦋[/]: [link={bluesky}]{bluesky}[/]")
	)
{
	Border = BoxBorder.Rounded,
	BorderStyle = new Style(Color.DodgerBlue2),
	Padding = new Padding(2, 1),
	Header = new PanelHeader("[bold dodgerblue2]Digital Business Card[/]", Justify.Center)
};

AnsiConsole.Write(card);
AnsiConsole.WriteLine();

// A short closing note
AnsiConsole.MarkupLine("[grey70]Thanks for stopping by! ✨ Feel free to reach out on any of the links above.[/]");
