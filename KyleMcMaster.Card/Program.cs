using TimeWarp.Nuru;

// Basic profile data for Kyle McMaster
string name = "Kyle McMaster";
string title = "Software Engineer & .NET Enthusiast 💻";
string location = "Cleveland, Ohio, USA 🌆";

// Social links – tweak these as needed
string website = "https://kylemcmaster.com";
string github = "https://github.com/kylemcmaster";
string linkedin = "https://www.linkedin.com/in/kylerobertmcmaster";
string twitter = "https://x.com/kylemcmaster";
string bluesky = "https://bsky.app/profile/kylemcmaster.com";
// Create terminal instance
var terminal = NuruTerminal.Default;

string header = $"Hi, I'm {name}! 👋".BrightBlue();

// Header panel
terminal.WritePanel(panel => panel
  .Content(header.White().Bold())
  .Border(BorderStyle.None)
  .Padding(2, 1));

terminal.WriteLine();

string body = title.White().Bold() + "\n" +
  location.Gray() + "\n\n" +
  "Website 🌐".Link(website).Yellow().Bold() + $": {website}" + "\n" +
  "GitHub 🧑‍💻".Link(github).Yellow().Bold() + $": {github}" + "\n" +
  "LinkedIn 💼".Link(linkedin).Yellow().Bold() + $": {linkedin}" + "\n" +
  "X (Twitter) 🐦".Link(twitter).Yellow().Bold() + $": {twitter}" + "\n" +
  "Bluesky 🦋".Link(bluesky).Yellow().Bold() + $": {bluesky}";

// Business card panel
terminal.WritePanel(panel => panel
  .Header("Digital Business Card".BrightBlue().Bold())
  .Content(body)
  .Border(BorderStyle.Rounded)
  .BorderColor("\x1b[34m")
  .Padding(2, 1));

terminal.WriteLine();

// A short closing note
terminal.WriteLine("Thanks for stopping by! ✨ Feel free to reach out on any of the links above.".Gray());
