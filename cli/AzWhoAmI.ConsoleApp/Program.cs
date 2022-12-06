// See https://aka.ms/new-console-template for more information
using AzWhoAmI.ConsoleApp;
using Azure.Cli.Commands;
using Azure.Cli.Commands.Ad;
using Spectre.Console;

var image = new CanvasImage(AzWhoAmI.ConsoleApp.Properties.Resources.azure_logo);
image.MaxWidth(26);
AnsiConsole.Write(image);

AccountCommands accountCommand = new();
AdCommands sps = new();

await OutputProvider.PrintCurrentAccountAsync();
AnsiConsole.MarkupLine("");

await OutputProvider.PrintDomainsAsync();
AnsiConsole.MarkupLine("");

await OutputProvider.PrintSubscriptionsAsync();

AnsiConsole.MarkupLine("");
AnsiConsole.MarkupLine("Find the latest version at:");
AnsiConsole.MarkupLine("[link blue]https://github.com/martijnvanschie/az-whoami[/]");
